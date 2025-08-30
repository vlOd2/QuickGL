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

// Bindings generated at 2025-08-30 15:45:08.521841
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_framebuffer_no_attachments", true, false)]
public static unsafe class GLEXT_ARBframebuffernoattachments
{
    #region Enums
    public const int GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
    public const int GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
    public const int GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
    public const int GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
    public const int GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
    public const int GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
    public const int GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
    public const int GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
    public const int GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
    #endregion
    
    #region Commands
    public static void glFramebufferParameteri(uint target, uint pname, int param) { QGLNativeAPI.Verify((nint)_glFramebufferParameteri); _glFramebufferParameteri(target, pname, param); }
    [QGLNativeAPI("glFramebufferParameteri")] internal static delegate* unmanaged<uint, uint, int, void> _glFramebufferParameteri = null;
    
    public static void glGetFramebufferParameteriv(uint target, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetFramebufferParameteriv); _glGetFramebufferParameteriv(target, pname, @params); }
    [QGLNativeAPI("glGetFramebufferParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetFramebufferParameteriv = null;
     #endregion
}
