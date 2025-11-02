using System.Text.RegularExpressions;

namespace QGLBindingsGen.CParsing;

internal partial class CFunction
{
    #region Patterns
    [GeneratedRegex(@"^\s*([a-zA-Z0-9_ ]+\**?) (\**?[a-zA-Z0-9_]+)\((.*)\)\s*?;")]
    private static partial Regex FuncPattern();
    #endregion
    public readonly string Name;
    public readonly CType ReturnType;
    public readonly Dictionary<string, CType> Args;

    public CFunction(CParserContext ctx, string name, string returnType, string args)
    {
        (ReturnType, Name) = ctx.TypeConv.Convert(returnType, name, false);
        Args = CArgParser.Parse(ctx, name, args, false);
    }

    public static CFunction Parse(CParserContext ctx, string line)
    {
        Match match = FuncPattern().Match(line);

        if (!match.Success)
            return null;

        string name = match.Groups[2].Value.Trim();
        string returnType = match.Groups[1].Value.Trim();
        string args = match.Groups[3].Value.Trim();

        return new CFunction(ctx, name, returnType, args);
    }
}
