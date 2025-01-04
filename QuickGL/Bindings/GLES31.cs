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

// Bindings generated at 2025-01-04 19:06:28.381053
namespace QuickGLNS.Bindings
{
    [GLFeature]
    public static unsafe class GLES31
    {
        #region Enums
        public const int GL_COMPUTE_SHADER = 0x91B9;
        public const int GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
        public const int GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
        public const int GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
        public const int GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
        public const int GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
        public const int GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
        public const int GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
        public const int GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
        public const int GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
        public const int GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
        public const int GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
        public const int GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
        public const int GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
        public const int GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
        public const int GL_COMPUTE_SHADER_BIT = 0x20;
        public const int GL_DRAW_INDIRECT_BUFFER = 0x8F3F;
        public const int GL_DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
        public const int GL_MAX_UNIFORM_LOCATIONS = 0x826E;
        public const int GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
        public const int GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
        public const int GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
        public const int GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
        public const int GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
        public const int GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
        public const int GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
        public const int GL_UNIFORM = 0x92E1;
        public const int GL_UNIFORM_BLOCK = 0x92E2;
        public const int GL_PROGRAM_INPUT = 0x92E3;
        public const int GL_PROGRAM_OUTPUT = 0x92E4;
        public const int GL_BUFFER_VARIABLE = 0x92E5;
        public const int GL_SHADER_STORAGE_BLOCK = 0x92E6;
        public const int GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
        public const int GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
        public const int GL_ACTIVE_RESOURCES = 0x92F5;
        public const int GL_MAX_NAME_LENGTH = 0x92F6;
        public const int GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
        public const int GL_NAME_LENGTH = 0x92F9;
        public const int GL_TYPE = 0x92FA;
        public const int GL_ARRAY_SIZE = 0x92FB;
        public const int GL_OFFSET = 0x92FC;
        public const int GL_BLOCK_INDEX = 0x92FD;
        public const int GL_ARRAY_STRIDE = 0x92FE;
        public const int GL_MATRIX_STRIDE = 0x92FF;
        public const int GL_IS_ROW_MAJOR = 0x9300;
        public const int GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
        public const int GL_BUFFER_BINDING = 0x9302;
        public const int GL_BUFFER_DATA_SIZE = 0x9303;
        public const int GL_NUM_ACTIVE_VARIABLES = 0x9304;
        public const int GL_ACTIVE_VARIABLES = 0x9305;
        public const int GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;
        public const int GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
        public const int GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
        public const int GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
        public const int GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
        public const int GL_LOCATION = 0x930E;
        public const int GL_VERTEX_SHADER_BIT = 0x1;
        public const int GL_FRAGMENT_SHADER_BIT = 0x2;
        public const uint GL_ALL_SHADER_BITS = 0xFFFFFFFF;
        public const int GL_PROGRAM_SEPARABLE = 0x8258;
        public const int GL_ACTIVE_PROGRAM = 0x8259;
        public const int GL_PROGRAM_PIPELINE_BINDING = 0x825A;
        public const int GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
        public const int GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;
        public const int GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
        public const int GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
        public const int GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
        public const int GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
        public const int GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
        public const int GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
        public const int GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
        public const int GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
        public const int GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
        public const int GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
        public const int GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
        public const int GL_MAX_IMAGE_UNITS = 0x8F38;
        public const int GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
        public const int GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
        public const int GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
        public const int GL_IMAGE_BINDING_NAME = 0x8F3A;
        public const int GL_IMAGE_BINDING_LEVEL = 0x8F3B;
        public const int GL_IMAGE_BINDING_LAYERED = 0x8F3C;
        public const int GL_IMAGE_BINDING_LAYER = 0x8F3D;
        public const int GL_IMAGE_BINDING_ACCESS = 0x8F3E;
        public const int GL_IMAGE_BINDING_FORMAT = 0x906E;
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
        public const int GL_IMAGE_2D = 0x904D;
        public const int GL_IMAGE_3D = 0x904E;
        public const int GL_IMAGE_CUBE = 0x9050;
        public const int GL_IMAGE_2D_ARRAY = 0x9053;
        public const int GL_INT_IMAGE_2D = 0x9058;
        public const int GL_INT_IMAGE_3D = 0x9059;
        public const int GL_INT_IMAGE_CUBE = 0x905B;
        public const int GL_INT_IMAGE_2D_ARRAY = 0x905E;
        public const int GL_UNSIGNED_INT_IMAGE_2D = 0x9063;
        public const int GL_UNSIGNED_INT_IMAGE_3D = 0x9064;
        public const int GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;
        public const int GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
        public const int GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
        public const int GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
        public const int GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
        public const int GL_READ_ONLY = 0x88B8;
        public const int GL_WRITE_ONLY = 0x88B9;
        public const int GL_READ_WRITE = 0x88BA;
        public const int GL_SHADER_STORAGE_BUFFER = 0x90D2;
        public const int GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
        public const int GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
        public const int GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
        public const int GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
        public const int GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
        public const int GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
        public const int GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
        public const int GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
        public const int GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
        public const int GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
        public const int GL_SHADER_STORAGE_BARRIER_BIT = 0x2000;
        public const int GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
        public const int GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
        public const int GL_STENCIL_INDEX = 0x1901;
        public const int GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
        public const int GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
        public const int GL_SAMPLE_POSITION = 0x8E50;
        public const int GL_SAMPLE_MASK = 0x8E51;
        public const int GL_SAMPLE_MASK_VALUE = 0x8E52;
        public const int GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
        public const int GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
        public const int GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
        public const int GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
        public const int GL_MAX_INTEGER_SAMPLES = 0x9110;
        public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
        public const int GL_TEXTURE_SAMPLES = 0x9106;
        public const int GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
        public const int GL_TEXTURE_WIDTH = 0x1000;
        public const int GL_TEXTURE_HEIGHT = 0x1001;
        public const int GL_TEXTURE_DEPTH = 0x8071;
        public const int GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
        public const int GL_TEXTURE_RED_SIZE = 0x805C;
        public const int GL_TEXTURE_GREEN_SIZE = 0x805D;
        public const int GL_TEXTURE_BLUE_SIZE = 0x805E;
        public const int GL_TEXTURE_ALPHA_SIZE = 0x805F;
        public const int GL_TEXTURE_DEPTH_SIZE = 0x884A;
        public const int GL_TEXTURE_STENCIL_SIZE = 0x88F1;
        public const int GL_TEXTURE_SHARED_SIZE = 0x8C3F;
        public const int GL_TEXTURE_RED_TYPE = 0x8C10;
        public const int GL_TEXTURE_GREEN_TYPE = 0x8C11;
        public const int GL_TEXTURE_BLUE_TYPE = 0x8C12;
        public const int GL_TEXTURE_ALPHA_TYPE = 0x8C13;
        public const int GL_TEXTURE_DEPTH_TYPE = 0x8C16;
        public const int GL_TEXTURE_COMPRESSED = 0x86A1;
        public const int GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
        public const int GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
        public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
        public const int GL_VERTEX_ATTRIB_BINDING = 0x82D4;
        public const int GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
        public const int GL_VERTEX_BINDING_DIVISOR = 0x82D6;
        public const int GL_VERTEX_BINDING_OFFSET = 0x82D7;
        public const int GL_VERTEX_BINDING_STRIDE = 0x82D8;
        public const int GL_VERTEX_BINDING_BUFFER = 0x8F4F;
        public const int GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
        public const int GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
        public const int GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
        #endregion
        
