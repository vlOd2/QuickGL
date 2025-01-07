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

// Bindings generated at 2025-01-07 20:24:12.634689
namespace QuickGLNS.Bindings
{
    [GLFeature(false)]
    public static unsafe class GL41
    {
        #region Enums
        public const int GL_FIXED = 0x140C;
        public const int GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        public const int GL_LOW_FLOAT = 0x8DF0;
        public const int GL_MEDIUM_FLOAT = 0x8DF1;
        public const int GL_HIGH_FLOAT = 0x8DF2;
        public const int GL_LOW_INT = 0x8DF3;
        public const int GL_MEDIUM_INT = 0x8DF4;
        public const int GL_HIGH_INT = 0x8DF5;
        public const int GL_SHADER_COMPILER = 0x8DFA;
        public const int GL_SHADER_BINARY_FORMATS = 0x8DF8;
        public const int GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
        public const int GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public const int GL_MAX_VARYING_VECTORS = 0x8DFC;
        public const int GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        public const int GL_RGB565 = 0x8D62;
        public const int GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
        public const int GL_PROGRAM_BINARY_LENGTH = 0x8741;
        public const int GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
        public const int GL_PROGRAM_BINARY_FORMATS = 0x87FF;
        public const int GL_VERTEX_SHADER_BIT = 0x1;
        public const int GL_FRAGMENT_SHADER_BIT = 0x2;
        public const int GL_GEOMETRY_SHADER_BIT = 0x4;
        public const int GL_TESS_CONTROL_SHADER_BIT = 0x8;
        public const int GL_TESS_EVALUATION_SHADER_BIT = 0x10;
        public const uint GL_ALL_SHADER_BITS = 0xFFFFFFFF;
        public const int GL_PROGRAM_SEPARABLE = 0x8258;
        public const int GL_ACTIVE_PROGRAM = 0x8259;
        public const int GL_PROGRAM_PIPELINE_BINDING = 0x825A;
        public const int GL_MAX_VIEWPORTS = 0x825B;
        public const int GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;
        public const int GL_VIEWPORT_BOUNDS_RANGE = 0x825D;
        public const int GL_LAYER_PROVOKING_VERTEX = 0x825E;
        public const int GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
        public const int GL_UNDEFINED_VERTEX = 0x8260;
        #endregion
        
        #region Commands
        public static void glReleaseShaderCompiler() => _glReleaseShaderCompiler();
        [QGLNativeAPI("glReleaseShaderCompiler")] internal static delegate* unmanaged<void> _glReleaseShaderCompiler = null;
        
        public static void glShaderBinary(int count, uint* shaders, uint binaryFormat, void* binary, int length) => _glShaderBinary(count, shaders, binaryFormat, binary, length);
        [QGLNativeAPI("glShaderBinary")] internal static delegate* unmanaged<int, uint*, uint, void*, int, void> _glShaderBinary = null;
        
        public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision) => _glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
        [QGLNativeAPI("glGetShaderPrecisionFormat")] internal static delegate* unmanaged<uint, uint, int*, int*, void> _glGetShaderPrecisionFormat = null;
        
        public static void glDepthRangef(float n, float f) => _glDepthRangef(n, f);
        [QGLNativeAPI("glDepthRangef")] internal static delegate* unmanaged<float, float, void> _glDepthRangef = null;
        
        public static void glClearDepthf(float d) => _glClearDepthf(d);
        [QGLNativeAPI("glClearDepthf")] internal static delegate* unmanaged<float, void> _glClearDepthf = null;
        
