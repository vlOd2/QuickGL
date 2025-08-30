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

// Bindings generated at 2025-08-30 15:45:08.498887
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_direct_state_access", true, false)]
public static unsafe class GLEXT_ARBdirectstateaccess
{
    #region Enums
    public const int GL_TEXTURE_TARGET = 0x1006;
    public const int GL_QUERY_TARGET = 0x82EA;
    public const int GL_TEXTURE_BINDING_1D = 0x8068;
    public const int GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
    public const int GL_TEXTURE_BINDING_2D = 0x8069;
    public const int GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
    public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
    public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
    public const int GL_TEXTURE_BINDING_3D = 0x806A;
    public const int GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
    public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
    public const int GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
    public const int GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
    #endregion
    
    #region Commands
    public static void glCreateTransformFeedbacks(int n, uint* ids) { QGLNativeAPI.Verify((nint)_glCreateTransformFeedbacks); _glCreateTransformFeedbacks(n, ids); }
    [QGLNativeAPI("glCreateTransformFeedbacks")] internal static delegate* unmanaged<int, uint*, void> _glCreateTransformFeedbacks = null;
    
    public static void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer) { QGLNativeAPI.Verify((nint)_glTransformFeedbackBufferBase); _glTransformFeedbackBufferBase(xfb, index, buffer); }
    [QGLNativeAPI("glTransformFeedbackBufferBase")] internal static delegate* unmanaged<uint, uint, uint, void> _glTransformFeedbackBufferBase = null;
    
    public static void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, nint offset, nint size) { QGLNativeAPI.Verify((nint)_glTransformFeedbackBufferRange); _glTransformFeedbackBufferRange(xfb, index, buffer, offset, size); }
    [QGLNativeAPI("glTransformFeedbackBufferRange")] internal static delegate* unmanaged<uint, uint, uint, nint, nint, void> _glTransformFeedbackBufferRange = null;
    
    public static void glGetTransformFeedbackiv(uint xfb, uint pname, int* param) { QGLNativeAPI.Verify((nint)_glGetTransformFeedbackiv); _glGetTransformFeedbackiv(xfb, pname, param); }
    [QGLNativeAPI("glGetTransformFeedbackiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetTransformFeedbackiv = null;
    
    public static void glGetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param) { QGLNativeAPI.Verify((nint)_glGetTransformFeedbacki_v); _glGetTransformFeedbacki_v(xfb, pname, index, param); }
    [QGLNativeAPI("glGetTransformFeedbacki_v")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetTransformFeedbacki_v = null;
    
    public static void glGetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long* param) { QGLNativeAPI.Verify((nint)_glGetTransformFeedbacki64_v); _glGetTransformFeedbacki64_v(xfb, pname, index, param); }
    [QGLNativeAPI("glGetTransformFeedbacki64_v")] internal static delegate* unmanaged<uint, uint, uint, long*, void> _glGetTransformFeedbacki64_v = null;
    
    public static void glCreateBuffers(int n, uint* buffers) { QGLNativeAPI.Verify((nint)_glCreateBuffers); _glCreateBuffers(n, buffers); }
    [QGLNativeAPI("glCreateBuffers")] internal static delegate* unmanaged<int, uint*, void> _glCreateBuffers = null;
    
    public static void glNamedBufferStorage(uint buffer, nint size, void* data, uint flags) { QGLNativeAPI.Verify((nint)_glNamedBufferStorage); _glNamedBufferStorage(buffer, size, data, flags); }
    [QGLNativeAPI("glNamedBufferStorage")] internal static delegate* unmanaged<uint, nint, void*, uint, void> _glNamedBufferStorage = null;
    
    public static void glNamedBufferData(uint buffer, nint size, void* data, uint usage) { QGLNativeAPI.Verify((nint)_glNamedBufferData); _glNamedBufferData(buffer, size, data, usage); }
    [QGLNativeAPI("glNamedBufferData")] internal static delegate* unmanaged<uint, nint, void*, uint, void> _glNamedBufferData = null;
    
    public static void glNamedBufferSubData(uint buffer, nint offset, nint size, void* data) { QGLNativeAPI.Verify((nint)_glNamedBufferSubData); _glNamedBufferSubData(buffer, offset, size, data); }
    [QGLNativeAPI("glNamedBufferSubData")] internal static delegate* unmanaged<uint, nint, nint, void*, void> _glNamedBufferSubData = null;
    
    public static void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size) { QGLNativeAPI.Verify((nint)_glCopyNamedBufferSubData); _glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size); }
    [QGLNativeAPI("glCopyNamedBufferSubData")] internal static delegate* unmanaged<uint, uint, nint, nint, nint, void> _glCopyNamedBufferSubData = null;
    
    public static void glClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, void* data) { QGLNativeAPI.Verify((nint)_glClearNamedBufferData); _glClearNamedBufferData(buffer, internalformat, format, type, data); }
    [QGLNativeAPI("glClearNamedBufferData")] internal static delegate* unmanaged<uint, uint, uint, uint, void*, void> _glClearNamedBufferData = null;
    
    public static void glClearNamedBufferSubData(uint buffer, uint internalformat, nint offset, nint size, uint format, uint type, void* data) { QGLNativeAPI.Verify((nint)_glClearNamedBufferSubData); _glClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data); }
    [QGLNativeAPI("glClearNamedBufferSubData")] internal static delegate* unmanaged<uint, uint, nint, nint, uint, uint, void*, void> _glClearNamedBufferSubData = null;
    
    public static void* glMapNamedBuffer(uint buffer, uint access) { QGLNativeAPI.Verify((nint)_glMapNamedBuffer); return _glMapNamedBuffer(buffer, access); }
    [QGLNativeAPI("glMapNamedBuffer")] internal static delegate* unmanaged<uint, uint, void*> _glMapNamedBuffer = null;
    
    public static void* glMapNamedBufferRange(uint buffer, nint offset, nint length, uint access) { QGLNativeAPI.Verify((nint)_glMapNamedBufferRange); return _glMapNamedBufferRange(buffer, offset, length, access); }
    [QGLNativeAPI("glMapNamedBufferRange")] internal static delegate* unmanaged<uint, nint, nint, uint, void*> _glMapNamedBufferRange = null;
    
    public static bool glUnmapNamedBuffer(uint buffer) { QGLNativeAPI.Verify((nint)_glUnmapNamedBuffer); return _glUnmapNamedBuffer(buffer); }
    [QGLNativeAPI("glUnmapNamedBuffer")] internal static delegate* unmanaged<uint, bool> _glUnmapNamedBuffer = null;
    
    public static void glFlushMappedNamedBufferRange(uint buffer, nint offset, nint length) { QGLNativeAPI.Verify((nint)_glFlushMappedNamedBufferRange); _glFlushMappedNamedBufferRange(buffer, offset, length); }
    [QGLNativeAPI("glFlushMappedNamedBufferRange")] internal static delegate* unmanaged<uint, nint, nint, void> _glFlushMappedNamedBufferRange = null;
    
    public static void glGetNamedBufferParameteriv(uint buffer, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetNamedBufferParameteriv); _glGetNamedBufferParameteriv(buffer, pname, @params); }
    [QGLNativeAPI("glGetNamedBufferParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetNamedBufferParameteriv = null;
    
    public static void glGetNamedBufferParameteri64v(uint buffer, uint pname, long* @params) { QGLNativeAPI.Verify((nint)_glGetNamedBufferParameteri64v); _glGetNamedBufferParameteri64v(buffer, pname, @params); }
    [QGLNativeAPI("glGetNamedBufferParameteri64v")] internal static delegate* unmanaged<uint, uint, long*, void> _glGetNamedBufferParameteri64v = null;
    
    public static void glGetNamedBufferPointerv(uint buffer, uint pname, void** @params) { QGLNativeAPI.Verify((nint)_glGetNamedBufferPointerv); _glGetNamedBufferPointerv(buffer, pname, @params); }
    [QGLNativeAPI("glGetNamedBufferPointerv")] internal static delegate* unmanaged<uint, uint, void**, void> _glGetNamedBufferPointerv = null;
    
    public static void glGetNamedBufferSubData(uint buffer, nint offset, nint size, void* data) { QGLNativeAPI.Verify((nint)_glGetNamedBufferSubData); _glGetNamedBufferSubData(buffer, offset, size, data); }
    [QGLNativeAPI("glGetNamedBufferSubData")] internal static delegate* unmanaged<uint, nint, nint, void*, void> _glGetNamedBufferSubData = null;
    
    public static void glCreateFramebuffers(int n, uint* framebuffers) { QGLNativeAPI.Verify((nint)_glCreateFramebuffers); _glCreateFramebuffers(n, framebuffers); }
    [QGLNativeAPI("glCreateFramebuffers")] internal static delegate* unmanaged<int, uint*, void> _glCreateFramebuffers = null;
    
    public static void glNamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer) { QGLNativeAPI.Verify((nint)_glNamedFramebufferRenderbuffer); _glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer); }
    [QGLNativeAPI("glNamedFramebufferRenderbuffer")] internal static delegate* unmanaged<uint, uint, uint, uint, void> _glNamedFramebufferRenderbuffer = null;
    
    public static void glNamedFramebufferParameteri(uint framebuffer, uint pname, int param) { QGLNativeAPI.Verify((nint)_glNamedFramebufferParameteri); _glNamedFramebufferParameteri(framebuffer, pname, param); }
    [QGLNativeAPI("glNamedFramebufferParameteri")] internal static delegate* unmanaged<uint, uint, int, void> _glNamedFramebufferParameteri = null;
    
    public static void glNamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level) { QGLNativeAPI.Verify((nint)_glNamedFramebufferTexture); _glNamedFramebufferTexture(framebuffer, attachment, texture, level); }
    [QGLNativeAPI("glNamedFramebufferTexture")] internal static delegate* unmanaged<uint, uint, uint, int, void> _glNamedFramebufferTexture = null;
    
    public static void glNamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer) { QGLNativeAPI.Verify((nint)_glNamedFramebufferTextureLayer); _glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer); }
    [QGLNativeAPI("glNamedFramebufferTextureLayer")] internal static delegate* unmanaged<uint, uint, uint, int, int, void> _glNamedFramebufferTextureLayer = null;
    
    public static void glNamedFramebufferDrawBuffer(uint framebuffer, uint buf) { QGLNativeAPI.Verify((nint)_glNamedFramebufferDrawBuffer); _glNamedFramebufferDrawBuffer(framebuffer, buf); }
    [QGLNativeAPI("glNamedFramebufferDrawBuffer")] internal static delegate* unmanaged<uint, uint, void> _glNamedFramebufferDrawBuffer = null;
    
    public static void glNamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs) { QGLNativeAPI.Verify((nint)_glNamedFramebufferDrawBuffers); _glNamedFramebufferDrawBuffers(framebuffer, n, bufs); }
    [QGLNativeAPI("glNamedFramebufferDrawBuffers")] internal static delegate* unmanaged<uint, int, uint*, void> _glNamedFramebufferDrawBuffers = null;
    
    public static void glNamedFramebufferReadBuffer(uint framebuffer, uint src) { QGLNativeAPI.Verify((nint)_glNamedFramebufferReadBuffer); _glNamedFramebufferReadBuffer(framebuffer, src); }
    [QGLNativeAPI("glNamedFramebufferReadBuffer")] internal static delegate* unmanaged<uint, uint, void> _glNamedFramebufferReadBuffer = null;
    
    public static void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments) { QGLNativeAPI.Verify((nint)_glInvalidateNamedFramebufferData); _glInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments); }
    [QGLNativeAPI("glInvalidateNamedFramebufferData")] internal static delegate* unmanaged<uint, int, uint*, void> _glInvalidateNamedFramebufferData = null;
    
    public static void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height) { QGLNativeAPI.Verify((nint)_glInvalidateNamedFramebufferSubData); _glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height); }
    [QGLNativeAPI("glInvalidateNamedFramebufferSubData")] internal static delegate* unmanaged<uint, int, uint*, int, int, int, int, void> _glInvalidateNamedFramebufferSubData = null;
    
    public static void glClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value) { QGLNativeAPI.Verify((nint)_glClearNamedFramebufferiv); _glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value); }
    [QGLNativeAPI("glClearNamedFramebufferiv")] internal static delegate* unmanaged<uint, uint, int, int*, void> _glClearNamedFramebufferiv = null;
    
    public static void glClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value) { QGLNativeAPI.Verify((nint)_glClearNamedFramebufferuiv); _glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value); }
    [QGLNativeAPI("glClearNamedFramebufferuiv")] internal static delegate* unmanaged<uint, uint, int, uint*, void> _glClearNamedFramebufferuiv = null;
    
    public static void glClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value) { QGLNativeAPI.Verify((nint)_glClearNamedFramebufferfv); _glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value); }
    [QGLNativeAPI("glClearNamedFramebufferfv")] internal static delegate* unmanaged<uint, uint, int, float*, void> _glClearNamedFramebufferfv = null;
    
    public static void glClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil) { QGLNativeAPI.Verify((nint)_glClearNamedFramebufferfi); _glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil); }
    [QGLNativeAPI("glClearNamedFramebufferfi")] internal static delegate* unmanaged<uint, uint, int, float, int, void> _glClearNamedFramebufferfi = null;
    
    public static void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) { QGLNativeAPI.Verify((nint)_glBlitNamedFramebuffer); _glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter); }
    [QGLNativeAPI("glBlitNamedFramebuffer")] internal static delegate* unmanaged<uint, uint, int, int, int, int, int, int, int, int, uint, uint, void> _glBlitNamedFramebuffer = null;
    
    public static uint glCheckNamedFramebufferStatus(uint framebuffer, uint target) { QGLNativeAPI.Verify((nint)_glCheckNamedFramebufferStatus); return _glCheckNamedFramebufferStatus(framebuffer, target); }
    [QGLNativeAPI("glCheckNamedFramebufferStatus")] internal static delegate* unmanaged<uint, uint, uint> _glCheckNamedFramebufferStatus = null;
    
    public static void glGetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param) { QGLNativeAPI.Verify((nint)_glGetNamedFramebufferParameteriv); _glGetNamedFramebufferParameteriv(framebuffer, pname, param); }
    [QGLNativeAPI("glGetNamedFramebufferParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetNamedFramebufferParameteriv = null;
    
    public static void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetNamedFramebufferAttachmentParameteriv); _glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, @params); }
    [QGLNativeAPI("glGetNamedFramebufferAttachmentParameteriv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetNamedFramebufferAttachmentParameteriv = null;
    
    public static void glCreateRenderbuffers(int n, uint* renderbuffers) { QGLNativeAPI.Verify((nint)_glCreateRenderbuffers); _glCreateRenderbuffers(n, renderbuffers); }
    [QGLNativeAPI("glCreateRenderbuffers")] internal static delegate* unmanaged<int, uint*, void> _glCreateRenderbuffers = null;
    
    public static void glNamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height) { QGLNativeAPI.Verify((nint)_glNamedRenderbufferStorage); _glNamedRenderbufferStorage(renderbuffer, internalformat, width, height); }
    [QGLNativeAPI("glNamedRenderbufferStorage")] internal static delegate* unmanaged<uint, uint, int, int, void> _glNamedRenderbufferStorage = null;
    
    public static void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height) { QGLNativeAPI.Verify((nint)_glNamedRenderbufferStorageMultisample); _glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height); }
    [QGLNativeAPI("glNamedRenderbufferStorageMultisample")] internal static delegate* unmanaged<uint, int, uint, int, int, void> _glNamedRenderbufferStorageMultisample = null;
    
    public static void glGetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetNamedRenderbufferParameteriv); _glGetNamedRenderbufferParameteriv(renderbuffer, pname, @params); }
    [QGLNativeAPI("glGetNamedRenderbufferParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetNamedRenderbufferParameteriv = null;
    
    public static void glCreateTextures(uint target, int n, uint* textures) { QGLNativeAPI.Verify((nint)_glCreateTextures); _glCreateTextures(target, n, textures); }
    [QGLNativeAPI("glCreateTextures")] internal static delegate* unmanaged<uint, int, uint*, void> _glCreateTextures = null;
    
    public static void glTextureBuffer(uint texture, uint internalformat, uint buffer) { QGLNativeAPI.Verify((nint)_glTextureBuffer); _glTextureBuffer(texture, internalformat, buffer); }
    [QGLNativeAPI("glTextureBuffer")] internal static delegate* unmanaged<uint, uint, uint, void> _glTextureBuffer = null;
    
    public static void glTextureBufferRange(uint texture, uint internalformat, uint buffer, nint offset, nint size) { QGLNativeAPI.Verify((nint)_glTextureBufferRange); _glTextureBufferRange(texture, internalformat, buffer, offset, size); }
    [QGLNativeAPI("glTextureBufferRange")] internal static delegate* unmanaged<uint, uint, uint, nint, nint, void> _glTextureBufferRange = null;
    
    public static void glTextureStorage1D(uint texture, int levels, uint internalformat, int width) { QGLNativeAPI.Verify((nint)_glTextureStorage1D); _glTextureStorage1D(texture, levels, internalformat, width); }
    [QGLNativeAPI("glTextureStorage1D")] internal static delegate* unmanaged<uint, int, uint, int, void> _glTextureStorage1D = null;
    
    public static void glTextureStorage2D(uint texture, int levels, uint internalformat, int width, int height) { QGLNativeAPI.Verify((nint)_glTextureStorage2D); _glTextureStorage2D(texture, levels, internalformat, width, height); }
    [QGLNativeAPI("glTextureStorage2D")] internal static delegate* unmanaged<uint, int, uint, int, int, void> _glTextureStorage2D = null;
    
    public static void glTextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth) { QGLNativeAPI.Verify((nint)_glTextureStorage3D); _glTextureStorage3D(texture, levels, internalformat, width, height, depth); }
    [QGLNativeAPI("glTextureStorage3D")] internal static delegate* unmanaged<uint, int, uint, int, int, int, void> _glTextureStorage3D = null;
    
    public static void glTextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) { QGLNativeAPI.Verify((nint)_glTextureStorage2DMultisample); _glTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations); }
    [QGLNativeAPI("glTextureStorage2DMultisample")] internal static delegate* unmanaged<uint, int, uint, int, int, bool, void> _glTextureStorage2DMultisample = null;
    
    public static void glTextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations) { QGLNativeAPI.Verify((nint)_glTextureStorage3DMultisample); _glTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations); }
    [QGLNativeAPI("glTextureStorage3DMultisample")] internal static delegate* unmanaged<uint, int, uint, int, int, int, bool, void> _glTextureStorage3DMultisample = null;
    
    public static void glTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels) { QGLNativeAPI.Verify((nint)_glTextureSubImage1D); _glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels); }
    [QGLNativeAPI("glTextureSubImage1D")] internal static delegate* unmanaged<uint, int, int, int, uint, uint, void*, void> _glTextureSubImage1D = null;
    
    public static void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) { QGLNativeAPI.Verify((nint)_glTextureSubImage2D); _glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels); }
    [QGLNativeAPI("glTextureSubImage2D")] internal static delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void> _glTextureSubImage2D = null;
    
    public static void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels) { QGLNativeAPI.Verify((nint)_glTextureSubImage3D); _glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels); }
    [QGLNativeAPI("glTextureSubImage3D")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void> _glTextureSubImage3D = null;
    
    public static void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data) { QGLNativeAPI.Verify((nint)_glCompressedTextureSubImage1D); _glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data); }
    [QGLNativeAPI("glCompressedTextureSubImage1D")] internal static delegate* unmanaged<uint, int, int, int, uint, int, void*, void> _glCompressedTextureSubImage1D = null;
    
    public static void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) { QGLNativeAPI.Verify((nint)_glCompressedTextureSubImage2D); _glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data); }
    [QGLNativeAPI("glCompressedTextureSubImage2D")] internal static delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void> _glCompressedTextureSubImage2D = null;
    
    public static void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) { QGLNativeAPI.Verify((nint)_glCompressedTextureSubImage3D); _glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data); }
    [QGLNativeAPI("glCompressedTextureSubImage3D")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void> _glCompressedTextureSubImage3D = null;
    
    public static void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width) { QGLNativeAPI.Verify((nint)_glCopyTextureSubImage1D); _glCopyTextureSubImage1D(texture, level, xoffset, x, y, width); }
    [QGLNativeAPI("glCopyTextureSubImage1D")] internal static delegate* unmanaged<uint, int, int, int, int, int, void> _glCopyTextureSubImage1D = null;
    
    public static void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) { QGLNativeAPI.Verify((nint)_glCopyTextureSubImage2D); _glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height); }
    [QGLNativeAPI("glCopyTextureSubImage2D")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, void> _glCopyTextureSubImage2D = null;
    
    public static void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) { QGLNativeAPI.Verify((nint)_glCopyTextureSubImage3D); _glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height); }
    [QGLNativeAPI("glCopyTextureSubImage3D")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, int, void> _glCopyTextureSubImage3D = null;
    
    public static void glTextureParameterf(uint texture, uint pname, float param) { QGLNativeAPI.Verify((nint)_glTextureParameterf); _glTextureParameterf(texture, pname, param); }
    [QGLNativeAPI("glTextureParameterf")] internal static delegate* unmanaged<uint, uint, float, void> _glTextureParameterf = null;
    
    public static void glTextureParameterfv(uint texture, uint pname, float* param) { QGLNativeAPI.Verify((nint)_glTextureParameterfv); _glTextureParameterfv(texture, pname, param); }
    [QGLNativeAPI("glTextureParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glTextureParameterfv = null;
    
    public static void glTextureParameteri(uint texture, uint pname, int param) { QGLNativeAPI.Verify((nint)_glTextureParameteri); _glTextureParameteri(texture, pname, param); }
    [QGLNativeAPI("glTextureParameteri")] internal static delegate* unmanaged<uint, uint, int, void> _glTextureParameteri = null;
    
    public static void glTextureParameterIiv(uint texture, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glTextureParameterIiv); _glTextureParameterIiv(texture, pname, @params); }
    [QGLNativeAPI("glTextureParameterIiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glTextureParameterIiv = null;
    
    public static void glTextureParameterIuiv(uint texture, uint pname, uint* @params) { QGLNativeAPI.Verify((nint)_glTextureParameterIuiv); _glTextureParameterIuiv(texture, pname, @params); }
    [QGLNativeAPI("glTextureParameterIuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glTextureParameterIuiv = null;
    
    public static void glTextureParameteriv(uint texture, uint pname, int* param) { QGLNativeAPI.Verify((nint)_glTextureParameteriv); _glTextureParameteriv(texture, pname, param); }
    [QGLNativeAPI("glTextureParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glTextureParameteriv = null;
    
    public static void glGenerateTextureMipmap(uint texture) { QGLNativeAPI.Verify((nint)_glGenerateTextureMipmap); _glGenerateTextureMipmap(texture); }
    [QGLNativeAPI("glGenerateTextureMipmap")] internal static delegate* unmanaged<uint, void> _glGenerateTextureMipmap = null;
    
    public static void glBindTextureUnit(uint unit, uint texture) { QGLNativeAPI.Verify((nint)_glBindTextureUnit); _glBindTextureUnit(unit, texture); }
    [QGLNativeAPI("glBindTextureUnit")] internal static delegate* unmanaged<uint, uint, void> _glBindTextureUnit = null;
    
    public static void glGetTextureImage(uint texture, int level, uint format, uint type, int bufSize, void* pixels) { QGLNativeAPI.Verify((nint)_glGetTextureImage); _glGetTextureImage(texture, level, format, type, bufSize, pixels); }
    [QGLNativeAPI("glGetTextureImage")] internal static delegate* unmanaged<uint, int, uint, uint, int, void*, void> _glGetTextureImage = null;
    
    public static void glGetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels) { QGLNativeAPI.Verify((nint)_glGetCompressedTextureImage); _glGetCompressedTextureImage(texture, level, bufSize, pixels); }
    [QGLNativeAPI("glGetCompressedTextureImage")] internal static delegate* unmanaged<uint, int, int, void*, void> _glGetCompressedTextureImage = null;
    
    public static void glGetTextureLevelParameterfv(uint texture, int level, uint pname, float* @params) { QGLNativeAPI.Verify((nint)_glGetTextureLevelParameterfv); _glGetTextureLevelParameterfv(texture, level, pname, @params); }
    [QGLNativeAPI("glGetTextureLevelParameterfv")] internal static delegate* unmanaged<uint, int, uint, float*, void> _glGetTextureLevelParameterfv = null;
    
    public static void glGetTextureLevelParameteriv(uint texture, int level, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetTextureLevelParameteriv); _glGetTextureLevelParameteriv(texture, level, pname, @params); }
    [QGLNativeAPI("glGetTextureLevelParameteriv")] internal static delegate* unmanaged<uint, int, uint, int*, void> _glGetTextureLevelParameteriv = null;
    
    public static void glGetTextureParameterfv(uint texture, uint pname, float* @params) { QGLNativeAPI.Verify((nint)_glGetTextureParameterfv); _glGetTextureParameterfv(texture, pname, @params); }
    [QGLNativeAPI("glGetTextureParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetTextureParameterfv = null;
    
    public static void glGetTextureParameterIiv(uint texture, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetTextureParameterIiv); _glGetTextureParameterIiv(texture, pname, @params); }
    [QGLNativeAPI("glGetTextureParameterIiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetTextureParameterIiv = null;
    
    public static void glGetTextureParameterIuiv(uint texture, uint pname, uint* @params) { QGLNativeAPI.Verify((nint)_glGetTextureParameterIuiv); _glGetTextureParameterIuiv(texture, pname, @params); }
    [QGLNativeAPI("glGetTextureParameterIuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glGetTextureParameterIuiv = null;
    
    public static void glGetTextureParameteriv(uint texture, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetTextureParameteriv); _glGetTextureParameteriv(texture, pname, @params); }
    [QGLNativeAPI("glGetTextureParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetTextureParameteriv = null;
    
    public static void glCreateVertexArrays(int n, uint* arrays) { QGLNativeAPI.Verify((nint)_glCreateVertexArrays); _glCreateVertexArrays(n, arrays); }
    [QGLNativeAPI("glCreateVertexArrays")] internal static delegate* unmanaged<int, uint*, void> _glCreateVertexArrays = null;
    
    public static void glDisableVertexArrayAttrib(uint vaobj, uint index) { QGLNativeAPI.Verify((nint)_glDisableVertexArrayAttrib); _glDisableVertexArrayAttrib(vaobj, index); }
    [QGLNativeAPI("glDisableVertexArrayAttrib")] internal static delegate* unmanaged<uint, uint, void> _glDisableVertexArrayAttrib = null;
    
    public static void glEnableVertexArrayAttrib(uint vaobj, uint index) { QGLNativeAPI.Verify((nint)_glEnableVertexArrayAttrib); _glEnableVertexArrayAttrib(vaobj, index); }
    [QGLNativeAPI("glEnableVertexArrayAttrib")] internal static delegate* unmanaged<uint, uint, void> _glEnableVertexArrayAttrib = null;
    
    public static void glVertexArrayElementBuffer(uint vaobj, uint buffer) { QGLNativeAPI.Verify((nint)_glVertexArrayElementBuffer); _glVertexArrayElementBuffer(vaobj, buffer); }
    [QGLNativeAPI("glVertexArrayElementBuffer")] internal static delegate* unmanaged<uint, uint, void> _glVertexArrayElementBuffer = null;
    
    public static void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, nint offset, int stride) { QGLNativeAPI.Verify((nint)_glVertexArrayVertexBuffer); _glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride); }
    [QGLNativeAPI("glVertexArrayVertexBuffer")] internal static delegate* unmanaged<uint, uint, uint, nint, int, void> _glVertexArrayVertexBuffer = null;
    
    public static void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, nint* offsets, int* strides) { QGLNativeAPI.Verify((nint)_glVertexArrayVertexBuffers); _glVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides); }
    [QGLNativeAPI("glVertexArrayVertexBuffers")] internal static delegate* unmanaged<uint, uint, int, uint*, nint*, int*, void> _glVertexArrayVertexBuffers = null;
    
    public static void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex) { QGLNativeAPI.Verify((nint)_glVertexArrayAttribBinding); _glVertexArrayAttribBinding(vaobj, attribindex, bindingindex); }
    [QGLNativeAPI("glVertexArrayAttribBinding")] internal static delegate* unmanaged<uint, uint, uint, void> _glVertexArrayAttribBinding = null;
    
    public static void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset) { QGLNativeAPI.Verify((nint)_glVertexArrayAttribFormat); _glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset); }
    [QGLNativeAPI("glVertexArrayAttribFormat")] internal static delegate* unmanaged<uint, uint, int, uint, bool, uint, void> _glVertexArrayAttribFormat = null;
    
    public static void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) { QGLNativeAPI.Verify((nint)_glVertexArrayAttribIFormat); _glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset); }
    [QGLNativeAPI("glVertexArrayAttribIFormat")] internal static delegate* unmanaged<uint, uint, int, uint, uint, void> _glVertexArrayAttribIFormat = null;
    
    public static void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) { QGLNativeAPI.Verify((nint)_glVertexArrayAttribLFormat); _glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset); }
    [QGLNativeAPI("glVertexArrayAttribLFormat")] internal static delegate* unmanaged<uint, uint, int, uint, uint, void> _glVertexArrayAttribLFormat = null;
    
    public static void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor) { QGLNativeAPI.Verify((nint)_glVertexArrayBindingDivisor); _glVertexArrayBindingDivisor(vaobj, bindingindex, divisor); }
    [QGLNativeAPI("glVertexArrayBindingDivisor")] internal static delegate* unmanaged<uint, uint, uint, void> _glVertexArrayBindingDivisor = null;
    
    public static void glGetVertexArrayiv(uint vaobj, uint pname, int* param) { QGLNativeAPI.Verify((nint)_glGetVertexArrayiv); _glGetVertexArrayiv(vaobj, pname, param); }
    [QGLNativeAPI("glGetVertexArrayiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetVertexArrayiv = null;
    
    public static void glGetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param) { QGLNativeAPI.Verify((nint)_glGetVertexArrayIndexediv); _glGetVertexArrayIndexediv(vaobj, index, pname, param); }
    [QGLNativeAPI("glGetVertexArrayIndexediv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetVertexArrayIndexediv = null;
    
    public static void glGetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long* param) { QGLNativeAPI.Verify((nint)_glGetVertexArrayIndexed64iv); _glGetVertexArrayIndexed64iv(vaobj, index, pname, param); }
    [QGLNativeAPI("glGetVertexArrayIndexed64iv")] internal static delegate* unmanaged<uint, uint, uint, long*, void> _glGetVertexArrayIndexed64iv = null;
    
    public static void glCreateSamplers(int n, uint* samplers) { QGLNativeAPI.Verify((nint)_glCreateSamplers); _glCreateSamplers(n, samplers); }
    [QGLNativeAPI("glCreateSamplers")] internal static delegate* unmanaged<int, uint*, void> _glCreateSamplers = null;
    
    public static void glCreateProgramPipelines(int n, uint* pipelines) { QGLNativeAPI.Verify((nint)_glCreateProgramPipelines); _glCreateProgramPipelines(n, pipelines); }
    [QGLNativeAPI("glCreateProgramPipelines")] internal static delegate* unmanaged<int, uint*, void> _glCreateProgramPipelines = null;
    
    public static void glCreateQueries(uint target, int n, uint* ids) { QGLNativeAPI.Verify((nint)_glCreateQueries); _glCreateQueries(target, n, ids); }
    [QGLNativeAPI("glCreateQueries")] internal static delegate* unmanaged<uint, int, uint*, void> _glCreateQueries = null;
    
    public static void glGetQueryBufferObjecti64v(uint id, uint buffer, uint pname, nint offset) { QGLNativeAPI.Verify((nint)_glGetQueryBufferObjecti64v); _glGetQueryBufferObjecti64v(id, buffer, pname, offset); }
    [QGLNativeAPI("glGetQueryBufferObjecti64v")] internal static delegate* unmanaged<uint, uint, uint, nint, void> _glGetQueryBufferObjecti64v = null;
    
    public static void glGetQueryBufferObjectiv(uint id, uint buffer, uint pname, nint offset) { QGLNativeAPI.Verify((nint)_glGetQueryBufferObjectiv); _glGetQueryBufferObjectiv(id, buffer, pname, offset); }
    [QGLNativeAPI("glGetQueryBufferObjectiv")] internal static delegate* unmanaged<uint, uint, uint, nint, void> _glGetQueryBufferObjectiv = null;
    
    public static void glGetQueryBufferObjectui64v(uint id, uint buffer, uint pname, nint offset) { QGLNativeAPI.Verify((nint)_glGetQueryBufferObjectui64v); _glGetQueryBufferObjectui64v(id, buffer, pname, offset); }
    [QGLNativeAPI("glGetQueryBufferObjectui64v")] internal static delegate* unmanaged<uint, uint, uint, nint, void> _glGetQueryBufferObjectui64v = null;
    
    public static void glGetQueryBufferObjectuiv(uint id, uint buffer, uint pname, nint offset) { QGLNativeAPI.Verify((nint)_glGetQueryBufferObjectuiv); _glGetQueryBufferObjectuiv(id, buffer, pname, offset); }
    [QGLNativeAPI("glGetQueryBufferObjectuiv")] internal static delegate* unmanaged<uint, uint, uint, nint, void> _glGetQueryBufferObjectuiv = null;
     #endregion
}
