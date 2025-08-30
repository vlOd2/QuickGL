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

// Bindings generated at 2025-08-30 15:45:08.775147
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_vertex_attrib_64bit", true, false)]
public static unsafe class GLEXT_ARBvertexattrib64bit
{
    #region Enums
    public const int GL_RGB32I = 0x8D83;
    public const int GL_DOUBLE_VEC2 = 0x8FFC;
    public const int GL_DOUBLE_VEC3 = 0x8FFD;
    public const int GL_DOUBLE_VEC4 = 0x8FFE;
    public const int GL_DOUBLE_MAT2 = 0x8F46;
    public const int GL_DOUBLE_MAT3 = 0x8F47;
    public const int GL_DOUBLE_MAT4 = 0x8F48;
    public const int GL_DOUBLE_MAT2x3 = 0x8F49;
    public const int GL_DOUBLE_MAT2x4 = 0x8F4A;
    public const int GL_DOUBLE_MAT3x2 = 0x8F4B;
    public const int GL_DOUBLE_MAT3x4 = 0x8F4C;
    public const int GL_DOUBLE_MAT4x2 = 0x8F4D;
    public const int GL_DOUBLE_MAT4x3 = 0x8F4E;
    #endregion
    
    #region Commands
    public static void glVertexAttribL1d(uint index, double x) { QGLNativeAPI.Verify((nint)_glVertexAttribL1d); _glVertexAttribL1d(index, x); }
    [QGLNativeAPI("glVertexAttribL1d")] internal static delegate* unmanaged<uint, double, void> _glVertexAttribL1d = null;
    
    public static void glVertexAttribL2d(uint index, double x, double y) { QGLNativeAPI.Verify((nint)_glVertexAttribL2d); _glVertexAttribL2d(index, x, y); }
    [QGLNativeAPI("glVertexAttribL2d")] internal static delegate* unmanaged<uint, double, double, void> _glVertexAttribL2d = null;
    
    public static void glVertexAttribL3d(uint index, double x, double y, double z) { QGLNativeAPI.Verify((nint)_glVertexAttribL3d); _glVertexAttribL3d(index, x, y, z); }
    [QGLNativeAPI("glVertexAttribL3d")] internal static delegate* unmanaged<uint, double, double, double, void> _glVertexAttribL3d = null;
    
    public static void glVertexAttribL4d(uint index, double x, double y, double z, double w) { QGLNativeAPI.Verify((nint)_glVertexAttribL4d); _glVertexAttribL4d(index, x, y, z, w); }
    [QGLNativeAPI("glVertexAttribL4d")] internal static delegate* unmanaged<uint, double, double, double, double, void> _glVertexAttribL4d = null;
    
    public static void glVertexAttribL1dv(uint index, double* v) { QGLNativeAPI.Verify((nint)_glVertexAttribL1dv); _glVertexAttribL1dv(index, v); }
    [QGLNativeAPI("glVertexAttribL1dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL1dv = null;
    
    public static void glVertexAttribL2dv(uint index, double* v) { QGLNativeAPI.Verify((nint)_glVertexAttribL2dv); _glVertexAttribL2dv(index, v); }
    [QGLNativeAPI("glVertexAttribL2dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL2dv = null;
    
    public static void glVertexAttribL3dv(uint index, double* v) { QGLNativeAPI.Verify((nint)_glVertexAttribL3dv); _glVertexAttribL3dv(index, v); }
    [QGLNativeAPI("glVertexAttribL3dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL3dv = null;
    
    public static void glVertexAttribL4dv(uint index, double* v) { QGLNativeAPI.Verify((nint)_glVertexAttribL4dv); _glVertexAttribL4dv(index, v); }
    [QGLNativeAPI("glVertexAttribL4dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL4dv = null;
    
    public static void glVertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer) { QGLNativeAPI.Verify((nint)_glVertexAttribLPointer); _glVertexAttribLPointer(index, size, type, stride, pointer); }
    [QGLNativeAPI("glVertexAttribLPointer")] internal static delegate* unmanaged<uint, int, uint, int, void*, void> _glVertexAttribLPointer = null;
    
    public static void glGetVertexAttribLdv(uint index, uint pname, double* @params) { QGLNativeAPI.Verify((nint)_glGetVertexAttribLdv); _glGetVertexAttribLdv(index, pname, @params); }
    [QGLNativeAPI("glGetVertexAttribLdv")] internal static delegate* unmanaged<uint, uint, double*, void> _glGetVertexAttribLdv = null;
     #endregion
}
