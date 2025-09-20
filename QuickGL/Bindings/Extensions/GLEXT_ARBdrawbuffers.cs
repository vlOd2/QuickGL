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

// Bindings generated at 2025-09-20 18:58:19.860310
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBdrawbuffers
{
    #region Enums
    public const int GL_MAX_DRAW_BUFFERS_ARB = 0x8824;
    public const int GL_DRAW_BUFFER0_ARB = 0x8825;
    public const int GL_DRAW_BUFFER1_ARB = 0x8826;
    public const int GL_DRAW_BUFFER2_ARB = 0x8827;
    public const int GL_DRAW_BUFFER3_ARB = 0x8828;
    public const int GL_DRAW_BUFFER4_ARB = 0x8829;
    public const int GL_DRAW_BUFFER5_ARB = 0x882A;
    public const int GL_DRAW_BUFFER6_ARB = 0x882B;
    public const int GL_DRAW_BUFFER7_ARB = 0x882C;
    public const int GL_DRAW_BUFFER8_ARB = 0x882D;
    public const int GL_DRAW_BUFFER9_ARB = 0x882E;
    public const int GL_DRAW_BUFFER10_ARB = 0x882F;
    public const int GL_DRAW_BUFFER11_ARB = 0x8830;
    public const int GL_DRAW_BUFFER12_ARB = 0x8831;
    public const int GL_DRAW_BUFFER13_ARB = 0x8832;
    public const int GL_DRAW_BUFFER14_ARB = 0x8833;
    public const int GL_DRAW_BUFFER15_ARB = 0x8834;
    #endregion
    
    #region Commands
    public static void glDrawBuffersARB(int n, uint* bufs) { QGLFeature.VerifyFunc((nint)_glDrawBuffersARB); _glDrawBuffersARB(n, bufs); }
    internal static delegate* unmanaged<int, uint*, void> _glDrawBuffersARB = null;
     #endregion
    
    internal static void Load()
    {
        _glDrawBuffersARB = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDrawBuffersARB");
    }
    
    internal static void Unload()
    {
        _glDrawBuffersARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_draw_buffers", true, false);
}
