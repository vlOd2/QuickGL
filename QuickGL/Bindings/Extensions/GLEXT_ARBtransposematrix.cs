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

// Bindings generated at 2025-09-20 18:58:20.117104
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtransposematrix
{
    #region Enums
    public const int GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
    public const int GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
    public const int GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
    public const int GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;
    #endregion
    
    #region Commands
    public static void glLoadTransposeMatrixfARB(float* m) { QGLFeature.VerifyFunc((nint)_glLoadTransposeMatrixfARB); _glLoadTransposeMatrixfARB(m); }
    internal static delegate* unmanaged<float*, void> _glLoadTransposeMatrixfARB = null;
    
    public static void glLoadTransposeMatrixdARB(double* m) { QGLFeature.VerifyFunc((nint)_glLoadTransposeMatrixdARB); _glLoadTransposeMatrixdARB(m); }
    internal static delegate* unmanaged<double*, void> _glLoadTransposeMatrixdARB = null;
    
    public static void glMultTransposeMatrixfARB(float* m) { QGLFeature.VerifyFunc((nint)_glMultTransposeMatrixfARB); _glMultTransposeMatrixfARB(m); }
    internal static delegate* unmanaged<float*, void> _glMultTransposeMatrixfARB = null;
    
    public static void glMultTransposeMatrixdARB(double* m) { QGLFeature.VerifyFunc((nint)_glMultTransposeMatrixdARB); _glMultTransposeMatrixdARB(m); }
    internal static delegate* unmanaged<double*, void> _glMultTransposeMatrixdARB = null;
     #endregion
    
    internal static void Load()
    {
        _glLoadTransposeMatrixfARB = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glLoadTransposeMatrixfARB");
        _glLoadTransposeMatrixdARB = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glLoadTransposeMatrixdARB");
        _glMultTransposeMatrixfARB = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glMultTransposeMatrixfARB");
        _glMultTransposeMatrixdARB = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glMultTransposeMatrixdARB");
    }
    
    internal static void Unload()
    {
        _glLoadTransposeMatrixfARB = null;
        _glLoadTransposeMatrixdARB = null;
        _glMultTransposeMatrixfARB = null;
        _glMultTransposeMatrixdARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_transpose_matrix", true, false);
}
