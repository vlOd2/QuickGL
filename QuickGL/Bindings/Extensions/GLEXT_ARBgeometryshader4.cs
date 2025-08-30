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

// Bindings generated at 2025-08-30 15:45:08.528425
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_geometry_shader4", true, false)]
public static unsafe class GLEXT_ARBgeometryshader4
{
    #region Enums
    public const int GL_LINES_ADJACENCY_ARB = 0xA;
    public const int GL_LINE_STRIP_ADJACENCY_ARB = 0xB;
    public const int GL_TRIANGLES_ADJACENCY_ARB = 0xC;
    public const int GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0xD;
    public const int GL_PROGRAM_POINT_SIZE_ARB = 0x8642;
    public const int GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29;
    public const int GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7;
    public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8;
    public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;
    public const int GL_GEOMETRY_SHADER_ARB = 0x8DD9;
    public const int GL_GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;
    public const int GL_GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;
    public const int GL_GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;
    public const int GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;
    public const int GL_MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;
    public const int GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF;
    public const int GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0;
    public const int GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1;
    public const int GL_MAX_VARYING_COMPONENTS = 0x8B4B;
    public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
    #endregion
    
    #region Commands
    public static void glProgramParameteriARB(uint program, uint pname, int value) { QGLNativeAPI.Verify((nint)_glProgramParameteriARB); _glProgramParameteriARB(program, pname, value); }
    [QGLNativeAPI("glProgramParameteriARB")] internal static delegate* unmanaged<uint, uint, int, void> _glProgramParameteriARB = null;
    
    public static void glFramebufferTextureARB(uint target, uint attachment, uint texture, int level) { QGLNativeAPI.Verify((nint)_glFramebufferTextureARB); _glFramebufferTextureARB(target, attachment, texture, level); }
    [QGLNativeAPI("glFramebufferTextureARB")] internal static delegate* unmanaged<uint, uint, uint, int, void> _glFramebufferTextureARB = null;
    
    public static void glFramebufferTextureLayerARB(uint target, uint attachment, uint texture, int level, int layer) { QGLNativeAPI.Verify((nint)_glFramebufferTextureLayerARB); _glFramebufferTextureLayerARB(target, attachment, texture, level, layer); }
    [QGLNativeAPI("glFramebufferTextureLayerARB")] internal static delegate* unmanaged<uint, uint, uint, int, int, void> _glFramebufferTextureLayerARB = null;
    
    public static void glFramebufferTextureFaceARB(uint target, uint attachment, uint texture, int level, uint face) { QGLNativeAPI.Verify((nint)_glFramebufferTextureFaceARB); _glFramebufferTextureFaceARB(target, attachment, texture, level, face); }
    [QGLNativeAPI("glFramebufferTextureFaceARB")] internal static delegate* unmanaged<uint, uint, uint, int, uint, void> _glFramebufferTextureFaceARB = null;
     #endregion
}
