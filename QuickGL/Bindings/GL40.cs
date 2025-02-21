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

// Bindings generated at 2025-02-21 16:29:58.866977
namespace QuickGLNS.Bindings;

[GLFeature(false)]
public static unsafe class GL40
{
    #region Enums
    public const int GL_SAMPLE_SHADING = 0x8C36;
    public const int GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;
    public const int GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
    public const int GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
    public const int GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
    public const int GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
    public const int GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
    public const int GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;
    public const int GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
    public const int GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
    public const int GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
    public const int GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
    public const int GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
    public const int GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
    public const int GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
    public const int GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
    public const int GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
    public const int GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
    public const int GL_MAX_VERTEX_STREAMS = 0x8E71;
    public const int GL_DOUBLE_VEC2 = 0x8FFC;
    public const int GL_DOUBLE_VEC3 = 0x8FFD;
    public const int GL_DOUBLE_VEC4 = 0x8FFE;
    public const int GL_DOUBLE_MAT2 = 0x8F46;
    public const int GL_DOUBLE_MAT3 = 0x8F47;
    public const int GL_DOUBLE_MAT4 = 0x8F48;
    public const int GL_DOUBLE_MAT2x3 = 0x8F49;
    public const int GL_DOUBLE_MAT2x4 = 0x8F4A;
    public const int GL_DOUBLE_MAT3x2 = 0x8F4B;
    public const int GL_DOUBLE_MAT3x4 = 0x8F4C;
    public const int GL_DOUBLE_MAT4x2 = 0x8F4D;
    public const int GL_DOUBLE_MAT4x3 = 0x8F4E;
    public const int GL_ACTIVE_SUBROUTINES = 0x8DE5;
    public const int GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
    public const int GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
    public const int GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
    public const int GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
    public const int GL_MAX_SUBROUTINES = 0x8DE7;
    public const int GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
    public const int GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
    public const int GL_COMPATIBLE_SUBROUTINES = 0x8E4B;
    public const int GL_PATCHES = 0xE;
    public const int GL_PATCH_VERTICES = 0x8E72;
    public const int GL_PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
    public const int GL_PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
    public const int GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
    public const int GL_TESS_GEN_MODE = 0x8E76;
    public const int GL_TESS_GEN_SPACING = 0x8E77;
    public const int GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
    public const int GL_TESS_GEN_POINT_MODE = 0x8E79;
    public const int GL_ISOLINES = 0x8E7A;
    public const int GL_QUADS = 0x7;
    public const int GL_FRACTIONAL_ODD = 0x8E7B;
    public const int GL_FRACTIONAL_EVEN = 0x8E7C;
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
    public const int GL_TRANSFORM_FEEDBACK = 0x8E22;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
    public const int GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
    public const int GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
    #endregion
    
    #region Commands
    public static void glMinSampleShading(float value) => _glMinSampleShading(value);
    [QGLNativeAPI("glMinSampleShading")] internal static delegate* unmanaged<float, void> _glMinSampleShading = null;
    
    public static void glBlendEquationi(uint buf, uint mode) => _glBlendEquationi(buf, mode);
    [QGLNativeAPI("glBlendEquationi")] internal static delegate* unmanaged<uint, uint, void> _glBlendEquationi = null;
    
