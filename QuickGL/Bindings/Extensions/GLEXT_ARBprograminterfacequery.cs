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

// Bindings generated at 2025-08-30 15:45:08.570121
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_program_interface_query", true, false)]
public static unsafe class GLEXT_ARBprograminterfacequery
{
    #region Enums
    public const int GL_UNIFORM = 0x92E1;
    public const int GL_UNIFORM_BLOCK = 0x92E2;
    public const int GL_PROGRAM_INPUT = 0x92E3;
    public const int GL_PROGRAM_OUTPUT = 0x92E4;
    public const int GL_BUFFER_VARIABLE = 0x92E5;
    public const int GL_SHADER_STORAGE_BLOCK = 0x92E6;
    public const int GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
    public const int GL_VERTEX_SUBROUTINE = 0x92E8;
    public const int GL_TESS_CONTROL_SUBROUTINE = 0x92E9;
    public const int GL_TESS_EVALUATION_SUBROUTINE = 0x92EA;
    public const int GL_GEOMETRY_SUBROUTINE = 0x92EB;
    public const int GL_FRAGMENT_SUBROUTINE = 0x92EC;
    public const int GL_COMPUTE_SUBROUTINE = 0x92ED;
    public const int GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
    public const int GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
    public const int GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
    public const int GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
    public const int GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
    public const int GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
    public const int GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
    public const int GL_ACTIVE_RESOURCES = 0x92F5;
    public const int GL_MAX_NAME_LENGTH = 0x92F6;
    public const int GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
    public const int GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
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
    public const int GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
    public const int GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
    public const int GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
    public const int GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
    public const int GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
    public const int GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
    public const int GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
    public const int GL_LOCATION = 0x930E;
    public const int GL_LOCATION_INDEX = 0x930F;
    public const int GL_IS_PER_PATCH = 0x92E7;
    public const int GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
    public const int GL_COMPATIBLE_SUBROUTINES = 0x8E4B;
    #endregion
    
    #region Commands
    public static void glGetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetProgramInterfaceiv); _glGetProgramInterfaceiv(program, programInterface, pname, @params); }
    [QGLNativeAPI("glGetProgramInterfaceiv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetProgramInterfaceiv = null;
    
    public static uint glGetProgramResourceIndex(uint program, uint programInterface, byte* name) { QGLNativeAPI.Verify((nint)_glGetProgramResourceIndex); return _glGetProgramResourceIndex(program, programInterface, name); }
    [QGLNativeAPI("glGetProgramResourceIndex")] internal static delegate* unmanaged<uint, uint, byte*, uint> _glGetProgramResourceIndex = null;
    
    public static void glGetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, byte* name) { QGLNativeAPI.Verify((nint)_glGetProgramResourceName); _glGetProgramResourceName(program, programInterface, index, bufSize, length, name); }
    [QGLNativeAPI("glGetProgramResourceName")] internal static delegate* unmanaged<uint, uint, uint, int, int*, byte*, void> _glGetProgramResourceName = null;
    
    public static void glGetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, int* @params) { QGLNativeAPI.Verify((nint)_glGetProgramResourceiv); _glGetProgramResourceiv(program, programInterface, index, propCount, props, count, length, @params); }
    [QGLNativeAPI("glGetProgramResourceiv")] internal static delegate* unmanaged<uint, uint, uint, int, uint*, int, int*, int*, void> _glGetProgramResourceiv = null;
    
    public static int glGetProgramResourceLocation(uint program, uint programInterface, byte* name) { QGLNativeAPI.Verify((nint)_glGetProgramResourceLocation); return _glGetProgramResourceLocation(program, programInterface, name); }
    [QGLNativeAPI("glGetProgramResourceLocation")] internal static delegate* unmanaged<uint, uint, byte*, int> _glGetProgramResourceLocation = null;
    
    public static int glGetProgramResourceLocationIndex(uint program, uint programInterface, byte* name) { QGLNativeAPI.Verify((nint)_glGetProgramResourceLocationIndex); return _glGetProgramResourceLocationIndex(program, programInterface, name); }
    [QGLNativeAPI("glGetProgramResourceLocationIndex")] internal static delegate* unmanaged<uint, uint, byte*, int> _glGetProgramResourceLocationIndex = null;
     #endregion
}
