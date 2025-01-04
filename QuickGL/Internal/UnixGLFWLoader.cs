using System.Runtime.InteropServices;

namespace QuickGLNS.Internal
{
    internal class UnixGLFWLoader : IGLFWLoader
    {
        private const int RTLD_NOW = 0x02;
        private const int RTLD_GLOBAL = 0x100;
        private const string LIB_NAME = "/usr/local/lib/libglfw.so.3";
        private nint handle;
        
        [DllImport("libdl.so.2")]
        private static extern nint dlopen([MarshalAs(UnmanagedType.LPStr)] string filename, int flag);

        [DllImport("libdl.so.2")]
        private static extern nint dlsym(nint handle, [MarshalAs(UnmanagedType.LPStr)] string symbol);
        
        [DllImport("libdl.so.2")]
        private static extern int dlclose(nint handle);

        public UnixGLFWLoader()
        {
            handle = dlopen(LIB_NAME, RTLD_NOW | RTLD_GLOBAL);
            if (handle == nint.Zero)
                throw new Exception($"Could not load {LIB_NAME}");
        }

        public nint GetProcAddress(string name) => dlsym(handle, name);
        
        public void Dispose()
        {
            if (handle == nint.Zero) return;
            dlclose(handle);
            handle = nint.Zero;
        }
    }
}