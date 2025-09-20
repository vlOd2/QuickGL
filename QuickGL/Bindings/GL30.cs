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

// Bindings generated at 2025-09-20 18:58:19.753433
namespace QuickGLNS.Bindings;

public static unsafe class GL30
{
    #region Enums
    public const int GL_COMPARE_REF_TO_TEXTURE = 0x884E;
    public const int GL_CLIP_DISTANCE0 = 0x3000;
    public const int GL_CLIP_DISTANCE1 = 0x3001;
    public const int GL_CLIP_DISTANCE2 = 0x3002;
    public const int GL_CLIP_DISTANCE3 = 0x3003;
    public const int GL_CLIP_DISTANCE4 = 0x3004;
    public const int GL_CLIP_DISTANCE5 = 0x3005;
    public const int GL_CLIP_DISTANCE6 = 0x3006;
    public const int GL_CLIP_DISTANCE7 = 0x3007;
    public const int GL_MAX_CLIP_DISTANCES = 0xD32;
    public const int GL_MAJOR_VERSION = 0x821B;
    public const int GL_MINOR_VERSION = 0x821C;
    public const int GL_NUM_EXTENSIONS = 0x821D;
    public const int GL_CONTEXT_FLAGS = 0x821E;
    public const int GL_COMPRESSED_RED = 0x8225;
    public const int GL_COMPRESSED_RG = 0x8226;
    public const int GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x1;
    public const int GL_RGBA32F = 0x8814;
    public const int GL_RGB32F = 0x8815;
    public const int GL_RGBA16F = 0x881A;
    public const int GL_RGB16F = 0x881B;
    public const int GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
    public const int GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
    public const int GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
    public const int GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
    public const int GL_CLAMP_READ_COLOR = 0x891C;
    public const int GL_FIXED_ONLY = 0x891D;
    public const int GL_MAX_VARYING_COMPONENTS = 0x8B4B;
    public const int GL_TEXTURE_1D_ARRAY = 0x8C18;
    public const int GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19;
    public const int GL_TEXTURE_2D_ARRAY = 0x8C1A;
    public const int GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
    public const int GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
    public const int GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
    public const int GL_R11F_G11F_B10F = 0x8C3A;
    public const int GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
    public const int GL_RGB9_E5 = 0x8C3D;
    public const int GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
    public const int GL_TEXTURE_SHARED_SIZE = 0x8C3F;
    public const int GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
    public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
    public const int GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
    public const int GL_PRIMITIVES_GENERATED = 0x8C87;
    public const int GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
    public const int GL_RASTERIZER_DISCARD = 0x8C89;
    public const int GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
    public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
    public const int GL_INTERLEAVED_ATTRIBS = 0x8C8C;
    public const int GL_SEPARATE_ATTRIBS = 0x8C8D;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
    public const int GL_RGBA32UI = 0x8D70;
    public const int GL_RGB32UI = 0x8D71;
    public const int GL_RGBA16UI = 0x8D76;
    public const int GL_RGB16UI = 0x8D77;
    public const int GL_RGBA8UI = 0x8D7C;
    public const int GL_RGB8UI = 0x8D7D;
    public const int GL_RGBA32I = 0x8D82;
    public const int GL_RGB32I = 0x8D83;
    public const int GL_RGBA16I = 0x8D88;
    public const int GL_RGB16I = 0x8D89;
    public const int GL_RGBA8I = 0x8D8E;
    public const int GL_RGB8I = 0x8D8F;
    public const int GL_RED_INTEGER = 0x8D94;
    public const int GL_GREEN_INTEGER = 0x8D95;
    public const int GL_BLUE_INTEGER = 0x8D96;
    public const int GL_RGB_INTEGER = 0x8D98;
    public const int GL_RGBA_INTEGER = 0x8D99;
    public const int GL_BGR_INTEGER = 0x8D9A;
    public const int GL_BGRA_INTEGER = 0x8D9B;
    public const int GL_SAMPLER_1D_ARRAY = 0x8DC0;
    public const int GL_SAMPLER_2D_ARRAY = 0x8DC1;
    public const int GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
    public const int GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
    public const int GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
    public const int GL_UNSIGNED_INT_VEC2 = 0x8DC6;
    public const int GL_UNSIGNED_INT_VEC3 = 0x8DC7;
    public const int GL_UNSIGNED_INT_VEC4 = 0x8DC8;
    public const int GL_INT_SAMPLER_1D = 0x8DC9;
    public const int GL_INT_SAMPLER_2D = 0x8DCA;
    public const int GL_INT_SAMPLER_3D = 0x8DCB;
    public const int GL_INT_SAMPLER_CUBE = 0x8DCC;
    public const int GL_INT_SAMPLER_1D_ARRAY = 0x8DCE;
    public const int GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
    public const int GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
    public const int GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
    public const int GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
    public const int GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
    public const int GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
    public const int GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
    public const int GL_QUERY_WAIT = 0x8E13;
    public const int GL_QUERY_NO_WAIT = 0x8E14;
    public const int GL_QUERY_BY_REGION_WAIT = 0x8E15;
    public const int GL_QUERY_BY_REGION_NO_WAIT = 0x8E16;
    public const int GL_BUFFER_ACCESS_FLAGS = 0x911F;
    public const int GL_BUFFER_MAP_LENGTH = 0x9120;
    public const int GL_BUFFER_MAP_OFFSET = 0x9121;
    public const int GL_DEPTH_COMPONENT32F = 0x8CAC;
    public const int GL_DEPTH32F_STENCIL8 = 0x8CAD;
    public const int GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
    public const int GL_INVALID_FRAMEBUFFER_OPERATION = 0x506;
    public const int GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
    public const int GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
    public const int GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
    public const int GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
    public const int GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
    public const int GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
    public const int GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
    public const int GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
    public const int GL_FRAMEBUFFER_DEFAULT = 0x8218;
    public const int GL_FRAMEBUFFER_UNDEFINED = 0x8219;
    public const int GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
    public const int GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
    public const int GL_DEPTH_STENCIL = 0x84F9;
    public const int GL_UNSIGNED_INT_24_8 = 0x84FA;
    public const int GL_DEPTH24_STENCIL8 = 0x88F0;
    public const int GL_TEXTURE_STENCIL_SIZE = 0x88F1;
    public const int GL_TEXTURE_RED_TYPE = 0x8C10;
    public const int GL_TEXTURE_GREEN_TYPE = 0x8C11;
    public const int GL_TEXTURE_BLUE_TYPE = 0x8C12;
    public const int GL_TEXTURE_ALPHA_TYPE = 0x8C13;
    public const int GL_TEXTURE_DEPTH_TYPE = 0x8C16;
    public const int GL_UNSIGNED_NORMALIZED = 0x8C17;
    public const int GL_FRAMEBUFFER_BINDING = 0x8CA6;
    public const int GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
    public const int GL_RENDERBUFFER_BINDING = 0x8CA7;
    public const int GL_READ_FRAMEBUFFER = 0x8CA8;
    public const int GL_DRAW_FRAMEBUFFER = 0x8CA9;
    public const int GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
    public const int GL_RENDERBUFFER_SAMPLES = 0x8CAB;
    public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
    public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
    public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
    public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
    public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
    public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
    public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
    public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
    public const int GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
    public const int GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
    public const int GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
    public const int GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
    public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;
    public const int GL_COLOR_ATTACHMENT1 = 0x8CE1;
    public const int GL_COLOR_ATTACHMENT2 = 0x8CE2;
    public const int GL_COLOR_ATTACHMENT3 = 0x8CE3;
    public const int GL_COLOR_ATTACHMENT4 = 0x8CE4;
    public const int GL_COLOR_ATTACHMENT5 = 0x8CE5;
    public const int GL_COLOR_ATTACHMENT6 = 0x8CE6;
    public const int GL_COLOR_ATTACHMENT7 = 0x8CE7;
    public const int GL_COLOR_ATTACHMENT8 = 0x8CE8;
    public const int GL_COLOR_ATTACHMENT9 = 0x8CE9;
    public const int GL_COLOR_ATTACHMENT10 = 0x8CEA;
    public const int GL_COLOR_ATTACHMENT11 = 0x8CEB;
    public const int GL_COLOR_ATTACHMENT12 = 0x8CEC;
    public const int GL_COLOR_ATTACHMENT13 = 0x8CED;
    public const int GL_COLOR_ATTACHMENT14 = 0x8CEE;
    public const int GL_COLOR_ATTACHMENT15 = 0x8CEF;
    public const int GL_COLOR_ATTACHMENT16 = 0x8CF0;
    public const int GL_COLOR_ATTACHMENT17 = 0x8CF1;
    public const int GL_COLOR_ATTACHMENT18 = 0x8CF2;
    public const int GL_COLOR_ATTACHMENT19 = 0x8CF3;
    public const int GL_COLOR_ATTACHMENT20 = 0x8CF4;
    public const int GL_COLOR_ATTACHMENT21 = 0x8CF5;
    public const int GL_COLOR_ATTACHMENT22 = 0x8CF6;
    public const int GL_COLOR_ATTACHMENT23 = 0x8CF7;
    public const int GL_COLOR_ATTACHMENT24 = 0x8CF8;
    public const int GL_COLOR_ATTACHMENT25 = 0x8CF9;
    public const int GL_COLOR_ATTACHMENT26 = 0x8CFA;
    public const int GL_COLOR_ATTACHMENT27 = 0x8CFB;
    public const int GL_COLOR_ATTACHMENT28 = 0x8CFC;
    public const int GL_COLOR_ATTACHMENT29 = 0x8CFD;
    public const int GL_COLOR_ATTACHMENT30 = 0x8CFE;
    public const int GL_COLOR_ATTACHMENT31 = 0x8CFF;
    public const int GL_DEPTH_ATTACHMENT = 0x8D00;
    public const int GL_STENCIL_ATTACHMENT = 0x8D20;
    public const int GL_FRAMEBUFFER = 0x8D40;
    public const int GL_RENDERBUFFER = 0x8D41;
    public const int GL_RENDERBUFFER_WIDTH = 0x8D42;
    public const int GL_RENDERBUFFER_HEIGHT = 0x8D43;
    public const int GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
    public const int GL_STENCIL_INDEX1 = 0x8D46;
    public const int GL_STENCIL_INDEX4 = 0x8D47;
    public const int GL_STENCIL_INDEX8 = 0x8D48;
    public const int GL_STENCIL_INDEX16 = 0x8D49;
    public const int GL_RENDERBUFFER_RED_SIZE = 0x8D50;
    public const int GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
    public const int GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
    public const int GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
    public const int GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
    public const int GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
    public const int GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
    public const int GL_MAX_SAMPLES = 0x8D57;
    public const int GL_INDEX = 0x8222;
    public const int GL_TEXTURE_LUMINANCE_TYPE = 0x8C14;
    public const int GL_TEXTURE_INTENSITY_TYPE = 0x8C15;
    public const int GL_FRAMEBUFFER_SRGB = 0x8DB9;
    public const int GL_HALF_FLOAT = 0x140B;
    public const int GL_MAP_READ_BIT = 0x1;
    public const int GL_MAP_WRITE_BIT = 0x2;
    public const int GL_MAP_INVALIDATE_RANGE_BIT = 0x4;
    public const int GL_MAP_INVALIDATE_BUFFER_BIT = 0x8;
    public const int GL_MAP_FLUSH_EXPLICIT_BIT = 0x10;
    public const int GL_MAP_UNSYNCHRONIZED_BIT = 0x20;
    public const int GL_COMPRESSED_RED_RGTC1 = 0x8DBB;
    public const int GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
    public const int GL_COMPRESSED_RG_RGTC2 = 0x8DBD;
    public const int GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
    public const int GL_RG = 0x8227;
    public const int GL_RG_INTEGER = 0x8228;
    public const int GL_R8 = 0x8229;
    public const int GL_R16 = 0x822A;
    public const int GL_RG8 = 0x822B;
    public const int GL_RG16 = 0x822C;
    public const int GL_R16F = 0x822D;
    public const int GL_R32F = 0x822E;
    public const int GL_RG16F = 0x822F;
    public const int GL_RG32F = 0x8230;
    public const int GL_R8I = 0x8231;
    public const int GL_R8UI = 0x8232;
    public const int GL_R16I = 0x8233;
    public const int GL_R16UI = 0x8234;
    public const int GL_R32I = 0x8235;
    public const int GL_R32UI = 0x8236;
    public const int GL_RG8I = 0x8237;
    public const int GL_RG8UI = 0x8238;
    public const int GL_RG16I = 0x8239;
    public const int GL_RG16UI = 0x823A;
    public const int GL_RG32I = 0x823B;
    public const int GL_RG32UI = 0x823C;
    public const int GL_VERTEX_ARRAY_BINDING = 0x85B5;
    public const int GL_CLAMP_VERTEX_COLOR = 0x891A;
    public const int GL_CLAMP_FRAGMENT_COLOR = 0x891B;
    public const int GL_ALPHA_INTEGER = 0x8D97;
    #endregion
    
