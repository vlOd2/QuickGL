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

// Bindings generated at 2025-01-04 01:08:51.540024
namespace QuickGLNS.Bindings
{
    [GLFeature]
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
        [QGLNativeAPI("glColorMaski")] public static delegate* unmanaged<uint, bool, bool, bool, bool, void> glColorMaski;
        [QGLNativeAPI("glGetBooleani_v")] public static delegate* unmanaged<uint, uint, bool*, void> glGetBooleani_v;
        [QGLNativeAPI("glGetIntegeri_v")] public static delegate* unmanaged<uint, uint, int*, void> glGetIntegeri_v;
        [QGLNativeAPI("glEnablei")] public static delegate* unmanaged<uint, uint, void> glEnablei;
        [QGLNativeAPI("glDisablei")] public static delegate* unmanaged<uint, uint, void> glDisablei;
        [QGLNativeAPI("glIsEnabledi")] public static delegate* unmanaged<uint, uint, bool> glIsEnabledi;
        [QGLNativeAPI("glBeginTransformFeedback")] public static delegate* unmanaged<uint, void> glBeginTransformFeedback;
        [QGLNativeAPI("glEndTransformFeedback")] public static delegate* unmanaged<void> glEndTransformFeedback;
        [QGLNativeAPI("glBindBufferRange")] public static delegate* unmanaged<uint, uint, uint, nint, nint, void> glBindBufferRange;
        [QGLNativeAPI("glBindBufferBase")] public static delegate* unmanaged<uint, uint, uint, void> glBindBufferBase;
        [QGLNativeAPI("glTransformFeedbackVaryings")] public static delegate* unmanaged<uint, int, char**, uint, void> glTransformFeedbackVaryings;
        [QGLNativeAPI("glGetTransformFeedbackVarying")] public static delegate* unmanaged<uint, uint, int, int*, int*, uint*, char*, void> glGetTransformFeedbackVarying;
        [QGLNativeAPI("glClampColor")] public static delegate* unmanaged<uint, uint, void> glClampColor;
        [QGLNativeAPI("glBeginConditionalRender")] public static delegate* unmanaged<uint, uint, void> glBeginConditionalRender;
        [QGLNativeAPI("glEndConditionalRender")] public static delegate* unmanaged<void> glEndConditionalRender;
        [QGLNativeAPI("glVertexAttribIPointer")] public static delegate* unmanaged<uint, int, uint, int, void*, void> glVertexAttribIPointer;
        [QGLNativeAPI("glGetVertexAttribIiv")] public static delegate* unmanaged<uint, uint, int*, void> glGetVertexAttribIiv;
        [QGLNativeAPI("glGetVertexAttribIuiv")] public static delegate* unmanaged<uint, uint, uint*, void> glGetVertexAttribIuiv;
        [QGLNativeAPI("glVertexAttribI1i")] public static delegate* unmanaged<uint, int, void> glVertexAttribI1i;
        [QGLNativeAPI("glVertexAttribI2i")] public static delegate* unmanaged<uint, int, int, void> glVertexAttribI2i;
        [QGLNativeAPI("glVertexAttribI3i")] public static delegate* unmanaged<uint, int, int, int, void> glVertexAttribI3i;
        [QGLNativeAPI("glVertexAttribI4i")] public static delegate* unmanaged<uint, int, int, int, int, void> glVertexAttribI4i;
        [QGLNativeAPI("glVertexAttribI1ui")] public static delegate* unmanaged<uint, uint, void> glVertexAttribI1ui;
        [QGLNativeAPI("glVertexAttribI2ui")] public static delegate* unmanaged<uint, uint, uint, void> glVertexAttribI2ui;
        [QGLNativeAPI("glVertexAttribI3ui")] public static delegate* unmanaged<uint, uint, uint, uint, void> glVertexAttribI3ui;
        [QGLNativeAPI("glVertexAttribI4ui")] public static delegate* unmanaged<uint, uint, uint, uint, uint, void> glVertexAttribI4ui;
        [QGLNativeAPI("glVertexAttribI1iv")] public static delegate* unmanaged<uint, int*, void> glVertexAttribI1iv;
        [QGLNativeAPI("glVertexAttribI2iv")] public static delegate* unmanaged<uint, int*, void> glVertexAttribI2iv;
        [QGLNativeAPI("glVertexAttribI3iv")] public static delegate* unmanaged<uint, int*, void> glVertexAttribI3iv;
        [QGLNativeAPI("glVertexAttribI4iv")] public static delegate* unmanaged<uint, int*, void> glVertexAttribI4iv;
        [QGLNativeAPI("glVertexAttribI1uiv")] public static delegate* unmanaged<uint, uint*, void> glVertexAttribI1uiv;
        [QGLNativeAPI("glVertexAttribI2uiv")] public static delegate* unmanaged<uint, uint*, void> glVertexAttribI2uiv;
        [QGLNativeAPI("glVertexAttribI3uiv")] public static delegate* unmanaged<uint, uint*, void> glVertexAttribI3uiv;
        [QGLNativeAPI("glVertexAttribI4uiv")] public static delegate* unmanaged<uint, uint*, void> glVertexAttribI4uiv;
        [QGLNativeAPI("glVertexAttribI4bv")] public static delegate* unmanaged<uint, sbyte*, void> glVertexAttribI4bv;
        [QGLNativeAPI("glVertexAttribI4sv")] public static delegate* unmanaged<uint, short*, void> glVertexAttribI4sv;
        [QGLNativeAPI("glVertexAttribI4ubv")] public static delegate* unmanaged<uint, byte*, void> glVertexAttribI4ubv;
        [QGLNativeAPI("glVertexAttribI4usv")] public static delegate* unmanaged<uint, ushort*, void> glVertexAttribI4usv;
        [QGLNativeAPI("glGetUniformuiv")] public static delegate* unmanaged<uint, int, uint*, void> glGetUniformuiv;
        [QGLNativeAPI("glBindFragDataLocation")] public static delegate* unmanaged<uint, uint, char*, void> glBindFragDataLocation;
        [QGLNativeAPI("glGetFragDataLocation")] public static delegate* unmanaged<uint, char*, int> glGetFragDataLocation;
        [QGLNativeAPI("glUniform1ui")] public static delegate* unmanaged<int, uint, void> glUniform1ui;
        [QGLNativeAPI("glUniform2ui")] public static delegate* unmanaged<int, uint, uint, void> glUniform2ui;
        [QGLNativeAPI("glUniform3ui")] public static delegate* unmanaged<int, uint, uint, uint, void> glUniform3ui;
        [QGLNativeAPI("glUniform4ui")] public static delegate* unmanaged<int, uint, uint, uint, uint, void> glUniform4ui;
        [QGLNativeAPI("glUniform1uiv")] public static delegate* unmanaged<int, int, uint*, void> glUniform1uiv;
        [QGLNativeAPI("glUniform2uiv")] public static delegate* unmanaged<int, int, uint*, void> glUniform2uiv;
        [QGLNativeAPI("glUniform3uiv")] public static delegate* unmanaged<int, int, uint*, void> glUniform3uiv;
        [QGLNativeAPI("glUniform4uiv")] public static delegate* unmanaged<int, int, uint*, void> glUniform4uiv;
        [QGLNativeAPI("glTexParameterIiv")] public static delegate* unmanaged<uint, uint, int*, void> glTexParameterIiv;
        [QGLNativeAPI("glTexParameterIuiv")] public static delegate* unmanaged<uint, uint, uint*, void> glTexParameterIuiv;
        [QGLNativeAPI("glGetTexParameterIiv")] public static delegate* unmanaged<uint, uint, int*, void> glGetTexParameterIiv;
        [QGLNativeAPI("glGetTexParameterIuiv")] public static delegate* unmanaged<uint, uint, uint*, void> glGetTexParameterIuiv;
        [QGLNativeAPI("glClearBufferiv")] public static delegate* unmanaged<uint, int, int*, void> glClearBufferiv;
        [QGLNativeAPI("glClearBufferuiv")] public static delegate* unmanaged<uint, int, uint*, void> glClearBufferuiv;
        [QGLNativeAPI("glClearBufferfv")] public static delegate* unmanaged<uint, int, float*, void> glClearBufferfv;
        [QGLNativeAPI("glClearBufferfi")] public static delegate* unmanaged<uint, int, float, int, void> glClearBufferfi;
        [QGLNativeAPI("glGetStringi")] public static delegate* unmanaged<uint, uint, byte*> glGetStringi;
        [QGLNativeAPI("glIsRenderbuffer")] public static delegate* unmanaged<uint, bool> glIsRenderbuffer;
        [QGLNativeAPI("glBindRenderbuffer")] public static delegate* unmanaged<uint, uint, void> glBindRenderbuffer;
        [QGLNativeAPI("glDeleteRenderbuffers")] public static delegate* unmanaged<int, uint*, void> glDeleteRenderbuffers;
        [QGLNativeAPI("glGenRenderbuffers")] public static delegate* unmanaged<int, uint*, void> glGenRenderbuffers;
        [QGLNativeAPI("glRenderbufferStorage")] public static delegate* unmanaged<uint, uint, int, int, void> glRenderbufferStorage;
        [QGLNativeAPI("glGetRenderbufferParameteriv")] public static delegate* unmanaged<uint, uint, int*, void> glGetRenderbufferParameteriv;
        [QGLNativeAPI("glIsFramebuffer")] public static delegate* unmanaged<uint, bool> glIsFramebuffer;
        [QGLNativeAPI("glBindFramebuffer")] public static delegate* unmanaged<uint, uint, void> glBindFramebuffer;
        [QGLNativeAPI("glDeleteFramebuffers")] public static delegate* unmanaged<int, uint*, void> glDeleteFramebuffers;
        [QGLNativeAPI("glGenFramebuffers")] public static delegate* unmanaged<int, uint*, void> glGenFramebuffers;
        [QGLNativeAPI("glCheckFramebufferStatus")] public static delegate* unmanaged<uint, uint> glCheckFramebufferStatus;
        [QGLNativeAPI("glFramebufferTexture1D")] public static delegate* unmanaged<uint, uint, uint, uint, int, void> glFramebufferTexture1D;
        [QGLNativeAPI("glFramebufferTexture2D")] public static delegate* unmanaged<uint, uint, uint, uint, int, void> glFramebufferTexture2D;
        [QGLNativeAPI("glFramebufferTexture3D")] public static delegate* unmanaged<uint, uint, uint, uint, int, int, void> glFramebufferTexture3D;
        [QGLNativeAPI("glFramebufferRenderbuffer")] public static delegate* unmanaged<uint, uint, uint, uint, void> glFramebufferRenderbuffer;
        [QGLNativeAPI("glGetFramebufferAttachmentParameteriv")] public static delegate* unmanaged<uint, uint, uint, int*, void> glGetFramebufferAttachmentParameteriv;
        [QGLNativeAPI("glGenerateMipmap")] public static delegate* unmanaged<uint, void> glGenerateMipmap;
        [QGLNativeAPI("glBlitFramebuffer")] public static delegate* unmanaged<int, int, int, int, int, int, int, int, uint, uint, void> glBlitFramebuffer;
        [QGLNativeAPI("glRenderbufferStorageMultisample")] public static delegate* unmanaged<uint, int, uint, int, int, void> glRenderbufferStorageMultisample;
        [QGLNativeAPI("glFramebufferTextureLayer")] public static delegate* unmanaged<uint, uint, uint, int, int, void> glFramebufferTextureLayer;
        [QGLNativeAPI("glMapBufferRange")] public static delegate* unmanaged<uint, nint, nint, uint, void*> glMapBufferRange;
        [QGLNativeAPI("glFlushMappedBufferRange")] public static delegate* unmanaged<uint, nint, nint, void> glFlushMappedBufferRange;
        [QGLNativeAPI("glBindVertexArray")] public static delegate* unmanaged<uint, void> glBindVertexArray;
        [QGLNativeAPI("glDeleteVertexArrays")] public static delegate* unmanaged<int, uint*, void> glDeleteVertexArrays;
        [QGLNativeAPI("glGenVertexArrays")] public static delegate* unmanaged<int, uint*, void> glGenVertexArrays;
        [QGLNativeAPI("glIsVertexArray")] public static delegate* unmanaged<uint, bool> glIsVertexArray;
        #endregion
    }
}
