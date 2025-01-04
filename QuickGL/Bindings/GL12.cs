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

// Bindings generated at 2025-01-04 19:06:28.363102
namespace QuickGLNS.Bindings
{
    [GLFeature]
    public static unsafe class GL12
    {
        #region Enums
        public const int GL_UNSIGNED_BYTE_3_3_2 = 0x8032;
        public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const int GL_UNSIGNED_INT_8_8_8_8 = 0x8035;
        public const int GL_UNSIGNED_INT_10_10_10_2 = 0x8036;
        public const int GL_TEXTURE_BINDING_3D = 0x806A;
        public const int GL_PACK_SKIP_IMAGES = 0x806B;
        public const int GL_PACK_IMAGE_HEIGHT = 0x806C;
        public const int GL_UNPACK_SKIP_IMAGES = 0x806D;
        public const int GL_UNPACK_IMAGE_HEIGHT = 0x806E;
        public const int GL_TEXTURE_3D = 0x806F;
        public const int GL_PROXY_TEXTURE_3D = 0x8070;
        public const int GL_TEXTURE_DEPTH = 0x8071;
        public const int GL_TEXTURE_WRAP_R = 0x8072;
        public const int GL_MAX_3D_TEXTURE_SIZE = 0x8073;
        public const int GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;
        public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
        public const int GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;
        public const int GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
        public const int GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
        public const int GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;
        public const int GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
        public const int GL_BGR = 0x80E0;
        public const int GL_BGRA = 0x80E1;
        public const int GL_MAX_ELEMENTS_VERTICES = 0x80E8;
        public const int GL_MAX_ELEMENTS_INDICES = 0x80E9;
        public const int GL_CLAMP_TO_EDGE = 0x812F;
        public const int GL_TEXTURE_MIN_LOD = 0x813A;
        public const int GL_TEXTURE_MAX_LOD = 0x813B;
        public const int GL_TEXTURE_BASE_LEVEL = 0x813C;
        public const int GL_TEXTURE_MAX_LEVEL = 0x813D;
        public const int GL_SMOOTH_POINT_SIZE_RANGE = 0xB12;
        public const int GL_SMOOTH_POINT_SIZE_GRANULARITY = 0xB13;
        public const int GL_SMOOTH_LINE_WIDTH_RANGE = 0xB22;
        public const int GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0xB23;
        public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const int GL_RESCALE_NORMAL = 0x803A;
        public const int GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
        public const int GL_SINGLE_COLOR = 0x81F9;
        public const int GL_SEPARATE_SPECULAR_COLOR = 0x81FA;
        public const int GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
        #endregion
        
        #region Commands
        [QGLNativeAPI("glDrawRangeElements")] public static delegate* unmanaged<uint, uint, uint, int, uint, void*, void> glDrawRangeElements;
        [QGLNativeAPI("glTexImage3D")] public static delegate* unmanaged<uint, int, int, int, int, int, int, uint, uint, void*, void> glTexImage3D;
        [QGLNativeAPI("glTexSubImage3D")] public static delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void> glTexSubImage3D;
        [QGLNativeAPI("glCopyTexSubImage3D")] public static delegate* unmanaged<uint, int, int, int, int, int, int, int, int, void> glCopyTexSubImage3D;
        #endregion
    }
}
