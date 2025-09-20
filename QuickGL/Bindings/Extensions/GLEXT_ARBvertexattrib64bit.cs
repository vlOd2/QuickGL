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

// Bindings generated at 2025-09-20 18:58:20.124736
namespace QuickGLNS.Bindings.Extensions;

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
    public static void glVertexAttribL1d(uint index, double x) { QGLFeature.VerifyFunc((nint)_glVertexAttribL1d); _glVertexAttribL1d(index, x); }
    internal static delegate* unmanaged<uint, double, void> _glVertexAttribL1d = null;
    
    public static void glVertexAttribL2d(uint index, double x, double y) { QGLFeature.VerifyFunc((nint)_glVertexAttribL2d); _glVertexAttribL2d(index, x, y); }
    internal static delegate* unmanaged<uint, double, double, void> _glVertexAttribL2d = null;
    
    public static void glVertexAttribL3d(uint index, double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glVertexAttribL3d); _glVertexAttribL3d(index, x, y, z); }
    internal static delegate* unmanaged<uint, double, double, double, void> _glVertexAttribL3d = null;
    
    public static void glVertexAttribL4d(uint index, double x, double y, double z, double w) { QGLFeature.VerifyFunc((nint)_glVertexAttribL4d); _glVertexAttribL4d(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, double, double, double, double, void> _glVertexAttribL4d = null;
    
    public static void glVertexAttribL1dv(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribL1dv); _glVertexAttribL1dv(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL1dv = null;
    
    public static void glVertexAttribL2dv(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribL2dv); _glVertexAttribL2dv(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL2dv = null;
    
    public static void glVertexAttribL3dv(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribL3dv); _glVertexAttribL3dv(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL3dv = null;
    
    public static void glVertexAttribL4dv(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribL4dv); _glVertexAttribL4dv(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL4dv = null;
    
    public static void glVertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glVertexAttribLPointer); _glVertexAttribLPointer(index, size, type, stride, pointer); }
    internal static delegate* unmanaged<uint, int, uint, int, void*, void> _glVertexAttribLPointer = null;
    
    public static void glGetVertexAttribLdv(uint index, uint pname, double* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribLdv); _glGetVertexAttribLdv(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glGetVertexAttribLdv = null;
     #endregion
    
    internal static void Load()
    {
        _glVertexAttribL1d = (delegate* unmanaged<uint, double, void>)QuickGL.GetGLProcAddress("glVertexAttribL1d");
        _glVertexAttribL2d = (delegate* unmanaged<uint, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttribL2d");
        _glVertexAttribL3d = (delegate* unmanaged<uint, double, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttribL3d");
        _glVertexAttribL4d = (delegate* unmanaged<uint, double, double, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttribL4d");
        _glVertexAttribL1dv = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttribL1dv");
        _glVertexAttribL2dv = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttribL2dv");
        _glVertexAttribL3dv = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttribL3dv");
        _glVertexAttribL4dv = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttribL4dv");
        _glVertexAttribLPointer = (delegate* unmanaged<uint, int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glVertexAttribLPointer");
        _glGetVertexAttribLdv = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribLdv");
    }
    
    internal static void Unload()
    {
        _glVertexAttribL1d = null;
        _glVertexAttribL2d = null;
        _glVertexAttribL3d = null;
        _glVertexAttribL4d = null;
        _glVertexAttribL1dv = null;
        _glVertexAttribL2dv = null;
        _glVertexAttribL3dv = null;
        _glVertexAttribL4dv = null;
        _glVertexAttribLPointer = null;
        _glGetVertexAttribLdv = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_vertex_attrib_64bit", true, false);
}