    #region Commands
    public static void glColorMaski(uint index, bool r, bool g, bool b, bool a) { QGLFeature.VerifyFunc((nint)_glColorMaski); _glColorMaski(index, r, g, b, a); }
    internal static delegate* unmanaged<uint, bool, bool, bool, bool, void> _glColorMaski = null;
    
    public static void glGetBooleani_v(uint target, uint index, bool* data) { QGLFeature.VerifyFunc((nint)_glGetBooleani_v); _glGetBooleani_v(target, index, data); }
    internal static delegate* unmanaged<uint, uint, bool*, void> _glGetBooleani_v = null;
    
    public static void glGetIntegeri_v(uint target, uint index, int* data) { QGLFeature.VerifyFunc((nint)_glGetIntegeri_v); _glGetIntegeri_v(target, index, data); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetIntegeri_v = null;
    
    public static void glEnablei(uint target, uint index) { QGLFeature.VerifyFunc((nint)_glEnablei); _glEnablei(target, index); }
    internal static delegate* unmanaged<uint, uint, void> _glEnablei = null;
    
    public static void glDisablei(uint target, uint index) { QGLFeature.VerifyFunc((nint)_glDisablei); _glDisablei(target, index); }
    internal static delegate* unmanaged<uint, uint, void> _glDisablei = null;
    
    public static bool glIsEnabledi(uint target, uint index) { QGLFeature.VerifyFunc((nint)_glIsEnabledi); return _glIsEnabledi(target, index); }
    internal static delegate* unmanaged<uint, uint, bool> _glIsEnabledi = null;
    
    public static void glBeginTransformFeedback(uint primitiveMode) { QGLFeature.VerifyFunc((nint)_glBeginTransformFeedback); _glBeginTransformFeedback(primitiveMode); }
    internal static delegate* unmanaged<uint, void> _glBeginTransformFeedback = null;
    
    public static void glEndTransformFeedback() { QGLFeature.VerifyFunc((nint)_glEndTransformFeedback); _glEndTransformFeedback(); }
    internal static delegate* unmanaged<void> _glEndTransformFeedback = null;
    
    public static void glBindBufferRange(uint target, uint index, uint buffer, nint offset, nint size) { QGLFeature.VerifyFunc((nint)_glBindBufferRange); _glBindBufferRange(target, index, buffer, offset, size); }
    internal static delegate* unmanaged<uint, uint, uint, nint, nint, void> _glBindBufferRange = null;
    
    public static void glBindBufferBase(uint target, uint index, uint buffer) { QGLFeature.VerifyFunc((nint)_glBindBufferBase); _glBindBufferBase(target, index, buffer); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glBindBufferBase = null;
    
    public static void glTransformFeedbackVaryings(uint program, int count, byte** varyings, uint bufferMode) { QGLFeature.VerifyFunc((nint)_glTransformFeedbackVaryings); _glTransformFeedbackVaryings(program, count, varyings, bufferMode); }
    internal static delegate* unmanaged<uint, int, byte**, uint, void> _glTransformFeedbackVaryings = null;
    
    public static void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name) { QGLFeature.VerifyFunc((nint)_glGetTransformFeedbackVarying); _glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name); }
    internal static delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void> _glGetTransformFeedbackVarying = null;
    
