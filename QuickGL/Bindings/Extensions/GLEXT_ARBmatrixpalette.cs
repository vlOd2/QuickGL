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

// Bindings generated at 2025-08-30 15:45:08.552491
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_matrix_palette", true, false)]
public static unsafe class GLEXT_ARBmatrixpalette
{
    #region Enums
    public const int GL_MATRIX_PALETTE_ARB = 0x8840;
    public const int GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;
    public const int GL_MAX_PALETTE_MATRICES_ARB = 0x8842;
    public const int GL_CURRENT_PALETTE_MATRIX_ARB = 0x8843;
    public const int GL_MATRIX_INDEX_ARRAY_ARB = 0x8844;
    public const int GL_CURRENT_MATRIX_INDEX_ARB = 0x8845;
    public const int GL_MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;
    public const int GL_MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;
    public const int GL_MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;
    public const int GL_MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;
    #endregion
    
    #region Commands
    public static void glCurrentPaletteMatrixARB(int index) { QGLNativeAPI.Verify((nint)_glCurrentPaletteMatrixARB); _glCurrentPaletteMatrixARB(index); }
    [QGLNativeAPI("glCurrentPaletteMatrixARB")] internal static delegate* unmanaged<int, void> _glCurrentPaletteMatrixARB = null;
    
    public static void glMatrixIndexubvARB(int size, byte* indices) { QGLNativeAPI.Verify((nint)_glMatrixIndexubvARB); _glMatrixIndexubvARB(size, indices); }
    [QGLNativeAPI("glMatrixIndexubvARB")] internal static delegate* unmanaged<int, byte*, void> _glMatrixIndexubvARB = null;
    
    public static void glMatrixIndexusvARB(int size, ushort* indices) { QGLNativeAPI.Verify((nint)_glMatrixIndexusvARB); _glMatrixIndexusvARB(size, indices); }
    [QGLNativeAPI("glMatrixIndexusvARB")] internal static delegate* unmanaged<int, ushort*, void> _glMatrixIndexusvARB = null;
    
    public static void glMatrixIndexuivARB(int size, uint* indices) { QGLNativeAPI.Verify((nint)_glMatrixIndexuivARB); _glMatrixIndexuivARB(size, indices); }
    [QGLNativeAPI("glMatrixIndexuivARB")] internal static delegate* unmanaged<int, uint*, void> _glMatrixIndexuivARB = null;
    
    public static void glMatrixIndexPointerARB(int size, uint type, int stride, void* pointer) { QGLNativeAPI.Verify((nint)_glMatrixIndexPointerARB); _glMatrixIndexPointerARB(size, type, stride, pointer); }
    [QGLNativeAPI("glMatrixIndexPointerARB")] internal static delegate* unmanaged<int, uint, int, void*, void> _glMatrixIndexPointerARB = null;
     #endregion
}
