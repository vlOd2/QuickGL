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

// Bindings generated at 2025-01-07 20:24:12.646961
namespace QuickGLNS.Bindings
{
    [GLFeature(true)]
    public static unsafe class GLES30
    {
        #region Enums
        public const int GL_READ_BUFFER = 0xC02;
        public const int GL_UNPACK_ROW_LENGTH = 0xCF2;
        public const int GL_UNPACK_SKIP_ROWS = 0xCF3;
        public const int GL_UNPACK_SKIP_PIXELS = 0xCF4;
        public const int GL_PACK_ROW_LENGTH = 0xD02;
        public const int GL_PACK_SKIP_ROWS = 0xD03;
        public const int GL_PACK_SKIP_PIXELS = 0xD04;
        public const int GL_COLOR = 0x1800;
        public const int GL_DEPTH = 0x1801;
        public const int GL_STENCIL = 0x1802;
        public const int GL_RED = 0x1903;
        public const int GL_RGB8 = 0x8051;
        public const int GL_RGBA8 = 0x8058;
        public const int GL_RGB10_A2 = 0x8059;
        public const int GL_TEXTURE_BINDING_3D = 0x806A;
        public const int GL_UNPACK_SKIP_IMAGES = 0x806D;
        public const int GL_UNPACK_IMAGE_HEIGHT = 0x806E;
        public const int GL_TEXTURE_3D = 0x806F;
        public const int GL_TEXTURE_WRAP_R = 0x8072;
        public const int GL_MAX_3D_TEXTURE_SIZE = 0x8073;
        public const int GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
        public const int GL_MAX_ELEMENTS_VERTICES = 0x80E8;
        public const int GL_MAX_ELEMENTS_INDICES = 0x80E9;
        public const int GL_TEXTURE_MIN_LOD = 0x813A;
        public const int GL_TEXTURE_MAX_LOD = 0x813B;
        public const int GL_TEXTURE_BASE_LEVEL = 0x813C;
        public const int GL_TEXTURE_MAX_LEVEL = 0x813D;
        public const int GL_MIN = 0x8007;
        public const int GL_MAX = 0x8008;
        public const int GL_DEPTH_COMPONENT24 = 0x81A6;
        public const int GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;
        public const int GL_TEXTURE_COMPARE_MODE = 0x884C;
        public const int GL_TEXTURE_COMPARE_FUNC = 0x884D;
        public const int GL_CURRENT_QUERY = 0x8865;
        public const int GL_QUERY_RESULT = 0x8866;
        public const int GL_QUERY_RESULT_AVAILABLE = 0x8867;
        public const int GL_BUFFER_MAPPED = 0x88BC;
        public const int GL_BUFFER_MAP_POINTER = 0x88BD;
        public const int GL_STREAM_READ = 0x88E1;
        public const int GL_STREAM_COPY = 0x88E2;
        public const int GL_STATIC_READ = 0x88E5;
        public const int GL_STATIC_COPY = 0x88E6;
        public const int GL_DYNAMIC_READ = 0x88E9;
        public const int GL_DYNAMIC_COPY = 0x88EA;
        public const int GL_MAX_DRAW_BUFFERS = 0x8824;
        public const int GL_DRAW_BUFFER0 = 0x8825;
        public const int GL_DRAW_BUFFER1 = 0x8826;
        public const int GL_DRAW_BUFFER2 = 0x8827;
        public const int GL_DRAW_BUFFER3 = 0x8828;
        public const int GL_DRAW_BUFFER4 = 0x8829;
        public const int GL_DRAW_BUFFER5 = 0x882A;
        public const int GL_DRAW_BUFFER6 = 0x882B;
        public const int GL_DRAW_BUFFER7 = 0x882C;
        public const int GL_DRAW_BUFFER8 = 0x882D;
        public const int GL_DRAW_BUFFER9 = 0x882E;
        public const int GL_DRAW_BUFFER10 = 0x882F;
        public const int GL_DRAW_BUFFER11 = 0x8830;
        public const int GL_DRAW_BUFFER12 = 0x8831;
        public const int GL_DRAW_BUFFER13 = 0x8832;
        public const int GL_DRAW_BUFFER14 = 0x8833;
        public const int GL_DRAW_BUFFER15 = 0x8834;
        public const int GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
        public const int GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
        public const int GL_SAMPLER_3D = 0x8B5F;
        public const int GL_SAMPLER_2D_SHADOW = 0x8B62;
        public const int GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
        public const int GL_PIXEL_PACK_BUFFER = 0x88EB;
        public const int GL_PIXEL_UNPACK_BUFFER = 0x88EC;
        public const int GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
        public const int GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
        public const int GL_FLOAT_MAT2x3 = 0x8B65;
        public const int GL_FLOAT_MAT2x4 = 0x8B66;
        public const int GL_FLOAT_MAT3x2 = 0x8B67;
        public const int GL_FLOAT_MAT3x4 = 0x8B68;
        public const int GL_FLOAT_MAT4x2 = 0x8B69;
        public const int GL_FLOAT_MAT4x3 = 0x8B6A;
        public const int GL_SRGB = 0x8C40;
        public const int GL_SRGB8 = 0x8C41;
        public const int GL_SRGB8_ALPHA8 = 0x8C43;
        public const int GL_COMPARE_REF_TO_TEXTURE = 0x884E;
        public const int GL_MAJOR_VERSION = 0x821B;
        public const int GL_MINOR_VERSION = 0x821C;
        public const int GL_NUM_EXTENSIONS = 0x821D;
        public const int GL_RGBA32F = 0x8814;
        public const int GL_RGB32F = 0x8815;
        public const int GL_RGBA16F = 0x881A;
        public const int GL_RGB16F = 0x881B;
        public const int GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
        public const int GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
        public const int GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
        public const int GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
        public const int GL_MAX_VARYING_COMPONENTS = 0x8B4B;
        public const int GL_TEXTURE_2D_ARRAY = 0x8C1A;
        public const int GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
        public const int GL_R11F_G11F_B10F = 0x8C3A;
        public const int GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
        public const int GL_RGB9_E5 = 0x8C3D;
        public const int GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
        public const int GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
        public const int GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
        public const int GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
        public const int GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
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
        public const int GL_RGB_INTEGER = 0x8D98;
        public const int GL_RGBA_INTEGER = 0x8D99;
        public const int GL_SAMPLER_2D_ARRAY = 0x8DC1;
        public const int GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
        public const int GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
        public const int GL_UNSIGNED_INT_VEC2 = 0x8DC6;
        public const int GL_UNSIGNED_INT_VEC3 = 0x8DC7;
        public const int GL_UNSIGNED_INT_VEC4 = 0x8DC8;
        public const int GL_INT_SAMPLER_2D = 0x8DCA;
        public const int GL_INT_SAMPLER_3D = 0x8DCB;
        public const int GL_INT_SAMPLER_CUBE = 0x8DCC;
        public const int GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
        public const int GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
        public const int GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
        public const int GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
        public const int GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
        public const int GL_BUFFER_ACCESS_FLAGS = 0x911F;
        public const int GL_BUFFER_MAP_LENGTH = 0x9120;
        public const int GL_BUFFER_MAP_OFFSET = 0x9121;
        public const int GL_DEPTH_COMPONENT32F = 0x8CAC;
        public const int GL_DEPTH32F_STENCIL8 = 0x8CAD;
        public const int GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
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
        public const int GL_DEPTH_STENCIL = 0x84F9;
        public const int GL_UNSIGNED_INT_24_8 = 0x84FA;
        public const int GL_DEPTH24_STENCIL8 = 0x88F0;
        public const int GL_UNSIGNED_NORMALIZED = 0x8C17;
        public const int GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
        public const int GL_READ_FRAMEBUFFER = 0x8CA8;
        public const int GL_DRAW_FRAMEBUFFER = 0x8CA9;
        public const int GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
        public const int GL_RENDERBUFFER_SAMPLES = 0x8CAB;
        public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
        public const int GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
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
        public const int GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
        public const int GL_MAX_SAMPLES = 0x8D57;
        public const int GL_HALF_FLOAT = 0x140B;
        public const int GL_MAP_READ_BIT = 0x1;
        public const int GL_MAP_WRITE_BIT = 0x2;
        public const int GL_MAP_INVALIDATE_RANGE_BIT = 0x4;
        public const int GL_MAP_INVALIDATE_BUFFER_BIT = 0x8;
        public const int GL_MAP_FLUSH_EXPLICIT_BIT = 0x10;
        public const int GL_MAP_UNSYNCHRONIZED_BIT = 0x20;
        public const int GL_RG = 0x8227;
        public const int GL_RG_INTEGER = 0x8228;
        public const int GL_R8 = 0x8229;
        public const int GL_RG8 = 0x822B;
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
        public const int GL_R8_SNORM = 0x8F94;
        public const int GL_RG8_SNORM = 0x8F95;
        public const int GL_RGB8_SNORM = 0x8F96;
        public const int GL_RGBA8_SNORM = 0x8F97;
        public const int GL_SIGNED_NORMALIZED = 0x8F9C;
        public const int GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
        public const int GL_COPY_READ_BUFFER = 0x8F36;
        public const int GL_COPY_WRITE_BUFFER = 0x8F37;
        public const int GL_COPY_READ_BUFFER_BINDING = 0x8F36;
        public const int GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;
        public const int GL_UNIFORM_BUFFER = 0x8A11;
        public const int GL_UNIFORM_BUFFER_BINDING = 0x8A28;
        public const int GL_UNIFORM_BUFFER_START = 0x8A29;
        public const int GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
        public const int GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
        public const int GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
        public const int GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
        public const int GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
        public const int GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
        public const int GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
        public const int GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
        public const int GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
        public const int GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
        public const int GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
        public const int GL_UNIFORM_TYPE = 0x8A37;
        public const int GL_UNIFORM_SIZE = 0x8A38;
        public const int GL_UNIFORM_NAME_LENGTH = 0x8A39;
        public const int GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
        public const int GL_UNIFORM_OFFSET = 0x8A3B;
        public const int GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
        public const int GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
        public const int GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
        public const int GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
        public const int GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
        public const int GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
        public const int GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
        public const int GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
        public const int GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
        public const int GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
        public const uint GL_INVALID_INDEX = 0xFFFFFFFF;
        public const int GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
        public const int GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
        public const int GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
        public const int GL_OBJECT_TYPE = 0x9112;
        public const int GL_SYNC_CONDITION = 0x9113;
        public const int GL_SYNC_STATUS = 0x9114;
        public const int GL_SYNC_FLAGS = 0x9115;
        public const int GL_SYNC_FENCE = 0x9116;
        public const int GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
        public const int GL_UNSIGNALED = 0x9118;
        public const int GL_SIGNALED = 0x9119;
        public const int GL_ALREADY_SIGNALED = 0x911A;
        public const int GL_TIMEOUT_EXPIRED = 0x911B;
        public const int GL_CONDITION_SATISFIED = 0x911C;
        public const int GL_WAIT_FAILED = 0x911D;
        public const int GL_SYNC_FLUSH_COMMANDS_BIT = 0x1;
        public const ulong GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
        public const int GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
        public const int GL_ANY_SAMPLES_PASSED = 0x8C2F;
        public const int GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
        public const int GL_SAMPLER_BINDING = 0x8919;
        public const int GL_RGB10_A2UI = 0x906F;
        public const int GL_TEXTURE_SWIZZLE_R = 0x8E42;
        public const int GL_TEXTURE_SWIZZLE_G = 0x8E43;
        public const int GL_TEXTURE_SWIZZLE_B = 0x8E44;
        public const int GL_TEXTURE_SWIZZLE_A = 0x8E45;
        public const int GL_GREEN = 0x1904;
        public const int GL_BLUE = 0x1905;
        public const int GL_INT_2_10_10_10_REV = 0x8D9F;
        public const int GL_TRANSFORM_FEEDBACK = 0x8E22;
        public const int GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
        public const int GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
        public const int GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
        public const int GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
        public const int GL_PROGRAM_BINARY_LENGTH = 0x8741;
        public const int GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
        public const int GL_PROGRAM_BINARY_FORMATS = 0x87FF;
        public const int GL_COMPRESSED_R11_EAC = 0x9270;
        public const int GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
        public const int GL_COMPRESSED_RG11_EAC = 0x9272;
        public const int GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
        public const int GL_COMPRESSED_RGB8_ETC2 = 0x9274;
        public const int GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
        public const int GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
        public const int GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
        public const int GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
        public const int GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
        public const int GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
        public const int GL_MAX_ELEMENT_INDEX = 0x8D6B;
        public const int GL_NUM_SAMPLE_COUNTS = 0x9380;
        public const int GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
        #endregion
        
