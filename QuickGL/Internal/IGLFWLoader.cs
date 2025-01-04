namespace QuickGLNS.Internal
{
    internal interface IGLFWLoader : IDisposable
    {
        nint GetProcAddress(string name);
    }
}