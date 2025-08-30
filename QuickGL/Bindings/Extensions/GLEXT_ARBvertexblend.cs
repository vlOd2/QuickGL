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

// Bindings generated at 2025-08-30 15:45:08.777389
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_vertex_blend", true, false)]
public static unsafe class GLEXT_ARBvertexblend
{
    #region Enums
    public const int GL_MAX_VERTEX_UNITS_ARB = 0x86A4;
    public const int GL_ACTIVE_VERTEX_UNITS_ARB = 0x86A5;
    public const int GL_WEIGHT_SUM_UNITY_ARB = 0x86A6;
    public const int GL_VERTEX_BLEND_ARB = 0x86A7;
    public const int GL_CURRENT_WEIGHT_ARB = 0x86A8;
    public const int GL_WEIGHT_ARRAY_TYPE_ARB = 0x86A9;
    public const int GL_WEIGHT_ARRAY_STRIDE_ARB = 0x86AA;
    public const int GL_WEIGHT_ARRAY_SIZE_ARB = 0x86AB;
    public const int GL_WEIGHT_ARRAY_POINTER_ARB = 0x86AC;
    public const int GL_WEIGHT_ARRAY_ARB = 0x86AD;
    public const int GL_MODELVIEW0_ARB = 0x1700;
    public const int GL_MODELVIEW1_ARB = 0x850A;
    public const int GL_MODELVIEW2_ARB = 0x8722;
    public const int GL_MODELVIEW3_ARB = 0x8723;
    public const int GL_MODELVIEW4_ARB = 0x8724;
    public const int GL_MODELVIEW5_ARB = 0x8725;
    public const int GL_MODELVIEW6_ARB = 0x8726;
    public const int GL_MODELVIEW7_ARB = 0x8727;
    public const int GL_MODELVIEW8_ARB = 0x8728;
    public const int GL_MODELVIEW9_ARB = 0x8729;
    public const int GL_MODELVIEW10_ARB = 0x872A;
    public const int GL_MODELVIEW11_ARB = 0x872B;
    public const int GL_MODELVIEW12_ARB = 0x872C;
    public const int GL_MODELVIEW13_ARB = 0x872D;
    public const int GL_MODELVIEW14_ARB = 0x872E;
    public const int GL_MODELVIEW15_ARB = 0x872F;
    public const int GL_MODELVIEW16_ARB = 0x8730;
    public const int GL_MODELVIEW17_ARB = 0x8731;
    public const int GL_MODELVIEW18_ARB = 0x8732;
    public const int GL_MODELVIEW19_ARB = 0x8733;
    public const int GL_MODELVIEW20_ARB = 0x8734;
    public const int GL_MODELVIEW21_ARB = 0x8735;
    public const int GL_MODELVIEW22_ARB = 0x8736;
    public const int GL_MODELVIEW23_ARB = 0x8737;
    public const int GL_MODELVIEW24_ARB = 0x8738;
    public const int GL_MODELVIEW25_ARB = 0x8739;
    public const int GL_MODELVIEW26_ARB = 0x873A;
    public const int GL_MODELVIEW27_ARB = 0x873B;
    public const int GL_MODELVIEW28_ARB = 0x873C;
    public const int GL_MODELVIEW29_ARB = 0x873D;
    public const int GL_MODELVIEW30_ARB = 0x873E;
    public const int GL_MODELVIEW31_ARB = 0x873F;
    #endregion
    
    #region Commands
    public static void glWeightbvARB(int size, sbyte* weights) { QGLNativeAPI.Verify((nint)_glWeightbvARB); _glWeightbvARB(size, weights); }
    [QGLNativeAPI("glWeightbvARB")] internal static delegate* unmanaged<int, sbyte*, void> _glWeightbvARB = null;
    
    public static void glWeightsvARB(int size, short* weights) { QGLNativeAPI.Verify((nint)_glWeightsvARB); _glWeightsvARB(size, weights); }
    [QGLNativeAPI("glWeightsvARB")] internal static delegate* unmanaged<int, short*, void> _glWeightsvARB = null;
    
    public static void glWeightivARB(int size, int* weights) { QGLNativeAPI.Verify((nint)_glWeightivARB); _glWeightivARB(size, weights); }
    [QGLNativeAPI("glWeightivARB")] internal static delegate* unmanaged<int, int*, void> _glWeightivARB = null;
    
    public static void glWeightfvARB(int size, float* weights) { QGLNativeAPI.Verify((nint)_glWeightfvARB); _glWeightfvARB(size, weights); }
    [QGLNativeAPI("glWeightfvARB")] internal static delegate* unmanaged<int, float*, void> _glWeightfvARB = null;
    
    public static void glWeightdvARB(int size, double* weights) { QGLNativeAPI.Verify((nint)_glWeightdvARB); _glWeightdvARB(size, weights); }
    [QGLNativeAPI("glWeightdvARB")] internal static delegate* unmanaged<int, double*, void> _glWeightdvARB = null;
    
    public static void glWeightubvARB(int size, byte* weights) { QGLNativeAPI.Verify((nint)_glWeightubvARB); _glWeightubvARB(size, weights); }
    [QGLNativeAPI("glWeightubvARB")] internal static delegate* unmanaged<int, byte*, void> _glWeightubvARB = null;
    
    public static void glWeightusvARB(int size, ushort* weights) { QGLNativeAPI.Verify((nint)_glWeightusvARB); _glWeightusvARB(size, weights); }
    [QGLNativeAPI("glWeightusvARB")] internal static delegate* unmanaged<int, ushort*, void> _glWeightusvARB = null;
    
    public static void glWeightuivARB(int size, uint* weights) { QGLNativeAPI.Verify((nint)_glWeightuivARB); _glWeightuivARB(size, weights); }
    [QGLNativeAPI("glWeightuivARB")] internal static delegate* unmanaged<int, uint*, void> _glWeightuivARB = null;
    
    public static void glWeightPointerARB(int size, uint type, int stride, void* pointer) { QGLNativeAPI.Verify((nint)_glWeightPointerARB); _glWeightPointerARB(size, type, stride, pointer); }
    [QGLNativeAPI("glWeightPointerARB")] internal static delegate* unmanaged<int, uint, int, void*, void> _glWeightPointerARB = null;
    
    public static void glVertexBlendARB(int count) { QGLNativeAPI.Verify((nint)_glVertexBlendARB); _glVertexBlendARB(count); }
    [QGLNativeAPI("glVertexBlendARB")] internal static delegate* unmanaged<int, void> _glVertexBlendARB = null;
     #endregion
}
