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

// Bindings generated at 2025-09-20 18:58:19.740273
namespace QuickGLNS.Bindings;

public static unsafe class GL14
{
    #region Enums
    public const int GL_BLEND_DST_RGB = 0x80C8;
    public const int GL_BLEND_SRC_RGB = 0x80C9;
    public const int GL_BLEND_DST_ALPHA = 0x80CA;
    public const int GL_BLEND_SRC_ALPHA = 0x80CB;
    public const int GL_POINT_FADE_THRESHOLD_SIZE = 0x8128;
    public const int GL_DEPTH_COMPONENT16 = 0x81A5;
    public const int GL_DEPTH_COMPONENT24 = 0x81A6;
    public const int GL_DEPTH_COMPONENT32 = 0x81A7;
    public const int GL_MIRRORED_REPEAT = 0x8370;
    public const int GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;
    public const int GL_TEXTURE_LOD_BIAS = 0x8501;
    public const int GL_INCR_WRAP = 0x8507;
    public const int GL_DECR_WRAP = 0x8508;
    public const int GL_TEXTURE_DEPTH_SIZE = 0x884A;
    public const int GL_TEXTURE_COMPARE_MODE = 0x884C;
    public const int GL_TEXTURE_COMPARE_FUNC = 0x884D;
    public const int GL_POINT_SIZE_MIN = 0x8126;
    public const int GL_POINT_SIZE_MAX = 0x8127;
    public const int GL_POINT_DISTANCE_ATTENUATION = 0x8129;
    public const int GL_GENERATE_MIPMAP = 0x8191;
    public const int GL_GENERATE_MIPMAP_HINT = 0x8192;
    public const int GL_FOG_COORDINATE_SOURCE = 0x8450;
    public const int GL_FOG_COORDINATE = 0x8451;
    public const int GL_FRAGMENT_DEPTH = 0x8452;
    public const int GL_CURRENT_FOG_COORDINATE = 0x8453;
    public const int GL_FOG_COORDINATE_ARRAY_TYPE = 0x8454;
    public const int GL_FOG_COORDINATE_ARRAY_STRIDE = 0x8455;
    public const int GL_FOG_COORDINATE_ARRAY_POINTER = 0x8456;
    public const int GL_FOG_COORDINATE_ARRAY = 0x8457;
    public const int GL_COLOR_SUM = 0x8458;
    public const int GL_CURRENT_SECONDARY_COLOR = 0x8459;
    public const int GL_SECONDARY_COLOR_ARRAY_SIZE = 0x845A;
    public const int GL_SECONDARY_COLOR_ARRAY_TYPE = 0x845B;
    public const int GL_SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;
    public const int GL_SECONDARY_COLOR_ARRAY_POINTER = 0x845D;
    public const int GL_SECONDARY_COLOR_ARRAY = 0x845E;
    public const int GL_TEXTURE_FILTER_CONTROL = 0x8500;
    public const int GL_DEPTH_TEXTURE_MODE = 0x884B;
    public const int GL_COMPARE_R_TO_TEXTURE = 0x884E;
    public const int GL_BLEND_COLOR = 0x8005;
    public const int GL_BLEND_EQUATION = 0x8009;
    public const int GL_CONSTANT_COLOR = 0x8001;
    public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
    public const int GL_CONSTANT_ALPHA = 0x8003;
    public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
    public const int GL_FUNC_ADD = 0x8006;
    public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;
    public const int GL_FUNC_SUBTRACT = 0x800A;
    public const int GL_MIN = 0x8007;
    public const int GL_MAX = 0x8008;
    #endregion
    
