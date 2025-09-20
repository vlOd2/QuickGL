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

// Bindings generated at 2025-09-20 18:58:19.814985
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBES2compatibility
{
    #region Enums
    public const int GL_FIXED = 0x140C;
    public const int GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
    public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
    public const int GL_LOW_FLOAT = 0x8DF0;
    public const int GL_MEDIUM_FLOAT = 0x8DF1;
    public const int GL_HIGH_FLOAT = 0x8DF2;
    public const int GL_LOW_INT = 0x8DF3;
    public const int GL_MEDIUM_INT = 0x8DF4;
    public const int GL_HIGH_INT = 0x8DF5;
    public const int GL_SHADER_COMPILER = 0x8DFA;
    public const int GL_SHADER_BINARY_FORMATS = 0x8DF8;
    public const int GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
    public const int GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
    public const int GL_MAX_VARYING_VECTORS = 0x8DFC;
    public const int GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
    public const int GL_RGB565 = 0x8D62;
    #endregion
    
    #region Commands
    public static void glReleaseShaderCompiler() { QGLFeature.VerifyFunc((nint)_glReleaseShaderCompiler); _glReleaseShaderCompiler(); }
    internal static delegate* unmanaged<void> _glReleaseShaderCompiler = null;
    
    public static void glShaderBinary(int count, uint* shaders, uint binaryFormat, void* binary, int length) { QGLFeature.VerifyFunc((nint)_glShaderBinary); _glShaderBinary(count, shaders, binaryFormat, binary, length); }
    internal static delegate* unmanaged<int, uint*, uint, void*, int, void> _glShaderBinary = null;
    
    public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision) { QGLFeature.VerifyFunc((nint)_glGetShaderPrecisionFormat); _glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision); }
    internal static delegate* unmanaged<uint, uint, int*, int*, void> _glGetShaderPrecisionFormat = null;
    
    public static void glDepthRangef(float n, float f) { QGLFeature.VerifyFunc((nint)_glDepthRangef); _glDepthRangef(n, f); }
    internal static delegate* unmanaged<float, float, void> _glDepthRangef = null;
    
    public static void glClearDepthf(float d) { QGLFeature.VerifyFunc((nint)_glClearDepthf); _glClearDepthf(d); }
    internal static delegate* unmanaged<float, void> _glClearDepthf = null;
     #endregion
    
    internal static void Load()
    {
        _glReleaseShaderCompiler = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glReleaseShaderCompiler");
        _glShaderBinary = (delegate* unmanaged<int, uint*, uint, void*, int, void>)QuickGL.GetGLProcAddress("glShaderBinary");
        _glGetShaderPrecisionFormat = (delegate* unmanaged<uint, uint, int*, int*, void>)QuickGL.GetGLProcAddress("glGetShaderPrecisionFormat");
        _glDepthRangef = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glDepthRangef");
        _glClearDepthf = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glClearDepthf");
    }
    
    internal static void Unload()
    {
        _glReleaseShaderCompiler = null;
        _glShaderBinary = null;
        _glGetShaderPrecisionFormat = null;
        _glDepthRangef = null;
        _glClearDepthf = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_ES2_compatibility", true, false);
}
