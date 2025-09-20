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

// Bindings generated at 2025-09-20 18:58:19.866929
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBdrawinstanced
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glDrawArraysInstancedARB(uint mode, int first, int count, int primcount) { QGLFeature.VerifyFunc((nint)_glDrawArraysInstancedARB); _glDrawArraysInstancedARB(mode, first, count, primcount); }
    internal static delegate* unmanaged<uint, int, int, int, void> _glDrawArraysInstancedARB = null;
    
    public static void glDrawElementsInstancedARB(uint mode, int count, uint type, void* indices, int primcount) { QGLFeature.VerifyFunc((nint)_glDrawElementsInstancedARB); _glDrawElementsInstancedARB(mode, count, type, indices, primcount); }
    internal static delegate* unmanaged<uint, int, uint, void*, int, void> _glDrawElementsInstancedARB = null;
     #endregion
    
    internal static void Load()
    {
        _glDrawArraysInstancedARB = (delegate* unmanaged<uint, int, int, int, void>)QuickGL.GetGLProcAddress("glDrawArraysInstancedARB");
        _glDrawElementsInstancedARB = (delegate* unmanaged<uint, int, uint, void*, int, void>)QuickGL.GetGLProcAddress("glDrawElementsInstancedARB");
    }
    
    internal static void Unload()
    {
        _glDrawArraysInstancedARB = null;
        _glDrawElementsInstancedARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_draw_instanced", true, false);
}
