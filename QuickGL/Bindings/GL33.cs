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

// Bindings generated at 2025-09-20 18:58:19.765655
namespace QuickGLNS.Bindings;

public static unsafe class GL33
{
    #region Enums
    public const int GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
    public const int GL_SRC1_COLOR = 0x88F9;
    public const int GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
    public const int GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
    public const int GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
    public const int GL_ANY_SAMPLES_PASSED = 0x8C2F;
    public const int GL_SAMPLER_BINDING = 0x8919;
    public const int GL_RGB10_A2UI = 0x906F;
    public const int GL_TEXTURE_SWIZZLE_R = 0x8E42;
    public const int GL_TEXTURE_SWIZZLE_G = 0x8E43;
    public const int GL_TEXTURE_SWIZZLE_B = 0x8E44;
    public const int GL_TEXTURE_SWIZZLE_A = 0x8E45;
    public const int GL_TEXTURE_SWIZZLE_RGBA = 0x8E46;
    public const int GL_TIME_ELAPSED = 0x88BF;
    public const int GL_TIMESTAMP = 0x8E28;
    public const int GL_INT_2_10_10_10_REV = 0x8D9F;
    #endregion
    
    #region Commands
    public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, byte* name) { QGLFeature.VerifyFunc((nint)_glBindFragDataLocationIndexed); _glBindFragDataLocationIndexed(program, colorNumber, index, name); }
    internal static delegate* unmanaged<uint, uint, uint, byte*, void> _glBindFragDataLocationIndexed = null;
    
    public static int glGetFragDataIndex(uint program, byte* name) { QGLFeature.VerifyFunc((nint)_glGetFragDataIndex); return _glGetFragDataIndex(program, name); }
    internal static delegate* unmanaged<uint, byte*, int> _glGetFragDataIndex = null;
    
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
    
    public static void glQueryCounter(uint id, uint target) { QGLFeature.VerifyFunc((nint)_glQueryCounter); _glQueryCounter(id, target); }
    internal static delegate* unmanaged<uint, uint, void> _glQueryCounter = null;
    
    public static void glGetQueryObjecti64v(uint id, uint pname, long* @params) { QGLFeature.VerifyFunc((nint)_glGetQueryObjecti64v); _glGetQueryObjecti64v(id, pname, @params); }
    internal static delegate* unmanaged<uint, uint, long*, void> _glGetQueryObjecti64v = null;
    
    public static void glGetQueryObjectui64v(uint id, uint pname, ulong* @params) { QGLFeature.VerifyFunc((nint)_glGetQueryObjectui64v); _glGetQueryObjectui64v(id, pname, @params); }
    internal static delegate* unmanaged<uint, uint, ulong*, void> _glGetQueryObjectui64v = null;
    
    public static void glVertexAttribDivisor(uint index, uint divisor) { QGLFeature.VerifyFunc((nint)_glVertexAttribDivisor); _glVertexAttribDivisor(index, divisor); }
    internal static delegate* unmanaged<uint, uint, void> _glVertexAttribDivisor = null;
    
    public static void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value) { QGLFeature.VerifyFunc((nint)_glVertexAttribP1ui); _glVertexAttribP1ui(index, type, normalized, value); }
    internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP1ui = null;
    
    public static void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint* value) { QGLFeature.VerifyFunc((nint)_glVertexAttribP1uiv); _glVertexAttribP1uiv(index, type, normalized, value); }
    internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP1uiv = null;
    
    public static void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value) { QGLFeature.VerifyFunc((nint)_glVertexAttribP2ui); _glVertexAttribP2ui(index, type, normalized, value); }
    internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP2ui = null;
    
    public static void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint* value) { QGLFeature.VerifyFunc((nint)_glVertexAttribP2uiv); _glVertexAttribP2uiv(index, type, normalized, value); }
    internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP2uiv = null;
    
    public static void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value) { QGLFeature.VerifyFunc((nint)_glVertexAttribP3ui); _glVertexAttribP3ui(index, type, normalized, value); }
    internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP3ui = null;
    
    public static void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint* value) { QGLFeature.VerifyFunc((nint)_glVertexAttribP3uiv); _glVertexAttribP3uiv(index, type, normalized, value); }
    internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP3uiv = null;
    
    public static void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value) { QGLFeature.VerifyFunc((nint)_glVertexAttribP4ui); _glVertexAttribP4ui(index, type, normalized, value); }
    internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP4ui = null;
    
    public static void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint* value) { QGLFeature.VerifyFunc((nint)_glVertexAttribP4uiv); _glVertexAttribP4uiv(index, type, normalized, value); }
    internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP4uiv = null;
    
    public static void glVertexP2ui(uint type, uint value) { QGLFeature.VerifyFunc((nint)_glVertexP2ui); _glVertexP2ui(type, value); }
    internal static delegate* unmanaged<uint, uint, void> _glVertexP2ui = null;
    
    public static void glVertexP2uiv(uint type, uint* value) { QGLFeature.VerifyFunc((nint)_glVertexP2uiv); _glVertexP2uiv(type, value); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexP2uiv = null;
    
    public static void glVertexP3ui(uint type, uint value) { QGLFeature.VerifyFunc((nint)_glVertexP3ui); _glVertexP3ui(type, value); }
    internal static delegate* unmanaged<uint, uint, void> _glVertexP3ui = null;
    
    public static void glVertexP3uiv(uint type, uint* value) { QGLFeature.VerifyFunc((nint)_glVertexP3uiv); _glVertexP3uiv(type, value); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexP3uiv = null;
    
    public static void glVertexP4ui(uint type, uint value) { QGLFeature.VerifyFunc((nint)_glVertexP4ui); _glVertexP4ui(type, value); }
    internal static delegate* unmanaged<uint, uint, void> _glVertexP4ui = null;
    
    public static void glVertexP4uiv(uint type, uint* value) { QGLFeature.VerifyFunc((nint)_glVertexP4uiv); _glVertexP4uiv(type, value); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexP4uiv = null;
    
    public static void glTexCoordP1ui(uint type, uint coords) { QGLFeature.VerifyFunc((nint)_glTexCoordP1ui); _glTexCoordP1ui(type, coords); }
    internal static delegate* unmanaged<uint, uint, void> _glTexCoordP1ui = null;
    
    public static void glTexCoordP1uiv(uint type, uint* coords) { QGLFeature.VerifyFunc((nint)_glTexCoordP1uiv); _glTexCoordP1uiv(type, coords); }
    internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP1uiv = null;
    
    public static void glTexCoordP2ui(uint type, uint coords) { QGLFeature.VerifyFunc((nint)_glTexCoordP2ui); _glTexCoordP2ui(type, coords); }
    internal static delegate* unmanaged<uint, uint, void> _glTexCoordP2ui = null;
    
    public static void glTexCoordP2uiv(uint type, uint* coords) { QGLFeature.VerifyFunc((nint)_glTexCoordP2uiv); _glTexCoordP2uiv(type, coords); }
    internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP2uiv = null;
    
    public static void glTexCoordP3ui(uint type, uint coords) { QGLFeature.VerifyFunc((nint)_glTexCoordP3ui); _glTexCoordP3ui(type, coords); }
    internal static delegate* unmanaged<uint, uint, void> _glTexCoordP3ui = null;
    
    public static void glTexCoordP3uiv(uint type, uint* coords) { QGLFeature.VerifyFunc((nint)_glTexCoordP3uiv); _glTexCoordP3uiv(type, coords); }
    internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP3uiv = null;
    
    public static void glTexCoordP4ui(uint type, uint coords) { QGLFeature.VerifyFunc((nint)_glTexCoordP4ui); _glTexCoordP4ui(type, coords); }
    internal static delegate* unmanaged<uint, uint, void> _glTexCoordP4ui = null;
    
    public static void glTexCoordP4uiv(uint type, uint* coords) { QGLFeature.VerifyFunc((nint)_glTexCoordP4uiv); _glTexCoordP4uiv(type, coords); }
    internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP4uiv = null;
    
    public static void glMultiTexCoordP1ui(uint texture, uint type, uint coords) { QGLFeature.VerifyFunc((nint)_glMultiTexCoordP1ui); _glMultiTexCoordP1ui(texture, type, coords); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP1ui = null;
    
    public static void glMultiTexCoordP1uiv(uint texture, uint type, uint* coords) { QGLFeature.VerifyFunc((nint)_glMultiTexCoordP1uiv); _glMultiTexCoordP1uiv(texture, type, coords); }
    internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP1uiv = null;
    
    public static void glMultiTexCoordP2ui(uint texture, uint type, uint coords) { QGLFeature.VerifyFunc((nint)_glMultiTexCoordP2ui); _glMultiTexCoordP2ui(texture, type, coords); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP2ui = null;
    
    public static void glMultiTexCoordP2uiv(uint texture, uint type, uint* coords) { QGLFeature.VerifyFunc((nint)_glMultiTexCoordP2uiv); _glMultiTexCoordP2uiv(texture, type, coords); }
    internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP2uiv = null;
    
    public static void glMultiTexCoordP3ui(uint texture, uint type, uint coords) { QGLFeature.VerifyFunc((nint)_glMultiTexCoordP3ui); _glMultiTexCoordP3ui(texture, type, coords); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP3ui = null;
    
    public static void glMultiTexCoordP3uiv(uint texture, uint type, uint* coords) { QGLFeature.VerifyFunc((nint)_glMultiTexCoordP3uiv); _glMultiTexCoordP3uiv(texture, type, coords); }
    internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP3uiv = null;
    
    public static void glMultiTexCoordP4ui(uint texture, uint type, uint coords) { QGLFeature.VerifyFunc((nint)_glMultiTexCoordP4ui); _glMultiTexCoordP4ui(texture, type, coords); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP4ui = null;
    
    public static void glMultiTexCoordP4uiv(uint texture, uint type, uint* coords) { QGLFeature.VerifyFunc((nint)_glMultiTexCoordP4uiv); _glMultiTexCoordP4uiv(texture, type, coords); }
    internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP4uiv = null;
    
    public static void glNormalP3ui(uint type, uint coords) { QGLFeature.VerifyFunc((nint)_glNormalP3ui); _glNormalP3ui(type, coords); }
    internal static delegate* unmanaged<uint, uint, void> _glNormalP3ui = null;
    
    public static void glNormalP3uiv(uint type, uint* coords) { QGLFeature.VerifyFunc((nint)_glNormalP3uiv); _glNormalP3uiv(type, coords); }
    internal static delegate* unmanaged<uint, uint*, void> _glNormalP3uiv = null;
    
    public static void glColorP3ui(uint type, uint color) { QGLFeature.VerifyFunc((nint)_glColorP3ui); _glColorP3ui(type, color); }
    internal static delegate* unmanaged<uint, uint, void> _glColorP3ui = null;
    
    public static void glColorP3uiv(uint type, uint* color) { QGLFeature.VerifyFunc((nint)_glColorP3uiv); _glColorP3uiv(type, color); }
    internal static delegate* unmanaged<uint, uint*, void> _glColorP3uiv = null;
    
    public static void glColorP4ui(uint type, uint color) { QGLFeature.VerifyFunc((nint)_glColorP4ui); _glColorP4ui(type, color); }
    internal static delegate* unmanaged<uint, uint, void> _glColorP4ui = null;
    
    public static void glColorP4uiv(uint type, uint* color) { QGLFeature.VerifyFunc((nint)_glColorP4uiv); _glColorP4uiv(type, color); }
    internal static delegate* unmanaged<uint, uint*, void> _glColorP4uiv = null;
    
    public static void glSecondaryColorP3ui(uint type, uint color) { QGLFeature.VerifyFunc((nint)_glSecondaryColorP3ui); _glSecondaryColorP3ui(type, color); }
    internal static delegate* unmanaged<uint, uint, void> _glSecondaryColorP3ui = null;
    
    public static void glSecondaryColorP3uiv(uint type, uint* color) { QGLFeature.VerifyFunc((nint)_glSecondaryColorP3uiv); _glSecondaryColorP3uiv(type, color); }
    internal static delegate* unmanaged<uint, uint*, void> _glSecondaryColorP3uiv = null;
     #endregion
    
    internal static void Load()
    {
        _glBindFragDataLocationIndexed = (delegate* unmanaged<uint, uint, uint, byte*, void>)QuickGL.GetGLProcAddress("glBindFragDataLocationIndexed");
        _glGetFragDataIndex = (delegate* unmanaged<uint, byte*, int>)QuickGL.GetGLProcAddress("glGetFragDataIndex");
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
        _glQueryCounter = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glQueryCounter");
        _glGetQueryObjecti64v = (delegate* unmanaged<uint, uint, long*, void>)QuickGL.GetGLProcAddress("glGetQueryObjecti64v");
        _glGetQueryObjectui64v = (delegate* unmanaged<uint, uint, ulong*, void>)QuickGL.GetGLProcAddress("glGetQueryObjectui64v");
        _glVertexAttribDivisor = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribDivisor");
        _glVertexAttribP1ui = (delegate* unmanaged<uint, uint, bool, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribP1ui");
        _glVertexAttribP1uiv = (delegate* unmanaged<uint, uint, bool, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttribP1uiv");
        _glVertexAttribP2ui = (delegate* unmanaged<uint, uint, bool, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribP2ui");
        _glVertexAttribP2uiv = (delegate* unmanaged<uint, uint, bool, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttribP2uiv");
        _glVertexAttribP3ui = (delegate* unmanaged<uint, uint, bool, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribP3ui");
        _glVertexAttribP3uiv = (delegate* unmanaged<uint, uint, bool, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttribP3uiv");
        _glVertexAttribP4ui = (delegate* unmanaged<uint, uint, bool, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribP4ui");
        _glVertexAttribP4uiv = (delegate* unmanaged<uint, uint, bool, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttribP4uiv");
        _glVertexP2ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glVertexP2ui");
        _glVertexP2uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexP2uiv");
        _glVertexP3ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glVertexP3ui");
        _glVertexP3uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexP3uiv");
        _glVertexP4ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glVertexP4ui");
        _glVertexP4uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexP4uiv");
        _glTexCoordP1ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glTexCoordP1ui");
        _glTexCoordP1uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glTexCoordP1uiv");
        _glTexCoordP2ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glTexCoordP2ui");
        _glTexCoordP2uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glTexCoordP2uiv");
        _glTexCoordP3ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glTexCoordP3ui");
        _glTexCoordP3uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glTexCoordP3uiv");
        _glTexCoordP4ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glTexCoordP4ui");
        _glTexCoordP4uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glTexCoordP4uiv");
        _glMultiTexCoordP1ui = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glMultiTexCoordP1ui");
        _glMultiTexCoordP1uiv = (delegate* unmanaged<uint, uint, uint*, void>)QuickGL.GetGLProcAddress("glMultiTexCoordP1uiv");
        _glMultiTexCoordP2ui = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glMultiTexCoordP2ui");
        _glMultiTexCoordP2uiv = (delegate* unmanaged<uint, uint, uint*, void>)QuickGL.GetGLProcAddress("glMultiTexCoordP2uiv");
        _glMultiTexCoordP3ui = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glMultiTexCoordP3ui");
        _glMultiTexCoordP3uiv = (delegate* unmanaged<uint, uint, uint*, void>)QuickGL.GetGLProcAddress("glMultiTexCoordP3uiv");
        _glMultiTexCoordP4ui = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glMultiTexCoordP4ui");
        _glMultiTexCoordP4uiv = (delegate* unmanaged<uint, uint, uint*, void>)QuickGL.GetGLProcAddress("glMultiTexCoordP4uiv");
        _glNormalP3ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glNormalP3ui");
        _glNormalP3uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glNormalP3uiv");
        _glColorP3ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glColorP3ui");
        _glColorP3uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glColorP3uiv");
        _glColorP4ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glColorP4ui");
        _glColorP4uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glColorP4uiv");
        _glSecondaryColorP3ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glSecondaryColorP3ui");
        _glSecondaryColorP3uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glSecondaryColorP3uiv");
    }
    
    internal static void Unload()
    {
        _glBindFragDataLocationIndexed = null;
        _glGetFragDataIndex = null;
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
        _glQueryCounter = null;
        _glGetQueryObjecti64v = null;
        _glGetQueryObjectui64v = null;
        _glVertexAttribDivisor = null;
        _glVertexAttribP1ui = null;
        _glVertexAttribP1uiv = null;
        _glVertexAttribP2ui = null;
        _glVertexAttribP2uiv = null;
        _glVertexAttribP3ui = null;
        _glVertexAttribP3uiv = null;
        _glVertexAttribP4ui = null;
        _glVertexAttribP4uiv = null;
        _glVertexP2ui = null;
        _glVertexP2uiv = null;
        _glVertexP3ui = null;
        _glVertexP3uiv = null;
        _glVertexP4ui = null;
        _glVertexP4uiv = null;
        _glTexCoordP1ui = null;
        _glTexCoordP1uiv = null;
        _glTexCoordP2ui = null;
        _glTexCoordP2uiv = null;
        _glTexCoordP3ui = null;
        _glTexCoordP3uiv = null;
        _glTexCoordP4ui = null;
        _glTexCoordP4uiv = null;
        _glMultiTexCoordP1ui = null;
        _glMultiTexCoordP1uiv = null;
        _glMultiTexCoordP2ui = null;
        _glMultiTexCoordP2uiv = null;
        _glMultiTexCoordP3ui = null;
        _glMultiTexCoordP3uiv = null;
        _glMultiTexCoordP4ui = null;
        _glMultiTexCoordP4uiv = null;
        _glNormalP3ui = null;
        _glNormalP3uiv = null;
        _glColorP3ui = null;
        _glColorP3uiv = null;
        _glColorP4ui = null;
        _glColorP4uiv = null;
        _glSecondaryColorP3ui = null;
        _glSecondaryColorP3uiv = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_VERSION_3_3", false, false);
}
