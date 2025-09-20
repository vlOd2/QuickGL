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

// Bindings generated at 2025-09-20 18:58:20.133205
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBvertexprogram
{
    #region Enums
    public const int GL_COLOR_SUM_ARB = 0x8458;
    public const int GL_VERTEX_PROGRAM_ARB = 0x8620;
    public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622;
    public const int GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623;
    public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624;
    public const int GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625;
    public const int GL_CURRENT_VERTEX_ATTRIB_ARB = 0x8626;
    public const int GL_PROGRAM_LENGTH_ARB = 0x8627;
    public const int GL_PROGRAM_STRING_ARB = 0x8628;
    public const int GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;
    public const int GL_MAX_PROGRAM_MATRICES_ARB = 0x862F;
    public const int GL_CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;
    public const int GL_CURRENT_MATRIX_ARB = 0x8641;
    public const int GL_VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642;
    public const int GL_VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643;
    public const int GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645;
    public const int GL_PROGRAM_ERROR_POSITION_ARB = 0x864B;
    public const int GL_PROGRAM_BINDING_ARB = 0x8677;
    public const int GL_MAX_VERTEX_ATTRIBS_ARB = 0x8869;
    public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A;
    public const int GL_PROGRAM_ERROR_STRING_ARB = 0x8874;
    public const int GL_PROGRAM_FORMAT_ASCII_ARB = 0x8875;
    public const int GL_PROGRAM_FORMAT_ARB = 0x8876;
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
    public const int GL_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0;
    public const int GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1;
    public const int GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2;
    public const int GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3;
    public const int GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;
    public const int GL_MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;
    public const int GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;
    public const int GL_TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;
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
    public static void glVertexAttrib1dARB(uint index, double x) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1dARB); _glVertexAttrib1dARB(index, x); }
    internal static delegate* unmanaged<uint, double, void> _glVertexAttrib1dARB = null;
    
    public static void glVertexAttrib1dvARB(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1dvARB); _glVertexAttrib1dvARB(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib1dvARB = null;
    
    public static void glVertexAttrib1fARB(uint index, float x) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1fARB); _glVertexAttrib1fARB(index, x); }
    internal static delegate* unmanaged<uint, float, void> _glVertexAttrib1fARB = null;
    
    public static void glVertexAttrib1fvARB(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1fvARB); _glVertexAttrib1fvARB(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib1fvARB = null;
    
    public static void glVertexAttrib1sARB(uint index, short x) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1sARB); _glVertexAttrib1sARB(index, x); }
    internal static delegate* unmanaged<uint, short, void> _glVertexAttrib1sARB = null;
    
    public static void glVertexAttrib1svARB(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1svARB); _glVertexAttrib1svARB(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib1svARB = null;
    
    public static void glVertexAttrib2dARB(uint index, double x, double y) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2dARB); _glVertexAttrib2dARB(index, x, y); }
    internal static delegate* unmanaged<uint, double, double, void> _glVertexAttrib2dARB = null;
    
    public static void glVertexAttrib2dvARB(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2dvARB); _glVertexAttrib2dvARB(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib2dvARB = null;
    
    public static void glVertexAttrib2fARB(uint index, float x, float y) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2fARB); _glVertexAttrib2fARB(index, x, y); }
    internal static delegate* unmanaged<uint, float, float, void> _glVertexAttrib2fARB = null;
    
    public static void glVertexAttrib2fvARB(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2fvARB); _glVertexAttrib2fvARB(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib2fvARB = null;
    
    public static void glVertexAttrib2sARB(uint index, short x, short y) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2sARB); _glVertexAttrib2sARB(index, x, y); }
    internal static delegate* unmanaged<uint, short, short, void> _glVertexAttrib2sARB = null;
    
    public static void glVertexAttrib2svARB(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2svARB); _glVertexAttrib2svARB(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib2svARB = null;
    
    public static void glVertexAttrib3dARB(uint index, double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3dARB); _glVertexAttrib3dARB(index, x, y, z); }
    internal static delegate* unmanaged<uint, double, double, double, void> _glVertexAttrib3dARB = null;
    
    public static void glVertexAttrib3dvARB(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3dvARB); _glVertexAttrib3dvARB(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib3dvARB = null;
    
    public static void glVertexAttrib3fARB(uint index, float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3fARB); _glVertexAttrib3fARB(index, x, y, z); }
    internal static delegate* unmanaged<uint, float, float, float, void> _glVertexAttrib3fARB = null;
    
    public static void glVertexAttrib3fvARB(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3fvARB); _glVertexAttrib3fvARB(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib3fvARB = null;
    
    public static void glVertexAttrib3sARB(uint index, short x, short y, short z) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3sARB); _glVertexAttrib3sARB(index, x, y, z); }
    internal static delegate* unmanaged<uint, short, short, short, void> _glVertexAttrib3sARB = null;
    
    public static void glVertexAttrib3svARB(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3svARB); _glVertexAttrib3svARB(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib3svARB = null;
    
    public static void glVertexAttrib4NbvARB(uint index, sbyte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NbvARB); _glVertexAttrib4NbvARB(index, v); }
    internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttrib4NbvARB = null;
    
    public static void glVertexAttrib4NivARB(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NivARB); _glVertexAttrib4NivARB(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glVertexAttrib4NivARB = null;
    
    public static void glVertexAttrib4NsvARB(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NsvARB); _glVertexAttrib4NsvARB(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib4NsvARB = null;
    
    public static void glVertexAttrib4NubARB(uint index, byte x, byte y, byte z, byte w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NubARB); _glVertexAttrib4NubARB(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, byte, byte, byte, byte, void> _glVertexAttrib4NubARB = null;
    
    public static void glVertexAttrib4NubvARB(uint index, byte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NubvARB); _glVertexAttrib4NubvARB(index, v); }
    internal static delegate* unmanaged<uint, byte*, void> _glVertexAttrib4NubvARB = null;
    
    public static void glVertexAttrib4NuivARB(uint index, uint* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NuivARB); _glVertexAttrib4NuivARB(index, v); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexAttrib4NuivARB = null;
    
    public static void glVertexAttrib4NusvARB(uint index, ushort* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4NusvARB); _glVertexAttrib4NusvARB(index, v); }
    internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttrib4NusvARB = null;
    
    public static void glVertexAttrib4bvARB(uint index, sbyte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4bvARB); _glVertexAttrib4bvARB(index, v); }
    internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttrib4bvARB = null;
    
    public static void glVertexAttrib4dARB(uint index, double x, double y, double z, double w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4dARB); _glVertexAttrib4dARB(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, double, double, double, double, void> _glVertexAttrib4dARB = null;
    
    public static void glVertexAttrib4dvARB(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4dvARB); _glVertexAttrib4dvARB(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib4dvARB = null;
    
    public static void glVertexAttrib4fARB(uint index, float x, float y, float z, float w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4fARB); _glVertexAttrib4fARB(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, float, float, float, float, void> _glVertexAttrib4fARB = null;
    
    public static void glVertexAttrib4fvARB(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4fvARB); _glVertexAttrib4fvARB(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib4fvARB = null;
    
    public static void glVertexAttrib4ivARB(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4ivARB); _glVertexAttrib4ivARB(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glVertexAttrib4ivARB = null;
    
    public static void glVertexAttrib4sARB(uint index, short x, short y, short z, short w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4sARB); _glVertexAttrib4sARB(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, short, short, short, short, void> _glVertexAttrib4sARB = null;
    
    public static void glVertexAttrib4svARB(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4svARB); _glVertexAttrib4svARB(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib4svARB = null;
    
    public static void glVertexAttrib4ubvARB(uint index, byte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4ubvARB); _glVertexAttrib4ubvARB(index, v); }
    internal static delegate* unmanaged<uint, byte*, void> _glVertexAttrib4ubvARB = null;
    
    public static void glVertexAttrib4uivARB(uint index, uint* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4uivARB); _glVertexAttrib4uivARB(index, v); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexAttrib4uivARB = null;
    
    public static void glVertexAttrib4usvARB(uint index, ushort* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4usvARB); _glVertexAttrib4usvARB(index, v); }
    internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttrib4usvARB = null;
    
    public static void glVertexAttribPointerARB(uint index, int size, uint type, bool normalized, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glVertexAttribPointerARB); _glVertexAttribPointerARB(index, size, type, normalized, stride, pointer); }
    internal static delegate* unmanaged<uint, int, uint, bool, int, void*, void> _glVertexAttribPointerARB = null;
    
    public static void glEnableVertexAttribArrayARB(uint index) { QGLFeature.VerifyFunc((nint)_glEnableVertexAttribArrayARB); _glEnableVertexAttribArrayARB(index); }
    internal static delegate* unmanaged<uint, void> _glEnableVertexAttribArrayARB = null;
    
    public static void glDisableVertexAttribArrayARB(uint index) { QGLFeature.VerifyFunc((nint)_glDisableVertexAttribArrayARB); _glDisableVertexAttribArrayARB(index); }
    internal static delegate* unmanaged<uint, void> _glDisableVertexAttribArrayARB = null;
    
    public static void glProgramStringARB(uint target, uint format, int len, void* @string) { QGLFeature.VerifyFunc((nint)_glProgramStringARB); _glProgramStringARB(target, format, len, @string); }
    internal static delegate* unmanaged<uint, uint, int, void*, void> _glProgramStringARB = null;
    
    public static void glBindProgramARB(uint target, uint program) { QGLFeature.VerifyFunc((nint)_glBindProgramARB); _glBindProgramARB(target, program); }
    internal static delegate* unmanaged<uint, uint, void> _glBindProgramARB = null;
    
    public static void glDeleteProgramsARB(int n, uint* programs) { QGLFeature.VerifyFunc((nint)_glDeleteProgramsARB); _glDeleteProgramsARB(n, programs); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteProgramsARB = null;
    
    public static void glGenProgramsARB(int n, uint* programs) { QGLFeature.VerifyFunc((nint)_glGenProgramsARB); _glGenProgramsARB(n, programs); }
    internal static delegate* unmanaged<int, uint*, void> _glGenProgramsARB = null;
    
    public static void glProgramEnvParameter4dARB(uint target, uint index, double x, double y, double z, double w) { QGLFeature.VerifyFunc((nint)_glProgramEnvParameter4dARB); _glProgramEnvParameter4dARB(target, index, x, y, z, w); }
    internal static delegate* unmanaged<uint, uint, double, double, double, double, void> _glProgramEnvParameter4dARB = null;
    
    public static void glProgramEnvParameter4dvARB(uint target, uint index, double* @params) { QGLFeature.VerifyFunc((nint)_glProgramEnvParameter4dvARB); _glProgramEnvParameter4dvARB(target, index, @params); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glProgramEnvParameter4dvARB = null;
    
    public static void glProgramEnvParameter4fARB(uint target, uint index, float x, float y, float z, float w) { QGLFeature.VerifyFunc((nint)_glProgramEnvParameter4fARB); _glProgramEnvParameter4fARB(target, index, x, y, z, w); }
    internal static delegate* unmanaged<uint, uint, float, float, float, float, void> _glProgramEnvParameter4fARB = null;
    
    public static void glProgramEnvParameter4fvARB(uint target, uint index, float* @params) { QGLFeature.VerifyFunc((nint)_glProgramEnvParameter4fvARB); _glProgramEnvParameter4fvARB(target, index, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glProgramEnvParameter4fvARB = null;
    
    public static void glProgramLocalParameter4dARB(uint target, uint index, double x, double y, double z, double w) { QGLFeature.VerifyFunc((nint)_glProgramLocalParameter4dARB); _glProgramLocalParameter4dARB(target, index, x, y, z, w); }
    internal static delegate* unmanaged<uint, uint, double, double, double, double, void> _glProgramLocalParameter4dARB = null;
    
    public static void glProgramLocalParameter4dvARB(uint target, uint index, double* @params) { QGLFeature.VerifyFunc((nint)_glProgramLocalParameter4dvARB); _glProgramLocalParameter4dvARB(target, index, @params); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glProgramLocalParameter4dvARB = null;
    
    public static void glProgramLocalParameter4fARB(uint target, uint index, float x, float y, float z, float w) { QGLFeature.VerifyFunc((nint)_glProgramLocalParameter4fARB); _glProgramLocalParameter4fARB(target, index, x, y, z, w); }
    internal static delegate* unmanaged<uint, uint, float, float, float, float, void> _glProgramLocalParameter4fARB = null;
    
    public static void glProgramLocalParameter4fvARB(uint target, uint index, float* @params) { QGLFeature.VerifyFunc((nint)_glProgramLocalParameter4fvARB); _glProgramLocalParameter4fvARB(target, index, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glProgramLocalParameter4fvARB = null;
    
    public static void glGetProgramEnvParameterdvARB(uint target, uint index, double* @params) { QGLFeature.VerifyFunc((nint)_glGetProgramEnvParameterdvARB); _glGetProgramEnvParameterdvARB(target, index, @params); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glGetProgramEnvParameterdvARB = null;
    
    public static void glGetProgramEnvParameterfvARB(uint target, uint index, float* @params) { QGLFeature.VerifyFunc((nint)_glGetProgramEnvParameterfvARB); _glGetProgramEnvParameterfvARB(target, index, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetProgramEnvParameterfvARB = null;
    
    public static void glGetProgramLocalParameterdvARB(uint target, uint index, double* @params) { QGLFeature.VerifyFunc((nint)_glGetProgramLocalParameterdvARB); _glGetProgramLocalParameterdvARB(target, index, @params); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glGetProgramLocalParameterdvARB = null;
    
    public static void glGetProgramLocalParameterfvARB(uint target, uint index, float* @params) { QGLFeature.VerifyFunc((nint)_glGetProgramLocalParameterfvARB); _glGetProgramLocalParameterfvARB(target, index, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetProgramLocalParameterfvARB = null;
    
    public static void glGetProgramivARB(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetProgramivARB); _glGetProgramivARB(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetProgramivARB = null;
    
    public static void glGetProgramStringARB(uint target, uint pname, void* @string) { QGLFeature.VerifyFunc((nint)_glGetProgramStringARB); _glGetProgramStringARB(target, pname, @string); }
    internal static delegate* unmanaged<uint, uint, void*, void> _glGetProgramStringARB = null;
    
    public static void glGetVertexAttribdvARB(uint index, uint pname, double* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribdvARB); _glGetVertexAttribdvARB(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glGetVertexAttribdvARB = null;
    
    public static void glGetVertexAttribfvARB(uint index, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribfvARB); _glGetVertexAttribfvARB(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetVertexAttribfvARB = null;
    
    public static void glGetVertexAttribivARB(uint index, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribivARB); _glGetVertexAttribivARB(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetVertexAttribivARB = null;
    
    public static void glGetVertexAttribPointervARB(uint index, uint pname, void** pointer) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribPointervARB); _glGetVertexAttribPointervARB(index, pname, pointer); }
    internal static delegate* unmanaged<uint, uint, void**, void> _glGetVertexAttribPointervARB = null;
    
    public static bool glIsProgramARB(uint program) { QGLFeature.VerifyFunc((nint)_glIsProgramARB); return _glIsProgramARB(program); }
    internal static delegate* unmanaged<uint, bool> _glIsProgramARB = null;
     #endregion
    
    internal static void Load()
    {
        _glVertexAttrib1dARB = (delegate* unmanaged<uint, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib1dARB");
        _glVertexAttrib1dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib1dvARB");
        _glVertexAttrib1fARB = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib1fARB");
        _glVertexAttrib1fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib1fvARB");
        _glVertexAttrib1sARB = (delegate* unmanaged<uint, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib1sARB");
        _glVertexAttrib1svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib1svARB");
        _glVertexAttrib2dARB = (delegate* unmanaged<uint, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib2dARB");
        _glVertexAttrib2dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib2dvARB");
        _glVertexAttrib2fARB = (delegate* unmanaged<uint, float, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib2fARB");
        _glVertexAttrib2fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib2fvARB");
        _glVertexAttrib2sARB = (delegate* unmanaged<uint, short, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib2sARB");
        _glVertexAttrib2svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib2svARB");
        _glVertexAttrib3dARB = (delegate* unmanaged<uint, double, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib3dARB");
        _glVertexAttrib3dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib3dvARB");
        _glVertexAttrib3fARB = (delegate* unmanaged<uint, float, float, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib3fARB");
        _glVertexAttrib3fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib3fvARB");
        _glVertexAttrib3sARB = (delegate* unmanaged<uint, short, short, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib3sARB");
        _glVertexAttrib3svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib3svARB");
        _glVertexAttrib4NbvARB = (delegate* unmanaged<uint, sbyte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NbvARB");
        _glVertexAttrib4NivARB = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NivARB");
        _glVertexAttrib4NsvARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NsvARB");
        _glVertexAttrib4NubARB = (delegate* unmanaged<uint, byte, byte, byte, byte, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NubARB");
        _glVertexAttrib4NubvARB = (delegate* unmanaged<uint, byte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NubvARB");
        _glVertexAttrib4NuivARB = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NuivARB");
        _glVertexAttrib4NusvARB = (delegate* unmanaged<uint, ushort*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4NusvARB");
        _glVertexAttrib4bvARB = (delegate* unmanaged<uint, sbyte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4bvARB");
        _glVertexAttrib4dARB = (delegate* unmanaged<uint, double, double, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib4dARB");
        _glVertexAttrib4dvARB = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4dvARB");
        _glVertexAttrib4fARB = (delegate* unmanaged<uint, float, float, float, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib4fARB");
        _glVertexAttrib4fvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4fvARB");
        _glVertexAttrib4ivARB = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4ivARB");
        _glVertexAttrib4sARB = (delegate* unmanaged<uint, short, short, short, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib4sARB");
        _glVertexAttrib4svARB = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4svARB");
        _glVertexAttrib4ubvARB = (delegate* unmanaged<uint, byte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4ubvARB");
        _glVertexAttrib4uivARB = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4uivARB");
        _glVertexAttrib4usvARB = (delegate* unmanaged<uint, ushort*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4usvARB");
        _glVertexAttribPointerARB = (delegate* unmanaged<uint, int, uint, bool, int, void*, void>)QuickGL.GetGLProcAddress("glVertexAttribPointerARB");
        _glEnableVertexAttribArrayARB = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glEnableVertexAttribArrayARB");
        _glDisableVertexAttribArrayARB = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDisableVertexAttribArrayARB");
        _glProgramStringARB = (delegate* unmanaged<uint, uint, int, void*, void>)QuickGL.GetGLProcAddress("glProgramStringARB");
        _glBindProgramARB = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBindProgramARB");
        _glDeleteProgramsARB = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteProgramsARB");
        _glGenProgramsARB = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenProgramsARB");
        _glProgramEnvParameter4dARB = (delegate* unmanaged<uint, uint, double, double, double, double, void>)QuickGL.GetGLProcAddress("glProgramEnvParameter4dARB");
        _glProgramEnvParameter4dvARB = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glProgramEnvParameter4dvARB");
        _glProgramEnvParameter4fARB = (delegate* unmanaged<uint, uint, float, float, float, float, void>)QuickGL.GetGLProcAddress("glProgramEnvParameter4fARB");
        _glProgramEnvParameter4fvARB = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glProgramEnvParameter4fvARB");
        _glProgramLocalParameter4dARB = (delegate* unmanaged<uint, uint, double, double, double, double, void>)QuickGL.GetGLProcAddress("glProgramLocalParameter4dARB");
        _glProgramLocalParameter4dvARB = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glProgramLocalParameter4dvARB");
        _glProgramLocalParameter4fARB = (delegate* unmanaged<uint, uint, float, float, float, float, void>)QuickGL.GetGLProcAddress("glProgramLocalParameter4fARB");
        _glProgramLocalParameter4fvARB = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glProgramLocalParameter4fvARB");
        _glGetProgramEnvParameterdvARB = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glGetProgramEnvParameterdvARB");
        _glGetProgramEnvParameterfvARB = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetProgramEnvParameterfvARB");
        _glGetProgramLocalParameterdvARB = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glGetProgramLocalParameterdvARB");
        _glGetProgramLocalParameterfvARB = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetProgramLocalParameterfvARB");
        _glGetProgramivARB = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetProgramivARB");
        _glGetProgramStringARB = (delegate* unmanaged<uint, uint, void*, void>)QuickGL.GetGLProcAddress("glGetProgramStringARB");
        _glGetVertexAttribdvARB = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribdvARB");
        _glGetVertexAttribfvARB = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribfvARB");
        _glGetVertexAttribivARB = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribivARB");
        _glGetVertexAttribPointervARB = (delegate* unmanaged<uint, uint, void**, void>)QuickGL.GetGLProcAddress("glGetVertexAttribPointervARB");
        _glIsProgramARB = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsProgramARB");
    }
    
    internal static void Unload()
    {
        _glVertexAttrib1dARB = null;
        _glVertexAttrib1dvARB = null;
        _glVertexAttrib1fARB = null;
        _glVertexAttrib1fvARB = null;
        _glVertexAttrib1sARB = null;
        _glVertexAttrib1svARB = null;
        _glVertexAttrib2dARB = null;
        _glVertexAttrib2dvARB = null;
        _glVertexAttrib2fARB = null;
        _glVertexAttrib2fvARB = null;
        _glVertexAttrib2sARB = null;
        _glVertexAttrib2svARB = null;
        _glVertexAttrib3dARB = null;
        _glVertexAttrib3dvARB = null;
        _glVertexAttrib3fARB = null;
        _glVertexAttrib3fvARB = null;
        _glVertexAttrib3sARB = null;
        _glVertexAttrib3svARB = null;
        _glVertexAttrib4NbvARB = null;
        _glVertexAttrib4NivARB = null;
        _glVertexAttrib4NsvARB = null;
        _glVertexAttrib4NubARB = null;
        _glVertexAttrib4NubvARB = null;
        _glVertexAttrib4NuivARB = null;
        _glVertexAttrib4NusvARB = null;
        _glVertexAttrib4bvARB = null;
        _glVertexAttrib4dARB = null;
        _glVertexAttrib4dvARB = null;
        _glVertexAttrib4fARB = null;
        _glVertexAttrib4fvARB = null;
        _glVertexAttrib4ivARB = null;
        _glVertexAttrib4sARB = null;
        _glVertexAttrib4svARB = null;
        _glVertexAttrib4ubvARB = null;
        _glVertexAttrib4uivARB = null;
        _glVertexAttrib4usvARB = null;
        _glVertexAttribPointerARB = null;
        _glEnableVertexAttribArrayARB = null;
        _glDisableVertexAttribArrayARB = null;
        _glProgramStringARB = null;
        _glBindProgramARB = null;
        _glDeleteProgramsARB = null;
        _glGenProgramsARB = null;
        _glProgramEnvParameter4dARB = null;
        _glProgramEnvParameter4dvARB = null;
        _glProgramEnvParameter4fARB = null;
        _glProgramEnvParameter4fvARB = null;
        _glProgramLocalParameter4dARB = null;
        _glProgramLocalParameter4dvARB = null;
        _glProgramLocalParameter4fARB = null;
        _glProgramLocalParameter4fvARB = null;
        _glGetProgramEnvParameterdvARB = null;
        _glGetProgramEnvParameterfvARB = null;
        _glGetProgramLocalParameterdvARB = null;
        _glGetProgramLocalParameterfvARB = null;
        _glGetProgramivARB = null;
        _glGetProgramStringARB = null;
        _glGetVertexAttribdvARB = null;
        _glGetVertexAttribfvARB = null;
        _glGetVertexAttribivARB = null;
        _glGetVertexAttribPointervARB = null;
        _glIsProgramARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_vertex_program", true, false);
}
