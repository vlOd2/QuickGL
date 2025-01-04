// MIT License
// 
// Copyright (c) 2025 vlOd
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Runtime.InteropServices;

namespace QuickGLNS.Internal
{
    internal class UnixGLFWLoader : IGLFWLoader
    {
        private const int RTLD_NOW = 0x02;
        private const int RTLD_GLOBAL = 0x100;
        private const string LIB_NAME = "libglfw.so.3";
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