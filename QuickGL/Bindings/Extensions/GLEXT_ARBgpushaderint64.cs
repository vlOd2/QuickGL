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

// Bindings generated at 2025-08-30 15:45:08.538481
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_gpu_shader_int64", true, false)]
public static unsafe class GLEXT_ARBgpushaderint64
{
    #region Enums
    public const int GL_INT64_ARB = 0x140E;
    public const int GL_UNSIGNED_INT64_ARB = 0x140F;
    public const int GL_INT64_VEC2_ARB = 0x8FE9;
    public const int GL_INT64_VEC3_ARB = 0x8FEA;
    public const int GL_INT64_VEC4_ARB = 0x8FEB;
    public const int GL_UNSIGNED_INT64_VEC2_ARB = 0x8FF5;
    public const int GL_UNSIGNED_INT64_VEC3_ARB = 0x8FF6;
    public const int GL_UNSIGNED_INT64_VEC4_ARB = 0x8FF7;
    #endregion
    
    #region Commands
    public static void glUniform1i64ARB(int location, long x) { QGLNativeAPI.Verify((nint)_glUniform1i64ARB); _glUniform1i64ARB(location, x); }
    [QGLNativeAPI("glUniform1i64ARB")] internal static delegate* unmanaged<int, long, void> _glUniform1i64ARB = null;
    
    public static void glUniform2i64ARB(int location, long x, long y) { QGLNativeAPI.Verify((nint)_glUniform2i64ARB); _glUniform2i64ARB(location, x, y); }
    [QGLNativeAPI("glUniform2i64ARB")] internal static delegate* unmanaged<int, long, long, void> _glUniform2i64ARB = null;
    
    public static void glUniform3i64ARB(int location, long x, long y, long z) { QGLNativeAPI.Verify((nint)_glUniform3i64ARB); _glUniform3i64ARB(location, x, y, z); }
    [QGLNativeAPI("glUniform3i64ARB")] internal static delegate* unmanaged<int, long, long, long, void> _glUniform3i64ARB = null;
    
    public static void glUniform4i64ARB(int location, long x, long y, long z, long w) { QGLNativeAPI.Verify((nint)_glUniform4i64ARB); _glUniform4i64ARB(location, x, y, z, w); }
    [QGLNativeAPI("glUniform4i64ARB")] internal static delegate* unmanaged<int, long, long, long, long, void> _glUniform4i64ARB = null;
    
    public static void glUniform1i64vARB(int location, int count, long* value) { QGLNativeAPI.Verify((nint)_glUniform1i64vARB); _glUniform1i64vARB(location, count, value); }
    [QGLNativeAPI("glUniform1i64vARB")] internal static delegate* unmanaged<int, int, long*, void> _glUniform1i64vARB = null;
    
    public static void glUniform2i64vARB(int location, int count, long* value) { QGLNativeAPI.Verify((nint)_glUniform2i64vARB); _glUniform2i64vARB(location, count, value); }
    [QGLNativeAPI("glUniform2i64vARB")] internal static delegate* unmanaged<int, int, long*, void> _glUniform2i64vARB = null;
    
    public static void glUniform3i64vARB(int location, int count, long* value) { QGLNativeAPI.Verify((nint)_glUniform3i64vARB); _glUniform3i64vARB(location, count, value); }
    [QGLNativeAPI("glUniform3i64vARB")] internal static delegate* unmanaged<int, int, long*, void> _glUniform3i64vARB = null;
    
    public static void glUniform4i64vARB(int location, int count, long* value) { QGLNativeAPI.Verify((nint)_glUniform4i64vARB); _glUniform4i64vARB(location, count, value); }
    [QGLNativeAPI("glUniform4i64vARB")] internal static delegate* unmanaged<int, int, long*, void> _glUniform4i64vARB = null;
    
    public static void glUniform1ui64ARB(int location, ulong x) { QGLNativeAPI.Verify((nint)_glUniform1ui64ARB); _glUniform1ui64ARB(location, x); }
    [QGLNativeAPI("glUniform1ui64ARB")] internal static delegate* unmanaged<int, ulong, void> _glUniform1ui64ARB = null;
    
    public static void glUniform2ui64ARB(int location, ulong x, ulong y) { QGLNativeAPI.Verify((nint)_glUniform2ui64ARB); _glUniform2ui64ARB(location, x, y); }
    [QGLNativeAPI("glUniform2ui64ARB")] internal static delegate* unmanaged<int, ulong, ulong, void> _glUniform2ui64ARB = null;
    
    public static void glUniform3ui64ARB(int location, ulong x, ulong y, ulong z) { QGLNativeAPI.Verify((nint)_glUniform3ui64ARB); _glUniform3ui64ARB(location, x, y, z); }
    [QGLNativeAPI("glUniform3ui64ARB")] internal static delegate* unmanaged<int, ulong, ulong, ulong, void> _glUniform3ui64ARB = null;
    
