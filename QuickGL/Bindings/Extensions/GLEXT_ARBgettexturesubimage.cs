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

// Bindings generated at 2025-08-30 15:45:08.531086
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_get_texture_sub_image", true, false)]
public static unsafe class GLEXT_ARBgettexturesubimage
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels) { QGLNativeAPI.Verify((nint)_glGetTextureSubImage); _glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels); }
    [QGLNativeAPI("glGetTextureSubImage")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, int, void*, void> _glGetTextureSubImage = null;
    
    public static void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels) { QGLNativeAPI.Verify((nint)_glGetCompressedTextureSubImage); _glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels); }
    [QGLNativeAPI("glGetCompressedTextureSubImage")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, int, void*, void> _glGetCompressedTextureSubImage = null;
     #endregion
}
