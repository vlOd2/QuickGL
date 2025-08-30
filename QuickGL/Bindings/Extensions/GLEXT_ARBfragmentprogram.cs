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

// Bindings generated at 2025-08-30 15:45:08.513248
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_fragment_program", true, false)]
public static unsafe class GLEXT_ARBfragmentprogram
{
    #region Enums
    public const int GL_FRAGMENT_PROGRAM_ARB = 0x8804;
    public const int GL_PROGRAM_FORMAT_ASCII_ARB = 0x8875;
    public const int GL_PROGRAM_LENGTH_ARB = 0x8627;
    public const int GL_PROGRAM_FORMAT_ARB = 0x8876;
    public const int GL_PROGRAM_BINDING_ARB = 0x8677;
    public const int GL_PROGRAM_INSTRUCTIONS_ARB = 0x88A0;
    public const int GL_MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1;
    public const int GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2;
    public const int GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3;
    public const int GL_PROGRAM_TEMPORARIES_ARB = 0x88A4;
    public const int GL_MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5;
    public const int GL_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6;
    public const int GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7;
    public const int GL_PROGRAM_PARAMETERS_ARB = 0x88A8;
    public const int GL_MAX_PROGRAM_PARAMETERS_ARB = 0x88A9;
    public const int GL_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA;
    public const int GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB;
    public const int GL_PROGRAM_ATTRIBS_ARB = 0x88AC;
    public const int GL_MAX_PROGRAM_ATTRIBS_ARB = 0x88AD;
    public const int GL_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE;
    public const int GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF;
    public const int GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;
    public const int GL_MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;
    public const int GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;
    public const int GL_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805;
    public const int GL_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806;
    public const int GL_PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807;
    public const int GL_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808;
    public const int GL_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809;
    public const int GL_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A;
    public const int GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B;
    public const int GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C;
    public const int GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D;
    public const int GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E;
    public const int GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F;
    public const int GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810;
    public const int GL_PROGRAM_STRING_ARB = 0x8628;
    public const int GL_PROGRAM_ERROR_POSITION_ARB = 0x864B;
    public const int GL_CURRENT_MATRIX_ARB = 0x8641;
    public const int GL_TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;
    public const int GL_CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;
    public const int GL_MAX_PROGRAM_MATRICES_ARB = 0x862F;
    public const int GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;
    public const int GL_MAX_TEXTURE_COORDS_ARB = 0x8871;
    public const int GL_MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872;
    public const int GL_PROGRAM_ERROR_STRING_ARB = 0x8874;
    public const int GL_MATRIX0_ARB = 0x88C0;
    public const int GL_MATRIX1_ARB = 0x88C1;
    public const int GL_MATRIX2_ARB = 0x88C2;
    public const int GL_MATRIX3_ARB = 0x88C3;
    public const int GL_MATRIX4_ARB = 0x88C4;
    public const int GL_MATRIX5_ARB = 0x88C5;
    public const int GL_MATRIX6_ARB = 0x88C6;
    public const int GL_MATRIX7_ARB = 0x88C7;
    public const int GL_MATRIX8_ARB = 0x88C8;
    public const int GL_MATRIX9_ARB = 0x88C9;
    public const int GL_MATRIX10_ARB = 0x88CA;
    public const int GL_MATRIX11_ARB = 0x88CB;
    public const int GL_MATRIX12_ARB = 0x88CC;
    public const int GL_MATRIX13_ARB = 0x88CD;
    public const int GL_MATRIX14_ARB = 0x88CE;
    public const int GL_MATRIX15_ARB = 0x88CF;
    public const int GL_MATRIX16_ARB = 0x88D0;
    public const int GL_MATRIX17_ARB = 0x88D1;
    public const int GL_MATRIX18_ARB = 0x88D2;
    public const int GL_MATRIX19_ARB = 0x88D3;
    public const int GL_MATRIX20_ARB = 0x88D4;
    public const int GL_MATRIX21_ARB = 0x88D5;
    public const int GL_MATRIX22_ARB = 0x88D6;
    public const int GL_MATRIX23_ARB = 0x88D7;
    public const int GL_MATRIX24_ARB = 0x88D8;
    public const int GL_MATRIX25_ARB = 0x88D9;
    public const int GL_MATRIX26_ARB = 0x88DA;
    public const int GL_MATRIX27_ARB = 0x88DB;
    public const int GL_MATRIX28_ARB = 0x88DC;
    public const int GL_MATRIX29_ARB = 0x88DD;
    public const int GL_MATRIX30_ARB = 0x88DE;
    public const int GL_MATRIX31_ARB = 0x88DF;
    #endregion
    
