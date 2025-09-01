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

namespace QuickGLNS.Internal;

internal class GLFWLoader
{
    private const string WIN_LIB_NAME = "glfw3.dll";
    private const string UNIX_LIB_NAME = "libglfw.so.3";
    private nint handle;

    public GLFWLoader(string winLibName = null, string unixLibName = null)
    {
        winLibName ??= WIN_LIB_NAME;
        unixLibName ??= UNIX_LIB_NAME;
        string libName;
        switch (Environment.OSVersion.Platform)
        {
            case PlatformID.Win32NT:
                libName = winLibName;
                break;
            case PlatformID.Unix:
                libName = unixLibName;
                break;
            default:
                throw new PlatformNotSupportedException();
        }
        try
        {
            handle = NativeLibrary.Load(libName);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
        if (handle == nint.Zero)
            throw new GLException($"Failed to load GLFW library: {libName}");
    }

    public nint GetProcAddress(string name)
    {
        try
        {
            return NativeLibrary.GetExport(handle, name);
        }
        catch 
        {
            return 0;
        }
    }

    public void Dispose()
    {
        if (handle == nint.Zero) return;
        NativeLibrary.Free(handle);
        handle = nint.Zero;
    }
}