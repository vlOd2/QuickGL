using QGLBindingsGen.CParsing;

namespace QGLBindingsGen.GLRegistry;

internal class GLFeature
{
    public string Name;
    public bool IsExtension;
    public bool IsES;
    public CParserContext ParserContext;

    public GLFeature(string name, bool isExtension, bool isEs, CParserContext ctx)
    {
        Name = name;
        IsExtension = isExtension;
        IsES = isEs;
        ParserContext = ctx;
    }
}
