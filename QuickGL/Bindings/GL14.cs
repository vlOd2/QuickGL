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

// Bindings generated at 2025-08-30 15:45:08.411002
namespace QuickGLNS.Bindings;

[QGLFeature("GL_VERSION_1_4", false, false)]
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
    public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) { QGLNativeAPI.Verify((nint)_glBlendFuncSeparate); _glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha); }
    [QGLNativeAPI("glBlendFuncSeparate")] internal static delegate* unmanaged<uint, uint, uint, uint, void> _glBlendFuncSeparate = null;
    
    public static void glMultiDrawArrays(uint mode, int* first, int* count, int drawcount) { QGLNativeAPI.Verify((nint)_glMultiDrawArrays); _glMultiDrawArrays(mode, first, count, drawcount); }
    [QGLNativeAPI("glMultiDrawArrays")] internal static delegate* unmanaged<uint, int*, int*, int, void> _glMultiDrawArrays = null;
    
    public static void glMultiDrawElements(uint mode, int* count, uint type, void** indices, int drawcount) { QGLNativeAPI.Verify((nint)_glMultiDrawElements); _glMultiDrawElements(mode, count, type, indices, drawcount); }
    [QGLNativeAPI("glMultiDrawElements")] internal static delegate* unmanaged<uint, int*, uint, void**, int, void> _glMultiDrawElements = null;
    
    public static void glPointParameterf(uint pname, float param) { QGLNativeAPI.Verify((nint)_glPointParameterf); _glPointParameterf(pname, param); }
    [QGLNativeAPI("glPointParameterf")] internal static delegate* unmanaged<uint, float, void> _glPointParameterf = null;
    
    public static void glPointParameterfv(uint pname, float* @params) { QGLNativeAPI.Verify((nint)_glPointParameterfv); _glPointParameterfv(pname, @params); }
    [QGLNativeAPI("glPointParameterfv")] internal static delegate* unmanaged<uint, float*, void> _glPointParameterfv = null;
    
    public static void glPointParameteri(uint pname, int param) { QGLNativeAPI.Verify((nint)_glPointParameteri); _glPointParameteri(pname, param); }
    [QGLNativeAPI("glPointParameteri")] internal static delegate* unmanaged<uint, int, void> _glPointParameteri = null;
    
    public static void glPointParameteriv(uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glPointParameteriv); _glPointParameteriv(pname, @params); }
    [QGLNativeAPI("glPointParameteriv")] internal static delegate* unmanaged<uint, int*, void> _glPointParameteriv = null;
    
    public static void glFogCoordf(float coord) { QGLNativeAPI.Verify((nint)_glFogCoordf); _glFogCoordf(coord); }
    [QGLNativeAPI("glFogCoordf")] internal static delegate* unmanaged<float, void> _glFogCoordf = null;
    
    public static void glFogCoordfv(float* coord) { QGLNativeAPI.Verify((nint)_glFogCoordfv); _glFogCoordfv(coord); }
    [QGLNativeAPI("glFogCoordfv")] internal static delegate* unmanaged<float*, void> _glFogCoordfv = null;
    
    public static void glFogCoordd(double coord) { QGLNativeAPI.Verify((nint)_glFogCoordd); _glFogCoordd(coord); }
    [QGLNativeAPI("glFogCoordd")] internal static delegate* unmanaged<double, void> _glFogCoordd = null;
    
    public static void glFogCoorddv(double* coord) { QGLNativeAPI.Verify((nint)_glFogCoorddv); _glFogCoorddv(coord); }
    [QGLNativeAPI("glFogCoorddv")] internal static delegate* unmanaged<double*, void> _glFogCoorddv = null;
    
    public static void glFogCoordPointer(uint type, int stride, void* pointer) { QGLNativeAPI.Verify((nint)_glFogCoordPointer); _glFogCoordPointer(type, stride, pointer); }
    [QGLNativeAPI("glFogCoordPointer")] internal static delegate* unmanaged<uint, int, void*, void> _glFogCoordPointer = null;
    
    public static void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue) { QGLNativeAPI.Verify((nint)_glSecondaryColor3b); _glSecondaryColor3b(red, green, blue); }
    [QGLNativeAPI("glSecondaryColor3b")] internal static delegate* unmanaged<sbyte, sbyte, sbyte, void> _glSecondaryColor3b = null;
    
    public static void glSecondaryColor3bv(sbyte* v) { QGLNativeAPI.Verify((nint)_glSecondaryColor3bv); _glSecondaryColor3bv(v); }
    [QGLNativeAPI("glSecondaryColor3bv")] internal static delegate* unmanaged<sbyte*, void> _glSecondaryColor3bv = null;
    
    public static void glSecondaryColor3d(double red, double green, double blue) { QGLNativeAPI.Verify((nint)_glSecondaryColor3d); _glSecondaryColor3d(red, green, blue); }
    [QGLNativeAPI("glSecondaryColor3d")] internal static delegate* unmanaged<double, double, double, void> _glSecondaryColor3d = null;
    
    public static void glSecondaryColor3dv(double* v) { QGLNativeAPI.Verify((nint)_glSecondaryColor3dv); _glSecondaryColor3dv(v); }
    [QGLNativeAPI("glSecondaryColor3dv")] internal static delegate* unmanaged<double*, void> _glSecondaryColor3dv = null;
    
    public static void glSecondaryColor3f(float red, float green, float blue) { QGLNativeAPI.Verify((nint)_glSecondaryColor3f); _glSecondaryColor3f(red, green, blue); }
    [QGLNativeAPI("glSecondaryColor3f")] internal static delegate* unmanaged<float, float, float, void> _glSecondaryColor3f = null;
    
    public static void glSecondaryColor3fv(float* v) { QGLNativeAPI.Verify((nint)_glSecondaryColor3fv); _glSecondaryColor3fv(v); }
    [QGLNativeAPI("glSecondaryColor3fv")] internal static delegate* unmanaged<float*, void> _glSecondaryColor3fv = null;
    
    public static void glSecondaryColor3i(int red, int green, int blue) { QGLNativeAPI.Verify((nint)_glSecondaryColor3i); _glSecondaryColor3i(red, green, blue); }
    [QGLNativeAPI("glSecondaryColor3i")] internal static delegate* unmanaged<int, int, int, void> _glSecondaryColor3i = null;
    
    public static void glSecondaryColor3iv(int* v) { QGLNativeAPI.Verify((nint)_glSecondaryColor3iv); _glSecondaryColor3iv(v); }
    [QGLNativeAPI("glSecondaryColor3iv")] internal static delegate* unmanaged<int*, void> _glSecondaryColor3iv = null;
    
    public static void glSecondaryColor3s(short red, short green, short blue) { QGLNativeAPI.Verify((nint)_glSecondaryColor3s); _glSecondaryColor3s(red, green, blue); }
    [QGLNativeAPI("glSecondaryColor3s")] internal static delegate* unmanaged<short, short, short, void> _glSecondaryColor3s = null;
    
    public static void glSecondaryColor3sv(short* v) { QGLNativeAPI.Verify((nint)_glSecondaryColor3sv); _glSecondaryColor3sv(v); }
    [QGLNativeAPI("glSecondaryColor3sv")] internal static delegate* unmanaged<short*, void> _glSecondaryColor3sv = null;
    
    public static void glSecondaryColor3ub(byte red, byte green, byte blue) { QGLNativeAPI.Verify((nint)_glSecondaryColor3ub); _glSecondaryColor3ub(red, green, blue); }
    [QGLNativeAPI("glSecondaryColor3ub")] internal static delegate* unmanaged<byte, byte, byte, void> _glSecondaryColor3ub = null;
    
    public static void glSecondaryColor3ubv(byte* v) { QGLNativeAPI.Verify((nint)_glSecondaryColor3ubv); _glSecondaryColor3ubv(v); }
    [QGLNativeAPI("glSecondaryColor3ubv")] internal static delegate* unmanaged<byte*, void> _glSecondaryColor3ubv = null;
    
    public static void glSecondaryColor3ui(uint red, uint green, uint blue) { QGLNativeAPI.Verify((nint)_glSecondaryColor3ui); _glSecondaryColor3ui(red, green, blue); }
    [QGLNativeAPI("glSecondaryColor3ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glSecondaryColor3ui = null;
    
    public static void glSecondaryColor3uiv(uint* v) { QGLNativeAPI.Verify((nint)_glSecondaryColor3uiv); _glSecondaryColor3uiv(v); }
    [QGLNativeAPI("glSecondaryColor3uiv")] internal static delegate* unmanaged<uint*, void> _glSecondaryColor3uiv = null;
    
    public static void glSecondaryColor3us(ushort red, ushort green, ushort blue) { QGLNativeAPI.Verify((nint)_glSecondaryColor3us); _glSecondaryColor3us(red, green, blue); }
    [QGLNativeAPI("glSecondaryColor3us")] internal static delegate* unmanaged<ushort, ushort, ushort, void> _glSecondaryColor3us = null;
    
    public static void glSecondaryColor3usv(ushort* v) { QGLNativeAPI.Verify((nint)_glSecondaryColor3usv); _glSecondaryColor3usv(v); }
    [QGLNativeAPI("glSecondaryColor3usv")] internal static delegate* unmanaged<ushort*, void> _glSecondaryColor3usv = null;
    
    public static void glSecondaryColorPointer(int size, uint type, int stride, void* pointer) { QGLNativeAPI.Verify((nint)_glSecondaryColorPointer); _glSecondaryColorPointer(size, type, stride, pointer); }
    [QGLNativeAPI("glSecondaryColorPointer")] internal static delegate* unmanaged<int, uint, int, void*, void> _glSecondaryColorPointer = null;
    
    public static void glWindowPos2d(double x, double y) { QGLNativeAPI.Verify((nint)_glWindowPos2d); _glWindowPos2d(x, y); }
    [QGLNativeAPI("glWindowPos2d")] internal static delegate* unmanaged<double, double, void> _glWindowPos2d = null;
    
    public static void glWindowPos2dv(double* v) { QGLNativeAPI.Verify((nint)_glWindowPos2dv); _glWindowPos2dv(v); }
    [QGLNativeAPI("glWindowPos2dv")] internal static delegate* unmanaged<double*, void> _glWindowPos2dv = null;
    
    public static void glWindowPos2f(float x, float y) { QGLNativeAPI.Verify((nint)_glWindowPos2f); _glWindowPos2f(x, y); }
    [QGLNativeAPI("glWindowPos2f")] internal static delegate* unmanaged<float, float, void> _glWindowPos2f = null;
    
    public static void glWindowPos2fv(float* v) { QGLNativeAPI.Verify((nint)_glWindowPos2fv); _glWindowPos2fv(v); }
    [QGLNativeAPI("glWindowPos2fv")] internal static delegate* unmanaged<float*, void> _glWindowPos2fv = null;
    
    public static void glWindowPos2i(int x, int y) { QGLNativeAPI.Verify((nint)_glWindowPos2i); _glWindowPos2i(x, y); }
    [QGLNativeAPI("glWindowPos2i")] internal static delegate* unmanaged<int, int, void> _glWindowPos2i = null;
    
    public static void glWindowPos2iv(int* v) { QGLNativeAPI.Verify((nint)_glWindowPos2iv); _glWindowPos2iv(v); }
    [QGLNativeAPI("glWindowPos2iv")] internal static delegate* unmanaged<int*, void> _glWindowPos2iv = null;
    
    public static void glWindowPos2s(short x, short y) { QGLNativeAPI.Verify((nint)_glWindowPos2s); _glWindowPos2s(x, y); }
    [QGLNativeAPI("glWindowPos2s")] internal static delegate* unmanaged<short, short, void> _glWindowPos2s = null;
    
    public static void glWindowPos2sv(short* v) { QGLNativeAPI.Verify((nint)_glWindowPos2sv); _glWindowPos2sv(v); }
    [QGLNativeAPI("glWindowPos2sv")] internal static delegate* unmanaged<short*, void> _glWindowPos2sv = null;
    
    public static void glWindowPos3d(double x, double y, double z) { QGLNativeAPI.Verify((nint)_glWindowPos3d); _glWindowPos3d(x, y, z); }
    [QGLNativeAPI("glWindowPos3d")] internal static delegate* unmanaged<double, double, double, void> _glWindowPos3d = null;
    
    public static void glWindowPos3dv(double* v) { QGLNativeAPI.Verify((nint)_glWindowPos3dv); _glWindowPos3dv(v); }
    [QGLNativeAPI("glWindowPos3dv")] internal static delegate* unmanaged<double*, void> _glWindowPos3dv = null;
    
    public static void glWindowPos3f(float x, float y, float z) { QGLNativeAPI.Verify((nint)_glWindowPos3f); _glWindowPos3f(x, y, z); }
    [QGLNativeAPI("glWindowPos3f")] internal static delegate* unmanaged<float, float, float, void> _glWindowPos3f = null;
    
    public static void glWindowPos3fv(float* v) { QGLNativeAPI.Verify((nint)_glWindowPos3fv); _glWindowPos3fv(v); }
    [QGLNativeAPI("glWindowPos3fv")] internal static delegate* unmanaged<float*, void> _glWindowPos3fv = null;
    
    public static void glWindowPos3i(int x, int y, int z) { QGLNativeAPI.Verify((nint)_glWindowPos3i); _glWindowPos3i(x, y, z); }
    [QGLNativeAPI("glWindowPos3i")] internal static delegate* unmanaged<int, int, int, void> _glWindowPos3i = null;
    
    public static void glWindowPos3iv(int* v) { QGLNativeAPI.Verify((nint)_glWindowPos3iv); _glWindowPos3iv(v); }
    [QGLNativeAPI("glWindowPos3iv")] internal static delegate* unmanaged<int*, void> _glWindowPos3iv = null;
    
    public static void glWindowPos3s(short x, short y, short z) { QGLNativeAPI.Verify((nint)_glWindowPos3s); _glWindowPos3s(x, y, z); }
    [QGLNativeAPI("glWindowPos3s")] internal static delegate* unmanaged<short, short, short, void> _glWindowPos3s = null;
    
    public static void glWindowPos3sv(short* v) { QGLNativeAPI.Verify((nint)_glWindowPos3sv); _glWindowPos3sv(v); }
    [QGLNativeAPI("glWindowPos3sv")] internal static delegate* unmanaged<short*, void> _glWindowPos3sv = null;
    
    public static void glBlendColor(float red, float green, float blue, float alpha) { QGLNativeAPI.Verify((nint)_glBlendColor); _glBlendColor(red, green, blue, alpha); }
    [QGLNativeAPI("glBlendColor")] internal static delegate* unmanaged<float, float, float, float, void> _glBlendColor = null;
    
    public static void glBlendEquation(uint mode) { QGLNativeAPI.Verify((nint)_glBlendEquation); _glBlendEquation(mode); }
    [QGLNativeAPI("glBlendEquation")] internal static delegate* unmanaged<uint, void> _glBlendEquation = null;
     #endregion
}
