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

internal class OpenALLoader
{
    private const string WIN_LIB_NAME = "OpenAL32.dll";
    private const string UNIX_LIB_NAME = "libopenal.so";
    private nint handle;

    public OpenALLoader(string winLibName = null, string unixLibName = null)
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
        handle = NativeLibrary.Load(libName);
        if (handle == nint.Zero)
            throw new GLException($"Could not load {libName}");
    }

    public nint GetProcAddress(string name) => NativeLibrary.GetExport(handle, name);

    public void Dispose()
    {
        if (handle == nint.Zero) return;
        NativeLibrary.Free(handle);
        handle = nint.Zero;
    }
}