    public static void glBlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha) => _glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
    [QGLNativeAPI("glBlendEquationSeparatei")] internal static delegate* unmanaged<uint, uint, uint, void> _glBlendEquationSeparatei = null;
    
    public static void glBlendFunci(uint buf, uint src, uint dst) => _glBlendFunci(buf, src, dst);
    [QGLNativeAPI("glBlendFunci")] internal static delegate* unmanaged<uint, uint, uint, void> _glBlendFunci = null;
    
    public static void glBlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) => _glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
    [QGLNativeAPI("glBlendFuncSeparatei")] internal static delegate* unmanaged<uint, uint, uint, uint, uint, void> _glBlendFuncSeparatei = null;
    
    public static void glDrawArraysIndirect(uint mode, void* indirect) => _glDrawArraysIndirect(mode, indirect);
    [QGLNativeAPI("glDrawArraysIndirect")] internal static delegate* unmanaged<uint, void*, void> _glDrawArraysIndirect = null;
    
    public static void glDrawElementsIndirect(uint mode, uint type, void* indirect) => _glDrawElementsIndirect(mode, type, indirect);
    [QGLNativeAPI("glDrawElementsIndirect")] internal static delegate* unmanaged<uint, uint, void*, void> _glDrawElementsIndirect = null;
    
    public static void glUniform1d(int location, double x) => _glUniform1d(location, x);
    [QGLNativeAPI("glUniform1d")] internal static delegate* unmanaged<int, double, void> _glUniform1d = null;
    
    public static void glUniform2d(int location, double x, double y) => _glUniform2d(location, x, y);
    [QGLNativeAPI("glUniform2d")] internal static delegate* unmanaged<int, double, double, void> _glUniform2d = null;
    
    public static void glUniform3d(int location, double x, double y, double z) => _glUniform3d(location, x, y, z);
    [QGLNativeAPI("glUniform3d")] internal static delegate* unmanaged<int, double, double, double, void> _glUniform3d = null;
    
    public static void glUniform4d(int location, double x, double y, double z, double w) => _glUniform4d(location, x, y, z, w);
    [QGLNativeAPI("glUniform4d")] internal static delegate* unmanaged<int, double, double, double, double, void> _glUniform4d = null;
    
    public static void glUniform1dv(int location, int count, double* value) => _glUniform1dv(location, count, value);
    [QGLNativeAPI("glUniform1dv")] internal static delegate* unmanaged<int, int, double*, void> _glUniform1dv = null;
    
    public static void glUniform2dv(int location, int count, double* value) => _glUniform2dv(location, count, value);
    [QGLNativeAPI("glUniform2dv")] internal static delegate* unmanaged<int, int, double*, void> _glUniform2dv = null;
    
    public static void glUniform3dv(int location, int count, double* value) => _glUniform3dv(location, count, value);
    [QGLNativeAPI("glUniform3dv")] internal static delegate* unmanaged<int, int, double*, void> _glUniform3dv = null;
    
    public static void glUniform4dv(int location, int count, double* value) => _glUniform4dv(location, count, value);
    [QGLNativeAPI("glUniform4dv")] internal static delegate* unmanaged<int, int, double*, void> _glUniform4dv = null;
    
    public static void glUniformMatrix2dv(int location, int count, bool transpose, double* value) => _glUniformMatrix2dv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix2dv")] internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix2dv = null;
    
    public static void glUniformMatrix3dv(int location, int count, bool transpose, double* value) => _glUniformMatrix3dv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix3dv")] internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix3dv = null;
    
    public static void glUniformMatrix4dv(int location, int count, bool transpose, double* value) => _glUniformMatrix4dv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix4dv")] internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix4dv = null;
    
    public static void glUniformMatrix2x3dv(int location, int count, bool transpose, double* value) => _glUniformMatrix2x3dv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix2x3dv")] internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix2x3dv = null;
    
    public static void glUniformMatrix2x4dv(int location, int count, bool transpose, double* value) => _glUniformMatrix2x4dv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix2x4dv")] internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix2x4dv = null;
    
    public static void glUniformMatrix3x2dv(int location, int count, bool transpose, double* value) => _glUniformMatrix3x2dv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix3x2dv")] internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix3x2dv = null;
    
    public static void glUniformMatrix3x4dv(int location, int count, bool transpose, double* value) => _glUniformMatrix3x4dv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix3x4dv")] internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix3x4dv = null;
    
    public static void glUniformMatrix4x2dv(int location, int count, bool transpose, double* value) => _glUniformMatrix4x2dv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix4x2dv")] internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix4x2dv = null;
    
    public static void glUniformMatrix4x3dv(int location, int count, bool transpose, double* value) => _glUniformMatrix4x3dv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix4x3dv")] internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix4x3dv = null;
    
    public static void glGetUniformdv(uint program, int location, double* @params) => _glGetUniformdv(program, location, @params);
    [QGLNativeAPI("glGetUniformdv")] internal static delegate* unmanaged<uint, int, double*, void> _glGetUniformdv = null;
    
    public static int glGetSubroutineUniformLocation(uint program, uint shadertype, byte* name) => _glGetSubroutineUniformLocation(program, shadertype, name);
    [QGLNativeAPI("glGetSubroutineUniformLocation")] internal static delegate* unmanaged<uint, uint, byte*, int> _glGetSubroutineUniformLocation = null;
    
    public static uint glGetSubroutineIndex(uint program, uint shadertype, byte* name) => _glGetSubroutineIndex(program, shadertype, name);
    [QGLNativeAPI("glGetSubroutineIndex")] internal static delegate* unmanaged<uint, uint, byte*, uint> _glGetSubroutineIndex = null;
    
    public static void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values) => _glGetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
    [QGLNativeAPI("glGetActiveSubroutineUniformiv")] internal static delegate* unmanaged<uint, uint, uint, uint, int*, void> _glGetActiveSubroutineUniformiv = null;
    
    public static void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize, int* length, byte* name) => _glGetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, name);
    [QGLNativeAPI("glGetActiveSubroutineUniformName")] internal static delegate* unmanaged<uint, uint, uint, int, int*, byte*, void> _glGetActiveSubroutineUniformName = null;
    
    public static void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize, int* length, byte* name) => _glGetActiveSubroutineName(program, shadertype, index, bufSize, length, name);
    [QGLNativeAPI("glGetActiveSubroutineName")] internal static delegate* unmanaged<uint, uint, uint, int, int*, byte*, void> _glGetActiveSubroutineName = null;
    
    public static void glUniformSubroutinesuiv(uint shadertype, int count, uint* indices) => _glUniformSubroutinesuiv(shadertype, count, indices);
    [QGLNativeAPI("glUniformSubroutinesuiv")] internal static delegate* unmanaged<uint, int, uint*, void> _glUniformSubroutinesuiv = null;
    
    public static void glGetUniformSubroutineuiv(uint shadertype, int location, uint* @params) => _glGetUniformSubroutineuiv(shadertype, location, @params);
    [QGLNativeAPI("glGetUniformSubroutineuiv")] internal static delegate* unmanaged<uint, int, uint*, void> _glGetUniformSubroutineuiv = null;
    
    public static void glGetProgramStageiv(uint program, uint shadertype, uint pname, int* values) => _glGetProgramStageiv(program, shadertype, pname, values);
    [QGLNativeAPI("glGetProgramStageiv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetProgramStageiv = null;
    
    public static void glPatchParameteri(uint pname, int value) => _glPatchParameteri(pname, value);
    [QGLNativeAPI("glPatchParameteri")] internal static delegate* unmanaged<uint, int, void> _glPatchParameteri = null;
    
    public static void glPatchParameterfv(uint pname, float* values) => _glPatchParameterfv(pname, values);
    [QGLNativeAPI("glPatchParameterfv")] internal static delegate* unmanaged<uint, float*, void> _glPatchParameterfv = null;
    
    public static void glBindTransformFeedback(uint target, uint id) => _glBindTransformFeedback(target, id);
    [QGLNativeAPI("glBindTransformFeedback")] internal static delegate* unmanaged<uint, uint, void> _glBindTransformFeedback = null;
    
    public static void glDeleteTransformFeedbacks(int n, uint* ids) => _glDeleteTransformFeedbacks(n, ids);
    [QGLNativeAPI("glDeleteTransformFeedbacks")] internal static delegate* unmanaged<int, uint*, void> _glDeleteTransformFeedbacks = null;
    
    public static void glGenTransformFeedbacks(int n, uint* ids) => _glGenTransformFeedbacks(n, ids);
    [QGLNativeAPI("glGenTransformFeedbacks")] internal static delegate* unmanaged<int, uint*, void> _glGenTransformFeedbacks = null;
    
    public static bool glIsTransformFeedback(uint id) => _glIsTransformFeedback(id);
    [QGLNativeAPI("glIsTransformFeedback")] internal static delegate* unmanaged<uint, bool> _glIsTransformFeedback = null;
    
    public static void glPauseTransformFeedback() => _glPauseTransformFeedback();
    [QGLNativeAPI("glPauseTransformFeedback")] internal static delegate* unmanaged<void> _glPauseTransformFeedback = null;
    
    public static void glResumeTransformFeedback() => _glResumeTransformFeedback();
    [QGLNativeAPI("glResumeTransformFeedback")] internal static delegate* unmanaged<void> _glResumeTransformFeedback = null;
    
    public static void glDrawTransformFeedback(uint mode, uint id) => _glDrawTransformFeedback(mode, id);
    [QGLNativeAPI("glDrawTransformFeedback")] internal static delegate* unmanaged<uint, uint, void> _glDrawTransformFeedback = null;
    
    public static void glDrawTransformFeedbackStream(uint mode, uint id, uint stream) => _glDrawTransformFeedbackStream(mode, id, stream);
    [QGLNativeAPI("glDrawTransformFeedbackStream")] internal static delegate* unmanaged<uint, uint, uint, void> _glDrawTransformFeedbackStream = null;
    
    public static void glBeginQueryIndexed(uint target, uint index, uint id) => _glBeginQueryIndexed(target, index, id);
    [QGLNativeAPI("glBeginQueryIndexed")] internal static delegate* unmanaged<uint, uint, uint, void> _glBeginQueryIndexed = null;
    
    public static void glEndQueryIndexed(uint target, uint index) => _glEndQueryIndexed(target, index);
    [QGLNativeAPI("glEndQueryIndexed")] internal static delegate* unmanaged<uint, uint, void> _glEndQueryIndexed = null;
    
    public static void glGetQueryIndexediv(uint target, uint index, uint pname, int* @params) => _glGetQueryIndexediv(target, index, pname, @params);
    [QGLNativeAPI("glGetQueryIndexediv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetQueryIndexediv = null;
     #endregion
}
