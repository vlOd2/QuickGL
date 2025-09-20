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

// Bindings generated at 2025-09-20 18:58:19.914587
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBmultidrawindirect
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glMultiDrawArraysIndirect(uint mode, void* indirect, int drawcount, int stride) { QGLFeature.VerifyFunc((nint)_glMultiDrawArraysIndirect); _glMultiDrawArraysIndirect(mode, indirect, drawcount, stride); }
    internal static delegate* unmanaged<uint, void*, int, int, void> _glMultiDrawArraysIndirect = null;
    
    public static void glMultiDrawElementsIndirect(uint mode, uint type, void* indirect, int drawcount, int stride) { QGLFeature.VerifyFunc((nint)_glMultiDrawElementsIndirect); _glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride); }
    internal static delegate* unmanaged<uint, uint, void*, int, int, void> _glMultiDrawElementsIndirect = null;
     #endregion
    
    internal static void Load()
    {
        _glMultiDrawArraysIndirect = (delegate* unmanaged<uint, void*, int, int, void>)QuickGL.GetGLProcAddress("glMultiDrawArraysIndirect");
        _glMultiDrawElementsIndirect = (delegate* unmanaged<uint, uint, void*, int, int, void>)QuickGL.GetGLProcAddress("glMultiDrawElementsIndirect");
    }
    
    internal static void Unload()
    {
        _glMultiDrawArraysIndirect = null;
        _glMultiDrawElementsIndirect = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_multi_draw_indirect", true, false);
}
