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

// Bindings generated at 2025-08-30 15:45:08.710826
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_tessellation_shader", true, false)]
public static unsafe class GLEXT_ARBtessellationshader
{
    #region Enums
    public const int GL_PATCHES = 0xE;
    public const int GL_PATCH_VERTICES = 0x8E72;
    public const int GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
    public const int GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
    public const int GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
    public const int GL_TESS_GEN_MODE = 0x8E76;
    public const int GL_TESS_GEN_SPACING = 0x8E77;
    public const int GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
    public const int GL_TESS_GEN_POINT_MODE = 0x8E79;
    public const int GL_TRIANGLES = 0x4;
    public const int GL_ISOLINES = 0x8E7A;
    public const int GL_QUADS = 0x7;
    public const int GL_EQUAL = 0x202;
    public const int GL_FRACTIONAL_ODD = 0x8E7B;
    public const int GL_FRACTIONAL_EVEN = 0x8E7C;
    public const int GL_CCW = 0x901;
    public const int GL_CW = 0x900;
    public const int GL_MAX_PATCH_VERTICES = 0x8E7D;
    public const int GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
    public const int GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
    public const int GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
    public const int GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
    public const int GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
    public const int GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
    public const int GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
    public const int GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
    public const int GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
    public const int GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
    public const int GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
    public const int GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
    public const int GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
    public const int GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
    public const int GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
    public const int GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
    public const int GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
    public const int GL_TESS_EVALUATION_SHADER = 0x8E87;
    public const int GL_TESS_CONTROL_SHADER = 0x8E88;
    #endregion
    
    #region Commands
    public static void glPatchParameteri(uint pname, int value) { QGLNativeAPI.Verify((nint)_glPatchParameteri); _glPatchParameteri(pname, value); }
    [QGLNativeAPI("glPatchParameteri")] internal static delegate* unmanaged<uint, int, void> _glPatchParameteri = null;
    
    public static void glPatchParameterfv(uint pname, float* values) { QGLNativeAPI.Verify((nint)_glPatchParameterfv); _glPatchParameterfv(pname, values); }
    [QGLNativeAPI("glPatchParameterfv")] internal static delegate* unmanaged<uint, float*, void> _glPatchParameterfv = null;
     #endregion
}
