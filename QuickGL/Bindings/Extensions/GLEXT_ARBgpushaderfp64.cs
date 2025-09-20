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

// Bindings generated at 2025-09-20 18:58:19.891620
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBgpushaderfp64
{
    #region Enums
    public const int GL_DOUBLE = 0x140A;
    public const int GL_DOUBLE_VEC2 = 0x8FFC;
    public const int GL_DOUBLE_VEC3 = 0x8FFD;
    public const int GL_DOUBLE_VEC4 = 0x8FFE;
    public const int GL_DOUBLE_MAT2 = 0x8F46;
    public const int GL_DOUBLE_MAT3 = 0x8F47;
    public const int GL_DOUBLE_MAT4 = 0x8F48;
    public const int GL_DOUBLE_MAT2x3 = 0x8F49;
    public const int GL_DOUBLE_MAT2x4 = 0x8F4A;
    public const int GL_DOUBLE_MAT3x2 = 0x8F4B;
    public const int GL_DOUBLE_MAT3x4 = 0x8F4C;
    public const int GL_DOUBLE_MAT4x2 = 0x8F4D;
    public const int GL_DOUBLE_MAT4x3 = 0x8F4E;
    #endregion
    
    #region Commands
    public static void glUniform1d(int location, double x) { QGLFeature.VerifyFunc((nint)_glUniform1d); _glUniform1d(location, x); }
    internal static delegate* unmanaged<int, double, void> _glUniform1d = null;
    
    public static void glUniform2d(int location, double x, double y) { QGLFeature.VerifyFunc((nint)_glUniform2d); _glUniform2d(location, x, y); }
    internal static delegate* unmanaged<int, double, double, void> _glUniform2d = null;
    
    public static void glUniform3d(int location, double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glUniform3d); _glUniform3d(location, x, y, z); }
    internal static delegate* unmanaged<int, double, double, double, void> _glUniform3d = null;
    
    public static void glUniform4d(int location, double x, double y, double z, double w) { QGLFeature.VerifyFunc((nint)_glUniform4d); _glUniform4d(location, x, y, z, w); }
    internal static delegate* unmanaged<int, double, double, double, double, void> _glUniform4d = null;
    
    public static void glUniform1dv(int location, int count, double* value) { QGLFeature.VerifyFunc((nint)_glUniform1dv); _glUniform1dv(location, count, value); }
    internal static delegate* unmanaged<int, int, double*, void> _glUniform1dv = null;
    
    public static void glUniform2dv(int location, int count, double* value) { QGLFeature.VerifyFunc((nint)_glUniform2dv); _glUniform2dv(location, count, value); }
    internal static delegate* unmanaged<int, int, double*, void> _glUniform2dv = null;
    
    public static void glUniform3dv(int location, int count, double* value) { QGLFeature.VerifyFunc((nint)_glUniform3dv); _glUniform3dv(location, count, value); }
    internal static delegate* unmanaged<int, int, double*, void> _glUniform3dv = null;
    
    public static void glUniform4dv(int location, int count, double* value) { QGLFeature.VerifyFunc((nint)_glUniform4dv); _glUniform4dv(location, count, value); }
    internal static delegate* unmanaged<int, int, double*, void> _glUniform4dv = null;
    
    public static void glUniformMatrix2dv(int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix2dv); _glUniformMatrix2dv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix2dv = null;
    
    public static void glUniformMatrix3dv(int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix3dv); _glUniformMatrix3dv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix3dv = null;
    
    public static void glUniformMatrix4dv(int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix4dv); _glUniformMatrix4dv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix4dv = null;
    
    public static void glUniformMatrix2x3dv(int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix2x3dv); _glUniformMatrix2x3dv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix2x3dv = null;
    
    public static void glUniformMatrix2x4dv(int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix2x4dv); _glUniformMatrix2x4dv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix2x4dv = null;
    
    public static void glUniformMatrix3x2dv(int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix3x2dv); _glUniformMatrix3x2dv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix3x2dv = null;
    
    public static void glUniformMatrix3x4dv(int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix3x4dv); _glUniformMatrix3x4dv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix3x4dv = null;
    
    public static void glUniformMatrix4x2dv(int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix4x2dv); _glUniformMatrix4x2dv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix4x2dv = null;
    
    public static void glUniformMatrix4x3dv(int location, int count, bool transpose, double* value) { QGLFeature.VerifyFunc((nint)_glUniformMatrix4x3dv); _glUniformMatrix4x3dv(location, count, transpose, value); }
    internal static delegate* unmanaged<int, int, bool, double*, void> _glUniformMatrix4x3dv = null;
    
    public static void glGetUniformdv(uint program, int location, double* @params) { QGLFeature.VerifyFunc((nint)_glGetUniformdv); _glGetUniformdv(program, location, @params); }
    internal static delegate* unmanaged<uint, int, double*, void> _glGetUniformdv = null;
     #endregion
    
    internal static void Load()
    {
        _glUniform1d = (delegate* unmanaged<int, double, void>)QuickGL.GetGLProcAddress("glUniform1d");
        _glUniform2d = (delegate* unmanaged<int, double, double, void>)QuickGL.GetGLProcAddress("glUniform2d");
        _glUniform3d = (delegate* unmanaged<int, double, double, double, void>)QuickGL.GetGLProcAddress("glUniform3d");
        _glUniform4d = (delegate* unmanaged<int, double, double, double, double, void>)QuickGL.GetGLProcAddress("glUniform4d");
        _glUniform1dv = (delegate* unmanaged<int, int, double*, void>)QuickGL.GetGLProcAddress("glUniform1dv");
        _glUniform2dv = (delegate* unmanaged<int, int, double*, void>)QuickGL.GetGLProcAddress("glUniform2dv");
        _glUniform3dv = (delegate* unmanaged<int, int, double*, void>)QuickGL.GetGLProcAddress("glUniform3dv");
        _glUniform4dv = (delegate* unmanaged<int, int, double*, void>)QuickGL.GetGLProcAddress("glUniform4dv");
        _glUniformMatrix2dv = (delegate* unmanaged<int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glUniformMatrix2dv");
        _glUniformMatrix3dv = (delegate* unmanaged<int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glUniformMatrix3dv");
        _glUniformMatrix4dv = (delegate* unmanaged<int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glUniformMatrix4dv");
        _glUniformMatrix2x3dv = (delegate* unmanaged<int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glUniformMatrix2x3dv");
        _glUniformMatrix2x4dv = (delegate* unmanaged<int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glUniformMatrix2x4dv");
        _glUniformMatrix3x2dv = (delegate* unmanaged<int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glUniformMatrix3x2dv");
        _glUniformMatrix3x4dv = (delegate* unmanaged<int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glUniformMatrix3x4dv");
        _glUniformMatrix4x2dv = (delegate* unmanaged<int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glUniformMatrix4x2dv");
        _glUniformMatrix4x3dv = (delegate* unmanaged<int, int, bool, double*, void>)QuickGL.GetGLProcAddress("glUniformMatrix4x3dv");
        _glGetUniformdv = (delegate* unmanaged<uint, int, double*, void>)QuickGL.GetGLProcAddress("glGetUniformdv");
    }
    
    internal static void Unload()
    {
        _glUniform1d = null;
        _glUniform2d = null;
        _glUniform3d = null;
        _glUniform4d = null;
        _glUniform1dv = null;
        _glUniform2dv = null;
        _glUniform3dv = null;
        _glUniform4dv = null;
        _glUniformMatrix2dv = null;
        _glUniformMatrix3dv = null;
        _glUniformMatrix4dv = null;
        _glUniformMatrix2x3dv = null;
        _glUniformMatrix2x4dv = null;
        _glUniformMatrix3x2dv = null;
        _glUniformMatrix3x4dv = null;
        _glUniformMatrix4x2dv = null;
        _glUniformMatrix4x3dv = null;
        _glGetUniformdv = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_gpu_shader_fp64", true, false);
}
