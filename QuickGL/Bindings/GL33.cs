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

// Bindings generated at 2025-01-07 20:24:12.631051
namespace QuickGLNS.Bindings
{
    [GLFeature(false)]
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
        public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, byte* name) => _glBindFragDataLocationIndexed(program, colorNumber, index, name);
        [QGLNativeAPI("glBindFragDataLocationIndexed")] internal static delegate* unmanaged<uint, uint, uint, byte*, void> _glBindFragDataLocationIndexed = null;
        
        public static int glGetFragDataIndex(uint program, byte* name) => _glGetFragDataIndex(program, name);
        [QGLNativeAPI("glGetFragDataIndex")] internal static delegate* unmanaged<uint, byte*, int> _glGetFragDataIndex = null;
        
        public static void glGenSamplers(int count, uint* samplers) => _glGenSamplers(count, samplers);
        [QGLNativeAPI("glGenSamplers")] internal static delegate* unmanaged<int, uint*, void> _glGenSamplers = null;
        
        public static void glDeleteSamplers(int count, uint* samplers) => _glDeleteSamplers(count, samplers);
        [QGLNativeAPI("glDeleteSamplers")] internal static delegate* unmanaged<int, uint*, void> _glDeleteSamplers = null;
        
        public static bool glIsSampler(uint sampler) => _glIsSampler(sampler);
        [QGLNativeAPI("glIsSampler")] internal static delegate* unmanaged<uint, bool> _glIsSampler = null;
        
        public static void glBindSampler(uint unit, uint sampler) => _glBindSampler(unit, sampler);
        [QGLNativeAPI("glBindSampler")] internal static delegate* unmanaged<uint, uint, void> _glBindSampler = null;
        
        public static void glSamplerParameteri(uint sampler, uint pname, int param) => _glSamplerParameteri(sampler, pname, param);
        [QGLNativeAPI("glSamplerParameteri")] internal static delegate* unmanaged<uint, uint, int, void> _glSamplerParameteri = null;
        
        public static void glSamplerParameteriv(uint sampler, uint pname, int* param) => _glSamplerParameteriv(sampler, pname, param);
        [QGLNativeAPI("glSamplerParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glSamplerParameteriv = null;
        
        public static void glSamplerParameterf(uint sampler, uint pname, float param) => _glSamplerParameterf(sampler, pname, param);
        [QGLNativeAPI("glSamplerParameterf")] internal static delegate* unmanaged<uint, uint, float, void> _glSamplerParameterf = null;
        
        public static void glSamplerParameterfv(uint sampler, uint pname, float* param) => _glSamplerParameterfv(sampler, pname, param);
        [QGLNativeAPI("glSamplerParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glSamplerParameterfv = null;
        
        public static void glSamplerParameterIiv(uint sampler, uint pname, int* param) => _glSamplerParameterIiv(sampler, pname, param);
        [QGLNativeAPI("glSamplerParameterIiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glSamplerParameterIiv = null;
        
        public static void glSamplerParameterIuiv(uint sampler, uint pname, uint* param) => _glSamplerParameterIuiv(sampler, pname, param);
        [QGLNativeAPI("glSamplerParameterIuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glSamplerParameterIuiv = null;
        
        public static void glGetSamplerParameteriv(uint sampler, uint pname, int* @params) => _glGetSamplerParameteriv(sampler, pname, @params);
        [QGLNativeAPI("glGetSamplerParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetSamplerParameteriv = null;
        
        public static void glGetSamplerParameterIiv(uint sampler, uint pname, int* @params) => _glGetSamplerParameterIiv(sampler, pname, @params);
        [QGLNativeAPI("glGetSamplerParameterIiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetSamplerParameterIiv = null;
        
        public static void glGetSamplerParameterfv(uint sampler, uint pname, float* @params) => _glGetSamplerParameterfv(sampler, pname, @params);
        [QGLNativeAPI("glGetSamplerParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetSamplerParameterfv = null;
        
        public static void glGetSamplerParameterIuiv(uint sampler, uint pname, uint* @params) => _glGetSamplerParameterIuiv(sampler, pname, @params);
        [QGLNativeAPI("glGetSamplerParameterIuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glGetSamplerParameterIuiv = null;
        
        public static void glQueryCounter(uint id, uint target) => _glQueryCounter(id, target);
        [QGLNativeAPI("glQueryCounter")] internal static delegate* unmanaged<uint, uint, void> _glQueryCounter = null;
        
        public static void glGetQueryObjecti64v(uint id, uint pname, long* @params) => _glGetQueryObjecti64v(id, pname, @params);
        [QGLNativeAPI("glGetQueryObjecti64v")] internal static delegate* unmanaged<uint, uint, long*, void> _glGetQueryObjecti64v = null;
        
        public static void glGetQueryObjectui64v(uint id, uint pname, ulong* @params) => _glGetQueryObjectui64v(id, pname, @params);
        [QGLNativeAPI("glGetQueryObjectui64v")] internal static delegate* unmanaged<uint, uint, ulong*, void> _glGetQueryObjectui64v = null;
        
        public static void glVertexAttribDivisor(uint index, uint divisor) => _glVertexAttribDivisor(index, divisor);
        [QGLNativeAPI("glVertexAttribDivisor")] internal static delegate* unmanaged<uint, uint, void> _glVertexAttribDivisor = null;
        
        public static void glVertexAttribP1ui(uint index, uint type, bool normalized, uint value) => _glVertexAttribP1ui(index, type, normalized, value);
        [QGLNativeAPI("glVertexAttribP1ui")] internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP1ui = null;
        
        public static void glVertexAttribP1uiv(uint index, uint type, bool normalized, uint* value) => _glVertexAttribP1uiv(index, type, normalized, value);
        [QGLNativeAPI("glVertexAttribP1uiv")] internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP1uiv = null;
        
        public static void glVertexAttribP2ui(uint index, uint type, bool normalized, uint value) => _glVertexAttribP2ui(index, type, normalized, value);
        [QGLNativeAPI("glVertexAttribP2ui")] internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP2ui = null;
        
        public static void glVertexAttribP2uiv(uint index, uint type, bool normalized, uint* value) => _glVertexAttribP2uiv(index, type, normalized, value);
        [QGLNativeAPI("glVertexAttribP2uiv")] internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP2uiv = null;
        
        public static void glVertexAttribP3ui(uint index, uint type, bool normalized, uint value) => _glVertexAttribP3ui(index, type, normalized, value);
        [QGLNativeAPI("glVertexAttribP3ui")] internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP3ui = null;
        
        public static void glVertexAttribP3uiv(uint index, uint type, bool normalized, uint* value) => _glVertexAttribP3uiv(index, type, normalized, value);
        [QGLNativeAPI("glVertexAttribP3uiv")] internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP3uiv = null;
        
        public static void glVertexAttribP4ui(uint index, uint type, bool normalized, uint value) => _glVertexAttribP4ui(index, type, normalized, value);
        [QGLNativeAPI("glVertexAttribP4ui")] internal static delegate* unmanaged<uint, uint, bool, uint, void> _glVertexAttribP4ui = null;
        
        public static void glVertexAttribP4uiv(uint index, uint type, bool normalized, uint* value) => _glVertexAttribP4uiv(index, type, normalized, value);
        [QGLNativeAPI("glVertexAttribP4uiv")] internal static delegate* unmanaged<uint, uint, bool, uint*, void> _glVertexAttribP4uiv = null;
        
        public static void glVertexP2ui(uint type, uint value) => _glVertexP2ui(type, value);
        [QGLNativeAPI("glVertexP2ui")] internal static delegate* unmanaged<uint, uint, void> _glVertexP2ui = null;
        
        public static void glVertexP2uiv(uint type, uint* value) => _glVertexP2uiv(type, value);
        [QGLNativeAPI("glVertexP2uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexP2uiv = null;
        
        public static void glVertexP3ui(uint type, uint value) => _glVertexP3ui(type, value);
        [QGLNativeAPI("glVertexP3ui")] internal static delegate* unmanaged<uint, uint, void> _glVertexP3ui = null;
        
        public static void glVertexP3uiv(uint type, uint* value) => _glVertexP3uiv(type, value);
        [QGLNativeAPI("glVertexP3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexP3uiv = null;
        
        public static void glVertexP4ui(uint type, uint value) => _glVertexP4ui(type, value);
        [QGLNativeAPI("glVertexP4ui")] internal static delegate* unmanaged<uint, uint, void> _glVertexP4ui = null;
        
        public static void glVertexP4uiv(uint type, uint* value) => _glVertexP4uiv(type, value);
        [QGLNativeAPI("glVertexP4uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexP4uiv = null;
        
        public static void glTexCoordP1ui(uint type, uint coords) => _glTexCoordP1ui(type, coords);
        [QGLNativeAPI("glTexCoordP1ui")] internal static delegate* unmanaged<uint, uint, void> _glTexCoordP1ui = null;
        
        public static void glTexCoordP1uiv(uint type, uint* coords) => _glTexCoordP1uiv(type, coords);
        [QGLNativeAPI("glTexCoordP1uiv")] internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP1uiv = null;
        
        public static void glTexCoordP2ui(uint type, uint coords) => _glTexCoordP2ui(type, coords);
        [QGLNativeAPI("glTexCoordP2ui")] internal static delegate* unmanaged<uint, uint, void> _glTexCoordP2ui = null;
        
        public static void glTexCoordP2uiv(uint type, uint* coords) => _glTexCoordP2uiv(type, coords);
        [QGLNativeAPI("glTexCoordP2uiv")] internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP2uiv = null;
        
        public static void glTexCoordP3ui(uint type, uint coords) => _glTexCoordP3ui(type, coords);
        [QGLNativeAPI("glTexCoordP3ui")] internal static delegate* unmanaged<uint, uint, void> _glTexCoordP3ui = null;
        
        public static void glTexCoordP3uiv(uint type, uint* coords) => _glTexCoordP3uiv(type, coords);
        [QGLNativeAPI("glTexCoordP3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP3uiv = null;
        
        public static void glTexCoordP4ui(uint type, uint coords) => _glTexCoordP4ui(type, coords);
        [QGLNativeAPI("glTexCoordP4ui")] internal static delegate* unmanaged<uint, uint, void> _glTexCoordP4ui = null;
        
        public static void glTexCoordP4uiv(uint type, uint* coords) => _glTexCoordP4uiv(type, coords);
        [QGLNativeAPI("glTexCoordP4uiv")] internal static delegate* unmanaged<uint, uint*, void> _glTexCoordP4uiv = null;
        
        public static void glMultiTexCoordP1ui(uint texture, uint type, uint coords) => _glMultiTexCoordP1ui(texture, type, coords);
        [QGLNativeAPI("glMultiTexCoordP1ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP1ui = null;
        
        public static void glMultiTexCoordP1uiv(uint texture, uint type, uint* coords) => _glMultiTexCoordP1uiv(texture, type, coords);
        [QGLNativeAPI("glMultiTexCoordP1uiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP1uiv = null;
        
        public static void glMultiTexCoordP2ui(uint texture, uint type, uint coords) => _glMultiTexCoordP2ui(texture, type, coords);
        [QGLNativeAPI("glMultiTexCoordP2ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP2ui = null;
        
        public static void glMultiTexCoordP2uiv(uint texture, uint type, uint* coords) => _glMultiTexCoordP2uiv(texture, type, coords);
        [QGLNativeAPI("glMultiTexCoordP2uiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP2uiv = null;
        
        public static void glMultiTexCoordP3ui(uint texture, uint type, uint coords) => _glMultiTexCoordP3ui(texture, type, coords);
        [QGLNativeAPI("glMultiTexCoordP3ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP3ui = null;
        
        public static void glMultiTexCoordP3uiv(uint texture, uint type, uint* coords) => _glMultiTexCoordP3uiv(texture, type, coords);
        [QGLNativeAPI("glMultiTexCoordP3uiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP3uiv = null;
        
        public static void glMultiTexCoordP4ui(uint texture, uint type, uint coords) => _glMultiTexCoordP4ui(texture, type, coords);
        [QGLNativeAPI("glMultiTexCoordP4ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glMultiTexCoordP4ui = null;
        
        public static void glMultiTexCoordP4uiv(uint texture, uint type, uint* coords) => _glMultiTexCoordP4uiv(texture, type, coords);
        [QGLNativeAPI("glMultiTexCoordP4uiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glMultiTexCoordP4uiv = null;
        
        public static void glNormalP3ui(uint type, uint coords) => _glNormalP3ui(type, coords);
        [QGLNativeAPI("glNormalP3ui")] internal static delegate* unmanaged<uint, uint, void> _glNormalP3ui = null;
        
        public static void glNormalP3uiv(uint type, uint* coords) => _glNormalP3uiv(type, coords);
        [QGLNativeAPI("glNormalP3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glNormalP3uiv = null;
        
        public static void glColorP3ui(uint type, uint color) => _glColorP3ui(type, color);
        [QGLNativeAPI("glColorP3ui")] internal static delegate* unmanaged<uint, uint, void> _glColorP3ui = null;
        
        public static void glColorP3uiv(uint type, uint* color) => _glColorP3uiv(type, color);
        [QGLNativeAPI("glColorP3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glColorP3uiv = null;
        
        public static void glColorP4ui(uint type, uint color) => _glColorP4ui(type, color);
        [QGLNativeAPI("glColorP4ui")] internal static delegate* unmanaged<uint, uint, void> _glColorP4ui = null;
        
        public static void glColorP4uiv(uint type, uint* color) => _glColorP4uiv(type, color);
        [QGLNativeAPI("glColorP4uiv")] internal static delegate* unmanaged<uint, uint*, void> _glColorP4uiv = null;
        
        public static void glSecondaryColorP3ui(uint type, uint color) => _glSecondaryColorP3ui(type, color);
        [QGLNativeAPI("glSecondaryColorP3ui")] internal static delegate* unmanaged<uint, uint, void> _glSecondaryColorP3ui = null;
        
        public static void glSecondaryColorP3uiv(uint type, uint* color) => _glSecondaryColorP3uiv(type, color);
        [QGLNativeAPI("glSecondaryColorP3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glSecondaryColorP3uiv = null;
        #endregion
    }
}
