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

// Bindings generated at 2025-09-20 18:58:20.145730
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBviewportarray
{
    #region Enums
    public const int GL_SCISSOR_BOX = 0xC10;
    public const int GL_VIEWPORT = 0xBA2;
    public const int GL_DEPTH_RANGE = 0xB70;
    public const int GL_SCISSOR_TEST = 0xC11;
    public const int GL_MAX_VIEWPORTS = 0x825B;
    public const int GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;
    public const int GL_VIEWPORT_BOUNDS_RANGE = 0x825D;
    public const int GL_LAYER_PROVOKING_VERTEX = 0x825E;
    public const int GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
    public const int GL_UNDEFINED_VERTEX = 0x8260;
    public const int GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
    public const int GL_LAST_VERTEX_CONVENTION = 0x8E4E;
    public const int GL_PROVOKING_VERTEX = 0x8E4F;
    #endregion
    
    #region Commands
    public static void glViewportArrayv(uint first, int count, float* v) { QGLFeature.VerifyFunc((nint)_glViewportArrayv); _glViewportArrayv(first, count, v); }
    internal static delegate* unmanaged<uint, int, float*, void> _glViewportArrayv = null;
    
    public static void glViewportIndexedf(uint index, float x, float y, float w, float h) { QGLFeature.VerifyFunc((nint)_glViewportIndexedf); _glViewportIndexedf(index, x, y, w, h); }
    internal static delegate* unmanaged<uint, float, float, float, float, void> _glViewportIndexedf = null;
    
    public static void glViewportIndexedfv(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glViewportIndexedfv); _glViewportIndexedfv(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glViewportIndexedfv = null;
    
    public static void glScissorArrayv(uint first, int count, int* v) { QGLFeature.VerifyFunc((nint)_glScissorArrayv); _glScissorArrayv(first, count, v); }
    internal static delegate* unmanaged<uint, int, int*, void> _glScissorArrayv = null;
    
    public static void glScissorIndexed(uint index, int left, int bottom, int width, int height) { QGLFeature.VerifyFunc((nint)_glScissorIndexed); _glScissorIndexed(index, left, bottom, width, height); }
    internal static delegate* unmanaged<uint, int, int, int, int, void> _glScissorIndexed = null;
    
    public static void glScissorIndexedv(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glScissorIndexedv); _glScissorIndexedv(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glScissorIndexedv = null;
    
    public static void glDepthRangeArrayv(uint first, int count, double* v) { QGLFeature.VerifyFunc((nint)_glDepthRangeArrayv); _glDepthRangeArrayv(first, count, v); }
    internal static delegate* unmanaged<uint, int, double*, void> _glDepthRangeArrayv = null;
    
    public static void glDepthRangeIndexed(uint index, double n, double f) { QGLFeature.VerifyFunc((nint)_glDepthRangeIndexed); _glDepthRangeIndexed(index, n, f); }
    internal static delegate* unmanaged<uint, double, double, void> _glDepthRangeIndexed = null;
    
    public static void glGetFloati_v(uint target, uint index, float* data) { QGLFeature.VerifyFunc((nint)_glGetFloati_v); _glGetFloati_v(target, index, data); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetFloati_v = null;
    
    public static void glGetDoublei_v(uint target, uint index, double* data) { QGLFeature.VerifyFunc((nint)_glGetDoublei_v); _glGetDoublei_v(target, index, data); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glGetDoublei_v = null;
    
    public static void glDepthRangeArraydvNV(uint first, int count, double* v) { QGLFeature.VerifyFunc((nint)_glDepthRangeArraydvNV); _glDepthRangeArraydvNV(first, count, v); }
    internal static delegate* unmanaged<uint, int, double*, void> _glDepthRangeArraydvNV = null;
    
    public static void glDepthRangeIndexeddNV(uint index, double n, double f) { QGLFeature.VerifyFunc((nint)_glDepthRangeIndexeddNV); _glDepthRangeIndexeddNV(index, n, f); }
    internal static delegate* unmanaged<uint, double, double, void> _glDepthRangeIndexeddNV = null;
     #endregion
    
    internal static void Load()
    {
        _glViewportArrayv = (delegate* unmanaged<uint, int, float*, void>)QuickGL.GetGLProcAddress("glViewportArrayv");
        _glViewportIndexedf = (delegate* unmanaged<uint, float, float, float, float, void>)QuickGL.GetGLProcAddress("glViewportIndexedf");
        _glViewportIndexedfv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glViewportIndexedfv");
        _glScissorArrayv = (delegate* unmanaged<uint, int, int*, void>)QuickGL.GetGLProcAddress("glScissorArrayv");
        _glScissorIndexed = (delegate* unmanaged<uint, int, int, int, int, void>)QuickGL.GetGLProcAddress("glScissorIndexed");
        _glScissorIndexedv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glScissorIndexedv");
        _glDepthRangeArrayv = (delegate* unmanaged<uint, int, double*, void>)QuickGL.GetGLProcAddress("glDepthRangeArrayv");
        _glDepthRangeIndexed = (delegate* unmanaged<uint, double, double, void>)QuickGL.GetGLProcAddress("glDepthRangeIndexed");
        _glGetFloati_v = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetFloati_v");
        _glGetDoublei_v = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glGetDoublei_v");
        _glDepthRangeArraydvNV = (delegate* unmanaged<uint, int, double*, void>)QuickGL.GetGLProcAddress("glDepthRangeArraydvNV");
        _glDepthRangeIndexeddNV = (delegate* unmanaged<uint, double, double, void>)QuickGL.GetGLProcAddress("glDepthRangeIndexeddNV");
    }
    
    internal static void Unload()
    {
        _glViewportArrayv = null;
        _glViewportIndexedf = null;
        _glViewportIndexedfv = null;
        _glScissorArrayv = null;
        _glScissorIndexed = null;
        _glScissorIndexedv = null;
        _glDepthRangeArrayv = null;
        _glDepthRangeIndexed = null;
        _glGetFloati_v = null;
        _glGetDoublei_v = null;
        _glDepthRangeArraydvNV = null;
        _glDepthRangeIndexeddNV = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_viewport_array", true, false);
}