        #region Commands
        public static void glReadBuffer(uint src) => _glReadBuffer(src);
        [QGLNativeAPI("glReadBuffer")] internal static delegate* unmanaged<uint, void> _glReadBuffer = null;
        
        public static void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices) => _glDrawRangeElements(mode, start, end, count, type, indices);
        [QGLNativeAPI("glDrawRangeElements")] internal static delegate* unmanaged<uint, uint, uint, int, uint, void*, void> _glDrawRangeElements = null;
        
        public static void glTexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels) => _glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
        [QGLNativeAPI("glTexImage3D")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, uint, uint, void*, void> _glTexImage3D = null;
        
        public static void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels) => _glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        [QGLNativeAPI("glTexSubImage3D")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void> _glTexSubImage3D = null;
        
        public static void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) => _glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        [QGLNativeAPI("glCopyTexSubImage3D")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, int, void> _glCopyTexSubImage3D = null;
        
        public static void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data) => _glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
        [QGLNativeAPI("glCompressedTexImage3D")] internal static delegate* unmanaged<uint, int, uint, int, int, int, int, int, void*, void> _glCompressedTexImage3D = null;
        
        public static void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data) => _glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        [QGLNativeAPI("glCompressedTexSubImage3D")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, int, void*, void> _glCompressedTexSubImage3D = null;
        
        public static void glGenQueries(int n, uint* ids) => _glGenQueries(n, ids);
        [QGLNativeAPI("glGenQueries")] internal static delegate* unmanaged<int, uint*, void> _glGenQueries = null;
        
        public static void glDeleteQueries(int n, uint* ids) => _glDeleteQueries(n, ids);
        [QGLNativeAPI("glDeleteQueries")] internal static delegate* unmanaged<int, uint*, void> _glDeleteQueries = null;
        
        public static bool glIsQuery(uint id) => _glIsQuery(id);
        [QGLNativeAPI("glIsQuery")] internal static delegate* unmanaged<uint, bool> _glIsQuery = null;
        
        public static void glBeginQuery(uint target, uint id) => _glBeginQuery(target, id);
        [QGLNativeAPI("glBeginQuery")] internal static delegate* unmanaged<uint, uint, void> _glBeginQuery = null;
        
        public static void glEndQuery(uint target) => _glEndQuery(target);
        [QGLNativeAPI("glEndQuery")] internal static delegate* unmanaged<uint, void> _glEndQuery = null;
        
        public static void glGetQueryiv(uint target, uint pname, int* @params) => _glGetQueryiv(target, pname, @params);
        [QGLNativeAPI("glGetQueryiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetQueryiv = null;
        
        public static void glGetQueryObjectuiv(uint id, uint pname, uint* @params) => _glGetQueryObjectuiv(id, pname, @params);
        [QGLNativeAPI("glGetQueryObjectuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glGetQueryObjectuiv = null;
        
        public static bool glUnmapBuffer(uint target) => _glUnmapBuffer(target);
        [QGLNativeAPI("glUnmapBuffer")] internal static delegate* unmanaged<uint, bool> _glUnmapBuffer = null;
        
        public static void glGetBufferPointerv(uint target, uint pname, void** @params) => _glGetBufferPointerv(target, pname, @params);
        [QGLNativeAPI("glGetBufferPointerv")] internal static delegate* unmanaged<uint, uint, void**, void> _glGetBufferPointerv = null;
        
        public static void glDrawBuffers(int n, uint* bufs) => _glDrawBuffers(n, bufs);
        [QGLNativeAPI("glDrawBuffers")] internal static delegate* unmanaged<int, uint*, void> _glDrawBuffers = null;
        
        public static void glUniformMatrix2x3fv(int location, int count, bool transpose, float* value) => _glUniformMatrix2x3fv(location, count, transpose, value);
        [QGLNativeAPI("glUniformMatrix2x3fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix2x3fv = null;
        
        public static void glUniformMatrix3x2fv(int location, int count, bool transpose, float* value) => _glUniformMatrix3x2fv(location, count, transpose, value);
        [QGLNativeAPI("glUniformMatrix3x2fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix3x2fv = null;
        
        public static void glUniformMatrix2x4fv(int location, int count, bool transpose, float* value) => _glUniformMatrix2x4fv(location, count, transpose, value);
        [QGLNativeAPI("glUniformMatrix2x4fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix2x4fv = null;
        
        public static void glUniformMatrix4x2fv(int location, int count, bool transpose, float* value) => _glUniformMatrix4x2fv(location, count, transpose, value);
        [QGLNativeAPI("glUniformMatrix4x2fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix4x2fv = null;
        
        public static void glUniformMatrix3x4fv(int location, int count, bool transpose, float* value) => _glUniformMatrix3x4fv(location, count, transpose, value);
        [QGLNativeAPI("glUniformMatrix3x4fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix3x4fv = null;
        
        public static void glUniformMatrix4x3fv(int location, int count, bool transpose, float* value) => _glUniformMatrix4x3fv(location, count, transpose, value);
        [QGLNativeAPI("glUniformMatrix4x3fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix4x3fv = null;
        
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
        
        public static void glGetIntegeri_v(uint target, uint index, int* data) => _glGetIntegeri_v(target, index, data);
        [QGLNativeAPI("glGetIntegeri_v")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetIntegeri_v = null;
        
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
        
        public static void glVertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer) => _glVertexAttribIPointer(index, size, type, stride, pointer);
        [QGLNativeAPI("glVertexAttribIPointer")] internal static delegate* unmanaged<uint, int, uint, int, void*, void> _glVertexAttribIPointer = null;
        
        public static void glGetVertexAttribIiv(uint index, uint pname, int* @params) => _glGetVertexAttribIiv(index, pname, @params);
        [QGLNativeAPI("glGetVertexAttribIiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetVertexAttribIiv = null;
        
        public static void glGetVertexAttribIuiv(uint index, uint pname, uint* @params) => _glGetVertexAttribIuiv(index, pname, @params);
        [QGLNativeAPI("glGetVertexAttribIuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glGetVertexAttribIuiv = null;
        
        public static void glVertexAttribI4i(uint index, int x, int y, int z, int w) => _glVertexAttribI4i(index, x, y, z, w);
        [QGLNativeAPI("glVertexAttribI4i")] internal static delegate* unmanaged<uint, int, int, int, int, void> _glVertexAttribI4i = null;
        
        public static void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) => _glVertexAttribI4ui(index, x, y, z, w);
        [QGLNativeAPI("glVertexAttribI4ui")] internal static delegate* unmanaged<uint, uint, uint, uint, uint, void> _glVertexAttribI4ui = null;
        
        public static void glVertexAttribI4iv(uint index, int* v) => _glVertexAttribI4iv(index, v);
        [QGLNativeAPI("glVertexAttribI4iv")] internal static delegate* unmanaged<uint, int*, void> _glVertexAttribI4iv = null;
        
        public static void glVertexAttribI4uiv(uint index, uint* v) => _glVertexAttribI4uiv(index, v);
        [QGLNativeAPI("glVertexAttribI4uiv")] internal static delegate* unmanaged<uint, uint*, void> _glVertexAttribI4uiv = null;
        
        public static void glGetUniformuiv(uint program, int location, uint* @params) => _glGetUniformuiv(program, location, @params);
        [QGLNativeAPI("glGetUniformuiv")] internal static delegate* unmanaged<uint, int, uint*, void> _glGetUniformuiv = null;
        
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
        
        public static void glCopyBufferSubData(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size) => _glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
        [QGLNativeAPI("glCopyBufferSubData")] internal static delegate* unmanaged<uint, uint, nint, nint, nint, void> _glCopyBufferSubData = null;
        
        public static void glGetUniformIndices(uint program, int uniformCount, byte** uniformNames, uint* uniformIndices) => _glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
        [QGLNativeAPI("glGetUniformIndices")] internal static delegate* unmanaged<uint, int, byte**, uint*, void> _glGetUniformIndices = null;
        
        public static void glGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* @params) => _glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params);
        [QGLNativeAPI("glGetActiveUniformsiv")] internal static delegate* unmanaged<uint, int, uint*, uint, int*, void> _glGetActiveUniformsiv = null;
        
        public static uint glGetUniformBlockIndex(uint program, byte* uniformBlockName) => _glGetUniformBlockIndex(program, uniformBlockName);
        [QGLNativeAPI("glGetUniformBlockIndex")] internal static delegate* unmanaged<uint, byte*, uint> _glGetUniformBlockIndex = null;
        
        public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* @params) => _glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params);
        [QGLNativeAPI("glGetActiveUniformBlockiv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetActiveUniformBlockiv = null;
        
        public static void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName) => _glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
        [QGLNativeAPI("glGetActiveUniformBlockName")] internal static delegate* unmanaged<uint, uint, int, int*, byte*, void> _glGetActiveUniformBlockName = null;
        
        public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) => _glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
        [QGLNativeAPI("glUniformBlockBinding")] internal static delegate* unmanaged<uint, uint, uint, void> _glUniformBlockBinding = null;
        
        public static void glDrawArraysInstanced(uint mode, int first, int count, int instancecount) => _glDrawArraysInstanced(mode, first, count, instancecount);
        [QGLNativeAPI("glDrawArraysInstanced")] internal static delegate* unmanaged<uint, int, int, int, void> _glDrawArraysInstanced = null;
        
        public static void glDrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount) => _glDrawElementsInstanced(mode, count, type, indices, instancecount);
        [QGLNativeAPI("glDrawElementsInstanced")] internal static delegate* unmanaged<uint, int, uint, void*, int, void> _glDrawElementsInstanced = null;
        
        public static nint glFenceSync(uint condition, uint flags) => _glFenceSync(condition, flags);
        [QGLNativeAPI("glFenceSync")] internal static delegate* unmanaged<uint, uint, nint> _glFenceSync = null;
        
        public static bool glIsSync(nint sync) => _glIsSync(sync);
        [QGLNativeAPI("glIsSync")] internal static delegate* unmanaged<nint, bool> _glIsSync = null;
        
        public static void glDeleteSync(nint sync) => _glDeleteSync(sync);
        [QGLNativeAPI("glDeleteSync")] internal static delegate* unmanaged<nint, void> _glDeleteSync = null;
        
        public static uint glClientWaitSync(nint sync, uint flags, ulong timeout) => _glClientWaitSync(sync, flags, timeout);
        [QGLNativeAPI("glClientWaitSync")] internal static delegate* unmanaged<nint, uint, ulong, uint> _glClientWaitSync = null;
        
        public static void glWaitSync(nint sync, uint flags, ulong timeout) => _glWaitSync(sync, flags, timeout);
        [QGLNativeAPI("glWaitSync")] internal static delegate* unmanaged<nint, uint, ulong, void> _glWaitSync = null;
        
        public static void glGetInteger64v(uint pname, long* data) => _glGetInteger64v(pname, data);
        [QGLNativeAPI("glGetInteger64v")] internal static delegate* unmanaged<uint, long*, void> _glGetInteger64v = null;
        
        public static void glGetSynciv(nint sync, uint pname, int count, int* length, int* values) => _glGetSynciv(sync, pname, count, length, values);
        [QGLNativeAPI("glGetSynciv")] internal static delegate* unmanaged<nint, uint, int, int*, int*, void> _glGetSynciv = null;
        
        public static void glGetInteger64i_v(uint target, uint index, long* data) => _glGetInteger64i_v(target, index, data);
        [QGLNativeAPI("glGetInteger64i_v")] internal static delegate* unmanaged<uint, uint, long*, void> _glGetInteger64i_v = null;
        
        public static void glGetBufferParameteri64v(uint target, uint pname, long* @params) => _glGetBufferParameteri64v(target, pname, @params);
        [QGLNativeAPI("glGetBufferParameteri64v")] internal static delegate* unmanaged<uint, uint, long*, void> _glGetBufferParameteri64v = null;
        
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
        
        public static void glGetSamplerParameteriv(uint sampler, uint pname, int* @params) => _glGetSamplerParameteriv(sampler, pname, @params);
        [QGLNativeAPI("glGetSamplerParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetSamplerParameteriv = null;
        
        public static void glGetSamplerParameterfv(uint sampler, uint pname, float* @params) => _glGetSamplerParameterfv(sampler, pname, @params);
        [QGLNativeAPI("glGetSamplerParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetSamplerParameterfv = null;
        
        public static void glVertexAttribDivisor(uint index, uint divisor) => _glVertexAttribDivisor(index, divisor);
        [QGLNativeAPI("glVertexAttribDivisor")] internal static delegate* unmanaged<uint, uint, void> _glVertexAttribDivisor = null;
        
        public static void glBindTransformFeedback(uint target, uint id) => _glBindTransformFeedback(target, id);
        [QGLNativeAPI("glBindTransformFeedback")] internal static delegate* unmanaged<uint, uint, void> _glBindTransformFeedback = null;
        
        public static void glDeleteTransformFeedbacks(int n, uint* ids) => _glDeleteTransformFeedbacks(n, ids);
        [QGLNativeAPI("glDeleteTransformFeedbacks")] internal static delegate* unmanaged<int, uint*, void> _glDeleteTransformFeedbacks = null;
        
        public static void glGenTransformFeedbacks(int n, uint* ids) => _glGenTransformFeedbacks(n, ids);
        [QGLNativeAPI("glGenTransformFeedbacks")] internal static delegate* unmanaged<int, uint*, void> _glGenTransformFeedbacks = null;
        
        public static bool glIsTransformFeedback(uint id) => _glIsTransformFeedback(id);
        [QGLNativeAPI("glIsTransformFeedback")] internal static delegate* unmanaged<uint, bool> _glIsTransformFeedback = null;
        
        public static void glPauseTransformFeedback() => _glPauseTransformFeedback();
        [QGLNativeAPI("glPauseTransformFeedback")] internal static delegate* unmanaged<void> _glPauseTransformFeedback = null;
        
        public static void glResumeTransformFeedback() => _glResumeTransformFeedback();
        [QGLNativeAPI("glResumeTransformFeedback")] internal static delegate* unmanaged<void> _glResumeTransformFeedback = null;
        
        public static void glGetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary) => _glGetProgramBinary(program, bufSize, length, binaryFormat, binary);
        [QGLNativeAPI("glGetProgramBinary")] internal static delegate* unmanaged<uint, int, int*, uint*, void*, void> _glGetProgramBinary = null;
        
        public static void glProgramBinary(uint program, uint binaryFormat, void* binary, int length) => _glProgramBinary(program, binaryFormat, binary, length);
        [QGLNativeAPI("glProgramBinary")] internal static delegate* unmanaged<uint, uint, void*, int, void> _glProgramBinary = null;
        
        public static void glProgramParameteri(uint program, uint pname, int value) => _glProgramParameteri(program, pname, value);
        [QGLNativeAPI("glProgramParameteri")] internal static delegate* unmanaged<uint, uint, int, void> _glProgramParameteri = null;
        
        public static void glInvalidateFramebuffer(uint target, int numAttachments, uint* attachments) => _glInvalidateFramebuffer(target, numAttachments, attachments);
        [QGLNativeAPI("glInvalidateFramebuffer")] internal static delegate* unmanaged<uint, int, uint*, void> _glInvalidateFramebuffer = null;
        
        public static void glInvalidateSubFramebuffer(uint target, int numAttachments, uint* attachments, int x, int y, int width, int height) => _glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
        [QGLNativeAPI("glInvalidateSubFramebuffer")] internal static delegate* unmanaged<uint, int, uint*, int, int, int, int, void> _glInvalidateSubFramebuffer = null;
        
        public static void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height) => _glTexStorage2D(target, levels, internalformat, width, height);
        [QGLNativeAPI("glTexStorage2D")] internal static delegate* unmanaged<uint, int, uint, int, int, void> _glTexStorage2D = null;
        
        public static void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth) => _glTexStorage3D(target, levels, internalformat, width, height, depth);
        [QGLNativeAPI("glTexStorage3D")] internal static delegate* unmanaged<uint, int, uint, int, int, int, void> _glTexStorage3D = null;
        
        public static void glGetInternalformativ(uint target, uint internalformat, uint pname, int count, int* @params) => _glGetInternalformativ(target, internalformat, pname, count, @params);
        [QGLNativeAPI("glGetInternalformativ")] internal static delegate* unmanaged<uint, uint, uint, int, int*, void> _glGetInternalformativ = null;
        #endregion
    }
}
