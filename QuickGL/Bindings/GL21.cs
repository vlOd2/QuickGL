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

// Bindings generated at 2025-01-04 01:08:51.538624
namespace QuickGLNS.Bindings
{
    [GLFeature]
    public static unsafe class GL21
    {
        #region Enums
        public const int GL_PIXEL_PACK_BUFFER = 0x88EB;
        public const int GL_PIXEL_UNPACK_BUFFER = 0x88EC;
        public const int GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
        public const int GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
        public const int GL_FLOAT_MAT2x3 = 0x8B65;
        public const int GL_FLOAT_MAT2x4 = 0x8B66;
        public const int GL_FLOAT_MAT3x2 = 0x8B67;
        public const int GL_FLOAT_MAT3x4 = 0x8B68;
        public const int GL_FLOAT_MAT4x2 = 0x8B69;
        public const int GL_FLOAT_MAT4x3 = 0x8B6A;
        public const int GL_SRGB = 0x8C40;
        public const int GL_SRGB8 = 0x8C41;
        public const int GL_SRGB_ALPHA = 0x8C42;
        public const int GL_SRGB8_ALPHA8 = 0x8C43;
        public const int GL_COMPRESSED_SRGB = 0x8C48;
        public const int GL_COMPRESSED_SRGB_ALPHA = 0x8C49;
        public const int GL_CURRENT_RASTER_SECONDARY_COLOR = 0x845F;
        public const int GL_SLUMINANCE_ALPHA = 0x8C44;
        public const int GL_SLUMINANCE8_ALPHA8 = 0x8C45;
        public const int GL_SLUMINANCE = 0x8C46;
        public const int GL_SLUMINANCE8 = 0x8C47;
        public const int GL_COMPRESSED_SLUMINANCE = 0x8C4A;
        public const int GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;
        #endregion
        
        #region Commands
        [QGLNativeAPI("glUniformMatrix2x3fv")] public static delegate* unmanaged<int, int, bool, float*, void> glUniformMatrix2x3fv;
        [QGLNativeAPI("glUniformMatrix3x2fv")] public static delegate* unmanaged<int, int, bool, float*, void> glUniformMatrix3x2fv;
        [QGLNativeAPI("glUniformMatrix2x4fv")] public static delegate* unmanaged<int, int, bool, float*, void> glUniformMatrix2x4fv;
        [QGLNativeAPI("glUniformMatrix4x2fv")] public static delegate* unmanaged<int, int, bool, float*, void> glUniformMatrix4x2fv;
        [QGLNativeAPI("glUniformMatrix3x4fv")] public static delegate* unmanaged<int, int, bool, float*, void> glUniformMatrix3x4fv;
        [QGLNativeAPI("glUniformMatrix4x3fv")] public static delegate* unmanaged<int, int, bool, float*, void> glUniformMatrix4x3fv;
        #endregion
    }
}
