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

// Bindings generated at 2025-08-30 15:45:08.553773
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_multi_bind", true, false)]
public static unsafe class GLEXT_ARBmultibind
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glBindBuffersBase(uint target, uint first, int count, uint* buffers) { QGLNativeAPI.Verify((nint)_glBindBuffersBase); _glBindBuffersBase(target, first, count, buffers); }
    [QGLNativeAPI("glBindBuffersBase")] internal static delegate* unmanaged<uint, uint, int, uint*, void> _glBindBuffersBase = null;
    
    public static void glBindBuffersRange(uint target, uint first, int count, uint* buffers, nint* offsets, nint* sizes) { QGLNativeAPI.Verify((nint)_glBindBuffersRange); _glBindBuffersRange(target, first, count, buffers, offsets, sizes); }
    [QGLNativeAPI("glBindBuffersRange")] internal static delegate* unmanaged<uint, uint, int, uint*, nint*, nint*, void> _glBindBuffersRange = null;
    
    public static void glBindTextures(uint first, int count, uint* textures) { QGLNativeAPI.Verify((nint)_glBindTextures); _glBindTextures(first, count, textures); }
    [QGLNativeAPI("glBindTextures")] internal static delegate* unmanaged<uint, int, uint*, void> _glBindTextures = null;
    
    public static void glBindSamplers(uint first, int count, uint* samplers) { QGLNativeAPI.Verify((nint)_glBindSamplers); _glBindSamplers(first, count, samplers); }
    [QGLNativeAPI("glBindSamplers")] internal static delegate* unmanaged<uint, int, uint*, void> _glBindSamplers = null;
    
    public static void glBindImageTextures(uint first, int count, uint* textures) { QGLNativeAPI.Verify((nint)_glBindImageTextures); _glBindImageTextures(first, count, textures); }
    [QGLNativeAPI("glBindImageTextures")] internal static delegate* unmanaged<uint, int, uint*, void> _glBindImageTextures = null;
    
    public static void glBindVertexBuffers(uint first, int count, uint* buffers, nint* offsets, int* strides) { QGLNativeAPI.Verify((nint)_glBindVertexBuffers); _glBindVertexBuffers(first, count, buffers, offsets, strides); }
    [QGLNativeAPI("glBindVertexBuffers")] internal static delegate* unmanaged<uint, int, uint*, nint*, int*, void> _glBindVertexBuffers = null;
     #endregion
}