    public static void glClampColor(uint target, uint clamp) { QGLFeature.VerifyFunc((nint)_glClampColor); _glClampColor(target, clamp); }
    internal static delegate* unmanaged<uint, uint, void> _glClampColor = null;
    
    public static void glBeginConditionalRender(uint id, uint mode) { QGLFeature.VerifyFunc((nint)_glBeginConditionalRender); _glBeginConditionalRender(id, mode); }
    internal static delegate* unmanaged<uint, uint, void> _glBeginConditionalRender = null;
    
    public static void glEndConditionalRender() { QGLFeature.VerifyFunc((nint)_glEndConditionalRender); _glEndConditionalRender(); }
    internal static delegate* unmanaged<void> _glEndConditionalRender = null;
    
    public static void glVertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glVertexAttribIPointer); _glVertexAttribIPointer(index, size, type, stride, pointer); }
    internal static delegate* unmanaged<uint, int, uint, int, void*, void> _glVertexAttribIPointer = null;
    
    public static void glGetVertexAttribIiv(uint index, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribIiv); _glGetVertexAttribIiv(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetVertexAttribIiv = null;
    
    public static void glGetVertexAttribIuiv(uint index, uint pname, uint* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribIuiv); _glGetVertexAttribIuiv(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, uint*, void> _glGetVertexAttribIuiv = null;
    
    public static void glVertexAttribI1i(uint index, int x) { QGLFeature.VerifyFunc((nint)_glVertexAttribI1i); _glVertexAttribI1i(index, x); }
    internal static delegate* unmanaged<uint, int, void> _glVertexAttribI1i = null;
    
    public static void glVertexAttribI2i(uint index, int x, int y) { QGLFeature.VerifyFunc((nint)_glVertexAttribI2i); _glVertexAttribI2i(index, x, y); }
    internal static delegate* unmanaged<uint, int, int, void> _glVertexAttribI2i = null;
    
    public static void glVertexAttribI3i(uint index, int x, int y, int z) { QGLFeature.VerifyFunc((nint)_glVertexAttribI3i); _glVertexAttribI3i(index, x, y, z); }
    internal static delegate* unmanaged<uint, int, int, int, void> _glVertexAttribI3i = null;
    
    public static void glVertexAttribI4i(uint index, int x, int y, int z, int w) { QGLFeature.VerifyFunc((nint)_glVertexAttribI4i); _glVertexAttribI4i(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, int, int, int, int, void> _glVertexAttribI4i = null;
    
    public static void glVertexAttribI1ui(uint index, uint x) { QGLFeature.VerifyFunc((nint)_glVertexAttribI1ui); _glVertexAttribI1ui(index, x); }
    internal static delegate* unmanaged<uint, uint, void> _glVertexAttribI1ui = null;
    
    public static void glVertexAttribI2ui(uint index, uint x, uint y) { QGLFeature.VerifyFunc((nint)_glVertexAttribI2ui); _glVertexAttribI2ui(index, x, y); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glVertexAttribI2ui = null;
    
    public static void glVertexAttribI3ui(uint index, uint x, uint y, uint z) { QGLFeature.VerifyFunc((nint)_glVertexAttribI3ui); _glVertexAttribI3ui(index, x, y, z); }
    internal static delegate* unmanaged<uint, uint, uint, uint, void> _glVertexAttribI3ui = null;
    
    public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) { QGLFeature.VerifyFunc((nint)_glVertexAttribI4ui); _glVertexAttribI4ui(index, x, y, z, w); }
    internal static delegate* unmanaged<uint, uint, uint, uint, uint, void> _glVertexAttribI4ui = null;
    
    public static void glVertexAttribI1iv(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI1iv); _glVertexAttribI1iv(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glVertexAttribI1iv = null;
    
    public static void glVertexAttribI2iv(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI2iv); _glVertexAttribI2iv(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glVertexAttribI2iv = null;
    
    public static void glVertexAttribI3iv(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI3iv); _glVertexAttribI3iv(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glVertexAttribI3iv = null;
    
    public static void glVertexAttribI4iv(uint index, int* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI4iv); _glVertexAttribI4iv(index, v); }
    internal static delegate* unmanaged<uint, int*, void> _glVertexAttribI4iv = null;
    
    public static void glVertexAttribI1uiv(uint index, uint* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI1uiv); _glVertexAttribI1uiv(index, v); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexAttribI1uiv = null;
    
    public static void glVertexAttribI2uiv(uint index, uint* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI2uiv); _glVertexAttribI2uiv(index, v); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexAttribI2uiv = null;
    
    public static void glVertexAttribI3uiv(uint index, uint* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI3uiv); _glVertexAttribI3uiv(index, v); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexAttribI3uiv = null;
    
    public static void glVertexAttribI4uiv(uint index, uint* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI4uiv); _glVertexAttribI4uiv(index, v); }
    internal static delegate* unmanaged<uint, uint*, void> _glVertexAttribI4uiv = null;
    
    public static void glVertexAttribI4bv(uint index, sbyte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI4bv); _glVertexAttribI4bv(index, v); }
    internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttribI4bv = null;
    
    public static void glVertexAttribI4sv(uint index, short* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI4sv); _glVertexAttribI4sv(index, v); }
    internal static delegate* unmanaged<uint, short*, void> _glVertexAttribI4sv = null;
    
    public static void glVertexAttribI4ubv(uint index, byte* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI4ubv); _glVertexAttribI4ubv(index, v); }
    internal static delegate* unmanaged<uint, byte*, void> _glVertexAttribI4ubv = null;
    
    public static void glVertexAttribI4usv(uint index, ushort* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribI4usv); _glVertexAttribI4usv(index, v); }
    internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttribI4usv = null;
    
    public static void glGetUniformuiv(uint program, int location, uint* @params) { QGLFeature.VerifyFunc((nint)_glGetUniformuiv); _glGetUniformuiv(program, location, @params); }
    internal static delegate* unmanaged<uint, int, uint*, void> _glGetUniformuiv = null;
    
    public static void glBindFragDataLocation(uint program, uint color, byte* name) { QGLFeature.VerifyFunc((nint)_glBindFragDataLocation); _glBindFragDataLocation(program, color, name); }
    internal static delegate* unmanaged<uint, uint, byte*, void> _glBindFragDataLocation = null;
    
    public static int glGetFragDataLocation(uint program, byte* name) { QGLFeature.VerifyFunc((nint)_glGetFragDataLocation); return _glGetFragDataLocation(program, name); }
    internal static delegate* unmanaged<uint, byte*, int> _glGetFragDataLocation = null;
    
    public static void glUniform1ui(int location, uint v0) { QGLFeature.VerifyFunc((nint)_glUniform1ui); _glUniform1ui(location, v0); }
    internal static delegate* unmanaged<int, uint, void> _glUniform1ui = null;
    
    public static void glUniform2ui(int location, uint v0, uint v1) { QGLFeature.VerifyFunc((nint)_glUniform2ui); _glUniform2ui(location, v0, v1); }
    internal static delegate* unmanaged<int, uint, uint, void> _glUniform2ui = null;
    
    public static void glUniform3ui(int location, uint v0, uint v1, uint v2) { QGLFeature.VerifyFunc((nint)_glUniform3ui); _glUniform3ui(location, v0, v1, v2); }
    internal static delegate* unmanaged<int, uint, uint, uint, void> _glUniform3ui = null;
    
    public static void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3) { QGLFeature.VerifyFunc((nint)_glUniform4ui); _glUniform4ui(location, v0, v1, v2, v3); }
    internal static delegate* unmanaged<int, uint, uint, uint, uint, void> _glUniform4ui = null;
    
    public static void glUniform1uiv(int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glUniform1uiv); _glUniform1uiv(location, count, value); }
    internal static delegate* unmanaged<int, int, uint*, void> _glUniform1uiv = null;
    
    public static void glUniform2uiv(int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glUniform2uiv); _glUniform2uiv(location, count, value); }
    internal static delegate* unmanaged<int, int, uint*, void> _glUniform2uiv = null;
    
    public static void glUniform3uiv(int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glUniform3uiv); _glUniform3uiv(location, count, value); }
    internal static delegate* unmanaged<int, int, uint*, void> _glUniform3uiv = null;
    
    public static void glUniform4uiv(int location, int count, uint* value) { QGLFeature.VerifyFunc((nint)_glUniform4uiv); _glUniform4uiv(location, count, value); }
    internal static delegate* unmanaged<int, int, uint*, void> _glUniform4uiv = null;
    
    public static void glTexParameterIiv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glTexParameterIiv); _glTexParameterIiv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glTexParameterIiv = null;
    
    public static void glTexParameterIuiv(uint target, uint pname, uint* @params) { QGLFeature.VerifyFunc((nint)_glTexParameterIuiv); _glTexParameterIuiv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, uint*, void> _glTexParameterIuiv = null;
    
    public static void glGetTexParameterIiv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetTexParameterIiv); _glGetTexParameterIiv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexParameterIiv = null;
    
    public static void glGetTexParameterIuiv(uint target, uint pname, uint* @params) { QGLFeature.VerifyFunc((nint)_glGetTexParameterIuiv); _glGetTexParameterIuiv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, uint*, void> _glGetTexParameterIuiv = null;
    
    public static void glClearBufferiv(uint buffer, int drawbuffer, int* value) { QGLFeature.VerifyFunc((nint)_glClearBufferiv); _glClearBufferiv(buffer, drawbuffer, value); }
    internal static delegate* unmanaged<uint, int, int*, void> _glClearBufferiv = null;
    
    public static void glClearBufferuiv(uint buffer, int drawbuffer, uint* value) { QGLFeature.VerifyFunc((nint)_glClearBufferuiv); _glClearBufferuiv(buffer, drawbuffer, value); }
    internal static delegate* unmanaged<uint, int, uint*, void> _glClearBufferuiv = null;
    
    public static void glClearBufferfv(uint buffer, int drawbuffer, float* value) { QGLFeature.VerifyFunc((nint)_glClearBufferfv); _glClearBufferfv(buffer, drawbuffer, value); }
    internal static delegate* unmanaged<uint, int, float*, void> _glClearBufferfv = null;
    
    public static void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil) { QGLFeature.VerifyFunc((nint)_glClearBufferfi); _glClearBufferfi(buffer, drawbuffer, depth, stencil); }
    internal static delegate* unmanaged<uint, int, float, int, void> _glClearBufferfi = null;
    
    public static byte* glGetStringi(uint name, uint index) { QGLFeature.VerifyFunc((nint)_glGetStringi); return _glGetStringi(name, index); }
    internal static delegate* unmanaged<uint, uint, byte*> _glGetStringi = null;
    
    public static bool glIsRenderbuffer(uint renderbuffer) { QGLFeature.VerifyFunc((nint)_glIsRenderbuffer); return _glIsRenderbuffer(renderbuffer); }
    internal static delegate* unmanaged<uint, bool> _glIsRenderbuffer = null;
    
    public static void glBindRenderbuffer(uint target, uint renderbuffer) { QGLFeature.VerifyFunc((nint)_glBindRenderbuffer); _glBindRenderbuffer(target, renderbuffer); }
    internal static delegate* unmanaged<uint, uint, void> _glBindRenderbuffer = null;
    
    public static void glDeleteRenderbuffers(int n, uint* renderbuffers) { QGLFeature.VerifyFunc((nint)_glDeleteRenderbuffers); _glDeleteRenderbuffers(n, renderbuffers); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteRenderbuffers = null;
    
    public static void glGenRenderbuffers(int n, uint* renderbuffers) { QGLFeature.VerifyFunc((nint)_glGenRenderbuffers); _glGenRenderbuffers(n, renderbuffers); }
    internal static delegate* unmanaged<int, uint*, void> _glGenRenderbuffers = null;
    
    public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height) { QGLFeature.VerifyFunc((nint)_glRenderbufferStorage); _glRenderbufferStorage(target, internalformat, width, height); }
    internal static delegate* unmanaged<uint, uint, int, int, void> _glRenderbufferStorage = null;
    
    public static void glGetRenderbufferParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetRenderbufferParameteriv); _glGetRenderbufferParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetRenderbufferParameteriv = null;
    
    public static bool glIsFramebuffer(uint framebuffer) { QGLFeature.VerifyFunc((nint)_glIsFramebuffer); return _glIsFramebuffer(framebuffer); }
    internal static delegate* unmanaged<uint, bool> _glIsFramebuffer = null;
    
    public static void glBindFramebuffer(uint target, uint framebuffer) { QGLFeature.VerifyFunc((nint)_glBindFramebuffer); _glBindFramebuffer(target, framebuffer); }
    internal static delegate* unmanaged<uint, uint, void> _glBindFramebuffer = null;
    
    public static void glDeleteFramebuffers(int n, uint* framebuffers) { QGLFeature.VerifyFunc((nint)_glDeleteFramebuffers); _glDeleteFramebuffers(n, framebuffers); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteFramebuffers = null;
    
    public static void glGenFramebuffers(int n, uint* framebuffers) { QGLFeature.VerifyFunc((nint)_glGenFramebuffers); _glGenFramebuffers(n, framebuffers); }
    internal static delegate* unmanaged<int, uint*, void> _glGenFramebuffers = null;
    
    public static uint glCheckFramebufferStatus(uint target) { QGLFeature.VerifyFunc((nint)_glCheckFramebufferStatus); return _glCheckFramebufferStatus(target); }
    internal static delegate* unmanaged<uint, uint> _glCheckFramebufferStatus = null;
    
    public static void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level) { QGLFeature.VerifyFunc((nint)_glFramebufferTexture1D); _glFramebufferTexture1D(target, attachment, textarget, texture, level); }
    internal static delegate* unmanaged<uint, uint, uint, uint, int, void> _glFramebufferTexture1D = null;
    
    public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) { QGLFeature.VerifyFunc((nint)_glFramebufferTexture2D); _glFramebufferTexture2D(target, attachment, textarget, texture, level); }
    internal static delegate* unmanaged<uint, uint, uint, uint, int, void> _glFramebufferTexture2D = null;
    
    public static void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) { QGLFeature.VerifyFunc((nint)_glFramebufferTexture3D); _glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset); }
    internal static delegate* unmanaged<uint, uint, uint, uint, int, int, void> _glFramebufferTexture3D = null;
    
    public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) { QGLFeature.VerifyFunc((nint)_glFramebufferRenderbuffer); _glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer); }
    internal static delegate* unmanaged<uint, uint, uint, uint, void> _glFramebufferRenderbuffer = null;
    
    public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetFramebufferAttachmentParameteriv); _glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params); }
    internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetFramebufferAttachmentParameteriv = null;
    
    public static void glGenerateMipmap(uint target) { QGLFeature.VerifyFunc((nint)_glGenerateMipmap); _glGenerateMipmap(target); }
    internal static delegate* unmanaged<uint, void> _glGenerateMipmap = null;
    
    public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) { QGLFeature.VerifyFunc((nint)_glBlitFramebuffer); _glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter); }
    internal static delegate* unmanaged<int, int, int, int, int, int, int, int, uint, uint, void> _glBlitFramebuffer = null;
    
    public static void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height) { QGLFeature.VerifyFunc((nint)_glRenderbufferStorageMultisample); _glRenderbufferStorageMultisample(target, samples, internalformat, width, height); }
    internal static delegate* unmanaged<uint, int, uint, int, int, void> _glRenderbufferStorageMultisample = null;
    
    public static void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer) { QGLFeature.VerifyFunc((nint)_glFramebufferTextureLayer); _glFramebufferTextureLayer(target, attachment, texture, level, layer); }
    internal static delegate* unmanaged<uint, uint, uint, int, int, void> _glFramebufferTextureLayer = null;
    
    public static void* glMapBufferRange(uint target, nint offset, nint length, uint access) { QGLFeature.VerifyFunc((nint)_glMapBufferRange); return _glMapBufferRange(target, offset, length, access); }
    internal static delegate* unmanaged<uint, nint, nint, uint, void*> _glMapBufferRange = null;
    
    public static void glFlushMappedBufferRange(uint target, nint offset, nint length) { QGLFeature.VerifyFunc((nint)_glFlushMappedBufferRange); _glFlushMappedBufferRange(target, offset, length); }
    internal static delegate* unmanaged<uint, nint, nint, void> _glFlushMappedBufferRange = null;
    
    public static void glBindVertexArray(uint array) { QGLFeature.VerifyFunc((nint)_glBindVertexArray); _glBindVertexArray(array); }
    internal static delegate* unmanaged<uint, void> _glBindVertexArray = null;
    
    public static void glDeleteVertexArrays(int n, uint* arrays) { QGLFeature.VerifyFunc((nint)_glDeleteVertexArrays); _glDeleteVertexArrays(n, arrays); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteVertexArrays = null;
    
    public static void glGenVertexArrays(int n, uint* arrays) { QGLFeature.VerifyFunc((nint)_glGenVertexArrays); _glGenVertexArrays(n, arrays); }
    internal static delegate* unmanaged<int, uint*, void> _glGenVertexArrays = null;
    
    public static bool glIsVertexArray(uint array) { QGLFeature.VerifyFunc((nint)_glIsVertexArray); return _glIsVertexArray(array); }
    internal static delegate* unmanaged<uint, bool> _glIsVertexArray = null;
     #endregion
    
    internal static void Load()
    {
        _glColorMaski = (delegate* unmanaged<uint, bool, bool, bool, bool, void>)QuickGL.GetGLProcAddress("glColorMaski");
        _glGetBooleani_v = (delegate* unmanaged<uint, uint, bool*, void>)QuickGL.GetGLProcAddress("glGetBooleani_v");
        _glGetIntegeri_v = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetIntegeri_v");
        _glEnablei = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glEnablei");
        _glDisablei = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glDisablei");
        _glIsEnabledi = (delegate* unmanaged<uint, uint, bool>)QuickGL.GetGLProcAddress("glIsEnabledi");
        _glBeginTransformFeedback = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glBeginTransformFeedback");
        _glEndTransformFeedback = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glEndTransformFeedback");
        _glBindBufferRange = (delegate* unmanaged<uint, uint, uint, nint, nint, void>)QuickGL.GetGLProcAddress("glBindBufferRange");
        _glBindBufferBase = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glBindBufferBase");
        _glTransformFeedbackVaryings = (delegate* unmanaged<uint, int, byte**, uint, void>)QuickGL.GetGLProcAddress("glTransformFeedbackVaryings");
        _glGetTransformFeedbackVarying = (delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void>)QuickGL.GetGLProcAddress("glGetTransformFeedbackVarying");
        _glClampColor = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glClampColor");
        _glBeginConditionalRender = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBeginConditionalRender");
        _glEndConditionalRender = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glEndConditionalRender");
        _glVertexAttribIPointer = (delegate* unmanaged<uint, int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glVertexAttribIPointer");
        _glGetVertexAttribIiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribIiv");
        _glGetVertexAttribIuiv = (delegate* unmanaged<uint, uint, uint*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribIuiv");
        _glVertexAttribI1i = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glVertexAttribI1i");
        _glVertexAttribI2i = (delegate* unmanaged<uint, int, int, void>)QuickGL.GetGLProcAddress("glVertexAttribI2i");
        _glVertexAttribI3i = (delegate* unmanaged<uint, int, int, int, void>)QuickGL.GetGLProcAddress("glVertexAttribI3i");
        _glVertexAttribI4i = (delegate* unmanaged<uint, int, int, int, int, void>)QuickGL.GetGLProcAddress("glVertexAttribI4i");
        _glVertexAttribI1ui = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribI1ui");
        _glVertexAttribI2ui = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribI2ui");
        _glVertexAttribI3ui = (delegate* unmanaged<uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribI3ui");
        _glVertexAttribI4ui = (delegate* unmanaged<uint, uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glVertexAttribI4ui");
        _glVertexAttribI1iv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glVertexAttribI1iv");
        _glVertexAttribI2iv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glVertexAttribI2iv");
        _glVertexAttribI3iv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glVertexAttribI3iv");
        _glVertexAttribI4iv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glVertexAttribI4iv");
        _glVertexAttribI1uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttribI1uiv");
        _glVertexAttribI2uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttribI2uiv");
        _glVertexAttribI3uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttribI3uiv");
        _glVertexAttribI4uiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glVertexAttribI4uiv");
        _glVertexAttribI4bv = (delegate* unmanaged<uint, sbyte*, void>)QuickGL.GetGLProcAddress("glVertexAttribI4bv");
        _glVertexAttribI4sv = (delegate* unmanaged<uint, short*, void>)QuickGL.GetGLProcAddress("glVertexAttribI4sv");
        _glVertexAttribI4ubv = (delegate* unmanaged<uint, byte*, void>)QuickGL.GetGLProcAddress("glVertexAttribI4ubv");
        _glVertexAttribI4usv = (delegate* unmanaged<uint, ushort*, void>)QuickGL.GetGLProcAddress("glVertexAttribI4usv");
        _glGetUniformuiv = (delegate* unmanaged<uint, int, uint*, void>)QuickGL.GetGLProcAddress("glGetUniformuiv");
        _glBindFragDataLocation = (delegate* unmanaged<uint, uint, byte*, void>)QuickGL.GetGLProcAddress("glBindFragDataLocation");
        _glGetFragDataLocation = (delegate* unmanaged<uint, byte*, int>)QuickGL.GetGLProcAddress("glGetFragDataLocation");
        _glUniform1ui = (delegate* unmanaged<int, uint, void>)QuickGL.GetGLProcAddress("glUniform1ui");
        _glUniform2ui = (delegate* unmanaged<int, uint, uint, void>)QuickGL.GetGLProcAddress("glUniform2ui");
        _glUniform3ui = (delegate* unmanaged<int, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glUniform3ui");
        _glUniform4ui = (delegate* unmanaged<int, uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glUniform4ui");
        _glUniform1uiv = (delegate* unmanaged<int, int, uint*, void>)QuickGL.GetGLProcAddress("glUniform1uiv");
        _glUniform2uiv = (delegate* unmanaged<int, int, uint*, void>)QuickGL.GetGLProcAddress("glUniform2uiv");
        _glUniform3uiv = (delegate* unmanaged<int, int, uint*, void>)QuickGL.GetGLProcAddress("glUniform3uiv");
        _glUniform4uiv = (delegate* unmanaged<int, int, uint*, void>)QuickGL.GetGLProcAddress("glUniform4uiv");
        _glTexParameterIiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glTexParameterIiv");
        _glTexParameterIuiv = (delegate* unmanaged<uint, uint, uint*, void>)QuickGL.GetGLProcAddress("glTexParameterIuiv");
        _glGetTexParameterIiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetTexParameterIiv");
        _glGetTexParameterIuiv = (delegate* unmanaged<uint, uint, uint*, void>)QuickGL.GetGLProcAddress("glGetTexParameterIuiv");
        _glClearBufferiv = (delegate* unmanaged<uint, int, int*, void>)QuickGL.GetGLProcAddress("glClearBufferiv");
        _glClearBufferuiv = (delegate* unmanaged<uint, int, uint*, void>)QuickGL.GetGLProcAddress("glClearBufferuiv");
        _glClearBufferfv = (delegate* unmanaged<uint, int, float*, void>)QuickGL.GetGLProcAddress("glClearBufferfv");
        _glClearBufferfi = (delegate* unmanaged<uint, int, float, int, void>)QuickGL.GetGLProcAddress("glClearBufferfi");
        _glGetStringi = (delegate* unmanaged<uint, uint, byte*>)QuickGL.GetGLProcAddress("glGetStringi");
        _glIsRenderbuffer = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsRenderbuffer");
        _glBindRenderbuffer = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBindRenderbuffer");
        _glDeleteRenderbuffers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteRenderbuffers");
        _glGenRenderbuffers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenRenderbuffers");
        _glRenderbufferStorage = (delegate* unmanaged<uint, uint, int, int, void>)QuickGL.GetGLProcAddress("glRenderbufferStorage");
        _glGetRenderbufferParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetRenderbufferParameteriv");
        _glIsFramebuffer = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsFramebuffer");
        _glBindFramebuffer = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBindFramebuffer");
        _glDeleteFramebuffers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteFramebuffers");
        _glGenFramebuffers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenFramebuffers");
        _glCheckFramebufferStatus = (delegate* unmanaged<uint, uint>)QuickGL.GetGLProcAddress("glCheckFramebufferStatus");
        _glFramebufferTexture1D = (delegate* unmanaged<uint, uint, uint, uint, int, void>)QuickGL.GetGLProcAddress("glFramebufferTexture1D");
        _glFramebufferTexture2D = (delegate* unmanaged<uint, uint, uint, uint, int, void>)QuickGL.GetGLProcAddress("glFramebufferTexture2D");
        _glFramebufferTexture3D = (delegate* unmanaged<uint, uint, uint, uint, int, int, void>)QuickGL.GetGLProcAddress("glFramebufferTexture3D");
        _glFramebufferRenderbuffer = (delegate* unmanaged<uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glFramebufferRenderbuffer");
        _glGetFramebufferAttachmentParameteriv = (delegate* unmanaged<uint, uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetFramebufferAttachmentParameteriv");
        _glGenerateMipmap = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glGenerateMipmap");
        _glBlitFramebuffer = (delegate* unmanaged<int, int, int, int, int, int, int, int, uint, uint, void>)QuickGL.GetGLProcAddress("glBlitFramebuffer");
        _glRenderbufferStorageMultisample = (delegate* unmanaged<uint, int, uint, int, int, void>)QuickGL.GetGLProcAddress("glRenderbufferStorageMultisample");
        _glFramebufferTextureLayer = (delegate* unmanaged<uint, uint, uint, int, int, void>)QuickGL.GetGLProcAddress("glFramebufferTextureLayer");
        _glMapBufferRange = (delegate* unmanaged<uint, nint, nint, uint, void*>)QuickGL.GetGLProcAddress("glMapBufferRange");
        _glFlushMappedBufferRange = (delegate* unmanaged<uint, nint, nint, void>)QuickGL.GetGLProcAddress("glFlushMappedBufferRange");
        _glBindVertexArray = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glBindVertexArray");
        _glDeleteVertexArrays = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteVertexArrays");
        _glGenVertexArrays = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenVertexArrays");
        _glIsVertexArray = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsVertexArray");
    }
    
    internal static void Unload()
    {
        _glColorMaski = null;
        _glGetBooleani_v = null;
        _glGetIntegeri_v = null;
        _glEnablei = null;
        _glDisablei = null;
        _glIsEnabledi = null;
        _glBeginTransformFeedback = null;
        _glEndTransformFeedback = null;
        _glBindBufferRange = null;
        _glBindBufferBase = null;
        _glTransformFeedbackVaryings = null;
        _glGetTransformFeedbackVarying = null;
        _glClampColor = null;
        _glBeginConditionalRender = null;
        _glEndConditionalRender = null;
        _glVertexAttribIPointer = null;
        _glGetVertexAttribIiv = null;
        _glGetVertexAttribIuiv = null;
        _glVertexAttribI1i = null;
        _glVertexAttribI2i = null;
        _glVertexAttribI3i = null;
        _glVertexAttribI4i = null;
        _glVertexAttribI1ui = null;
        _glVertexAttribI2ui = null;
        _glVertexAttribI3ui = null;
        _glVertexAttribI4ui = null;
        _glVertexAttribI1iv = null;
        _glVertexAttribI2iv = null;
        _glVertexAttribI3iv = null;
        _glVertexAttribI4iv = null;
        _glVertexAttribI1uiv = null;
        _glVertexAttribI2uiv = null;
        _glVertexAttribI3uiv = null;
        _glVertexAttribI4uiv = null;
        _glVertexAttribI4bv = null;
        _glVertexAttribI4sv = null;
        _glVertexAttribI4ubv = null;
        _glVertexAttribI4usv = null;
        _glGetUniformuiv = null;
        _glBindFragDataLocation = null;
        _glGetFragDataLocation = null;
        _glUniform1ui = null;
        _glUniform2ui = null;
        _glUniform3ui = null;
        _glUniform4ui = null;
        _glUniform1uiv = null;
        _glUniform2uiv = null;
        _glUniform3uiv = null;
        _glUniform4uiv = null;
        _glTexParameterIiv = null;
        _glTexParameterIuiv = null;
        _glGetTexParameterIiv = null;
        _glGetTexParameterIuiv = null;
        _glClearBufferiv = null;
        _glClearBufferuiv = null;
        _glClearBufferfv = null;
        _glClearBufferfi = null;
        _glGetStringi = null;
        _glIsRenderbuffer = null;
        _glBindRenderbuffer = null;
        _glDeleteRenderbuffers = null;
        _glGenRenderbuffers = null;
        _glRenderbufferStorage = null;
        _glGetRenderbufferParameteriv = null;
        _glIsFramebuffer = null;
        _glBindFramebuffer = null;
        _glDeleteFramebuffers = null;
        _glGenFramebuffers = null;
        _glCheckFramebufferStatus = null;
        _glFramebufferTexture1D = null;
        _glFramebufferTexture2D = null;
        _glFramebufferTexture3D = null;
        _glFramebufferRenderbuffer = null;
        _glGetFramebufferAttachmentParameteriv = null;
        _glGenerateMipmap = null;
        _glBlitFramebuffer = null;
        _glRenderbufferStorageMultisample = null;
        _glFramebufferTextureLayer = null;
        _glMapBufferRange = null;
        _glFlushMappedBufferRange = null;
        _glBindVertexArray = null;
        _glDeleteVertexArrays = null;
        _glGenVertexArrays = null;
        _glIsVertexArray = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_VERSION_3_0", false, false);
}
