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

// Bindings generated at 2025-01-04 01:08:51.534469
namespace QuickGLNS.Bindings
{
    [GLFeature]
    public static unsafe class GL13
    {
        #region Enums
        public const int GL_TEXTURE0 = 0x84C0;
        public const int GL_TEXTURE1 = 0x84C1;
        public const int GL_TEXTURE2 = 0x84C2;
        public const int GL_TEXTURE3 = 0x84C3;
        public const int GL_TEXTURE4 = 0x84C4;
        public const int GL_TEXTURE5 = 0x84C5;
        public const int GL_TEXTURE6 = 0x84C6;
        public const int GL_TEXTURE7 = 0x84C7;
        public const int GL_TEXTURE8 = 0x84C8;
        public const int GL_TEXTURE9 = 0x84C9;
        public const int GL_TEXTURE10 = 0x84CA;
        public const int GL_TEXTURE11 = 0x84CB;
        public const int GL_TEXTURE12 = 0x84CC;
        public const int GL_TEXTURE13 = 0x84CD;
        public const int GL_TEXTURE14 = 0x84CE;
        public const int GL_TEXTURE15 = 0x84CF;
        public const int GL_TEXTURE16 = 0x84D0;
        public const int GL_TEXTURE17 = 0x84D1;
        public const int GL_TEXTURE18 = 0x84D2;
        public const int GL_TEXTURE19 = 0x84D3;
        public const int GL_TEXTURE20 = 0x84D4;
        public const int GL_TEXTURE21 = 0x84D5;
        public const int GL_TEXTURE22 = 0x84D6;
        public const int GL_TEXTURE23 = 0x84D7;
        public const int GL_TEXTURE24 = 0x84D8;
        public const int GL_TEXTURE25 = 0x84D9;
        public const int GL_TEXTURE26 = 0x84DA;
        public const int GL_TEXTURE27 = 0x84DB;
        public const int GL_TEXTURE28 = 0x84DC;
        public const int GL_TEXTURE29 = 0x84DD;
        public const int GL_TEXTURE30 = 0x84DE;
        public const int GL_TEXTURE31 = 0x84DF;
        public const int GL_ACTIVE_TEXTURE = 0x84E0;
        public const int GL_MULTISAMPLE = 0x809D;
        public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const int GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
        public const int GL_SAMPLE_COVERAGE = 0x80A0;
        public const int GL_SAMPLE_BUFFERS = 0x80A8;
        public const int GL_SAMPLES = 0x80A9;
        public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
        public const int GL_TEXTURE_CUBE_MAP = 0x8513;
        public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const int GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
        public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
        public const int GL_COMPRESSED_RGB = 0x84ED;
        public const int GL_COMPRESSED_RGBA = 0x84EE;
        public const int GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
        public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
        public const int GL_TEXTURE_COMPRESSED = 0x86A1;
        public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
        public const int GL_CLAMP_TO_BORDER = 0x812D;
        public const int GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
        public const int GL_MAX_TEXTURE_UNITS = 0x84E2;
        public const int GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
        public const int GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
        public const int GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
        public const int GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;
        public const int GL_MULTISAMPLE_BIT = 0x20000000;
        public const int GL_NORMAL_MAP = 0x8511;
        public const int GL_REFLECTION_MAP = 0x8512;
        public const int GL_COMPRESSED_ALPHA = 0x84E9;
        public const int GL_COMPRESSED_LUMINANCE = 0x84EA;
        public const int GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
        public const int GL_COMPRESSED_INTENSITY = 0x84EC;
        public const int GL_COMBINE = 0x8570;
        public const int GL_COMBINE_RGB = 0x8571;
        public const int GL_COMBINE_ALPHA = 0x8572;
        public const int GL_SOURCE0_RGB = 0x8580;
        public const int GL_SOURCE1_RGB = 0x8581;
        public const int GL_SOURCE2_RGB = 0x8582;
        public const int GL_SOURCE0_ALPHA = 0x8588;
        public const int GL_SOURCE1_ALPHA = 0x8589;
        public const int GL_SOURCE2_ALPHA = 0x858A;
        public const int GL_OPERAND0_RGB = 0x8590;
        public const int GL_OPERAND1_RGB = 0x8591;
        public const int GL_OPERAND2_RGB = 0x8592;
        public const int GL_OPERAND0_ALPHA = 0x8598;
        public const int GL_OPERAND1_ALPHA = 0x8599;
        public const int GL_OPERAND2_ALPHA = 0x859A;
        public const int GL_RGB_SCALE = 0x8573;
        public const int GL_ADD_SIGNED = 0x8574;
        public const int GL_INTERPOLATE = 0x8575;
        public const int GL_SUBTRACT = 0x84E7;
        public const int GL_CONSTANT = 0x8576;
        public const int GL_PRIMARY_COLOR = 0x8577;
        public const int GL_PREVIOUS = 0x8578;
        public const int GL_DOT3_RGB = 0x86AE;
        public const int GL_DOT3_RGBA = 0x86AF;
        #endregion
        
