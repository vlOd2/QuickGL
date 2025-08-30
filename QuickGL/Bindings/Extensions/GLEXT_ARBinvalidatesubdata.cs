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

// Bindings generated at 2025-08-30 15:45:08.548259
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_invalidate_subdata", true, false)]
public static unsafe class GLEXT_ARBinvalidatesubdata
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) { QGLNativeAPI.Verify((nint)_glInvalidateTexSubImage); _glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth); }
    [QGLNativeAPI("glInvalidateTexSubImage")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, void> _glInvalidateTexSubImage = null;
    
    public static void glInvalidateTexImage(uint texture, int level) { QGLNativeAPI.Verify((nint)_glInvalidateTexImage); _glInvalidateTexImage(texture, level); }
    [QGLNativeAPI("glInvalidateTexImage")] internal static delegate* unmanaged<uint, int, void> _glInvalidateTexImage = null;
    
    public static void glInvalidateBufferSubData(uint buffer, nint offset, nint length) { QGLNativeAPI.Verify((nint)_glInvalidateBufferSubData); _glInvalidateBufferSubData(buffer, offset, length); }
    [QGLNativeAPI("glInvalidateBufferSubData")] internal static delegate* unmanaged<uint, nint, nint, void> _glInvalidateBufferSubData = null;
    
    public static void glInvalidateBufferData(uint buffer) { QGLNativeAPI.Verify((nint)_glInvalidateBufferData); _glInvalidateBufferData(buffer); }
    [QGLNativeAPI("glInvalidateBufferData")] internal static delegate* unmanaged<uint, void> _glInvalidateBufferData = null;
    
    public static void glInvalidateFramebuffer(uint target, int numAttachments, uint* attachments) { QGLNativeAPI.Verify((nint)_glInvalidateFramebuffer); _glInvalidateFramebuffer(target, numAttachments, attachments); }
    [QGLNativeAPI("glInvalidateFramebuffer")] internal static delegate* unmanaged<uint, int, uint*, void> _glInvalidateFramebuffer = null;
    
    public static void glInvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height) { QGLNativeAPI.Verify((nint)_glInvalidateSubFramebuffer); _glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height); }
    [QGLNativeAPI("glInvalidateSubFramebuffer")] internal static delegate* unmanaged<uint, int, uint*, int, int, int, int, void> _glInvalidateSubFramebuffer = null;
     #endregion
}
