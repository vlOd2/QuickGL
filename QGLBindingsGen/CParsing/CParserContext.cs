namespace QGLBindingsGen.CParsing;

internal class CParserContext
{
    public CTypeConverter TypeConv { get; private set; }
    public readonly Dictionary<string, string> TypeMap = [];
    public readonly List<string> RemoveWords = [];
    public readonly List<CConstant> Constants = [];
    public readonly List<CDefinition> Definitions = [];
    public readonly List<CStruct> Structs = [];
    public readonly List<CEnum> Enums = [];
    public readonly List<string> UnknownTypes = [];
    public readonly List<CFunction> Functions = [];
    private readonly List<string> declaredSymbols = [];

    public CParserContext(List<string> removeWords = null)
    {
        TypeConv = new(this);
        if (removeWords != null)
            RemoveWords.AddRange(removeWords);
    }

    public bool CheckSymbol(string name)
    {
        if (declaredSymbols.Contains(name))
        {
            Logger.Warn($"Symbol \"{name}\" is already declared");
            return false;
        }
        declaredSymbols.Add(name);
        return true;
    }

    public void RemoveSymbol(string name) => declaredSymbols.Remove(name);
}
