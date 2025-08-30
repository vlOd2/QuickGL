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

// Bindings generated at 2025-08-30 15:45:08.682684
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_shader_subroutine", true, false)]
public static unsafe class GLEXT_ARBshadersubroutine
{
    #region Enums
    public const int GL_ACTIVE_SUBROUTINES = 0x8DE5;
    public const int GL_ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
    public const int GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
    public const int GL_ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
    public const int GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
    public const int GL_MAX_SUBROUTINES = 0x8DE7;
    public const int GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
    public const int GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
    public const int GL_COMPATIBLE_SUBROUTINES = 0x8E4B;
    public const int GL_UNIFORM_SIZE = 0x8A38;
    public const int GL_UNIFORM_NAME_LENGTH = 0x8A39;
    #endregion
    
    #region Commands
    public static int glGetSubroutineUniformLocation(uint program, uint shadertype, byte* name) { QGLNativeAPI.Verify((nint)_glGetSubroutineUniformLocation); return _glGetSubroutineUniformLocation(program, shadertype, name); }
    [QGLNativeAPI("glGetSubroutineUniformLocation")] internal static delegate* unmanaged<uint, uint, byte*, int> _glGetSubroutineUniformLocation = null;
    
    public static uint glGetSubroutineIndex(uint program, uint shadertype, byte* name) { QGLNativeAPI.Verify((nint)_glGetSubroutineIndex); return _glGetSubroutineIndex(program, shadertype, name); }
    [QGLNativeAPI("glGetSubroutineIndex")] internal static delegate* unmanaged<uint, uint, byte*, uint> _glGetSubroutineIndex = null;
    
    public static void glGetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values) { QGLNativeAPI.Verify((nint)_glGetActiveSubroutineUniformiv); _glGetActiveSubroutineUniformiv(program, shadertype, index, pname, values); }
    [QGLNativeAPI("glGetActiveSubroutineUniformiv")] internal static delegate* unmanaged<uint, uint, uint, uint, int*, void> _glGetActiveSubroutineUniformiv = null;
    
    public static void glGetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize, int* length, byte* name) { QGLNativeAPI.Verify((nint)_glGetActiveSubroutineUniformName); _glGetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, name); }
    [QGLNativeAPI("glGetActiveSubroutineUniformName")] internal static delegate* unmanaged<uint, uint, uint, int, int*, byte*, void> _glGetActiveSubroutineUniformName = null;
    
    public static void glGetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize, int* length, byte* name) { QGLNativeAPI.Verify((nint)_glGetActiveSubroutineName); _glGetActiveSubroutineName(program, shadertype, index, bufSize, length, name); }
    [QGLNativeAPI("glGetActiveSubroutineName")] internal static delegate* unmanaged<uint, uint, uint, int, int*, byte*, void> _glGetActiveSubroutineName = null;
    
    public static void glUniformSubroutinesuiv(uint shadertype, int count, uint* indices) { QGLNativeAPI.Verify((nint)_glUniformSubroutinesuiv); _glUniformSubroutinesuiv(shadertype, count, indices); }
    [QGLNativeAPI("glUniformSubroutinesuiv")] internal static delegate* unmanaged<uint, int, uint*, void> _glUniformSubroutinesuiv = null;
    
    public static void glGetUniformSubroutineuiv(uint shadertype, int location, uint* @params) { QGLNativeAPI.Verify((nint)_glGetUniformSubroutineuiv); _glGetUniformSubroutineuiv(shadertype, location, @params); }
    [QGLNativeAPI("glGetUniformSubroutineuiv")] internal static delegate* unmanaged<uint, int, uint*, void> _glGetUniformSubroutineuiv = null;
    
    public static void glGetProgramStageiv(uint program, uint shadertype, uint pname, int* values) { QGLNativeAPI.Verify((nint)_glGetProgramStageiv); _glGetProgramStageiv(program, shadertype, pname, values); }
    [QGLNativeAPI("glGetProgramStageiv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetProgramStageiv = null;
     #endregion
}
