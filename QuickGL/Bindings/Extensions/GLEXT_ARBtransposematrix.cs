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

// Bindings generated at 2025-08-30 15:45:08.766234
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_transpose_matrix", true, false)]
public static unsafe class GLEXT_ARBtransposematrix
{
    #region Enums
    public const int GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
    public const int GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
    public const int GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
    public const int GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;
    #endregion
    
    #region Commands
    public static void glLoadTransposeMatrixfARB(float* m) { QGLNativeAPI.Verify((nint)_glLoadTransposeMatrixfARB); _glLoadTransposeMatrixfARB(m); }
    [QGLNativeAPI("glLoadTransposeMatrixfARB")] internal static delegate* unmanaged<float*, void> _glLoadTransposeMatrixfARB = null;
    
    public static void glLoadTransposeMatrixdARB(double* m) { QGLNativeAPI.Verify((nint)_glLoadTransposeMatrixdARB); _glLoadTransposeMatrixdARB(m); }
    [QGLNativeAPI("glLoadTransposeMatrixdARB")] internal static delegate* unmanaged<double*, void> _glLoadTransposeMatrixdARB = null;
    
    public static void glMultTransposeMatrixfARB(float* m) { QGLNativeAPI.Verify((nint)_glMultTransposeMatrixfARB); _glMultTransposeMatrixfARB(m); }
    [QGLNativeAPI("glMultTransposeMatrixfARB")] internal static delegate* unmanaged<float*, void> _glMultTransposeMatrixfARB = null;
    
    public static void glMultTransposeMatrixdARB(double* m) { QGLNativeAPI.Verify((nint)_glMultTransposeMatrixdARB); _glMultTransposeMatrixdARB(m); }
    [QGLNativeAPI("glMultTransposeMatrixdARB")] internal static delegate* unmanaged<double*, void> _glMultTransposeMatrixdARB = null;
     #endregion
}
