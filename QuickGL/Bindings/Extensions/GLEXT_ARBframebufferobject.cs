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

// Bindings generated at 2025-08-30 15:45:08.525575
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_framebuffer_object", true, false)]
public static unsafe class GLEXT_ARBframebufferobject
{
    #region Enums
    public const int GL_INVALID_FRAMEBUFFER_OPERATION = 0x506;
    public const int GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
    public const int GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
    public const int GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
    public const int GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
    public const int GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
    public const int GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
    public const int GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
    public const int GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
    public const int GL_FRAMEBUFFER_DEFAULT = 0x8218;
    public const int GL_FRAMEBUFFER_UNDEFINED = 0x8219;
    public const int GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
    public const int GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
    public const int GL_DEPTH_STENCIL = 0x84F9;
    public const int GL_UNSIGNED_INT_24_8 = 0x84FA;
    public const int GL_DEPTH24_STENCIL8 = 0x88F0;
    public const int GL_TEXTURE_STENCIL_SIZE = 0x88F1;
    public const int GL_UNSIGNED_NORMALIZED = 0x8C17;
    public const int GL_FRAMEBUFFER_BINDING = 0x8CA6;
    public const int GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
    public const int GL_RENDERBUFFER_BINDING = 0x8CA7;
    public const int GL_READ_FRAMEBUFFER = 0x8CA8;
    public const int GL_DRAW_FRAMEBUFFER = 0x8CA9;
    public const int GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
    public const int GL_RENDERBUFFER_SAMPLES = 0x8CAB;
    public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
    public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
    public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
    public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
    public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
    public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
    public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
    public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
    public const int GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
    public const int GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
    public const int GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
    public const int GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
    public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;
    public const int GL_COLOR_ATTACHMENT1 = 0x8CE1;
    public const int GL_COLOR_ATTACHMENT2 = 0x8CE2;
    public const int GL_COLOR_ATTACHMENT3 = 0x8CE3;
    public const int GL_COLOR_ATTACHMENT4 = 0x8CE4;
    public const int GL_COLOR_ATTACHMENT5 = 0x8CE5;
    public const int GL_COLOR_ATTACHMENT6 = 0x8CE6;
    public const int GL_COLOR_ATTACHMENT7 = 0x8CE7;
    public const int GL_COLOR_ATTACHMENT8 = 0x8CE8;
    public const int GL_COLOR_ATTACHMENT9 = 0x8CE9;
    public const int GL_COLOR_ATTACHMENT10 = 0x8CEA;
    public const int GL_COLOR_ATTACHMENT11 = 0x8CEB;
    public const int GL_COLOR_ATTACHMENT12 = 0x8CEC;
    public const int GL_COLOR_ATTACHMENT13 = 0x8CED;
    public const int GL_COLOR_ATTACHMENT14 = 0x8CEE;
    public const int GL_COLOR_ATTACHMENT15 = 0x8CEF;
    public const int GL_DEPTH_ATTACHMENT = 0x8D00;
    public const int GL_STENCIL_ATTACHMENT = 0x8D20;
    public const int GL_FRAMEBUFFER = 0x8D40;
    public const int GL_RENDERBUFFER = 0x8D41;
    public const int GL_RENDERBUFFER_WIDTH = 0x8D42;
    public const int GL_RENDERBUFFER_HEIGHT = 0x8D43;
    public const int GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
    public const int GL_STENCIL_INDEX1 = 0x8D46;
    public const int GL_STENCIL_INDEX4 = 0x8D47;
    public const int GL_STENCIL_INDEX8 = 0x8D48;
    public const int GL_STENCIL_INDEX16 = 0x8D49;
    public const int GL_RENDERBUFFER_RED_SIZE = 0x8D50;
    public const int GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
    public const int GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
    public const int GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
    public const int GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
    public const int GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
    public const int GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
    public const int GL_MAX_SAMPLES = 0x8D57;
    public const int GL_INDEX = 0x8222;
    #endregion
    
    #region Commands
    public static bool glIsRenderbuffer(uint renderbuffer) { QGLNativeAPI.Verify((nint)_glIsRenderbuffer); return _glIsRenderbuffer(renderbuffer); }
    [QGLNativeAPI("glIsRenderbuffer")] internal static delegate* unmanaged<uint, bool> _glIsRenderbuffer = null;
    
    public static void glBindRenderbuffer(uint target, uint renderbuffer) { QGLNativeAPI.Verify((nint)_glBindRenderbuffer); _glBindRenderbuffer(target, renderbuffer); }
    [QGLNativeAPI("glBindRenderbuffer")] internal static delegate* unmanaged<uint, uint, void> _glBindRenderbuffer = null;
    
    public static void glDeleteRenderbuffers(int n, uint* renderbuffers) { QGLNativeAPI.Verify((nint)_glDeleteRenderbuffers); _glDeleteRenderbuffers(n, renderbuffers); }
    [QGLNativeAPI("glDeleteRenderbuffers")] internal static delegate* unmanaged<int, uint*, void> _glDeleteRenderbuffers = null;
    
    public static void glGenRenderbuffers(int n, uint* renderbuffers) { QGLNativeAPI.Verify((nint)_glGenRenderbuffers); _glGenRenderbuffers(n, renderbuffers); }
    [QGLNativeAPI("glGenRenderbuffers")] internal static delegate* unmanaged<int, uint*, void> _glGenRenderbuffers = null;
    