        #region Commands
        [QGLNativeAPI("glDispatchCompute")] public static delegate* unmanaged<uint, uint, uint, void> glDispatchCompute;
        [QGLNativeAPI("glDispatchComputeIndirect")] public static delegate* unmanaged<nint, void> glDispatchComputeIndirect;
        [QGLNativeAPI("glDrawArraysIndirect")] public static delegate* unmanaged<uint, void*, void> glDrawArraysIndirect;
        [QGLNativeAPI("glDrawElementsIndirect")] public static delegate* unmanaged<uint, uint, void*, void> glDrawElementsIndirect;
        [QGLNativeAPI("glFramebufferParameteri")] public static delegate* unmanaged<uint, uint, int, void> glFramebufferParameteri;
        [QGLNativeAPI("glGetFramebufferParameteriv")] public static delegate* unmanaged<uint, uint, int*, void> glGetFramebufferParameteriv;
        [QGLNativeAPI("glGetProgramInterfaceiv")] public static delegate* unmanaged<uint, uint, uint, int*, void> glGetProgramInterfaceiv;
        [QGLNativeAPI("glGetProgramResourceIndex")] public static delegate* unmanaged<uint, uint, byte*, uint> glGetProgramResourceIndex;
        [QGLNativeAPI("glGetProgramResourceName")] public static delegate* unmanaged<uint, uint, uint, int, int*, byte*, void> glGetProgramResourceName;
        [QGLNativeAPI("glGetProgramResourceiv")] public static delegate* unmanaged<uint, uint, uint, int, uint*, int, int*, int*, void> glGetProgramResourceiv;
        [QGLNativeAPI("glGetProgramResourceLocation")] public static delegate* unmanaged<uint, uint, byte*, int> glGetProgramResourceLocation;
        [QGLNativeAPI("glUseProgramStages")] public static delegate* unmanaged<uint, uint, uint, void> glUseProgramStages;
        [QGLNativeAPI("glActiveShaderProgram")] public static delegate* unmanaged<uint, uint, void> glActiveShaderProgram;
        [QGLNativeAPI("glCreateShaderProgramv")] public static delegate* unmanaged<uint, int, byte**, uint> glCreateShaderProgramv;
        [QGLNativeAPI("glBindProgramPipeline")] public static delegate* unmanaged<uint, void> glBindProgramPipeline;
        [QGLNativeAPI("glDeleteProgramPipelines")] public static delegate* unmanaged<int, uint*, void> glDeleteProgramPipelines;
        [QGLNativeAPI("glGenProgramPipelines")] public static delegate* unmanaged<int, uint*, void> glGenProgramPipelines;
        [QGLNativeAPI("glIsProgramPipeline")] public static delegate* unmanaged<uint, bool> glIsProgramPipeline;
        [QGLNativeAPI("glGetProgramPipelineiv")] public static delegate* unmanaged<uint, uint, int*, void> glGetProgramPipelineiv;
        [QGLNativeAPI("glProgramUniform1i")] public static delegate* unmanaged<uint, int, int, void> glProgramUniform1i;
        [QGLNativeAPI("glProgramUniform2i")] public static delegate* unmanaged<uint, int, int, int, void> glProgramUniform2i;
        [QGLNativeAPI("glProgramUniform3i")] public static delegate* unmanaged<uint, int, int, int, int, void> glProgramUniform3i;
        [QGLNativeAPI("glProgramUniform4i")] public static delegate* unmanaged<uint, int, int, int, int, int, void> glProgramUniform4i;
        [QGLNativeAPI("glProgramUniform1ui")] public static delegate* unmanaged<uint, int, uint, void> glProgramUniform1ui;
        [QGLNativeAPI("glProgramUniform2ui")] public static delegate* unmanaged<uint, int, uint, uint, void> glProgramUniform2ui;
        [QGLNativeAPI("glProgramUniform3ui")] public static delegate* unmanaged<uint, int, uint, uint, uint, void> glProgramUniform3ui;
        [QGLNativeAPI("glProgramUniform4ui")] public static delegate* unmanaged<uint, int, uint, uint, uint, uint, void> glProgramUniform4ui;
        [QGLNativeAPI("glProgramUniform1f")] public static delegate* unmanaged<uint, int, float, void> glProgramUniform1f;
        [QGLNativeAPI("glProgramUniform2f")] public static delegate* unmanaged<uint, int, float, float, void> glProgramUniform2f;
        [QGLNativeAPI("glProgramUniform3f")] public static delegate* unmanaged<uint, int, float, float, float, void> glProgramUniform3f;
        [QGLNativeAPI("glProgramUniform4f")] public static delegate* unmanaged<uint, int, float, float, float, float, void> glProgramUniform4f;
        [QGLNativeAPI("glProgramUniform1iv")] public static delegate* unmanaged<uint, int, int, int*, void> glProgramUniform1iv;
        [QGLNativeAPI("glProgramUniform2iv")] public static delegate* unmanaged<uint, int, int, int*, void> glProgramUniform2iv;
        [QGLNativeAPI("glProgramUniform3iv")] public static delegate* unmanaged<uint, int, int, int*, void> glProgramUniform3iv;
        [QGLNativeAPI("glProgramUniform4iv")] public static delegate* unmanaged<uint, int, int, int*, void> glProgramUniform4iv;
        [QGLNativeAPI("glProgramUniform1uiv")] public static delegate* unmanaged<uint, int, int, uint*, void> glProgramUniform1uiv;
        [QGLNativeAPI("glProgramUniform2uiv")] public static delegate* unmanaged<uint, int, int, uint*, void> glProgramUniform2uiv;
        [QGLNativeAPI("glProgramUniform3uiv")] public static delegate* unmanaged<uint, int, int, uint*, void> glProgramUniform3uiv;
        [QGLNativeAPI("glProgramUniform4uiv")] public static delegate* unmanaged<uint, int, int, uint*, void> glProgramUniform4uiv;
        [QGLNativeAPI("glProgramUniform1fv")] public static delegate* unmanaged<uint, int, int, float*, void> glProgramUniform1fv;
        [QGLNativeAPI("glProgramUniform2fv")] public static delegate* unmanaged<uint, int, int, float*, void> glProgramUniform2fv;
        [QGLNativeAPI("glProgramUniform3fv")] public static delegate* unmanaged<uint, int, int, float*, void> glProgramUniform3fv;
        [QGLNativeAPI("glProgramUniform4fv")] public static delegate* unmanaged<uint, int, int, float*, void> glProgramUniform4fv;
        [QGLNativeAPI("glProgramUniformMatrix2fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix2fv;
        [QGLNativeAPI("glProgramUniformMatrix3fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix3fv;
        [QGLNativeAPI("glProgramUniformMatrix4fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix4fv;
        [QGLNativeAPI("glProgramUniformMatrix2x3fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix2x3fv;
        [QGLNativeAPI("glProgramUniformMatrix3x2fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix3x2fv;
        [QGLNativeAPI("glProgramUniformMatrix2x4fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix2x4fv;
        [QGLNativeAPI("glProgramUniformMatrix4x2fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix4x2fv;
        [QGLNativeAPI("glProgramUniformMatrix3x4fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix3x4fv;
        [QGLNativeAPI("glProgramUniformMatrix4x3fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix4x3fv;
        [QGLNativeAPI("glValidateProgramPipeline")] public static delegate* unmanaged<uint, void> glValidateProgramPipeline;
        [QGLNativeAPI("glGetProgramPipelineInfoLog")] public static delegate* unmanaged<uint, int, int*, byte*, void> glGetProgramPipelineInfoLog;
        [QGLNativeAPI("glBindImageTexture")] public static delegate* unmanaged<uint, uint, int, bool, int, uint, uint, void> glBindImageTexture;
        [QGLNativeAPI("glGetBooleani_v")] public static delegate* unmanaged<uint, uint, bool*, void> glGetBooleani_v;
        [QGLNativeAPI("glMemoryBarrier")] public static delegate* unmanaged<uint, void> glMemoryBarrier;
        [QGLNativeAPI("glMemoryBarrierByRegion")] public static delegate* unmanaged<uint, void> glMemoryBarrierByRegion;
        [QGLNativeAPI("glTexStorage2DMultisample")] public static delegate* unmanaged<uint, int, uint, int, int, bool, void> glTexStorage2DMultisample;
        [QGLNativeAPI("glGetMultisamplefv")] public static delegate* unmanaged<uint, uint, float*, void> glGetMultisamplefv;
        [QGLNativeAPI("glSampleMaski")] public static delegate* unmanaged<uint, uint, void> glSampleMaski;
        [QGLNativeAPI("glGetTexLevelParameteriv")] public static delegate* unmanaged<uint, int, uint, int*, void> glGetTexLevelParameteriv;
        [QGLNativeAPI("glGetTexLevelParameterfv")] public static delegate* unmanaged<uint, int, uint, float*, void> glGetTexLevelParameterfv;
        [QGLNativeAPI("glBindVertexBuffer")] public static delegate* unmanaged<uint, uint, nint, int, void> glBindVertexBuffer;
        [QGLNativeAPI("glVertexAttribFormat")] public static delegate* unmanaged<uint, int, uint, bool, uint, void> glVertexAttribFormat;
        [QGLNativeAPI("glVertexAttribIFormat")] public static delegate* unmanaged<uint, int, uint, uint, void> glVertexAttribIFormat;
        [QGLNativeAPI("glVertexAttribBinding")] public static delegate* unmanaged<uint, uint, void> glVertexAttribBinding;
        [QGLNativeAPI("glVertexBindingDivisor")] public static delegate* unmanaged<uint, uint, void> glVertexBindingDivisor;
        #endregion
    }
}