    public static void glUniform4ui64ARB(int location, ulong x, ulong y, ulong z, ulong w) { QGLNativeAPI.Verify((nint)_glUniform4ui64ARB); _glUniform4ui64ARB(location, x, y, z, w); }
    [QGLNativeAPI("glUniform4ui64ARB")] internal static delegate* unmanaged<int, ulong, ulong, ulong, ulong, void> _glUniform4ui64ARB = null;
    
    public static void glUniform1ui64vARB(int location, int count, ulong* value) { QGLNativeAPI.Verify((nint)_glUniform1ui64vARB); _glUniform1ui64vARB(location, count, value); }
    [QGLNativeAPI("glUniform1ui64vARB")] internal static delegate* unmanaged<int, int, ulong*, void> _glUniform1ui64vARB = null;
    
    public static void glUniform2ui64vARB(int location, int count, ulong* value) { QGLNativeAPI.Verify((nint)_glUniform2ui64vARB); _glUniform2ui64vARB(location, count, value); }
    [QGLNativeAPI("glUniform2ui64vARB")] internal static delegate* unmanaged<int, int, ulong*, void> _glUniform2ui64vARB = null;
    
    public static void glUniform3ui64vARB(int location, int count, ulong* value) { QGLNativeAPI.Verify((nint)_glUniform3ui64vARB); _glUniform3ui64vARB(location, count, value); }
    [QGLNativeAPI("glUniform3ui64vARB")] internal static delegate* unmanaged<int, int, ulong*, void> _glUniform3ui64vARB = null;
    
    public static void glUniform4ui64vARB(int location, int count, ulong* value) { QGLNativeAPI.Verify((nint)_glUniform4ui64vARB); _glUniform4ui64vARB(location, count, value); }
    [QGLNativeAPI("glUniform4ui64vARB")] internal static delegate* unmanaged<int, int, ulong*, void> _glUniform4ui64vARB = null;
    
    public static void glGetUniformi64vARB(uint program, int location, long* @params) { QGLNativeAPI.Verify((nint)_glGetUniformi64vARB); _glGetUniformi64vARB(program, location, @params); }
    [QGLNativeAPI("glGetUniformi64vARB")] internal static delegate* unmanaged<uint, int, long*, void> _glGetUniformi64vARB = null;
    
    public static void glGetUniformui64vARB(uint program, int location, ulong* @params) { QGLNativeAPI.Verify((nint)_glGetUniformui64vARB); _glGetUniformui64vARB(program, location, @params); }
    [QGLNativeAPI("glGetUniformui64vARB")] internal static delegate* unmanaged<uint, int, ulong*, void> _glGetUniformui64vARB = null;
    
    public static void glGetnUniformi64vARB(uint program, int location, int bufSize, long* @params) { QGLNativeAPI.Verify((nint)_glGetnUniformi64vARB); _glGetnUniformi64vARB(program, location, bufSize, @params); }
    [QGLNativeAPI("glGetnUniformi64vARB")] internal static delegate* unmanaged<uint, int, int, long*, void> _glGetnUniformi64vARB = null;
    
    public static void glGetnUniformui64vARB(uint program, int location, int bufSize, ulong* @params) { QGLNativeAPI.Verify((nint)_glGetnUniformui64vARB); _glGetnUniformui64vARB(program, location, bufSize, @params); }
    [QGLNativeAPI("glGetnUniformui64vARB")] internal static delegate* unmanaged<uint, int, int, ulong*, void> _glGetnUniformui64vARB = null;
    
    public static void glProgramUniform1i64ARB(uint program, int location, long x) { QGLNativeAPI.Verify((nint)_glProgramUniform1i64ARB); _glProgramUniform1i64ARB(program, location, x); }
    [QGLNativeAPI("glProgramUniform1i64ARB")] internal static delegate* unmanaged<uint, int, long, void> _glProgramUniform1i64ARB = null;
    
    public static void glProgramUniform2i64ARB(uint program, int location, long x, long y) { QGLNativeAPI.Verify((nint)_glProgramUniform2i64ARB); _glProgramUniform2i64ARB(program, location, x, y); }
    [QGLNativeAPI("glProgramUniform2i64ARB")] internal static delegate* unmanaged<uint, int, long, long, void> _glProgramUniform2i64ARB = null;
    
    public static void glProgramUniform3i64ARB(uint program, int location, long x, long y, long z) { QGLNativeAPI.Verify((nint)_glProgramUniform3i64ARB); _glProgramUniform3i64ARB(program, location, x, y, z); }
    [QGLNativeAPI("glProgramUniform3i64ARB")] internal static delegate* unmanaged<uint, int, long, long, long, void> _glProgramUniform3i64ARB = null;
    
    public static void glProgramUniform4i64ARB(uint program, int location, long x, long y, long z, long w) { QGLNativeAPI.Verify((nint)_glProgramUniform4i64ARB); _glProgramUniform4i64ARB(program, location, x, y, z, w); }
    [QGLNativeAPI("glProgramUniform4i64ARB")] internal static delegate* unmanaged<uint, int, long, long, long, long, void> _glProgramUniform4i64ARB = null;
    
