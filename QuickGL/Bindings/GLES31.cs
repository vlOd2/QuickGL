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

// Bindings generated at 2025-09-20 18:58:19.806091
namespace QuickGLNS.Bindings;

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
    public static void glDispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) { QGLFeature.VerifyFunc((nint)_glDispatchCompute); _glDispatchCompute(num_groups_x, num_groups_y, num_groups_z); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glDispatchCompute = null;
    
    public static void glDispatchComputeIndirect(nint indirect) { QGLFeature.VerifyFunc((nint)_glDispatchComputeIndirect); _glDispatchComputeIndirect(indirect); }
    internal static delegate* unmanaged<nint, void> _glDispatchComputeIndirect = null;
    
    public static void glDrawArraysIndirect(uint mode, void* indirect) { QGLFeature.VerifyFunc((nint)_glDrawArraysIndirect); _glDrawArraysIndirect(mode, indirect); }
    internal static delegate* unmanaged<uint, void*, void> _glDrawArraysIndirect = null;
    
    public static void glDrawElementsIndirect(uint mode, uint type, void* indirect) { QGLFeature.VerifyFunc((nint)_glDrawElementsIndirect); _glDrawElementsIndirect(mode, type, indirect); }
    internal static delegate* unmanaged<uint, uint, void*, void> _glDrawElementsIndirect = null;
    
    public static void glFramebufferParameteri(uint target, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glFramebufferParameteri); _glFramebufferParameteri(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glFramebufferParameteri = null;
    
    public static void glGetFramebufferParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetFramebufferParameteriv); _glGetFramebufferParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetFramebufferParameteriv = null;
    
    public static void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetProgramInterfaceiv); _glGetProgramInterfaceiv(program, programInterface, pname, @params); }
    internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetProgramInterfaceiv = null;
    
    public static uint glGetProgramResourceIndex(uint program, uint programInterface, byte* name) { QGLFeature.VerifyFunc((nint)_glGetProgramResourceIndex); return _glGetProgramResourceIndex(program, programInterface, name); }
    internal static delegate* unmanaged<uint, uint, byte*, uint> _glGetProgramResourceIndex = null;
    
    public static void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, byte* name) { QGLFeature.VerifyFunc((nint)_glGetProgramResourceName); _glGetProgramResourceName(program, programInterface, index, bufSize, length, name); }
    internal static delegate* unmanaged<uint, uint, uint, int, int*, byte*, void> _glGetProgramResourceName = null;
    
    public static void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, int* @params) { QGLFeature.VerifyFunc((nint)_glGetProgramResourceiv); _glGetProgramResourceiv(program, programInterface, index, propCount, props, count, length, @params); }
    internal static delegate* unmanaged<uint, uint, uint, int, uint*, int, int*, int*, void> _glGetProgramResourceiv = null;
    
    public static int glGetProgramResourceLocation(uint program, uint programInterface, byte* name) { QGLFeature.VerifyFunc((nint)_glGetProgramResourceLocation); return _glGetProgramResourceLocation(program, programInterface, name); }
    internal static delegate* unmanaged<uint, uint, byte*, int> _glGetProgramResourceLocation = null;
    
    public static void glUseProgramStages(uint pipeline, uint stages, uint program) { QGLFeature.VerifyFunc((nint)_glUseProgramStages); _glUseProgramStages(pipeline, stages, program); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glUseProgramStages = null;
    
    public static void glActiveShaderProgram(uint pipeline, uint program) { QGLFeature.VerifyFunc((nint)_glActiveShaderProgram); _glActiveShaderProgram(pipeline, program); }
    internal static delegate* unmanaged<uint, uint, void> _glActiveShaderProgram = null;
    
    public static uint glCreateShaderProgramv(uint type, int count, byte** strings) { QGLFeature.VerifyFunc((nint)_glCreateShaderProgramv); return _glCreateShaderProgramv(type, count, strings); }
    internal static delegate* unmanaged<uint, int, byte**, uint> _glCreateShaderProgramv = null;
    
    public static void glBindProgramPipeline(uint pipeline) { QGLFeature.VerifyFunc((nint)_glBindProgramPipeline); _glBindProgramPipeline(pipeline); }
    internal static delegate* unmanaged<uint, void> _glBindProgramPipeline = null;
    
    public static void glDeleteProgramPipelines(int n, uint* pipelines) { QGLFeature.VerifyFunc((nint)_glDeleteProgramPipelines); _glDeleteProgramPipelines(n, pipelines); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteProgramPipelines = null;
    
    public static void glGenProgramPipelines(int n, uint* pipelines) { QGLFeature.VerifyFunc((nint)_glGenProgramPipelines); _glGenProgramPipelines(n, pipelines); }
    internal static delegate* unmanaged<int, uint*, void> _glGenProgramPipelines = null;
    
    public static bool glIsProgramPipeline(uint pipeline) { QGLFeature.VerifyFunc((nint)_glIsProgramPipeline); return _glIsProgramPipeline(pipeline); }
    internal static delegate* unmanaged<uint, bool> _glIsProgramPipeline = null;
    
    public static void glGetProgramPipelineiv(uint pipeline, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetProgramPipelineiv); _glGetProgramPipelineiv(pipeline, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetProgramPipelineiv = null;
    
    public static void glProgramUniform1i(uint program, int location, int v0) { QGLFeature.VerifyFunc((nint)_glProgramUniform1i); _glProgramUniform1i(program, location, v0); }
    internal static delegate* unmanaged<uint, int, int, void> _glProgramUniform1i = null;
    
    public static void glProgramUniform2i(uint program, int location, int v0, int v1) { QGLFeature.VerifyFunc((nint)_glProgramUniform2i); _glProgramUniform2i(program, location, v0, v1); }
    internal static delegate* unmanaged<uint, int, int, int, void> _glProgramUniform2i = null;
    
    public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2) { QGLFeature.VerifyFunc((nint)_glProgramUniform3i); _glProgramUniform3i(program, location, v0, v1, v2); }
    internal static delegate* unmanaged<uint, int, int, int, int, void> _glProgramUniform3i = null;
    
    public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3) { QGLFeature.VerifyFunc((nint)_glProgramUniform4i); _glProgramUniform4i(program, location, v0, v1, v2, v3); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, void> _glProgramUniform4i = null;
    
    public static void glProgramUniform1ui(uint program, int location, uint v0) { QGLFeature.VerifyFunc((nint)_glProgramUniform1ui); _glProgramUniform1ui(program, location, v0); }
    internal static delegate* unmanaged<uint, int, uint, void> _glProgramUniform1ui = null;
    
    public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1) { QGLFeature.VerifyFunc((nint)_glProgramUniform2ui); _glProgramUniform2ui(program, location, v0, v1); }
    internal static delegate* unmanaged<uint, int, uint, uint, void> _glProgramUniform2ui = null;
    
    public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2) { QGLFeature.VerifyFunc((nint)_glProgramUniform3ui); _glProgramUniform3ui(program, location, v0, v1, v2); }
    internal static delegate* unmanaged<uint, int, uint, uint, uint, void> _glProgramUniform3ui = null;
    
    public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3) { QGLFeature.VerifyFunc((nint)_glProgramUniform4ui); _glProgramUniform4ui(program, location, v0, v1, v2, v3); }
    internal static delegate* unmanaged<uint, int, uint, uint, uint, uint, void> _glProgramUniform4ui = null;
    
    public static void glProgramUniform1f(uint program, int location, float v0) { QGLFeature.VerifyFunc((nint)_glProgramUniform1f); _glProgramUniform1f(program, location, v0); }
    internal static delegate* unmanaged<uint, int, float, void> _glProgramUniform1f = null;
    
    public static void glProgramUniform2f(uint program, int location, float v0, float v1) { QGLFeature.VerifyFunc((nint)_glProgramUniform2f); _glProgramUniform2f(program, location, v0, v1); }
    internal static delegate* unmanaged<uint, int, float, float, void> _glProgramUniform2f = null;
    
    public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2) { QGLFeature.VerifyFunc((nint)_glProgramUniform3f); _glProgramUniform3f(program, location, v0, v1, v2); }
    internal static delegate* unmanaged<uint, int, float, float, float, void> _glProgramUniform3f = null;
    
    public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3) { QGLFeature.VerifyFunc((nint)_glProgramUniform4f); _glProgramUniform4f(program, location, v0, v1, v2, v3); }
    internal static delegate* unmanaged<uint, int, float, float, float, float, void> _glProgramUniform4f = null;
    
    public static void glProgramUniform1iv(uint program, int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform1iv); _glProgramUniform1iv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform1iv = null;
    
    public static void glProgramUniform2iv(uint program, int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform2iv); _glProgramUniform2iv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform2iv = null;
    
    public static void glProgramUniform3iv(uint program, int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform3iv); _glProgramUniform3iv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform3iv = null;
    
    public static void glProgramUniform4iv(uint program, int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform4iv); _glProgramUniform4iv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform4iv = null;
    
    public static void glProgramUniform1uiv(uint program, int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform1uiv); _glProgramUniform1uiv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform1uiv = null;
    
    public static void glProgramUniform2uiv(uint program, int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform2uiv); _glProgramUniform2uiv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform2uiv = null;
    
    public static void glProgramUniform3uiv(uint program, int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform3uiv); _glProgramUniform3uiv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform3uiv = null;
    
    public static void glProgramUniform4uiv(uint program, int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform4uiv); _glProgramUniform4uiv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform4uiv = null;
    
    public static void glProgramUniform1fv(uint program, int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform1fv); _glProgramUniform1fv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform1fv = null;
    
    public static void glProgramUniform2fv(uint program, int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform2fv); _glProgramUniform2fv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform2fv = null;
    
    public static void glProgramUniform3fv(uint program, int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform3fv); _glProgramUniform3fv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform3fv = null;
    
    public static void glProgramUniform4fv(uint program, int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform4fv); _glProgramUniform4fv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform4fv = null;
    
    public static void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix2fv); _glProgramUniformMatrix2fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix2fv = null;
    
    public static void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix3fv); _glProgramUniformMatrix3fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix3fv = null;
    
    public static void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix4fv); _glProgramUniformMatrix4fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix4fv = null;
    
    public static void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix2x3fv); _glProgramUniformMatrix2x3fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix2x3fv = null;
    
    public static void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix3x2fv); _glProgramUniformMatrix3x2fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix3x2fv = null;
    
    public static void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix2x4fv); _glProgramUniformMatrix2x4fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix2x4fv = null;
    
    public static void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix4x2fv); _glProgramUniformMatrix4x2fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix4x2fv = null;
    
    public static void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix3x4fv); _glProgramUniformMatrix3x4fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix3x4fv = null;
    
    public static void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix4x3fv); _glProgramUniformMatrix4x3fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix4x3fv = null;
    
    public static void glValidateProgramPipeline(uint pipeline) { QGLFeature.VerifyFunc((nint)_glValidateProgramPipeline); _glValidateProgramPipeline(pipeline); }
    internal static delegate* unmanaged<uint, void> _glValidateProgramPipeline = null;
    
    public static void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, byte* infoLog) { QGLFeature.VerifyFunc((nint)_glGetProgramPipelineInfoLog); _glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog); }
    internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetProgramPipelineInfoLog = null;
    
    public static void glBindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format) { QGLFeature.VerifyFunc((nint)_glBindImageTexture); _glBindImageTexture(unit, texture, level, layered, layer, access, format); }
    internal static delegate* unmanaged<uint, uint, int, bool, int, uint, uint, void> _glBindImageTexture = null;
    
    public static void glGetBooleani_v(uint target, uint index, bool* data) { QGLFeature.VerifyFunc((nint)_glGetBooleani_v); _glGetBooleani_v(target, index, data); }
    internal static delegate* unmanaged<uint, uint, bool*, void> _glGetBooleani_v = null;
    
    public static void glMemoryBarrier(uint barriers) { QGLFeature.VerifyFunc((nint)_glMemoryBarrier); _glMemoryBarrier(barriers); }
    internal static delegate* unmanaged<uint, void> _glMemoryBarrier = null;
    
    public static void glMemoryBarrierByRegion(uint barriers) { QGLFeature.VerifyFunc((nint)_glMemoryBarrierByRegion); _glMemoryBarrierByRegion(barriers); }
    internal static delegate* unmanaged<uint, void> _glMemoryBarrierByRegion = null;
    
    public static void glTexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations) { QGLFeature.VerifyFunc((nint)_glTexStorage2DMultisample); _glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations); }
    internal static delegate* unmanaged<uint, int, uint, int, int, bool, void> _glTexStorage2DMultisample = null;
    
    public static void glGetMultisamplefv(uint pname, uint index, float* val) { QGLFeature.VerifyFunc((nint)_glGetMultisamplefv); _glGetMultisamplefv(pname, index, val); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetMultisamplefv = null;
    
    public static void glSampleMaski(uint maskNumber, uint mask) { QGLFeature.VerifyFunc((nint)_glSampleMaski); _glSampleMaski(maskNumber, mask); }
    internal static delegate* unmanaged<uint, uint, void> _glSampleMaski = null;
    
    public static void glGetTexLevelParameteriv(uint target, int level, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetTexLevelParameteriv); _glGetTexLevelParameteriv(target, level, pname, @params); }
    internal static delegate* unmanaged<uint, int, uint, int*, void> _glGetTexLevelParameteriv = null;
    
    public static void glGetTexLevelParameterfv(uint target, int level, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetTexLevelParameterfv); _glGetTexLevelParameterfv(target, level, pname, @params); }
    internal static delegate* unmanaged<uint, int, uint, float*, void> _glGetTexLevelParameterfv = null;
    
    public static void glBindVertexBuffer(uint bindingindex, uint buffer, nint offset, int stride) { QGLFeature.VerifyFunc((nint)_glBindVertexBuffer); _glBindVertexBuffer(bindingindex, buffer, offset, stride); }
    internal static delegate* unmanaged<uint, uint, nint, int, void> _glBindVertexBuffer = null;
    
    public static void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset) { QGLFeature.VerifyFunc((nint)_glVertexAttribFormat); _glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset); }
    internal static delegate* unmanaged<uint, int, uint, bool, uint, void> _glVertexAttribFormat = null;
    
    public static void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset) { QGLFeature.VerifyFunc((nint)_glVertexAttribIFormat); _glVertexAttribIFormat(attribindex, size, type, relativeoffset); }
    internal static delegate* unmanaged<uint, int, uint, uint, void> _glVertexAttribIFormat = null;
    
    public static void glVertexAttribBinding(uint attribindex, uint bindingindex) { QGLFeature.VerifyFunc((nint)_glVertexAttribBinding); _glVertexAttribBinding(attribindex, bindingindex); }
    internal static delegate* unmanaged<uint, uint, void> _glVertexAttribBinding = null;
    
    public static void glVertexBindingDivisor(uint bindingindex, uint divisor) { QGLFeature.VerifyFunc((nint)_glVertexBindingDivisor); _glVertexBindingDivisor(bindingindex, divisor); }
    internal static delegate* unmanaged<uint, uint, void> _glVertexBindingDivisor = null;
     #endregion
    
    internal static void Load()
    {
        _glDispatchCompute = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glDispatchCompute");
        _glDispatchComputeIndirect = (delegate* unmanaged<nint, void>)QuickGL.GetGLProcAddress("glDispatchComputeIndirect");
        _glDrawArraysIndirect = (delegate* unmanaged<uint, void*, void>)QuickGL.GetGLProcAddress("glDrawArraysIndirect");
        _glDrawElementsIndirect = (delegate* unmanaged<uint, uint, void*, void>)QuickGL.GetGLProcAddress("glDrawElementsIndirect");
        _glFramebufferParameteri = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glFramebufferParameteri");
        _glGetFramebufferParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetFramebufferParameteriv");
        _glGetProgramInterfaceiv = (delegate* unmanaged<uint, uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetProgramInterfaceiv");
        _glGetProgramResourceIndex = (delegate* unmanaged<uint, uint, byte*, uint>)QuickGL.GetGLProcAddress("glGetProgramResourceIndex");
        _glGetProgramResourceName = (delegate* unmanaged<uint, uint, uint, int, int*, byte*, void>)QuickGL.GetGLProcAddress("glGetProgramResourceName");
        _glGetProgramResourceiv = (delegate* unmanaged<uint, uint, uint, int, uint*, int, int*, int*, void>)QuickGL.GetGLProcAddress("glGetProgramResourceiv");
        _glGetProgramResourceLocation = (delegate* unmanaged<uint, uint, byte*, int>)QuickGL.GetGLProcAddress("glGetProgramResourceLocation");
        _glUseProgramStages = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glUseProgramStages");
        _glActiveShaderProgram = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glActiveShaderProgram");
        _glCreateShaderProgramv = (delegate* unmanaged<uint, int, byte**, uint>)QuickGL.GetGLProcAddress("glCreateShaderProgramv");
        _glBindProgramPipeline = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glBindProgramPipeline");
        _glDeleteProgramPipelines = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteProgramPipelines");
        _glGenProgramPipelines = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenProgramPipelines");
        _glIsProgramPipeline = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsProgramPipeline");
        _glGetProgramPipelineiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetProgramPipelineiv");
        _glProgramUniform1i = (delegate* unmanaged<uint, int, int, void>)QuickGL.GetGLProcAddress("glProgramUniform1i");
        _glProgramUniform2i = (delegate* unmanaged<uint, int, int, int, void>)QuickGL.GetGLProcAddress("glProgramUniform2i");
        _glProgramUniform3i = (delegate* unmanaged<uint, int, int, int, int, void>)QuickGL.GetGLProcAddress("glProgramUniform3i");
        _glProgramUniform4i = (delegate* unmanaged<uint, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glProgramUniform4i");
        _glProgramUniform1ui = (delegate* unmanaged<uint, int, uint, void>)QuickGL.GetGLProcAddress("glProgramUniform1ui");
        _glProgramUniform2ui = (delegate* unmanaged<uint, int, uint, uint, void>)QuickGL.GetGLProcAddress("glProgramUniform2ui");
        _glProgramUniform3ui = (delegate* unmanaged<uint, int, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glProgramUniform3ui");
        _glProgramUniform4ui = (delegate* unmanaged<uint, int, uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glProgramUniform4ui");
        _glProgramUniform1f = (delegate* unmanaged<uint, int, float, void>)QuickGL.GetGLProcAddress("glProgramUniform1f");
        _glProgramUniform2f = (delegate* unmanaged<uint, int, float, float, void>)QuickGL.GetGLProcAddress("glProgramUniform2f");
        _glProgramUniform3f = (delegate* unmanaged<uint, int, float, float, float, void>)QuickGL.GetGLProcAddress("glProgramUniform3f");
        _glProgramUniform4f = (delegate* unmanaged<uint, int, float, float, float, float, void>)QuickGL.GetGLProcAddress("glProgramUniform4f");
        _glProgramUniform1iv = (delegate* unmanaged<uint, int, int, int*, void>)QuickGL.GetGLProcAddress("glProgramUniform1iv");
        _glProgramUniform2iv = (delegate* unmanaged<uint, int, int, int*, void>)QuickGL.GetGLProcAddress("glProgramUniform2iv");
        _glProgramUniform3iv = (delegate* unmanaged<uint, int, int, int*, void>)QuickGL.GetGLProcAddress("glProgramUniform3iv");
        _glProgramUniform4iv = (delegate* unmanaged<uint, int, int, int*, void>)QuickGL.GetGLProcAddress("glProgramUniform4iv");
        _glProgramUniform1uiv = (delegate* unmanaged<uint, int, int, uint*, void>)QuickGL.GetGLProcAddress("glProgramUniform1uiv");
        _glProgramUniform2uiv = (delegate* unmanaged<uint, int, int, uint*, void>)QuickGL.GetGLProcAddress("glProgramUniform2uiv");
        _glProgramUniform3uiv = (delegate* unmanaged<uint, int, int, uint*, void>)QuickGL.GetGLProcAddress("glProgramUniform3uiv");
        _glProgramUniform4uiv = (delegate* unmanaged<uint, int, int, uint*, void>)QuickGL.GetGLProcAddress("glProgramUniform4uiv");
        _glProgramUniform1fv = (delegate* unmanaged<uint, int, int, float*, void>)QuickGL.GetGLProcAddress("glProgramUniform1fv");
        _glProgramUniform2fv = (delegate* unmanaged<uint, int, int, float*, void>)QuickGL.GetGLProcAddress("glProgramUniform2fv");
        _glProgramUniform3fv = (delegate* unmanaged<uint, int, int, float*, void>)QuickGL.GetGLProcAddress("glProgramUniform3fv");
        _glProgramUniform4fv = (delegate* unmanaged<uint, int, int, float*, void>)QuickGL.GetGLProcAddress("glProgramUniform4fv");
        _glProgramUniformMatrix2fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix2fv");
        _glProgramUniformMatrix3fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix3fv");
        _glProgramUniformMatrix4fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix4fv");
        _glProgramUniformMatrix2x3fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix2x3fv");
        _glProgramUniformMatrix3x2fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix3x2fv");
        _glProgramUniformMatrix2x4fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix2x4fv");
        _glProgramUniformMatrix4x2fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix4x2fv");
        _glProgramUniformMatrix3x4fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix3x4fv");
        _glProgramUniformMatrix4x3fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix4x3fv");
        _glValidateProgramPipeline = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glValidateProgramPipeline");
        _glGetProgramPipelineInfoLog = (delegate* unmanaged<uint, int, int*, byte*, void>)QuickGL.GetGLProcAddress("glGetProgramPipelineInfoLog");
        _glBindImageTexture = (delegate* unmanaged<uint, uint, int, bool, int, uint, uint, void>)QuickGL.GetGLProcAddress("glBindImageTexture");
        _glGetBooleani_v = (delegate* unmanaged<uint, uint, bool*, void>)QuickGL.GetGLProcAddress("glGetBooleani_v");
        _glMemoryBarrier = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glMemoryBarrier");
        _glMemoryBarrierByRegion = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glMemoryBarrierByRegion");
        _glTexStorage2DMultisample = (delegate* unmanaged<uint, int, uint, int, int, bool, void>)QuickGL.GetGLProcAddress("glTexStorage2DMultisample");
        _glGetMultisamplefv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetMultisamplefv");
        _glSampleMaski = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glSampleMaski");
        _glGetTexLevelParameteriv = (delegate* unmanaged<uint, int, uint, int*, void>)QuickGL.GetGLProcAddress("glGetTexLevelParameteriv");
        _glGetTexLevelParameterfv = (delegate* unmanaged<uint, int, uint, float*, void>)QuickGL.GetGLProcAddress("glGetTexLevelParameterfv");
        _glBindVertexBuffer = (delegate* unmanaged<uint, uint, nint, int, void>)QuickGL.GetGLProcAddress("glBindVertexBuffer");
        _glVertexAttribFormat = (delegate* unmanaged<uint, int, uint, bool, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribFormat");
        _glVertexAttribIFormat = (delegate* unmanaged<uint, int, uint, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribIFormat");
        _glVertexAttribBinding = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribBinding");
        _glVertexBindingDivisor = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glVertexBindingDivisor");
    }
    
    internal static void Unload()
    {
        _glDispatchCompute = null;
        _glDispatchComputeIndirect = null;
        _glDrawArraysIndirect = null;
        _glDrawElementsIndirect = null;
        _glFramebufferParameteri = null;
        _glGetFramebufferParameteriv = null;
        _glGetProgramInterfaceiv = null;
        _glGetProgramResourceIndex = null;
        _glGetProgramResourceName = null;
        _glGetProgramResourceiv = null;
        _glGetProgramResourceLocation = null;
        _glUseProgramStages = null;
        _glActiveShaderProgram = null;
        _glCreateShaderProgramv = null;
        _glBindProgramPipeline = null;
        _glDeleteProgramPipelines = null;
        _glGenProgramPipelines = null;
        _glIsProgramPipeline = null;
        _glGetProgramPipelineiv = null;
        _glProgramUniform1i = null;
        _glProgramUniform2i = null;
        _glProgramUniform3i = null;
        _glProgramUniform4i = null;
        _glProgramUniform1ui = null;
        _glProgramUniform2ui = null;
        _glProgramUniform3ui = null;
        _glProgramUniform4ui = null;
        _glProgramUniform1f = null;
        _glProgramUniform2f = null;
        _glProgramUniform3f = null;
        _glProgramUniform4f = null;
        _glProgramUniform1iv = null;
        _glProgramUniform2iv = null;
        _glProgramUniform3iv = null;
        _glProgramUniform4iv = null;
        _glProgramUniform1uiv = null;
        _glProgramUniform2uiv = null;
        _glProgramUniform3uiv = null;
        _glProgramUniform4uiv = null;
        _glProgramUniform1fv = null;
        _glProgramUniform2fv = null;
        _glProgramUniform3fv = null;
        _glProgramUniform4fv = null;
        _glProgramUniformMatrix2fv = null;
        _glProgramUniformMatrix3fv = null;
        _glProgramUniformMatrix4fv = null;
        _glProgramUniformMatrix2x3fv = null;
        _glProgramUniformMatrix3x2fv = null;
        _glProgramUniformMatrix2x4fv = null;
        _glProgramUniformMatrix4x2fv = null;
        _glProgramUniformMatrix3x4fv = null;
        _glProgramUniformMatrix4x3fv = null;
        _glValidateProgramPipeline = null;
        _glGetProgramPipelineInfoLog = null;
        _glBindImageTexture = null;
        _glGetBooleani_v = null;
        _glMemoryBarrier = null;
        _glMemoryBarrierByRegion = null;
        _glTexStorage2DMultisample = null;
        _glGetMultisamplefv = null;
        _glSampleMaski = null;
        _glGetTexLevelParameteriv = null;
        _glGetTexLevelParameterfv = null;
        _glBindVertexBuffer = null;
        _glVertexAttribFormat = null;
        _glVertexAttribIFormat = null;
        _glVertexAttribBinding = null;
        _glVertexBindingDivisor = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ES_VERSION_3_1", false, true);
}
