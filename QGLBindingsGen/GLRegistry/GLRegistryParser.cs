using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using System.Xml;
using QGLBindingsGen.CParsing;

namespace QGLBindingsGen.GLRegistry;

internal static class GLRegistryParser
{
    private static string GetArgType(XmlNode node)
    {
        string type = node.Value ?? "";
        foreach (XmlNode child in node.ChildNodes)
        {
            if (child.Name == "name")
                continue;
            type += child.InnerText;
        }
        return type.Trim();
    }

    private static async Task<List<CConstant>> GetEnums(XmlDocument root)
    {
        List<CConstant> allEnums = [];

        await Task.Run(() =>
        {
            foreach (XmlElement enums in root.GetElementsByTagName("enums"))
            {
                foreach (XmlElement enm in enums.GetElementsByTagName("enum"))
                {
                    string name = enm.GetAttribute("name").Trim();
                    string rawValue = enm.GetAttribute("value").Trim();
                    (CType type, string value) = CTypeConverter.ProcessConstant(rawValue);
                    if (type == null)
                        continue;
                    allEnums.Add(new CConstant(name, value, type));
                }
            }
        });

        return allEnums;
    }

    private static async Task<List<CFunction>> GetCommands(CParserContext ctx, XmlDocument root)
    {
        List<CFunction> funcs = [];

        await Task.Run(() =>
        {
            foreach (XmlElement commands in root.GetElementsByTagName("commands"))
            {
                foreach (XmlElement cmd in commands.GetElementsByTagName("command"))
                {
                    XmlNode protoElem = cmd.SelectSingleNode("proto");
                    if (protoElem == null)
                        continue;

                    XmlNode nameElem = protoElem.SelectSingleNode("name");
                    if (nameElem == null)
                        continue;

                    string args = "";
                    foreach (XmlElement arg in cmd.GetElementsByTagName("param"))
                    {
                        XmlNode aNameElem = arg.SelectSingleNode("name");
                        if (aNameElem == null)
                            continue;
                        args += $"{GetArgType(arg)} {aNameElem.InnerText.Trim()}, ";
                    }
                    if (args.Length != 0)
                        args = args[..^2];

                    string name = nameElem.InnerText.Trim();
                    string retType = GetArgType(protoElem);
                    funcs.Add(new CFunction(ctx, name, retType, args));
                }
            }
        });

        return funcs;
    }

    private static async Task<CParserContext> GetFeature(CParserContext baseCtx, XmlElement feature, List<CConstant> enums, List<CFunction> commands)
    {
        CParserContext ctx = new(baseCtx.RemoveWords);
        foreach (KeyValuePair<string, string> kv in baseCtx.TypeMap)
            ctx.TypeMap[kv.Key] = kv.Value;

        await Task.Run(() =>
        {
            foreach (XmlElement require in feature.GetElementsByTagName("require"))
            {
                foreach (XmlElement enm in require.GetElementsByTagName("enum"))
                {
                    string name = enm.GetAttribute("name").Trim();
                    foreach (CConstant c in enums)
                    {
                        if (c.Name == name)
                        {
                            if (ctx.CheckSymbol(c.Name))
                                ctx.Constants.Add(c);
                            break;
                        }
                    }
                }

                foreach (XmlElement cmd in require.GetElementsByTagName("command"))
                {
                    string name = cmd.GetAttribute("name").Trim();
                    foreach (CFunction f in commands)
                    {
                        if (f.Name == name)
                        {
                            if (ctx.CheckSymbol(f.Name))
                                ctx.Functions.Add(f);
                            break;
                        }
                    }
                }
            }
        });

        return ctx;
    }

    public static async Task<List<GLFeature>> Parse(CParserContext baseCtx, string[] lines, List<string> allowedFeatures, List<string> allowedExt)
    {
        XmlDocument root = new();
        root.Load(new StringReader(string.Join('\n', lines)));

        List<CConstant> constants = await TaskRunner.Run("Parsing enums", GetEnums(root));
        List<CFunction> functions = await TaskRunner.Run("Parsing commands", GetCommands(baseCtx, root));
        List<GLFeature> features = [];

        await TaskRunner.Run("Parsing features", Task.Run(async () =>
        {
            foreach (XmlElement feature in root.GetElementsByTagName("feature"))
            {
                string name = feature.GetAttribute("name").Trim();
                string api = feature.GetAttribute("api").Trim();
                if (allowedFeatures != null && !allowedFeatures.Contains(name))
                    return;
                CParserContext ctx = await GetFeature(baseCtx, feature, constants, functions);
                features.Add(new GLFeature(name, false, api.Contains("gles"), ctx));
            }
        }));

        await TaskRunner.Run("Parsing extensions", Task.Run(async () =>
        {
            foreach (XmlElement extension in root.GetElementsByTagName("extension"))
            {
                string name = extension.GetAttribute("name").Trim();

                if (allowedExt != null && !allowedExt.Contains(name))
                {
                    foreach (string pattern in allowedExt)
                    {
                        if (!pattern.StartsWith("@/"))
                            continue;
                        if (Regex.IsMatch(name, pattern[2..]))
                            goto passed;
                    }
                    continue;
                }

            passed:
                string[] supportedAPI = extension.GetAttribute("supported").Trim().Split('|');
                bool isEs = !supportedAPI.Contains("gl") && !supportedAPI.Contains("glcore");
                CParserContext ctx = await GetFeature(baseCtx, extension, constants, functions);
                features.Add(new GLFeature(name, true, isEs, ctx));
            }
        }));

        return features;
    }
}
