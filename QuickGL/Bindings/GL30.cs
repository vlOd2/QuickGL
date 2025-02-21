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

// Bindings generated at 2025-02-21 16:29:58.837810
namespace QuickGLNS.Bindings;

[GLFeature(false)]
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
    public static void glColorMaski(uint index, bool r, bool g, bool b, bool a) => _glColorMaski(index, r, g, b, a);
    [QGLNativeAPI("glColorMaski")] internal static delegate* unmanaged<uint, bool, bool, bool, bool, void> _glColorMaski = null;
    
    public static void glGetBooleani_v(uint target, uint index, bool* data) => _glGetBooleani_v(target, index, data);
    [QGLNativeAPI("glGetBooleani_v")] internal static delegate* unmanaged<uint, uint, bool*, void> _glGetBooleani_v = null;
    
    public static void glGetIntegeri_v(uint target, uint index, int* data) => _glGetIntegeri_v(target, index, data);
    [QGLNativeAPI("glGetIntegeri_v")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetIntegeri_v = null;
    
    public static void glEnablei(uint target, uint index) => _glEnablei(target, index);
    [QGLNativeAPI("glEnablei")] internal static delegate* unmanaged<uint, uint, void> _glEnablei = null;
    
    public static void glDisablei(uint target, uint index) => _glDisablei(target, index);
    [QGLNativeAPI("glDisablei")] internal static delegate* unmanaged<uint, uint, void> _glDisablei = null;
    
    public static bool glIsEnabledi(uint target, uint index) => _glIsEnabledi(target, index);
    [QGLNativeAPI("glIsEnabledi")] internal static delegate* unmanaged<uint, uint, bool> _glIsEnabledi = null;
    
    public static void glBeginTransformFeedback(uint primitiveMode) => _glBeginTransformFeedback(primitiveMode);
    [QGLNativeAPI("glBeginTransformFeedback")] internal static delegate* unmanaged<uint, void> _glBeginTransformFeedback = null;
    
    public static void glEndTransformFeedback() => _glEndTransformFeedback();
    [QGLNativeAPI("glEndTransformFeedback")] internal static delegate* unmanaged<void> _glEndTransformFeedback = null;
    
    public static void glBindBufferRange(uint target, uint index, uint buffer, nint offset, nint size) => _glBindBufferRange(target, index, buffer, offset, size);
    [QGLNativeAPI("glBindBufferRange")] internal static delegate* unmanaged<uint, uint, uint, nint, nint, void> _glBindBufferRange = null;
    
    public static void glBindBufferBase(uint target, uint index, uint buffer) => _glBindBufferBase(target, index, buffer);
    [QGLNativeAPI("glBindBufferBase")] internal static delegate* unmanaged<uint, uint, uint, void> _glBindBufferBase = null;
    
    public static void glTransformFeedbackVaryings(uint program, int count, byte** varyings, uint bufferMode) => _glTransformFeedbackVaryings(program, count, varyings, bufferMode);
    [QGLNativeAPI("glTransformFeedbackVaryings")] internal static delegate* unmanaged<uint, int, byte**, uint, void> _glTransformFeedbackVaryings = null;
    
    public static void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name) => _glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
    [QGLNativeAPI("glGetTransformFeedbackVarying")] internal static delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void> _glGetTransformFeedbackVarying = null;
    
    public static void glClampColor(uint target, uint clamp) => _glClampColor(target, clamp);
    [QGLNativeAPI("glClampColor")] internal static delegate* unmanaged<uint, uint, void> _glClampColor = null;
    
    public static void glBeginConditionalRender(uint id, uint mode) => _glBeginConditionalRender(id, mode);
    [QGLNativeAPI("glBeginConditionalRender")] internal static delegate* unmanaged<uint, uint, void> _glBeginConditionalRender = null;
    
    public static void glEndConditionalRender() => _glEndConditionalRender();
    [QGLNativeAPI("glEndConditionalRender")] internal static delegate* unmanaged<void> _glEndConditionalRender = null;
    
    public static void glVertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer) => _glVertexAttribIPointer(index, size, type, stride, pointer);
    [QGLNativeAPI("glVertexAttribIPointer")] internal static delegate* unmanaged<uint, int, uint, int, void*, void> _glVertexAttribIPointer = null;
    
    public static void glGetVertexAttribIiv(uint index, uint pname, int* @params) => _glGetVertexAttribIiv(index, pname, @params);
    [QGLNativeAPI("glGetVertexAttribIiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetVertexAttribIiv = null;
    
    public static void glGetVertexAttribIuiv(uint index, uint pname, uint* @params) => _glGetVertexAttribIuiv(index, pname, @params);
    [QGLNativeAPI("glGetVertexAttribIuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glGetVertexAttribIuiv = null;
    
    public static void glVertexAttribI1i(uint index, int x) => _glVertexAttribI1i(index, x);
    [QGLNativeAPI("glVertexAttribI1i")] internal static delegate* unmanaged<uint, int, void> _glVertexAttribI1i = null;
    
    public static void glVertexAttribI2i(uint index, int x, int y) => _glVertexAttribI2i(index, x, y);
    [QGLNativeAPI("glVertexAttribI2i")] internal static delegate* unmanaged<uint, int, int, void> _glVertexAttribI2i = null;
    
    public static void glVertexAttribI3i(uint index, int x, int y, int z) => _glVertexAttribI3i(index, x, y, z);
    [QGLNativeAPI("glVertexAttribI3i")] internal static delegate* unmanaged<uint, int, int, int, void> _glVertexAttribI3i = null;
    
    public static void glVertexAttribI4i(uint index, int x, int y, int z, int w) => _glVertexAttribI4i(index, x, y, z, w);
    [QGLNativeAPI("glVertexAttribI4i")] internal static delegate* unmanaged<uint, int, int, int, int, void> _glVertexAttribI4i = null;
    
    public static void glVertexAttribI1ui(uint index, uint x) => _glVertexAttribI1ui(index, x);
    [QGLNativeAPI("glVertexAttribI1ui")] internal static delegate* unmanaged<uint, uint, void> _glVertexAttribI1ui = null;
    
    public static void glVertexAttribI2ui(uint index, uint x, uint y) => _glVertexAttribI2ui(index, x, y);
    [QGLNativeAPI("glVertexAttribI2ui")] internal static delegate* unmanaged<uint, uint, uint, void> _glVertexAttribI2ui = null;
    
    public static void glVertexAttribI3ui(uint index, uint x, uint y, uint z) => _glVertexAttribI3ui(index, x, y, z);
    [QGLNativeAPI("glVertexAttribI3ui")] internal static delegate* unmanaged<uint, uint, uint, uint, void> _glVertexAttribI3ui = null;
    
    public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => _glVertexAttribI4ui(index, x, y, z, w);
    [QGLNativeAPI("glVertexAttribI4ui")] internal static delegate* unmanaged<uint, uint, uint, uint, uint, void> _glVertexAttribI4ui = null;
    
    public static void glVertexAttribI1iv(uint index, int* v) => _glVertexAttribI1iv(index, v);
    [QGLNativeAPI("glVertexAttribI1iv")] internal static delegate* unmanaged<uint, int*, void> _glVertexAttribI1iv = null;
    
    public static void glVertexAttribI2iv(uint index, int* v) => _glVertexAttribI2iv(index, v);
    [QGLNativeAPI("glVertexAttribI2iv")] internal static delegate* unmanaged<uint, int*, void> _glVertexAttribI2iv = null;
    
    public static void glVertexAttribI3iv(uint index, int* v) => _glVertexAttribI3iv(index, v);
    [QGLNativeAPI("glVertexAttribI3iv")] internal static delegate* unmanaged<uint, int*, void> _glVertexAttribI3iv = null;
    
    public static void glVertexAttribI4iv(uint index, int* v) => _glVertexAttribI4iv(index, v);
    [QGLNativeAPI("glVertexAttribI4iv")] internal static delegate* unmanaged<uint, int*, void> _glVertexAttribI4iv = null;
    
    public static void glVertexAttribI1uiv(uint index, uint* v) => _glVertexAttribI1uiv(index, v);
    [QGLNativeAPI("glVertexAttribI1uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexAttribI1uiv = null;
    
    public static void glVertexAttribI2uiv(uint index, uint* v) => _glVertexAttribI2uiv(index, v);
    [QGLNativeAPI("glVertexAttribI2uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexAttribI2uiv = null;
    
    public static void glVertexAttribI3uiv(uint index, uint* v) => _glVertexAttribI3uiv(index, v);
    [QGLNativeAPI("glVertexAttribI3uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexAttribI3uiv = null;
    
    public static void glVertexAttribI4uiv(uint index, uint* v) => _glVertexAttribI4uiv(index, v);
    [QGLNativeAPI("glVertexAttribI4uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexAttribI4uiv = null;
    
    public static void glVertexAttribI4bv(uint index, sbyte* v) => _glVertexAttribI4bv(index, v);
    [QGLNativeAPI("glVertexAttribI4bv")] internal static delegate* unmanaged<uint, sbyte*, void> _glVertexAttribI4bv = null;
    
    public static void glVertexAttribI4sv(uint index, short* v) => _glVertexAttribI4sv(index, v);
    [QGLNativeAPI("glVertexAttribI4sv")] internal static delegate* unmanaged<uint, short*, void> _glVertexAttribI4sv = null;
    
    public static void glVertexAttribI4ubv(uint index, byte* v) => _glVertexAttribI4ubv(index, v);
    [QGLNativeAPI("glVertexAttribI4ubv")] internal static delegate* unmanaged<uint, byte*, void> _glVertexAttribI4ubv = null;
    
    public static void glVertexAttribI4usv(uint index, ushort* v) => _glVertexAttribI4usv(index, v);
    [QGLNativeAPI("glVertexAttribI4usv")] internal static delegate* unmanaged<uint, ushort*, void> _glVertexAttribI4usv = null;
    
    public static void glGetUniformuiv(uint program, int location, uint* @params) => _glGetUniformuiv(program, location, @params);
    [QGLNativeAPI("glGetUniformuiv")] internal static delegate* unmanaged<uint, int, uint*, void> _glGetUniformuiv = null;
    
    public static void glBindFragDataLocation(uint program, uint color, byte* name) => _glBindFragDataLocation(program, color, name);
    [QGLNativeAPI("glBindFragDataLocation")] internal static delegate* unmanaged<uint, uint, byte*, void> _glBindFragDataLocation = null;
    
    public static int glGetFragDataLocation(uint program, byte* name) => _glGetFragDataLocation(program, name);
    [QGLNativeAPI("glGetFragDataLocation")] internal static delegate* unmanaged<uint, byte*, int> _glGetFragDataLocation = null;
    
    public static void glUniform1ui(int location, uint v0) => _glUniform1ui(location, v0);
    [QGLNativeAPI("glUniform1ui")] internal static delegate* unmanaged<int, uint, void> _glUniform1ui = null;
    
    public static void glUniform2ui(int location, uint v0, uint v1) => _glUniform2ui(location, v0, v1);
    [QGLNativeAPI("glUniform2ui")] internal static delegate* unmanaged<int, uint, uint, void> _glUniform2ui = null;
    
    public static void glUniform3ui(int location, uint v0, uint v1, uint v2) => _glUniform3ui(location, v0, v1, v2);
    [QGLNativeAPI("glUniform3ui")] internal static delegate* unmanaged<int, uint, uint, uint, void> _glUniform3ui = null;
    
    public static void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3) => _glUniform4ui(location, v0, v1, v2, v3);
    [QGLNativeAPI("glUniform4ui")] internal static delegate* unmanaged<int, uint, uint, uint, uint, void> _glUniform4ui = null;
    
    public static void glUniform1uiv(int location, int count, uint* value) => _glUniform1uiv(location, count, value);
    [QGLNativeAPI("glUniform1uiv")] internal static delegate* unmanaged<int, int, uint*, void> _glUniform1uiv = null;
    
    public static void glUniform2uiv(int location, int count, uint* value) => _glUniform2uiv(location, count, value);
    [QGLNativeAPI("glUniform2uiv")] internal static delegate* unmanaged<int, int, uint*, void> _glUniform2uiv = null;
    
    public static void glUniform3uiv(int location, int count, uint* value) => _glUniform3uiv(location, count, value);
    [QGLNativeAPI("glUniform3uiv")] internal static delegate* unmanaged<int, int, uint*, void> _glUniform3uiv = null;
    
    public static void glUniform4uiv(int location, int count, uint* value) => _glUniform4uiv(location, count, value);
    [QGLNativeAPI("glUniform4uiv")] internal static delegate* unmanaged<int, int, uint*, void> _glUniform4uiv = null;
    
    public static void glTexParameterIiv(uint target, uint pname, int* @params) => _glTexParameterIiv(target, pname, @params);
    [QGLNativeAPI("glTexParameterIiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glTexParameterIiv = null;
    
    public static void glTexParameterIuiv(uint target, uint pname, uint* @params) => _glTexParameterIuiv(target, pname, @params);
    [QGLNativeAPI("glTexParameterIuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glTexParameterIuiv = null;
    
    public static void glGetTexParameterIiv(uint target, uint pname, int* @params) => _glGetTexParameterIiv(target, pname, @params);
    [QGLNativeAPI("glGetTexParameterIiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexParameterIiv = null;
    
    public static void glGetTexParameterIuiv(uint target, uint pname, uint* @params) => _glGetTexParameterIuiv(target, pname, @params);
    [QGLNativeAPI("glGetTexParameterIuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glGetTexParameterIuiv = null;
    
    public static void glClearBufferiv(uint buffer, int drawbuffer, int* value) => _glClearBufferiv(buffer, drawbuffer, value);
    [QGLNativeAPI("glClearBufferiv")] internal static delegate* unmanaged<uint, int, int*, void> _glClearBufferiv = null;
    
    public static void glClearBufferuiv(uint buffer, int drawbuffer, uint* value) => _glClearBufferuiv(buffer, drawbuffer, value);
    [QGLNativeAPI("glClearBufferuiv")] internal static delegate* unmanaged<uint, int, uint*, void> _glClearBufferuiv = null;
    
    public static void glClearBufferfv(uint buffer, int drawbuffer, float* value) => _glClearBufferfv(buffer, drawbuffer, value);
    [QGLNativeAPI("glClearBufferfv")] internal static delegate* unmanaged<uint, int, float*, void> _glClearBufferfv = null;
    
    public static void glClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil) => _glClearBufferfi(buffer, drawbuffer, depth, stencil);
    [QGLNativeAPI("glClearBufferfi")] internal static delegate* unmanaged<uint, int, float, int, void> _glClearBufferfi = null;
    
    public static byte* glGetStringi(uint name, uint index) => _glGetStringi(name, index);
    [QGLNativeAPI("glGetStringi")] internal static delegate* unmanaged<uint, uint, byte*> _glGetStringi = null;
    
    public static bool glIsRenderbuffer(uint renderbuffer) => _glIsRenderbuffer(renderbuffer);
    [QGLNativeAPI("glIsRenderbuffer")] internal static delegate* unmanaged<uint, bool> _glIsRenderbuffer = null;
    
    public static void glBindRenderbuffer(uint target, uint renderbuffer) => _glBindRenderbuffer(target, renderbuffer);
    [QGLNativeAPI("glBindRenderbuffer")] internal static delegate* unmanaged<uint, uint, void> _glBindRenderbuffer = null;
    
    public static void glDeleteRenderbuffers(int n, uint* renderbuffers) => _glDeleteRenderbuffers(n, renderbuffers);
    [QGLNativeAPI("glDeleteRenderbuffers")] internal static delegate* unmanaged<int, uint*, void> _glDeleteRenderbuffers = null;
    
    public static void glGenRenderbuffers(int n, uint* renderbuffers) => _glGenRenderbuffers(n, renderbuffers);
    [QGLNativeAPI("glGenRenderbuffers")] internal static delegate* unmanaged<int, uint*, void> _glGenRenderbuffers = null;
    
    public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height) => _glRenderbufferStorage(target, internalformat, width, height);
    [QGLNativeAPI("glRenderbufferStorage")] internal static delegate* unmanaged<uint, uint, int, int, void> _glRenderbufferStorage = null;
    
    public static void glGetRenderbufferParameteriv(uint target, uint pname, int* @params) => _glGetRenderbufferParameteriv(target, pname, @params);
    [QGLNativeAPI("glGetRenderbufferParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetRenderbufferParameteriv = null;
    
    public static bool glIsFramebuffer(uint framebuffer) => _glIsFramebuffer(framebuffer);
    [QGLNativeAPI("glIsFramebuffer")] internal static delegate* unmanaged<uint, bool> _glIsFramebuffer = null;
    
    public static void glBindFramebuffer(uint target, uint framebuffer) => _glBindFramebuffer(target, framebuffer);
    [QGLNativeAPI("glBindFramebuffer")] internal static delegate* unmanaged<uint, uint, void> _glBindFramebuffer = null;
    
    public static void glDeleteFramebuffers(int n, uint* framebuffers) => _glDeleteFramebuffers(n, framebuffers);
    [QGLNativeAPI("glDeleteFramebuffers")] internal static delegate* unmanaged<int, uint*, void> _glDeleteFramebuffers = null;
    
    public static void glGenFramebuffers(int n, uint* framebuffers) => _glGenFramebuffers(n, framebuffers);
    [QGLNativeAPI("glGenFramebuffers")] internal static delegate* unmanaged<int, uint*, void> _glGenFramebuffers = null;
    
    public static uint glCheckFramebufferStatus(uint target) => _glCheckFramebufferStatus(target);
    [QGLNativeAPI("glCheckFramebufferStatus")] internal static delegate* unmanaged<uint, uint> _glCheckFramebufferStatus = null;
    
    public static void glFramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level) => _glFramebufferTexture1D(target, attachment, textarget, texture, level);
    [QGLNativeAPI("glFramebufferTexture1D")] internal static delegate* unmanaged<uint, uint, uint, uint, int, void> _glFramebufferTexture1D = null;
    
    public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) => _glFramebufferTexture2D(target, attachment, textarget, texture, level);
    [QGLNativeAPI("glFramebufferTexture2D")] internal static delegate* unmanaged<uint, uint, uint, uint, int, void> _glFramebufferTexture2D = null;
    
    public static void glFramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) => _glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
    [QGLNativeAPI("glFramebufferTexture3D")] internal static delegate* unmanaged<uint, uint, uint, uint, int, int, void> _glFramebufferTexture3D = null;
    
    public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) => _glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
    [QGLNativeAPI("glFramebufferRenderbuffer")] internal static delegate* unmanaged<uint, uint, uint, uint, void> _glFramebufferRenderbuffer = null;
    
    public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params) => _glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
    [QGLNativeAPI("glGetFramebufferAttachmentParameteriv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetFramebufferAttachmentParameteriv = null;
    
    public static void glGenerateMipmap(uint target) => _glGenerateMipmap(target);
    [QGLNativeAPI("glGenerateMipmap")] internal static delegate* unmanaged<uint, void> _glGenerateMipmap = null;
    
    public static void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) => _glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
    [QGLNativeAPI("glBlitFramebuffer")] internal static delegate* unmanaged<int, int, int, int, int, int, int, int, uint, uint, void> _glBlitFramebuffer = null;
    
    public static void glRenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height) => _glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
    [QGLNativeAPI("glRenderbufferStorageMultisample")] internal static delegate* unmanaged<uint, int, uint, int, int, void> _glRenderbufferStorageMultisample = null;
    
    public static void glFramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer) => _glFramebufferTextureLayer(target, attachment, texture, level, layer);
    [QGLNativeAPI("glFramebufferTextureLayer")] internal static delegate* unmanaged<uint, uint, uint, int, int, void> _glFramebufferTextureLayer = null;
    
    public static void* glMapBufferRange(uint target, nint offset, nint length, uint access) => _glMapBufferRange(target, offset, length, access);
    [QGLNativeAPI("glMapBufferRange")] internal static delegate* unmanaged<uint, nint, nint, uint, void*> _glMapBufferRange = null;
    
    public static void glFlushMappedBufferRange(uint target, nint offset, nint length) => _glFlushMappedBufferRange(target, offset, length);
    [QGLNativeAPI("glFlushMappedBufferRange")] internal static delegate* unmanaged<uint, nint, nint, void> _glFlushMappedBufferRange = null;
    
    public static void glBindVertexArray(uint array) => _glBindVertexArray(array);
    [QGLNativeAPI("glBindVertexArray")] internal static delegate* unmanaged<uint, void> _glBindVertexArray = null;
    
    public static void glDeleteVertexArrays(int n, uint* arrays) => _glDeleteVertexArrays(n, arrays);
    [QGLNativeAPI("glDeleteVertexArrays")] internal static delegate* unmanaged<int, uint*, void> _glDeleteVertexArrays = null;
    
    public static void glGenVertexArrays(int n, uint* arrays) => _glGenVertexArrays(n, arrays);
    [QGLNativeAPI("glGenVertexArrays")] internal static delegate* unmanaged<int, uint*, void> _glGenVertexArrays = null;
    
    public static bool glIsVertexArray(uint array) => _glIsVertexArray(array);
    [QGLNativeAPI("glIsVertexArray")] internal static delegate* unmanaged<uint, bool> _glIsVertexArray = null;
     #endregion
}
