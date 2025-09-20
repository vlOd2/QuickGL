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

// Bindings generated at 2025-09-20 18:58:19.861725
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBdrawbuffersblend
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glBlendEquationiARB(uint buf, uint mode) { QGLFeature.VerifyFunc((nint)_glBlendEquationiARB); _glBlendEquationiARB(buf, mode); }
    internal static delegate* unmanaged<uint, uint, void> _glBlendEquationiARB = null;
    
    public static void glBlendEquationSeparateiARB(uint buf, uint modeRGB, uint modeAlpha) { QGLFeature.VerifyFunc((nint)_glBlendEquationSeparateiARB); _glBlendEquationSeparateiARB(buf, modeRGB, modeAlpha); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glBlendEquationSeparateiARB = null;
    
    public static void glBlendFunciARB(uint buf, uint src, uint dst) { QGLFeature.VerifyFunc((nint)_glBlendFunciARB); _glBlendFunciARB(buf, src, dst); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glBlendFunciARB = null;
    
    public static void glBlendFuncSeparateiARB(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) { QGLFeature.VerifyFunc((nint)_glBlendFuncSeparateiARB); _glBlendFuncSeparateiARB(buf, srcRGB, dstRGB, srcAlpha, dstAlpha); }
    internal static delegate* unmanaged<uint, uint, uint, uint, uint, void> _glBlendFuncSeparateiARB = null;
     #endregion
    
    internal static void Load()
    {
        _glBlendEquationiARB = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBlendEquationiARB");
        _glBlendEquationSeparateiARB = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glBlendEquationSeparateiARB");
        _glBlendFunciARB = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glBlendFunciARB");
        _glBlendFuncSeparateiARB = (delegate* unmanaged<uint, uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glBlendFuncSeparateiARB");
    }
    
    internal static void Unload()
    {
        _glBlendEquationiARB = null;
        _glBlendEquationSeparateiARB = null;
        _glBlendFunciARB = null;
        _glBlendFuncSeparateiARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_draw_buffers_blend", true, false);
}
