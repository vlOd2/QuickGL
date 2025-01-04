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

// Bindings generated at 2025-01-04 01:08:51.544203
namespace QuickGLNS.Bindings
{
    [GLFeature]
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
        [QGLNativeAPI("glMinSampleShading")] public static delegate* unmanaged<float, void> glMinSampleShading;
        [QGLNativeAPI("glBlendEquationi")] public static delegate* unmanaged<uint, uint, void> glBlendEquationi;
        [QGLNativeAPI("glBlendEquationSeparatei")] public static delegate* unmanaged<uint, uint, uint, void> glBlendEquationSeparatei;
        [QGLNativeAPI("glBlendFunci")] public static delegate* unmanaged<uint, uint, uint, void> glBlendFunci;
        [QGLNativeAPI("glBlendFuncSeparatei")] public static delegate* unmanaged<uint, uint, uint, uint, uint, void> glBlendFuncSeparatei;
        [QGLNativeAPI("glDrawArraysIndirect")] public static delegate* unmanaged<uint, void*, void> glDrawArraysIndirect;
        [QGLNativeAPI("glDrawElementsIndirect")] public static delegate* unmanaged<uint, uint, void*, void> glDrawElementsIndirect;
        [QGLNativeAPI("glUniform1d")] public static delegate* unmanaged<int, double, void> glUniform1d;
        [QGLNativeAPI("glUniform2d")] public static delegate* unmanaged<int, double, double, void> glUniform2d;
        [QGLNativeAPI("glUniform3d")] public static delegate* unmanaged<int, double, double, double, void> glUniform3d;
        [QGLNativeAPI("glUniform4d")] public static delegate* unmanaged<int, double, double, double, double, void> glUniform4d;
        [QGLNativeAPI("glUniform1dv")] public static delegate* unmanaged<int, int, double*, void> glUniform1dv;
        [QGLNativeAPI("glUniform2dv")] public static delegate* unmanaged<int, int, double*, void> glUniform2dv;
        [QGLNativeAPI("glUniform3dv")] public static delegate* unmanaged<int, int, double*, void> glUniform3dv;
        [QGLNativeAPI("glUniform4dv")] public static delegate* unmanaged<int, int, double*, void> glUniform4dv;
        [QGLNativeAPI("glUniformMatrix2dv")] public static delegate* unmanaged<int, int, bool, double*, void> glUniformMatrix2dv;
        [QGLNativeAPI("glUniformMatrix3dv")] public static delegate* unmanaged<int, int, bool, double*, void> glUniformMatrix3dv;
        [QGLNativeAPI("glUniformMatrix4dv")] public static delegate* unmanaged<int, int, bool, double*, void> glUniformMatrix4dv;
        [QGLNativeAPI("glUniformMatrix2x3dv")] public static delegate* unmanaged<int, int, bool, double*, void> glUniformMatrix2x3dv;
        [QGLNativeAPI("glUniformMatrix2x4dv")] public static delegate* unmanaged<int, int, bool, double*, void> glUniformMatrix2x4dv;
        [QGLNativeAPI("glUniformMatrix3x2dv")] public static delegate* unmanaged<int, int, bool, double*, void> glUniformMatrix3x2dv;
        [QGLNativeAPI("glUniformMatrix3x4dv")] public static delegate* unmanaged<int, int, bool, double*, void> glUniformMatrix3x4dv;
        [QGLNativeAPI("glUniformMatrix4x2dv")] public static delegate* unmanaged<int, int, bool, double*, void> glUniformMatrix4x2dv;
        [QGLNativeAPI("glUniformMatrix4x3dv")] public static delegate* unmanaged<int, int, bool, double*, void> glUniformMatrix4x3dv;
        [QGLNativeAPI("glGetUniformdv")] public static delegate* unmanaged<uint, int, double*, void> glGetUniformdv;
        [QGLNativeAPI("glGetSubroutineUniformLocation")] public static delegate* unmanaged<uint, uint, char*, int> glGetSubroutineUniformLocation;
        [QGLNativeAPI("glGetSubroutineIndex")] public static delegate* unmanaged<uint, uint, char*, uint> glGetSubroutineIndex;
        [QGLNativeAPI("glGetActiveSubroutineUniformiv")] public static delegate* unmanaged<uint, uint, uint, uint, int*, void> glGetActiveSubroutineUniformiv;
        [QGLNativeAPI("glGetActiveSubroutineUniformName")] public static delegate* unmanaged<uint, uint, uint, int, int*, char*, void> glGetActiveSubroutineUniformName;
        [QGLNativeAPI("glGetActiveSubroutineName")] public static delegate* unmanaged<uint, uint, uint, int, int*, char*, void> glGetActiveSubroutineName;
        [QGLNativeAPI("glUniformSubroutinesuiv")] public static delegate* unmanaged<uint, int, uint*, void> glUniformSubroutinesuiv;
        [QGLNativeAPI("glGetUniformSubroutineuiv")] public static delegate* unmanaged<uint, int, uint*, void> glGetUniformSubroutineuiv;
        [QGLNativeAPI("glGetProgramStageiv")] public static delegate* unmanaged<uint, uint, uint, int*, void> glGetProgramStageiv;
        [QGLNativeAPI("glPatchParameteri")] public static delegate* unmanaged<uint, int, void> glPatchParameteri;
        [QGLNativeAPI("glPatchParameterfv")] public static delegate* unmanaged<uint, float*, void> glPatchParameterfv;
        [QGLNativeAPI("glBindTransformFeedback")] public static delegate* unmanaged<uint, uint, void> glBindTransformFeedback;
        [QGLNativeAPI("glDeleteTransformFeedbacks")] public static delegate* unmanaged<int, uint*, void> glDeleteTransformFeedbacks;
        [QGLNativeAPI("glGenTransformFeedbacks")] public static delegate* unmanaged<int, uint*, void> glGenTransformFeedbacks;
        [QGLNativeAPI("glIsTransformFeedback")] public static delegate* unmanaged<uint, bool> glIsTransformFeedback;
        [QGLNativeAPI("glPauseTransformFeedback")] public static delegate* unmanaged<void> glPauseTransformFeedback;
        [QGLNativeAPI("glResumeTransformFeedback")] public static delegate* unmanaged<void> glResumeTransformFeedback;
        [QGLNativeAPI("glDrawTransformFeedback")] public static delegate* unmanaged<uint, uint, void> glDrawTransformFeedback;
        [QGLNativeAPI("glDrawTransformFeedbackStream")] public static delegate* unmanaged<uint, uint, uint, void> glDrawTransformFeedbackStream;
        [QGLNativeAPI("glBeginQueryIndexed")] public static delegate* unmanaged<uint, uint, uint, void> glBeginQueryIndexed;
        [QGLNativeAPI("glEndQueryIndexed")] public static delegate* unmanaged<uint, uint, void> glEndQueryIndexed;
        [QGLNativeAPI("glGetQueryIndexediv")] public static delegate* unmanaged<uint, uint, uint, int*, void> glGetQueryIndexediv;
        #endregion
    }
}
