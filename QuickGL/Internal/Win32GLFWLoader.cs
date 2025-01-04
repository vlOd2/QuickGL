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