        public static void glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary) => _glGetProgramBinary(program, bufSize, length, binaryFormat, binary);
        [QGLNativeAPI("glGetProgramBinary")] internal static delegate* unmanaged<uint, int, int*, uint*, void*, void> _glGetProgramBinary = null;
        
        public static void glProgramBinary(uint program, uint binaryFormat, void* binary, int length) => _glProgramBinary(program, binaryFormat, binary, length);
        [QGLNativeAPI("glProgramBinary")] internal static delegate* unmanaged<uint, uint, void*, int, void> _glProgramBinary = null;
        
        public static void glProgramParameteri(uint program, uint pname, int value) => _glProgramParameteri(program, pname, value);
        [QGLNativeAPI("glProgramParameteri")] internal static delegate* unmanaged<uint, uint, int, void> _glProgramParameteri = null;
        
        public static void glUseProgramStages(uint pipeline, uint stages, uint program) => _glUseProgramStages(pipeline, stages, program);
        [QGLNativeAPI("glUseProgramStages")] internal static delegate* unmanaged<uint, uint, uint, void> _glUseProgramStages = null;
        
        public static void glActiveShaderProgram(uint pipeline, uint program) => _glActiveShaderProgram(pipeline, program);
        [QGLNativeAPI("glActiveShaderProgram")] internal static delegate* unmanaged<uint, uint, void> _glActiveShaderProgram = null;
        
        public static uint glCreateShaderProgramv(uint type, int count, byte** strings) => _glCreateShaderProgramv(type, count, strings);
        [QGLNativeAPI("glCreateShaderProgramv")] internal static delegate* unmanaged<uint, int, byte**, uint> _glCreateShaderProgramv = null;
        
        public static void glBindProgramPipeline(uint pipeline) => _glBindProgramPipeline(pipeline);
        [QGLNativeAPI("glBindProgramPipeline")] internal static delegate* unmanaged<uint, void> _glBindProgramPipeline = null;
        
        public static void glDeleteProgramPipelines(int n, uint* pipelines) => _glDeleteProgramPipelines(n, pipelines);
        [QGLNativeAPI("glDeleteProgramPipelines")] internal static delegate* unmanaged<int, uint*, void> _glDeleteProgramPipelines = null;
        
        public static void glGenProgramPipelines(int n, uint* pipelines) => _glGenProgramPipelines(n, pipelines);
        [QGLNativeAPI("glGenProgramPipelines")] internal static delegate* unmanaged<int, uint*, void> _glGenProgramPipelines = null;
        
        public static bool glIsProgramPipeline(uint pipeline) => _glIsProgramPipeline(pipeline);
        [QGLNativeAPI("glIsProgramPipeline")] internal static delegate* unmanaged<uint, bool> _glIsProgramPipeline = null;
        
        public static void glGetProgramPipelineiv(uint pipeline, uint pname, int* @params) => _glGetProgramPipelineiv(pipeline, pname, @params);
        [QGLNativeAPI("glGetProgramPipelineiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetProgramPipelineiv = null;
        
        public static void glProgramUniform1i(uint program, int location, int v0) => _glProgramUniform1i(program, location, v0);
        [QGLNativeAPI("glProgramUniform1i")] internal static delegate* unmanaged<uint, int, int, void> _glProgramUniform1i = null;
        
        public static void glProgramUniform1iv(uint program, int location, int count, int* value) => _glProgramUniform1iv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform1iv")] internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform1iv = null;
        
        public static void glProgramUniform1f(uint program, int location, float v0) => _glProgramUniform1f(program, location, v0);
        [QGLNativeAPI("glProgramUniform1f")] internal static delegate* unmanaged<uint, int, float, void> _glProgramUniform1f = null;
        
        public static void glProgramUniform1fv(uint program, int location, int count, float* value) => _glProgramUniform1fv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform1fv")] internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform1fv = null;
        
        public static void glProgramUniform1d(uint program, int location, double v0) => _glProgramUniform1d(program, location, v0);
        [QGLNativeAPI("glProgramUniform1d")] internal static delegate* unmanaged<uint, int, double, void> _glProgramUniform1d = null;
        
        public static void glProgramUniform1dv(uint program, int location, int count, double* value) => _glProgramUniform1dv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform1dv")] internal static delegate* unmanaged<uint, int, int, double*, void> _glProgramUniform1dv = null;
        
        public static void glProgramUniform1ui(uint program, int location, uint v0) => _glProgramUniform1ui(program, location, v0);
        [QGLNativeAPI("glProgramUniform1ui")] internal static delegate* unmanaged<uint, int, uint, void> _glProgramUniform1ui = null;
        
        public static void glProgramUniform1uiv(uint program, int location, int count, uint* value) => _glProgramUniform1uiv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform1uiv")] internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform1uiv = null;
        
        public static void glProgramUniform2i(uint program, int location, int v0, int v1) => _glProgramUniform2i(program, location, v0, v1);
        [QGLNativeAPI("glProgramUniform2i")] internal static delegate* unmanaged<uint, int, int, int, void> _glProgramUniform2i = null;
        
        public static void glProgramUniform2iv(uint program, int location, int count, int* value) => _glProgramUniform2iv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform2iv")] internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform2iv = null;
        
        public static void glProgramUniform2f(uint program, int location, float v0, float v1) => _glProgramUniform2f(program, location, v0, v1);
        [QGLNativeAPI("glProgramUniform2f")] internal static delegate* unmanaged<uint, int, float, float, void> _glProgramUniform2f = null;
        
        public static void glProgramUniform2fv(uint program, int location, int count, float* value) => _glProgramUniform2fv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform2fv")] internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform2fv = null;
        
        public static void glProgramUniform2d(uint program, int location, double v0, double v1) => _glProgramUniform2d(program, location, v0, v1);
        [QGLNativeAPI("glProgramUniform2d")] internal static delegate* unmanaged<uint, int, double, double, void> _glProgramUniform2d = null;
        
        public static void glProgramUniform2dv(uint program, int location, int count, double* value) => _glProgramUniform2dv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform2dv")] internal static delegate* unmanaged<uint, int, int, double*, void> _glProgramUniform2dv = null;
        
        public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1) => _glProgramUniform2ui(program, location, v0, v1);
        [QGLNativeAPI("glProgramUniform2ui")] internal static delegate* unmanaged<uint, int, uint, uint, void> _glProgramUniform2ui = null;
        
        public static void glProgramUniform2uiv(uint program, int location, int count, uint* value) => _glProgramUniform2uiv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform2uiv")] internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform2uiv = null;
        
        public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2) => _glProgramUniform3i(program, location, v0, v1, v2);
        [QGLNativeAPI("glProgramUniform3i")] internal static delegate* unmanaged<uint, int, int, int, int, void> _glProgramUniform3i = null;
        
        public static void glProgramUniform3iv(uint program, int location, int count, int* value) => _glProgramUniform3iv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform3iv")] internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform3iv = null;
        
        public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2) => _glProgramUniform3f(program, location, v0, v1, v2);
        [QGLNativeAPI("glProgramUniform3f")] internal static delegate* unmanaged<uint, int, float, float, float, void> _glProgramUniform3f = null;
        
        public static void glProgramUniform3fv(uint program, int location, int count, float* value) => _glProgramUniform3fv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform3fv")] internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform3fv = null;
        
        public static void glProgramUniform3d(uint program, int location, double v0, double v1, double v2) => _glProgramUniform3d(program, location, v0, v1, v2);
        [QGLNativeAPI("glProgramUniform3d")] internal static delegate* unmanaged<uint, int, double, double, double, void> _glProgramUniform3d = null;
        
        public static void glProgramUniform3dv(uint program, int location, int count, double* value) => _glProgramUniform3dv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform3dv")] internal static delegate* unmanaged<uint, int, int, double*, void> _glProgramUniform3dv = null;
        
        public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2) => _glProgramUniform3ui(program, location, v0, v1, v2);
        [QGLNativeAPI("glProgramUniform3ui")] internal static delegate* unmanaged<uint, int, uint, uint, uint, void> _glProgramUniform3ui = null;
        
        public static void glProgramUniform3uiv(uint program, int location, int count, uint* value) => _glProgramUniform3uiv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform3uiv")] internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform3uiv = null;
        
        public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3) => _glProgramUniform4i(program, location, v0, v1, v2, v3);
        [QGLNativeAPI("glProgramUniform4i")] internal static delegate* unmanaged<uint, int, int, int, int, int, void> _glProgramUniform4i = null;
        
        public static void glProgramUniform4iv(uint program, int location, int count, int* value) => _glProgramUniform4iv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform4iv")] internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform4iv = null;
        
        public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3) => _glProgramUniform4f(program, location, v0, v1, v2, v3);
        [QGLNativeAPI("glProgramUniform4f")] internal static delegate* unmanaged<uint, int, float, float, float, float, void> _glProgramUniform4f = null;
        
        public static void glProgramUniform4fv(uint program, int location, int count, float* value) => _glProgramUniform4fv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform4fv")] internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform4fv = null;
        
        public static void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3) => _glProgramUniform4d(program, location, v0, v1, v2, v3);
        [QGLNativeAPI("glProgramUniform4d")] internal static delegate* unmanaged<uint, int, double, double, double, double, void> _glProgramUniform4d = null;
        
        public static void glProgramUniform4dv(uint program, int location, int count, double* value) => _glProgramUniform4dv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform4dv")] internal static delegate* unmanaged<uint, int, int, double*, void> _glProgramUniform4dv = null;
        
        public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3) => _glProgramUniform4ui(program, location, v0, v1, v2, v3);
        [QGLNativeAPI("glProgramUniform4ui")] internal static delegate* unmanaged<uint, int, uint, uint, uint, uint, void> _glProgramUniform4ui = null;
        
        public static void glProgramUniform4uiv(uint program, int location, int count, uint* value) => _glProgramUniform4uiv(program, location, count, value);
        [QGLNativeAPI("glProgramUniform4uiv")] internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform4uiv = null;
        
        public static void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value) => _glProgramUniformMatrix2fv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix2fv")] internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix2fv = null;
        
        public static void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value) => _glProgramUniformMatrix3fv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix3fv")] internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix3fv = null;
        
        public static void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value) => _glProgramUniformMatrix4fv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix4fv")] internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix4fv = null;
        
        public static void glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double* value) => _glProgramUniformMatrix2dv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix2dv")] internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix2dv = null;
        
        public static void glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double* value) => _glProgramUniformMatrix3dv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix3dv")] internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix3dv = null;
        
        public static void glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double* value) => _glProgramUniformMatrix4dv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix4dv")] internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix4dv = null;
        
        public static void glProgramUniformMatrix2x3fv(uint program, int location, int count, bool transpose, float* value) => _glProgramUniformMatrix2x3fv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix2x3fv")] internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix2x3fv = null;
        
        public static void glProgramUniformMatrix3x2fv(uint program, int location, int count, bool transpose, float* value) => _glProgramUniformMatrix3x2fv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix3x2fv")] internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix3x2fv = null;
        
        public static void glProgramUniformMatrix2x4fv(uint program, int location, int count, bool transpose, float* value) => _glProgramUniformMatrix2x4fv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix2x4fv")] internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix2x4fv = null;
        
        public static void glProgramUniformMatrix4x2fv(uint program, int location, int count, bool transpose, float* value) => _glProgramUniformMatrix4x2fv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix4x2fv")] internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix4x2fv = null;
        
        public static void glProgramUniformMatrix3x4fv(uint program, int location, int count, bool transpose, float* value) => _glProgramUniformMatrix3x4fv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix3x4fv")] internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix3x4fv = null;
        
        public static void glProgramUniformMatrix4x3fv(uint program, int location, int count, bool transpose, float* value) => _glProgramUniformMatrix4x3fv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix4x3fv")] internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix4x3fv = null;
        
        public static void glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double* value) => _glProgramUniformMatrix2x3dv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix2x3dv")] internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix2x3dv = null;
        
        public static void glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double* value) => _glProgramUniformMatrix3x2dv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix3x2dv")] internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix3x2dv = null;
        
        public static void glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double* value) => _glProgramUniformMatrix2x4dv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix2x4dv")] internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix2x4dv = null;
        
        public static void glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double* value) => _glProgramUniformMatrix4x2dv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix4x2dv")] internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix4x2dv = null;
        
        public static void glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double* value) => _glProgramUniformMatrix3x4dv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix3x4dv")] internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix3x4dv = null;
        
        public static void glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double* value) => _glProgramUniformMatrix4x3dv(program, location, count, transpose, value);
        [QGLNativeAPI("glProgramUniformMatrix4x3dv")] internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix4x3dv = null;
        
        public static void glValidateProgramPipeline(uint pipeline) => _glValidateProgramPipeline(pipeline);
        [QGLNativeAPI("glValidateProgramPipeline")] internal static delegate* unmanaged<uint, void> _glValidateProgramPipeline = null;
        
        public static void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, byte* infoLog) => _glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
        [QGLNativeAPI("glGetProgramPipelineInfoLog")] internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetProgramPipelineInfoLog = null;
        
        public static void glVertexAttribL1d(uint index, double x) => _glVertexAttribL1d(index, x);
        [QGLNativeAPI("glVertexAttribL1d")] internal static delegate* unmanaged<uint, double, void> _glVertexAttribL1d = null;
        
        public static void glVertexAttribL2d(uint index, double x, double y) => _glVertexAttribL2d(index, x, y);
        [QGLNativeAPI("glVertexAttribL2d")] internal static delegate* unmanaged<uint, double, double, void> _glVertexAttribL2d = null;
        
        public static void glVertexAttribL3d(uint index, double x, double y, double z) => _glVertexAttribL3d(index, x, y, z);
        [QGLNativeAPI("glVertexAttribL3d")] internal static delegate* unmanaged<uint, double, double, double, void> _glVertexAttribL3d = null;
        
        public static void glVertexAttribL4d(uint index, double x, double y, double z, double w) => _glVertexAttribL4d(index, x, y, z, w);
        [QGLNativeAPI("glVertexAttribL4d")] internal static delegate* unmanaged<uint, double, double, double, double, void> _glVertexAttribL4d = null;
        
        public static void glVertexAttribL1dv(uint index, double* v) => _glVertexAttribL1dv(index, v);
        [QGLNativeAPI("glVertexAttribL1dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL1dv = null;
        
        public static void glVertexAttribL2dv(uint index, double* v) => _glVertexAttribL2dv(index, v);
        [QGLNativeAPI("glVertexAttribL2dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL2dv = null;
        
        public static void glVertexAttribL3dv(uint index, double* v) => _glVertexAttribL3dv(index, v);
        [QGLNativeAPI("glVertexAttribL3dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL3dv = null;
        
        public static void glVertexAttribL4dv(uint index, double* v) => _glVertexAttribL4dv(index, v);
        [QGLNativeAPI("glVertexAttribL4dv")] internal static delegate* unmanaged<uint, double*, void> _glVertexAttribL4dv = null;
        
        public static void glVertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer) => _glVertexAttribLPointer(index, size, type, stride, pointer);
        [QGLNativeAPI("glVertexAttribLPointer")] internal static delegate* unmanaged<uint, int, uint, int, void*, void> _glVertexAttribLPointer = null;
        
        public static void glGetVertexAttribLdv(uint index, uint pname, double* @params) => _glGetVertexAttribLdv(index, pname, @params);
        [QGLNativeAPI("glGetVertexAttribLdv")] internal static delegate* unmanaged<uint, uint, double*, void> _glGetVertexAttribLdv = null;
        
        public static void glViewportArrayv(uint first, int count, float* v) => _glViewportArrayv(first, count, v);
        [QGLNativeAPI("glViewportArrayv")] internal static delegate* unmanaged<uint, int, float*, void> _glViewportArrayv = null;
        
        public static void glViewportIndexedf(uint index, float x, float y, float w, float h) => _glViewportIndexedf(index, x, y, w, h);
        [QGLNativeAPI("glViewportIndexedf")] internal static delegate* unmanaged<uint, float, float, float, float, void> _glViewportIndexedf = null;
        
        public static void glViewportIndexedfv(uint index, float* v) => _glViewportIndexedfv(index, v);
        [QGLNativeAPI("glViewportIndexedfv")] internal static delegate* unmanaged<uint, float*, void> _glViewportIndexedfv = null;
        
        public static void glScissorArrayv(uint first, int count, int* v) => _glScissorArrayv(first, count, v);
        [QGLNativeAPI("glScissorArrayv")] internal static delegate* unmanaged<uint, int, int*, void> _glScissorArrayv = null;
        
        public static void glScissorIndexed(uint index, int left, int bottom, int width, int height) => _glScissorIndexed(index, left, bottom, width, height);
        [QGLNativeAPI("glScissorIndexed")] internal static delegate* unmanaged<uint, int, int, int, int, void> _glScissorIndexed = null;
        
        public static void glScissorIndexedv(uint index, int* v) => _glScissorIndexedv(index, v);
        [QGLNativeAPI("glScissorIndexedv")] internal static delegate* unmanaged<uint, int*, void> _glScissorIndexedv = null;
        
        public static void glDepthRangeArrayv(uint first, int count, double* v) => _glDepthRangeArrayv(first, count, v);
        [QGLNativeAPI("glDepthRangeArrayv")] internal static delegate* unmanaged<uint, int, double*, void> _glDepthRangeArrayv = null;
        
        public static void glDepthRangeIndexed(uint index, double n, double f) => _glDepthRangeIndexed(index, n, f);
        [QGLNativeAPI("glDepthRangeIndexed")] internal static delegate* unmanaged<uint, double, double, void> _glDepthRangeIndexed = null;
        
        public static void glGetFloati_v(uint target, uint index, float* data) => _glGetFloati_v(target, index, data);
        [QGLNativeAPI("glGetFloati_v")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetFloati_v = null;
        
        public static void glGetDoublei_v(uint target, uint index, double* data) => _glGetDoublei_v(target, index, data);
        [QGLNativeAPI("glGetDoublei_v")] internal static delegate* unmanaged<uint, uint, double*, void> _glGetDoublei_v = null;
        #endregion
    }
}
