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

// Bindings generated at 2025-09-20 18:58:19.747249
namespace QuickGLNS.Bindings;

public static unsafe class GL20
{
    #region Enums
    public const int GL_BLEND_EQUATION_RGB = 0x8009;
    public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
    public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
    public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
    public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
    public const int GL_CURRENT_VERTEX_ATTRIB = 0x8626;
    public const int GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642;
    public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
    public const int GL_STENCIL_BACK_FUNC = 0x8800;
    public const int GL_STENCIL_BACK_FAIL = 0x8801;
    public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
    public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
    public const int GL_MAX_DRAW_BUFFERS = 0x8824;
    public const int GL_DRAW_BUFFER0 = 0x8825;
    public const int GL_DRAW_BUFFER1 = 0x8826;
    public const int GL_DRAW_BUFFER2 = 0x8827;
    public const int GL_DRAW_BUFFER3 = 0x8828;
    public const int GL_DRAW_BUFFER4 = 0x8829;
    public const int GL_DRAW_BUFFER5 = 0x882A;
    public const int GL_DRAW_BUFFER6 = 0x882B;
    public const int GL_DRAW_BUFFER7 = 0x882C;
    public const int GL_DRAW_BUFFER8 = 0x882D;
    public const int GL_DRAW_BUFFER9 = 0x882E;
    public const int GL_DRAW_BUFFER10 = 0x882F;
    public const int GL_DRAW_BUFFER11 = 0x8830;
    public const int GL_DRAW_BUFFER12 = 0x8831;
    public const int GL_DRAW_BUFFER13 = 0x8832;
    public const int GL_DRAW_BUFFER14 = 0x8833;
    public const int GL_DRAW_BUFFER15 = 0x8834;
    public const int GL_BLEND_EQUATION_ALPHA = 0x883D;
    public const int GL_MAX_VERTEX_ATTRIBS = 0x8869;
    public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
    public const int GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
    public const int GL_FRAGMENT_SHADER = 0x8B30;
    public const int GL_VERTEX_SHADER = 0x8B31;
    public const int GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
    public const int GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
    public const int GL_MAX_VARYING_FLOATS = 0x8B4B;
    public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
    public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
    public const int GL_SHADER_TYPE = 0x8B4F;
    public const int GL_FLOAT_VEC2 = 0x8B50;
    public const int GL_FLOAT_VEC3 = 0x8B51;
    public const int GL_FLOAT_VEC4 = 0x8B52;
    public const int GL_INT_VEC2 = 0x8B53;
    public const int GL_INT_VEC3 = 0x8B54;
    public const int GL_INT_VEC4 = 0x8B55;
    public const int GL_BOOL = 0x8B56;
    public const int GL_BOOL_VEC2 = 0x8B57;
    public const int GL_BOOL_VEC3 = 0x8B58;
    public const int GL_BOOL_VEC4 = 0x8B59;
    public const int GL_FLOAT_MAT2 = 0x8B5A;
    public const int GL_FLOAT_MAT3 = 0x8B5B;
    public const int GL_FLOAT_MAT4 = 0x8B5C;
    public const int GL_SAMPLER_1D = 0x8B5D;
    public const int GL_SAMPLER_2D = 0x8B5E;
    public const int GL_SAMPLER_3D = 0x8B5F;
    public const int GL_SAMPLER_CUBE = 0x8B60;
    public const int GL_SAMPLER_1D_SHADOW = 0x8B61;
    public const int GL_SAMPLER_2D_SHADOW = 0x8B62;
    public const int GL_DELETE_STATUS = 0x8B80;
    public const int GL_COMPILE_STATUS = 0x8B81;
    public const int GL_LINK_STATUS = 0x8B82;
    public const int GL_VALIDATE_STATUS = 0x8B83;
    public const int GL_INFO_LOG_LENGTH = 0x8B84;
    public const int GL_ATTACHED_SHADERS = 0x8B85;
    public const int GL_ACTIVE_UNIFORMS = 0x8B86;
    public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
    public const int GL_SHADER_SOURCE_LENGTH = 0x8B88;
    public const int GL_ACTIVE_ATTRIBUTES = 0x8B89;
    public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
    public const int GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
    public const int GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
    public const int GL_CURRENT_PROGRAM = 0x8B8D;
    public const int GL_POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
    public const int GL_LOWER_LEFT = 0x8CA1;
    public const int GL_UPPER_LEFT = 0x8CA2;
    public const int GL_STENCIL_BACK_REF = 0x8CA3;
    public const int GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
    public const int GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
    public const int GL_VERTEX_PROGRAM_TWO_SIDE = 0x8643;
    public const int GL_POINT_SPRITE = 0x8861;
    public const int GL_COORD_REPLACE = 0x8862;
    public const int GL_MAX_TEXTURE_COORDS = 0x8871;
    #endregion
    
