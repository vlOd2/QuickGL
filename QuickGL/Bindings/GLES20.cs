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

// Bindings generated at 2025-02-21 16:29:58.879773
namespace QuickGLNS.Bindings;

[GLFeature(true)]
public static unsafe class GLES20
{
    #region Enums
    public const int GL_DEPTH_BUFFER_BIT = 0x100;
    public const int GL_STENCIL_BUFFER_BIT = 0x400;
    public const int GL_COLOR_BUFFER_BIT = 0x4000;
    public const int GL_FALSE = 0x0;
    public const int GL_TRUE = 0x1;
    public const int GL_POINTS = 0x0;
    public const int GL_LINES = 0x1;
    public const int GL_LINE_LOOP = 0x2;
    public const int GL_LINE_STRIP = 0x3;
    public const int GL_TRIANGLES = 0x4;
    public const int GL_TRIANGLE_STRIP = 0x5;
    public const int GL_TRIANGLE_FAN = 0x6;
    public const int GL_ZERO = 0x0;
    public const int GL_ONE = 0x1;
    public const int GL_SRC_COLOR = 0x300;
    public const int GL_ONE_MINUS_SRC_COLOR = 0x301;
    public const int GL_SRC_ALPHA = 0x302;
    public const int GL_ONE_MINUS_SRC_ALPHA = 0x303;
    public const int GL_DST_ALPHA = 0x304;
    public const int GL_ONE_MINUS_DST_ALPHA = 0x305;
    public const int GL_DST_COLOR = 0x306;
    public const int GL_ONE_MINUS_DST_COLOR = 0x307;
    public const int GL_SRC_ALPHA_SATURATE = 0x308;
    public const int GL_FUNC_ADD = 0x8006;
    public const int GL_BLEND_EQUATION = 0x8009;
    public const int GL_BLEND_EQUATION_RGB = 0x8009;
    public const int GL_BLEND_EQUATION_ALPHA = 0x883D;
    public const int GL_FUNC_SUBTRACT = 0x800A;
    public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;
    public const int GL_BLEND_DST_RGB = 0x80C8;
    public const int GL_BLEND_SRC_RGB = 0x80C9;
    public const int GL_BLEND_DST_ALPHA = 0x80CA;
    public const int GL_BLEND_SRC_ALPHA = 0x80CB;
    public const int GL_CONSTANT_COLOR = 0x8001;
    public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
    public const int GL_CONSTANT_ALPHA = 0x8003;
    public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
    public const int GL_BLEND_COLOR = 0x8005;
    public const int GL_ARRAY_BUFFER = 0x8892;
    public const int GL_ELEMENT_ARRAY_BUFFER = 0x8893;
    public const int GL_ARRAY_BUFFER_BINDING = 0x8894;
    public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
    public const int GL_STREAM_DRAW = 0x88E0;
    public const int GL_STATIC_DRAW = 0x88E4;
    public const int GL_DYNAMIC_DRAW = 0x88E8;
    public const int GL_BUFFER_SIZE = 0x8764;
    public const int GL_BUFFER_USAGE = 0x8765;
    public const int GL_CURRENT_VERTEX_ATTRIB = 0x8626;
    public const int GL_FRONT = 0x404;
    public const int GL_BACK = 0x405;
    public const int GL_FRONT_AND_BACK = 0x408;
    public const int GL_TEXTURE_2D = 0xDE1;
    public const int GL_CULL_FACE = 0xB44;
    public const int GL_BLEND = 0xBE2;
    public const int GL_DITHER = 0xBD0;
    public const int GL_STENCIL_TEST = 0xB90;
    public const int GL_DEPTH_TEST = 0xB71;
    public const int GL_SCISSOR_TEST = 0xC11;
    public const int GL_POLYGON_OFFSET_FILL = 0x8037;
    public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
    public const int GL_SAMPLE_COVERAGE = 0x80A0;
    public const int GL_NO_ERROR = 0x0;
    public const int GL_INVALID_ENUM = 0x500;
    public const int GL_INVALID_VALUE = 0x501;
    public const int GL_INVALID_OPERATION = 0x502;
    public const int GL_OUT_OF_MEMORY = 0x505;
    public const int GL_CW = 0x900;
    public const int GL_CCW = 0x901;
    public const int GL_LINE_WIDTH = 0xB21;
    public const int GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
    public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
    public const int GL_CULL_FACE_MODE = 0xB45;
    public const int GL_FRONT_FACE = 0xB46;
    public const int GL_DEPTH_RANGE = 0xB70;
    public const int GL_DEPTH_WRITEMASK = 0xB72;
    public const int GL_DEPTH_CLEAR_VALUE = 0xB73;
    public const int GL_DEPTH_FUNC = 0xB74;
    public const int GL_STENCIL_CLEAR_VALUE = 0xB91;
    public const int GL_STENCIL_FUNC = 0xB92;
    public const int GL_STENCIL_FAIL = 0xB94;
    public const int GL_STENCIL_PASS_DEPTH_FAIL = 0xB95;
    public const int GL_STENCIL_PASS_DEPTH_PASS = 0xB96;
    public const int GL_STENCIL_REF = 0xB97;
    public const int GL_STENCIL_VALUE_MASK = 0xB93;
    public const int GL_STENCIL_WRITEMASK = 0xB98;
    public const int GL_STENCIL_BACK_FUNC = 0x8800;
    public const int GL_STENCIL_BACK_FAIL = 0x8801;
    public const int GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
    public const int GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
    public const int GL_STENCIL_BACK_REF = 0x8CA3;
    public const int GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;
    public const int GL_STENCIL_BACK_WRITEMASK = 0x8CA5;
    public const int GL_VIEWPORT = 0xBA2;
    public const int GL_SCISSOR_BOX = 0xC10;
    public const int GL_COLOR_CLEAR_VALUE = 0xC22;
    public const int GL_COLOR_WRITEMASK = 0xC23;
    public const int GL_UNPACK_ALIGNMENT = 0xCF5;
    public const int GL_PACK_ALIGNMENT = 0xD05;
    public const int GL_MAX_TEXTURE_SIZE = 0xD33;
    public const int GL_MAX_VIEWPORT_DIMS = 0xD3A;
    public const int GL_SUBPIXEL_BITS = 0xD50;
    public const int GL_RED_BITS = 0xD52;
    public const int GL_GREEN_BITS = 0xD53;
    public const int GL_BLUE_BITS = 0xD54;
    public const int GL_ALPHA_BITS = 0xD55;
    public const int GL_DEPTH_BITS = 0xD56;
    public const int GL_STENCIL_BITS = 0xD57;
    public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;
    public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;
    public const int GL_TEXTURE_BINDING_2D = 0x8069;
    public const int GL_SAMPLE_BUFFERS = 0x80A8;
    public const int GL_SAMPLES = 0x80A9;
    public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
    public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
    public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
    public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
    public const int GL_DONT_CARE = 0x1100;
    public const int GL_FASTEST = 0x1101;
    public const int GL_NICEST = 0x1102;
    public const int GL_GENERATE_MIPMAP_HINT = 0x8192;
    public const int GL_BYTE = 0x1400;
    public const int GL_UNSIGNED_BYTE = 0x1401;
    public const int GL_SHORT = 0x1402;
    public const int GL_UNSIGNED_SHORT = 0x1403;
    public const int GL_INT = 0x1404;
    public const int GL_UNSIGNED_INT = 0x1405;
    public const int GL_FLOAT = 0x1406;
    public const int GL_FIXED = 0x140C;
    public const int GL_DEPTH_COMPONENT = 0x1902;
    public const int GL_ALPHA = 0x1906;
    public const int GL_RGB = 0x1907;
    public const int GL_RGBA = 0x1908;
    public const int GL_LUMINANCE = 0x1909;
    public const int GL_LUMINANCE_ALPHA = 0x190A;
    public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
    public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
    public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
    public const int GL_FRAGMENT_SHADER = 0x8B30;
    public const int GL_VERTEX_SHADER = 0x8B31;
    public const int GL_MAX_VERTEX_ATTRIBS = 0x8869;
    public const int GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
    public const int GL_MAX_VARYING_VECTORS = 0x8DFC;
    public const int GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
    public const int GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
    public const int GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;
    public const int GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
    public const int GL_SHADER_TYPE = 0x8B4F;
    public const int GL_DELETE_STATUS = 0x8B80;
    public const int GL_LINK_STATUS = 0x8B82;
    public const int GL_VALIDATE_STATUS = 0x8B83;
    public const int GL_ATTACHED_SHADERS = 0x8B85;
    public const int GL_ACTIVE_UNIFORMS = 0x8B86;
    public const int GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
    public const int GL_ACTIVE_ATTRIBUTES = 0x8B89;
    public const int GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
    public const int GL_SHADING_LANGUAGE_VERSION = 0x8B8C;
    public const int GL_CURRENT_PROGRAM = 0x8B8D;
    public const int GL_NEVER = 0x200;
    public const int GL_LESS = 0x201;
    public const int GL_EQUAL = 0x202;
    public const int GL_LEQUAL = 0x203;
    public const int GL_GREATER = 0x204;
    public const int GL_NOTEQUAL = 0x205;
    public const int GL_GEQUAL = 0x206;
    public const int GL_ALWAYS = 0x207;
    public const int GL_KEEP = 0x1E00;
    public const int GL_REPLACE = 0x1E01;
    public const int GL_INCR = 0x1E02;
    public const int GL_DECR = 0x1E03;
    public const int GL_INVERT = 0x150A;
    public const int GL_INCR_WRAP = 0x8507;
    public const int GL_DECR_WRAP = 0x8508;
    public const int GL_VENDOR = 0x1F00;
    public const int GL_RENDERER = 0x1F01;
    public const int GL_VERSION = 0x1F02;
    public const int GL_EXTENSIONS = 0x1F03;
    public const int GL_NEAREST = 0x2600;
    public const int GL_LINEAR = 0x2601;
    public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;
    public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;
    public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;
    public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;
    public const int GL_TEXTURE_MAG_FILTER = 0x2800;
    public const int GL_TEXTURE_MIN_FILTER = 0x2801;
    public const int GL_TEXTURE_WRAP_S = 0x2802;
    public const int GL_TEXTURE_WRAP_T = 0x2803;
    public const int GL_TEXTURE = 0x1702;
    public const int GL_TEXTURE_CUBE_MAP = 0x8513;
    public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
    public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
    public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
    public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
    public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
    public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
    public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
    public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
    public const int GL_TEXTURE0 = 0x84C0;
    public const int GL_TEXTURE1 = 0x84C1;
    public const int GL_TEXTURE2 = 0x84C2;
    public const int GL_TEXTURE3 = 0x84C3;
    public const int GL_TEXTURE4 = 0x84C4;
    public const int GL_TEXTURE5 = 0x84C5;
    public const int GL_TEXTURE6 = 0x84C6;
    public const int GL_TEXTURE7 = 0x84C7;
    public const int GL_TEXTURE8 = 0x84C8;
    public const int GL_TEXTURE9 = 0x84C9;
    public const int GL_TEXTURE10 = 0x84CA;
    public const int GL_TEXTURE11 = 0x84CB;
    public const int GL_TEXTURE12 = 0x84CC;
    public const int GL_TEXTURE13 = 0x84CD;
    public const int GL_TEXTURE14 = 0x84CE;
    public const int GL_TEXTURE15 = 0x84CF;
    public const int GL_TEXTURE16 = 0x84D0;
    public const int GL_TEXTURE17 = 0x84D1;
    public const int GL_TEXTURE18 = 0x84D2;
    public const int GL_TEXTURE19 = 0x84D3;
    public const int GL_TEXTURE20 = 0x84D4;
    public const int GL_TEXTURE21 = 0x84D5;
    public const int GL_TEXTURE22 = 0x84D6;
    public const int GL_TEXTURE23 = 0x84D7;
    public const int GL_TEXTURE24 = 0x84D8;
    public const int GL_TEXTURE25 = 0x84D9;
    public const int GL_TEXTURE26 = 0x84DA;
    public const int GL_TEXTURE27 = 0x84DB;
    public const int GL_TEXTURE28 = 0x84DC;
    public const int GL_TEXTURE29 = 0x84DD;
    public const int GL_TEXTURE30 = 0x84DE;
    public const int GL_TEXTURE31 = 0x84DF;
    public const int GL_ACTIVE_TEXTURE = 0x84E0;
    public const int GL_REPEAT = 0x2901;
    public const int GL_CLAMP_TO_EDGE = 0x812F;
    public const int GL_MIRRORED_REPEAT = 0x8370;
    public const int GL_FLOAT_VEC2 = 0x8B50;
    public const int GL_FLOAT_VEC3 = 0x8B51;
    public const int GL_FLOAT_VEC4 = 0x8B52;
    public const int GL_INT_VEC2 = 0x8B53;
    public const int GL_INT_VEC3 = 0x8B54;
    public const int GL_INT_VEC4 = 0x8B55;
    public const int GL_BOOL = 0x8B56;
    public const int GL_BOOL_VEC2 = 0x8B57;
    public const int GL_BOOL_VEC3 = 0x8B58;
    public const int GL_BOOL_VEC4 = 0x8B59;
    public const int GL_FLOAT_MAT2 = 0x8B5A;
    public const int GL_FLOAT_MAT3 = 0x8B5B;
    public const int GL_FLOAT_MAT4 = 0x8B5C;
    public const int GL_SAMPLER_2D = 0x8B5E;
    public const int GL_SAMPLER_CUBE = 0x8B60;
    public const int GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
    public const int GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
    public const int GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
    public const int GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
    public const int GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
    public const int GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
    public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
    public const int GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
    public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
    public const int GL_COMPILE_STATUS = 0x8B81;
    public const int GL_INFO_LOG_LENGTH = 0x8B84;
    public const int GL_SHADER_SOURCE_LENGTH = 0x8B88;
    public const int GL_SHADER_COMPILER = 0x8DFA;
    public const int GL_SHADER_BINARY_FORMATS = 0x8DF8;
    public const int GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
    public const int GL_LOW_FLOAT = 0x8DF0;
    public const int GL_MEDIUM_FLOAT = 0x8DF1;
    public const int GL_HIGH_FLOAT = 0x8DF2;
    public const int GL_LOW_INT = 0x8DF3;
    public const int GL_MEDIUM_INT = 0x8DF4;
    public const int GL_HIGH_INT = 0x8DF5;
    public const int GL_FRAMEBUFFER = 0x8D40;
    public const int GL_RENDERBUFFER = 0x8D41;
    public const int GL_RGBA4 = 0x8056;
    public const int GL_RGB5_A1 = 0x8057;
    public const int GL_RGB565 = 0x8D62;
    public const int GL_DEPTH_COMPONENT16 = 0x81A5;
    public const int GL_STENCIL_INDEX8 = 0x8D48;
    public const int GL_RENDERBUFFER_WIDTH = 0x8D42;
    public const int GL_RENDERBUFFER_HEIGHT = 0x8D43;
    public const int GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
    public const int GL_RENDERBUFFER_RED_SIZE = 0x8D50;
    public const int GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;
    public const int GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;
    public const int GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;
    public const int GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;
    public const int GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;
    public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
    public const int GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
    public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
    public const int GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
    public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;
    public const int GL_DEPTH_ATTACHMENT = 0x8D00;
    public const int GL_STENCIL_ATTACHMENT = 0x8D20;
    public const int GL_NONE = 0x0;
    public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
    public const int GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
    public const int GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
    public const int GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;
    public const int GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
    public const int GL_FRAMEBUFFER_BINDING = 0x8CA6;
    public const int GL_RENDERBUFFER_BINDING = 0x8CA7;
    public const int GL_MAX_RENDERBUFFER_SIZE = 0x84E8;
    public const int GL_INVALID_FRAMEBUFFER_OPERATION = 0x506;
    #endregion
    
