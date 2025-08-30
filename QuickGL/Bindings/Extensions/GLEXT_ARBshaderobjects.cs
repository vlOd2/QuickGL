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

// Bindings generated at 2025-08-30 15:45:08.677058
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_shader_objects", true, false)]
public static unsafe class GLEXT_ARBshaderobjects
{
    #region Enums
    public const int GL_PROGRAM_OBJECT_ARB = 0x8B40;
    public const int GL_SHADER_OBJECT_ARB = 0x8B48;
    public const int GL_OBJECT_TYPE_ARB = 0x8B4E;
    public const int GL_OBJECT_SUBTYPE_ARB = 0x8B4F;
    public const int GL_FLOAT_VEC2_ARB = 0x8B50;
    public const int GL_FLOAT_VEC3_ARB = 0x8B51;
    public const int GL_FLOAT_VEC4_ARB = 0x8B52;
    public const int GL_INT_VEC2_ARB = 0x8B53;
    public const int GL_INT_VEC3_ARB = 0x8B54;
    public const int GL_INT_VEC4_ARB = 0x8B55;
    public const int GL_BOOL_ARB = 0x8B56;
    public const int GL_BOOL_VEC2_ARB = 0x8B57;
    public const int GL_BOOL_VEC3_ARB = 0x8B58;
    public const int GL_BOOL_VEC4_ARB = 0x8B59;
    public const int GL_FLOAT_MAT2_ARB = 0x8B5A;
    public const int GL_FLOAT_MAT3_ARB = 0x8B5B;
    public const int GL_FLOAT_MAT4_ARB = 0x8B5C;
    public const int GL_SAMPLER_1D_ARB = 0x8B5D;
    public const int GL_SAMPLER_2D_ARB = 0x8B5E;
    public const int GL_SAMPLER_3D_ARB = 0x8B5F;
    public const int GL_SAMPLER_CUBE_ARB = 0x8B60;
    public const int GL_SAMPLER_1D_SHADOW_ARB = 0x8B61;
    public const int GL_SAMPLER_2D_SHADOW_ARB = 0x8B62;
    public const int GL_SAMPLER_2D_RECT_ARB = 0x8B63;
    public const int GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64;
    public const int GL_OBJECT_DELETE_STATUS_ARB = 0x8B80;
    public const int GL_OBJECT_COMPILE_STATUS_ARB = 0x8B81;
    public const int GL_OBJECT_LINK_STATUS_ARB = 0x8B82;
    public const int GL_OBJECT_VALIDATE_STATUS_ARB = 0x8B83;
    public const int GL_OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84;
    public const int GL_OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85;
    public const int GL_OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86;
    public const int GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87;
    public const int GL_OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88;
    #endregion
    
    #region Commands
    public static void glDeleteObjectARB(nint obj) { QGLNativeAPI.Verify((nint)_glDeleteObjectARB); _glDeleteObjectARB(obj); }
    [QGLNativeAPI("glDeleteObjectARB")] internal static delegate* unmanaged<nint, void> _glDeleteObjectARB = null;
    
    public static nint glGetHandleARB(uint pname) { QGLNativeAPI.Verify((nint)_glGetHandleARB); return _glGetHandleARB(pname); }
    [QGLNativeAPI("glGetHandleARB")] internal static delegate* unmanaged<uint, nint> _glGetHandleARB = null;
    
    public static void glDetachObjectARB(nint containerObj, nint attachedObj) { QGLNativeAPI.Verify((nint)_glDetachObjectARB); _glDetachObjectARB(containerObj, attachedObj); }
    [QGLNativeAPI("glDetachObjectARB")] internal static delegate* unmanaged<nint, nint, void> _glDetachObjectARB = null;
    
    public static nint glCreateShaderObjectARB(uint shaderType) { QGLNativeAPI.Verify((nint)_glCreateShaderObjectARB); return _glCreateShaderObjectARB(shaderType); }
    [QGLNativeAPI("glCreateShaderObjectARB")] internal static delegate* unmanaged<uint, nint> _glCreateShaderObjectARB = null;
    
