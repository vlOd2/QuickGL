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

// Bindings generated at 2025-01-04 01:08:51.535456
namespace QuickGLNS.Bindings
{
    [GLFeature]
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
        [QGLNativeAPI("glBlendFuncSeparate")] public static delegate* unmanaged<uint, uint, uint, uint, void> glBlendFuncSeparate;
        [QGLNativeAPI("glMultiDrawArrays")] public static delegate* unmanaged<uint, int*, int*, int, void> glMultiDrawArrays;
        [QGLNativeAPI("glMultiDrawElements")] public static delegate* unmanaged<uint, int*, uint, void**, int, void> glMultiDrawElements;
        [QGLNativeAPI("glPointParameterf")] public static delegate* unmanaged<uint, float, void> glPointParameterf;
        [QGLNativeAPI("glPointParameterfv")] public static delegate* unmanaged<uint, float*, void> glPointParameterfv;
        [QGLNativeAPI("glPointParameteri")] public static delegate* unmanaged<uint, int, void> glPointParameteri;
        [QGLNativeAPI("glPointParameteriv")] public static delegate* unmanaged<uint, int*, void> glPointParameteriv;
        [QGLNativeAPI("glFogCoordf")] public static delegate* unmanaged<float, void> glFogCoordf;
        [QGLNativeAPI("glFogCoordfv")] public static delegate* unmanaged<float*, void> glFogCoordfv;
        [QGLNativeAPI("glFogCoordd")] public static delegate* unmanaged<double, void> glFogCoordd;
        [QGLNativeAPI("glFogCoorddv")] public static delegate* unmanaged<double*, void> glFogCoorddv;
        [QGLNativeAPI("glFogCoordPointer")] public static delegate* unmanaged<uint, int, void*, void> glFogCoordPointer;
        [QGLNativeAPI("glSecondaryColor3b")] public static delegate* unmanaged<sbyte, sbyte, sbyte, void> glSecondaryColor3b;
        [QGLNativeAPI("glSecondaryColor3bv")] public static delegate* unmanaged<sbyte*, void> glSecondaryColor3bv;
        [QGLNativeAPI("glSecondaryColor3d")] public static delegate* unmanaged<double, double, double, void> glSecondaryColor3d;
        [QGLNativeAPI("glSecondaryColor3dv")] public static delegate* unmanaged<double*, void> glSecondaryColor3dv;
        [QGLNativeAPI("glSecondaryColor3f")] public static delegate* unmanaged<float, float, float, void> glSecondaryColor3f;
        [QGLNativeAPI("glSecondaryColor3fv")] public static delegate* unmanaged<float*, void> glSecondaryColor3fv;
        [QGLNativeAPI("glSecondaryColor3i")] public static delegate* unmanaged<int, int, int, void> glSecondaryColor3i;
        [QGLNativeAPI("glSecondaryColor3iv")] public static delegate* unmanaged<int*, void> glSecondaryColor3iv;
        [QGLNativeAPI("glSecondaryColor3s")] public static delegate* unmanaged<short, short, short, void> glSecondaryColor3s;
        [QGLNativeAPI("glSecondaryColor3sv")] public static delegate* unmanaged<short*, void> glSecondaryColor3sv;
        [QGLNativeAPI("glSecondaryColor3ub")] public static delegate* unmanaged<byte, byte, byte, void> glSecondaryColor3ub;
        [QGLNativeAPI("glSecondaryColor3ubv")] public static delegate* unmanaged<byte*, void> glSecondaryColor3ubv;
        [QGLNativeAPI("glSecondaryColor3ui")] public static delegate* unmanaged<uint, uint, uint, void> glSecondaryColor3ui;
        [QGLNativeAPI("glSecondaryColor3uiv")] public static delegate* unmanaged<uint*, void> glSecondaryColor3uiv;
        [QGLNativeAPI("glSecondaryColor3us")] public static delegate* unmanaged<ushort, ushort, ushort, void> glSecondaryColor3us;
        [QGLNativeAPI("glSecondaryColor3usv")] public static delegate* unmanaged<ushort*, void> glSecondaryColor3usv;
        [QGLNativeAPI("glSecondaryColorPointer")] public static delegate* unmanaged<int, uint, int, void*, void> glSecondaryColorPointer;
        [QGLNativeAPI("glWindowPos2d")] public static delegate* unmanaged<double, double, void> glWindowPos2d;
        [QGLNativeAPI("glWindowPos2dv")] public static delegate* unmanaged<double*, void> glWindowPos2dv;
        [QGLNativeAPI("glWindowPos2f")] public static delegate* unmanaged<float, float, void> glWindowPos2f;
        [QGLNativeAPI("glWindowPos2fv")] public static delegate* unmanaged<float*, void> glWindowPos2fv;
        [QGLNativeAPI("glWindowPos2i")] public static delegate* unmanaged<int, int, void> glWindowPos2i;
        [QGLNativeAPI("glWindowPos2iv")] public static delegate* unmanaged<int*, void> glWindowPos2iv;
        [QGLNativeAPI("glWindowPos2s")] public static delegate* unmanaged<short, short, void> glWindowPos2s;
        [QGLNativeAPI("glWindowPos2sv")] public static delegate* unmanaged<short*, void> glWindowPos2sv;
        [QGLNativeAPI("glWindowPos3d")] public static delegate* unmanaged<double, double, double, void> glWindowPos3d;
        [QGLNativeAPI("glWindowPos3dv")] public static delegate* unmanaged<double*, void> glWindowPos3dv;
        [QGLNativeAPI("glWindowPos3f")] public static delegate* unmanaged<float, float, float, void> glWindowPos3f;
        [QGLNativeAPI("glWindowPos3fv")] public static delegate* unmanaged<float*, void> glWindowPos3fv;
        [QGLNativeAPI("glWindowPos3i")] public static delegate* unmanaged<int, int, int, void> glWindowPos3i;
        [QGLNativeAPI("glWindowPos3iv")] public static delegate* unmanaged<int*, void> glWindowPos3iv;
        [QGLNativeAPI("glWindowPos3s")] public static delegate* unmanaged<short, short, short, void> glWindowPos3s;
        [QGLNativeAPI("glWindowPos3sv")] public static delegate* unmanaged<short*, void> glWindowPos3sv;
        [QGLNativeAPI("glBlendColor")] public static delegate* unmanaged<float, float, float, float, void> glBlendColor;
        [QGLNativeAPI("glBlendEquation")] public static delegate* unmanaged<uint, void> glBlendEquation;
        #endregion
    }
}
