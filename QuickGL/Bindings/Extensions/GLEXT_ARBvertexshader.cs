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

// Bindings generated at 2025-08-30 15:45:08.796144
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_vertex_shader", true, false)]
public static unsafe class GLEXT_ARBvertexshader
{
    #region Enums
    public const int GL_VERTEX_SHADER_ARB = 0x8B31;
    public const int GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A;
    public const int GL_MAX_VARYING_FLOATS_ARB = 0x8B4B;
    public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C;
    public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D;
    public const int GL_OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89;
    public const int GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A;
    public const int GL_MAX_VERTEX_ATTRIBS_ARB = 0x8869;
    public const int GL_MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872;
    public const int GL_MAX_TEXTURE_COORDS_ARB = 0x8871;
    public const int GL_VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642;
    public const int GL_VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643;
    public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622;
    public const int GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623;
    public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624;
    public const int GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625;
    public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A;
    public const int GL_CURRENT_VERTEX_ATTRIB_ARB = 0x8626;
    public const int GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645;
    public const int GL_FLOAT = 0x1406;
    public const int GL_FLOAT_VEC2_ARB = 0x8B50;
    public const int GL_FLOAT_VEC3_ARB = 0x8B51;
    public const int GL_FLOAT_VEC4_ARB = 0x8B52;
    public const int GL_FLOAT_MAT2_ARB = 0x8B5A;
    public const int GL_FLOAT_MAT3_ARB = 0x8B5B;
    public const int GL_FLOAT_MAT4_ARB = 0x8B5C;
    #endregion
    
    #region Commands
    public static void glVertexAttrib1fARB(uint index, float x) { QGLNativeAPI.Verify((nint)_glVertexAttrib1fARB); _glVertexAttrib1fARB(index, x); }
    [QGLNativeAPI("glVertexAttrib1fARB")] internal static delegate* unmanaged<uint, float, void> _glVertexAttrib1fARB = null;
    
    public static void glVertexAttrib1sARB(uint index, short x) { QGLNativeAPI.Verify((nint)_glVertexAttrib1sARB); _glVertexAttrib1sARB(index, x); }
    [QGLNativeAPI("glVertexAttrib1sARB")] internal static delegate* unmanaged<uint, short, void> _glVertexAttrib1sARB = null;
    
    public static void glVertexAttrib1dARB(uint index, double x) { QGLNativeAPI.Verify((nint)_glVertexAttrib1dARB); _glVertexAttrib1dARB(index, x); }
    [QGLNativeAPI("glVertexAttrib1dARB")] internal static delegate* unmanaged<uint, double, void> _glVertexAttrib1dARB = null;
    
    public static void glVertexAttrib2fARB(uint index, float x, float y) { QGLNativeAPI.Verify((nint)_glVertexAttrib2fARB); _glVertexAttrib2fARB(index, x, y); }
    [QGLNativeAPI("glVertexAttrib2fARB")] internal static delegate* unmanaged<uint, float, float, void> _glVertexAttrib2fARB = null;
    
    public static void glVertexAttrib2sARB(uint index, short x, short y) { QGLNativeAPI.Verify((nint)_glVertexAttrib2sARB); _glVertexAttrib2sARB(index, x, y); }
    [QGLNativeAPI("glVertexAttrib2sARB")] internal static delegate* unmanaged<uint, short, short, void> _glVertexAttrib2sARB = null;
    
    public static void glVertexAttrib2dARB(uint index, double x, double y) { QGLNativeAPI.Verify((nint)_glVertexAttrib2dARB); _glVertexAttrib2dARB(index, x, y); }
    [QGLNativeAPI("glVertexAttrib2dARB")] internal static delegate* unmanaged<uint, double, double, void> _glVertexAttrib2dARB = null;
    
    public static void glVertexAttrib3fARB(uint index, float x, float y, float z) { QGLNativeAPI.Verify((nint)_glVertexAttrib3fARB); _glVertexAttrib3fARB(index, x, y, z); }
    [QGLNativeAPI("glVertexAttrib3fARB")] internal static delegate* unmanaged<uint, float, float, float, void> _glVertexAttrib3fARB = null;
    
    public static void glVertexAttrib3sARB(uint index, short x, short y, short z) { QGLNativeAPI.Verify((nint)_glVertexAttrib3sARB); _glVertexAttrib3sARB(index, x, y, z); }
    [QGLNativeAPI("glVertexAttrib3sARB")] internal static delegate* unmanaged<uint, short, short, short, void> _glVertexAttrib3sARB = null;
    
    public static void glVertexAttrib3dARB(uint index, double x, double y, double z) { QGLNativeAPI.Verify((nint)_glVertexAttrib3dARB); _glVertexAttrib3dARB(index, x, y, z); }
    [QGLNativeAPI("glVertexAttrib3dARB")] internal static delegate* unmanaged<uint, double, double, double, void> _glVertexAttrib3dARB = null;
    
