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

// Bindings generated at 2025-09-20 18:58:19.906697
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBinvalidatesubdata
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glInvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) { QGLFeature.VerifyFunc((nint)_glInvalidateTexSubImage); _glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, void> _glInvalidateTexSubImage = null;
    
    public static void glInvalidateTexImage(uint texture, int level) { QGLFeature.VerifyFunc((nint)_glInvalidateTexImage); _glInvalidateTexImage(texture, level); }
    internal static delegate* unmanaged<uint, int, void> _glInvalidateTexImage = null;
    
    public static void glInvalidateBufferSubData(uint buffer, nint offset, nint length) { QGLFeature.VerifyFunc((nint)_glInvalidateBufferSubData); _glInvalidateBufferSubData(buffer, offset, length); }
    internal static delegate* unmanaged<uint, nint, nint, void> _glInvalidateBufferSubData = null;
    
    public static void glInvalidateBufferData(uint buffer) { QGLFeature.VerifyFunc((nint)_glInvalidateBufferData); _glInvalidateBufferData(buffer); }
    internal static delegate* unmanaged<uint, void> _glInvalidateBufferData = null;
    
    public static void glInvalidateFramebuffer(uint target, int numAttachments, uint* attachments) { QGLFeature.VerifyFunc((nint)_glInvalidateFramebuffer); _glInvalidateFramebuffer(target, numAttachments, attachments); }
    internal static delegate* unmanaged<uint, int, uint*, void> _glInvalidateFramebuffer = null;
    
    public static void glInvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height) { QGLFeature.VerifyFunc((nint)_glInvalidateSubFramebuffer); _glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height); }
    internal static delegate* unmanaged<uint, int, uint*, int, int, int, int, void> _glInvalidateSubFramebuffer = null;
     #endregion
    
    internal static void Load()
    {
        _glInvalidateTexSubImage = (delegate* unmanaged<uint, int, int, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glInvalidateTexSubImage");
        _glInvalidateTexImage = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glInvalidateTexImage");
        _glInvalidateBufferSubData = (delegate* unmanaged<uint, nint, nint, void>)QuickGL.GetGLProcAddress("glInvalidateBufferSubData");
        _glInvalidateBufferData = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glInvalidateBufferData");
        _glInvalidateFramebuffer = (delegate* unmanaged<uint, int, uint*, void>)QuickGL.GetGLProcAddress("glInvalidateFramebuffer");
        _glInvalidateSubFramebuffer = (delegate* unmanaged<uint, int, uint*, int, int, int, int, void>)QuickGL.GetGLProcAddress("glInvalidateSubFramebuffer");
    }
    
    internal static void Unload()
    {
        _glInvalidateTexSubImage = null;
        _glInvalidateTexImage = null;
        _glInvalidateBufferSubData = null;
        _glInvalidateBufferData = null;
        _glInvalidateFramebuffer = null;
        _glInvalidateSubFramebuffer = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_invalidate_subdata", true, false);
}
