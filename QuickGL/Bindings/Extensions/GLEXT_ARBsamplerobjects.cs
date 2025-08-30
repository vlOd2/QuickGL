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

// Bindings generated at 2025-08-30 15:45:08.639980
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_sampler_objects", true, false)]
public static unsafe class GLEXT_ARBsamplerobjects
{
    #region Enums
    public const int GL_SAMPLER_BINDING = 0x8919;
    #endregion
    
    #region Commands
    public static void glGenSamplers(int count, uint* samplers) { QGLNativeAPI.Verify((nint)_glGenSamplers); _glGenSamplers(count, samplers); }
    [QGLNativeAPI("glGenSamplers")] internal static delegate* unmanaged<int, uint*, void> _glGenSamplers = null;
    
    public static void glDeleteSamplers(int count, uint* samplers) { QGLNativeAPI.Verify((nint)_glDeleteSamplers); _glDeleteSamplers(count, samplers); }
    [QGLNativeAPI("glDeleteSamplers")] internal static delegate* unmanaged<int, uint*, void> _glDeleteSamplers = null;
    
    public static bool glIsSampler(uint sampler) { QGLNativeAPI.Verify((nint)_glIsSampler); return _glIsSampler(sampler); }
    [QGLNativeAPI("glIsSampler")] internal static delegate* unmanaged<uint, bool> _glIsSampler = null;
    
    public static void glBindSampler(uint unit, uint sampler) { QGLNativeAPI.Verify((nint)_glBindSampler); _glBindSampler(unit, sampler); }
    [QGLNativeAPI("glBindSampler")] internal static delegate* unmanaged<uint, uint, void> _glBindSampler = null;
    
    public static void glSamplerParameteri(uint sampler, uint pname, int param) { QGLNativeAPI.Verify((nint)_glSamplerParameteri); _glSamplerParameteri(sampler, pname, param); }
    [QGLNativeAPI("glSamplerParameteri")] internal static delegate* unmanaged<uint, uint, int, void> _glSamplerParameteri = null;
    
    public static void glSamplerParameteriv(uint sampler, uint pname, int* param) { QGLNativeAPI.Verify((nint)_glSamplerParameteriv); _glSamplerParameteriv(sampler, pname, param); }
    [QGLNativeAPI("glSamplerParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glSamplerParameteriv = null;
    
    public static void glSamplerParameterf(uint sampler, uint pname, float param) { QGLNativeAPI.Verify((nint)_glSamplerParameterf); _glSamplerParameterf(sampler, pname, param); }
    [QGLNativeAPI("glSamplerParameterf")] internal static delegate* unmanaged<uint, uint, float, void> _glSamplerParameterf = null;
    
    public static void glSamplerParameterfv(uint sampler, uint pname, float* param) { QGLNativeAPI.Verify((nint)_glSamplerParameterfv); _glSamplerParameterfv(sampler, pname, param); }
    [QGLNativeAPI("glSamplerParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glSamplerParameterfv = null;
    
    public static void glSamplerParameterIiv(uint sampler, uint pname, int* param) { QGLNativeAPI.Verify((nint)_glSamplerParameterIiv); _glSamplerParameterIiv(sampler, pname, param); }
    [QGLNativeAPI("glSamplerParameterIiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glSamplerParameterIiv = null;
    
    public static void glSamplerParameterIuiv(uint sampler, uint pname, uint* param) { QGLNativeAPI.Verify((nint)_glSamplerParameterIuiv); _glSamplerParameterIuiv(sampler, pname, param); }
    [QGLNativeAPI("glSamplerParameterIuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glSamplerParameterIuiv = null;
    
    public static void glGetSamplerParameteriv(uint sampler, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetSamplerParameteriv); _glGetSamplerParameteriv(sampler, pname, @params); }
    [QGLNativeAPI("glGetSamplerParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetSamplerParameteriv = null;
    
    public static void glGetSamplerParameterIiv(uint sampler, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetSamplerParameterIiv); _glGetSamplerParameterIiv(sampler, pname, @params); }
    [QGLNativeAPI("glGetSamplerParameterIiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetSamplerParameterIiv = null;
    
    public static void glGetSamplerParameterfv(uint sampler, uint pname, float* @params) { QGLNativeAPI.Verify((nint)_glGetSamplerParameterfv); _glGetSamplerParameterfv(sampler, pname, @params); }
    [QGLNativeAPI("glGetSamplerParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetSamplerParameterfv = null;
    
    public static void glGetSamplerParameterIuiv(uint sampler, uint pname, uint* @params) { QGLNativeAPI.Verify((nint)_glGetSamplerParameterIuiv); _glGetSamplerParameterIuiv(sampler, pname, @params); }
    [QGLNativeAPI("glGetSamplerParameterIuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glGetSamplerParameterIuiv = null;
     #endregion
}
