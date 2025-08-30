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

// Bindings generated at 2025-08-30 15:45:08.529588
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_get_program_binary", true, false)]
public static unsafe class GLEXT_ARBgetprogrambinary
{
    #region Enums
    public const int GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
    public const int GL_PROGRAM_BINARY_LENGTH = 0x8741;
    public const int GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
    public const int GL_PROGRAM_BINARY_FORMATS = 0x87FF;
    #endregion
    
    #region Commands
    public static void glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary) { QGLNativeAPI.Verify((nint)_glGetProgramBinary); _glGetProgramBinary(program, bufSize, length, binaryFormat, binary); }
    [QGLNativeAPI("glGetProgramBinary")] internal static delegate* unmanaged<uint, int, int*, uint*, void*, void> _glGetProgramBinary = null;
    
    public static void glProgramBinary(uint program, uint binaryFormat, void* binary, int length) { QGLNativeAPI.Verify((nint)_glProgramBinary); _glProgramBinary(program, binaryFormat, binary, length); }
    [QGLNativeAPI("glProgramBinary")] internal static delegate* unmanaged<uint, uint, void*, int, void> _glProgramBinary = null;
    
    public static void glProgramParameteri(uint program, uint pname, int value) { QGLNativeAPI.Verify((nint)_glProgramParameteri); _glProgramParameteri(program, pname, value); }
    [QGLNativeAPI("glProgramParameteri")] internal static delegate* unmanaged<uint, uint, int, void> _glProgramParameteri = null;
     #endregion
}