    public static void glShaderSourceARB(nint shaderObj, int count, byte** @string, int* length) { QGLNativeAPI.Verify((nint)_glShaderSourceARB); _glShaderSourceARB(shaderObj, count, @string, length); }
    [QGLNativeAPI("glShaderSourceARB")] internal static delegate* unmanaged<nint, int, byte**, int*, void> _glShaderSourceARB = null;
    
    public static void glCompileShaderARB(nint shaderObj) { QGLNativeAPI.Verify((nint)_glCompileShaderARB); _glCompileShaderARB(shaderObj); }
    [QGLNativeAPI("glCompileShaderARB")] internal static delegate* unmanaged<nint, void> _glCompileShaderARB = null;
    
    public static nint glCreateProgramObjectARB() { QGLNativeAPI.Verify((nint)_glCreateProgramObjectARB); return _glCreateProgramObjectARB(); }
    [QGLNativeAPI("glCreateProgramObjectARB")] internal static delegate* unmanaged<nint> _glCreateProgramObjectARB = null;
    
    public static void glAttachObjectARB(nint containerObj, nint obj) { QGLNativeAPI.Verify((nint)_glAttachObjectARB); _glAttachObjectARB(containerObj, obj); }
    [QGLNativeAPI("glAttachObjectARB")] internal static delegate* unmanaged<nint, nint, void> _glAttachObjectARB = null;
    
    public static void glLinkProgramARB(nint programObj) { QGLNativeAPI.Verify((nint)_glLinkProgramARB); _glLinkProgramARB(programObj); }
    [QGLNativeAPI("glLinkProgramARB")] internal static delegate* unmanaged<nint, void> _glLinkProgramARB = null;
    
    public static void glUseProgramObjectARB(nint programObj) { QGLNativeAPI.Verify((nint)_glUseProgramObjectARB); _glUseProgramObjectARB(programObj); }
    [QGLNativeAPI("glUseProgramObjectARB")] internal static delegate* unmanaged<nint, void> _glUseProgramObjectARB = null;
    
    public static void glValidateProgramARB(nint programObj) { QGLNativeAPI.Verify((nint)_glValidateProgramARB); _glValidateProgramARB(programObj); }
    [QGLNativeAPI("glValidateProgramARB")] internal static delegate* unmanaged<nint, void> _glValidateProgramARB = null;
    
    public static void glUniform1fARB(int location, float v0) { QGLNativeAPI.Verify((nint)_glUniform1fARB); _glUniform1fARB(location, v0); }
    [QGLNativeAPI("glUniform1fARB")] internal static delegate* unmanaged<int, float, void> _glUniform1fARB = null;
    
    public static void glUniform2fARB(int location, float v0, float v1) { QGLNativeAPI.Verify((nint)_glUniform2fARB); _glUniform2fARB(location, v0, v1); }
    [QGLNativeAPI("glUniform2fARB")] internal static delegate* unmanaged<int, float, float, void> _glUniform2fARB = null;
    
    public static void glUniform3fARB(int location, float v0, float v1, float v2) { QGLNativeAPI.Verify((nint)_glUniform3fARB); _glUniform3fARB(location, v0, v1, v2); }
    [QGLNativeAPI("glUniform3fARB")] internal static delegate* unmanaged<int, float, float, float, void> _glUniform3fARB = null;
    
    public static void glUniform4fARB(int location, float v0, float v1, float v2, float v3) { QGLNativeAPI.Verify((nint)_glUniform4fARB); _glUniform4fARB(location, v0, v1, v2, v3); }
    [QGLNativeAPI("glUniform4fARB")] internal static delegate* unmanaged<int, float, float, float, float, void> _glUniform4fARB = null;
    
    public static void glUniform1iARB(int location, int v0) { QGLNativeAPI.Verify((nint)_glUniform1iARB); _glUniform1iARB(location, v0); }
    [QGLNativeAPI("glUniform1iARB")] internal static delegate* unmanaged<int, int, void> _glUniform1iARB = null;
    
