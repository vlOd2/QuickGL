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

// Bindings generated at 2025-09-20 18:58:19.865973
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBdrawindirect
{
    #region Enums
    public const int GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
    public const int GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
    #endregion
    
    #region Commands
    public static void glDrawArraysIndirect(uint mode, void* indirect) { QGLFeature.VerifyFunc((nint)_glDrawArraysIndirect); _glDrawArraysIndirect(mode, indirect); }
    internal static delegate* unmanaged<uint, void*, void> _glDrawArraysIndirect = null;
    
    public static void glDrawElementsIndirect(uint mode, uint type, void* indirect) { QGLFeature.VerifyFunc((nint)_glDrawElementsIndirect); _glDrawElementsIndirect(mode, type, indirect); }
    internal static delegate* unmanaged<uint, uint, void*, void> _glDrawElementsIndirect = null;
     #endregion
    
    internal static void Load()
    {
        _glDrawArraysIndirect = (delegate* unmanaged<uint, void*, void>)QuickGL.GetGLProcAddress("glDrawArraysIndirect");
        _glDrawElementsIndirect = (delegate* unmanaged<uint, uint, void*, void>)QuickGL.GetGLProcAddress("glDrawElementsIndirect");
    }
    
    internal static void Unload()
    {
        _glDrawArraysIndirect = null;
        _glDrawElementsIndirect = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_draw_indirect", true, false);
}
