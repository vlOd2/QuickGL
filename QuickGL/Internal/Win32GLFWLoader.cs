namespace QuickGLNS.Internal
{
    internal class Win32GLFWLoader : IGLFWLoader
    {
        public nint GetProcAddress(string name)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}