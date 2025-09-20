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

// Bindings generated at 2025-09-20 18:58:19.893859
namespace QuickGLNS.Bindings.Extensions;

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
    public static void glUniform1i64ARB(int location, long x) { QGLFeature.VerifyFunc((nint)_glUniform1i64ARB); _glUniform1i64ARB(location, x); }
    internal static delegate* unmanaged<int, long, void> _glUniform1i64ARB = null;
    
    public static void glUniform2i64ARB(int location, long x, long y) { QGLFeature.VerifyFunc((nint)_glUniform2i64ARB); _glUniform2i64ARB(location, x, y); }
    internal static delegate* unmanaged<int, long, long, void> _glUniform2i64ARB = null;
    
    public static void glUniform3i64ARB(int location, long x, long y, long z) { QGLFeature.VerifyFunc((nint)_glUniform3i64ARB); _glUniform3i64ARB(location, x, y, z); }
    internal static delegate* unmanaged<int, long, long, long, void> _glUniform3i64ARB = null;
    
    public static void glUniform4i64ARB(int location, long x, long y, long z, long w) { QGLFeature.VerifyFunc((nint)_glUniform4i64ARB); _glUniform4i64ARB(location, x, y, z, w); }
    internal static delegate* unmanaged<int, long, long, long, long, void> _glUniform4i64ARB = null;
    
    public static void glUniform1i64vARB(int location, int count, long* value) { QGLFeature.VerifyFunc((nint)_glUniform1i64vARB); _glUniform1i64vARB(location, count, value); }
    internal static delegate* unmanaged<int, int, long*, void> _glUniform1i64vARB = null;
    
    public static void glUniform2i64vARB(int location, int count, long* value) { QGLFeature.VerifyFunc((nint)_glUniform2i64vARB); _glUniform2i64vARB(location, count, value); }
    internal static delegate* unmanaged<int, int, long*, void> _glUniform2i64vARB = null;
    
    public static void glUniform3i64vARB(int location, int count, long* value) { QGLFeature.VerifyFunc((nint)_glUniform3i64vARB); _glUniform3i64vARB(location, count, value); }
    internal static delegate* unmanaged<int, int, long*, void> _glUniform3i64vARB = null;
    
    public static void glUniform4i64vARB(int location, int count, long* value) { QGLFeature.VerifyFunc((nint)_glUniform4i64vARB); _glUniform4i64vARB(location, count, value); }
    internal static delegate* unmanaged<int, int, long*, void> _glUniform4i64vARB = null;
    
    public static void glUniform1ui64ARB(int location, ulong x) { QGLFeature.VerifyFunc((nint)_glUniform1ui64ARB); _glUniform1ui64ARB(location, x); }
    internal static delegate* unmanaged<int, ulong, void> _glUniform1ui64ARB = null;
    
    public static void glUniform2ui64ARB(int location, ulong x, ulong y) { QGLFeature.VerifyFunc((nint)_glUniform2ui64ARB); _glUniform2ui64ARB(location, x, y); }
    internal static delegate* unmanaged<int, ulong, ulong, void> _glUniform2ui64ARB = null;
    
    public static void glUniform3ui64ARB(int location, ulong x, ulong y, ulong z) { QGLFeature.VerifyFunc((nint)_glUniform3ui64ARB); _glUniform3ui64ARB(location, x, y, z); }
    internal static delegate* unmanaged<int, ulong, ulong, ulong, void> _glUniform3ui64ARB = null;
    
    public static void glUniform4ui64ARB(int location, ulong x, ulong y, ulong z, ulong w) { QGLFeature.VerifyFunc((nint)_glUniform4ui64ARB); _glUniform4ui64ARB(location, x, y, z, w); }
    internal static delegate* unmanaged<int, ulong, ulong, ulong, ulong, void> _glUniform4ui64ARB = null;
    
    public static void glUniform1ui64vARB(int location, int count, ulong* value) { QGLFeature.VerifyFunc((nint)_glUniform1ui64vARB); _glUniform1ui64vARB(location, count, value); }
    internal static delegate* unmanaged<int, int, ulong*, void> _glUniform1ui64vARB = null;
    
    public static void glUniform2ui64vARB(int location, int count, ulong* value) { QGLFeature.VerifyFunc((nint)_glUniform2ui64vARB); _glUniform2ui64vARB(location, count, value); }
    internal static delegate* unmanaged<int, int, ulong*, void> _glUniform2ui64vARB = null;
    
    public static void glUniform3ui64vARB(int location, int count, ulong* value) { QGLFeature.VerifyFunc((nint)_glUniform3ui64vARB); _glUniform3ui64vARB(location, count, value); }
    internal static delegate* unmanaged<int, int, ulong*, void> _glUniform3ui64vARB = null;
    
    public static void glUniform4ui64vARB(int location, int count, ulong* value) { QGLFeature.VerifyFunc((nint)_glUniform4ui64vARB); _glUniform4ui64vARB(location, count, value); }
    internal static delegate* unmanaged<int, int, ulong*, void> _glUniform4ui64vARB = null;
    
    public static void glGetUniformi64vARB(uint program, int location, long* @params) { QGLFeature.VerifyFunc((nint)_glGetUniformi64vARB); _glGetUniformi64vARB(program, location, @params); }
    internal static delegate* unmanaged<uint, int, long*, void> _glGetUniformi64vARB = null;
    
    public static void glGetUniformui64vARB(uint program, int location, ulong* @params) { QGLFeature.VerifyFunc((nint)_glGetUniformui64vARB); _glGetUniformui64vARB(program, location, @params); }
    internal static delegate* unmanaged<uint, int, ulong*, void> _glGetUniformui64vARB = null;
    
    public static void glGetnUniformi64vARB(uint program, int location, int bufSize, long* @params) { QGLFeature.VerifyFunc((nint)_glGetnUniformi64vARB); _glGetnUniformi64vARB(program, location, bufSize, @params); }
    internal static delegate* unmanaged<uint, int, int, long*, void> _glGetnUniformi64vARB = null;
    
    public static void glGetnUniformui64vARB(uint program, int location, int bufSize, ulong* @params) { QGLFeature.VerifyFunc((nint)_glGetnUniformui64vARB); _glGetnUniformui64vARB(program, location, bufSize, @params); }
    internal static delegate* unmanaged<uint, int, int, ulong*, void> _glGetnUniformui64vARB = null;
    
    public static void glProgramUniform1i64ARB(uint program, int location, long x) { QGLFeature.VerifyFunc((nint)_glProgramUniform1i64ARB); _glProgramUniform1i64ARB(program, location, x); }
    internal static delegate* unmanaged<uint, int, long, void> _glProgramUniform1i64ARB = null;
    
    public static void glProgramUniform2i64ARB(uint program, int location, long x, long y) { QGLFeature.VerifyFunc((nint)_glProgramUniform2i64ARB); _glProgramUniform2i64ARB(program, location, x, y); }
    internal static delegate* unmanaged<uint, int, long, long, void> _glProgramUniform2i64ARB = null;
    
    public static void glProgramUniform3i64ARB(uint program, int location, long x, long y, long z) { QGLFeature.VerifyFunc((nint)_glProgramUniform3i64ARB); _glProgramUniform3i64ARB(program, location, x, y, z); }
    internal static delegate* unmanaged<uint, int, long, long, long, void> _glProgramUniform3i64ARB = null;
    
    public static void glProgramUniform4i64ARB(uint program, int location, long x, long y, long z, long w) { QGLFeature.VerifyFunc((nint)_glProgramUniform4i64ARB); _glProgramUniform4i64ARB(program, location, x, y, z, w); }
    internal static delegate* unmanaged<uint, int, long, long, long, long, void> _glProgramUniform4i64ARB = null;
    
    public static void glProgramUniform1i64vARB(uint program, int location, int count, long* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform1i64vARB); _glProgramUniform1i64vARB(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, long*, void> _glProgramUniform1i64vARB = null;
    
    public static void glProgramUniform2i64vARB(uint program, int location, int count, long* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform2i64vARB); _glProgramUniform2i64vARB(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, long*, void> _glProgramUniform2i64vARB = null;
    
    public static void glProgramUniform3i64vARB(uint program, int location, int count, long* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform3i64vARB); _glProgramUniform3i64vARB(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, long*, void> _glProgramUniform3i64vARB = null;
    
    public static void glProgramUniform4i64vARB(uint program, int location, int count, long* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform4i64vARB); _glProgramUniform4i64vARB(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, long*, void> _glProgramUniform4i64vARB = null;
    
    public static void glProgramUniform1ui64ARB(uint program, int location, ulong x) { QGLFeature.VerifyFunc((nint)_glProgramUniform1ui64ARB); _glProgramUniform1ui64ARB(program, location, x); }
    internal static delegate* unmanaged<uint, int, ulong, void> _glProgramUniform1ui64ARB = null;
    
    public static void glProgramUniform2ui64ARB(uint program, int location, ulong x, ulong y) { QGLFeature.VerifyFunc((nint)_glProgramUniform2ui64ARB); _glProgramUniform2ui64ARB(program, location, x, y); }
    internal static delegate* unmanaged<uint, int, ulong, ulong, void> _glProgramUniform2ui64ARB = null;
    
    public static void glProgramUniform3ui64ARB(uint program, int location, ulong x, ulong y, ulong z) { QGLFeature.VerifyFunc((nint)_glProgramUniform3ui64ARB); _glProgramUniform3ui64ARB(program, location, x, y, z); }
    internal static delegate* unmanaged<uint, int, ulong, ulong, ulong, void> _glProgramUniform3ui64ARB = null;
    
    public static void glProgramUniform4ui64ARB(uint program, int location, ulong x, ulong y, ulong z, ulong w) { QGLFeature.VerifyFunc((nint)_glProgramUniform4ui64ARB); _glProgramUniform4ui64ARB(program, location, x, y, z, w); }
    internal static delegate* unmanaged<uint, int, ulong, ulong, ulong, ulong, void> _glProgramUniform4ui64ARB = null;
    
    public static void glProgramUniform1ui64vARB(uint program, int location, int count, ulong* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform1ui64vARB); _glProgramUniform1ui64vARB(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, ulong*, void> _glProgramUniform1ui64vARB = null;
    
    public static void glProgramUniform2ui64vARB(uint program, int location, int count, ulong* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform2ui64vARB); _glProgramUniform2ui64vARB(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, ulong*, void> _glProgramUniform2ui64vARB = null;
    
    public static void glProgramUniform3ui64vARB(uint program, int location, int count, ulong* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform3ui64vARB); _glProgramUniform3ui64vARB(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, ulong*, void> _glProgramUniform3ui64vARB = null;
    
    public static void glProgramUniform4ui64vARB(uint program, int location, int count, ulong* value) { QGLFeature.VerifyFunc((nint)_glProgramUniform4ui64vARB); _glProgramUniform4ui64vARB(program, location, count, value); }
    internal static delegate* unmanaged<uint, int, int, ulong*, void> _glProgramUniform4ui64vARB = null;
     #endregion
    
    internal static void Load()
    {
        _glUniform1i64ARB = (delegate* unmanaged<int, long, void>)QuickGL.GetGLProcAddress("glUniform1i64ARB");
        _glUniform2i64ARB = (delegate* unmanaged<int, long, long, void>)QuickGL.GetGLProcAddress("glUniform2i64ARB");
        _glUniform3i64ARB = (delegate* unmanaged<int, long, long, long, void>)QuickGL.GetGLProcAddress("glUniform3i64ARB");
        _glUniform4i64ARB = (delegate* unmanaged<int, long, long, long, long, void>)QuickGL.GetGLProcAddress("glUniform4i64ARB");
        _glUniform1i64vARB = (delegate* unmanaged<int, int, long*, void>)QuickGL.GetGLProcAddress("glUniform1i64vARB");
        _glUniform2i64vARB = (delegate* unmanaged<int, int, long*, void>)QuickGL.GetGLProcAddress("glUniform2i64vARB");
        _glUniform3i64vARB = (delegate* unmanaged<int, int, long*, void>)QuickGL.GetGLProcAddress("glUniform3i64vARB");
        _glUniform4i64vARB = (delegate* unmanaged<int, int, long*, void>)QuickGL.GetGLProcAddress("glUniform4i64vARB");
        _glUniform1ui64ARB = (delegate* unmanaged<int, ulong, void>)QuickGL.GetGLProcAddress("glUniform1ui64ARB");
        _glUniform2ui64ARB = (delegate* unmanaged<int, ulong, ulong, void>)QuickGL.GetGLProcAddress("glUniform2ui64ARB");
        _glUniform3ui64ARB = (delegate* unmanaged<int, ulong, ulong, ulong, void>)QuickGL.GetGLProcAddress("glUniform3ui64ARB");
        _glUniform4ui64ARB = (delegate* unmanaged<int, ulong, ulong, ulong, ulong, void>)QuickGL.GetGLProcAddress("glUniform4ui64ARB");
        _glUniform1ui64vARB = (delegate* unmanaged<int, int, ulong*, void>)QuickGL.GetGLProcAddress("glUniform1ui64vARB");
        _glUniform2ui64vARB = (delegate* unmanaged<int, int, ulong*, void>)QuickGL.GetGLProcAddress("glUniform2ui64vARB");
        _glUniform3ui64vARB = (delegate* unmanaged<int, int, ulong*, void>)QuickGL.GetGLProcAddress("glUniform3ui64vARB");
        _glUniform4ui64vARB = (delegate* unmanaged<int, int, ulong*, void>)QuickGL.GetGLProcAddress("glUniform4ui64vARB");
        _glGetUniformi64vARB = (delegate* unmanaged<uint, int, long*, void>)QuickGL.GetGLProcAddress("glGetUniformi64vARB");
        _glGetUniformui64vARB = (delegate* unmanaged<uint, int, ulong*, void>)QuickGL.GetGLProcAddress("glGetUniformui64vARB");
        _glGetnUniformi64vARB = (delegate* unmanaged<uint, int, int, long*, void>)QuickGL.GetGLProcAddress("glGetnUniformi64vARB");
        _glGetnUniformui64vARB = (delegate* unmanaged<uint, int, int, ulong*, void>)QuickGL.GetGLProcAddress("glGetnUniformui64vARB");
        _glProgramUniform1i64ARB = (delegate* unmanaged<uint, int, long, void>)QuickGL.GetGLProcAddress("glProgramUniform1i64ARB");
        _glProgramUniform2i64ARB = (delegate* unmanaged<uint, int, long, long, void>)QuickGL.GetGLProcAddress("glProgramUniform2i64ARB");
        _glProgramUniform3i64ARB = (delegate* unmanaged<uint, int, long, long, long, void>)QuickGL.GetGLProcAddress("glProgramUniform3i64ARB");
        _glProgramUniform4i64ARB = (delegate* unmanaged<uint, int, long, long, long, long, void>)QuickGL.GetGLProcAddress("glProgramUniform4i64ARB");
        _glProgramUniform1i64vARB = (delegate* unmanaged<uint, int, int, long*, void>)QuickGL.GetGLProcAddress("glProgramUniform1i64vARB");
        _glProgramUniform2i64vARB = (delegate* unmanaged<uint, int, int, long*, void>)QuickGL.GetGLProcAddress("glProgramUniform2i64vARB");
        _glProgramUniform3i64vARB = (delegate* unmanaged<uint, int, int, long*, void>)QuickGL.GetGLProcAddress("glProgramUniform3i64vARB");
        _glProgramUniform4i64vARB = (delegate* unmanaged<uint, int, int, long*, void>)QuickGL.GetGLProcAddress("glProgramUniform4i64vARB");
        _glProgramUniform1ui64ARB = (delegate* unmanaged<uint, int, ulong, void>)QuickGL.GetGLProcAddress("glProgramUniform1ui64ARB");
        _glProgramUniform2ui64ARB = (delegate* unmanaged<uint, int, ulong, ulong, void>)QuickGL.GetGLProcAddress("glProgramUniform2ui64ARB");
        _glProgramUniform3ui64ARB = (delegate* unmanaged<uint, int, ulong, ulong, ulong, void>)QuickGL.GetGLProcAddress("glProgramUniform3ui64ARB");
        _glProgramUniform4ui64ARB = (delegate* unmanaged<uint, int, ulong, ulong, ulong, ulong, void>)QuickGL.GetGLProcAddress("glProgramUniform4ui64ARB");
        _glProgramUniform1ui64vARB = (delegate* unmanaged<uint, int, int, ulong*, void>)QuickGL.GetGLProcAddress("glProgramUniform1ui64vARB");
        _glProgramUniform2ui64vARB = (delegate* unmanaged<uint, int, int, ulong*, void>)QuickGL.GetGLProcAddress("glProgramUniform2ui64vARB");
        _glProgramUniform3ui64vARB = (delegate* unmanaged<uint, int, int, ulong*, void>)QuickGL.GetGLProcAddress("glProgramUniform3ui64vARB");
        _glProgramUniform4ui64vARB = (delegate* unmanaged<uint, int, int, ulong*, void>)QuickGL.GetGLProcAddress("glProgramUniform4ui64vARB");
    }
    
    internal static void Unload()
    {
        _glUniform1i64ARB = null;
        _glUniform2i64ARB = null;
        _glUniform3i64ARB = null;
        _glUniform4i64ARB = null;
        _glUniform1i64vARB = null;
        _glUniform2i64vARB = null;
        _glUniform3i64vARB = null;
        _glUniform4i64vARB = null;
        _glUniform1ui64ARB = null;
        _glUniform2ui64ARB = null;
        _glUniform3ui64ARB = null;
        _glUniform4ui64ARB = null;
        _glUniform1ui64vARB = null;
        _glUniform2ui64vARB = null;
        _glUniform3ui64vARB = null;
        _glUniform4ui64vARB = null;
        _glGetUniformi64vARB = null;
        _glGetUniformui64vARB = null;
        _glGetnUniformi64vARB = null;
        _glGetnUniformui64vARB = null;
        _glProgramUniform1i64ARB = null;
        _glProgramUniform2i64ARB = null;
        _glProgramUniform3i64ARB = null;
        _glProgramUniform4i64ARB = null;
        _glProgramUniform1i64vARB = null;
        _glProgramUniform2i64vARB = null;
        _glProgramUniform3i64vARB = null;
        _glProgramUniform4i64vARB = null;
        _glProgramUniform1ui64ARB = null;
        _glProgramUniform2ui64ARB = null;
        _glProgramUniform3ui64ARB = null;
        _glProgramUniform4ui64ARB = null;
        _glProgramUniform1ui64vARB = null;
        _glProgramUniform2ui64vARB = null;
        _glProgramUniform3ui64vARB = null;
        _glProgramUniform4ui64vARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_gpu_shader_int64", true, false);
}