    #region Commands
    public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha) { QGLFeature.VerifyFunc((nint)_glBlendEquationSeparate); _glBlendEquationSeparate(modeRGB, modeAlpha); }
    internal static delegate* unmanaged<uint, uint, void> _glBlendEquationSeparate = null;
    
    public static void glDrawBuffers(int n, uint* bufs) { QGLFeature.VerifyFunc((nint)_glDrawBuffers); _glDrawBuffers(n, bufs); }
    internal static delegate* unmanaged<int, uint*, void> _glDrawBuffers = null;
    
    public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass) { QGLFeature.VerifyFunc((nint)_glStencilOpSeparate); _glStencilOpSeparate(face, sfail, dpfail, dppass); }
    internal static delegate* unmanaged<uint, uint, uint, uint, void> _glStencilOpSeparate = null;
    
    public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask) { QGLFeature.VerifyFunc((nint)_glStencilFuncSeparate); _glStencilFuncSeparate(face, func, @ref, mask); }
    internal static delegate* unmanaged<uint, uint, int, uint, void> _glStencilFuncSeparate = null;
    
    public static void glStencilMaskSeparate(uint face, uint mask) { QGLFeature.VerifyFunc((nint)_glStencilMaskSeparate); _glStencilMaskSeparate(face, mask); }
    internal static delegate* unmanaged<uint, uint, void> _glStencilMaskSeparate = null;
    
    public static void glAttachShader(uint program, uint shader) { QGLFeature.VerifyFunc((nint)_glAttachShader); _glAttachShader(program, shader); }
    internal static delegate* unmanaged<uint, uint, void> _glAttachShader = null;
    
    public static void glBindAttribLocation(uint program, uint index, byte* name) { QGLFeature.VerifyFunc((nint)_glBindAttribLocation); _glBindAttribLocation(program, index, name); }
    internal static delegate* unmanaged<uint, uint, byte*, void> _glBindAttribLocation = null;
    
    public static void glCompileShader(uint shader) { QGLFeature.VerifyFunc((nint)_glCompileShader); _glCompileShader(shader); }
    internal static delegate* unmanaged<uint, void> _glCompileShader = null;
    
    public static uint glCreateProgram() { QGLFeature.VerifyFunc((nint)_glCreateProgram); return _glCreateProgram(); }
    internal static delegate* unmanaged<uint> _glCreateProgram = null;
    
    public static uint glCreateShader(uint type) { QGLFeature.VerifyFunc((nint)_glCreateShader); return _glCreateShader(type); }
    internal static delegate* unmanaged<uint, uint> _glCreateShader = null;
    
    public static void glDeleteProgram(uint program) { QGLFeature.VerifyFunc((nint)_glDeleteProgram); _glDeleteProgram(program); }
    internal static delegate* unmanaged<uint, void> _glDeleteProgram = null;
    
    public static void glDeleteShader(uint shader) { QGLFeature.VerifyFunc((nint)_glDeleteShader); _glDeleteShader(shader); }
    internal static delegate* unmanaged<uint, void> _glDeleteShader = null;
    
    public static void glDetachShader(uint program, uint shader) { QGLFeature.VerifyFunc((nint)_glDetachShader); _glDetachShader(program, shader); }
    internal static delegate* unmanaged<uint, uint, void> _glDetachShader = null;
    
    public static void glDisableVertexAttribArray(uint index) { QGLFeature.VerifyFunc((nint)_glDisableVertexAttribArray); _glDisableVertexAttribArray(index); }
    internal static delegate* unmanaged<uint, void> _glDisableVertexAttribArray = null;
    
    public static void glEnableVertexAttribArray(uint index) { QGLFeature.VerifyFunc((nint)_glEnableVertexAttribArray); _glEnableVertexAttribArray(index); }
    internal static delegate* unmanaged<uint, void> _glEnableVertexAttribArray = null;
    
    public static void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name) { QGLFeature.VerifyFunc((nint)_glGetActiveAttrib); _glGetActiveAttrib(program, index, bufSize, length, size, type, name); }
    internal static delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void> _glGetActiveAttrib = null;
    
    public static void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name) { QGLFeature.VerifyFunc((nint)_glGetActiveUniform); _glGetActiveUniform(program, index, bufSize, length, size, type, name); }
    internal static delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void> _glGetActiveUniform = null;
    
    public static void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders) { QGLFeature.VerifyFunc((nint)_glGetAttachedShaders); _glGetAttachedShaders(program, maxCount, count, shaders); }
    internal static delegate* unmanaged<uint, int, int*, uint*, void> _glGetAttachedShaders = null;
    
    public static int glGetAttribLocation(uint program, byte* name) { QGLFeature.VerifyFunc((nint)_glGetAttribLocation); return _glGetAttribLocation(program, name); }
    internal static delegate* unmanaged<uint, byte*, int> _glGetAttribLocation = null;
    
    public static void glGetProgramiv(uint program, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetProgramiv); _glGetProgramiv(program, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetProgramiv = null;
    
    public static void glGetProgramInfoLog(uint program, int bufSize, int* length, byte* infoLog) { QGLFeature.VerifyFunc((nint)_glGetProgramInfoLog); _glGetProgramInfoLog(program, bufSize, length, infoLog); }
    internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetProgramInfoLog = null;
    
    public static void glGetShaderiv(uint shader, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetShaderiv); _glGetShaderiv(shader, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetShaderiv = null;
    
    public static void glGetShaderInfoLog(uint shader, int bufSize, int* length, byte* infoLog) { QGLFeature.VerifyFunc((nint)_glGetShaderInfoLog); _glGetShaderInfoLog(shader, bufSize, length, infoLog); }
    internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetShaderInfoLog = null;
    
    public static void glGetShaderSource(uint shader, int bufSize, int* length, byte* source) { QGLFeature.VerifyFunc((nint)_glGetShaderSource); _glGetShaderSource(shader, bufSize, length, source); }
    internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetShaderSource = null;
    
    public static int glGetUniformLocation(uint program, byte* name) { QGLFeature.VerifyFunc((nint)_glGetUniformLocation); return _glGetUniformLocation(program, name); }
    internal static delegate* unmanaged<uint, byte*, int> _glGetUniformLocation = null;
    
    public static void glGetUniformfv(uint program, int location, float* @params) { QGLFeature.VerifyFunc((nint)_glGetUniformfv); _glGetUniformfv(program, location, @params); }
    internal static delegate* unmanaged<uint, int, float*, void> _glGetUniformfv = null;
    
    public static void glGetUniformiv(uint program, int location, int* @params) { QGLFeature.VerifyFunc((nint)_glGetUniformiv); _glGetUniformiv(program, location, @params); }
    internal static delegate* unmanaged<uint, int, int*, void> _glGetUniformiv = null;
    
    public static void glGetVertexAttribdv(uint index, uint pname, double* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribdv); _glGetVertexAttribdv(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glGetVertexAttribdv = null;
    
    public static void glGetVertexAttribfv(uint index, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribfv); _glGetVertexAttribfv(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetVertexAttribfv = null;
    
    public static void glGetVertexAttribiv(uint index, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribiv); _glGetVertexAttribiv(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetVertexAttribiv = null;
    
    public static void glGetVertexAttribPointerv(uint index, uint pname, void** pointer) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribPointerv); _glGetVertexAttribPointerv(index, pname, pointer); }
    internal static delegate* unmanaged<uint, uint, void**, void> _glGetVertexAttribPointerv = null;
    
    public static bool glIsProgram(uint program) { QGLFeature.VerifyFunc((nint)_glIsProgram); return _glIsProgram(program); }
    internal static delegate* unmanaged<uint, bool> _glIsProgram = null;
    
    public static bool glIsShader(uint shader) { QGLFeature.VerifyFunc((nint)_glIsShader); return _glIsShader(shader); }
    internal static delegate* unmanaged<uint, bool> _glIsShader = null;
    
    public static void glLinkProgram(uint program) { QGLFeature.VerifyFunc((nint)_glLinkProgram); _glLinkProgram(program); }
    internal static delegate* unmanaged<uint, void> _glLinkProgram = null;
    
    public static void glShaderSource(uint shader, int count, byte** @string, int* length) { QGLFeature.VerifyFunc((nint)_glShaderSource); _glShaderSource(shader, count, @string, length); }
    internal static delegate* unmanaged<uint, int, byte**, int*, void> _glShaderSource = null;
    
    public static void glUseProgram(uint program) { QGLFeature.VerifyFunc((nint)_glUseProgram); _glUseProgram(program); }
    internal static delegate* unmanaged<uint, void> _glUseProgram = null;
    
    public static void glUniform1f(int location, float v0) { QGLFeature.VerifyFunc((nint)_glUniform1f); _glUniform1f(location, v0); }
    internal static delegate* unmanaged<int, float, void> _glUniform1f = null;
    
    public static void glUniform2f(int location, float v0, float v1) { QGLFeature.VerifyFunc((nint)_glUniform2f); _glUniform2f(location, v0, v1); }
    internal static delegate* unmanaged<int, float, float, void> _glUniform2f = null;
    
    public static void glUniform3f(int location, float v0, float v1, float v2) { QGLFeature.VerifyFunc((nint)_glUniform3f); _glUniform3f(location, v0, v1, v2); }
    internal static delegate* unmanaged<int, float, float, float, void> _glUniform3f = null;
    
    public static void glUniform4f(int location, float v0, float v1, float v2, float v3) { QGLFeature.VerifyFunc((nint)_glUniform4f); _glUniform4f(location, v0, v1, v2, v3); }
    internal static delegate* unmanaged<int, float, float, float, float, void> _glUniform4f = null;
    
    public static void glUniform1i(int location, int v0) { QGLFeature.VerifyFunc((nint)_glUniform1i); _glUniform1i(location, v0); }
    internal static delegate* unmanaged<int, int, void> _glUniform1i = null;
    
    public static void glUniform2i(int location, int v0, int v1) { QGLFeature.VerifyFunc((nint)_glUniform2i); _glUniform2i(location, v0, v1); }
    internal static delegate* unmanaged<int, int, int, void> _glUniform2i = null;
    
    public static void glUniform3i(int location, int v0, int v1, int v2) { QGLFeature.VerifyFunc((nint)_glUniform3i); _glUniform3i(location, v0, v1, v2); }
    internal static delegate* unmanaged<int, int, int, int, void> _glUniform3i = null;
    
    public static void glUniform4i(int location, int v0, int v1, int v2, int v3) { QGLFeature.VerifyFunc((nint)_glUniform4i); _glUniform4i(location, v0, v1, v2, v3); }
    internal static delegate* unmanaged<int, int, int, int, int, void> _glUniform4i = null;
    
    public static void glUniform1fv(int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glUniform1fv); _glUniform1fv(location, count, value); }
    internal static delegate* unmanaged<int, int, float*, void> _glUniform1fv = null;
    
    public static void glUniform2fv(int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glUniform2fv); _glUniform2fv(location, count, value); }
    internal static delegate* unmanaged<int, int, float*, void> _glUniform2fv = null;
    
    public static void glUniform3fv(int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glUniform3fv); _glUniform3fv(location, count, value); }
    internal static delegate* unmanaged<int, int, float*, void> _glUniform3fv = null;
    
    public static void glUniform4fv(int location, int count, float* value) { QGLFeature.VerifyFunc((nint)_glUniform4fv); _glUniform4fv(location, count, value); }
    internal static delegate* unmanaged<int, int, float*, void> _glUniform4fv = null;
    
    public static void glUniform1iv(int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glUniform1iv); _glUniform1iv(location, count, value); }
    internal static delegate* unmanaged<int, int, int*, void> _glUniform1iv = null;
    
    public static void glUniform2iv(int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glUniform2iv); _glUniform2iv(location, count, value); }
    internal static delegate* unmanaged<int, int, int*, void> _glUniform2iv = null;
    
    public static void glUniform3iv(int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glUniform3iv); _glUniform3iv(location, count, value); }
    internal static delegate* unmanaged<int, int, int*, void> _glUniform3iv = null;
    
    public static void glUniform4iv(int location, int count, int* value) { QGLFeature.VerifyFunc((nint)_glUniform4iv); _glUniform4iv(location, count, value); }
    internal static delegate* unmanaged<int, int, int*, void> _glUniform4iv = null;
    
    public static void glUniformMatrix2fv(int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix2fv); _glUniformMatrix2fv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix2fv = null;
    
    public static void glUniformMatrix3fv(int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix3fv); _glUniformMatrix3fv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix3fv = null;
    
    public static void glUniformMatrix4fv(int location, int count, bool transpose, float* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix4fv); _glUniformMatrix4fv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix4fv = null;
    
    public static void glValidateProgram(uint program) { QGLFeature.VerifyFunc((nint)_glValidateProgram); _glValidateProgram(program); }
    internal static delegate* unmanaged<uint, void> _glValidateProgram = null;
    
    public static void glVertexAttrib1d(uint index, double x) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1d); _glVertexAttrib1d(index, x); }
    internal static delegate* unmanaged<uint, double, void> _glVertexAttrib1d = null;
    
    public static void glVertexAttrib1dv(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1dv); _glVertexAttrib1dv(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib1dv = null;
    
    public static void glVertexAttrib1f(uint index, float x) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1f); _glVertexAttrib1f(index, x); }
    internal static delegate* unmanaged<uint, float, void> _glVertexAttrib1f = null;
    
    public static void glVertexAttrib1fv(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1fv); _glVertexAttrib1fv(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib1fv = null;
    
    public static void glVertexAttrib1s(uint index, short x) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1s); _glVertexAttrib1s(index, x); }
    internal static delegate* unmanaged<uint, short, void> _glVertexAttrib1s = null;
    
    public static void glVertexAttrib1sv(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib1sv); _glVertexAttrib1sv(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib1sv = null;
    
    public static void glVertexAttrib2d(uint index, double x, double y) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2d); _glVertexAttrib2d(index, x, y); }
    internal static delegate* unmanaged<uint, double, double, void> _glVertexAttrib2d = null;
    
    public static void glVertexAttrib2dv(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2dv); _glVertexAttrib2dv(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib2dv = null;
    
    public static void glVertexAttrib2f(uint index, float x, float y) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2f); _glVertexAttrib2f(index, x, y); }
    internal static delegate* unmanaged<uint, float, float, void> _glVertexAttrib2f = null;
    
    public static void glVertexAttrib2fv(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2fv); _glVertexAttrib2fv(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib2fv = null;
    
    public static void glVertexAttrib2s(uint index, short x, short y) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2s); _glVertexAttrib2s(index, x, y); }
    internal static delegate* unmanaged<uint, short, short, void> _glVertexAttrib2s = null;
    
    public static void glVertexAttrib2sv(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib2sv); _glVertexAttrib2sv(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib2sv = null;
    
    public static void glVertexAttrib3d(uint index, double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3d); _glVertexAttrib3d(index, x, y, z); }
    internal static delegate* unmanaged<uint, double, double, double, void> _glVertexAttrib3d = null;
    
    public static void glVertexAttrib3dv(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3dv); _glVertexAttrib3dv(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib3dv = null;
    
    public static void glVertexAttrib3f(uint index, float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3f); _glVertexAttrib3f(index, x, y, z); }
    internal static delegate* unmanaged<uint, float, float, float, void> _glVertexAttrib3f = null;
    
    public static void glVertexAttrib3fv(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3fv); _glVertexAttrib3fv(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib3fv = null;
    
    public static void glVertexAttrib3s(uint index, short x, short y, short z) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3s); _glVertexAttrib3s(index, x, y, z); }
    internal static delegate* unmanaged<uint, short, short, short, void> _glVertexAttrib3s = null;
    
    public static void glVertexAttrib3sv(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib3sv); _glVertexAttrib3sv(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib3sv = null;
    
    public static void glVertexAttrib4Nbv(uint index, sbyte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4Nbv); _glVertexAttrib4Nbv(index, v); }
    internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttrib4Nbv = null;
    
    public static void glVertexAttrib4Niv(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4Niv); _glVertexAttrib4Niv(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glVertexAttrib4Niv = null;
    
    public static void glVertexAttrib4Nsv(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4Nsv); _glVertexAttrib4Nsv(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib4Nsv = null;
    
    public static void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4Nub); _glVertexAttrib4Nub(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, byte, byte, byte, byte, void> _glVertexAttrib4Nub = null;
    
    public static void glVertexAttrib4Nubv(uint index, byte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4Nubv); _glVertexAttrib4Nubv(index, v); }
    internal static delegate* unmanaged<uint, byte*, void> _glVertexAttrib4Nubv = null;
    
    public static void glVertexAttrib4Nuiv(uint index, uint* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4Nuiv); _glVertexAttrib4Nuiv(index, v); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexAttrib4Nuiv = null;
    
    public static void glVertexAttrib4Nusv(uint index, ushort* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4Nusv); _glVertexAttrib4Nusv(index, v); }
    internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttrib4Nusv = null;
    
    public static void glVertexAttrib4bv(uint index, sbyte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4bv); _glVertexAttrib4bv(index, v); }
    internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttrib4bv = null;
    
    public static void glVertexAttrib4d(uint index, double x, double y, double z, double w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4d); _glVertexAttrib4d(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, double, double, double, double, void> _glVertexAttrib4d = null;
    
    public static void glVertexAttrib4dv(uint index, double* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4dv); _glVertexAttrib4dv(index, v); }
    internal static delegate* unmanaged<uint, double*, void> _glVertexAttrib4dv = null;
    
    public static void glVertexAttrib4f(uint index, float x, float y, float z, float w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4f); _glVertexAttrib4f(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, float, float, float, float, void> _glVertexAttrib4f = null;
    
    public static void glVertexAttrib4fv(uint index, float* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4fv); _glVertexAttrib4fv(index, v); }
    internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib4fv = null;
    
    public static void glVertexAttrib4iv(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4iv); _glVertexAttrib4iv(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glVertexAttrib4iv = null;
    
    public static void glVertexAttrib4s(uint index, short x, short y, short z, short w) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4s); _glVertexAttrib4s(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, short, short, short, short, void> _glVertexAttrib4s = null;
    
    public static void glVertexAttrib4sv(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4sv); _glVertexAttrib4sv(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttrib4sv = null;
    
    public static void glVertexAttrib4ubv(uint index, byte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4ubv); _glVertexAttrib4ubv(index, v); }
    internal static delegate* unmanaged<uint, byte*, void> _glVertexAttrib4ubv = null;
    
    public static void glVertexAttrib4uiv(uint index, uint* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4uiv); _glVertexAttrib4uiv(index, v); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexAttrib4uiv = null;
    
    public static void glVertexAttrib4usv(uint index, ushort* v) { QGLFeature.VerifyFunc((nint)_glVertexAttrib4usv); _glVertexAttrib4usv(index, v); }
    internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttrib4usv = null;
    
    public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glVertexAttribPointer); _glVertexAttribPointer(index, size, type, normalized, stride, pointer); }
    internal static delegate* unmanaged<uint, int, uint, bool, int, void*, void> _glVertexAttribPointer = null;
     #endregion
    
    internal static void Load()
    {
        _glBlendEquationSeparate = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBlendEquationSeparate");
        _glDrawBuffers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDrawBuffers");
        _glStencilOpSeparate = (delegate* unmanaged<uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glStencilOpSeparate");
        _glStencilFuncSeparate = (delegate* unmanaged<uint, uint, int, uint, void>)QuickGL.GetGLProcAddress("glStencilFuncSeparate");
        _glStencilMaskSeparate = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glStencilMaskSeparate");
        _glAttachShader = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glAttachShader");
        _glBindAttribLocation = (delegate* unmanaged<uint, uint, byte*, void>)QuickGL.GetGLProcAddress("glBindAttribLocation");
        _glCompileShader = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glCompileShader");
        _glCreateProgram = (delegate* unmanaged<uint>)QuickGL.GetGLProcAddress("glCreateProgram");
        _glCreateShader = (delegate* unmanaged<uint, uint>)QuickGL.GetGLProcAddress("glCreateShader");
        _glDeleteProgram = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDeleteProgram");
        _glDeleteShader = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDeleteShader");
        _glDetachShader = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glDetachShader");
        _glDisableVertexAttribArray = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDisableVertexAttribArray");
        _glEnableVertexAttribArray = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glEnableVertexAttribArray");
        _glGetActiveAttrib = (delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void>)QuickGL.GetGLProcAddress("glGetActiveAttrib");
        _glGetActiveUniform = (delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void>)QuickGL.GetGLProcAddress("glGetActiveUniform");
        _glGetAttachedShaders = (delegate* unmanaged<uint, int, int*, uint*, void>)QuickGL.GetGLProcAddress("glGetAttachedShaders");
        _glGetAttribLocation = (delegate* unmanaged<uint, byte*, int>)QuickGL.GetGLProcAddress("glGetAttribLocation");
        _glGetProgramiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetProgramiv");
        _glGetProgramInfoLog = (delegate* unmanaged<uint, int, int*, byte*, void>)QuickGL.GetGLProcAddress("glGetProgramInfoLog");
        _glGetShaderiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetShaderiv");
        _glGetShaderInfoLog = (delegate* unmanaged<uint, int, int*, byte*, void>)QuickGL.GetGLProcAddress("glGetShaderInfoLog");
        _glGetShaderSource = (delegate* unmanaged<uint, int, int*, byte*, void>)QuickGL.GetGLProcAddress("glGetShaderSource");
        _glGetUniformLocation = (delegate* unmanaged<uint, byte*, int>)QuickGL.GetGLProcAddress("glGetUniformLocation");
        _glGetUniformfv = (delegate* unmanaged<uint, int, float*, void>)QuickGL.GetGLProcAddress("glGetUniformfv");
        _glGetUniformiv = (delegate* unmanaged<uint, int, int*, void>)QuickGL.GetGLProcAddress("glGetUniformiv");
        _glGetVertexAttribdv = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribdv");
        _glGetVertexAttribfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribfv");
        _glGetVertexAttribiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribiv");
        _glGetVertexAttribPointerv = (delegate* unmanaged<uint, uint, void**, void>)QuickGL.GetGLProcAddress("glGetVertexAttribPointerv");
        _glIsProgram = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsProgram");
        _glIsShader = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsShader");
        _glLinkProgram = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glLinkProgram");
        _glShaderSource = (delegate* unmanaged<uint, int, byte**, int*, void>)QuickGL.GetGLProcAddress("glShaderSource");
        _glUseProgram = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glUseProgram");
        _glUniform1f = (delegate* unmanaged<int, float, void>)QuickGL.GetGLProcAddress("glUniform1f");
        _glUniform2f = (delegate* unmanaged<int, float, float, void>)QuickGL.GetGLProcAddress("glUniform2f");
        _glUniform3f = (delegate* unmanaged<int, float, float, float, void>)QuickGL.GetGLProcAddress("glUniform3f");
        _glUniform4f = (delegate* unmanaged<int, float, float, float, float, void>)QuickGL.GetGLProcAddress("glUniform4f");
        _glUniform1i = (delegate* unmanaged<int, int, void>)QuickGL.GetGLProcAddress("glUniform1i");
        _glUniform2i = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glUniform2i");
        _glUniform3i = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glUniform3i");
        _glUniform4i = (delegate* unmanaged<int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glUniform4i");
        _glUniform1fv = (delegate* unmanaged<int, int, float*, void>)QuickGL.GetGLProcAddress("glUniform1fv");
        _glUniform2fv = (delegate* unmanaged<int, int, float*, void>)QuickGL.GetGLProcAddress("glUniform2fv");
        _glUniform3fv = (delegate* unmanaged<int, int, float*, void>)QuickGL.GetGLProcAddress("glUniform3fv");
        _glUniform4fv = (delegate* unmanaged<int, int, float*, void>)QuickGL.GetGLProcAddress("glUniform4fv");
        _glUniform1iv = (delegate* unmanaged<int, int, int*, void>)QuickGL.GetGLProcAddress("glUniform1iv");
        _glUniform2iv = (delegate* unmanaged<int, int, int*, void>)QuickGL.GetGLProcAddress("glUniform2iv");
        _glUniform3iv = (delegate* unmanaged<int, int, int*, void>)QuickGL.GetGLProcAddress("glUniform3iv");
        _glUniform4iv = (delegate* unmanaged<int, int, int*, void>)QuickGL.GetGLProcAddress("glUniform4iv");
        _glUniformMatrix2fv = (delegate* unmanaged<int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glUniformMatrix2fv");
        _glUniformMatrix3fv = (delegate* unmanaged<int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glUniformMatrix3fv");
        _glUniformMatrix4fv = (delegate* unmanaged<int, int, bool, float*, void>)QuickGL.GetGLProcAddress("glUniformMatrix4fv");
        _glValidateProgram = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glValidateProgram");
        _glVertexAttrib1d = (delegate* unmanaged<uint, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib1d");
        _glVertexAttrib1dv = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib1dv");
        _glVertexAttrib1f = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib1f");
        _glVertexAttrib1fv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib1fv");
        _glVertexAttrib1s = (delegate* unmanaged<uint, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib1s");
        _glVertexAttrib1sv = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib1sv");
        _glVertexAttrib2d = (delegate* unmanaged<uint, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib2d");
        _glVertexAttrib2dv = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib2dv");
        _glVertexAttrib2f = (delegate* unmanaged<uint, float, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib2f");
        _glVertexAttrib2fv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib2fv");
        _glVertexAttrib2s = (delegate* unmanaged<uint, short, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib2s");
        _glVertexAttrib2sv = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib2sv");
        _glVertexAttrib3d = (delegate* unmanaged<uint, double, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib3d");
        _glVertexAttrib3dv = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib3dv");
        _glVertexAttrib3f = (delegate* unmanaged<uint, float, float, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib3f");
        _glVertexAttrib3fv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib3fv");
        _glVertexAttrib3s = (delegate* unmanaged<uint, short, short, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib3s");
        _glVertexAttrib3sv = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib3sv");
        _glVertexAttrib4Nbv = (delegate* unmanaged<uint, sbyte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4Nbv");
        _glVertexAttrib4Niv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4Niv");
        _glVertexAttrib4Nsv = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4Nsv");
        _glVertexAttrib4Nub = (delegate* unmanaged<uint, byte, byte, byte, byte, void>)QuickGL.GetGLProcAddress("glVertexAttrib4Nub");
        _glVertexAttrib4Nubv = (delegate* unmanaged<uint, byte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4Nubv");
        _glVertexAttrib4Nuiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4Nuiv");
        _glVertexAttrib4Nusv = (delegate* unmanaged<uint, ushort*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4Nusv");
        _glVertexAttrib4bv = (delegate* unmanaged<uint, sbyte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4bv");
        _glVertexAttrib4d = (delegate* unmanaged<uint, double, double, double, double, void>)QuickGL.GetGLProcAddress("glVertexAttrib4d");
        _glVertexAttrib4dv = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4dv");
        _glVertexAttrib4f = (delegate* unmanaged<uint, float, float, float, float, void>)QuickGL.GetGLProcAddress("glVertexAttrib4f");
        _glVertexAttrib4fv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4fv");
        _glVertexAttrib4iv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4iv");
        _glVertexAttrib4s = (delegate* unmanaged<uint, short, short, short, short, void>)QuickGL.GetGLProcAddress("glVertexAttrib4s");
        _glVertexAttrib4sv = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4sv");
        _glVertexAttrib4ubv = (delegate* unmanaged<uint, byte*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4ubv");
        _glVertexAttrib4uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4uiv");
        _glVertexAttrib4usv = (delegate* unmanaged<uint, ushort*, void>)QuickGL.GetGLProcAddress("glVertexAttrib4usv");
        _glVertexAttribPointer = (delegate* unmanaged<uint, int, uint, bool, int, void*, void>)QuickGL.GetGLProcAddress("glVertexAttribPointer");
    }
    
    internal static void Unload()
    {
        _glBlendEquationSeparate = null;
        _glDrawBuffers = null;
        _glStencilOpSeparate = null;
        _glStencilFuncSeparate = null;
        _glStencilMaskSeparate = null;
        _glAttachShader = null;
        _glBindAttribLocation = null;
        _glCompileShader = null;
        _glCreateProgram = null;
        _glCreateShader = null;
        _glDeleteProgram = null;
        _glDeleteShader = null;
        _glDetachShader = null;
        _glDisableVertexAttribArray = null;
        _glEnableVertexAttribArray = null;
        _glGetActiveAttrib = null;
        _glGetActiveUniform = null;
        _glGetAttachedShaders = null;
        _glGetAttribLocation = null;
        _glGetProgramiv = null;
        _glGetProgramInfoLog = null;
        _glGetShaderiv = null;
        _glGetShaderInfoLog = null;
        _glGetShaderSource = null;
        _glGetUniformLocation = null;
        _glGetUniformfv = null;
        _glGetUniformiv = null;
        _glGetVertexAttribdv = null;
        _glGetVertexAttribfv = null;
        _glGetVertexAttribiv = null;
        _glGetVertexAttribPointerv = null;
        _glIsProgram = null;
        _glIsShader = null;
        _glLinkProgram = null;
        _glShaderSource = null;
        _glUseProgram = null;
        _glUniform1f = null;
        _glUniform2f = null;
        _glUniform3f = null;
        _glUniform4f = null;
        _glUniform1i = null;
        _glUniform2i = null;
        _glUniform3i = null;
        _glUniform4i = null;
        _glUniform1fv = null;
        _glUniform2fv = null;
        _glUniform3fv = null;
        _glUniform4fv = null;
        _glUniform1iv = null;
        _glUniform2iv = null;
        _glUniform3iv = null;
        _glUniform4iv = null;
        _glUniformMatrix2fv = null;
        _glUniformMatrix3fv = null;
        _glUniformMatrix4fv = null;
        _glValidateProgram = null;
        _glVertexAttrib1d = null;
        _glVertexAttrib1dv = null;
        _glVertexAttrib1f = null;
        _glVertexAttrib1fv = null;
        _glVertexAttrib1s = null;
        _glVertexAttrib1sv = null;
        _glVertexAttrib2d = null;
        _glVertexAttrib2dv = null;
        _glVertexAttrib2f = null;
        _glVertexAttrib2fv = null;
        _glVertexAttrib2s = null;
        _glVertexAttrib2sv = null;
        _glVertexAttrib3d = null;
        _glVertexAttrib3dv = null;
        _glVertexAttrib3f = null;
        _glVertexAttrib3fv = null;
        _glVertexAttrib3s = null;
        _glVertexAttrib3sv = null;
        _glVertexAttrib4Nbv = null;
        _glVertexAttrib4Niv = null;
        _glVertexAttrib4Nsv = null;
        _glVertexAttrib4Nub = null;
        _glVertexAttrib4Nubv = null;
        _glVertexAttrib4Nuiv = null;
        _glVertexAttrib4Nusv = null;
        _glVertexAttrib4bv = null;
        _glVertexAttrib4d = null;
        _glVertexAttrib4dv = null;
        _glVertexAttrib4f = null;
        _glVertexAttrib4fv = null;
        _glVertexAttrib4iv = null;
        _glVertexAttrib4s = null;
        _glVertexAttrib4sv = null;
        _glVertexAttrib4ubv = null;
        _glVertexAttrib4uiv = null;
        _glVertexAttrib4usv = null;
        _glVertexAttribPointer = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_VERSION_2_0", false, false);
}
