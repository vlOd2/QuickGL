using System.Runtime.InteropServices;

namespace QuickGLNS.Internal
{
    internal class Win32GLFWLoader : IGLFWLoader
    {
        private const string LIB_NAME = "glfw3.dll";
        private nint handle;
        
        [DllImport("kernel32.dll")]
        private static extern nint LoadLibraryA(
            [In][MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeLibrary(nint hLibModule);

        [DllImport("kernel32.dll")]
        private static extern nint GetProcAddress(nint hModule, string lpProcName);

        public Win32GLFWLoader()
        {
            handle = LoadLibraryA(LIB_NAME);
            if (handle == nint.Zero)
                throw new Exception($"Could not load {LIB_NAME}");
        }

        public nint GetProcAddress(string name) => GetProcAddress(handle, name);

        public void Dispose()
        {
            if (handle == nint.Zero) return;
            FreeLibrary(handle);
            handle = nint.Zero;
        }
    }
}