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

// Bindings generated at 2025-08-30 15:45:08.573640
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_robustness", true, false)]
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
    public static uint glGetGraphicsResetStatusARB() { QGLNativeAPI.Verify((nint)_glGetGraphicsResetStatusARB); return _glGetGraphicsResetStatusARB(); }
    [QGLNativeAPI("glGetGraphicsResetStatusARB")] internal static delegate* unmanaged<uint> _glGetGraphicsResetStatusARB = null;
    
    public static void glGetnTexImageARB(uint target, int level, uint format, uint type, int bufSize, void* img) { QGLNativeAPI.Verify((nint)_glGetnTexImageARB); _glGetnTexImageARB(target, level, format, type, bufSize, img); }
    [QGLNativeAPI("glGetnTexImageARB")] internal static delegate* unmanaged<uint, int, uint, uint, int, void*, void> _glGetnTexImageARB = null;
    
    public static void glReadnPixelsARB(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data) { QGLNativeAPI.Verify((nint)_glReadnPixelsARB); _glReadnPixelsARB(x, y, width, height, format, type, bufSize, data); }
    [QGLNativeAPI("glReadnPixelsARB")] internal static delegate* unmanaged<int, int, int, int, uint, uint, int, void*, void> _glReadnPixelsARB = null;
    
    public static void glGetnCompressedTexImageARB(uint target, int lod, int bufSize, void* img) { QGLNativeAPI.Verify((nint)_glGetnCompressedTexImageARB); _glGetnCompressedTexImageARB(target, lod, bufSize, img); }
    [QGLNativeAPI("glGetnCompressedTexImageARB")] internal static delegate* unmanaged<uint, int, int, void*, void> _glGetnCompressedTexImageARB = null;
    
    public static void glGetnUniformfvARB(uint program, int location, int bufSize, float* @params) { QGLNativeAPI.Verify((nint)_glGetnUniformfvARB); _glGetnUniformfvARB(program, location, bufSize, @params); }
    [QGLNativeAPI("glGetnUniformfvARB")] internal static delegate* unmanaged<uint, int, int, float*, void> _glGetnUniformfvARB = null;
    
    public static void glGetnUniformivARB(uint program, int location, int bufSize, int* @params) { QGLNativeAPI.Verify((nint)_glGetnUniformivARB); _glGetnUniformivARB(program, location, bufSize, @params); }
    [QGLNativeAPI("glGetnUniformivARB")] internal static delegate* unmanaged<uint, int, int, int*, void> _glGetnUniformivARB = null;
    
    public static void glGetnUniformuivARB(uint program, int location, int bufSize, uint* @params) { QGLNativeAPI.Verify((nint)_glGetnUniformuivARB); _glGetnUniformuivARB(program, location, bufSize, @params); }
    [QGLNativeAPI("glGetnUniformuivARB")] internal static delegate* unmanaged<uint, int, int, uint*, void> _glGetnUniformuivARB = null;
    
    public static void glGetnUniformdvARB(uint program, int location, int bufSize, double* @params) { QGLNativeAPI.Verify((nint)_glGetnUniformdvARB); _glGetnUniformdvARB(program, location, bufSize, @params); }
    [QGLNativeAPI("glGetnUniformdvARB")] internal static delegate* unmanaged<uint, int, int, double*, void> _glGetnUniformdvARB = null;
    
    public static void glGetnMapdvARB(uint target, uint query, int bufSize, double* v) { QGLNativeAPI.Verify((nint)_glGetnMapdvARB); _glGetnMapdvARB(target, query, bufSize, v); }
    [QGLNativeAPI("glGetnMapdvARB")] internal static delegate* unmanaged<uint, uint, int, double*, void> _glGetnMapdvARB = null;
    
    public static void glGetnMapfvARB(uint target, uint query, int bufSize, float* v) { QGLNativeAPI.Verify((nint)_glGetnMapfvARB); _glGetnMapfvARB(target, query, bufSize, v); }
    [QGLNativeAPI("glGetnMapfvARB")] internal static delegate* unmanaged<uint, uint, int, float*, void> _glGetnMapfvARB = null;
    
    public static void glGetnMapivARB(uint target, uint query, int bufSize, int* v) { QGLNativeAPI.Verify((nint)_glGetnMapivARB); _glGetnMapivARB(target, query, bufSize, v); }
    [QGLNativeAPI("glGetnMapivARB")] internal static delegate* unmanaged<uint, uint, int, int*, void> _glGetnMapivARB = null;
    
    public static void glGetnPixelMapfvARB(uint map, int bufSize, float* values) { QGLNativeAPI.Verify((nint)_glGetnPixelMapfvARB); _glGetnPixelMapfvARB(map, bufSize, values); }
    [QGLNativeAPI("glGetnPixelMapfvARB")] internal static delegate* unmanaged<uint, int, float*, void> _glGetnPixelMapfvARB = null;
    
    public static void glGetnPixelMapuivARB(uint map, int bufSize, uint* values) { QGLNativeAPI.Verify((nint)_glGetnPixelMapuivARB); _glGetnPixelMapuivARB(map, bufSize, values); }
    [QGLNativeAPI("glGetnPixelMapuivARB")] internal static delegate* unmanaged<uint, int, uint*, void> _glGetnPixelMapuivARB = null;
    
    public static void glGetnPixelMapusvARB(uint map, int bufSize, ushort* values) { QGLNativeAPI.Verify((nint)_glGetnPixelMapusvARB); _glGetnPixelMapusvARB(map, bufSize, values); }
    [QGLNativeAPI("glGetnPixelMapusvARB")] internal static delegate* unmanaged<uint, int, ushort*, void> _glGetnPixelMapusvARB = null;
    
    public static void glGetnPolygonStippleARB(int bufSize, byte* pattern) { QGLNativeAPI.Verify((nint)_glGetnPolygonStippleARB); _glGetnPolygonStippleARB(bufSize, pattern); }
    [QGLNativeAPI("glGetnPolygonStippleARB")] internal static delegate* unmanaged<int, byte*, void> _glGetnPolygonStippleARB = null;
    
    public static void glGetnColorTableARB(uint target, uint format, uint type, int bufSize, void* table) { QGLNativeAPI.Verify((nint)_glGetnColorTableARB); _glGetnColorTableARB(target, format, type, bufSize, table); }
    [QGLNativeAPI("glGetnColorTableARB")] internal static delegate* unmanaged<uint, uint, uint, int, void*, void> _glGetnColorTableARB = null;
    
    public static void glGetnConvolutionFilterARB(uint target, uint format, uint type, int bufSize, void* image) { QGLNativeAPI.Verify((nint)_glGetnConvolutionFilterARB); _glGetnConvolutionFilterARB(target, format, type, bufSize, image); }
    [QGLNativeAPI("glGetnConvolutionFilterARB")] internal static delegate* unmanaged<uint, uint, uint, int, void*, void> _glGetnConvolutionFilterARB = null;
    
    public static void glGetnSeparableFilterARB(uint target, uint format, uint type, int rowBufSize, void* row, int columnBufSize, void* column, void* span) { QGLNativeAPI.Verify((nint)_glGetnSeparableFilterARB); _glGetnSeparableFilterARB(target, format, type, rowBufSize, row, columnBufSize, column, span); }
    [QGLNativeAPI("glGetnSeparableFilterARB")] internal static delegate* unmanaged<uint, uint, uint, int, void*, int, void*, void*, void> _glGetnSeparableFilterARB = null;
    
    public static void glGetnHistogramARB(uint target, bool reset, uint format, uint type, int bufSize, void* values) { QGLNativeAPI.Verify((nint)_glGetnHistogramARB); _glGetnHistogramARB(target, reset, format, type, bufSize, values); }
    [QGLNativeAPI("glGetnHistogramARB")] internal static delegate* unmanaged<uint, bool, uint, uint, int, void*, void> _glGetnHistogramARB = null;
    
    public static void glGetnMinmaxARB(uint target, bool reset, uint format, uint type, int bufSize, void* values) { QGLNativeAPI.Verify((nint)_glGetnMinmaxARB); _glGetnMinmaxARB(target, reset, format, type, bufSize, values); }
    [QGLNativeAPI("glGetnMinmaxARB")] internal static delegate* unmanaged<uint, bool, uint, uint, int, void*, void> _glGetnMinmaxARB = null;
     #endregion
}
