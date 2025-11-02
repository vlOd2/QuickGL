using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace QGLBindingsGen.CParsing;

internal static partial class CParser
{
    [GeneratedRegex(@"\s*?\/\/.*?$")]
    public static partial Regex CommentPattern();

    private static async Task<List<string>> PrepareFile(string[] rawLines, CParserContext ctx) => await Task.Run(() =>
    {
        List<string> lines = [];

        foreach (string rawLine in rawLines)
        {
            string line = rawLine.Trim();

            if (string.IsNullOrWhiteSpace(line))
                continue;
            if (line.StartsWith("//") || (line.StartsWith("/*") && line.EndsWith("*/")))
                continue;

            foreach (string word in ctx.RemoveWords)
            {
                line = line.Replace($" {word} ", " ").Trim();
                line = line.Replace($" {word}", " ").Trim();
                line = line.Replace($"{word} ", " ").Trim();
            }

            lines.Add(line);
        }

        return lines;
    });

    private static async Task ParseConstants(List<string> lines, CParserContext ctx) => await Task.Run(() =>
    {
        foreach (string line in lines)
        {
            CConstant cconst = CConstant.Parse(line);
            if (cconst != null)
            {
                if (!ctx.CheckSymbol(cconst.Name))
                    continue;
                ctx.Constants.Add(cconst);
                continue;
            }
            CDefinition def = CDefinition.ParseOpaqueStruct(line);
            if (def != null && ctx.CheckSymbol(def.Name))
                ctx.Definitions.Add(def);
        }
    });

    private static async Task<string[]> ParseStructsLazy(List<string> lines, CParserContext ctx) => await Task.Run(() =>
    {
        string[] structNames = CStruct.ParseAllNames(lines);
        foreach (CDefinition def in structNames.Select(name => new CDefinition(name, null)))
        {
            if (!ctx.CheckSymbol(def.Name))
                continue;
            ctx.Definitions.Add(def);
        }
        return structNames;
    });

    private static async Task ParseCallbacks(List<string> lines, CParserContext ctx) => await Task.Run(() =>
    {
        foreach (string line in lines)
        {
            CDefinition def = CDefinition.ParseCallback(ctx, line);
            if (def == null || !ctx.CheckSymbol(def.Name))
                continue;
            ctx.Definitions.Add(def);
        }
    });

    private static async Task ParseStructs(List<string> lines, string[] structNames, CParserContext ctx) => await Task.Run(() => 
    {
        List<CDefinition> defs = [.. ctx.Definitions];
        ctx.Definitions.Clear();

        foreach (CDefinition def in defs)
        {
            if (structNames.Contains(def.Name))
            {
                ctx.RemoveSymbol(def.Name);
                continue;
            }
            ctx.Definitions.Add(def);
        }

        foreach (CStruct s in CStruct.ParseAll(ctx, lines))
        {
            if (!ctx.CheckSymbol(s.Name))
                continue;
            ctx.Structs.Add(s);
        }
    });

    private static async Task ParseFunctions(List<string> lines, CParserContext ctx) => await Task.Run(() => 
    {
        foreach (string line in lines)
        {
            CFunction func = CFunction.Parse(ctx, line);
            if (func == null || !ctx.CheckSymbol(func.Name))
                continue;
            ctx.Functions.Add(func);
        }
    });

    public static async Task ParseFile(string[] rawLines, CParserContext ctx, Action<List<string>> customParser = null)
    {
        List<string> lines = await TaskRunner.Run("Preparing file", PrepareFile(rawLines, ctx));
        customParser?.Invoke(lines);

        ctx.TypeConv.BeginScheduleUnknown();
        await TaskRunner.Run("Parsing constants and opaque structs", ParseConstants(lines, ctx));
        string[] structNames = await TaskRunner.Run("Parsing structs (lazy)", ParseStructsLazy(lines, ctx));
        await TaskRunner.Run("Parsing callbacks", ParseCallbacks(lines, ctx));
        await TaskRunner.Run("Parsing structs", ParseStructs(lines, structNames, ctx));
        ctx.TypeConv.EndScheduleUnknown();

        await TaskRunner.Run("Parsing functions", ParseFunctions(lines, ctx));
    }
}