    public static void glProgramUniform1i64vARB(uint program, int location, int count, long* value) { QGLNativeAPI.Verify((nint)_glProgramUniform1i64vARB); _glProgramUniform1i64vARB(program, location, count, value); }
    [QGLNativeAPI("glProgramUniform1i64vARB")] internal static delegate* unmanaged<uint, int, int, long*, void> _glProgramUniform1i64vARB = null;
    
    public static void glProgramUniform2i64vARB(uint program, int location, int count, long* value) { QGLNativeAPI.Verify((nint)_glProgramUniform2i64vARB); _glProgramUniform2i64vARB(program, location, count, value); }
    [QGLNativeAPI("glProgramUniform2i64vARB")] internal static delegate* unmanaged<uint, int, int, long*, void> _glProgramUniform2i64vARB = null;
    
    public static void glProgramUniform3i64vARB(uint program, int location, int count, long* value) { QGLNativeAPI.Verify((nint)_glProgramUniform3i64vARB); _glProgramUniform3i64vARB(program, location, count, value); }
    [QGLNativeAPI("glProgramUniform3i64vARB")] internal static delegate* unmanaged<uint, int, int, long*, void> _glProgramUniform3i64vARB = null;
    
    public static void glProgramUniform4i64vARB(uint program, int location, int count, long* value) { QGLNativeAPI.Verify((nint)_glProgramUniform4i64vARB); _glProgramUniform4i64vARB(program, location, count, value); }
    [QGLNativeAPI("glProgramUniform4i64vARB")] internal static delegate* unmanaged<uint, int, int, long*, void> _glProgramUniform4i64vARB = null;
    
    public static void glProgramUniform1ui64ARB(uint program, int location, ulong x) { QGLNativeAPI.Verify((nint)_glProgramUniform1ui64ARB); _glProgramUniform1ui64ARB(program, location, x); }
    [QGLNativeAPI("glProgramUniform1ui64ARB")] internal static delegate* unmanaged<uint, int, ulong, void> _glProgramUniform1ui64ARB = null;
    
    public static void glProgramUniform2ui64ARB(uint program, int location, ulong x, ulong y) { QGLNativeAPI.Verify((nint)_glProgramUniform2ui64ARB); _glProgramUniform2ui64ARB(program, location, x, y); }
    [QGLNativeAPI("glProgramUniform2ui64ARB")] internal static delegate* unmanaged<uint, int, ulong, ulong, void> _glProgramUniform2ui64ARB = null;
    
    public static void glProgramUniform3ui64ARB(uint program, int location, ulong x, ulong y, ulong z) { QGLNativeAPI.Verify((nint)_glProgramUniform3ui64ARB); _glProgramUniform3ui64ARB(program, location, x, y, z); }
    [QGLNativeAPI("glProgramUniform3ui64ARB")] internal static delegate* unmanaged<uint, int, ulong, ulong, ulong, void> _glProgramUniform3ui64ARB = null;
    
    public static void glProgramUniform4ui64ARB(uint program, int location, ulong x, ulong y, ulong z, ulong w) { QGLNativeAPI.Verify((nint)_glProgramUniform4ui64ARB); _glProgramUniform4ui64ARB(program, location, x, y, z, w); }
    [QGLNativeAPI("glProgramUniform4ui64ARB")] internal static delegate* unmanaged<uint, int, ulong, ulong, ulong, ulong, void> _glProgramUniform4ui64ARB = null;
    
    public static void glProgramUniform1ui64vARB(uint program, int location, int count, ulong* value) { QGLNativeAPI.Verify((nint)_glProgramUniform1ui64vARB); _glProgramUniform1ui64vARB(program, location, count, value); }
    [QGLNativeAPI("glProgramUniform1ui64vARB")] internal static delegate* unmanaged<uint, int, int, ulong*, void> _glProgramUniform1ui64vARB = null;
    
    public static void glProgramUniform2ui64vARB(uint program, int location, int count, ulong* value) { QGLNativeAPI.Verify((nint)_glProgramUniform2ui64vARB); _glProgramUniform2ui64vARB(program, location, count, value); }
    [QGLNativeAPI("glProgramUniform2ui64vARB")] internal static delegate* unmanaged<uint, int, int, ulong*, void> _glProgramUniform2ui64vARB = null;
    
    public static void glProgramUniform3ui64vARB(uint program, int location, int count, ulong* value) { QGLNativeAPI.Verify((nint)_glProgramUniform3ui64vARB); _glProgramUniform3ui64vARB(program, location, count, value); }
    [QGLNativeAPI("glProgramUniform3ui64vARB")] internal static delegate* unmanaged<uint, int, int, ulong*, void> _glProgramUniform3ui64vARB = null;
    
    public static void glProgramUniform4ui64vARB(uint program, int location, int count, ulong* value) { QGLNativeAPI.Verify((nint)_glProgramUniform4ui64vARB); _glProgramUniform4ui64vARB(program, location, count, value); }
    [QGLNativeAPI("glProgramUniform4ui64vARB")] internal static delegate* unmanaged<uint, int, int, ulong*, void> _glProgramUniform4ui64vARB = null;
     #endregion
}
