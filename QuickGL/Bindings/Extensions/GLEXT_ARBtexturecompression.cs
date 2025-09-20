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

// Bindings generated at 2025-09-20 18:58:20.023951
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtexturecompression
{
    #region Enums
    public const int GL_COMPRESSED_ALPHA_ARB = 0x84E9;
    public const int GL_COMPRESSED_LUMINANCE_ARB = 0x84EA;
    public const int GL_COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;
    public const int GL_COMPRESSED_INTENSITY_ARB = 0x84EC;
    public const int GL_COMPRESSED_RGB_ARB = 0x84ED;
    public const int GL_COMPRESSED_RGBA_ARB = 0x84EE;
    public const int GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF;
    public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0;
    public const int GL_TEXTURE_COMPRESSED_ARB = 0x86A1;
    public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;
    public const int GL_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;
    #endregion
    
    #region Commands
    public static void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data) { QGLFeature.VerifyFunc((nint)_glCompressedTexImage3DARB); _glCompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data); }
    internal static delegate* unmanaged<uint, int, uint, int, int, int, int, int, void*, void> _glCompressedTexImage3DARB = null;
    
    public static void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data) { QGLFeature.VerifyFunc((nint)_glCompressedTexImage2DARB); _glCompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data); }
    internal static delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void> _glCompressedTexImage2DARB = null;
    
    public static void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data) { QGLFeature.VerifyFunc((nint)_glCompressedTexImage1DARB); _glCompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data); }
    internal static delegate* unmanaged<uint, int, uint, int, int, int, void*, void> _glCompressedTexImage1DARB = null;
    
    public static void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) { QGLFeature.VerifyFunc((nint)_glCompressedTexSubImage3DARB); _glCompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void> _glCompressedTexSubImage3DARB = null;
    
    public static void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) { QGLFeature.VerifyFunc((nint)_glCompressedTexSubImage2DARB); _glCompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void> _glCompressedTexSubImage2DARB = null;
    
    public static void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data) { QGLFeature.VerifyFunc((nint)_glCompressedTexSubImage1DARB); _glCompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data); }
    internal static delegate* unmanaged<uint, int, int, int, uint, int, void*, void> _glCompressedTexSubImage1DARB = null;
    
    public static void glGetCompressedTexImageARB(uint target, int level, void* img) { QGLFeature.VerifyFunc((nint)_glGetCompressedTexImageARB); _glGetCompressedTexImageARB(target, level, img); }
    internal static delegate* unmanaged<uint, int, void*, void> _glGetCompressedTexImageARB = null;
     #endregion
    
    internal static void Load()
    {
        _glCompressedTexImage3DARB = (delegate* unmanaged<uint, int, uint, int, int, int, int, int, void*, void>)QuickGL.GetGLProcAddress("glCompressedTexImage3DARB");
        _glCompressedTexImage2DARB = (delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void>)QuickGL.GetGLProcAddress("glCompressedTexImage2DARB");
        _glCompressedTexImage1DARB = (delegate* unmanaged<uint, int, uint, int, int, int, void*, void>)QuickGL.GetGLProcAddress("glCompressedTexImage1DARB");
        _glCompressedTexSubImage3DARB = (delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glCompressedTexSubImage3DARB");
        _glCompressedTexSubImage2DARB = (delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glCompressedTexSubImage2DARB");
        _glCompressedTexSubImage1DARB = (delegate* unmanaged<uint, int, int, int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glCompressedTexSubImage1DARB");
        _glGetCompressedTexImageARB = (delegate* unmanaged<uint, int, void*, void>)QuickGL.GetGLProcAddress("glGetCompressedTexImageARB");
    }
    
    internal static void Unload()
    {
        _glCompressedTexImage3DARB = null;
        _glCompressedTexImage2DARB = null;
        _glCompressedTexImage1DARB = null;
        _glCompressedTexSubImage3DARB = null;
        _glCompressedTexSubImage2DARB = null;
        _glCompressedTexSubImage1DARB = null;
        _glGetCompressedTexImageARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_texture_compression", true, false);
}
