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

// Bindings generated at 2025-09-20 18:58:19.951145
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBsamplerobjects
{
    #region Enums
    public const int GL_SAMPLER_BINDING = 0x8919;
    #endregion
    
    #region Commands
    public static void glGenSamplers(int count, uint* samplers) { QGLFeature.VerifyFunc((nint)_glGenSamplers); _glGenSamplers(count, samplers); }
    internal static delegate* unmanaged<int, uint*, void> _glGenSamplers = null;
    
    public static void glDeleteSamplers(int count, uint* samplers) { QGLFeature.VerifyFunc((nint)_glDeleteSamplers); _glDeleteSamplers(count, samplers); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteSamplers = null;
    
    public static bool glIsSampler(uint sampler) { QGLFeature.VerifyFunc((nint)_glIsSampler); return _glIsSampler(sampler); }
    internal static delegate* unmanaged<uint, bool> _glIsSampler = null;
    
    public static void glBindSampler(uint unit, uint sampler) { QGLFeature.VerifyFunc((nint)_glBindSampler); _glBindSampler(unit, sampler); }
    internal static delegate* unmanaged<uint, uint, void> _glBindSampler = null;
    
    public static void glSamplerParameteri(uint sampler, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glSamplerParameteri); _glSamplerParameteri(sampler, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glSamplerParameteri = null;
    
    public static void glSamplerParameteriv(uint sampler, uint pname, int* param) { QGLFeature.VerifyFunc((nint)_glSamplerParameteriv); _glSamplerParameteriv(sampler, pname, param); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glSamplerParameteriv = null;
    
    public static void glSamplerParameterf(uint sampler, uint pname, float param) { QGLFeature.VerifyFunc((nint)_glSamplerParameterf); _glSamplerParameterf(sampler, pname, param); }
    internal static delegate* unmanaged<uint, uint, float, void> _glSamplerParameterf = null;
    
    public static void glSamplerParameterfv(uint sampler, uint pname, float* param) { QGLFeature.VerifyFunc((nint)_glSamplerParameterfv); _glSamplerParameterfv(sampler, pname, param); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glSamplerParameterfv = null;
    
    public static void glSamplerParameterIiv(uint sampler, uint pname, int* param) { QGLFeature.VerifyFunc((nint)_glSamplerParameterIiv); _glSamplerParameterIiv(sampler, pname, param); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glSamplerParameterIiv = null;
    
    public static void glSamplerParameterIuiv(uint sampler, uint pname, uint* param) { QGLFeature.VerifyFunc((nint)_glSamplerParameterIuiv); _glSamplerParameterIuiv(sampler, pname, param); }
    internal static delegate* unmanaged<uint, uint, uint*, void> _glSamplerParameterIuiv = null;
    
    public static void glGetSamplerParameteriv(uint sampler, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetSamplerParameteriv); _glGetSamplerParameteriv(sampler, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetSamplerParameteriv = null;
    
    public static void glGetSamplerParameterIiv(uint sampler, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetSamplerParameterIiv); _glGetSamplerParameterIiv(sampler, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetSamplerParameterIiv = null;
    
    public static void glGetSamplerParameterfv(uint sampler, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetSamplerParameterfv); _glGetSamplerParameterfv(sampler, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetSamplerParameterfv = null;
    
    public static void glGetSamplerParameterIuiv(uint sampler, uint pname, uint* @params) { QGLFeature.VerifyFunc((nint)_glGetSamplerParameterIuiv); _glGetSamplerParameterIuiv(sampler, pname, @params); }
    internal static delegate* unmanaged<uint, uint, uint*, void> _glGetSamplerParameterIuiv = null;
     #endregion
    
    internal static void Load()
    {
        _glGenSamplers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenSamplers");
        _glDeleteSamplers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteSamplers");
        _glIsSampler = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsSampler");
        _glBindSampler = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBindSampler");
        _glSamplerParameteri = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glSamplerParameteri");
        _glSamplerParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glSamplerParameteriv");
        _glSamplerParameterf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glSamplerParameterf");
        _glSamplerParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glSamplerParameterfv");
        _glSamplerParameterIiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glSamplerParameterIiv");
        _glSamplerParameterIuiv = (delegate* unmanaged<uint, uint, uint*, void>)QuickGL.GetGLProcAddress("glSamplerParameterIuiv");
        _glGetSamplerParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetSamplerParameteriv");
        _glGetSamplerParameterIiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetSamplerParameterIiv");
        _glGetSamplerParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetSamplerParameterfv");
        _glGetSamplerParameterIuiv = (delegate* unmanaged<uint, uint, uint*, void>)QuickGL.GetGLProcAddress("glGetSamplerParameterIuiv");
    }
    
    internal static void Unload()
    {
        _glGenSamplers = null;
        _glDeleteSamplers = null;
        _glIsSampler = null;
        _glBindSampler = null;
        _glSamplerParameteri = null;
        _glSamplerParameteriv = null;
        _glSamplerParameterf = null;
        _glSamplerParameterfv = null;
        _glSamplerParameterIiv = null;
        _glSamplerParameterIuiv = null;
        _glGetSamplerParameteriv = null;
        _glGetSamplerParameterIiv = null;
        _glGetSamplerParameterfv = null;
        _glGetSamplerParameterIuiv = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_sampler_objects", true, false);
}
