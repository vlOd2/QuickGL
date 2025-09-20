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

// Bindings generated at 2025-09-20 18:58:19.941038
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBrobustness
{
    #region Enums
    public const int GL_NO_ERROR = 0x0;
    public const int GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x4;
    public const int GL_LOSE_CONTEXT_ON_RESET_ARB = 0x8252;
    public const int GL_GUILTY_CONTEXT_RESET_ARB = 0x8253;
    public const int GL_INNOCENT_CONTEXT_RESET_ARB = 0x8254;
    public const int GL_UNKNOWN_CONTEXT_RESET_ARB = 0x8255;
    public const int GL_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;
    public const int GL_NO_RESET_NOTIFICATION_ARB = 0x8261;
    #endregion
    
    #region Commands
    public static uint glGetGraphicsResetStatusARB() { QGLFeature.VerifyFunc((nint)_glGetGraphicsResetStatusARB); return _glGetGraphicsResetStatusARB(); }
    internal static delegate* unmanaged<uint> _glGetGraphicsResetStatusARB = null;
    
    public static void glGetnTexImageARB(uint target, int level, uint format, uint type, int bufSize, void* img) { QGLFeature.VerifyFunc((nint)_glGetnTexImageARB); _glGetnTexImageARB(target, level, format, type, bufSize, img); }
    internal static delegate* unmanaged<uint, int, uint, uint, int, void*, void> _glGetnTexImageARB = null;
    
    public static void glReadnPixelsARB(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data) { QGLFeature.VerifyFunc((nint)_glReadnPixelsARB); _glReadnPixelsARB(x, y, width, height, format, type, bufSize, data); }
    internal static delegate* unmanaged<int, int, int, int, uint, uint, int, void*, void> _glReadnPixelsARB = null;
    
    public static void glGetnCompressedTexImageARB(uint target, int lod, int bufSize, void* img) { QGLFeature.VerifyFunc((nint)_glGetnCompressedTexImageARB); _glGetnCompressedTexImageARB(target, lod, bufSize, img); }
    internal static delegate* unmanaged<uint, int, int, void*, void> _glGetnCompressedTexImageARB = null;
    
    public static void glGetnUniformfvARB(uint program, int location, int bufSize, float* @params) { QGLFeature.VerifyFunc((nint)_glGetnUniformfvARB); _glGetnUniformfvARB(program, location, bufSize, @params); }
    internal static delegate* unmanaged<uint, int, int, float*, void> _glGetnUniformfvARB = null;
    
    public static void glGetnUniformivARB(uint program, int location, int bufSize, int* @params) { QGLFeature.VerifyFunc((nint)_glGetnUniformivARB); _glGetnUniformivARB(program, location, bufSize, @params); }
    internal static delegate* unmanaged<uint, int, int, int*, void> _glGetnUniformivARB = null;
    
    public static void glGetnUniformuivARB(uint program, int location, int bufSize, uint* @params) { QGLFeature.VerifyFunc((nint)_glGetnUniformuivARB); _glGetnUniformuivARB(program, location, bufSize, @params); }
    internal static delegate* unmanaged<uint, int, int, uint*, void> _glGetnUniformuivARB = null;
    
    public static void glGetnUniformdvARB(uint program, int location, int bufSize, double* @params) { QGLFeature.VerifyFunc((nint)_glGetnUniformdvARB); _glGetnUniformdvARB(program, location, bufSize, @params); }
    internal static delegate* unmanaged<uint, int, int, double*, void> _glGetnUniformdvARB = null;
    
    public static void glGetnMapdvARB(uint target, uint query, int bufSize, double* v) { QGLFeature.VerifyFunc((nint)_glGetnMapdvARB); _glGetnMapdvARB(target, query, bufSize, v); }
    internal static delegate* unmanaged<uint, uint, int, double*, void> _glGetnMapdvARB = null;
    
    public static void glGetnMapfvARB(uint target, uint query, int bufSize, float* v) { QGLFeature.VerifyFunc((nint)_glGetnMapfvARB); _glGetnMapfvARB(target, query, bufSize, v); }
    internal static delegate* unmanaged<uint, uint, int, float*, void> _glGetnMapfvARB = null;
    
    public static void glGetnMapivARB(uint target, uint query, int bufSize, int* v) { QGLFeature.VerifyFunc((nint)_glGetnMapivARB); _glGetnMapivARB(target, query, bufSize, v); }
    internal static delegate* unmanaged<uint, uint, int, int*, void> _glGetnMapivARB = null;
    
    public static void glGetnPixelMapfvARB(uint map, int bufSize, float* values) { QGLFeature.VerifyFunc((nint)_glGetnPixelMapfvARB); _glGetnPixelMapfvARB(map, bufSize, values); }
    internal static delegate* unmanaged<uint, int, float*, void> _glGetnPixelMapfvARB = null;
    
    public static void glGetnPixelMapuivARB(uint map, int bufSize, uint* values) { QGLFeature.VerifyFunc((nint)_glGetnPixelMapuivARB); _glGetnPixelMapuivARB(map, bufSize, values); }
    internal static delegate* unmanaged<uint, int, uint*, void> _glGetnPixelMapuivARB = null;
    
    public static void glGetnPixelMapusvARB(uint map, int bufSize, ushort* values) { QGLFeature.VerifyFunc((nint)_glGetnPixelMapusvARB); _glGetnPixelMapusvARB(map, bufSize, values); }
    internal static delegate* unmanaged<uint, int, ushort*, void> _glGetnPixelMapusvARB = null;
    
    public static void glGetnPolygonStippleARB(int bufSize, byte* pattern) { QGLFeature.VerifyFunc((nint)_glGetnPolygonStippleARB); _glGetnPolygonStippleARB(bufSize, pattern); }
    internal static delegate* unmanaged<int, byte*, void> _glGetnPolygonStippleARB = null;
    
    public static void glGetnColorTableARB(uint target, uint format, uint type, int bufSize, void* table) { QGLFeature.VerifyFunc((nint)_glGetnColorTableARB); _glGetnColorTableARB(target, format, type, bufSize, table); }
    internal static delegate* unmanaged<uint, uint, uint, int, void*, void> _glGetnColorTableARB = null;
    
    public static void glGetnConvolutionFilterARB(uint target, uint format, uint type, int bufSize, void* image) { QGLFeature.VerifyFunc((nint)_glGetnConvolutionFilterARB); _glGetnConvolutionFilterARB(target, format, type, bufSize, image); }
    internal static delegate* unmanaged<uint, uint, uint, int, void*, void> _glGetnConvolutionFilterARB = null;
    
    public static void glGetnSeparableFilterARB(uint target, uint format, uint type, int rowBufSize, void* row, int columnBufSize, void* column, void* span) { QGLFeature.VerifyFunc((nint)_glGetnSeparableFilterARB); _glGetnSeparableFilterARB(target, format, type, rowBufSize, row, columnBufSize, column, span); }
    internal static delegate* unmanaged<uint, uint, uint, int, void*, int, void*, void*, void> _glGetnSeparableFilterARB = null;
    
    public static void glGetnHistogramARB(uint target, bool reset, uint format, uint type, int bufSize, void* values) { QGLFeature.VerifyFunc((nint)_glGetnHistogramARB); _glGetnHistogramARB(target, reset, format, type, bufSize, values); }
    internal static delegate* unmanaged<uint, bool, uint, uint, int, void*, void> _glGetnHistogramARB = null;
    
    public static void glGetnMinmaxARB(uint target, bool reset, uint format, uint type, int bufSize, void* values) { QGLFeature.VerifyFunc((nint)_glGetnMinmaxARB); _glGetnMinmaxARB(target, reset, format, type, bufSize, values); }
    internal static delegate* unmanaged<uint, bool, uint, uint, int, void*, void> _glGetnMinmaxARB = null;
     #endregion
    
    internal static void Load()
    {
        _glGetGraphicsResetStatusARB = (delegate* unmanaged<uint>)QuickGL.GetGLProcAddress("glGetGraphicsResetStatusARB");
        _glGetnTexImageARB = (delegate* unmanaged<uint, int, uint, uint, int, void*, void>)QuickGL.GetGLProcAddress("glGetnTexImageARB");
        _glReadnPixelsARB = (delegate* unmanaged<int, int, int, int, uint, uint, int, void*, void>)QuickGL.GetGLProcAddress("glReadnPixelsARB");
        _glGetnCompressedTexImageARB = (delegate* unmanaged<uint, int, int, void*, void>)QuickGL.GetGLProcAddress("glGetnCompressedTexImageARB");
        _glGetnUniformfvARB = (delegate* unmanaged<uint, int, int, float*, void>)QuickGL.GetGLProcAddress("glGetnUniformfvARB");
        _glGetnUniformivARB = (delegate* unmanaged<uint, int, int, int*, void>)QuickGL.GetGLProcAddress("glGetnUniformivARB");
        _glGetnUniformuivARB = (delegate* unmanaged<uint, int, int, uint*, void>)QuickGL.GetGLProcAddress("glGetnUniformuivARB");
        _glGetnUniformdvARB = (delegate* unmanaged<uint, int, int, double*, void>)QuickGL.GetGLProcAddress("glGetnUniformdvARB");
        _glGetnMapdvARB = (delegate* unmanaged<uint, uint, int, double*, void>)QuickGL.GetGLProcAddress("glGetnMapdvARB");
        _glGetnMapfvARB = (delegate* unmanaged<uint, uint, int, float*, void>)QuickGL.GetGLProcAddress("glGetnMapfvARB");
        _glGetnMapivARB = (delegate* unmanaged<uint, uint, int, int*, void>)QuickGL.GetGLProcAddress("glGetnMapivARB");
        _glGetnPixelMapfvARB = (delegate* unmanaged<uint, int, float*, void>)QuickGL.GetGLProcAddress("glGetnPixelMapfvARB");
        _glGetnPixelMapuivARB = (delegate* unmanaged<uint, int, uint*, void>)QuickGL.GetGLProcAddress("glGetnPixelMapuivARB");
        _glGetnPixelMapusvARB = (delegate* unmanaged<uint, int, ushort*, void>)QuickGL.GetGLProcAddress("glGetnPixelMapusvARB");
        _glGetnPolygonStippleARB = (delegate* unmanaged<int, byte*, void>)QuickGL.GetGLProcAddress("glGetnPolygonStippleARB");
        _glGetnColorTableARB = (delegate* unmanaged<uint, uint, uint, int, void*, void>)QuickGL.GetGLProcAddress("glGetnColorTableARB");
        _glGetnConvolutionFilterARB = (delegate* unmanaged<uint, uint, uint, int, void*, void>)QuickGL.GetGLProcAddress("glGetnConvolutionFilterARB");
        _glGetnSeparableFilterARB = (delegate* unmanaged<uint, uint, uint, int, void*, int, void*, void*, void>)QuickGL.GetGLProcAddress("glGetnSeparableFilterARB");
        _glGetnHistogramARB = (delegate* unmanaged<uint, bool, uint, uint, int, void*, void>)QuickGL.GetGLProcAddress("glGetnHistogramARB");
        _glGetnMinmaxARB = (delegate* unmanaged<uint, bool, uint, uint, int, void*, void>)QuickGL.GetGLProcAddress("glGetnMinmaxARB");
    }
    
    internal static void Unload()
    {
        _glGetGraphicsResetStatusARB = null;
        _glGetnTexImageARB = null;
        _glReadnPixelsARB = null;
        _glGetnCompressedTexImageARB = null;
        _glGetnUniformfvARB = null;
        _glGetnUniformivARB = null;
        _glGetnUniformuivARB = null;
        _glGetnUniformdvARB = null;
        _glGetnMapdvARB = null;
        _glGetnMapfvARB = null;
        _glGetnMapivARB = null;
        _glGetnPixelMapfvARB = null;
        _glGetnPixelMapuivARB = null;
        _glGetnPixelMapusvARB = null;
        _glGetnPolygonStippleARB = null;
        _glGetnColorTableARB = null;
        _glGetnConvolutionFilterARB = null;
        _glGetnSeparableFilterARB = null;
        _glGetnHistogramARB = null;
        _glGetnMinmaxARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_robustness", true, false);
}
