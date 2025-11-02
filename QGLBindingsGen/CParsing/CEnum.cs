namespace QGLBindingsGen.CParsing;

internal class CEnum
{
    public string Name;
    public Dictionary<string, string> Values;

    public CEnum(string name, string rawValues)
    {
        Name = name;
        Values = [];

        foreach (string line in rawValues.Split('\n'))
        {
            string l = line.Trim();
            if (l.StartsWith("//") || l.StartsWith("/*") || l.StartsWith('!') || l.StartsWith('*'))
                continue;
            l = CParser.CommentPattern().Replace(l, "").Trim();
            
            string[] parts = l.Split([',', '='], StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0)
                continue;
            string valueName = parts[0].Trim();
            string value = parts.Length > 1 ? parts[1].Trim() : "";
            Values[valueName] = value;
        }
    }
}
