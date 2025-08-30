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

// Bindings generated at 2025-08-30 15:45:08.505549
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_draw_buffers_blend", true, false)]
public static unsafe class GLEXT_ARBdrawbuffersblend
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glBlendEquationiARB(uint buf, uint mode) { QGLNativeAPI.Verify((nint)_glBlendEquationiARB); _glBlendEquationiARB(buf, mode); }
    [QGLNativeAPI("glBlendEquationiARB")] internal static delegate* unmanaged<uint, uint, void> _glBlendEquationiARB = null;
    
    public static void glBlendEquationSeparateiARB(uint buf, uint modeRGB, uint modeAlpha) { QGLNativeAPI.Verify((nint)_glBlendEquationSeparateiARB); _glBlendEquationSeparateiARB(buf, modeRGB, modeAlpha); }
    [QGLNativeAPI("glBlendEquationSeparateiARB")] internal static delegate* unmanaged<uint, uint, uint, void> _glBlendEquationSeparateiARB = null;
    
    public static void glBlendFunciARB(uint buf, uint src, uint dst) { QGLNativeAPI.Verify((nint)_glBlendFunciARB); _glBlendFunciARB(buf, src, dst); }
    [QGLNativeAPI("glBlendFunciARB")] internal static delegate* unmanaged<uint, uint, uint, void> _glBlendFunciARB = null;
    
    public static void glBlendFuncSeparateiARB(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) { QGLNativeAPI.Verify((nint)_glBlendFuncSeparateiARB); _glBlendFuncSeparateiARB(buf, srcRGB, dstRGB, srcAlpha, dstAlpha); }
    [QGLNativeAPI("glBlendFuncSeparateiARB")] internal static delegate* unmanaged<uint, uint, uint, uint, uint, void> _glBlendFuncSeparateiARB = null;
     #endregion
}
