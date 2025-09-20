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

// Bindings generated at 2025-09-20 18:58:19.912149
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBmultibind
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glBindBuffersBase(uint target, uint first, int count, uint* buffers) { QGLFeature.VerifyFunc((nint)_glBindBuffersBase); _glBindBuffersBase(target, first, count, buffers); }
    internal static delegate* unmanaged<uint, uint, int, uint*, void> _glBindBuffersBase = null;
    
    public static void glBindBuffersRange(uint target, uint first, int count, uint* buffers, nint* offsets, nint* sizes) { QGLFeature.VerifyFunc((nint)_glBindBuffersRange); _glBindBuffersRange(target, first, count, buffers, offsets, sizes); }
    internal static delegate* unmanaged<uint, uint, int, uint*, nint*, nint*, void> _glBindBuffersRange = null;
    
    public static void glBindTextures(uint first, int count, uint* textures) { QGLFeature.VerifyFunc((nint)_glBindTextures); _glBindTextures(first, count, textures); }
    internal static delegate* unmanaged<uint, int, uint*, void> _glBindTextures = null;
    
    public static void glBindSamplers(uint first, int count, uint* samplers) { QGLFeature.VerifyFunc((nint)_glBindSamplers); _glBindSamplers(first, count, samplers); }
    internal static delegate* unmanaged<uint, int, uint*, void> _glBindSamplers = null;
    
    public static void glBindImageTextures(uint first, int count, uint* textures) { QGLFeature.VerifyFunc((nint)_glBindImageTextures); _glBindImageTextures(first, count, textures); }
    internal static delegate* unmanaged<uint, int, uint*, void> _glBindImageTextures = null;
    
    public static void glBindVertexBuffers(uint first, int count, uint* buffers, nint* offsets, int* strides) { QGLFeature.VerifyFunc((nint)_glBindVertexBuffers); _glBindVertexBuffers(first, count, buffers, offsets, strides); }
    internal static delegate* unmanaged<uint, int, uint*, nint*, int*, void> _glBindVertexBuffers = null;
     #endregion
    
    internal static void Load()
    {
        _glBindBuffersBase = (delegate* unmanaged<uint, uint, int, uint*, void>)QuickGL.GetGLProcAddress("glBindBuffersBase");
        _glBindBuffersRange = (delegate* unmanaged<uint, uint, int, uint*, nint*, nint*, void>)QuickGL.GetGLProcAddress("glBindBuffersRange");
        _glBindTextures = (delegate* unmanaged<uint, int, uint*, void>)QuickGL.GetGLProcAddress("glBindTextures");
        _glBindSamplers = (delegate* unmanaged<uint, int, uint*, void>)QuickGL.GetGLProcAddress("glBindSamplers");
        _glBindImageTextures = (delegate* unmanaged<uint, int, uint*, void>)QuickGL.GetGLProcAddress("glBindImageTextures");
        _glBindVertexBuffers = (delegate* unmanaged<uint, int, uint*, nint*, int*, void>)QuickGL.GetGLProcAddress("glBindVertexBuffers");
    }
    
    internal static void Unload()
    {
        _glBindBuffersBase = null;
        _glBindBuffersRange = null;
        _glBindTextures = null;
        _glBindSamplers = null;
        _glBindImageTextures = null;
        _glBindVertexBuffers = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_multi_bind", true, false);
}
