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

// Bindings generated at 2025-09-20 18:58:20.137745
namespace QuickGLNS.Bindings.Extensions;

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
    public static void glVertexAttrib1fARB(uint index, float x) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1fARB); _glVertexAttrib1fARB(index, x); }
    internal static delegate* unmanaged<uint, float, void> _glVertexAttrib1fARB = null;
    
    public static void glVertexAttrib1sARB(uint index, short x) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1sARB); _glVertexAttrib1sARB(index, x); }
    internal static delegate* unmanaged<uint, short, void> _glVertexAttrib1sARB = null;
    
    public static void glVertexAttrib1dARB(uint index, double x) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1dARB); _glVertexAttrib1dARB(index, x); }
    internal static delegate* unmanaged<uint, double, void> _glVertexAttrib1dARB = null;
    
    public static void glVertexAttrib2fARB(uint index, float x, float y) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2fARB); _glVertexAttrib2fARB(index, x, y); }
    internal static delegate* unmanaged<uint, float, float, void> _glVertexAttrib2fARB = null;
    
    public static void glVertexAttrib2sARB(uint index, short x, short y) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2sARB); _glVertexAttrib2sARB(index, x, y); }
    internal static delegate* unmanaged<uint, short, short, void> _glVertexAttrib2sARB = null;
    
    public static void glVertexAttrib2dARB(uint index, double x, double y) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2dARB); _glVertexAttrib2dARB(index, x, y); }
    internal static delegate* unmanaged<uint, double, double, void> _glVertexAttrib2dARB = null;
    
    public static void glVertexAttrib3fARB(uint index, float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3fARB); _glVertexAttrib3fARB(index, x, y, z); }
    internal static delegate* unmanaged<uint, float, float, float, void> _glVertexAttrib3fARB = null;
    
    public static void glVertexAttrib3sARB(uint index, short x, short y, short z) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3sARB); _glVertexAttrib3sARB(index, x, y, z); }
    internal static delegate* unmanaged<uint, short, short, short, void> _glVertexAttrib3sARB = null;
    
    public static void glVertexAttrib3dARB(uint index, double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3dARB); _glVertexAttrib3dARB(index, x, y, z); }
    internal static delegate* unmanaged<uint, double, double, double, void> _glVertexAttrib3dARB = null;
    
    public static void glVertexAttrib4fARB(uint index, float x, float y, float z, float w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4fARB); _glVertexAttrib4fARB(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, float, float, float, float, void> _glVertexAttrib4fARB = null;
    
    public static void glVertexAttrib4sARB(uint index, short x, short y, short z, short w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4sARB); _glVertexAttrib4sARB(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, short, short, short, short, void> _glVertexAttrib4sARB = null;
    
    public static void glVertexAttrib4dARB(uint index, double x, double y, double z, double w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4dARB); _glVertexAttrib4dARB(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, double, double, double, double, void> _glVertexAttrib4dARB = null;
    
    public static void glVertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NubARB); _glVertexAttrib4NubARB(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, byte, byte, byte, byte, void> _glVertexAttrib4NubARB = null;
    
    public static void glVertexAttrib1fvARB(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1fvARB); _glVertexAttrib1fvARB(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib1fvARB = null;
    
    public static void glVertexAttrib1svARB(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1svARB); _glVertexAttrib1svARB(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib1svARB = null;
    
    public static void glVertexAttrib1dvARB(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1dvARB); _glVertexAttrib1dvARB(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib1dvARB = null;
    
    public static void glVertexAttrib2fvARB(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2fvARB); _glVertexAttrib2fvARB(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib2fvARB = null;
    
    public static void glVertexAttrib2svARB(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2svARB); _glVertexAttrib2svARB(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib2svARB = null;
    
    public static void glVertexAttrib2dvARB(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2dvARB); _glVertexAttrib2dvARB(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib2dvARB = null;
    
    public static void glVertexAttrib3fvARB(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3fvARB); _glVertexAttrib3fvARB(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib3fvARB = null;
    
    public static void glVertexAttrib3svARB(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3svARB); _glVertexAttrib3svARB(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib3svARB = null;
    
    public static void glVertexAttrib3dvARB(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3dvARB); _glVertexAttrib3dvARB(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib3dvARB = null;
    
    public static void glVertexAttrib4fvARB(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4fvARB); _glVertexAttrib4fvARB(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib4fvARB = null;
    
    public static void glVertexAttrib4svARB(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4svARB); _glVertexAttrib4svARB(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib4svARB = null;
    
    public static void glVertexAttrib4dvARB(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4dvARB); _glVertexAttrib4dvARB(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib4dvARB = null;
    
    public static void glVertexAttrib4ivARB(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4ivARB); _glVertexAttrib4ivARB(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glVertexAttrib4ivARB = null;
    
    public static void glVertexAttrib4bvARB(uint index, sbyte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4bvARB); _glVertexAttrib4bvARB(index, v); }
    internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttrib4bvARB = null;
    
    public static void glVertexAttrib4ubvARB(uint index, byte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4ubvARB); _glVertexAttrib4ubvARB(index, v); }
    internal static delegate* unmanaged<uint, byte*, void> _glVertexAttrib4ubvARB = null;
    
    public static void glVertexAttrib4usvARB(uint index, ushort* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4usvARB); _glVertexAttrib4usvARB(index, v); }
    internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttrib4usvARB = null;
    
    public static void glVertexAttrib4uivARB(uint index, uint* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4uivARB); _glVertexAttrib4uivARB(index, v); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexAttrib4uivARB = null;
    
    public static void glVertexAttrib4NbvARB(uint index, sbyte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NbvARB); _glVertexAttrib4NbvARB(index, v); }
    internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttrib4NbvARB = null;
    
    public static void glVertexAttrib4NsvARB(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NsvARB); _glVertexAttrib4NsvARB(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib4NsvARB = null;
    
    public static void glVertexAttrib4NivARB(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NivARB); _glVertexAttrib4NivARB(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glVertexAttrib4NivARB = null;
    
    public static void glVertexAttrib4NubvARB(uint index, byte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NubvARB); _glVertexAttrib4NubvARB(index, v); }
    internal static delegate* unmanaged<uint, byte*, void> _glVertexAttrib4NubvARB = null;
    
    public static void glVertexAttrib4NusvARB(uint index, ushort* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NusvARB); _glVertexAttrib4NusvARB(index, v); }
    internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttrib4NusvARB = null;
    
    public static void glVertexAttrib4NuivARB(uint index, uint* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NuivARB); _glVertexAttrib4NuivARB(index, v); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexAttrib4NuivARB = null;
    
    public static void glVertexAttribPointerARB(uint index, int size, uint type, bool normalized, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glVertexAttribPointerARB); _glVertexAttribPointerARB(index, size, type, normalized, stride, pointer); }
    internal static delegate* unmanaged<uint, int, uint, bool, int, void*, void> _glVertexAttribPointerARB = null;
    
    public static void glEnableVertexAttribArrayARB(uint index) { QGLFeature.VerifyFunc((nint)_glEnableVertexAttribArrayARB); _glEnableVertexAttribArrayARB(index); }
    internal static delegate* unmanaged<uint, void> _glEnableVertexAttribArrayARB = null;
    
    public static void glDisableVertexAttribArrayARB(uint index) { QGLFeature.VerifyFunc((nint)_glDisableVertexAttribArrayARB); _glDisableVertexAttribArrayARB(index); }
    internal static delegate* unmanaged<uint, void> _glDisableVertexAttribArrayARB = null;
    
    public static void glBindAttribLocationARB(nint programObj, uint index, byte* name) { QGLFeature.VerifyFunc((nint)_glBindAttribLocationARB); _glBindAttribLocationARB(programObj, index, name); }
    internal static delegate* unmanaged<nint, uint, byte*, void> _glBindAttribLocationARB = null;
    
    public static void glGetActiveAttribARB(nint programObj, uint index, int maxLength, int* length, int* size, uint* type, byte* name) { QGLFeature.VerifyFunc((nint)_glGetActiveAttribARB); _glGetActiveAttribARB(programObj, index, maxLength, length, size, type, name); }
    internal static delegate* unmanaged<nint, uint, int, int*, int*, uint*, byte*, void> _glGetActiveAttribARB = null;
    
    public static int glGetAttribLocationARB(nint programObj, byte* name) { QGLFeature.VerifyFunc((nint)_glGetAttribLocationARB); return _glGetAttribLocationARB(programObj, name); }
    internal static delegate* unmanaged<nint, byte*, int> _glGetAttribLocationARB = null;
    
    public static void glGetVertexAttribdvARB(uint index, uint pname, double* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribdvARB); _glGetVertexAttribdvARB(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glGetVertexAttribdvARB = null;
    
    public static void glGetVertexAttribfvARB(uint index, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribfvARB); _glGetVertexAttribfvARB(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetVertexAttribfvARB = null;
    
    public static void glGetVertexAttribivARB(uint index, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribivARB); _glGetVertexAttribivARB(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetVertexAttribivARB = null;
    
    public static void glGetVertexAttribPointervARB(uint index, uint pname, void** pointer) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribPointervARB); _glGetVertexAttribPointervARB(index, pname, pointer); }
    internal static delegate* unmanaged<uint, uint, void**, void> _glGetVertexAttribPointervARB = null;
     #endregion
    
    internal static void Load()
    {
        _glVertexAttrib1fARB = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib1fARB");
        _glVertexAttrib1sARB = (delegate* unmanaged<uint, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib1sARB");
        _glVertexAttrib1dARB = (delegate* unmanaged<uint, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib1dARB");
        _glVertexAttrib2fARB = (delegate* unmanaged<uint, float, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib2fARB");
        _glVertexAttrib2sARB = (delegate* unmanaged<uint, short, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib2sARB");
        _glVertexAttrib2dARB = (delegate* unmanaged<uint, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib2dARB");
        _glVertexAttrib3fARB = (delegate* unmanaged<uint, float, float, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib3fARB");
        _glVertexAttrib3sARB = (delegate* unmanaged<uint, short, short, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib3sARB");
        _glVertexAttrib3dARB = (delegate* unmanaged<uint, double, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib3dARB");
        _glVertexAttrib4fARB = (delegate* unmanaged<uint, float, float, float, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib4fARB");
        _glVertexAttrib4sARB = (delegate* unmanaged<uint, short, short, short, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib4sARB");
        _glVertexAttrib4dARB = (delegate* unmanaged<uint, double, double, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib4dARB");
        _glVertexAttrib4NubARB = (delegate* unmanaged<uint, byte, byte, byte, byte, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NubARB");
        _glVertexAttrib1fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib1fvARB");
        _glVertexAttrib1svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib1svARB");
        _glVertexAttrib1dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib1dvARB");
        _glVertexAttrib2fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib2fvARB");
        _glVertexAttrib2svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib2svARB");
        _glVertexAttrib2dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib2dvARB");
        _glVertexAttrib3fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib3fvARB");
        _glVertexAttrib3svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib3svARB");
        _glVertexAttrib3dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib3dvARB");
        _glVertexAttrib4fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4fvARB");
        _glVertexAttrib4svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4svARB");
        _glVertexAttrib4dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4dvARB");
        _glVertexAttrib4ivARB = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4ivARB");
        _glVertexAttrib4bvARB = (delegate* unmanaged<uint, sbyte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4bvARB");
        _glVertexAttrib4ubvARB = (delegate* unmanaged<uint, byte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4ubvARB");
        _glVertexAttrib4usvARB = (delegate* unmanaged<uint, ushort*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4usvARB");
        _glVertexAttrib4uivARB = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4uivARB");
        _glVertexAttrib4NbvARB = (delegate* unmanaged<uint, sbyte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NbvARB");
        _glVertexAttrib4NsvARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NsvARB");
        _glVertexAttrib4NivARB = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NivARB");
        _glVertexAttrib4NubvARB = (delegate* unmanaged<uint, byte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NubvARB");
        _glVertexAttrib4NusvARB = (delegate* unmanaged<uint, ushort*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NusvARB");
        _glVertexAttrib4NuivARB = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NuivARB");
        _glVertexAttribPointerARB = (delegate* unmanaged<uint, int, uint, bool, int, void*, void>)QuickGL.GetGLProcAddress("glVertexAttribPointerARB");
        _glEnableVertexAttribArrayARB = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glEnableVertexAttribArrayARB");
        _glDisableVertexAttribArrayARB = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDisableVertexAttribArrayARB");
        _glBindAttribLocationARB = (delegate* unmanaged<nint, uint, byte*, void>)QuickGL.GetGLProcAddress("glBindAttribLocationARB");
        _glGetActiveAttribARB = (delegate* unmanaged<nint, uint, int, int*, int*, uint*, byte*, void>)QuickGL.GetGLProcAddress("glGetActiveAttribARB");
        _glGetAttribLocationARB = (delegate* unmanaged<nint, byte*, int>)QuickGL.GetGLProcAddress("glGetAttribLocationARB");
        _glGetVertexAttribdvARB = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribdvARB");
        _glGetVertexAttribfvARB = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribfvARB");
        _glGetVertexAttribivARB = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribivARB");
        _glGetVertexAttribPointervARB = (delegate* unmanaged<uint, uint, void**, void>)QuickGL.GetGLProcAddress("glGetVertexAttribPointervARB");
    }
    
    internal static void Unload()
    {
        _glVertexAttrib1fARB = null;
        _glVertexAttrib1sARB = null;
        _glVertexAttrib1dARB = null;
        _glVertexAttrib2fARB = null;
        _glVertexAttrib2sARB = null;
        _glVertexAttrib2dARB = null;
        _glVertexAttrib3fARB = null;
        _glVertexAttrib3sARB = null;
        _glVertexAttrib3dARB = null;
        _glVertexAttrib4fARB = null;
        _glVertexAttrib4sARB = null;
        _glVertexAttrib4dARB = null;
        _glVertexAttrib4NubARB = null;
        _glVertexAttrib1fvARB = null;
        _glVertexAttrib1svARB = null;
        _glVertexAttrib1dvARB = null;
        _glVertexAttrib2fvARB = null;
        _glVertexAttrib2svARB = null;
        _glVertexAttrib2dvARB = null;
        _glVertexAttrib3fvARB = null;
        _glVertexAttrib3svARB = null;
        _glVertexAttrib3dvARB = null;
        _glVertexAttrib4fvARB = null;
        _glVertexAttrib4svARB = null;
        _glVertexAttrib4dvARB = null;
        _glVertexAttrib4ivARB = null;
        _glVertexAttrib4bvARB = null;
        _glVertexAttrib4ubvARB = null;
        _glVertexAttrib4usvARB = null;
        _glVertexAttrib4uivARB = null;
        _glVertexAttrib4NbvARB = null;
        _glVertexAttrib4NsvARB = null;
        _glVertexAttrib4NivARB = null;
        _glVertexAttrib4NubvARB = null;
        _glVertexAttrib4NusvARB = null;
        _glVertexAttrib4NuivARB = null;
        _glVertexAttribPointerARB = null;
        _glEnableVertexAttribArrayARB = null;
        _glDisableVertexAttribArrayARB = null;
        _glBindAttribLocationARB = null;
        _glGetActiveAttribARB = null;
        _glGetAttribLocationARB = null;
        _glGetVertexAttribdvARB = null;
        _glGetVertexAttribfvARB = null;
        _glGetVertexAttribivARB = null;
        _glGetVertexAttribPointervARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_vertex_shader", true, false);
}
