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

// Bindings generated at 2025-08-30 15:45:08.507468
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_draw_indirect", true, false)]
public static unsafe class GLEXT_ARBdrawindirect
{
    #region Enums
    public const int GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
    public const int GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
    #endregion
    
    #region Commands
    public static void glDrawArraysIndirect(uint mode, void* indirect) { QGLNativeAPI.Verify((nint)_glDrawArraysIndirect); _glDrawArraysIndirect(mode, indirect); }
    [QGLNativeAPI("glDrawArraysIndirect")] internal static delegate* unmanaged<uint, void*, void> _glDrawArraysIndirect = null;
    
    public static void glDrawElementsIndirect(uint mode, uint type, void* indirect) { QGLNativeAPI.Verify((nint)_glDrawElementsIndirect); _glDrawElementsIndirect(mode, type, indirect); }
    [QGLNativeAPI("glDrawElementsIndirect")] internal static delegate* unmanaged<uint, uint, void*, void> _glDrawElementsIndirect = null;
     #endregion
}
