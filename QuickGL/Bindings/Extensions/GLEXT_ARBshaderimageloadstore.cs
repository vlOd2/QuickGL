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

// Bindings generated at 2025-08-30 15:45:08.674807
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_shader_image_load_store", true, false)]
public static unsafe class GLEXT_ARBshaderimageloadstore
{
    #region Enums
    public const int GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x1;
    public const int GL_ELEMENT_ARRAY_BARRIER_BIT = 0x2;
    public const int GL_UNIFORM_BARRIER_BIT = 0x4;
    public const int GL_TEXTURE_FETCH_BARRIER_BIT = 0x8;
    public const int GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x20;
    public const int GL_COMMAND_BARRIER_BIT = 0x40;
    public const int GL_PIXEL_BUFFER_BARRIER_BIT = 0x80;
    public const int GL_TEXTURE_UPDATE_BARRIER_BIT = 0x100;
    public const int GL_BUFFER_UPDATE_BARRIER_BIT = 0x200;
    public const int GL_FRAMEBUFFER_BARRIER_BIT = 0x400;
    public const int GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x800;
    public const int GL_ATOMIC_COUNTER_BARRIER_BIT = 0x1000;
    public const uint GL_ALL_BARRIER_BITS = 0xFFFFFFFF;
    public const int GL_MAX_IMAGE_UNITS = 0x8F38;
    public const int GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
    public const int GL_IMAGE_BINDING_NAME = 0x8F3A;
    public const int GL_IMAGE_BINDING_LEVEL = 0x8F3B;
    public const int GL_IMAGE_BINDING_LAYERED = 0x8F3C;
    public const int GL_IMAGE_BINDING_LAYER = 0x8F3D;
    public const int GL_IMAGE_BINDING_ACCESS = 0x8F3E;
    public const int GL_IMAGE_1D = 0x904C;
    public const int GL_IMAGE_2D = 0x904D;
    public const int GL_IMAGE_3D = 0x904E;
    public const int GL_IMAGE_2D_RECT = 0x904F;
    public const int GL_IMAGE_CUBE = 0x9050;
    public const int GL_IMAGE_BUFFER = 0x9051;
    public const int GL_IMAGE_1D_ARRAY = 0x9052;
    public const int GL_IMAGE_2D_ARRAY = 0x9053;
    public const int GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;
    public const int GL_IMAGE_2D_MULTISAMPLE = 0x9055;
    public const int GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
    public const int GL_INT_IMAGE_1D = 0x9057;
    public const int GL_INT_IMAGE_2D = 0x9058;
    public const int GL_INT_IMAGE_3D = 0x9059;
    public const int GL_INT_IMAGE_2D_RECT = 0x905A;
    public const int GL_INT_IMAGE_CUBE = 0x905B;
    public const int GL_INT_IMAGE_BUFFER = 0x905C;
    public const int GL_INT_IMAGE_1D_ARRAY = 0x905D;
    public const int GL_INT_IMAGE_2D_ARRAY = 0x905E;
    public const int GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
    public const int GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060;
    public const int GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
    public const int GL_UNSIGNED_INT_IMAGE_1D = 0x9062;
    public const int GL_UNSIGNED_INT_IMAGE_2D = 0x9063;
    public const int GL_UNSIGNED_INT_IMAGE_3D = 0x9064;
    public const int GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
    public const int GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;
    public const int GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
    public const int GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
    public const int GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
    public const int GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
    public const int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
    public const int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
    public const int GL_MAX_IMAGE_SAMPLES = 0x906D;
    public const int GL_IMAGE_BINDING_FORMAT = 0x906E;
    public const int GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
    public const int GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
    public const int GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
    public const int GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
    public const int GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
    public const int GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
    public const int GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
    public const int GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
    public const int GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
    #endregion
    
    #region Commands
    public static void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format) { QGLNativeAPI.Verify((nint)_glBindImageTexture); _glBindImageTexture(unit, texture, level, layered, layer, access, format); }
    [QGLNativeAPI("glBindImageTexture")] internal static delegate* unmanaged<uint, uint, int, bool, int, uint, uint, void> _glBindImageTexture = null;
    
    public static void glMemoryBarrier(uint barriers) { QGLNativeAPI.Verify((nint)_glMemoryBarrier); _glMemoryBarrier(barriers); }
    [QGLNativeAPI("glMemoryBarrier")] internal static delegate* unmanaged<uint, void> _glMemoryBarrier = null;
     #endregion
}