    #region Commands
    public static void glProgramStringARB(uint target, uint format, int len, void* @string) { QGLNativeAPI.Verify((nint)_glProgramStringARB); _glProgramStringARB(target, format, len, @string); }
    [QGLNativeAPI("glProgramStringARB")] internal static delegate* unmanaged<uint, uint, int, void*, void> _glProgramStringARB = null;
    
    public static void glBindProgramARB(uint target, uint program) { QGLNativeAPI.Verify((nint)_glBindProgramARB); _glBindProgramARB(target, program); }
    [QGLNativeAPI("glBindProgramARB")] internal static delegate* unmanaged<uint, uint, void> _glBindProgramARB = null;
    
    public static void glDeleteProgramsARB(int n, uint* programs) { QGLNativeAPI.Verify((nint)_glDeleteProgramsARB); _glDeleteProgramsARB(n, programs); }
    [QGLNativeAPI("glDeleteProgramsARB")] internal static delegate* unmanaged<int, uint*, void> _glDeleteProgramsARB = null;
    
    public static void glGenProgramsARB(int n, uint* programs) { QGLNativeAPI.Verify((nint)_glGenProgramsARB); _glGenProgramsARB(n, programs); }
    [QGLNativeAPI("glGenProgramsARB")] internal static delegate* unmanaged<int, uint*, void> _glGenProgramsARB = null;
    
    public static void glProgramEnvParameter4dARB(uint target, uint index, double x, double y, double z, double w) { QGLNativeAPI.Verify((nint)_glProgramEnvParameter4dARB); _glProgramEnvParameter4dARB(target, index, x, y, z, w); }
    [QGLNativeAPI("glProgramEnvParameter4dARB")] internal static delegate* unmanaged<uint, uint, double, double, double, double, void> _glProgramEnvParameter4dARB = null;
    
    public static void glProgramEnvParameter4dvARB(uint target, uint index, double* @params) { QGLNativeAPI.Verify((nint)_glProgramEnvParameter4dvARB); _glProgramEnvParameter4dvARB(target, index, @params); }
    [QGLNativeAPI("glProgramEnvParameter4dvARB")] internal static delegate* unmanaged<uint, uint, double*, void> _glProgramEnvParameter4dvARB = null;
    
    public static void glProgramEnvParameter4fARB(uint target, uint index, float x, float y, float z, float w) { QGLNativeAPI.Verify((nint)_glProgramEnvParameter4fARB); _glProgramEnvParameter4fARB(target, index, x, y, z, w); }
    [QGLNativeAPI("glProgramEnvParameter4fARB")] internal static delegate* unmanaged<uint, uint, float, float, float, float, void> _glProgramEnvParameter4fARB = null;
    
    public static void glProgramEnvParameter4fvARB(uint target, uint index, float* @params) { QGLNativeAPI.Verify((nint)_glProgramEnvParameter4fvARB); _glProgramEnvParameter4fvARB(target, index, @params); }
    [QGLNativeAPI("glProgramEnvParameter4fvARB")] internal static delegate* unmanaged<uint, uint, float*, void> _glProgramEnvParameter4fvARB = null;
    
    public static void glProgramLocalParameter4dARB(uint target, uint index, double x, double y, double z, double w) { QGLNativeAPI.Verify((nint)_glProgramLocalParameter4dARB); _glProgramLocalParameter4dARB(target, index, x, y, z, w); }
    [QGLNativeAPI("glProgramLocalParameter4dARB")] internal static delegate* unmanaged<uint, uint, double, double, double, double, void> _glProgramLocalParameter4dARB = null;
    
