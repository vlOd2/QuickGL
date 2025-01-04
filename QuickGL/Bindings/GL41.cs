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

// Bindings generated at 2025-01-04 19:06:28.374122
namespace QuickGLNS.Bindings
{
    [GLFeature]
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
        [QGLNativeAPI("glReleaseShaderCompiler")] public static delegate* unmanaged<void> glReleaseShaderCompiler;
        [QGLNativeAPI("glShaderBinary")] public static delegate* unmanaged<int, uint*, uint, void*, int, void> glShaderBinary;
        [QGLNativeAPI("glGetShaderPrecisionFormat")] public static delegate* unmanaged<uint, uint, int*, int*, void> glGetShaderPrecisionFormat;
        [QGLNativeAPI("glDepthRangef")] public static delegate* unmanaged<float, float, void> glDepthRangef;
        [QGLNativeAPI("glClearDepthf")] public static delegate* unmanaged<float, void> glClearDepthf;
        [QGLNativeAPI("glGetProgramBinary")] public static delegate* unmanaged<uint, int, int*, uint*, void*, void> glGetProgramBinary;
        [QGLNativeAPI("glProgramBinary")] public static delegate* unmanaged<uint, uint, void*, int, void> glProgramBinary;
        [QGLNativeAPI("glProgramParameteri")] public static delegate* unmanaged<uint, uint, int, void> glProgramParameteri;
        [QGLNativeAPI("glUseProgramStages")] public static delegate* unmanaged<uint, uint, uint, void> glUseProgramStages;
        [QGLNativeAPI("glActiveShaderProgram")] public static delegate* unmanaged<uint, uint, void> glActiveShaderProgram;
        [QGLNativeAPI("glCreateShaderProgramv")] public static delegate* unmanaged<uint, int, byte**, uint> glCreateShaderProgramv;
        [QGLNativeAPI("glBindProgramPipeline")] public static delegate* unmanaged<uint, void> glBindProgramPipeline;
        [QGLNativeAPI("glDeleteProgramPipelines")] public static delegate* unmanaged<int, uint*, void> glDeleteProgramPipelines;
        [QGLNativeAPI("glGenProgramPipelines")] public static delegate* unmanaged<int, uint*, void> glGenProgramPipelines;
        [QGLNativeAPI("glIsProgramPipeline")] public static delegate* unmanaged<uint, bool> glIsProgramPipeline;
        [QGLNativeAPI("glGetProgramPipelineiv")] public static delegate* unmanaged<uint, uint, int*, void> glGetProgramPipelineiv;
        [QGLNativeAPI("glProgramUniform1i")] public static delegate* unmanaged<uint, int, int, void> glProgramUniform1i;
        [QGLNativeAPI("glProgramUniform1iv")] public static delegate* unmanaged<uint, int, int, int*, void> glProgramUniform1iv;
        [QGLNativeAPI("glProgramUniform1f")] public static delegate* unmanaged<uint, int, float, void> glProgramUniform1f;
        [QGLNativeAPI("glProgramUniform1fv")] public static delegate* unmanaged<uint, int, int, float*, void> glProgramUniform1fv;
        [QGLNativeAPI("glProgramUniform1d")] public static delegate* unmanaged<uint, int, double, void> glProgramUniform1d;
        [QGLNativeAPI("glProgramUniform1dv")] public static delegate* unmanaged<uint, int, int, double*, void> glProgramUniform1dv;
        [QGLNativeAPI("glProgramUniform1ui")] public static delegate* unmanaged<uint, int, uint, void> glProgramUniform1ui;
        [QGLNativeAPI("glProgramUniform1uiv")] public static delegate* unmanaged<uint, int, int, uint*, void> glProgramUniform1uiv;
        [QGLNativeAPI("glProgramUniform2i")] public static delegate* unmanaged<uint, int, int, int, void> glProgramUniform2i;
        [QGLNativeAPI("glProgramUniform2iv")] public static delegate* unmanaged<uint, int, int, int*, void> glProgramUniform2iv;
        [QGLNativeAPI("glProgramUniform2f")] public static delegate* unmanaged<uint, int, float, float, void> glProgramUniform2f;
        [QGLNativeAPI("glProgramUniform2fv")] public static delegate* unmanaged<uint, int, int, float*, void> glProgramUniform2fv;
        [QGLNativeAPI("glProgramUniform2d")] public static delegate* unmanaged<uint, int, double, double, void> glProgramUniform2d;
        [QGLNativeAPI("glProgramUniform2dv")] public static delegate* unmanaged<uint, int, int, double*, void> glProgramUniform2dv;
        [QGLNativeAPI("glProgramUniform2ui")] public static delegate* unmanaged<uint, int, uint, uint, void> glProgramUniform2ui;
        [QGLNativeAPI("glProgramUniform2uiv")] public static delegate* unmanaged<uint, int, int, uint*, void> glProgramUniform2uiv;
        [QGLNativeAPI("glProgramUniform3i")] public static delegate* unmanaged<uint, int, int, int, int, void> glProgramUniform3i;
        [QGLNativeAPI("glProgramUniform3iv")] public static delegate* unmanaged<uint, int, int, int*, void> glProgramUniform3iv;
        [QGLNativeAPI("glProgramUniform3f")] public static delegate* unmanaged<uint, int, float, float, float, void> glProgramUniform3f;
        [QGLNativeAPI("glProgramUniform3fv")] public static delegate* unmanaged<uint, int, int, float*, void> glProgramUniform3fv;
        [QGLNativeAPI("glProgramUniform3d")] public static delegate* unmanaged<uint, int, double, double, double, void> glProgramUniform3d;
        [QGLNativeAPI("glProgramUniform3dv")] public static delegate* unmanaged<uint, int, int, double*, void> glProgramUniform3dv;
        [QGLNativeAPI("glProgramUniform3ui")] public static delegate* unmanaged<uint, int, uint, uint, uint, void> glProgramUniform3ui;
        [QGLNativeAPI("glProgramUniform3uiv")] public static delegate* unmanaged<uint, int, int, uint*, void> glProgramUniform3uiv;
        [QGLNativeAPI("glProgramUniform4i")] public static delegate* unmanaged<uint, int, int, int, int, int, void> glProgramUniform4i;
        [QGLNativeAPI("glProgramUniform4iv")] public static delegate* unmanaged<uint, int, int, int*, void> glProgramUniform4iv;
        [QGLNativeAPI("glProgramUniform4f")] public static delegate* unmanaged<uint, int, float, float, float, float, void> glProgramUniform4f;
        [QGLNativeAPI("glProgramUniform4fv")] public static delegate* unmanaged<uint, int, int, float*, void> glProgramUniform4fv;
        [QGLNativeAPI("glProgramUniform4d")] public static delegate* unmanaged<uint, int, double, double, double, double, void> glProgramUniform4d;
        [QGLNativeAPI("glProgramUniform4dv")] public static delegate* unmanaged<uint, int, int, double*, void> glProgramUniform4dv;
        [QGLNativeAPI("glProgramUniform4ui")] public static delegate* unmanaged<uint, int, uint, uint, uint, uint, void> glProgramUniform4ui;
        [QGLNativeAPI("glProgramUniform4uiv")] public static delegate* unmanaged<uint, int, int, uint*, void> glProgramUniform4uiv;
        [QGLNativeAPI("glProgramUniformMatrix2fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix2fv;
        [QGLNativeAPI("glProgramUniformMatrix3fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix3fv;
        [QGLNativeAPI("glProgramUniformMatrix4fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix4fv;
        [QGLNativeAPI("glProgramUniformMatrix2dv")] public static delegate* unmanaged<uint, int, int, bool, double*, void> glProgramUniformMatrix2dv;
        [QGLNativeAPI("glProgramUniformMatrix3dv")] public static delegate* unmanaged<uint, int, int, bool, double*, void> glProgramUniformMatrix3dv;
        [QGLNativeAPI("glProgramUniformMatrix4dv")] public static delegate* unmanaged<uint, int, int, bool, double*, void> glProgramUniformMatrix4dv;
        [QGLNativeAPI("glProgramUniformMatrix2x3fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix2x3fv;
        [QGLNativeAPI("glProgramUniformMatrix3x2fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix3x2fv;
        [QGLNativeAPI("glProgramUniformMatrix2x4fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix2x4fv;
        [QGLNativeAPI("glProgramUniformMatrix4x2fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix4x2fv;
        [QGLNativeAPI("glProgramUniformMatrix3x4fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix3x4fv;
        [QGLNativeAPI("glProgramUniformMatrix4x3fv")] public static delegate* unmanaged<uint, int, int, bool, float*, void> glProgramUniformMatrix4x3fv;
        [QGLNativeAPI("glProgramUniformMatrix2x3dv")] public static delegate* unmanaged<uint, int, int, bool, double*, void> glProgramUniformMatrix2x3dv;
        [QGLNativeAPI("glProgramUniformMatrix3x2dv")] public static delegate* unmanaged<uint, int, int, bool, double*, void> glProgramUniformMatrix3x2dv;
        [QGLNativeAPI("glProgramUniformMatrix2x4dv")] public static delegate* unmanaged<uint, int, int, bool, double*, void> glProgramUniformMatrix2x4dv;
        [QGLNativeAPI("glProgramUniformMatrix4x2dv")] public static delegate* unmanaged<uint, int, int, bool, double*, void> glProgramUniformMatrix4x2dv;
        [QGLNativeAPI("glProgramUniformMatrix3x4dv")] public static delegate* unmanaged<uint, int, int, bool, double*, void> glProgramUniformMatrix3x4dv;
        [QGLNativeAPI("glProgramUniformMatrix4x3dv")] public static delegate* unmanaged<uint, int, int, bool, double*, void> glProgramUniformMatrix4x3dv;
        [QGLNativeAPI("glValidateProgramPipeline")] public static delegate* unmanaged<uint, void> glValidateProgramPipeline;
        [QGLNativeAPI("glGetProgramPipelineInfoLog")] public static delegate* unmanaged<uint, int, int*, byte*, void> glGetProgramPipelineInfoLog;
        [QGLNativeAPI("glVertexAttribL1d")] public static delegate* unmanaged<uint, double, void> glVertexAttribL1d;
        [QGLNativeAPI("glVertexAttribL2d")] public static delegate* unmanaged<uint, double, double, void> glVertexAttribL2d;
        [QGLNativeAPI("glVertexAttribL3d")] public static delegate* unmanaged<uint, double, double, double, void> glVertexAttribL3d;
        [QGLNativeAPI("glVertexAttribL4d")] public static delegate* unmanaged<uint, double, double, double, double, void> glVertexAttribL4d;
        [QGLNativeAPI("glVertexAttribL1dv")] public static delegate* unmanaged<uint, double*, void> glVertexAttribL1dv;
        [QGLNativeAPI("glVertexAttribL2dv")] public static delegate* unmanaged<uint, double*, void> glVertexAttribL2dv;
        [QGLNativeAPI("glVertexAttribL3dv")] public static delegate* unmanaged<uint, double*, void> glVertexAttribL3dv;
        [QGLNativeAPI("glVertexAttribL4dv")] public static delegate* unmanaged<uint, double*, void> glVertexAttribL4dv;
        [QGLNativeAPI("glVertexAttribLPointer")] public static delegate* unmanaged<uint, int, uint, int, void*, void> glVertexAttribLPointer;
        [QGLNativeAPI("glGetVertexAttribLdv")] public static delegate* unmanaged<uint, uint, double*, void> glGetVertexAttribLdv;
        [QGLNativeAPI("glViewportArrayv")] public static delegate* unmanaged<uint, int, float*, void> glViewportArrayv;
        [QGLNativeAPI("glViewportIndexedf")] public static delegate* unmanaged<uint, float, float, float, float, void> glViewportIndexedf;
        [QGLNativeAPI("glViewportIndexedfv")] public static delegate* unmanaged<uint, float*, void> glViewportIndexedfv;
        [QGLNativeAPI("glScissorArrayv")] public static delegate* unmanaged<uint, int, int*, void> glScissorArrayv;
        [QGLNativeAPI("glScissorIndexed")] public static delegate* unmanaged<uint, int, int, int, int, void> glScissorIndexed;
        [QGLNativeAPI("glScissorIndexedv")] public static delegate* unmanaged<uint, int*, void> glScissorIndexedv;
        [QGLNativeAPI("glDepthRangeArrayv")] public static delegate* unmanaged<uint, int, double*, void> glDepthRangeArrayv;
        [QGLNativeAPI("glDepthRangeIndexed")] public static delegate* unmanaged<uint, double, double, void> glDepthRangeIndexed;
        [QGLNativeAPI("glGetFloati_v")] public static delegate* unmanaged<uint, uint, float*, void> glGetFloati_v;
        [QGLNativeAPI("glGetDoublei_v")] public static delegate* unmanaged<uint, uint, double*, void> glGetDoublei_v;
        #endregion
    }
}
