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

// Bindings generated at 2025-08-30 15:45:08.556877
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_multitexture", true, false)]
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
    public static void glActiveTextureARB(uint texture) { QGLNativeAPI.Verify((nint)_glActiveTextureARB); _glActiveTextureARB(texture); }
    [QGLNativeAPI("glActiveTextureARB")] internal static delegate* unmanaged<uint, void> _glActiveTextureARB = null;
    
    public static void glClientActiveTextureARB(uint texture) { QGLNativeAPI.Verify((nint)_glClientActiveTextureARB); _glClientActiveTextureARB(texture); }
    [QGLNativeAPI("glClientActiveTextureARB")] internal static delegate* unmanaged<uint, void> _glClientActiveTextureARB = null;
    
    public static void glMultiTexCoord1dARB(uint target, double s) { QGLNativeAPI.Verify((nint)_glMultiTexCoord1dARB); _glMultiTexCoord1dARB(target, s); }
    [QGLNativeAPI("glMultiTexCoord1dARB")] internal static delegate* unmanaged<uint, double, void> _glMultiTexCoord1dARB = null;
    
    public static void glMultiTexCoord1dvARB(uint target, double* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord1dvARB); _glMultiTexCoord1dvARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord1dvARB")] internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord1dvARB = null;
    
    public static void glMultiTexCoord1fARB(uint target, float s) { QGLNativeAPI.Verify((nint)_glMultiTexCoord1fARB); _glMultiTexCoord1fARB(target, s); }
    [QGLNativeAPI("glMultiTexCoord1fARB")] internal static delegate* unmanaged<uint, float, void> _glMultiTexCoord1fARB = null;
    
    public static void glMultiTexCoord1fvARB(uint target, float* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord1fvARB); _glMultiTexCoord1fvARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord1fvARB")] internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord1fvARB = null;
    
    public static void glMultiTexCoord1iARB(uint target, int s) { QGLNativeAPI.Verify((nint)_glMultiTexCoord1iARB); _glMultiTexCoord1iARB(target, s); }
    [QGLNativeAPI("glMultiTexCoord1iARB")] internal static delegate* unmanaged<uint, int, void> _glMultiTexCoord1iARB = null;
    
    public static void glMultiTexCoord1ivARB(uint target, int* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord1ivARB); _glMultiTexCoord1ivARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord1ivARB")] internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord1ivARB = null;
    
    public static void glMultiTexCoord1sARB(uint target, short s) { QGLNativeAPI.Verify((nint)_glMultiTexCoord1sARB); _glMultiTexCoord1sARB(target, s); }
    [QGLNativeAPI("glMultiTexCoord1sARB")] internal static delegate* unmanaged<uint, short, void> _glMultiTexCoord1sARB = null;
    
    public static void glMultiTexCoord1svARB(uint target, short* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord1svARB); _glMultiTexCoord1svARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord1svARB")] internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord1svARB = null;
    
    public static void glMultiTexCoord2dARB(uint target, double s, double t) { QGLNativeAPI.Verify((nint)_glMultiTexCoord2dARB); _glMultiTexCoord2dARB(target, s, t); }
    [QGLNativeAPI("glMultiTexCoord2dARB")] internal static delegate* unmanaged<uint, double, double, void> _glMultiTexCoord2dARB = null;
    
    public static void glMultiTexCoord2dvARB(uint target, double* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord2dvARB); _glMultiTexCoord2dvARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord2dvARB")] internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord2dvARB = null;
    
    public static void glMultiTexCoord2fARB(uint target, float s, float t) { QGLNativeAPI.Verify((nint)_glMultiTexCoord2fARB); _glMultiTexCoord2fARB(target, s, t); }
    [QGLNativeAPI("glMultiTexCoord2fARB")] internal static delegate* unmanaged<uint, float, float, void> _glMultiTexCoord2fARB = null;
    
    public static void glMultiTexCoord2fvARB(uint target, float* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord2fvARB); _glMultiTexCoord2fvARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord2fvARB")] internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord2fvARB = null;
    
    public static void glMultiTexCoord2iARB(uint target, int s, int t) { QGLNativeAPI.Verify((nint)_glMultiTexCoord2iARB); _glMultiTexCoord2iARB(target, s, t); }
    [QGLNativeAPI("glMultiTexCoord2iARB")] internal static delegate* unmanaged<uint, int, int, void> _glMultiTexCoord2iARB = null;
    
    public static void glMultiTexCoord2ivARB(uint target, int* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord2ivARB); _glMultiTexCoord2ivARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord2ivARB")] internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord2ivARB = null;
    
    public static void glMultiTexCoord2sARB(uint target, short s, short t) { QGLNativeAPI.Verify((nint)_glMultiTexCoord2sARB); _glMultiTexCoord2sARB(target, s, t); }
    [QGLNativeAPI("glMultiTexCoord2sARB")] internal static delegate* unmanaged<uint, short, short, void> _glMultiTexCoord2sARB = null;
    
    public static void glMultiTexCoord2svARB(uint target, short* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord2svARB); _glMultiTexCoord2svARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord2svARB")] internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord2svARB = null;
    
    public static void glMultiTexCoord3dARB(uint target, double s, double t, double r) { QGLNativeAPI.Verify((nint)_glMultiTexCoord3dARB); _glMultiTexCoord3dARB(target, s, t, r); }
    [QGLNativeAPI("glMultiTexCoord3dARB")] internal static delegate* unmanaged<uint, double, double, double, void> _glMultiTexCoord3dARB = null;
    
    public static void glMultiTexCoord3dvARB(uint target, double* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord3dvARB); _glMultiTexCoord3dvARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord3dvARB")] internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord3dvARB = null;
    
    public static void glMultiTexCoord3fARB(uint target, float s, float t, float r) { QGLNativeAPI.Verify((nint)_glMultiTexCoord3fARB); _glMultiTexCoord3fARB(target, s, t, r); }
    [QGLNativeAPI("glMultiTexCoord3fARB")] internal static delegate* unmanaged<uint, float, float, float, void> _glMultiTexCoord3fARB = null;
    
    public static void glMultiTexCoord3fvARB(uint target, float* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord3fvARB); _glMultiTexCoord3fvARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord3fvARB")] internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord3fvARB = null;
    
    public static void glMultiTexCoord3iARB(uint target, int s, int t, int r) { QGLNativeAPI.Verify((nint)_glMultiTexCoord3iARB); _glMultiTexCoord3iARB(target, s, t, r); }
    [QGLNativeAPI("glMultiTexCoord3iARB")] internal static delegate* unmanaged<uint, int, int, int, void> _glMultiTexCoord3iARB = null;
    
    public static void glMultiTexCoord3ivARB(uint target, int* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord3ivARB); _glMultiTexCoord3ivARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord3ivARB")] internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord3ivARB = null;
    
    public static void glMultiTexCoord3sARB(uint target, short s, short t, short r) { QGLNativeAPI.Verify((nint)_glMultiTexCoord3sARB); _glMultiTexCoord3sARB(target, s, t, r); }
    [QGLNativeAPI("glMultiTexCoord3sARB")] internal static delegate* unmanaged<uint, short, short, short, void> _glMultiTexCoord3sARB = null;
    
    public static void glMultiTexCoord3svARB(uint target, short* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord3svARB); _glMultiTexCoord3svARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord3svARB")] internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord3svARB = null;
    
    public static void glMultiTexCoord4dARB(uint target, double s, double t, double r, double q) { QGLNativeAPI.Verify((nint)_glMultiTexCoord4dARB); _glMultiTexCoord4dARB(target, s, t, r, q); }
    [QGLNativeAPI("glMultiTexCoord4dARB")] internal static delegate* unmanaged<uint, double, double, double, double, void> _glMultiTexCoord4dARB = null;
    
    public static void glMultiTexCoord4dvARB(uint target, double* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord4dvARB); _glMultiTexCoord4dvARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord4dvARB")] internal static delegate* unmanaged<uint, double*, void> _glMultiTexCoord4dvARB = null;
    
    public static void glMultiTexCoord4fARB(uint target, float s, float t, float r, float q) { QGLNativeAPI.Verify((nint)_glMultiTexCoord4fARB); _glMultiTexCoord4fARB(target, s, t, r, q); }
    [QGLNativeAPI("glMultiTexCoord4fARB")] internal static delegate* unmanaged<uint, float, float, float, float, void> _glMultiTexCoord4fARB = null;
    
    public static void glMultiTexCoord4fvARB(uint target, float* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord4fvARB); _glMultiTexCoord4fvARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord4fvARB")] internal static delegate* unmanaged<uint, float*, void> _glMultiTexCoord4fvARB = null;
    
    public static void glMultiTexCoord4iARB(uint target, int s, int t, int r, int q) { QGLNativeAPI.Verify((nint)_glMultiTexCoord4iARB); _glMultiTexCoord4iARB(target, s, t, r, q); }
    [QGLNativeAPI("glMultiTexCoord4iARB")] internal static delegate* unmanaged<uint, int, int, int, int, void> _glMultiTexCoord4iARB = null;
    
    public static void glMultiTexCoord4ivARB(uint target, int* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord4ivARB); _glMultiTexCoord4ivARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord4ivARB")] internal static delegate* unmanaged<uint, int*, void> _glMultiTexCoord4ivARB = null;
    
    public static void glMultiTexCoord4sARB(uint target, short s, short t, short r, short q) { QGLNativeAPI.Verify((nint)_glMultiTexCoord4sARB); _glMultiTexCoord4sARB(target, s, t, r, q); }
    [QGLNativeAPI("glMultiTexCoord4sARB")] internal static delegate* unmanaged<uint, short, short, short, short, void> _glMultiTexCoord4sARB = null;
    
    public static void glMultiTexCoord4svARB(uint target, short* v) { QGLNativeAPI.Verify((nint)_glMultiTexCoord4svARB); _glMultiTexCoord4svARB(target, v); }
    [QGLNativeAPI("glMultiTexCoord4svARB")] internal static delegate* unmanaged<uint, short*, void> _glMultiTexCoord4svARB = null;
     #endregion
}