    public static void glProgramLocalParameter4dvARB(uint target, uint index, double* @params) { QGLNativeAPI.Verify((nint)_glProgramLocalParameter4dvARB); _glProgramLocalParameter4dvARB(target, index, @params); }
    [QGLNativeAPI("glProgramLocalParameter4dvARB")] internal static delegate* unmanaged<uint, uint, double*, void> _glProgramLocalParameter4dvARB = null;
    
    public static void glProgramLocalParameter4fARB(uint target, uint index, float x, float y, float z, float w) { QGLNativeAPI.Verify((nint)_glProgramLocalParameter4fARB); _glProgramLocalParameter4fARB(target, index, x, y, z, w); }
    [QGLNativeAPI("glProgramLocalParameter4fARB")] internal static delegate* unmanaged<uint, uint, float, float, float, float, void> _glProgramLocalParameter4fARB = null;
    
    public static void glProgramLocalParameter4fvARB(uint target, uint index, float* @params) { QGLNativeAPI.Verify((nint)_glProgramLocalParameter4fvARB); _glProgramLocalParameter4fvARB(target, index, @params); }
    [QGLNativeAPI("glProgramLocalParameter4fvARB")] internal static delegate* unmanaged<uint, uint, float*, void> _glProgramLocalParameter4fvARB = null;
    
    public static void glGetProgramEnvParameterdvARB(uint target, uint index, double* @params) { QGLNativeAPI.Verify((nint)_glGetProgramEnvParameterdvARB); _glGetProgramEnvParameterdvARB(target, index, @params); }
    [QGLNativeAPI("glGetProgramEnvParameterdvARB")] internal static delegate* unmanaged<uint, uint, double*, void> _glGetProgramEnvParameterdvARB = null;
    
    public static void glGetProgramEnvParameterfvARB(uint target, uint index, float* @params) { QGLNativeAPI.Verify((nint)_glGetProgramEnvParameterfvARB); _glGetProgramEnvParameterfvARB(target, index, @params); }
    [QGLNativeAPI("glGetProgramEnvParameterfvARB")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetProgramEnvParameterfvARB = null;
    
    public static void glGetProgramLocalParameterdvARB(uint target, uint index, double* @params) { QGLNativeAPI.Verify((nint)_glGetProgramLocalParameterdvARB); _glGetProgramLocalParameterdvARB(target, index, @params); }
    [QGLNativeAPI("glGetProgramLocalParameterdvARB")] internal static delegate* unmanaged<uint, uint, double*, void> _glGetProgramLocalParameterdvARB = null;
    
    public static void glGetProgramLocalParameterfvARB(uint target, uint index, float* @params) { QGLNativeAPI.Verify((nint)_glGetProgramLocalParameterfvARB); _glGetProgramLocalParameterfvARB(target, index, @params); }
    [QGLNativeAPI("glGetProgramLocalParameterfvARB")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetProgramLocalParameterfvARB = null;
    
    public static void glGetProgramivARB(uint target, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetProgramivARB); _glGetProgramivARB(target, pname, @params); }
    [QGLNativeAPI("glGetProgramivARB")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetProgramivARB = null;
    
    public static void glGetProgramStringARB(uint target, uint pname, void* @string) { QGLNativeAPI.Verify((nint)_glGetProgramStringARB); _glGetProgramStringARB(target, pname, @string); }
    [QGLNativeAPI("glGetProgramStringARB")] internal static delegate* unmanaged<uint, uint, void*, void> _glGetProgramStringARB = null;
    
    public static bool glIsProgramARB(uint program) { QGLNativeAPI.Verify((nint)_glIsProgramARB); return _glIsProgramARB(program); }
    [QGLNativeAPI("glIsProgramARB")] internal static delegate* unmanaged<uint, bool> _glIsProgramARB = null;
     #endregion
}
