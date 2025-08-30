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

// Bindings generated at 2025-08-30 15:45:08.543840
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_indirect_parameters", true, false)]
public static unsafe class GLEXT_ARBindirectparameters
{
    #region Enums
    public const int GL_PARAMETER_BUFFER_ARB = 0x80EE;
    public const int GL_PARAMETER_BUFFER_BINDING_ARB = 0x80EF;
    #endregion
    
    #region Commands
    public static void glMultiDrawArraysIndirectCountARB(uint mode, void* indirect, nint drawcount, int maxdrawcount, int stride) { QGLNativeAPI.Verify((nint)_glMultiDrawArraysIndirectCountARB); _glMultiDrawArraysIndirectCountARB(mode, indirect, drawcount, maxdrawcount, stride); }
    [QGLNativeAPI("glMultiDrawArraysIndirectCountARB")] internal static delegate* unmanaged<uint, void*, nint, int, int, void> _glMultiDrawArraysIndirectCountARB = null;
    
    public static void glMultiDrawElementsIndirectCountARB(uint mode, uint type, void* indirect, nint drawcount, int maxdrawcount, int stride) { QGLNativeAPI.Verify((nint)_glMultiDrawElementsIndirectCountARB); _glMultiDrawElementsIndirectCountARB(mode, type, indirect, drawcount, maxdrawcount, stride); }
    [QGLNativeAPI("glMultiDrawElementsIndirectCountARB")] internal static delegate* unmanaged<uint, uint, void*, nint, int, int, void> _glMultiDrawElementsIndirectCountARB = null;
     #endregion
}