    #region Commands
    public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) { QGLFeature.VerifyFunc((nint)_glBlendFuncSeparate); _glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha); }
    internal static delegate* unmanaged<uint, uint, uint, uint, void> _glBlendFuncSeparate = null;
    
    public static void glMultiDrawArrays(uint mode, int* first, int* count, int drawcount) { QGLFeature.VerifyFunc((nint)_glMultiDrawArrays); _glMultiDrawArrays(mode, first, count, drawcount); }
    internal static delegate* unmanaged<uint, int*, int*, int, void> _glMultiDrawArrays = null;
    
    public static void glMultiDrawElements(uint mode, int* count, uint type, void** indices, int drawcount) { QGLFeature.VerifyFunc((nint)_glMultiDrawElements); _glMultiDrawElements(mode, count, type, indices, drawcount); }
    internal static delegate* unmanaged<uint, int*, uint, void**, int, void> _glMultiDrawElements = null;
    
    public static void glPointParameterf(uint pname, float param) { QGLFeature.VerifyFunc((nint)_glPointParameterf); _glPointParameterf(pname, param); }
    internal static delegate* unmanaged<uint, float, void> _glPointParameterf = null;
    
    public static void glPointParameterfv(uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glPointParameterfv); _glPointParameterfv(pname, @params); }
    internal static delegate* unmanaged<uint, float*, void> _glPointParameterfv = null;
    
    public static void glPointParameteri(uint pname, int param) { QGLFeature.VerifyFunc((nint)_glPointParameteri); _glPointParameteri(pname, param); }
    internal static delegate* unmanaged<uint, int, void> _glPointParameteri = null;
    
    public static void glPointParameteriv(uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glPointParameteriv); _glPointParameteriv(pname, @params); }
    internal static delegate* unmanaged<uint, int*, void> _glPointParameteriv = null;
    
    public static void glFogCoordf(float coord) { QGLFeature.VerifyFunc((nint)_glFogCoordf); _glFogCoordf(coord); }
    internal static delegate* unmanaged<float, void> _glFogCoordf = null;
    
    public static void glFogCoordfv(float* coord) { QGLFeature.VerifyFunc((nint)_glFogCoordfv); _glFogCoordfv(coord); }
    internal static delegate* unmanaged<float*, void> _glFogCoordfv = null;
    
    public static void glFogCoordd(double coord) { QGLFeature.VerifyFunc((nint)_glFogCoordd); _glFogCoordd(coord); }
    internal static delegate* unmanaged<double, void> _glFogCoordd = null;
    
    public static void glFogCoorddv(double* coord) { QGLFeature.VerifyFunc((nint)_glFogCoorddv); _glFogCoorddv(coord); }
    internal static delegate* unmanaged<double*, void> _glFogCoorddv = null;
    
    public static void glFogCoordPointer(uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glFogCoordPointer); _glFogCoordPointer(type, stride, pointer); }
    internal static delegate* unmanaged<uint, int, void*, void> _glFogCoordPointer = null;
    
    public static void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3b); _glSecondaryColor3b(red, green, blue); }
    internal static delegate* unmanaged<sbyte, sbyte, sbyte, void> _glSecondaryColor3b = null;
    
    public static void glSecondaryColor3bv(sbyte* v) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3bv); _glSecondaryColor3bv(v); }
    internal static delegate* unmanaged<sbyte*, void> _glSecondaryColor3bv = null;
    
    public static void glSecondaryColor3d(double red, double green, double blue) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3d); _glSecondaryColor3d(red, green, blue); }
    internal static delegate* unmanaged<double, double, double, void> _glSecondaryColor3d = null;
    
    public static void glSecondaryColor3dv(double* v) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3dv); _glSecondaryColor3dv(v); }
    internal static delegate* unmanaged<double*, void> _glSecondaryColor3dv = null;
    
    public static void glSecondaryColor3f(float red, float green, float blue) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3f); _glSecondaryColor3f(red, green, blue); }
    internal static delegate* unmanaged<float, float, float, void> _glSecondaryColor3f = null;
    
    public static void glSecondaryColor3fv(float* v) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3fv); _glSecondaryColor3fv(v); }
    internal static delegate* unmanaged<float*, void> _glSecondaryColor3fv = null;
    
    public static void glSecondaryColor3i(int red, int green, int blue) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3i); _glSecondaryColor3i(red, green, blue); }
    internal static delegate* unmanaged<int, int, int, void> _glSecondaryColor3i = null;
    
    public static void glSecondaryColor3iv(int* v) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3iv); _glSecondaryColor3iv(v); }
    internal static delegate* unmanaged<int*, void> _glSecondaryColor3iv = null;
    
    public static void glSecondaryColor3s(short red, short green, short blue) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3s); _glSecondaryColor3s(red, green, blue); }
    internal static delegate* unmanaged<short, short, short, void> _glSecondaryColor3s = null;
    
    public static void glSecondaryColor3sv(short* v) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3sv); _glSecondaryColor3sv(v); }
    internal static delegate* unmanaged<short*, void> _glSecondaryColor3sv = null;
    
    public static void glSecondaryColor3ub(byte red, byte green, byte blue) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3ub); _glSecondaryColor3ub(red, green, blue); }
    internal static delegate* unmanaged<byte, byte, byte, void> _glSecondaryColor3ub = null;
    
    public static void glSecondaryColor3ubv(byte* v) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3ubv); _glSecondaryColor3ubv(v); }
    internal static delegate* unmanaged<byte*, void> _glSecondaryColor3ubv = null;
    
    public static void glSecondaryColor3ui(uint red, uint green, uint blue) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3ui); _glSecondaryColor3ui(red, green, blue); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glSecondaryColor3ui = null;
    
    public static void glSecondaryColor3uiv(uint* v) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3uiv); _glSecondaryColor3uiv(v); }
    internal static delegate* unmanaged<uint*, void> _glSecondaryColor3uiv = null;
    
    public static void glSecondaryColor3us(ushort red, ushort green, ushort blue) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3us); _glSecondaryColor3us(red, green, blue); }
    internal static delegate* unmanaged<ushort, ushort, ushort, void> _glSecondaryColor3us = null;
    
    public static void glSecondaryColor3usv(ushort* v) { QGLFeature.VerifyFunc((nint)_glSecondaryColor3usv); _glSecondaryColor3usv(v); }
    internal static delegate* unmanaged<ushort*, void> _glSecondaryColor3usv = null;
    
    public static void glSecondaryColorPointer(int size, uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glSecondaryColorPointer); _glSecondaryColorPointer(size, type, stride, pointer); }
    internal static delegate* unmanaged<int, uint, int, void*, void> _glSecondaryColorPointer = null;
    
    public static void glWindowPos2d(double x, double y) { QGLFeature.VerifyFunc((nint)_glWindowPos2d); _glWindowPos2d(x, y); }
    internal static delegate* unmanaged<double, double, void> _glWindowPos2d = null;
    
    public static void glWindowPos2dv(double* v) { QGLFeature.VerifyFunc((nint)_glWindowPos2dv); _glWindowPos2dv(v); }
    internal static delegate* unmanaged<double*, void> _glWindowPos2dv = null;
    
    public static void glWindowPos2f(float x, float y) { QGLFeature.VerifyFunc((nint)_glWindowPos2f); _glWindowPos2f(x, y); }
    internal static delegate* unmanaged<float, float, void> _glWindowPos2f = null;
    
    public static void glWindowPos2fv(float* v) { QGLFeature.VerifyFunc((nint)_glWindowPos2fv); _glWindowPos2fv(v); }
    internal static delegate* unmanaged<float*, void> _glWindowPos2fv = null;
    
    public static void glWindowPos2i(int x, int y) { QGLFeature.VerifyFunc((nint)_glWindowPos2i); _glWindowPos2i(x, y); }
    internal static delegate* unmanaged<int, int, void> _glWindowPos2i = null;
    
    public static void glWindowPos2iv(int* v) { QGLFeature.VerifyFunc((nint)_glWindowPos2iv); _glWindowPos2iv(v); }
    internal static delegate* unmanaged<int*, void> _glWindowPos2iv = null;
    
    public static void glWindowPos2s(short x, short y) { QGLFeature.VerifyFunc((nint)_glWindowPos2s); _glWindowPos2s(x, y); }
    internal static delegate* unmanaged<short, short, void> _glWindowPos2s = null;
    
    public static void glWindowPos2sv(short* v) { QGLFeature.VerifyFunc((nint)_glWindowPos2sv); _glWindowPos2sv(v); }
    internal static delegate* unmanaged<short*, void> _glWindowPos2sv = null;
    
    public static void glWindowPos3d(double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glWindowPos3d); _glWindowPos3d(x, y, z); }
    internal static delegate* unmanaged<double, double, double, void> _glWindowPos3d = null;
    
    public static void glWindowPos3dv(double* v) { QGLFeature.VerifyFunc((nint)_glWindowPos3dv); _glWindowPos3dv(v); }
    internal static delegate* unmanaged<double*, void> _glWindowPos3dv = null;
    
    public static void glWindowPos3f(float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glWindowPos3f); _glWindowPos3f(x, y, z); }
    internal static delegate* unmanaged<float, float, float, void> _glWindowPos3f = null;
    
    public static void glWindowPos3fv(float* v) { QGLFeature.VerifyFunc((nint)_glWindowPos3fv); _glWindowPos3fv(v); }
    internal static delegate* unmanaged<float*, void> _glWindowPos3fv = null;
    
    public static void glWindowPos3i(int x, int y, int z) { QGLFeature.VerifyFunc((nint)_glWindowPos3i); _glWindowPos3i(x, y, z); }
    internal static delegate* unmanaged<int, int, int, void> _glWindowPos3i = null;
    
    public static void glWindowPos3iv(int* v) { QGLFeature.VerifyFunc((nint)_glWindowPos3iv); _glWindowPos3iv(v); }
    internal static delegate* unmanaged<int*, void> _glWindowPos3iv = null;
    
    public static void glWindowPos3s(short x, short y, short z) { QGLFeature.VerifyFunc((nint)_glWindowPos3s); _glWindowPos3s(x, y, z); }
    internal static delegate* unmanaged<short, short, short, void> _glWindowPos3s = null;
    
    public static void glWindowPos3sv(short* v) { QGLFeature.VerifyFunc((nint)_glWindowPos3sv); _glWindowPos3sv(v); }
    internal static delegate* unmanaged<short*, void> _glWindowPos3sv = null;
    
    public static void glBlendColor(float red, float green, float blue, float alpha) { QGLFeature.VerifyFunc((nint)_glBlendColor); _glBlendColor(red, green, blue, alpha); }
    internal static delegate* unmanaged<float, float, float, float, void> _glBlendColor = null;
    
    public static void glBlendEquation(uint mode) { QGLFeature.VerifyFunc((nint)_glBlendEquation); _glBlendEquation(mode); }
    internal static delegate* unmanaged<uint, void> _glBlendEquation = null;
     #endregion
    
    internal static void Load()
    {
        _glBlendFuncSeparate = (delegate* unmanaged<uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glBlendFuncSeparate");
        _glMultiDrawArrays = (delegate* unmanaged<uint, int*, int*, int, void>)QuickGL.GetGLProcAddress("glMultiDrawArrays");
        _glMultiDrawElements = (delegate* unmanaged<uint, int*, uint, void**, int, void>)QuickGL.GetGLProcAddress("glMultiDrawElements");
        _glPointParameterf = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glPointParameterf");
        _glPointParameterfv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glPointParameterfv");
        _glPointParameteri = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glPointParameteri");
        _glPointParameteriv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glPointParameteriv");
        _glFogCoordf = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glFogCoordf");
        _glFogCoordfv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glFogCoordfv");
        _glFogCoordd = (delegate* unmanaged<double, void>)QuickGL.GetGLProcAddress("glFogCoordd");
        _glFogCoorddv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glFogCoorddv");
        _glFogCoordPointer = (delegate* unmanaged<uint, int, void*, void>)QuickGL.GetGLProcAddress("glFogCoordPointer");
        _glSecondaryColor3b = (delegate* unmanaged<sbyte, sbyte, sbyte, void>)QuickGL.GetGLProcAddress("glSecondaryColor3b");
        _glSecondaryColor3bv = (delegate* unmanaged<sbyte*, void>)QuickGL.GetGLProcAddress("glSecondaryColor3bv");
        _glSecondaryColor3d = (delegate* unmanaged<double, double, double, void>)QuickGL.GetGLProcAddress("glSecondaryColor3d");
        _glSecondaryColor3dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glSecondaryColor3dv");
        _glSecondaryColor3f = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glSecondaryColor3f");
        _glSecondaryColor3fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glSecondaryColor3fv");
        _glSecondaryColor3i = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glSecondaryColor3i");
        _glSecondaryColor3iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glSecondaryColor3iv");
        _glSecondaryColor3s = (delegate* unmanaged<short, short, short, void>)QuickGL.GetGLProcAddress("glSecondaryColor3s");
        _glSecondaryColor3sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glSecondaryColor3sv");
        _glSecondaryColor3ub = (delegate* unmanaged<byte, byte, byte, void>)QuickGL.GetGLProcAddress("glSecondaryColor3ub");
        _glSecondaryColor3ubv = (delegate* unmanaged<byte*, void>)QuickGL.GetGLProcAddress("glSecondaryColor3ubv");
        _glSecondaryColor3ui = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glSecondaryColor3ui");
        _glSecondaryColor3uiv = (delegate* unmanaged<uint*, void>)QuickGL.GetGLProcAddress("glSecondaryColor3uiv");
        _glSecondaryColor3us = (delegate* unmanaged<ushort, ushort, ushort, void>)QuickGL.GetGLProcAddress("glSecondaryColor3us");
        _glSecondaryColor3usv = (delegate* unmanaged<ushort*, void>)QuickGL.GetGLProcAddress("glSecondaryColor3usv");
        _glSecondaryColorPointer = (delegate* unmanaged<int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glSecondaryColorPointer");
        _glWindowPos2d = (delegate* unmanaged<double, double, void>)QuickGL.GetGLProcAddress("glWindowPos2d");
        _glWindowPos2dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glWindowPos2dv");
        _glWindowPos2f = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glWindowPos2f");
        _glWindowPos2fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glWindowPos2fv");
        _glWindowPos2i = (delegate* unmanaged<int, int, void>)QuickGL.GetGLProcAddress("glWindowPos2i");
        _glWindowPos2iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glWindowPos2iv");
        _glWindowPos2s = (delegate* unmanaged<short, short, void>)QuickGL.GetGLProcAddress("glWindowPos2s");
        _glWindowPos2sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glWindowPos2sv");
        _glWindowPos3d = (delegate* unmanaged<double, double, double, void>)QuickGL.GetGLProcAddress("glWindowPos3d");
        _glWindowPos3dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glWindowPos3dv");
        _glWindowPos3f = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glWindowPos3f");
        _glWindowPos3fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glWindowPos3fv");
        _glWindowPos3i = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glWindowPos3i");
        _glWindowPos3iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glWindowPos3iv");
        _glWindowPos3s = (delegate* unmanaged<short, short, short, void>)QuickGL.GetGLProcAddress("glWindowPos3s");
        _glWindowPos3sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glWindowPos3sv");
        _glBlendColor = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glBlendColor");
        _glBlendEquation = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glBlendEquation");
    }
    
    internal static void Unload()
    {
        _glBlendFuncSeparate = null;
        _glMultiDrawArrays = null;
        _glMultiDrawElements = null;
        _glPointParameterf = null;
        _glPointParameterfv = null;
        _glPointParameteri = null;
        _glPointParameteriv = null;
        _glFogCoordf = null;
        _glFogCoordfv = null;
        _glFogCoordd = null;
        _glFogCoorddv = null;
        _glFogCoordPointer = null;
        _glSecondaryColor3b = null;
        _glSecondaryColor3bv = null;
        _glSecondaryColor3d = null;
        _glSecondaryColor3dv = null;
        _glSecondaryColor3f = null;
        _glSecondaryColor3fv = null;
        _glSecondaryColor3i = null;
        _glSecondaryColor3iv = null;
        _glSecondaryColor3s = null;
        _glSecondaryColor3sv = null;
        _glSecondaryColor3ub = null;
        _glSecondaryColor3ubv = null;
        _glSecondaryColor3ui = null;
        _glSecondaryColor3uiv = null;
        _glSecondaryColor3us = null;
        _glSecondaryColor3usv = null;
        _glSecondaryColorPointer = null;
        _glWindowPos2d = null;
        _glWindowPos2dv = null;
        _glWindowPos2f = null;
        _glWindowPos2fv = null;
        _glWindowPos2i = null;
        _glWindowPos2iv = null;
        _glWindowPos2s = null;
        _glWindowPos2sv = null;
        _glWindowPos3d = null;
        _glWindowPos3dv = null;
        _glWindowPos3f = null;
        _glWindowPos3fv = null;
        _glWindowPos3i = null;
        _glWindowPos3iv = null;
        _glWindowPos3s = null;
        _glWindowPos3sv = null;
        _glBlendColor = null;
        _glBlendEquation = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_VERSION_1_4", false, false);
}
