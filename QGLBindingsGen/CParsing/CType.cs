namespace QGLBindingsGen.CParsing;

internal class CType
{
    public string Name;
    public int PointerCount;
    public string NativeConvertedName;

    public CType(string name, int pointerCount = 0, string nativeConvertedName = null)
    {
        Name = name;
        PointerCount = pointerCount;
        NativeConvertedName = nativeConvertedName;
    }

    public override string ToString() => Name + "".PadRight(PointerCount, '*');
}