        #region Commands
        [QGLNativeAPI("glActiveTexture")] public static delegate* unmanaged<uint, void> glActiveTexture;
        [QGLNativeAPI("glSampleCoverage")] public static delegate* unmanaged<float, bool, void> glSampleCoverage;
        [QGLNativeAPI("glCompressedTexImage3D")] public static delegate* unmanaged<uint, int, uint, int, int, int, int, int, void*, void> glCompressedTexImage3D;
        [QGLNativeAPI("glCompressedTexImage2D")] public static delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void> glCompressedTexImage2D;
        [QGLNativeAPI("glCompressedTexImage1D")] public static delegate* unmanaged<uint, int, uint, int, int, int, void*, void> glCompressedTexImage1D;
        [QGLNativeAPI("glCompressedTexSubImage3D")] public static delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void> glCompressedTexSubImage3D;
        [QGLNativeAPI("glCompressedTexSubImage2D")] public static delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void> glCompressedTexSubImage2D;
        [QGLNativeAPI("glCompressedTexSubImage1D")] public static delegate* unmanaged<uint, int, int, int, uint, int, void*, void> glCompressedTexSubImage1D;
        [QGLNativeAPI("glGetCompressedTexImage")] public static delegate* unmanaged<uint, int, void*, void> glGetCompressedTexImage;
        [QGLNativeAPI("glClientActiveTexture")] public static delegate* unmanaged<uint, void> glClientActiveTexture;
        [QGLNativeAPI("glMultiTexCoord1d")] public static delegate* unmanaged<uint, double, void> glMultiTexCoord1d;
        [QGLNativeAPI("glMultiTexCoord1dv")] public static delegate* unmanaged<uint, double*, void> glMultiTexCoord1dv;
        [QGLNativeAPI("glMultiTexCoord1f")] public static delegate* unmanaged<uint, float, void> glMultiTexCoord1f;
        [QGLNativeAPI("glMultiTexCoord1fv")] public static delegate* unmanaged<uint, float*, void> glMultiTexCoord1fv;
        [QGLNativeAPI("glMultiTexCoord1i")] public static delegate* unmanaged<uint, int, void> glMultiTexCoord1i;
        [QGLNativeAPI("glMultiTexCoord1iv")] public static delegate* unmanaged<uint, int*, void> glMultiTexCoord1iv;
        [QGLNativeAPI("glMultiTexCoord1s")] public static delegate* unmanaged<uint, short, void> glMultiTexCoord1s;
        [QGLNativeAPI("glMultiTexCoord1sv")] public static delegate* unmanaged<uint, short*, void> glMultiTexCoord1sv;
        [QGLNativeAPI("glMultiTexCoord2d")] public static delegate* unmanaged<uint, double, double, void> glMultiTexCoord2d;
        [QGLNativeAPI("glMultiTexCoord2dv")] public static delegate* unmanaged<uint, double*, void> glMultiTexCoord2dv;
        [QGLNativeAPI("glMultiTexCoord2f")] public static delegate* unmanaged<uint, float, float, void> glMultiTexCoord2f;
        [QGLNativeAPI("glMultiTexCoord2fv")] public static delegate* unmanaged<uint, float*, void> glMultiTexCoord2fv;
        [QGLNativeAPI("glMultiTexCoord2i")] public static delegate* unmanaged<uint, int, int, void> glMultiTexCoord2i;
        [QGLNativeAPI("glMultiTexCoord2iv")] public static delegate* unmanaged<uint, int*, void> glMultiTexCoord2iv;
        [QGLNativeAPI("glMultiTexCoord2s")] public static delegate* unmanaged<uint, short, short, void> glMultiTexCoord2s;
        [QGLNativeAPI("glMultiTexCoord2sv")] public static delegate* unmanaged<uint, short*, void> glMultiTexCoord2sv;
        [QGLNativeAPI("glMultiTexCoord3d")] public static delegate* unmanaged<uint, double, double, double, void> glMultiTexCoord3d;
        [QGLNativeAPI("glMultiTexCoord3dv")] public static delegate* unmanaged<uint, double*, void> glMultiTexCoord3dv;
        [QGLNativeAPI("glMultiTexCoord3f")] public static delegate* unmanaged<uint, float, float, float, void> glMultiTexCoord3f;
        [QGLNativeAPI("glMultiTexCoord3fv")] public static delegate* unmanaged<uint, float*, void> glMultiTexCoord3fv;
        [QGLNativeAPI("glMultiTexCoord3i")] public static delegate* unmanaged<uint, int, int, int, void> glMultiTexCoord3i;
        [QGLNativeAPI("glMultiTexCoord3iv")] public static delegate* unmanaged<uint, int*, void> glMultiTexCoord3iv;
        [QGLNativeAPI("glMultiTexCoord3s")] public static delegate* unmanaged<uint, short, short, short, void> glMultiTexCoord3s;
        [QGLNativeAPI("glMultiTexCoord3sv")] public static delegate* unmanaged<uint, short*, void> glMultiTexCoord3sv;
        [QGLNativeAPI("glMultiTexCoord4d")] public static delegate* unmanaged<uint, double, double, double, double, void> glMultiTexCoord4d;
        [QGLNativeAPI("glMultiTexCoord4dv")] public static delegate* unmanaged<uint, double*, void> glMultiTexCoord4dv;
        [QGLNativeAPI("glMultiTexCoord4f")] public static delegate* unmanaged<uint, float, float, float, float, void> glMultiTexCoord4f;
        [QGLNativeAPI("glMultiTexCoord4fv")] public static delegate* unmanaged<uint, float*, void> glMultiTexCoord4fv;
        [QGLNativeAPI("glMultiTexCoord4i")] public static delegate* unmanaged<uint, int, int, int, int, void> glMultiTexCoord4i;
        [QGLNativeAPI("glMultiTexCoord4iv")] public static delegate* unmanaged<uint, int*, void> glMultiTexCoord4iv;
        [QGLNativeAPI("glMultiTexCoord4s")] public static delegate* unmanaged<uint, short, short, short, short, void> glMultiTexCoord4s;
        [QGLNativeAPI("glMultiTexCoord4sv")] public static delegate* unmanaged<uint, short*, void> glMultiTexCoord4sv;
        [QGLNativeAPI("glLoadTransposeMatrixf")] public static delegate* unmanaged<float*, void> glLoadTransposeMatrixf;
        [QGLNativeAPI("glLoadTransposeMatrixd")] public static delegate* unmanaged<double*, void> glLoadTransposeMatrixd;
        [QGLNativeAPI("glMultTransposeMatrixf")] public static delegate* unmanaged<float*, void> glMultTransposeMatrixf;
        [QGLNativeAPI("glMultTransposeMatrixd")] public static delegate* unmanaged<double*, void> glMultTransposeMatrixd;
        #endregion
    }
}
