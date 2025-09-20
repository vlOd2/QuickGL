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

// Bindings generated at 2025-09-20 18:58:19.954259
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBseparateshaderobjects
{
    #region Enums
    public const int GL_VERTEX_SHADER_BIT = 0x1;
    public const int GL_FRAGMENT_SHADER_BIT = 0x2;
    public const int GL_GEOMETRY_SHADER_BIT = 0x4;
    public const int GL_TESS_CONTROL_SHADER_BIT = 0x8;
    public const int GL_TESS_EVALUATION_SHADER_BIT = 0x10;
    public const uint GL_ALL_SHADER_BITS = 0xFFFFFFFF;
    public const int GL_PROGRAM_SEPARABLE = 0x8258;
    public const int GL_ACTIVE_PROGRAM = 0x8259;
    public const int GL_PROGRAM_PIPELINE_BINDING = 0x825A;
    #endregion
    
    #region Commands
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
    
    public static void glProgramParameteri(uint program, uint pname, int value) { QGLFeature.VerifyFunc((nint)_glProgramParameteri); _glProgramParameteri(program, pname, value); }
    internal static delegate* unmanaged<uint, uint, int, void> _glProgramParameteri = null;
    
    public static void glProgramUniform1i(uint program, int location, int v0) { QGLFeature.VerifyFunc((nint)_glProgramUniform1i); _glProgramUniform1i(program, location, v0); }
    internal static delegate* unmanaged<uint, int, int, void> _glProgramUniform1i = null;
    
    public static void glProgramUniform1iv(uint program, int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform1iv); _glProgramUniform1iv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform1iv = null;
    
    public static void glProgramUniform1f(uint program, int location, float v0) { QGLFeature.VerifyFunc((nint)_glProgramUniform1f); _glProgramUniform1f(program, location, v0); }
    internal static delegate* unmanaged<uint, int, float, void> _glProgramUniform1f = null;
    
    public static void glProgramUniform1fv(uint program, int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform1fv); _glProgramUniform1fv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform1fv = null;
    
    public static void glProgramUniform1d(uint program, int location, double v0) { QGLFeature.VerifyFunc((nint)_glProgramUniform1d); _glProgramUniform1d(program, location, v0); }
    internal static delegate* unmanaged<uint, int, double, void> _glProgramUniform1d = null;
    
    public static void glProgramUniform1dv(uint program, int location, int count, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform1dv); _glProgramUniform1dv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, double*, void> _glProgramUniform1dv = null;
    
    public static void glProgramUniform1ui(uint program, int location, uint v0) { QGLFeature.VerifyFunc((nint)_glProgramUniform1ui); _glProgramUniform1ui(program, location, v0); }
    internal static delegate* unmanaged<uint, int, uint, void> _glProgramUniform1ui = null;
    
    public static void glProgramUniform1uiv(uint program, int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform1uiv); _glProgramUniform1uiv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform1uiv = null;
    
    public static void glProgramUniform2i(uint program, int location, int v0, int v1) { QGLFeature.VerifyFunc((nint)_glProgramUniform2i); _glProgramUniform2i(program, location, v0, v1); }
    internal static delegate* unmanaged<uint, int, int, int, void> _glProgramUniform2i = null;
    
    public static void glProgramUniform2iv(uint program, int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform2iv); _glProgramUniform2iv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform2iv = null;
    
    public static void glProgramUniform2f(uint program, int location, float v0, float v1) { QGLFeature.VerifyFunc((nint)_glProgramUniform2f); _glProgramUniform2f(program, location, v0, v1); }
    internal static delegate* unmanaged<uint, int, float, float, void> _glProgramUniform2f = null;
    
    public static void glProgramUniform2fv(uint program, int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform2fv); _glProgramUniform2fv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform2fv = null;
    
    public static void glProgramUniform2d(uint program, int location, double v0, double v1) { QGLFeature.VerifyFunc((nint)_glProgramUniform2d); _glProgramUniform2d(program, location, v0, v1); }
    internal static delegate* unmanaged<uint, int, double, double, void> _glProgramUniform2d = null;
    
    public static void glProgramUniform2dv(uint program, int location, int count, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform2dv); _glProgramUniform2dv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, double*, void> _glProgramUniform2dv = null;
    
    public static void glProgramUniform2ui(uint program, int location, uint v0, uint v1) { QGLFeature.VerifyFunc((nint)_glProgramUniform2ui); _glProgramUniform2ui(program, location, v0, v1); }
    internal static delegate* unmanaged<uint, int, uint, uint, void> _glProgramUniform2ui = null;
    
    public static void glProgramUniform2uiv(uint program, int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform2uiv); _glProgramUniform2uiv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform2uiv = null;
    
    public static void glProgramUniform3i(uint program, int location, int v0, int v1, int v2) { QGLFeature.VerifyFunc((nint)_glProgramUniform3i); _glProgramUniform3i(program, location, v0, v1, v2); }
    internal static delegate* unmanaged<uint, int, int, int, int, void> _glProgramUniform3i = null;
    
    public static void glProgramUniform3iv(uint program, int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform3iv); _glProgramUniform3iv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform3iv = null;
    
    public static void glProgramUniform3f(uint program, int location, float v0, float v1, float v2) { QGLFeature.VerifyFunc((nint)_glProgramUniform3f); _glProgramUniform3f(program, location, v0, v1, v2); }
    internal static delegate* unmanaged<uint, int, float, float, float, void> _glProgramUniform3f = null;
    
    public static void glProgramUniform3fv(uint program, int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform3fv); _glProgramUniform3fv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform3fv = null;
    
    public static void glProgramUniform3d(uint program, int location, double v0, double v1, double v2) { QGLFeature.VerifyFunc((nint)_glProgramUniform3d); _glProgramUniform3d(program, location, v0, v1, v2); }
    internal static delegate* unmanaged<uint, int, double, double, double, void> _glProgramUniform3d = null;
    
    public static void glProgramUniform3dv(uint program, int location, int count, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform3dv); _glProgramUniform3dv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, double*, void> _glProgramUniform3dv = null;
    
    public static void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2) { QGLFeature.VerifyFunc((nint)_glProgramUniform3ui); _glProgramUniform3ui(program, location, v0, v1, v2); }
    internal static delegate* unmanaged<uint, int, uint, uint, uint, void> _glProgramUniform3ui = null;
    
    public static void glProgramUniform3uiv(uint program, int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform3uiv); _glProgramUniform3uiv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform3uiv = null;
    
    public static void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3) { QGLFeature.VerifyFunc((nint)_glProgramUniform4i); _glProgramUniform4i(program, location, v0, v1, v2, v3); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, void> _glProgramUniform4i = null;
    
    public static void glProgramUniform4iv(uint program, int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform4iv); _glProgramUniform4iv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, int*, void> _glProgramUniform4iv = null;
    
    public static void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3) { QGLFeature.VerifyFunc((nint)_glProgramUniform4f); _glProgramUniform4f(program, location, v0, v1, v2, v3); }
    internal static delegate* unmanaged<uint, int, float, float, float, float, void> _glProgramUniform4f = null;
    
    public static void glProgramUniform4fv(uint program, int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform4fv); _glProgramUniform4fv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, float*, void> _glProgramUniform4fv = null;
    
    public static void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3) { QGLFeature.VerifyFunc((nint)_glProgramUniform4d); _glProgramUniform4d(program, location, v0, v1, v2, v3); }
    internal static delegate* unmanaged<uint, int, double, double, double, double, void> _glProgramUniform4d = null;
    
    public static void glProgramUniform4dv(uint program, int location, int count, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform4dv); _glProgramUniform4dv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, double*, void> _glProgramUniform4dv = null;
    
    public static void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3) { QGLFeature.VerifyFunc((nint)_glProgramUniform4ui); _glProgramUniform4ui(program, location, v0, v1, v2, v3); }
    internal static delegate* unmanaged<uint, int, uint, uint, uint, uint, void> _glProgramUniform4ui = null;
    
    public static void glProgramUniform4uiv(uint program, int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform4uiv); _glProgramUniform4uiv(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, uint*, void> _glProgramUniform4uiv = null;
    
    public static void glProgramUniformMatrix2fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix2fv); _glProgramUniformMatrix2fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix2fv = null;
    
    public static void glProgramUniformMatrix3fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix3fv); _glProgramUniformMatrix3fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix3fv = null;
    
    public static void glProgramUniformMatrix4fv(uint program, int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix4fv); _glProgramUniformMatrix4fv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, float*, void> _glProgramUniformMatrix4fv = null;
    
    public static void glProgramUniformMatrix2dv(uint program, int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix2dv); _glProgramUniformMatrix2dv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix2dv = null;
    
    public static void glProgramUniformMatrix3dv(uint program, int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix3dv); _glProgramUniformMatrix3dv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix3dv = null;
    
    public static void glProgramUniformMatrix4dv(uint program, int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix4dv); _glProgramUniformMatrix4dv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix4dv = null;
    
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
    
    public static void glProgramUniformMatrix2x3dv(uint program, int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix2x3dv); _glProgramUniformMatrix2x3dv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix2x3dv = null;
    
    public static void glProgramUniformMatrix3x2dv(uint program, int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix3x2dv); _glProgramUniformMatrix3x2dv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix3x2dv = null;
    
    public static void glProgramUniformMatrix2x4dv(uint program, int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix2x4dv); _glProgramUniformMatrix2x4dv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix2x4dv = null;
    
    public static void glProgramUniformMatrix4x2dv(uint program, int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix4x2dv); _glProgramUniformMatrix4x2dv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix4x2dv = null;
    
    public static void glProgramUniformMatrix3x4dv(uint program, int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix3x4dv); _glProgramUniformMatrix3x4dv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix3x4dv = null;
    
    public static void glProgramUniformMatrix4x3dv(uint program, int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glProgramUniformMatrix4x3dv); _glProgramUniformMatrix4x3dv(program, location, count, transpose, value); }
    internal static delegate* unmanaged<uint, int, int, bool, double*, void> _glProgramUniformMatrix4x3dv = null;
    
    public static void glValidateProgramPipeline(uint pipeline) { QGLFeature.VerifyFunc((nint)_glValidateProgramPipeline); _glValidateProgramPipeline(pipeline); }
    internal static delegate* unmanaged<uint, void> _glValidateProgramPipeline = null;
    
    public static void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, byte* infoLog) { QGLFeature.VerifyFunc((nint)_glGetProgramPipelineInfoLog); _glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog); }
    internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetProgramPipelineInfoLog = null;
     #endregion
    
    internal static void Load()
    {
        _glUseProgramStages = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glUseProgramStages");
        _glActiveShaderProgram = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glActiveShaderProgram");
        _glCreateShaderProgramv = (delegate* unmanaged<uint, int, byte**, uint>)QuickGL.GetGLProcAddress("glCreateShaderProgramv");
        _glBindProgramPipeline = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glBindProgramPipeline");
        _glDeleteProgramPipelines = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteProgramPipelines");
        _glGenProgramPipelines = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenProgramPipelines");
        _glIsProgramPipeline = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsProgramPipeline");
        _glGetProgramPipelineiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetProgramPipelineiv");
        _glProgramParameteri = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glProgramParameteri");
        _glProgramUniform1i = (delegate* unmanaged<uint, int, int, void>)QuickGL.GetGLProcAddress("glProgramUniform1i");
        _glProgramUniform1iv = (delegate* unmanaged<uint, int, int, int*, void>)QuickGL.GetGLProcAddress("glProgramUniform1iv");
        _glProgramUniform1f = (delegate* unmanaged<uint, int, float, void>)QuickGL.GetGLProcAddress("glProgramUniform1f");
        _glProgramUniform1fv = (delegate* unmanaged<uint, int, int, float*, void>)QuickGL.GetGLProcAddress("glProgramUniform1fv");
        _glProgramUniform1d = (delegate* unmanaged<uint, int, double, void>)QuickGL.GetGLProcAddress("glProgramUniform1d");
        _glProgramUniform1dv = (delegate* unmanaged<uint, int, int, double*, void>)QuickGL.GetGLProcAddress("glProgramUniform1dv");
        _glProgramUniform1ui = (delegate* unmanaged<uint, int, uint, void>)QuickGL.GetGLProcAddress("glProgramUniform1ui");
        _glProgramUniform1uiv = (delegate* unmanaged<uint, int, int, uint*, void>)QuickGL.GetGLProcAddress("glProgramUniform1uiv");
        _glProgramUniform2i = (delegate* unmanaged<uint, int, int, int, void>)QuickGL.GetGLProcAddress("glProgramUniform2i");
        _glProgramUniform2iv = (delegate* unmanaged<uint, int, int, int*, void>)QuickGL.GetGLProcAddress("glProgramUniform2iv");
        _glProgramUniform2f = (delegate* unmanaged<uint, int, float, float, void>)QuickGL.GetGLProcAddress("glProgramUniform2f");
        _glProgramUniform2fv = (delegate* unmanaged<uint, int, int, float*, void>)QuickGL.GetGLProcAddress("glProgramUniform2fv");
        _glProgramUniform2d = (delegate* unmanaged<uint, int, double, double, void>)QuickGL.GetGLProcAddress("glProgramUniform2d");
        _glProgramUniform2dv = (delegate* unmanaged<uint, int, int, double*, void>)QuickGL.GetGLProcAddress("glProgramUniform2dv");
        _glProgramUniform2ui = (delegate* unmanaged<uint, int, uint, uint, void>)QuickGL.GetGLProcAddress("glProgramUniform2ui");
        _glProgramUniform2uiv = (delegate* unmanaged<uint, int, int, uint*, void>)QuickGL.GetGLProcAddress("glProgramUniform2uiv");
        _glProgramUniform3i = (delegate* unmanaged<uint, int, int, int, int, void>)QuickGL.GetGLProcAddress("glProgramUniform3i");
        _glProgramUniform3iv = (delegate* unmanaged<uint, int, int, int*, void>)QuickGL.GetGLProcAddress("glProgramUniform3iv");
        _glProgramUniform3f = (delegate* unmanaged<uint, int, float, float, float, void>)QuickGL.GetGLProcAddress("glProgramUniform3f");
        _glProgramUniform3fv = (delegate* unmanaged<uint, int, int, float*, void>)QuickGL.GetGLProcAddress("glProgramUniform3fv");
        _glProgramUniform3d = (delegate* unmanaged<uint, int, double, double, double, void>)QuickGL.GetGLProcAddress("glProgramUniform3d");
        _glProgramUniform3dv = (delegate* unmanaged<uint, int, int, double*, void>)QuickGL.GetGLProcAddress("glProgramUniform3dv");
        _glProgramUniform3ui = (delegate* unmanaged<uint, int, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glProgramUniform3ui");
        _glProgramUniform3uiv = (delegate* unmanaged<uint, int, int, uint*, void>)QuickGL.GetGLProcAddress("glProgramUniform3uiv");
        _glProgramUniform4i = (delegate* unmanaged<uint, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glProgramUniform4i");
        _glProgramUniform4iv = (delegate* unmanaged<uint, int, int, int*, void>)QuickGL.GetGLProcAddress("glProgramUniform4iv");
        _glProgramUniform4f = (delegate* unmanaged<uint, int, float, float, float, float, void>)QuickGL.GetGLProcAddress("glProgramUniform4f");
        _glProgramUniform4fv = (delegate* unmanaged<uint, int, int, float*, void>)QuickGL.GetGLProcAddress("glProgramUniform4fv");
        _glProgramUniform4d = (delegate* unmanaged<uint, int, double, double, double, double, void>)QuickGL.GetGLProcAddress("glProgramUniform4d");
        _glProgramUniform4dv = (delegate* unmanaged<uint, int, int, double*, void>)QuickGL.GetGLProcAddress("glProgramUniform4dv");
        _glProgramUniform4ui = (delegate* unmanaged<uint, int, uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glProgramUniform4ui");
        _glProgramUniform4uiv = (delegate* unmanaged<uint, int, int, uint*, void>)QuickGL.GetGLProcAddress("glProgramUniform4uiv");
        _glProgramUniformMatrix2fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix2fv");
        _glProgramUniformMatrix3fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix3fv");
        _glProgramUniformMatrix4fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix4fv");
        _glProgramUniformMatrix2dv = (delegate* unmanaged<uint, int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix2dv");
        _glProgramUniformMatrix3dv = (delegate* unmanaged<uint, int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix3dv");
        _glProgramUniformMatrix4dv = (delegate* unmanaged<uint, int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix4dv");
        _glProgramUniformMatrix2x3fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix2x3fv");
        _glProgramUniformMatrix3x2fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix3x2fv");
        _glProgramUniformMatrix2x4fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix2x4fv");
        _glProgramUniformMatrix4x2fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix4x2fv");
        _glProgramUniformMatrix3x4fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix3x4fv");
        _glProgramUniformMatrix4x3fv = (delegate* unmanaged<uint, int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix4x3fv");
        _glProgramUniformMatrix2x3dv = (delegate* unmanaged<uint, int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix2x3dv");
        _glProgramUniformMatrix3x2dv = (delegate* unmanaged<uint, int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix3x2dv");
        _glProgramUniformMatrix2x4dv = (delegate* unmanaged<uint, int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix2x4dv");
        _glProgramUniformMatrix4x2dv = (delegate* unmanaged<uint, int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix4x2dv");
        _glProgramUniformMatrix3x4dv = (delegate* unmanaged<uint, int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix3x4dv");
        _glProgramUniformMatrix4x3dv = (delegate* unmanaged<uint, int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glProgramUniformMatrix4x3dv");
        _glValidateProgramPipeline = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glValidateProgramPipeline");
        _glGetProgramPipelineInfoLog = (delegate* unmanaged<uint, int, int*, byte*, void>)QuickGL.GetGLProcAddress("glGetProgramPipelineInfoLog");
    }
    
    internal static void Unload()
    {
        _glUseProgramStages = null;
        _glActiveShaderProgram = null;
        _glCreateShaderProgramv = null;
        _glBindProgramPipeline = null;
        _glDeleteProgramPipelines = null;
        _glGenProgramPipelines = null;
        _glIsProgramPipeline = null;
        _glGetProgramPipelineiv = null;
        _glProgramParameteri = null;
        _glProgramUniform1i = null;
        _glProgramUniform1iv = null;
        _glProgramUniform1f = null;
        _glProgramUniform1fv = null;
        _glProgramUniform1d = null;
        _glProgramUniform1dv = null;
        _glProgramUniform1ui = null;
        _glProgramUniform1uiv = null;
        _glProgramUniform2i = null;
        _glProgramUniform2iv = null;
        _glProgramUniform2f = null;
        _glProgramUniform2fv = null;
        _glProgramUniform2d = null;
        _glProgramUniform2dv = null;
        _glProgramUniform2ui = null;
        _glProgramUniform2uiv = null;
        _glProgramUniform3i = null;
        _glProgramUniform3iv = null;
        _glProgramUniform3f = null;
        _glProgramUniform3fv = null;
        _glProgramUniform3d = null;
        _glProgramUniform3dv = null;
        _glProgramUniform3ui = null;
        _glProgramUniform3uiv = null;
        _glProgramUniform4i = null;
        _glProgramUniform4iv = null;
        _glProgramUniform4f = null;
        _glProgramUniform4fv = null;
        _glProgramUniform4d = null;
        _glProgramUniform4dv = null;
        _glProgramUniform4ui = null;
        _glProgramUniform4uiv = null;
        _glProgramUniformMatrix2fv = null;
        _glProgramUniformMatrix3fv = null;
        _glProgramUniformMatrix4fv = null;
        _glProgramUniformMatrix2dv = null;
        _glProgramUniformMatrix3dv = null;
        _glProgramUniformMatrix4dv = null;
        _glProgramUniformMatrix2x3fv = null;
        _glProgramUniformMatrix3x2fv = null;
        _glProgramUniformMatrix2x4fv = null;
        _glProgramUniformMatrix4x2fv = null;
        _glProgramUniformMatrix3x4fv = null;
        _glProgramUniformMatrix4x3fv = null;
        _glProgramUniformMatrix2x3dv = null;
        _glProgramUniformMatrix3x2dv = null;
        _glProgramUniformMatrix2x4dv = null;
        _glProgramUniformMatrix4x2dv = null;
        _glProgramUniformMatrix3x4dv = null;
        _glProgramUniformMatrix4x3dv = null;
        _glValidateProgramPipeline = null;
        _glGetProgramPipelineInfoLog = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_separate_shader_objects", true, false);
}