    public static void glUniform2iARB(int location, int v0, int v1) { QGLNativeAPI.Verify((nint)_glUniform2iARB); _glUniform2iARB(location, v0, v1); }
    [QGLNativeAPI("glUniform2iARB")] internal static delegate* unmanaged<int, int, int, void> _glUniform2iARB = null;
    
    public static void glUniform3iARB(int location, int v0, int v1, int v2) { QGLNativeAPI.Verify((nint)_glUniform3iARB); _glUniform3iARB(location, v0, v1, v2); }
    [QGLNativeAPI("glUniform3iARB")] internal static delegate* unmanaged<int, int, int, int, void> _glUniform3iARB = null;
    
    public static void glUniform4iARB(int location, int v0, int v1, int v2, int v3) { QGLNativeAPI.Verify((nint)_glUniform4iARB); _glUniform4iARB(location, v0, v1, v2, v3); }
    [QGLNativeAPI("glUniform4iARB")] internal static delegate* unmanaged<int, int, int, int, int, void> _glUniform4iARB = null;
    
    public static void glUniform1fvARB(int location, int count, float* value) { QGLNativeAPI.Verify((nint)_glUniform1fvARB); _glUniform1fvARB(location, count, value); }
    [QGLNativeAPI("glUniform1fvARB")] internal static delegate* unmanaged<int, int, float*, void> _glUniform1fvARB = null;
    
    public static void glUniform2fvARB(int location, int count, float* value) { QGLNativeAPI.Verify((nint)_glUniform2fvARB); _glUniform2fvARB(location, count, value); }
    [QGLNativeAPI("glUniform2fvARB")] internal static delegate* unmanaged<int, int, float*, void> _glUniform2fvARB = null;
    
    public static void glUniform3fvARB(int location, int count, float* value) { QGLNativeAPI.Verify((nint)_glUniform3fvARB); _glUniform3fvARB(location, count, value); }
    [QGLNativeAPI("glUniform3fvARB")] internal static delegate* unmanaged<int, int, float*, void> _glUniform3fvARB = null;
    
    public static void glUniform4fvARB(int location, int count, float* value) { QGLNativeAPI.Verify((nint)_glUniform4fvARB); _glUniform4fvARB(location, count, value); }
    [QGLNativeAPI("glUniform4fvARB")] internal static delegate* unmanaged<int, int, float*, void> _glUniform4fvARB = null;
    
    public static void glUniform1ivARB(int location, int count, int* value) { QGLNativeAPI.Verify((nint)_glUniform1ivARB); _glUniform1ivARB(location, count, value); }
    [QGLNativeAPI("glUniform1ivARB")] internal static delegate* unmanaged<int, int, int*, void> _glUniform1ivARB = null;
    
    public static void glUniform2ivARB(int location, int count, int* value) { QGLNativeAPI.Verify((nint)_glUniform2ivARB); _glUniform2ivARB(location, count, value); }
    [QGLNativeAPI("glUniform2ivARB")] internal static delegate* unmanaged<int, int, int*, void> _glUniform2ivARB = null;
    
    public static void glUniform3ivARB(int location, int count, int* value) { QGLNativeAPI.Verify((nint)_glUniform3ivARB); _glUniform3ivARB(location, count, value); }
    [QGLNativeAPI("glUniform3ivARB")] internal static delegate* unmanaged<int, int, int*, void> _glUniform3ivARB = null;
    
    public static void glUniform4ivARB(int location, int count, int* value) { QGLNativeAPI.Verify((nint)_glUniform4ivARB); _glUniform4ivARB(location, count, value); }
    [QGLNativeAPI("glUniform4ivARB")] internal static delegate* unmanaged<int, int, int*, void> _glUniform4ivARB = null;
    