    public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height) { QGLNativeAPI.Verify((nint)_glRenderbufferStorage); _glRenderbufferStorage(target, internalformat, width, height); }
    [QGLNativeAPI("glRenderbufferStorage")] internal static delegate* unmanaged<uint, uint, int, int, void> _glRenderbufferStorage = null;
    
    public static void glGetRenderbufferParameteriv(uint target, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetRenderbufferParameteriv); _glGetRenderbufferParameteriv(target, pname, @params); }
    [QGLNativeAPI("glGetRenderbufferParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetRenderbufferParameteriv = null;
    
    public static bool glIsFramebuffer(uint framebuffer) { QGLNativeAPI.Verify((nint)_glIsFramebuffer); return _glIsFramebuffer(framebuffer); }
    [QGLNativeAPI("glIsFramebuffer")] internal static delegate* unmanaged<uint, bool> _glIsFramebuffer = null;
    
    public static void glBindFramebuffer(uint target, uint framebuffer) { QGLNativeAPI.Verify((nint)_glBindFramebuffer); _glBindFramebuffer(target, framebuffer); }
    [QGLNativeAPI("glBindFramebuffer")] internal static delegate* unmanaged<uint, uint, void> _glBindFramebuffer = null;
    
    public static void glDeleteFramebuffers(int n, uint* framebuffers) { QGLNativeAPI.Verify((nint)_glDeleteFramebuffers); _glDeleteFramebuffers(n, framebuffers); }
    [QGLNativeAPI("glDeleteFramebuffers")] internal static delegate* unmanaged<int, uint*, void> _glDeleteFramebuffers = null;
    
    public static void glGenFramebuffers(int n, uint* framebuffers) { QGLNativeAPI.Verify((nint)_glGenFramebuffers); _glGenFramebuffers(n, framebuffers); }
    [QGLNativeAPI("glGenFramebuffers")] internal static delegate* unmanaged<int, uint*, void> _glGenFramebuffers = null;
    
    public static uint glCheckFramebufferStatus(uint target) { QGLNativeAPI.Verify((nint)_glCheckFramebufferStatus); return _glCheckFramebufferStatus(target); }
    [QGLNativeAPI("glCheckFramebufferStatus")] internal static delegate* unmanaged<uint, uint> _glCheckFramebufferStatus = null;
    
    public static void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level) { QGLNativeAPI.Verify((nint)_glFramebufferTexture1D); _glFramebufferTexture1D(target, attachment, textarget, texture, level); }
    [QGLNativeAPI("glFramebufferTexture1D")] internal static delegate* unmanaged<uint, uint, uint, uint, int, void> _glFramebufferTexture1D = null;
    
    public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) { QGLNativeAPI.Verify((nint)_glFramebufferTexture2D); _glFramebufferTexture2D(target, attachment, textarget, texture, level); }
    [QGLNativeAPI("glFramebufferTexture2D")] internal static delegate* unmanaged<uint, uint, uint, uint, int, void> _glFramebufferTexture2D = null;
    
    public static void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) { QGLNativeAPI.Verify((nint)_glFramebufferTexture3D); _glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset); }
    [QGLNativeAPI("glFramebufferTexture3D")] internal static delegate* unmanaged<uint, uint, uint, uint, int, int, void> _glFramebufferTexture3D = null;
    
    public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) { QGLNativeAPI.Verify((nint)_glFramebufferRenderbuffer); _glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer); }
    [QGLNativeAPI("glFramebufferRenderbuffer")] internal static delegate* unmanaged<uint, uint, uint, uint, void> _glFramebufferRenderbuffer = null;
    
    public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetFramebufferAttachmentParameteriv); _glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params); }
    [QGLNativeAPI("glGetFramebufferAttachmentParameteriv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetFramebufferAttachmentParameteriv = null;
    
    public static void glGenerateMipmap(uint target) { QGLNativeAPI.Verify((nint)_glGenerateMipmap); _glGenerateMipmap(target); }
    [QGLNativeAPI("glGenerateMipmap")] internal static delegate* unmanaged<uint, void> _glGenerateMipmap = null;
    
    public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) { QGLNativeAPI.Verify((nint)_glBlitFramebuffer); _glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter); }
    [QGLNativeAPI("glBlitFramebuffer")] internal static delegate* unmanaged<int, int, int, int, int, int, int, int, uint, uint, void> _glBlitFramebuffer = null;
    
    public static void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height) { QGLNativeAPI.Verify((nint)_glRenderbufferStorageMultisample); _glRenderbufferStorageMultisample(target, samples, internalformat, width, height); }
    [QGLNativeAPI("glRenderbufferStorageMultisample")] internal static delegate* unmanaged<uint, int, uint, int, int, void> _glRenderbufferStorageMultisample = null;
    
    public static void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer) { QGLNativeAPI.Verify((nint)_glFramebufferTextureLayer); _glFramebufferTextureLayer(target, attachment, texture, level, layer); }
    [QGLNativeAPI("glFramebufferTextureLayer")] internal static delegate* unmanaged<uint, uint, uint, int, int, void> _glFramebufferTextureLayer = null;
     #endregion
}
