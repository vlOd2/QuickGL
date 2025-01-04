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

// Bindings generated at 2025-01-04 01:08:51.537106
namespace QuickGLNS.Bindings
{
    [GLFeature]
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
        [QGLNativeAPI("glBlendEquationSeparate")] public static delegate* unmanaged<uint, uint, void> glBlendEquationSeparate;
        [QGLNativeAPI("glDrawBuffers")] public static delegate* unmanaged<int, uint*, void> glDrawBuffers;
        [QGLNativeAPI("glStencilOpSeparate")] public static delegate* unmanaged<uint, uint, uint, uint, void> glStencilOpSeparate;
        [QGLNativeAPI("glStencilFuncSeparate")] public static delegate* unmanaged<uint, uint, int, uint, void> glStencilFuncSeparate;
        [QGLNativeAPI("glStencilMaskSeparate")] public static delegate* unmanaged<uint, uint, void> glStencilMaskSeparate;
        [QGLNativeAPI("glAttachShader")] public static delegate* unmanaged<uint, uint, void> glAttachShader;
        [QGLNativeAPI("glBindAttribLocation")] public static delegate* unmanaged<uint, uint, char*, void> glBindAttribLocation;
        [QGLNativeAPI("glCompileShader")] public static delegate* unmanaged<uint, void> glCompileShader;
        [QGLNativeAPI("glCreateProgram")] public static delegate* unmanaged<uint> glCreateProgram;
        [QGLNativeAPI("glCreateShader")] public static delegate* unmanaged<uint, uint> glCreateShader;
        [QGLNativeAPI("glDeleteProgram")] public static delegate* unmanaged<uint, void> glDeleteProgram;
        [QGLNativeAPI("glDeleteShader")] public static delegate* unmanaged<uint, void> glDeleteShader;
        [QGLNativeAPI("glDetachShader")] public static delegate* unmanaged<uint, uint, void> glDetachShader;
        [QGLNativeAPI("glDisableVertexAttribArray")] public static delegate* unmanaged<uint, void> glDisableVertexAttribArray;
        [QGLNativeAPI("glEnableVertexAttribArray")] public static delegate* unmanaged<uint, void> glEnableVertexAttribArray;
        [QGLNativeAPI("glGetActiveAttrib")] public static delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void> glGetActiveAttrib;
        [QGLNativeAPI("glGetActiveUniform")] public static delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void> glGetActiveUniform;
        [QGLNativeAPI("glGetAttachedShaders")] public static delegate* unmanaged<uint, int, int*, uint*, void> glGetAttachedShaders;
        [QGLNativeAPI("glGetAttribLocation")] public static delegate* unmanaged<uint, char*, int> glGetAttribLocation;
        [QGLNativeAPI("glGetProgramiv")] public static delegate* unmanaged<uint, uint, int*, void> glGetProgramiv;
        [QGLNativeAPI("glGetProgramInfoLog")] public static delegate* unmanaged<uint, int, int*, char*, void> glGetProgramInfoLog;
        [QGLNativeAPI("glGetShaderiv")] public static delegate* unmanaged<uint, uint, int*, void> glGetShaderiv;
        [QGLNativeAPI("glGetShaderInfoLog")] public static delegate* unmanaged<uint, int, int*, char*, void> glGetShaderInfoLog;
        [QGLNativeAPI("glGetShaderSource")] public static delegate* unmanaged<uint, int, int*, char*, void> glGetShaderSource;
        [QGLNativeAPI("glGetUniformLocation")] public static delegate* unmanaged<uint, char*, int> glGetUniformLocation;
        [QGLNativeAPI("glGetUniformfv")] public static delegate* unmanaged<uint, int, float*, void> glGetUniformfv;
        [QGLNativeAPI("glGetUniformiv")] public static delegate* unmanaged<uint, int, int*, void> glGetUniformiv;
        [QGLNativeAPI("glGetVertexAttribdv")] public static delegate* unmanaged<uint, uint, double*, void> glGetVertexAttribdv;
        [QGLNativeAPI("glGetVertexAttribfv")] public static delegate* unmanaged<uint, uint, float*, void> glGetVertexAttribfv;
        [QGLNativeAPI("glGetVertexAttribiv")] public static delegate* unmanaged<uint, uint, int*, void> glGetVertexAttribiv;
        [QGLNativeAPI("glGetVertexAttribPointerv")] public static delegate* unmanaged<uint, uint, void**, void> glGetVertexAttribPointerv;
        [QGLNativeAPI("glIsProgram")] public static delegate* unmanaged<uint, bool> glIsProgram;
        [QGLNativeAPI("glIsShader")] public static delegate* unmanaged<uint, bool> glIsShader;
        [QGLNativeAPI("glLinkProgram")] public static delegate* unmanaged<uint, void> glLinkProgram;
        [QGLNativeAPI("glShaderSource")] public static delegate* unmanaged<uint, int, char**, int*, void> glShaderSource;
        [QGLNativeAPI("glUseProgram")] public static delegate* unmanaged<uint, void> glUseProgram;
        [QGLNativeAPI("glUniform1f")] public static delegate* unmanaged<int, float, void> glUniform1f;
        [QGLNativeAPI("glUniform2f")] public static delegate* unmanaged<int, float, float, void> glUniform2f;
        [QGLNativeAPI("glUniform3f")] public static delegate* unmanaged<int, float, float, float, void> glUniform3f;
        [QGLNativeAPI("glUniform4f")] public static delegate* unmanaged<int, float, float, float, float, void> glUniform4f;
        [QGLNativeAPI("glUniform1i")] public static delegate* unmanaged<int, int, void> glUniform1i;
        [QGLNativeAPI("glUniform2i")] public static delegate* unmanaged<int, int, int, void> glUniform2i;
        [QGLNativeAPI("glUniform3i")] public static delegate* unmanaged<int, int, int, int, void> glUniform3i;
        [QGLNativeAPI("glUniform4i")] public static delegate* unmanaged<int, int, int, int, int, void> glUniform4i;
        [QGLNativeAPI("glUniform1fv")] public static delegate* unmanaged<int, int, float*, void> glUniform1fv;
        [QGLNativeAPI("glUniform2fv")] public static delegate* unmanaged<int, int, float*, void> glUniform2fv;
        [QGLNativeAPI("glUniform3fv")] public static delegate* unmanaged<int, int, float*, void> glUniform3fv;
        [QGLNativeAPI("glUniform4fv")] public static delegate* unmanaged<int, int, float*, void> glUniform4fv;
        [QGLNativeAPI("glUniform1iv")] public static delegate* unmanaged<int, int, int*, void> glUniform1iv;
        [QGLNativeAPI("glUniform2iv")] public static delegate* unmanaged<int, int, int*, void> glUniform2iv;
        [QGLNativeAPI("glUniform3iv")] public static delegate* unmanaged<int, int, int*, void> glUniform3iv;
        [QGLNativeAPI("glUniform4iv")] public static delegate* unmanaged<int, int, int*, void> glUniform4iv;
        [QGLNativeAPI("glUniformMatrix2fv")] public static delegate* unmanaged<int, int, bool, float*, void> glUniformMatrix2fv;
        [QGLNativeAPI("glUniformMatrix3fv")] public static delegate* unmanaged<int, int, bool, float*, void> glUniformMatrix3fv;
        [QGLNativeAPI("glUniformMatrix4fv")] public static delegate* unmanaged<int, int, bool, float*, void> glUniformMatrix4fv;
        [QGLNativeAPI("glValidateProgram")] public static delegate* unmanaged<uint, void> glValidateProgram;
        [QGLNativeAPI("glVertexAttrib1d")] public static delegate* unmanaged<uint, double, void> glVertexAttrib1d;
        [QGLNativeAPI("glVertexAttrib1dv")] public static delegate* unmanaged<uint, double*, void> glVertexAttrib1dv;
        [QGLNativeAPI("glVertexAttrib1f")] public static delegate* unmanaged<uint, float, void> glVertexAttrib1f;
        [QGLNativeAPI("glVertexAttrib1fv")] public static delegate* unmanaged<uint, float*, void> glVertexAttrib1fv;
        [QGLNativeAPI("glVertexAttrib1s")] public static delegate* unmanaged<uint, short, void> glVertexAttrib1s;
        [QGLNativeAPI("glVertexAttrib1sv")] public static delegate* unmanaged<uint, short*, void> glVertexAttrib1sv;
        [QGLNativeAPI("glVertexAttrib2d")] public static delegate* unmanaged<uint, double, double, void> glVertexAttrib2d;
        [QGLNativeAPI("glVertexAttrib2dv")] public static delegate* unmanaged<uint, double*, void> glVertexAttrib2dv;
        [QGLNativeAPI("glVertexAttrib2f")] public static delegate* unmanaged<uint, float, float, void> glVertexAttrib2f;
        [QGLNativeAPI("glVertexAttrib2fv")] public static delegate* unmanaged<uint, float*, void> glVertexAttrib2fv;
        [QGLNativeAPI("glVertexAttrib2s")] public static delegate* unmanaged<uint, short, short, void> glVertexAttrib2s;
        [QGLNativeAPI("glVertexAttrib2sv")] public static delegate* unmanaged<uint, short*, void> glVertexAttrib2sv;
        [QGLNativeAPI("glVertexAttrib3d")] public static delegate* unmanaged<uint, double, double, double, void> glVertexAttrib3d;
        [QGLNativeAPI("glVertexAttrib3dv")] public static delegate* unmanaged<uint, double*, void> glVertexAttrib3dv;
        [QGLNativeAPI("glVertexAttrib3f")] public static delegate* unmanaged<uint, float, float, float, void> glVertexAttrib3f;
        [QGLNativeAPI("glVertexAttrib3fv")] public static delegate* unmanaged<uint, float*, void> glVertexAttrib3fv;
        [QGLNativeAPI("glVertexAttrib3s")] public static delegate* unmanaged<uint, short, short, short, void> glVertexAttrib3s;
        [QGLNativeAPI("glVertexAttrib3sv")] public static delegate* unmanaged<uint, short*, void> glVertexAttrib3sv;
        [QGLNativeAPI("glVertexAttrib4Nbv")] public static delegate* unmanaged<uint, sbyte*, void> glVertexAttrib4Nbv;
        [QGLNativeAPI("glVertexAttrib4Niv")] public static delegate* unmanaged<uint, int*, void> glVertexAttrib4Niv;
        [QGLNativeAPI("glVertexAttrib4Nsv")] public static delegate* unmanaged<uint, short*, void> glVertexAttrib4Nsv;
        [QGLNativeAPI("glVertexAttrib4Nub")] public static delegate* unmanaged<uint, byte, byte, byte, byte, void> glVertexAttrib4Nub;
        [QGLNativeAPI("glVertexAttrib4Nubv")] public static delegate* unmanaged<uint, byte*, void> glVertexAttrib4Nubv;
        [QGLNativeAPI("glVertexAttrib4Nuiv")] public static delegate* unmanaged<uint, uint*, void> glVertexAttrib4Nuiv;
        [QGLNativeAPI("glVertexAttrib4Nusv")] public static delegate* unmanaged<uint, ushort*, void> glVertexAttrib4Nusv;
        [QGLNativeAPI("glVertexAttrib4bv")] public static delegate* unmanaged<uint, sbyte*, void> glVertexAttrib4bv;
        [QGLNativeAPI("glVertexAttrib4d")] public static delegate* unmanaged<uint, double, double, double, double, void> glVertexAttrib4d;
        [QGLNativeAPI("glVertexAttrib4dv")] public static delegate* unmanaged<uint, double*, void> glVertexAttrib4dv;
        [QGLNativeAPI("glVertexAttrib4f")] public static delegate* unmanaged<uint, float, float, float, float, void> glVertexAttrib4f;
        [QGLNativeAPI("glVertexAttrib4fv")] public static delegate* unmanaged<uint, float*, void> glVertexAttrib4fv;
        [QGLNativeAPI("glVertexAttrib4iv")] public static delegate* unmanaged<uint, int*, void> glVertexAttrib4iv;
        [QGLNativeAPI("glVertexAttrib4s")] public static delegate* unmanaged<uint, short, short, short, short, void> glVertexAttrib4s;
        [QGLNativeAPI("glVertexAttrib4sv")] public static delegate* unmanaged<uint, short*, void> glVertexAttrib4sv;
        [QGLNativeAPI("glVertexAttrib4ubv")] public static delegate* unmanaged<uint, byte*, void> glVertexAttrib4ubv;
        [QGLNativeAPI("glVertexAttrib4uiv")] public static delegate* unmanaged<uint, uint*, void> glVertexAttrib4uiv;
        [QGLNativeAPI("glVertexAttrib4usv")] public static delegate* unmanaged<uint, ushort*, void> glVertexAttrib4usv;
        [QGLNativeAPI("glVertexAttribPointer")] public static delegate* unmanaged<uint, int, uint, bool, int, void*, void> glVertexAttribPointer;
        #endregion
    }
}