    public static void glVertexAttrib4fARB(uint index, float x, float y, float z, float w) { QGLNativeAPI.Verify((nint)_glVertexAttrib4fARB); _glVertexAttrib4fARB(index, x, y, z, w); }
    [QGLNativeAPI("glVertexAttrib4fARB")] internal static delegate* unmanaged<uint, float, float, float, float, void> _glVertexAttrib4fARB = null;
    
    public static void glVertexAttrib4sARB(uint index, short x, short y, short z, short w) { QGLNativeAPI.Verify((nint)_glVertexAttrib4sARB); _glVertexAttrib4sARB(index, x, y, z, w); }
    [QGLNativeAPI("glVertexAttrib4sARB")] internal static delegate* unmanaged<uint, short, short, short, short, void> _glVertexAttrib4sARB = null;
    
    public static void glVertexAttrib4dARB(uint index, double x, double y, double z, double w) { QGLNativeAPI.Verify((nint)_glVertexAttrib4dARB); _glVertexAttrib4dARB(index, x, y, z, w); }
    [QGLNativeAPI("glVertexAttrib4dARB")] internal static delegate* unmanaged<uint, double, double, double, double, void> _glVertexAttrib4dARB = null;
    
    public static void glVertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w) { QGLNativeAPI.Verify((nint)_glVertexAttrib4NubARB); _glVertexAttrib4NubARB(index, x, y, z, w); }
    [QGLNativeAPI("glVertexAttrib4NubARB")] internal static delegate* unmanaged<uint, byte, byte, byte, byte, void> _glVertexAttrib4NubARB = null;
    
    public static void glVertexAttrib1fvARB(uint index, float* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib1fvARB); _glVertexAttrib1fvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib1fvARB")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib1fvARB = null;
    
    public static void glVertexAttrib1svARB(uint index, short* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib1svARB); _glVertexAttrib1svARB(index, v); }
    [QGLNativeAPI("glVertexAttrib1svARB")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib1svARB = null;
    
    public static void glVertexAttrib1dvARB(uint index, double* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib1dvARB); _glVertexAttrib1dvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib1dvARB")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib1dvARB = null;
    
    public static void glVertexAttrib2fvARB(uint index, float* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib2fvARB); _glVertexAttrib2fvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib2fvARB")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib2fvARB = null;
    
    public static void glVertexAttrib2svARB(uint index, short* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib2svARB); _glVertexAttrib2svARB(index, v); }
    [QGLNativeAPI("glVertexAttrib2svARB")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib2svARB = null;
    
    public static void glVertexAttrib2dvARB(uint index, double* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib2dvARB); _glVertexAttrib2dvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib2dvARB")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib2dvARB = null;
    
    public static void glVertexAttrib3fvARB(uint index, float* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib3fvARB); _glVertexAttrib3fvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib3fvARB")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib3fvARB = null;
    
    public static void glVertexAttrib3svARB(uint index, short* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib3svARB); _glVertexAttrib3svARB(index, v); }
    [QGLNativeAPI("glVertexAttrib3svARB")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib3svARB = null;
    
    public static void glVertexAttrib3dvARB(uint index, double* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib3dvARB); _glVertexAttrib3dvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib3dvARB")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib3dvARB = null;
    
    public static void glVertexAttrib4fvARB(uint index, float* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4fvARB); _glVertexAttrib4fvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4fvARB")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib4fvARB = null;
    
    public static void glVertexAttrib4svARB(uint index, short* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4svARB); _glVertexAttrib4svARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4svARB")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib4svARB = null;
    
    public static void glVertexAttrib4dvARB(uint index, double* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4dvARB); _glVertexAttrib4dvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4dvARB")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib4dvARB = null;
    
    public static void glVertexAttrib4ivARB(uint index, int* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4ivARB); _glVertexAttrib4ivARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4ivARB")] internal static delegate* unmanaged<uint, int*, void> _glVertexAttrib4ivARB = null;
    
    public static void glVertexAttrib4bvARB(uint index, sbyte* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4bvARB); _glVertexAttrib4bvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4bvARB")] internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttrib4bvARB = null;
    
    public static void glVertexAttrib4ubvARB(uint index, byte* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4ubvARB); _glVertexAttrib4ubvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4ubvARB")] internal static delegate* unmanaged<uint, byte*, void> _glVertexAttrib4ubvARB = null;
    
    public static void glVertexAttrib4usvARB(uint index, ushort* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4usvARB); _glVertexAttrib4usvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4usvARB")] internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttrib4usvARB = null;
    
    public static void glVertexAttrib4uivARB(uint index, uint* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4uivARB); _glVertexAttrib4uivARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4uivARB")] internal static delegate* unmanaged<uint, uint*, void> _glVertexAttrib4uivARB = null;
    
    public static void glVertexAttrib4NbvARB(uint index, sbyte* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4NbvARB); _glVertexAttrib4NbvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4NbvARB")] internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttrib4NbvARB = null;
    
    public static void glVertexAttrib4NsvARB(uint index, short* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4NsvARB); _glVertexAttrib4NsvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4NsvARB")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib4NsvARB = null;
    
    public static void glVertexAttrib4NivARB(uint index, int* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4NivARB); _glVertexAttrib4NivARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4NivARB")] internal static delegate* unmanaged<uint, int*, void> _glVertexAttrib4NivARB = null;
    
    public static void glVertexAttrib4NubvARB(uint index, byte* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4NubvARB); _glVertexAttrib4NubvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4NubvARB")] internal static delegate* unmanaged<uint, byte*, void> _glVertexAttrib4NubvARB = null;
    
    public static void glVertexAttrib4NusvARB(uint index, ushort* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4NusvARB); _glVertexAttrib4NusvARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4NusvARB")] internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttrib4NusvARB = null;
    
    public static void glVertexAttrib4NuivARB(uint index, uint* v) { QGLNativeAPI.Verify((nint)_glVertexAttrib4NuivARB); _glVertexAttrib4NuivARB(index, v); }
    [QGLNativeAPI("glVertexAttrib4NuivARB")] internal static delegate* unmanaged<uint, uint*, void> _glVertexAttrib4NuivARB = null;
    
    public static void glVertexAttribPointerARB(uint index, int size, uint type, bool normalized, int stride, void* pointer) { QGLNativeAPI.Verify((nint)_glVertexAttribPointerARB); _glVertexAttribPointerARB(index, size, type, normalized, stride, pointer); }
    [QGLNativeAPI("glVertexAttribPointerARB")] internal static delegate* unmanaged<uint, int, uint, bool, int, void*, void> _glVertexAttribPointerARB = null;
    
    public static void glEnableVertexAttribArrayARB(uint index) { QGLNativeAPI.Verify((nint)_glEnableVertexAttribArrayARB); _glEnableVertexAttribArrayARB(index); }
    [QGLNativeAPI("glEnableVertexAttribArrayARB")] internal static delegate* unmanaged<uint, void> _glEnableVertexAttribArrayARB = null;
    
    public static void glDisableVertexAttribArrayARB(uint index) { QGLNativeAPI.Verify((nint)_glDisableVertexAttribArrayARB); _glDisableVertexAttribArrayARB(index); }
    [QGLNativeAPI("glDisableVertexAttribArrayARB")] internal static delegate* unmanaged<uint, void> _glDisableVertexAttribArrayARB = null;
    
    public static void glBindAttribLocationARB(nint programObj, uint index, byte* name) { QGLNativeAPI.Verify((nint)_glBindAttribLocationARB); _glBindAttribLocationARB(programObj, index, name); }
    [QGLNativeAPI("glBindAttribLocationARB")] internal static delegate* unmanaged<nint, uint, byte*, void> _glBindAttribLocationARB = null;
    
    public static void glGetActiveAttribARB(nint programObj, uint index, int maxLength, int* length, int* size, uint* type, byte* name) { QGLNativeAPI.Verify((nint)_glGetActiveAttribARB); _glGetActiveAttribARB(programObj, index, maxLength, length, size, type, name); }
    [QGLNativeAPI("glGetActiveAttribARB")] internal static delegate* unmanaged<nint, uint, int, int*, int*, uint*, byte*, void> _glGetActiveAttribARB = null;
    
    public static int glGetAttribLocationARB(nint programObj, byte* name) { QGLNativeAPI.Verify((nint)_glGetAttribLocationARB); return _glGetAttribLocationARB(programObj, name); }
    [QGLNativeAPI("glGetAttribLocationARB")] internal static delegate* unmanaged<nint, byte*, int> _glGetAttribLocationARB = null;
    
    public static void glGetVertexAttribdvARB(uint index, uint pname, double* @params) { QGLNativeAPI.Verify((nint)_glGetVertexAttribdvARB); _glGetVertexAttribdvARB(index, pname, @params); }
    [QGLNativeAPI("glGetVertexAttribdvARB")] internal static delegate* unmanaged<uint, uint, double*, void> _glGetVertexAttribdvARB = null;
    
    public static void glGetVertexAttribfvARB(uint index, uint pname, float* @params) { QGLNativeAPI.Verify((nint)_glGetVertexAttribfvARB); _glGetVertexAttribfvARB(index, pname, @params); }
    [QGLNativeAPI("glGetVertexAttribfvARB")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetVertexAttribfvARB = null;
    
    public static void glGetVertexAttribivARB(uint index, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetVertexAttribivARB); _glGetVertexAttribivARB(index, pname, @params); }
    [QGLNativeAPI("glGetVertexAttribivARB")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetVertexAttribivARB = null;
    
    public static void glGetVertexAttribPointervARB(uint index, uint pname, void** pointer) { QGLNativeAPI.Verify((nint)_glGetVertexAttribPointervARB); _glGetVertexAttribPointervARB(index, pname, pointer); }
    [QGLNativeAPI("glGetVertexAttribPointervARB")] internal static delegate* unmanaged<uint, uint, void**, void> _glGetVertexAttribPointervARB = null;
     #endregion
}