    #region Commands
    public static void glActiveTexture(uint texture) => _glActiveTexture(texture);
    [QGLNativeAPI("glActiveTexture")] internal static delegate* unmanaged<uint, void> _glActiveTexture = null;
    
    public static void glAttachShader(uint program, uint shader) => _glAttachShader(program, shader);
    [QGLNativeAPI("glAttachShader")] internal static delegate* unmanaged<uint, uint, void> _glAttachShader = null;
    
    public static void glBindAttribLocation(uint program, uint index, byte* name) => _glBindAttribLocation(program, index, name);
    [QGLNativeAPI("glBindAttribLocation")] internal static delegate* unmanaged<uint, uint, byte*, void> _glBindAttribLocation = null;
    
    public static void glBindBuffer(uint target, uint buffer) => _glBindBuffer(target, buffer);
    [QGLNativeAPI("glBindBuffer")] internal static delegate* unmanaged<uint, uint, void> _glBindBuffer = null;
    
    public static void glBindFramebuffer(uint target, uint framebuffer) => _glBindFramebuffer(target, framebuffer);
    [QGLNativeAPI("glBindFramebuffer")] internal static delegate* unmanaged<uint, uint, void> _glBindFramebuffer = null;
    
    public static void glBindRenderbuffer(uint target, uint renderbuffer) => _glBindRenderbuffer(target, renderbuffer);
    [QGLNativeAPI("glBindRenderbuffer")] internal static delegate* unmanaged<uint, uint, void> _glBindRenderbuffer = null;
    
