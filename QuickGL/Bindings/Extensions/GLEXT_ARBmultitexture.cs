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

// Bindings generated at 2025-09-20 18:58:19.917118
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBmultitexture
{
    #region Enums
    public const int GL_TEXTURE0_ARB = 0x84C0;
    public const int GL_TEXTURE1_ARB = 0x84C1;
    public const int GL_TEXTURE2_ARB = 0x84C2;
    public const int GL_TEXTURE3_ARB = 0x84C3;
    public const int GL_TEXTURE4_ARB = 0x84C4;
    public const int GL_TEXTURE5_ARB = 0x84C5;
    public const int GL_TEXTURE6_ARB = 0x84C6;
    public const int GL_TEXTURE7_ARB = 0x84C7;
    public const int GL_TEXTURE8_ARB = 0x84C8;
    public const int GL_TEXTURE9_ARB = 0x84C9;
    public const int GL_TEXTURE10_ARB = 0x84CA;
    public const int GL_TEXTURE11_ARB = 0x84CB;
    public const int GL_TEXTURE12_ARB = 0x84CC;
    public const int GL_TEXTURE13_ARB = 0x84CD;
    public const int GL_TEXTURE14_ARB = 0x84CE;
    public const int GL_TEXTURE15_ARB = 0x84CF;
    public const int GL_TEXTURE16_ARB = 0x84D0;
    public const int GL_TEXTURE17_ARB = 0x84D1;
    public const int GL_TEXTURE18_ARB = 0x84D2;
    public const int GL_TEXTURE19_ARB = 0x84D3;
    public const int GL_TEXTURE20_ARB = 0x84D4;
    public const int GL_TEXTURE21_ARB = 0x84D5;
    public const int GL_TEXTURE22_ARB = 0x84D6;
    public const int GL_TEXTURE23_ARB = 0x84D7;
    public const int GL_TEXTURE24_ARB = 0x84D8;
    public const int GL_TEXTURE25_ARB = 0x84D9;
    public const int GL_TEXTURE26_ARB = 0x84DA;
    public const int GL_TEXTURE27_ARB = 0x84DB;
    public const int GL_TEXTURE28_ARB = 0x84DC;
    public const int GL_TEXTURE29_ARB = 0x84DD;
    public const int GL_TEXTURE30_ARB = 0x84DE;
    public const int GL_TEXTURE31_ARB = 0x84DF;
    public const int GL_ACTIVE_TEXTURE_ARB = 0x84E0;
    public const int GL_CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;
    public const int GL_MAX_TEXTURE_UNITS_ARB = 0x84E2;
    #endregion
    
    #region Commands
    public static void glActiveTextureARB(uint texture) { QGLFeature.VerifyFunc((nint)_glActiveTextureARB); _glActiveTextureARB(texture); }
    internal static delegate* unmanaged<uint, void> _glActiveTextureARB = null;
    
    public static void glClientActiveTextureARB(uint texture) { QGLFeature.VerifyFunc((nint)_glClientActiveTextureARB); _glClientActiveTextureARB(texture); }
    internal static delegate* unmanaged<uint, void> _glClientActiveTextureARB = null;
    
    public static void glMultiTexCoord1dARB(uint target, double s) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord1dARB); _glMultiTexCoord1dARB(target, s); }
    internal static delegate* unmanaged<uint, double, void> _glMultiTexCoord1dARB = null;
    
    public static void glMultiTexCoord1dvARB(uint target, double* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord1dvARB); _glMultiTexCoord1dvARB(target, v); }
    internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord1dvARB = null;
    
    public static void glMultiTexCoord1fARB(uint target, float s) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord1fARB); _glMultiTexCoord1fARB(target, s); }
    internal static delegate* unmanaged<uint, float, void> _glMultiTexCoord1fARB = null;
    
    public static void glMultiTexCoord1fvARB(uint target, float* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord1fvARB); _glMultiTexCoord1fvARB(target, v); }
    internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord1fvARB = null;
    
    public static void glMultiTexCoord1iARB(uint target, int s) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord1iARB); _glMultiTexCoord1iARB(target, s); }
    internal static delegate* unmanaged<uint, int, void> _glMultiTexCoord1iARB = null;
    
    public static void glMultiTexCoord1ivARB(uint target, int* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord1ivARB); _glMultiTexCoord1ivARB(target, v); }
    internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord1ivARB = null;
    
    public static void glMultiTexCoord1sARB(uint target, short s) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord1sARB); _glMultiTexCoord1sARB(target, s); }
    internal static delegate* unmanaged<uint, short, void> _glMultiTexCoord1sARB = null;
    
    public static void glMultiTexCoord1svARB(uint target, short* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord1svARB); _glMultiTexCoord1svARB(target, v); }
    internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord1svARB = null;
    
    public static void glMultiTexCoord2dARB(uint target, double s, double t) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord2dARB); _glMultiTexCoord2dARB(target, s, t); }
    internal static delegate* unmanaged<uint, double, double, void> _glMultiTexCoord2dARB = null;
    
    public static void glMultiTexCoord2dvARB(uint target, double* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord2dvARB); _glMultiTexCoord2dvARB(target, v); }
    internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord2dvARB = null;
    
    public static void glMultiTexCoord2fARB(uint target, float s, float t) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord2fARB); _glMultiTexCoord2fARB(target, s, t); }
    internal static delegate* unmanaged<uint, float, float, void> _glMultiTexCoord2fARB = null;
    
    public static void glMultiTexCoord2fvARB(uint target, float* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord2fvARB); _glMultiTexCoord2fvARB(target, v); }
    internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord2fvARB = null;
    
    public static void glMultiTexCoord2iARB(uint target, int s, int t) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord2iARB); _glMultiTexCoord2iARB(target, s, t); }
    internal static delegate* unmanaged<uint, int, int, void> _glMultiTexCoord2iARB = null;
    
    public static void glMultiTexCoord2ivARB(uint target, int* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord2ivARB); _glMultiTexCoord2ivARB(target, v); }
    internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord2ivARB = null;
    
    public static void glMultiTexCoord2sARB(uint target, short s, short t) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord2sARB); _glMultiTexCoord2sARB(target, s, t); }
    internal static delegate* unmanaged<uint, short, short, void> _glMultiTexCoord2sARB = null;
    
    public static void glMultiTexCoord2svARB(uint target, short* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord2svARB); _glMultiTexCoord2svARB(target, v); }
    internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord2svARB = null;
    
    public static void glMultiTexCoord3dARB(uint target, double s, double t, double r) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord3dARB); _glMultiTexCoord3dARB(target, s, t, r); }
    internal static delegate* unmanaged<uint, double, double, double, void> _glMultiTexCoord3dARB = null;
    
    public static void glMultiTexCoord3dvARB(uint target, double* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord3dvARB); _glMultiTexCoord3dvARB(target, v); }
    internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord3dvARB = null;
    
    public static void glMultiTexCoord3fARB(uint target, float s, float t, float r) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord3fARB); _glMultiTexCoord3fARB(target, s, t, r); }
    internal static delegate* unmanaged<uint, float, float, float, void> _glMultiTexCoord3fARB = null;
    
    public static void glMultiTexCoord3fvARB(uint target, float* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord3fvARB); _glMultiTexCoord3fvARB(target, v); }
    internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord3fvARB = null;
    
    public static void glMultiTexCoord3iARB(uint target, int s, int t, int r) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord3iARB); _glMultiTexCoord3iARB(target, s, t, r); }
    internal static delegate* unmanaged<uint, int, int, int, void> _glMultiTexCoord3iARB = null;
    
    public static void glMultiTexCoord3ivARB(uint target, int* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord3ivARB); _glMultiTexCoord3ivARB(target, v); }
    internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord3ivARB = null;
    
    public static void glMultiTexCoord3sARB(uint target, short s, short t, short r) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord3sARB); _glMultiTexCoord3sARB(target, s, t, r); }
    internal static delegate* unmanaged<uint, short, short, short, void> _glMultiTexCoord3sARB = null;
    
    public static void glMultiTexCoord3svARB(uint target, short* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord3svARB); _glMultiTexCoord3svARB(target, v); }
    internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord3svARB = null;
    
    public static void glMultiTexCoord4dARB(uint target, double s, double t, double r, double q) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord4dARB); _glMultiTexCoord4dARB(target, s, t, r, q); }
    internal static delegate* unmanaged<uint, double, double, double, double, void> _glMultiTexCoord4dARB = null;
    
    public static void glMultiTexCoord4dvARB(uint target, double* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord4dvARB); _glMultiTexCoord4dvARB(target, v); }
    internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord4dvARB = null;
    
    public static void glMultiTexCoord4fARB(uint target, float s, float t, float r, float q) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord4fARB); _glMultiTexCoord4fARB(target, s, t, r, q); }
    internal static delegate* unmanaged<uint, float, float, float, float, void> _glMultiTexCoord4fARB = null;
    
    public static void glMultiTexCoord4fvARB(uint target, float* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord4fvARB); _glMultiTexCoord4fvARB(target, v); }
    internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord4fvARB = null;
    
    public static void glMultiTexCoord4iARB(uint target, int s, int t, int r, int q) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord4iARB); _glMultiTexCoord4iARB(target, s, t, r, q); }
    internal static delegate* unmanaged<uint, int, int, int, int, void> _glMultiTexCoord4iARB = null;
    
    public static void glMultiTexCoord4ivARB(uint target, int* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord4ivARB); _glMultiTexCoord4ivARB(target, v); }
    internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord4ivARB = null;
    
    public static void glMultiTexCoord4sARB(uint target, short s, short t, short r, short q) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord4sARB); _glMultiTexCoord4sARB(target, s, t, r, q); }
    internal static delegate* unmanaged<uint, short, short, short, short, void> _glMultiTexCoord4sARB = null;
    
    public static void glMultiTexCoord4svARB(uint target, short* v) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord4svARB); _glMultiTexCoord4svARB(target, v); }
    internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord4svARB = null;
     #endregion
    
    internal static void Load()
    {
        _glActiveTextureARB = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glActiveTextureARB");
        _glClientActiveTextureARB = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glClientActiveTextureARB");
        _glMultiTexCoord1dARB = (delegate* unmanaged<uint, double, void>)QuickGL.GetGLProcAddress("glMultiTexCoord1dARB");
        _glMultiTexCoord1dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord1dvARB");
        _glMultiTexCoord1fARB = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glMultiTexCoord1fARB");
        _glMultiTexCoord1fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord1fvARB");
        _glMultiTexCoord1iARB = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glMultiTexCoord1iARB");
        _glMultiTexCoord1ivARB = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord1ivARB");
        _glMultiTexCoord1sARB = (delegate* unmanaged<uint, short, void>)QuickGL.GetGLProcAddress("glMultiTexCoord1sARB");
        _glMultiTexCoord1svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord1svARB");
        _glMultiTexCoord2dARB = (delegate* unmanaged<uint, double, double, void>)QuickGL.GetGLProcAddress("glMultiTexCoord2dARB");
        _glMultiTexCoord2dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord2dvARB");
        _glMultiTexCoord2fARB = (delegate* unmanaged<uint, float, float, void>)QuickGL.GetGLProcAddress("glMultiTexCoord2fARB");
        _glMultiTexCoord2fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord2fvARB");
        _glMultiTexCoord2iARB = (delegate* unmanaged<uint, int, int, void>)QuickGL.GetGLProcAddress("glMultiTexCoord2iARB");
        _glMultiTexCoord2ivARB = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord2ivARB");
        _glMultiTexCoord2sARB = (delegate* unmanaged<uint, short, short, void>)QuickGL.GetGLProcAddress("glMultiTexCoord2sARB");
        _glMultiTexCoord2svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord2svARB");
        _glMultiTexCoord3dARB = (delegate* unmanaged<uint, double, double, double, void>)QuickGL.GetGLProcAddress("glMultiTexCoord3dARB");
        _glMultiTexCoord3dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord3dvARB");
        _glMultiTexCoord3fARB = (delegate* unmanaged<uint, float, float, float, void>)QuickGL.GetGLProcAddress("glMultiTexCoord3fARB");
        _glMultiTexCoord3fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord3fvARB");
        _glMultiTexCoord3iARB = (delegate* unmanaged<uint, int, int, int, void>)QuickGL.GetGLProcAddress("glMultiTexCoord3iARB");
        _glMultiTexCoord3ivARB = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord3ivARB");
        _glMultiTexCoord3sARB = (delegate* unmanaged<uint, short, short, short, void>)QuickGL.GetGLProcAddress("glMultiTexCoord3sARB");
        _glMultiTexCoord3svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord3svARB");
        _glMultiTexCoord4dARB = (delegate* unmanaged<uint, double, double, double, double, void>)QuickGL.GetGLProcAddress("glMultiTexCoord4dARB");
        _glMultiTexCoord4dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord4dvARB");
        _glMultiTexCoord4fARB = (delegate* unmanaged<uint, float, float, float, float, void>)QuickGL.GetGLProcAddress("glMultiTexCoord4fARB");
        _glMultiTexCoord4fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord4fvARB");
        _glMultiTexCoord4iARB = (delegate* unmanaged<uint, int, int, int, int, void>)QuickGL.GetGLProcAddress("glMultiTexCoord4iARB");
        _glMultiTexCoord4ivARB = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord4ivARB");
        _glMultiTexCoord4sARB = (delegate* unmanaged<uint, short, short, short, short, void>)QuickGL.GetGLProcAddress("glMultiTexCoord4sARB");
        _glMultiTexCoord4svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glMultiTexCoord4svARB");
    }
    
    internal static void Unload()
    {
        _glActiveTextureARB = null;
        _glClientActiveTextureARB = null;
        _glMultiTexCoord1dARB = null;
        _glMultiTexCoord1dvARB = null;
        _glMultiTexCoord1fARB = null;
        _glMultiTexCoord1fvARB = null;
        _glMultiTexCoord1iARB = null;
        _glMultiTexCoord1ivARB = null;
        _glMultiTexCoord1sARB = null;
        _glMultiTexCoord1svARB = null;
        _glMultiTexCoord2dARB = null;
        _glMultiTexCoord2dvARB = null;
        _glMultiTexCoord2fARB = null;
        _glMultiTexCoord2fvARB = null;
        _glMultiTexCoord2iARB = null;
        _glMultiTexCoord2ivARB = null;
        _glMultiTexCoord2sARB = null;
        _glMultiTexCoord2svARB = null;
        _glMultiTexCoord3dARB = null;
        _glMultiTexCoord3dvARB = null;
        _glMultiTexCoord3fARB = null;
        _glMultiTexCoord3fvARB = null;
        _glMultiTexCoord3iARB = null;
        _glMultiTexCoord3ivARB = null;
        _glMultiTexCoord3sARB = null;
        _glMultiTexCoord3svARB = null;
        _glMultiTexCoord4dARB = null;
        _glMultiTexCoord4dvARB = null;
        _glMultiTexCoord4fARB = null;
        _glMultiTexCoord4fvARB = null;
        _glMultiTexCoord4iARB = null;
        _glMultiTexCoord4ivARB = null;
        _glMultiTexCoord4sARB = null;
        _glMultiTexCoord4svARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_multitexture", true, false);
}
