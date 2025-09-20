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

// Bindings generated at 2025-09-20 18:58:20.149126
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBwindowpos
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glWindowPos2dARB(double x, double y) { QGLFeature.VerifyFunc((nint)_glWindowPos2dARB); _glWindowPos2dARB(x, y); }
    internal static delegate* unmanaged<double, double, void> _glWindowPos2dARB = null;
    
    public static void glWindowPos2dvARB(double* v) { QGLFeature.VerifyFunc((nint)_glWindowPos2dvARB); _glWindowPos2dvARB(v); }
    internal static delegate* unmanaged<double*, void> _glWindowPos2dvARB = null;
    
    public static void glWindowPos2fARB(float x, float y) { QGLFeature.VerifyFunc((nint)_glWindowPos2fARB); _glWindowPos2fARB(x, y); }
    internal static delegate* unmanaged<float, float, void> _glWindowPos2fARB = null;
    
    public static void glWindowPos2fvARB(float* v) { QGLFeature.VerifyFunc((nint)_glWindowPos2fvARB); _glWindowPos2fvARB(v); }
    internal static delegate* unmanaged<float*, void> _glWindowPos2fvARB = null;
    
    public static void glWindowPos2iARB(int x, int y) { QGLFeature.VerifyFunc((nint)_glWindowPos2iARB); _glWindowPos2iARB(x, y); }
    internal static delegate* unmanaged<int, int, void> _glWindowPos2iARB = null;
    
    public static void glWindowPos2ivARB(int* v) { QGLFeature.VerifyFunc((nint)_glWindowPos2ivARB); _glWindowPos2ivARB(v); }
    internal static delegate* unmanaged<int*, void> _glWindowPos2ivARB = null;
    
    public static void glWindowPos2sARB(short x, short y) { QGLFeature.VerifyFunc((nint)_glWindowPos2sARB); _glWindowPos2sARB(x, y); }
    internal static delegate* unmanaged<short, short, void> _glWindowPos2sARB = null;
    
    public static void glWindowPos2svARB(short* v) { QGLFeature.VerifyFunc((nint)_glWindowPos2svARB); _glWindowPos2svARB(v); }
    internal static delegate* unmanaged<short*, void> _glWindowPos2svARB = null;
    
    public static void glWindowPos3dARB(double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glWindowPos3dARB); _glWindowPos3dARB(x, y, z); }
    internal static delegate* unmanaged<double, double, double, void> _glWindowPos3dARB = null;
    
    public static void glWindowPos3dvARB(double* v) { QGLFeature.VerifyFunc((nint)_glWindowPos3dvARB); _glWindowPos3dvARB(v); }
    internal static delegate* unmanaged<double*, void> _glWindowPos3dvARB = null;
    
    public static void glWindowPos3fARB(float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glWindowPos3fARB); _glWindowPos3fARB(x, y, z); }
    internal static delegate* unmanaged<float, float, float, void> _glWindowPos3fARB = null;
    
    public static void glWindowPos3fvARB(float* v) { QGLFeature.VerifyFunc((nint)_glWindowPos3fvARB); _glWindowPos3fvARB(v); }
    internal static delegate* unmanaged<float*, void> _glWindowPos3fvARB = null;
    
    public static void glWindowPos3iARB(int x, int y, int z) { QGLFeature.VerifyFunc((nint)_glWindowPos3iARB); _glWindowPos3iARB(x, y, z); }
    internal static delegate* unmanaged<int, int, int, void> _glWindowPos3iARB = null;
    
    public static void glWindowPos3ivARB(int* v) { QGLFeature.VerifyFunc((nint)_glWindowPos3ivARB); _glWindowPos3ivARB(v); }
    internal static delegate* unmanaged<int*, void> _glWindowPos3ivARB = null;
    
    public static void glWindowPos3sARB(short x, short y, short z) { QGLFeature.VerifyFunc((nint)_glWindowPos3sARB); _glWindowPos3sARB(x, y, z); }
    internal static delegate* unmanaged<short, short, short, void> _glWindowPos3sARB = null;
    
    public static void glWindowPos3svARB(short* v) { QGLFeature.VerifyFunc((nint)_glWindowPos3svARB); _glWindowPos3svARB(v); }
    internal static delegate* unmanaged<short*, void> _glWindowPos3svARB = null;
     #endregion
    
    internal static void Load()
    {
        _glWindowPos2dARB = (delegate* unmanaged<double, double, void>)QuickGL.GetGLProcAddress("glWindowPos2dARB");
        _glWindowPos2dvARB = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glWindowPos2dvARB");
        _glWindowPos2fARB = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glWindowPos2fARB");
        _glWindowPos2fvARB = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glWindowPos2fvARB");
        _glWindowPos2iARB = (delegate* unmanaged<int, int, void>)QuickGL.GetGLProcAddress("glWindowPos2iARB");
        _glWindowPos2ivARB = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glWindowPos2ivARB");
        _glWindowPos2sARB = (delegate* unmanaged<short, short, void>)QuickGL.GetGLProcAddress("glWindowPos2sARB");
        _glWindowPos2svARB = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glWindowPos2svARB");
        _glWindowPos3dARB = (delegate* unmanaged<double, double, double, void>)QuickGL.GetGLProcAddress("glWindowPos3dARB");
        _glWindowPos3dvARB = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glWindowPos3dvARB");
        _glWindowPos3fARB = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glWindowPos3fARB");
        _glWindowPos3fvARB = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glWindowPos3fvARB");
        _glWindowPos3iARB = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glWindowPos3iARB");
        _glWindowPos3ivARB = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glWindowPos3ivARB");
        _glWindowPos3sARB = (delegate* unmanaged<short, short, short, void>)QuickGL.GetGLProcAddress("glWindowPos3sARB");
        _glWindowPos3svARB = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glWindowPos3svARB");
    }
    
    internal static void Unload()
    {
        _glWindowPos2dARB = null;
        _glWindowPos2dvARB = null;
        _glWindowPos2fARB = null;
        _glWindowPos2fvARB = null;
        _glWindowPos2iARB = null;
        _glWindowPos2ivARB = null;
        _glWindowPos2sARB = null;
        _glWindowPos2svARB = null;
        _glWindowPos3dARB = null;
        _glWindowPos3dvARB = null;
        _glWindowPos3fARB = null;
        _glWindowPos3fvARB = null;
        _glWindowPos3iARB = null;
        _glWindowPos3ivARB = null;
        _glWindowPos3sARB = null;
        _glWindowPos3svARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_window_pos", true, false);
}
