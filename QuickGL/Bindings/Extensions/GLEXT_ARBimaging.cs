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

// Bindings generated at 2025-09-20 18:58:19.898868
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBimaging
{
    #region Enums
    public const int GL_BLEND_COLOR = 0x8005;
    public const int GL_BLEND_EQUATION = 0x8009;
    public const int GL_CONSTANT_COLOR = 0x8001;
    public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
    public const int GL_CONSTANT_ALPHA = 0x8003;
    public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
    public const int GL_FUNC_ADD = 0x8006;
    public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;
    public const int GL_FUNC_SUBTRACT = 0x800A;
    public const int GL_MIN = 0x8007;
    public const int GL_MAX = 0x8008;
    public const int GL_CONVOLUTION_1D = 0x8010;
    public const int GL_CONVOLUTION_2D = 0x8011;
    public const int GL_SEPARABLE_2D = 0x8012;
    public const int GL_CONVOLUTION_BORDER_MODE = 0x8013;
    public const int GL_CONVOLUTION_FILTER_SCALE = 0x8014;
    public const int GL_CONVOLUTION_FILTER_BIAS = 0x8015;
    public const int GL_REDUCE = 0x8016;
    public const int GL_CONVOLUTION_FORMAT = 0x8017;
    public const int GL_CONVOLUTION_WIDTH = 0x8018;
    public const int GL_CONVOLUTION_HEIGHT = 0x8019;
    public const int GL_MAX_CONVOLUTION_WIDTH = 0x801A;
    public const int GL_MAX_CONVOLUTION_HEIGHT = 0x801B;
    public const int GL_POST_CONVOLUTION_RED_SCALE = 0x801C;
    public const int GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D;
    public const int GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E;
    public const int GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F;
    public const int GL_POST_CONVOLUTION_RED_BIAS = 0x8020;
    public const int GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021;
    public const int GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022;
    public const int GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023;
    public const int GL_HISTOGRAM = 0x8024;
    public const int GL_PROXY_HISTOGRAM = 0x8025;
    public const int GL_HISTOGRAM_WIDTH = 0x8026;
    public const int GL_HISTOGRAM_FORMAT = 0x8027;
    public const int GL_HISTOGRAM_RED_SIZE = 0x8028;
    public const int GL_HISTOGRAM_GREEN_SIZE = 0x8029;
    public const int GL_HISTOGRAM_BLUE_SIZE = 0x802A;
    public const int GL_HISTOGRAM_ALPHA_SIZE = 0x802B;
    public const int GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C;
    public const int GL_HISTOGRAM_SINK = 0x802D;
    public const int GL_MINMAX = 0x802E;
    public const int GL_MINMAX_FORMAT = 0x802F;
    public const int GL_MINMAX_SINK = 0x8030;
    public const int GL_TABLE_TOO_LARGE = 0x8031;
    public const int GL_COLOR_MATRIX = 0x80B1;
    public const int GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2;
    public const int GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
    public const int GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4;
    public const int GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;
    public const int GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;
    public const int GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;
    public const int GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8;
    public const int GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;
    public const int GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;
    public const int GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;
    public const int GL_COLOR_TABLE = 0x80D0;
    public const int GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
    public const int GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
    public const int GL_PROXY_COLOR_TABLE = 0x80D3;
    public const int GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
    public const int GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
    public const int GL_COLOR_TABLE_SCALE = 0x80D6;
    public const int GL_COLOR_TABLE_BIAS = 0x80D7;
    public const int GL_COLOR_TABLE_FORMAT = 0x80D8;
    public const int GL_COLOR_TABLE_WIDTH = 0x80D9;
    public const int GL_COLOR_TABLE_RED_SIZE = 0x80DA;
    public const int GL_COLOR_TABLE_GREEN_SIZE = 0x80DB;
    public const int GL_COLOR_TABLE_BLUE_SIZE = 0x80DC;
    public const int GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD;
    public const int GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;
    public const int GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF;
    public const int GL_CONSTANT_BORDER = 0x8151;
    public const int GL_REPLICATE_BORDER = 0x8153;
    public const int GL_CONVOLUTION_BORDER_COLOR = 0x8154;
    #endregion
    
    #region Commands
    public static void glBlendColor(float red, float green, float blue, float alpha) { QGLFeature.VerifyFunc((nint)_glBlendColor); _glBlendColor(red, green, blue, alpha); }
    internal static delegate* unmanaged<float, float, float, float, void> _glBlendColor = null;
    
    public static void glBlendEquation(uint mode) { QGLFeature.VerifyFunc((nint)_glBlendEquation); _glBlendEquation(mode); }
    internal static delegate* unmanaged<uint, void> _glBlendEquation = null;
    
    public static void glColorTable(uint target, uint internalformat, int width, uint format, uint type, void* table) { QGLFeature.VerifyFunc((nint)_glColorTable); _glColorTable(target, internalformat, width, format, type, table); }
    internal static delegate* unmanaged<uint, uint, int, uint, uint, void*, void> _glColorTable = null;
    
    public static void glColorTableParameterfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glColorTableParameterfv); _glColorTableParameterfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glColorTableParameterfv = null;
    
    public static void glColorTableParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glColorTableParameteriv); _glColorTableParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glColorTableParameteriv = null;
    
    public static void glCopyColorTable(uint target, uint internalformat, int x, int y, int width) { QGLFeature.VerifyFunc((nint)_glCopyColorTable); _glCopyColorTable(target, internalformat, x, y, width); }
    internal static delegate* unmanaged<uint, uint, int, int, int, void> _glCopyColorTable = null;
    
    public static void glGetColorTable(uint target, uint format, uint type, void* table) { QGLFeature.VerifyFunc((nint)_glGetColorTable); _glGetColorTable(target, format, type, table); }
    internal static delegate* unmanaged<uint, uint, uint, void*, void> _glGetColorTable = null;
    
    public static void glGetColorTableParameterfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetColorTableParameterfv); _glGetColorTableParameterfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetColorTableParameterfv = null;
    
    public static void glGetColorTableParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetColorTableParameteriv); _glGetColorTableParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetColorTableParameteriv = null;
    
    public static void glColorSubTable(uint target, int start, int count, uint format, uint type, void* data) { QGLFeature.VerifyFunc((nint)_glColorSubTable); _glColorSubTable(target, start, count, format, type, data); }
    internal static delegate* unmanaged<uint, int, int, uint, uint, void*, void> _glColorSubTable = null;
    
    public static void glCopyColorSubTable(uint target, int start, int x, int y, int width) { QGLFeature.VerifyFunc((nint)_glCopyColorSubTable); _glCopyColorSubTable(target, start, x, y, width); }
    internal static delegate* unmanaged<uint, int, int, int, int, void> _glCopyColorSubTable = null;
    
    public static void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, void* image) { QGLFeature.VerifyFunc((nint)_glConvolutionFilter1D); _glConvolutionFilter1D(target, internalformat, width, format, type, image); }
    internal static delegate* unmanaged<uint, uint, int, uint, uint, void*, void> _glConvolutionFilter1D = null;
    
    public static void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* image) { QGLFeature.VerifyFunc((nint)_glConvolutionFilter2D); _glConvolutionFilter2D(target, internalformat, width, height, format, type, image); }
    internal static delegate* unmanaged<uint, uint, int, int, uint, uint, void*, void> _glConvolutionFilter2D = null;
    
    public static void glConvolutionParameterf(uint target, uint pname, float @params) { QGLFeature.VerifyFunc((nint)_glConvolutionParameterf); _glConvolutionParameterf(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float, void> _glConvolutionParameterf = null;
    
    public static void glConvolutionParameterfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glConvolutionParameterfv); _glConvolutionParameterfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glConvolutionParameterfv = null;
    
    public static void glConvolutionParameteri(uint target, uint pname, int @params) { QGLFeature.VerifyFunc((nint)_glConvolutionParameteri); _glConvolutionParameteri(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int, void> _glConvolutionParameteri = null;
    
    public static void glConvolutionParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glConvolutionParameteriv); _glConvolutionParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glConvolutionParameteriv = null;
    
    public static void glCopyConvolutionFilter1D(uint target, uint internalformat, int x, int y, int width) { QGLFeature.VerifyFunc((nint)_glCopyConvolutionFilter1D); _glCopyConvolutionFilter1D(target, internalformat, x, y, width); }
    internal static delegate* unmanaged<uint, uint, int, int, int, void> _glCopyConvolutionFilter1D = null;
    
    public static void glCopyConvolutionFilter2D(uint target, uint internalformat, int x, int y, int width, int height) { QGLFeature.VerifyFunc((nint)_glCopyConvolutionFilter2D); _glCopyConvolutionFilter2D(target, internalformat, x, y, width, height); }
    internal static delegate* unmanaged<uint, uint, int, int, int, int, void> _glCopyConvolutionFilter2D = null;
    
    public static void glGetConvolutionFilter(uint target, uint format, uint type, void* image) { QGLFeature.VerifyFunc((nint)_glGetConvolutionFilter); _glGetConvolutionFilter(target, format, type, image); }
    internal static delegate* unmanaged<uint, uint, uint, void*, void> _glGetConvolutionFilter = null;
    
    public static void glGetConvolutionParameterfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetConvolutionParameterfv); _glGetConvolutionParameterfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetConvolutionParameterfv = null;
    
    public static void glGetConvolutionParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetConvolutionParameteriv); _glGetConvolutionParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetConvolutionParameteriv = null;
    
    public static void glGetSeparableFilter(uint target, uint format, uint type, void* row, void* column, void* span) { QGLFeature.VerifyFunc((nint)_glGetSeparableFilter); _glGetSeparableFilter(target, format, type, row, column, span); }
    internal static delegate* unmanaged<uint, uint, uint, void*, void*, void*, void> _glGetSeparableFilter = null;
    
    public static void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* row, void* column) { QGLFeature.VerifyFunc((nint)_glSeparableFilter2D); _glSeparableFilter2D(target, internalformat, width, height, format, type, row, column); }
    internal static delegate* unmanaged<uint, uint, int, int, uint, uint, void*, void*, void> _glSeparableFilter2D = null;
    
    public static void glGetHistogram(uint target, bool reset, uint format, uint type, void* values) { QGLFeature.VerifyFunc((nint)_glGetHistogram); _glGetHistogram(target, reset, format, type, values); }
    internal static delegate* unmanaged<uint, bool, uint, uint, void*, void> _glGetHistogram = null;
    
    public static void glGetHistogramParameterfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetHistogramParameterfv); _glGetHistogramParameterfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetHistogramParameterfv = null;
    
    public static void glGetHistogramParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetHistogramParameteriv); _glGetHistogramParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetHistogramParameteriv = null;
    
    public static void glGetMinmax(uint target, bool reset, uint format, uint type, void* values) { QGLFeature.VerifyFunc((nint)_glGetMinmax); _glGetMinmax(target, reset, format, type, values); }
    internal static delegate* unmanaged<uint, bool, uint, uint, void*, void> _glGetMinmax = null;
    
    public static void glGetMinmaxParameterfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetMinmaxParameterfv); _glGetMinmaxParameterfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetMinmaxParameterfv = null;
    
    public static void glGetMinmaxParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetMinmaxParameteriv); _glGetMinmaxParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetMinmaxParameteriv = null;
    
    public static void glHistogram(uint target, int width, uint internalformat, bool sink) { QGLFeature.VerifyFunc((nint)_glHistogram); _glHistogram(target, width, internalformat, sink); }
    internal static delegate* unmanaged<uint, int, uint, bool, void> _glHistogram = null;
    
    public static void glMinmax(uint target, uint internalformat, bool sink) { QGLFeature.VerifyFunc((nint)_glMinmax); _glMinmax(target, internalformat, sink); }
    internal static delegate* unmanaged<uint, uint, bool, void> _glMinmax = null;
    
    public static void glResetHistogram(uint target) { QGLFeature.VerifyFunc((nint)_glResetHistogram); _glResetHistogram(target); }
    internal static delegate* unmanaged<uint, void> _glResetHistogram = null;
    
    public static void glResetMinmax(uint target) { QGLFeature.VerifyFunc((nint)_glResetMinmax); _glResetMinmax(target); }
    internal static delegate* unmanaged<uint, void> _glResetMinmax = null;
     #endregion
    
    internal static void Load()
    {
        _glBlendColor = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glBlendColor");
        _glBlendEquation = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glBlendEquation");
        _glColorTable = (delegate* unmanaged<uint, uint, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glColorTable");
        _glColorTableParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glColorTableParameterfv");
        _glColorTableParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glColorTableParameteriv");
        _glCopyColorTable = (delegate* unmanaged<uint, uint, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyColorTable");
        _glGetColorTable = (delegate* unmanaged<uint, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glGetColorTable");
        _glGetColorTableParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetColorTableParameterfv");
        _glGetColorTableParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetColorTableParameteriv");
        _glColorSubTable = (delegate* unmanaged<uint, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glColorSubTable");
        _glCopyColorSubTable = (delegate* unmanaged<uint, int, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyColorSubTable");
        _glConvolutionFilter1D = (delegate* unmanaged<uint, uint, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glConvolutionFilter1D");
        _glConvolutionFilter2D = (delegate* unmanaged<uint, uint, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glConvolutionFilter2D");
        _glConvolutionParameterf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glConvolutionParameterf");
        _glConvolutionParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glConvolutionParameterfv");
        _glConvolutionParameteri = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glConvolutionParameteri");
        _glConvolutionParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glConvolutionParameteriv");
        _glCopyConvolutionFilter1D = (delegate* unmanaged<uint, uint, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyConvolutionFilter1D");
        _glCopyConvolutionFilter2D = (delegate* unmanaged<uint, uint, int, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyConvolutionFilter2D");
        _glGetConvolutionFilter = (delegate* unmanaged<uint, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glGetConvolutionFilter");
        _glGetConvolutionParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetConvolutionParameterfv");
        _glGetConvolutionParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetConvolutionParameteriv");
        _glGetSeparableFilter = (delegate* unmanaged<uint, uint, uint, void*, void*, void*, void>)QuickGL.GetGLProcAddress("glGetSeparableFilter");
        _glSeparableFilter2D = (delegate* unmanaged<uint, uint, int, int, uint, uint, void*, void*, void>)QuickGL.GetGLProcAddress("glSeparableFilter2D");
        _glGetHistogram = (delegate* unmanaged<uint, bool, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glGetHistogram");
        _glGetHistogramParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetHistogramParameterfv");
        _glGetHistogramParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetHistogramParameteriv");
        _glGetMinmax = (delegate* unmanaged<uint, bool, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glGetMinmax");
        _glGetMinmaxParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetMinmaxParameterfv");
        _glGetMinmaxParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetMinmaxParameteriv");
        _glHistogram = (delegate* unmanaged<uint, int, uint, bool, void>)QuickGL.GetGLProcAddress("glHistogram");
        _glMinmax = (delegate* unmanaged<uint, uint, bool, void>)QuickGL.GetGLProcAddress("glMinmax");
        _glResetHistogram = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glResetHistogram");
        _glResetMinmax = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glResetMinmax");
    }
    
    internal static void Unload()
    {
        _glBlendColor = null;
        _glBlendEquation = null;
        _glColorTable = null;
        _glColorTableParameterfv = null;
        _glColorTableParameteriv = null;
        _glCopyColorTable = null;
        _glGetColorTable = null;
        _glGetColorTableParameterfv = null;
        _glGetColorTableParameteriv = null;
        _glColorSubTable = null;
        _glCopyColorSubTable = null;
        _glConvolutionFilter1D = null;
        _glConvolutionFilter2D = null;
        _glConvolutionParameterf = null;
        _glConvolutionParameterfv = null;
        _glConvolutionParameteri = null;
        _glConvolutionParameteriv = null;
        _glCopyConvolutionFilter1D = null;
        _glCopyConvolutionFilter2D = null;
        _glGetConvolutionFilter = null;
        _glGetConvolutionParameterfv = null;
        _glGetConvolutionParameteriv = null;
        _glGetSeparableFilter = null;
        _glSeparableFilter2D = null;
        _glGetHistogram = null;
        _glGetHistogramParameterfv = null;
        _glGetHistogramParameteriv = null;
        _glGetMinmax = null;
        _glGetMinmaxParameterfv = null;
        _glGetMinmaxParameteriv = null;
        _glHistogram = null;
        _glMinmax = null;
        _glResetHistogram = null;
        _glResetMinmax = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_imaging", true, false);
}
