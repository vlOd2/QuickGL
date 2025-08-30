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

// Bindings generated at 2025-08-30 15:45:08.743033
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_texture_multisample", true, false)]
public static unsafe class GLEXT_ARBtexturemultisample
{
    #region Enums
    public const int GL_SAMPLE_POSITION = 0x8E50;
    public const int GL_SAMPLE_MASK = 0x8E51;
    public const int GL_SAMPLE_MASK_VALUE = 0x8E52;
    public const int GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
    public const int GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
    public const int GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
    public const int GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
    public const int GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
    public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
    public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
    public const int GL_TEXTURE_SAMPLES = 0x9106;
    public const int GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
    public const int GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
    public const int GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
    public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
    public const int GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
    public const int GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
    public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
    public const int GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
    public const int GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
    public const int GL_MAX_INTEGER_SAMPLES = 0x9110;
    #endregion
    
    #region Commands
    public static void glTexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) { QGLNativeAPI.Verify((nint)_glTexImage2DMultisample); _glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations); }
    [QGLNativeAPI("glTexImage2DMultisample")] internal static delegate* unmanaged<uint, int, uint, int, int, bool, void> _glTexImage2DMultisample = null;
    
    public static void glTexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations) { QGLNativeAPI.Verify((nint)_glTexImage3DMultisample); _glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations); }
    [QGLNativeAPI("glTexImage3DMultisample")] internal static delegate* unmanaged<uint, int, uint, int, int, int, bool, void> _glTexImage3DMultisample = null;
    
    public static void glGetMultisamplefv(uint pname, uint index, float* val) { QGLNativeAPI.Verify((nint)_glGetMultisamplefv); _glGetMultisamplefv(pname, index, val); }
    [QGLNativeAPI("glGetMultisamplefv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetMultisamplefv = null;
    
    public static void glSampleMaski(uint maskNumber, uint mask) { QGLNativeAPI.Verify((nint)_glSampleMaski); _glSampleMaski(maskNumber, mask); }
    [QGLNativeAPI("glSampleMaski")] internal static delegate* unmanaged<uint, uint, void> _glSampleMaski = null;
     #endregion
}
