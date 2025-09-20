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

using QuickGLNS.Internal;

// Bindings generated at 2025-09-20 18:58:19.887948
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBgetprogrambinary
{
    #region Enums
    public const int GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
    public const int GL_PROGRAM_BINARY_LENGTH = 0x8741;
    public const int GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
    public const int GL_PROGRAM_BINARY_FORMATS = 0x87FF;
    #endregion
    
    #region Commands
    public static void glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary) { QGLFeature.VerifyFunc((nint)_glGetProgramBinary); _glGetProgramBinary(program, bufSize, length, binaryFormat, binary); }
    internal static delegate* unmanaged<uint, int, int*, uint*, void*, void> _glGetProgramBinary = null;
    
    public static void glProgramBinary(uint program, uint binaryFormat, void* binary, int length) { QGLFeature.VerifyFunc((nint)_glProgramBinary); _glProgramBinary(program, binaryFormat, binary, length); }
    internal static delegate* unmanaged<uint, uint, void*, int, void> _glProgramBinary = null;
    
    public static void glProgramParameteri(uint program, uint pname, int value) { QGLFeature.VerifyFunc((nint)_glProgramParameteri); _glProgramParameteri(program, pname, value); }
    internal static delegate* unmanaged<uint, uint, int, void> _glProgramParameteri = null;
     #endregion
    
    internal static void Load()
    {
        _glGetProgramBinary = (delegate* unmanaged<uint, int, int*, uint*, void*, void>)QuickGL.GetGLProcAddress("glGetProgramBinary");
        _glProgramBinary = (delegate* unmanaged<uint, uint, void*, int, void>)QuickGL.GetGLProcAddress("glProgramBinary");
        _glProgramParameteri = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glProgramParameteri");
    }
    
    internal static void Unload()
    {
        _glGetProgramBinary = null;
        _glProgramBinary = null;
        _glProgramParameteri = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_get_program_binary", true, false);
}