    public static void glUniformMatrix2fvARB(int location, int count, bool transpose, float* value) { QGLNativeAPI.Verify((nint)_glUniformMatrix2fvARB); _glUniformMatrix2fvARB(location, count, transpose, value); }
    [QGLNativeAPI("glUniformMatrix2fvARB")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix2fvARB = null;
    
    public static void glUniformMatrix3fvARB(int location, int count, bool transpose, float* value) { QGLNativeAPI.Verify((nint)_glUniformMatrix3fvARB); _glUniformMatrix3fvARB(location, count, transpose, value); }
    [QGLNativeAPI("glUniformMatrix3fvARB")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix3fvARB = null;
    
    public static void glUniformMatrix4fvARB(int location, int count, bool transpose, float* value) { QGLNativeAPI.Verify((nint)_glUniformMatrix4fvARB); _glUniformMatrix4fvARB(location, count, transpose, value); }
    [QGLNativeAPI("glUniformMatrix4fvARB")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix4fvARB = null;
    
    public static void glGetObjectParameterfvARB(nint obj, uint pname, float* @params) { QGLNativeAPI.Verify((nint)_glGetObjectParameterfvARB); _glGetObjectParameterfvARB(obj, pname, @params); }
    [QGLNativeAPI("glGetObjectParameterfvARB")] internal static delegate* unmanaged<nint, uint, float*, void> _glGetObjectParameterfvARB = null;
    
    public static void glGetObjectParameterivARB(nint obj, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetObjectParameterivARB); _glGetObjectParameterivARB(obj, pname, @params); }
    [QGLNativeAPI("glGetObjectParameterivARB")] internal static delegate* unmanaged<nint, uint, int*, void> _glGetObjectParameterivARB = null;
    
    public static void glGetInfoLogARB(nint obj, int maxLength, int* length, byte* infoLog) { QGLNativeAPI.Verify((nint)_glGetInfoLogARB); _glGetInfoLogARB(obj, maxLength, length, infoLog); }
    [QGLNativeAPI("glGetInfoLogARB")] internal static delegate* unmanaged<nint, int, int*, byte*, void> _glGetInfoLogARB = null;
    
    public static void glGetAttachedObjectsARB(nint containerObj, int maxCount, int* count, nint* obj) { QGLNativeAPI.Verify((nint)_glGetAttachedObjectsARB); _glGetAttachedObjectsARB(containerObj, maxCount, count, obj); }
    [QGLNativeAPI("glGetAttachedObjectsARB")] internal static delegate* unmanaged<nint, int, int*, nint*, void> _glGetAttachedObjectsARB = null;
    
    public static int glGetUniformLocationARB(nint programObj, byte* name) { QGLNativeAPI.Verify((nint)_glGetUniformLocationARB); return _glGetUniformLocationARB(programObj, name); }
    [QGLNativeAPI("glGetUniformLocationARB")] internal static delegate* unmanaged<nint, byte*, int> _glGetUniformLocationARB = null;
    
    public static void glGetActiveUniformARB(nint programObj, uint index, int maxLength, int* length, int* size, uint* type, byte* name) { QGLNativeAPI.Verify((nint)_glGetActiveUniformARB); _glGetActiveUniformARB(programObj, index, maxLength, length, size, type, name); }
    [QGLNativeAPI("glGetActiveUniformARB")] internal static delegate* unmanaged<nint, uint, int, int*, int*, uint*, byte*, void> _glGetActiveUniformARB = null;
    
    public static void glGetUniformfvARB(nint programObj, int location, float* @params) { QGLNativeAPI.Verify((nint)_glGetUniformfvARB); _glGetUniformfvARB(programObj, location, @params); }
    [QGLNativeAPI("glGetUniformfvARB")] internal static delegate* unmanaged<nint, int, float*, void> _glGetUniformfvARB = null;
    
    public static void glGetUniformivARB(nint programObj, int location, int* @params) { QGLNativeAPI.Verify((nint)_glGetUniformivARB); _glGetUniformivARB(programObj, location, @params); }
    [QGLNativeAPI("glGetUniformivARB")] internal static delegate* unmanaged<nint, int, int*, void> _glGetUniformivARB = null;
    
    public static void glGetShaderSourceARB(nint obj, int maxLength, int* length, byte* source) { QGLNativeAPI.Verify((nint)_glGetShaderSourceARB); _glGetShaderSourceARB(obj, maxLength, length, source); }
    [QGLNativeAPI("glGetShaderSourceARB")] internal static delegate* unmanaged<nint, int, int*, byte*, void> _glGetShaderSourceARB = null;
     #endregion
}
