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

// Bindings generated at 2025-08-30 15:45:08.805948
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_window_pos", true, false)]
public static unsafe class GLEXT_ARBwindowpos
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glWindowPos2dARB(double x, double y) { QGLNativeAPI.Verify((nint)_glWindowPos2dARB); _glWindowPos2dARB(x, y); }
    [QGLNativeAPI("glWindowPos2dARB")] internal static delegate* unmanaged<double, double, void> _glWindowPos2dARB = null;
    
    public static void glWindowPos2dvARB(double* v) { QGLNativeAPI.Verify((nint)_glWindowPos2dvARB); _glWindowPos2dvARB(v); }
    [QGLNativeAPI("glWindowPos2dvARB")] internal static delegate* unmanaged<double*, void> _glWindowPos2dvARB = null;
    
    public static void glWindowPos2fARB(float x, float y) { QGLNativeAPI.Verify((nint)_glWindowPos2fARB); _glWindowPos2fARB(x, y); }
    [QGLNativeAPI("glWindowPos2fARB")] internal static delegate* unmanaged<float, float, void> _glWindowPos2fARB = null;
    
    public static void glWindowPos2fvARB(float* v) { QGLNativeAPI.Verify((nint)_glWindowPos2fvARB); _glWindowPos2fvARB(v); }
    [QGLNativeAPI("glWindowPos2fvARB")] internal static delegate* unmanaged<float*, void> _glWindowPos2fvARB = null;
    
    public static void glWindowPos2iARB(int x, int y) { QGLNativeAPI.Verify((nint)_glWindowPos2iARB); _glWindowPos2iARB(x, y); }
    [QGLNativeAPI("glWindowPos2iARB")] internal static delegate* unmanaged<int, int, void> _glWindowPos2iARB = null;
    
    public static void glWindowPos2ivARB(int* v) { QGLNativeAPI.Verify((nint)_glWindowPos2ivARB); _glWindowPos2ivARB(v); }
    [QGLNativeAPI("glWindowPos2ivARB")] internal static delegate* unmanaged<int*, void> _glWindowPos2ivARB = null;
    
    public static void glWindowPos2sARB(short x, short y) { QGLNativeAPI.Verify((nint)_glWindowPos2sARB); _glWindowPos2sARB(x, y); }
    [QGLNativeAPI("glWindowPos2sARB")] internal static delegate* unmanaged<short, short, void> _glWindowPos2sARB = null;
    
    public static void glWindowPos2svARB(short* v) { QGLNativeAPI.Verify((nint)_glWindowPos2svARB); _glWindowPos2svARB(v); }
    [QGLNativeAPI("glWindowPos2svARB")] internal static delegate* unmanaged<short*, void> _glWindowPos2svARB = null;
    
    public static void glWindowPos3dARB(double x, double y, double z) { QGLNativeAPI.Verify((nint)_glWindowPos3dARB); _glWindowPos3dARB(x, y, z); }
    [QGLNativeAPI("glWindowPos3dARB")] internal static delegate* unmanaged<double, double, double, void> _glWindowPos3dARB = null;
    
    public static void glWindowPos3dvARB(double* v) { QGLNativeAPI.Verify((nint)_glWindowPos3dvARB); _glWindowPos3dvARB(v); }
    [QGLNativeAPI("glWindowPos3dvARB")] internal static delegate* unmanaged<double*, void> _glWindowPos3dvARB = null;
    
    public static void glWindowPos3fARB(float x, float y, float z) { QGLNativeAPI.Verify((nint)_glWindowPos3fARB); _glWindowPos3fARB(x, y, z); }
    [QGLNativeAPI("glWindowPos3fARB")] internal static delegate* unmanaged<float, float, float, void> _glWindowPos3fARB = null;
    
    public static void glWindowPos3fvARB(float* v) { QGLNativeAPI.Verify((nint)_glWindowPos3fvARB); _glWindowPos3fvARB(v); }
    [QGLNativeAPI("glWindowPos3fvARB")] internal static delegate* unmanaged<float*, void> _glWindowPos3fvARB = null;
    
    public static void glWindowPos3iARB(int x, int y, int z) { QGLNativeAPI.Verify((nint)_glWindowPos3iARB); _glWindowPos3iARB(x, y, z); }
    [QGLNativeAPI("glWindowPos3iARB")] internal static delegate* unmanaged<int, int, int, void> _glWindowPos3iARB = null;
    
    public static void glWindowPos3ivARB(int* v) { QGLNativeAPI.Verify((nint)_glWindowPos3ivARB); _glWindowPos3ivARB(v); }
    [QGLNativeAPI("glWindowPos3ivARB")] internal static delegate* unmanaged<int*, void> _glWindowPos3ivARB = null;
    
    public static void glWindowPos3sARB(short x, short y, short z) { QGLNativeAPI.Verify((nint)_glWindowPos3sARB); _glWindowPos3sARB(x, y, z); }
    [QGLNativeAPI("glWindowPos3sARB")] internal static delegate* unmanaged<short, short, short, void> _glWindowPos3sARB = null;
    
    public static void glWindowPos3svARB(short* v) { QGLNativeAPI.Verify((nint)_glWindowPos3svARB); _glWindowPos3svARB(v); }
    [QGLNativeAPI("glWindowPos3svARB")] internal static delegate* unmanaged<short*, void> _glWindowPos3svARB = null;
     #endregion
}
