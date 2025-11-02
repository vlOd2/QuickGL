using System.Text.RegularExpressions;

namespace QGLBindingsGen.CParsing;

internal static partial class CArgParser
{
    #region Patterns
    [GeneratedRegex(@"^([a-zA-Z0-9_ *]+)\(\s*?\*\s*([a-zA-Z0-9_]+)\)\((.*)\)\s*$")]
    private static partial Regex InlineFuncPtrPattern();
    #endregion

    private static List<string> SplitArgs(string args)
    {
        List<string> result = [];
        int level = 0;
        int last = 0;

        for (int i = 0; i < args.Length; i++)
        {
            char c = args[i];
            if (c == '(') 
                level++;
            else if (c == ')') 
                level--;
            else if (c == ',' && level == 0)
            {
                result.Add(args[last..i].Trim());
                last = i + 1;
            }
        }

        if (last < args.Length)
            result.Add(args[last..].Trim());

        return result;
    }

    public static Dictionary<string, CType> Parse(CParserContext ctx, string defPrefix, string rawArgs, bool convertCallbacks)
    {
        List<string> _rawArgs = SplitArgs(rawArgs.Trim());
        Dictionary<string, CType> args = [];
        int namelessArgs = 0;

        foreach (string arg in _rawArgs)
        {
            if (_rawArgs.Count == 1 && arg == "void")
                return [];

            if (InlineFuncPtrPattern().Match(arg) is Match match && match.Success)
            {
                string name = match.Groups[2].Value.Trim();
                string retType = match.Groups[1].Value.Trim();
                string fArgs = match.Groups[3].Value.Trim();
                string def = $"{defPrefix}_{fArgs.Split(' ').Length}_{name}";

                if (!ctx.CheckSymbol(def))
                    throw new Exception($"Func ptr def conflict: {def}");

                ctx.Definitions.Add(new(def, new CFunction(ctx, def, retType, fArgs)));
                args[name] = convertCallbacks ? new CType("nint", 0, def) : new(def);
            }
            else
            {
                string[] split = arg.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                string rawType = split.Length > 1 ? string.Join(' ', split[..^1]).Trim() : split[0].Trim();
                string rawName = split.Length > 1 ? split[^1].Trim() : null;
                (CType type, string name) = ctx.TypeConv.Convert(rawType, rawName, convertCallbacks);
                if (string.IsNullOrWhiteSpace(name)) 
                    name = $"arg{namelessArgs++}";
                args[name] = type;
            }
        }

        return args;
    }
}