    public static void glBindTexture(uint target, uint texture) => _glBindTexture(target, texture);
    [QGLNativeAPI("glBindTexture")] internal static delegate* unmanaged<uint, uint, void> _glBindTexture = null;
    
    public static void glBlendColor(float red, float green, float blue, float alpha) => _glBlendColor(red, green, blue, alpha);
    [QGLNativeAPI("glBlendColor")] internal static delegate* unmanaged<float, float, float, float, void> _glBlendColor = null;
    
    public static void glBlendEquation(uint mode) => _glBlendEquation(mode);
    [QGLNativeAPI("glBlendEquation")] internal static delegate* unmanaged<uint, void> _glBlendEquation = null;
    
    public static void glBlendEquationSeparate(uint modeRGB, uint modeAlpha) => _glBlendEquationSeparate(modeRGB, modeAlpha);
    [QGLNativeAPI("glBlendEquationSeparate")] internal static delegate* unmanaged<uint, uint, void> _glBlendEquationSeparate = null;
    
    public static void glBlendFunc(uint sfactor, uint dfactor) => _glBlendFunc(sfactor, dfactor);
    [QGLNativeAPI("glBlendFunc")] internal static delegate* unmanaged<uint, uint, void> _glBlendFunc = null;
    
    public static void glBlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) => _glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
    [QGLNativeAPI("glBlendFuncSeparate")] internal static delegate* unmanaged<uint, uint, uint, uint, void> _glBlendFuncSeparate = null;
    
    public static void glBufferData(uint target, nint size, void* data, uint usage) => _glBufferData(target, size, data, usage);
    [QGLNativeAPI("glBufferData")] internal static delegate* unmanaged<uint, nint, void*, uint, void> _glBufferData = null;
    
    public static void glBufferSubData(uint target, nint offset, nint size, void* data) => _glBufferSubData(target, offset, size, data);
    [QGLNativeAPI("glBufferSubData")] internal static delegate* unmanaged<uint, nint, nint, void*, void> _glBufferSubData = null;
    
    public static uint glCheckFramebufferStatus(uint target) => _glCheckFramebufferStatus(target);
    [QGLNativeAPI("glCheckFramebufferStatus")] internal static delegate* unmanaged<uint, uint> _glCheckFramebufferStatus = null;
    
    public static void glClear(uint mask) => _glClear(mask);
    [QGLNativeAPI("glClear")] internal static delegate* unmanaged<uint, void> _glClear = null;
    
    public static void glClearColor(float red, float green, float blue, float alpha) => _glClearColor(red, green, blue, alpha);
    [QGLNativeAPI("glClearColor")] internal static delegate* unmanaged<float, float, float, float, void> _glClearColor = null;
    
    public static void glClearDepthf(float d) => _glClearDepthf(d);
    [QGLNativeAPI("glClearDepthf")] internal static delegate* unmanaged<float, void> _glClearDepthf = null;
    
    public static void glClearStencil(int s) => _glClearStencil(s);
    [QGLNativeAPI("glClearStencil")] internal static delegate* unmanaged<int, void> _glClearStencil = null;
    
    public static void glColorMask(bool red, bool green, bool blue, bool alpha) => _glColorMask(red, green, blue, alpha);
    [QGLNativeAPI("glColorMask")] internal static delegate* unmanaged<bool, bool, bool, bool, void> _glColorMask = null;
    
    public static void glCompileShader(uint shader) => _glCompileShader(shader);
    [QGLNativeAPI("glCompileShader")] internal static delegate* unmanaged<uint, void> _glCompileShader = null;
    
    public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data) => _glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
    [QGLNativeAPI("glCompressedTexImage2D")] internal static delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void> _glCompressedTexImage2D = null;
    
    public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) => _glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
    [QGLNativeAPI("glCompressedTexSubImage2D")] internal static delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void> _glCompressedTexSubImage2D = null;
    
    public static void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border) => _glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
    [QGLNativeAPI("glCopyTexImage2D")] internal static delegate* unmanaged<uint, int, uint, int, int, int, int, int, void> _glCopyTexImage2D = null;
    
    public static void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => _glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
    [QGLNativeAPI("glCopyTexSubImage2D")] internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, void> _glCopyTexSubImage2D = null;
    
    public static uint glCreateProgram() => _glCreateProgram();
    [QGLNativeAPI("glCreateProgram")] internal static delegate* unmanaged<uint> _glCreateProgram = null;
    
    public static uint glCreateShader(uint type) => _glCreateShader(type);
    [QGLNativeAPI("glCreateShader")] internal static delegate* unmanaged<uint, uint> _glCreateShader = null;
    
    public static void glCullFace(uint mode) => _glCullFace(mode);
    [QGLNativeAPI("glCullFace")] internal static delegate* unmanaged<uint, void> _glCullFace = null;
    
    public static void glDeleteBuffers(int n, uint* buffers) => _glDeleteBuffers(n, buffers);
    [QGLNativeAPI("glDeleteBuffers")] internal static delegate* unmanaged<int, uint*, void> _glDeleteBuffers = null;
    
    public static void glDeleteFramebuffers(int n, uint* framebuffers) => _glDeleteFramebuffers(n, framebuffers);
    [QGLNativeAPI("glDeleteFramebuffers")] internal static delegate* unmanaged<int, uint*, void> _glDeleteFramebuffers = null;
    
    public static void glDeleteProgram(uint program) => _glDeleteProgram(program);
    [QGLNativeAPI("glDeleteProgram")] internal static delegate* unmanaged<uint, void> _glDeleteProgram = null;
    
    public static void glDeleteRenderbuffers(int n, uint* renderbuffers) => _glDeleteRenderbuffers(n, renderbuffers);
    [QGLNativeAPI("glDeleteRenderbuffers")] internal static delegate* unmanaged<int, uint*, void> _glDeleteRenderbuffers = null;
    
    public static void glDeleteShader(uint shader) => _glDeleteShader(shader);
    [QGLNativeAPI("glDeleteShader")] internal static delegate* unmanaged<uint, void> _glDeleteShader = null;
    
    public static void glDeleteTextures(int n, uint* textures) => _glDeleteTextures(n, textures);
    [QGLNativeAPI("glDeleteTextures")] internal static delegate* unmanaged<int, uint*, void> _glDeleteTextures = null;
    
    public static void glDepthFunc(uint func) => _glDepthFunc(func);
    [QGLNativeAPI("glDepthFunc")] internal static delegate* unmanaged<uint, void> _glDepthFunc = null;
    
    public static void glDepthMask(bool flag) => _glDepthMask(flag);
    [QGLNativeAPI("glDepthMask")] internal static delegate* unmanaged<bool, void> _glDepthMask = null;
    
    public static void glDepthRangef(float n, float f) => _glDepthRangef(n, f);
    [QGLNativeAPI("glDepthRangef")] internal static delegate* unmanaged<float, float, void> _glDepthRangef = null;
    
    public static void glDetachShader(uint program, uint shader) => _glDetachShader(program, shader);
    [QGLNativeAPI("glDetachShader")] internal static delegate* unmanaged<uint, uint, void> _glDetachShader = null;
    
    public static void glDisable(uint cap) => _glDisable(cap);
    [QGLNativeAPI("glDisable")] internal static delegate* unmanaged<uint, void> _glDisable = null;
    
    public static void glDisableVertexAttribArray(uint index) => _glDisableVertexAttribArray(index);
    [QGLNativeAPI("glDisableVertexAttribArray")] internal static delegate* unmanaged<uint, void> _glDisableVertexAttribArray = null;
    
    public static void glDrawArrays(uint mode, int first, int count) => _glDrawArrays(mode, first, count);
    [QGLNativeAPI("glDrawArrays")] internal static delegate* unmanaged<uint, int, int, void> _glDrawArrays = null;
    
    public static void glDrawElements(uint mode, int count, uint type, void* indices) => _glDrawElements(mode, count, type, indices);
    [QGLNativeAPI("glDrawElements")] internal static delegate* unmanaged<uint, int, uint, void*, void> _glDrawElements = null;
    
    public static void glEnable(uint cap) => _glEnable(cap);
    [QGLNativeAPI("glEnable")] internal static delegate* unmanaged<uint, void> _glEnable = null;
    
    public static void glEnableVertexAttribArray(uint index) => _glEnableVertexAttribArray(index);
    [QGLNativeAPI("glEnableVertexAttribArray")] internal static delegate* unmanaged<uint, void> _glEnableVertexAttribArray = null;
    
    public static void glFinish() => _glFinish();
    [QGLNativeAPI("glFinish")] internal static delegate* unmanaged<void> _glFinish = null;
    
    public static void glFlush() => _glFlush();
    [QGLNativeAPI("glFlush")] internal static delegate* unmanaged<void> _glFlush = null;
    
    public static void glFramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) => _glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
    [QGLNativeAPI("glFramebufferRenderbuffer")] internal static delegate* unmanaged<uint, uint, uint, uint, void> _glFramebufferRenderbuffer = null;
    
    public static void glFramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) => _glFramebufferTexture2D(target, attachment, textarget, texture, level);
    [QGLNativeAPI("glFramebufferTexture2D")] internal static delegate* unmanaged<uint, uint, uint, uint, int, void> _glFramebufferTexture2D = null;
    
    public static void glFrontFace(uint mode) => _glFrontFace(mode);
    [QGLNativeAPI("glFrontFace")] internal static delegate* unmanaged<uint, void> _glFrontFace = null;
    
    public static void glGenBuffers(int n, uint* buffers) => _glGenBuffers(n, buffers);
    [QGLNativeAPI("glGenBuffers")] internal static delegate* unmanaged<int, uint*, void> _glGenBuffers = null;
    
    public static void glGenerateMipmap(uint target) => _glGenerateMipmap(target);
    [QGLNativeAPI("glGenerateMipmap")] internal static delegate* unmanaged<uint, void> _glGenerateMipmap = null;
    
    public static void glGenFramebuffers(int n, uint* framebuffers) => _glGenFramebuffers(n, framebuffers);
    [QGLNativeAPI("glGenFramebuffers")] internal static delegate* unmanaged<int, uint*, void> _glGenFramebuffers = null;
    
    public static void glGenRenderbuffers(int n, uint* renderbuffers) => _glGenRenderbuffers(n, renderbuffers);
    [QGLNativeAPI("glGenRenderbuffers")] internal static delegate* unmanaged<int, uint*, void> _glGenRenderbuffers = null;
    
    public static void glGenTextures(int n, uint* textures) => _glGenTextures(n, textures);
    [QGLNativeAPI("glGenTextures")] internal static delegate* unmanaged<int, uint*, void> _glGenTextures = null;
    
    public static void glGetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name) => _glGetActiveAttrib(program, index, bufSize, length, size, type, name);
    [QGLNativeAPI("glGetActiveAttrib")] internal static delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void> _glGetActiveAttrib = null;
    
    public static void glGetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, byte* name) => _glGetActiveUniform(program, index, bufSize, length, size, type, name);
    [QGLNativeAPI("glGetActiveUniform")] internal static delegate* unmanaged<uint, uint, int, int*, int*, uint*, byte*, void> _glGetActiveUniform = null;
    
    public static void glGetAttachedShaders(uint program, int maxCount, int* count, uint* shaders) => _glGetAttachedShaders(program, maxCount, count, shaders);
    [QGLNativeAPI("glGetAttachedShaders")] internal static delegate* unmanaged<uint, int, int*, uint*, void> _glGetAttachedShaders = null;
    
    public static int glGetAttribLocation(uint program, byte* name) => _glGetAttribLocation(program, name);
    [QGLNativeAPI("glGetAttribLocation")] internal static delegate* unmanaged<uint, byte*, int> _glGetAttribLocation = null;
    
    public static void glGetBooleanv(uint pname, bool* data) => _glGetBooleanv(pname, data);
    [QGLNativeAPI("glGetBooleanv")] internal static delegate* unmanaged<uint, bool*, void> _glGetBooleanv = null;
    
    public static void glGetBufferParameteriv(uint target, uint pname, int* @params) => _glGetBufferParameteriv(target, pname, @params);
    [QGLNativeAPI("glGetBufferParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetBufferParameteriv = null;
    
    public static uint glGetError() => _glGetError();
    [QGLNativeAPI("glGetError")] internal static delegate* unmanaged<uint> _glGetError = null;
    
    public static void glGetFloatv(uint pname, float* data) => _glGetFloatv(pname, data);
    [QGLNativeAPI("glGetFloatv")] internal static delegate* unmanaged<uint, float*, void> _glGetFloatv = null;
    
    public static void glGetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* @params) => _glGetFramebufferAttachmentParameteriv(target, attachment, pname, @params);
    [QGLNativeAPI("glGetFramebufferAttachmentParameteriv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetFramebufferAttachmentParameteriv = null;
    
    public static void glGetIntegerv(uint pname, int* data) => _glGetIntegerv(pname, data);
    [QGLNativeAPI("glGetIntegerv")] internal static delegate* unmanaged<uint, int*, void> _glGetIntegerv = null;
    
    public static void glGetProgramiv(uint program, uint pname, int* @params) => _glGetProgramiv(program, pname, @params);
    [QGLNativeAPI("glGetProgramiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetProgramiv = null;
    
    public static void glGetProgramInfoLog(uint program, int bufSize, int* length, byte* infoLog) => _glGetProgramInfoLog(program, bufSize, length, infoLog);
    [QGLNativeAPI("glGetProgramInfoLog")] internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetProgramInfoLog = null;
    
    public static void glGetRenderbufferParameteriv(uint target, uint pname, int* @params) => _glGetRenderbufferParameteriv(target, pname, @params);
    [QGLNativeAPI("glGetRenderbufferParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetRenderbufferParameteriv = null;
    
    public static void glGetShaderiv(uint shader, uint pname, int* @params) => _glGetShaderiv(shader, pname, @params);
    [QGLNativeAPI("glGetShaderiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetShaderiv = null;
    
    public static void glGetShaderInfoLog(uint shader, int bufSize, int* length, byte* infoLog) => _glGetShaderInfoLog(shader, bufSize, length, infoLog);
    [QGLNativeAPI("glGetShaderInfoLog")] internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetShaderInfoLog = null;
    
    public static void glGetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision) => _glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
    [QGLNativeAPI("glGetShaderPrecisionFormat")] internal static delegate* unmanaged<uint, uint, int*, int*, void> _glGetShaderPrecisionFormat = null;
    
    public static void glGetShaderSource(uint shader, int bufSize, int* length, byte* source) => _glGetShaderSource(shader, bufSize, length, source);
    [QGLNativeAPI("glGetShaderSource")] internal static delegate* unmanaged<uint, int, int*, byte*, void> _glGetShaderSource = null;
    
    public static byte* glGetString(uint name) => _glGetString(name);
    [QGLNativeAPI("glGetString")] internal static delegate* unmanaged<uint, byte*> _glGetString = null;
    
    public static void glGetTexParameterfv(uint target, uint pname, float* @params) => _glGetTexParameterfv(target, pname, @params);
    [QGLNativeAPI("glGetTexParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetTexParameterfv = null;
    
    public static void glGetTexParameteriv(uint target, uint pname, int* @params) => _glGetTexParameteriv(target, pname, @params);
    [QGLNativeAPI("glGetTexParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexParameteriv = null;
    
    public static void glGetUniformfv(uint program, int location, float* @params) => _glGetUniformfv(program, location, @params);
    [QGLNativeAPI("glGetUniformfv")] internal static delegate* unmanaged<uint, int, float*, void> _glGetUniformfv = null;
    
    public static void glGetUniformiv(uint program, int location, int* @params) => _glGetUniformiv(program, location, @params);
    [QGLNativeAPI("glGetUniformiv")] internal static delegate* unmanaged<uint, int, int*, void> _glGetUniformiv = null;
    
    public static int glGetUniformLocation(uint program, byte* name) => _glGetUniformLocation(program, name);
    [QGLNativeAPI("glGetUniformLocation")] internal static delegate* unmanaged<uint, byte*, int> _glGetUniformLocation = null;
    
    public static void glGetVertexAttribfv(uint index, uint pname, float* @params) => _glGetVertexAttribfv(index, pname, @params);
    [QGLNativeAPI("glGetVertexAttribfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glGetVertexAttribfv = null;
    
    public static void glGetVertexAttribiv(uint index, uint pname, int* @params) => _glGetVertexAttribiv(index, pname, @params);
    [QGLNativeAPI("glGetVertexAttribiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetVertexAttribiv = null;
    
    public static void glGetVertexAttribPointerv(uint index, uint pname, void** pointer) => _glGetVertexAttribPointerv(index, pname, pointer);
    [QGLNativeAPI("glGetVertexAttribPointerv")] internal static delegate* unmanaged<uint, uint, void**, void> _glGetVertexAttribPointerv = null;
    
    public static void glHint(uint target, uint mode) => _glHint(target, mode);
    [QGLNativeAPI("glHint")] internal static delegate* unmanaged<uint, uint, void> _glHint = null;
    
    public static bool glIsBuffer(uint buffer) => _glIsBuffer(buffer);
    [QGLNativeAPI("glIsBuffer")] internal static delegate* unmanaged<uint, bool> _glIsBuffer = null;
    
    public static bool glIsEnabled(uint cap) => _glIsEnabled(cap);
    [QGLNativeAPI("glIsEnabled")] internal static delegate* unmanaged<uint, bool> _glIsEnabled = null;
    
    public static bool glIsFramebuffer(uint framebuffer) => _glIsFramebuffer(framebuffer);
    [QGLNativeAPI("glIsFramebuffer")] internal static delegate* unmanaged<uint, bool> _glIsFramebuffer = null;
    
    public static bool glIsProgram(uint program) => _glIsProgram(program);
    [QGLNativeAPI("glIsProgram")] internal static delegate* unmanaged<uint, bool> _glIsProgram = null;
    
    public static bool glIsRenderbuffer(uint renderbuffer) => _glIsRenderbuffer(renderbuffer);
    [QGLNativeAPI("glIsRenderbuffer")] internal static delegate* unmanaged<uint, bool> _glIsRenderbuffer = null;
    
    public static bool glIsShader(uint shader) => _glIsShader(shader);
    [QGLNativeAPI("glIsShader")] internal static delegate* unmanaged<uint, bool> _glIsShader = null;
    
    public static bool glIsTexture(uint texture) => _glIsTexture(texture);
    [QGLNativeAPI("glIsTexture")] internal static delegate* unmanaged<uint, bool> _glIsTexture = null;
    
    public static void glLineWidth(float width) => _glLineWidth(width);
    [QGLNativeAPI("glLineWidth")] internal static delegate* unmanaged<float, void> _glLineWidth = null;
    
    public static void glLinkProgram(uint program) => _glLinkProgram(program);
    [QGLNativeAPI("glLinkProgram")] internal static delegate* unmanaged<uint, void> _glLinkProgram = null;
    
    public static void glPixelStorei(uint pname, int param) => _glPixelStorei(pname, param);
    [QGLNativeAPI("glPixelStorei")] internal static delegate* unmanaged<uint, int, void> _glPixelStorei = null;
    
    public static void glPolygonOffset(float factor, float units) => _glPolygonOffset(factor, units);
    [QGLNativeAPI("glPolygonOffset")] internal static delegate* unmanaged<float, float, void> _glPolygonOffset = null;
    
    public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels) => _glReadPixels(x, y, width, height, format, type, pixels);
    [QGLNativeAPI("glReadPixels")] internal static delegate* unmanaged<int, int, int, int, uint, uint, void*, void> _glReadPixels = null;
    
    public static void glReleaseShaderCompiler() => _glReleaseShaderCompiler();
    [QGLNativeAPI("glReleaseShaderCompiler")] internal static delegate* unmanaged<void> _glReleaseShaderCompiler = null;
    
    public static void glRenderbufferStorage(uint target, uint internalformat, int width, int height) => _glRenderbufferStorage(target, internalformat, width, height);
    [QGLNativeAPI("glRenderbufferStorage")] internal static delegate* unmanaged<uint, uint, int, int, void> _glRenderbufferStorage = null;
    
    public static void glSampleCoverage(float value, bool invert) => _glSampleCoverage(value, invert);
    [QGLNativeAPI("glSampleCoverage")] internal static delegate* unmanaged<float, bool, void> _glSampleCoverage = null;
    
    public static void glScissor(int x, int y, int width, int height) => _glScissor(x, y, width, height);
    [QGLNativeAPI("glScissor")] internal static delegate* unmanaged<int, int, int, int, void> _glScissor = null;
    
    public static void glShaderBinary(int count, uint* shaders, uint binaryFormat, void* binary, int length) => _glShaderBinary(count, shaders, binaryFormat, binary, length);
    [QGLNativeAPI("glShaderBinary")] internal static delegate* unmanaged<int, uint*, uint, void*, int, void> _glShaderBinary = null;
    
    public static void glShaderSource(uint shader, int count, byte** @string, int* length) => _glShaderSource(shader, count, @string, length);
    [QGLNativeAPI("glShaderSource")] internal static delegate* unmanaged<uint, int, byte**, int*, void> _glShaderSource = null;
    
    public static void glStencilFunc(uint func, int @ref, uint mask) => _glStencilFunc(func, @ref, mask);
    [QGLNativeAPI("glStencilFunc")] internal static delegate* unmanaged<uint, int, uint, void> _glStencilFunc = null;
    
    public static void glStencilFuncSeparate(uint face, uint func, int @ref, uint mask) => _glStencilFuncSeparate(face, func, @ref, mask);
    [QGLNativeAPI("glStencilFuncSeparate")] internal static delegate* unmanaged<uint, uint, int, uint, void> _glStencilFuncSeparate = null;
    
    public static void glStencilMask(uint mask) => _glStencilMask(mask);
    [QGLNativeAPI("glStencilMask")] internal static delegate* unmanaged<uint, void> _glStencilMask = null;
    
    public static void glStencilMaskSeparate(uint face, uint mask) => _glStencilMaskSeparate(face, mask);
    [QGLNativeAPI("glStencilMaskSeparate")] internal static delegate* unmanaged<uint, uint, void> _glStencilMaskSeparate = null;
    
    public static void glStencilOp(uint fail, uint zfail, uint zpass) => _glStencilOp(fail, zfail, zpass);
    [QGLNativeAPI("glStencilOp")] internal static delegate* unmanaged<uint, uint, uint, void> _glStencilOp = null;
    
    public static void glStencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass) => _glStencilOpSeparate(face, sfail, dpfail, dppass);
    [QGLNativeAPI("glStencilOpSeparate")] internal static delegate* unmanaged<uint, uint, uint, uint, void> _glStencilOpSeparate = null;
    
    public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels) => _glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
    [QGLNativeAPI("glTexImage2D")] internal static delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void> _glTexImage2D = null;
    
    public static void glTexParameterf(uint target, uint pname, float param) => _glTexParameterf(target, pname, param);
    [QGLNativeAPI("glTexParameterf")] internal static delegate* unmanaged<uint, uint, float, void> _glTexParameterf = null;
    
    public static void glTexParameterfv(uint target, uint pname, float* @params) => _glTexParameterfv(target, pname, @params);
    [QGLNativeAPI("glTexParameterfv")] internal static delegate* unmanaged<uint, uint, float*, void> _glTexParameterfv = null;
    
    public static void glTexParameteri(uint target, uint pname, int param) => _glTexParameteri(target, pname, param);
    [QGLNativeAPI("glTexParameteri")] internal static delegate* unmanaged<uint, uint, int, void> _glTexParameteri = null;
    
    public static void glTexParameteriv(uint target, uint pname, int* @params) => _glTexParameteriv(target, pname, @params);
    [QGLNativeAPI("glTexParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glTexParameteriv = null;
    
    public static void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) => _glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
    [QGLNativeAPI("glTexSubImage2D")] internal static delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void> _glTexSubImage2D = null;
    
    public static void glUniform1f(int location, float v0) => _glUniform1f(location, v0);
    [QGLNativeAPI("glUniform1f")] internal static delegate* unmanaged<int, float, void> _glUniform1f = null;
    
    public static void glUniform1fv(int location, int count, float* value) => _glUniform1fv(location, count, value);
    [QGLNativeAPI("glUniform1fv")] internal static delegate* unmanaged<int, int, float*, void> _glUniform1fv = null;
    
    public static void glUniform1i(int location, int v0) => _glUniform1i(location, v0);
    [QGLNativeAPI("glUniform1i")] internal static delegate* unmanaged<int, int, void> _glUniform1i = null;
    
    public static void glUniform1iv(int location, int count, int* value) => _glUniform1iv(location, count, value);
    [QGLNativeAPI("glUniform1iv")] internal static delegate* unmanaged<int, int, int*, void> _glUniform1iv = null;
    
    public static void glUniform2f(int location, float v0, float v1) => _glUniform2f(location, v0, v1);
    [QGLNativeAPI("glUniform2f")] internal static delegate* unmanaged<int, float, float, void> _glUniform2f = null;
    
    public static void glUniform2fv(int location, int count, float* value) => _glUniform2fv(location, count, value);
    [QGLNativeAPI("glUniform2fv")] internal static delegate* unmanaged<int, int, float*, void> _glUniform2fv = null;
    
    public static void glUniform2i(int location, int v0, int v1) => _glUniform2i(location, v0, v1);
    [QGLNativeAPI("glUniform2i")] internal static delegate* unmanaged<int, int, int, void> _glUniform2i = null;
    
    public static void glUniform2iv(int location, int count, int* value) => _glUniform2iv(location, count, value);
    [QGLNativeAPI("glUniform2iv")] internal static delegate* unmanaged<int, int, int*, void> _glUniform2iv = null;
    
    public static void glUniform3f(int location, float v0, float v1, float v2) => _glUniform3f(location, v0, v1, v2);
    [QGLNativeAPI("glUniform3f")] internal static delegate* unmanaged<int, float, float, float, void> _glUniform3f = null;
    
    public static void glUniform3fv(int location, int count, float* value) => _glUniform3fv(location, count, value);
    [QGLNativeAPI("glUniform3fv")] internal static delegate* unmanaged<int, int, float*, void> _glUniform3fv = null;
    
    public static void glUniform3i(int location, int v0, int v1, int v2) => _glUniform3i(location, v0, v1, v2);
    [QGLNativeAPI("glUniform3i")] internal static delegate* unmanaged<int, int, int, int, void> _glUniform3i = null;
    
    public static void glUniform3iv(int location, int count, int* value) => _glUniform3iv(location, count, value);
    [QGLNativeAPI("glUniform3iv")] internal static delegate* unmanaged<int, int, int*, void> _glUniform3iv = null;
    
    public static void glUniform4f(int location, float v0, float v1, float v2, float v3) => _glUniform4f(location, v0, v1, v2, v3);
    [QGLNativeAPI("glUniform4f")] internal static delegate* unmanaged<int, float, float, float, float, void> _glUniform4f = null;
    
    public static void glUniform4fv(int location, int count, float* value) => _glUniform4fv(location, count, value);
    [QGLNativeAPI("glUniform4fv")] internal static delegate* unmanaged<int, int, float*, void> _glUniform4fv = null;
    
    public static void glUniform4i(int location, int v0, int v1, int v2, int v3) => _glUniform4i(location, v0, v1, v2, v3);
    [QGLNativeAPI("glUniform4i")] internal static delegate* unmanaged<int, int, int, int, int, void> _glUniform4i = null;
    
    public static void glUniform4iv(int location, int count, int* value) => _glUniform4iv(location, count, value);
    [QGLNativeAPI("glUniform4iv")] internal static delegate* unmanaged<int, int, int*, void> _glUniform4iv = null;
    
    public static void glUniformMatrix2fv(int location, int count, bool transpose, float* value) => _glUniformMatrix2fv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix2fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix2fv = null;
    
    public static void glUniformMatrix3fv(int location, int count, bool transpose, float* value) => _glUniformMatrix3fv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix3fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix3fv = null;
    
    public static void glUniformMatrix4fv(int location, int count, bool transpose, float* value) => _glUniformMatrix4fv(location, count, transpose, value);
    [QGLNativeAPI("glUniformMatrix4fv")] internal static delegate* unmanaged<int, int, bool, float*, void> _glUniformMatrix4fv = null;
    
    public static void glUseProgram(uint program) => _glUseProgram(program);
    [QGLNativeAPI("glUseProgram")] internal static delegate* unmanaged<uint, void> _glUseProgram = null;
    
    public static void glValidateProgram(uint program) => _glValidateProgram(program);
    [QGLNativeAPI("glValidateProgram")] internal static delegate* unmanaged<uint, void> _glValidateProgram = null;
    
    public static void glVertexAttrib1f(uint index, float x) => _glVertexAttrib1f(index, x);
    [QGLNativeAPI("glVertexAttrib1f")] internal static delegate* unmanaged<uint, float, void> _glVertexAttrib1f = null;
    
    public static void glVertexAttrib1fv(uint index, float* v) => _glVertexAttrib1fv(index, v);
    [QGLNativeAPI("glVertexAttrib1fv")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib1fv = null;
    
    public static void glVertexAttrib2f(uint index, float x, float y) => _glVertexAttrib2f(index, x, y);
    [QGLNativeAPI("glVertexAttrib2f")] internal static delegate* unmanaged<uint, float, float, void> _glVertexAttrib2f = null;
    
    public static void glVertexAttrib2fv(uint index, float* v) => _glVertexAttrib2fv(index, v);
    [QGLNativeAPI("glVertexAttrib2fv")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib2fv = null;
    
    public static void glVertexAttrib3f(uint index, float x, float y, float z) => _glVertexAttrib3f(index, x, y, z);
    [QGLNativeAPI("glVertexAttrib3f")] internal static delegate* unmanaged<uint, float, float, float, void> _glVertexAttrib3f = null;
    
    public static void glVertexAttrib3fv(uint index, float* v) => _glVertexAttrib3fv(index, v);
    [QGLNativeAPI("glVertexAttrib3fv")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib3fv = null;
    
    public static void glVertexAttrib4f(uint index, float x, float y, float z, float w) => _glVertexAttrib4f(index, x, y, z, w);
    [QGLNativeAPI("glVertexAttrib4f")] internal static delegate* unmanaged<uint, float, float, float, float, void> _glVertexAttrib4f = null;
    
    public static void glVertexAttrib4fv(uint index, float* v) => _glVertexAttrib4fv(index, v);
    [QGLNativeAPI("glVertexAttrib4fv")] internal static delegate* unmanaged<uint, float*, void> _glVertexAttrib4fv = null;
    
    public static void glVertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer) => _glVertexAttribPointer(index, size, type, normalized, stride, pointer);
    [QGLNativeAPI("glVertexAttribPointer")] internal static delegate* unmanaged<uint, int, uint, bool, int, void*, void> _glVertexAttribPointer = null;
    
    public static void glViewport(int x, int y, int width, int height) => _glViewport(x, y, width, height);
    [QGLNativeAPI("glViewport")] internal static delegate* unmanaged<int, int, int, int, void> _glViewport = null;
     #endregion
}
