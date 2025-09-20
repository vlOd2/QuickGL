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

// Bindings generated at 2025-09-20 18:58:19.782800
namespace QuickGLNS.Bindings;

public static unsafe class GLESCM10
{
    #region Enums
    public const int GL_VERSION_ES_CL_1_0 = 0x1;
    public const int GL_VERSION_ES_CM_1_1 = 0x1;
    public const int GL_VERSION_ES_CL_1_1 = 0x1;
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
    public const int GL_NEVER = 0x200;
    public const int GL_LESS = 0x201;
    public const int GL_EQUAL = 0x202;
    public const int GL_LEQUAL = 0x203;
    public const int GL_GREATER = 0x204;
    public const int GL_NOTEQUAL = 0x205;
    public const int GL_GEQUAL = 0x206;
    public const int GL_ALWAYS = 0x207;
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
    public const int GL_CLIP_PLANE0 = 0x3000;
    public const int GL_CLIP_PLANE1 = 0x3001;
    public const int GL_CLIP_PLANE2 = 0x3002;
    public const int GL_CLIP_PLANE3 = 0x3003;
    public const int GL_CLIP_PLANE4 = 0x3004;
    public const int GL_CLIP_PLANE5 = 0x3005;
    public const int GL_FRONT = 0x404;
    public const int GL_BACK = 0x405;
    public const int GL_FRONT_AND_BACK = 0x408;
    public const int GL_FOG = 0xB60;
    public const int GL_LIGHTING = 0xB50;
    public const int GL_TEXTURE_2D = 0xDE1;
    public const int GL_CULL_FACE = 0xB44;
    public const int GL_ALPHA_TEST = 0xBC0;
    public const int GL_BLEND = 0xBE2;
    public const int GL_COLOR_LOGIC_OP = 0xBF2;
    public const int GL_DITHER = 0xBD0;
    public const int GL_STENCIL_TEST = 0xB90;
    public const int GL_DEPTH_TEST = 0xB71;
    public const int GL_POINT_SMOOTH = 0xB10;
    public const int GL_LINE_SMOOTH = 0xB20;
    public const int GL_SCISSOR_TEST = 0xC11;
    public const int GL_COLOR_MATERIAL = 0xB57;
    public const int GL_NORMALIZE = 0xBA1;
    public const int GL_RESCALE_NORMAL = 0x803A;
    public const int GL_VERTEX_ARRAY = 0x8074;
    public const int GL_NORMAL_ARRAY = 0x8075;
    public const int GL_COLOR_ARRAY = 0x8076;
    public const int GL_TEXTURE_COORD_ARRAY = 0x8078;
    public const int GL_MULTISAMPLE = 0x809D;
    public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
    public const int GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
    public const int GL_SAMPLE_COVERAGE = 0x80A0;
    public const int GL_NO_ERROR = 0x0;
    public const int GL_INVALID_ENUM = 0x500;
    public const int GL_INVALID_VALUE = 0x501;
    public const int GL_INVALID_OPERATION = 0x502;
    public const int GL_STACK_OVERFLOW = 0x503;
    public const int GL_STACK_UNDERFLOW = 0x504;
    public const int GL_OUT_OF_MEMORY = 0x505;
    public const int GL_EXP = 0x800;
    public const int GL_EXP2 = 0x801;
    public const int GL_FOG_DENSITY = 0xB62;
    public const int GL_FOG_START = 0xB63;
    public const int GL_FOG_END = 0xB64;
    public const int GL_FOG_MODE = 0xB65;
    public const int GL_FOG_COLOR = 0xB66;
    public const int GL_CW = 0x900;
    public const int GL_CCW = 0x901;
    public const int GL_CURRENT_COLOR = 0xB00;
    public const int GL_CURRENT_NORMAL = 0xB02;
    public const int GL_CURRENT_TEXTURE_COORDS = 0xB03;
    public const int GL_POINT_SIZE = 0xB11;
    public const int GL_POINT_SIZE_MIN = 0x8126;
    public const int GL_POINT_SIZE_MAX = 0x8127;
    public const int GL_POINT_FADE_THRESHOLD_SIZE = 0x8128;
    public const int GL_POINT_DISTANCE_ATTENUATION = 0x8129;
    public const int GL_SMOOTH_POINT_SIZE_RANGE = 0xB12;
    public const int GL_LINE_WIDTH = 0xB21;
    public const int GL_SMOOTH_LINE_WIDTH_RANGE = 0xB22;
    public const int GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
    public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
    public const int GL_CULL_FACE_MODE = 0xB45;
    public const int GL_FRONT_FACE = 0xB46;
    public const int GL_SHADE_MODEL = 0xB54;
    public const int GL_DEPTH_RANGE = 0xB70;
    public const int GL_DEPTH_WRITEMASK = 0xB72;
    public const int GL_DEPTH_CLEAR_VALUE = 0xB73;
    public const int GL_DEPTH_FUNC = 0xB74;
    public const int GL_STENCIL_CLEAR_VALUE = 0xB91;
    public const int GL_STENCIL_FUNC = 0xB92;
    public const int GL_STENCIL_VALUE_MASK = 0xB93;
    public const int GL_STENCIL_FAIL = 0xB94;
    public const int GL_STENCIL_PASS_DEPTH_FAIL = 0xB95;
    public const int GL_STENCIL_PASS_DEPTH_PASS = 0xB96;
    public const int GL_STENCIL_REF = 0xB97;
    public const int GL_STENCIL_WRITEMASK = 0xB98;
    public const int GL_MATRIX_MODE = 0xBA0;
    public const int GL_VIEWPORT = 0xBA2;
    public const int GL_MODELVIEW_STACK_DEPTH = 0xBA3;
    public const int GL_PROJECTION_STACK_DEPTH = 0xBA4;
    public const int GL_TEXTURE_STACK_DEPTH = 0xBA5;
    public const int GL_MODELVIEW_MATRIX = 0xBA6;
    public const int GL_PROJECTION_MATRIX = 0xBA7;
    public const int GL_TEXTURE_MATRIX = 0xBA8;
    public const int GL_ALPHA_TEST_FUNC = 0xBC1;
    public const int GL_ALPHA_TEST_REF = 0xBC2;
    public const int GL_BLEND_DST = 0xBE0;
    public const int GL_BLEND_SRC = 0xBE1;
    public const int GL_LOGIC_OP_MODE = 0xBF0;
    public const int GL_SCISSOR_BOX = 0xC10;
    public const int GL_COLOR_CLEAR_VALUE = 0xC22;
    public const int GL_COLOR_WRITEMASK = 0xC23;
    public const int GL_MAX_LIGHTS = 0xD31;
    public const int GL_MAX_CLIP_PLANES = 0xD32;
    public const int GL_MAX_TEXTURE_SIZE = 0xD33;
    public const int GL_MAX_MODELVIEW_STACK_DEPTH = 0xD36;
    public const int GL_MAX_PROJECTION_STACK_DEPTH = 0xD38;
    public const int GL_MAX_TEXTURE_STACK_DEPTH = 0xD39;
    public const int GL_MAX_VIEWPORT_DIMS = 0xD3A;
    public const int GL_MAX_TEXTURE_UNITS = 0x84E2;
    public const int GL_SUBPIXEL_BITS = 0xD50;
    public const int GL_RED_BITS = 0xD52;
    public const int GL_GREEN_BITS = 0xD53;
    public const int GL_BLUE_BITS = 0xD54;
    public const int GL_ALPHA_BITS = 0xD55;
    public const int GL_DEPTH_BITS = 0xD56;
    public const int GL_STENCIL_BITS = 0xD57;
    public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;
    public const int GL_POLYGON_OFFSET_FILL = 0x8037;
    public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;
    public const int GL_TEXTURE_BINDING_2D = 0x8069;
    public const int GL_VERTEX_ARRAY_SIZE = 0x807A;
    public const int GL_VERTEX_ARRAY_TYPE = 0x807B;
    public const int GL_VERTEX_ARRAY_STRIDE = 0x807C;
    public const int GL_NORMAL_ARRAY_TYPE = 0x807E;
    public const int GL_NORMAL_ARRAY_STRIDE = 0x807F;
    public const int GL_COLOR_ARRAY_SIZE = 0x8081;
    public const int GL_COLOR_ARRAY_TYPE = 0x8082;
    public const int GL_COLOR_ARRAY_STRIDE = 0x8083;
    public const int GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;
    public const int GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;
    public const int GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
    public const int GL_VERTEX_ARRAY_POINTER = 0x808E;
    public const int GL_NORMAL_ARRAY_POINTER = 0x808F;
    public const int GL_COLOR_ARRAY_POINTER = 0x8090;
    public const int GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;
    public const int GL_SAMPLE_BUFFERS = 0x80A8;
    public const int GL_SAMPLES = 0x80A9;
    public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
    public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
    public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
    public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
    public const int GL_DONT_CARE = 0x1100;
    public const int GL_FASTEST = 0x1101;
    public const int GL_NICEST = 0x1102;
    public const int GL_PERSPECTIVE_CORRECTION_HINT = 0xC50;
    public const int GL_POINT_SMOOTH_HINT = 0xC51;
    public const int GL_LINE_SMOOTH_HINT = 0xC52;
    public const int GL_FOG_HINT = 0xC54;
    public const int GL_GENERATE_MIPMAP_HINT = 0x8192;
    public const int GL_LIGHT_MODEL_AMBIENT = 0xB53;
    public const int GL_LIGHT_MODEL_TWO_SIDE = 0xB52;
    public const int GL_AMBIENT = 0x1200;
    public const int GL_DIFFUSE = 0x1201;
    public const int GL_SPECULAR = 0x1202;
    public const int GL_POSITION = 0x1203;
    public const int GL_SPOT_DIRECTION = 0x1204;
    public const int GL_SPOT_EXPONENT = 0x1205;
    public const int GL_SPOT_CUTOFF = 0x1206;
    public const int GL_CONSTANT_ATTENUATION = 0x1207;
    public const int GL_LINEAR_ATTENUATION = 0x1208;
    public const int GL_QUADRATIC_ATTENUATION = 0x1209;
    public const int GL_BYTE = 0x1400;
    public const int GL_UNSIGNED_BYTE = 0x1401;
    public const int GL_SHORT = 0x1402;
    public const int GL_UNSIGNED_SHORT = 0x1403;
    public const int GL_FLOAT = 0x1406;
    public const int GL_FIXED = 0x140C;
    public const int GL_CLEAR = 0x1500;
    public const int GL_AND = 0x1501;
    public const int GL_AND_REVERSE = 0x1502;
    public const int GL_COPY = 0x1503;
    public const int GL_AND_INVERTED = 0x1504;
    public const int GL_NOOP = 0x1505;
    public const int GL_XOR = 0x1506;
    public const int GL_OR = 0x1507;
    public const int GL_NOR = 0x1508;
    public const int GL_EQUIV = 0x1509;
    public const int GL_INVERT = 0x150A;
    public const int GL_OR_REVERSE = 0x150B;
    public const int GL_COPY_INVERTED = 0x150C;
    public const int GL_OR_INVERTED = 0x150D;
    public const int GL_NAND = 0x150E;
    public const int GL_SET = 0x150F;
    public const int GL_EMISSION = 0x1600;
    public const int GL_SHININESS = 0x1601;
    public const int GL_AMBIENT_AND_DIFFUSE = 0x1602;
    public const int GL_MODELVIEW = 0x1700;
    public const int GL_PROJECTION = 0x1701;
    public const int GL_TEXTURE = 0x1702;
    public const int GL_ALPHA = 0x1906;
    public const int GL_RGB = 0x1907;
    public const int GL_RGBA = 0x1908;
    public const int GL_LUMINANCE = 0x1909;
    public const int GL_LUMINANCE_ALPHA = 0x190A;
    public const int GL_UNPACK_ALIGNMENT = 0xCF5;
    public const int GL_PACK_ALIGNMENT = 0xD05;
    public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
    public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
    public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
    public const int GL_FLAT = 0x1D00;
    public const int GL_SMOOTH = 0x1D01;
    public const int GL_KEEP = 0x1E00;
    public const int GL_REPLACE = 0x1E01;
    public const int GL_INCR = 0x1E02;
    public const int GL_DECR = 0x1E03;
    public const int GL_VENDOR = 0x1F00;
    public const int GL_RENDERER = 0x1F01;
    public const int GL_VERSION = 0x1F02;
    public const int GL_EXTENSIONS = 0x1F03;
    public const int GL_MODULATE = 0x2100;
    public const int GL_DECAL = 0x2101;
    public const int GL_ADD = 0x104;
    public const int GL_TEXTURE_ENV_MODE = 0x2200;
    public const int GL_TEXTURE_ENV_COLOR = 0x2201;
    public const int GL_TEXTURE_ENV = 0x2300;
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
    public const int GL_GENERATE_MIPMAP = 0x8191;
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
    public const int GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
    public const int GL_REPEAT = 0x2901;
    public const int GL_CLAMP_TO_EDGE = 0x812F;
    public const int GL_LIGHT0 = 0x4000;
    public const int GL_LIGHT1 = 0x4001;
    public const int GL_LIGHT2 = 0x4002;
    public const int GL_LIGHT3 = 0x4003;
    public const int GL_LIGHT4 = 0x4004;
    public const int GL_LIGHT5 = 0x4005;
    public const int GL_LIGHT6 = 0x4006;
    public const int GL_LIGHT7 = 0x4007;
    public const int GL_ARRAY_BUFFER = 0x8892;
    public const int GL_ELEMENT_ARRAY_BUFFER = 0x8893;
    public const int GL_ARRAY_BUFFER_BINDING = 0x8894;
    public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
    public const int GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896;
    public const int GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897;
    public const int GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898;
    public const int GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;
    public const int GL_STATIC_DRAW = 0x88E4;
    public const int GL_DYNAMIC_DRAW = 0x88E8;
    public const int GL_BUFFER_SIZE = 0x8764;
    public const int GL_BUFFER_USAGE = 0x8765;
    public const int GL_SUBTRACT = 0x84E7;
    public const int GL_COMBINE = 0x8570;
    public const int GL_COMBINE_RGB = 0x8571;
    public const int GL_COMBINE_ALPHA = 0x8572;
    public const int GL_RGB_SCALE = 0x8573;
    public const int GL_ADD_SIGNED = 0x8574;
    public const int GL_INTERPOLATE = 0x8575;
    public const int GL_CONSTANT = 0x8576;
    public const int GL_PRIMARY_COLOR = 0x8577;
    public const int GL_PREVIOUS = 0x8578;
    public const int GL_OPERAND0_RGB = 0x8590;
    public const int GL_OPERAND1_RGB = 0x8591;
    public const int GL_OPERAND2_RGB = 0x8592;
    public const int GL_OPERAND0_ALPHA = 0x8598;
    public const int GL_OPERAND1_ALPHA = 0x8599;
    public const int GL_OPERAND2_ALPHA = 0x859A;
    public const int GL_ALPHA_SCALE = 0xD1C;
    public const int GL_SRC0_RGB = 0x8580;
    public const int GL_SRC1_RGB = 0x8581;
    public const int GL_SRC2_RGB = 0x8582;
    public const int GL_SRC0_ALPHA = 0x8588;
    public const int GL_SRC1_ALPHA = 0x8589;
    public const int GL_SRC2_ALPHA = 0x858A;
    public const int GL_DOT3_RGB = 0x86AE;
    public const int GL_DOT3_RGBA = 0x86AF;
    #endregion
    
    #region Commands
    public static void glAlphaFunc(uint func, float @ref) { QGLFeature.VerifyFunc((nint)_glAlphaFunc); _glAlphaFunc(func, @ref); }
    internal static delegate* unmanaged<uint, float, void> _glAlphaFunc = null;
    
    public static void glClearColor(float red, float green, float blue, float alpha) { QGLFeature.VerifyFunc((nint)_glClearColor); _glClearColor(red, green, blue, alpha); }
    internal static delegate* unmanaged<float, float, float, float, void> _glClearColor = null;
    
    public static void glClearDepthf(float d) { QGLFeature.VerifyFunc((nint)_glClearDepthf); _glClearDepthf(d); }
    internal static delegate* unmanaged<float, void> _glClearDepthf = null;
    
    public static void glClipPlanef(uint p, float* eqn) { QGLFeature.VerifyFunc((nint)_glClipPlanef); _glClipPlanef(p, eqn); }
    internal static delegate* unmanaged<uint, float*, void> _glClipPlanef = null;
    
    public static void glColor4f(float red, float green, float blue, float alpha) { QGLFeature.VerifyFunc((nint)_glColor4f); _glColor4f(red, green, blue, alpha); }
    internal static delegate* unmanaged<float, float, float, float, void> _glColor4f = null;
    
    public static void glDepthRangef(float n, float f) { QGLFeature.VerifyFunc((nint)_glDepthRangef); _glDepthRangef(n, f); }
    internal static delegate* unmanaged<float, float, void> _glDepthRangef = null;
    
    public static void glFogf(uint pname, float param) { QGLFeature.VerifyFunc((nint)_glFogf); _glFogf(pname, param); }
    internal static delegate* unmanaged<uint, float, void> _glFogf = null;
    
    public static void glFogfv(uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glFogfv); _glFogfv(pname, @params); }
    internal static delegate* unmanaged<uint, float*, void> _glFogfv = null;
    
    public static void glFrustumf(float l, float r, float b, float t, float n, float f) { QGLFeature.VerifyFunc((nint)_glFrustumf); _glFrustumf(l, r, b, t, n, f); }
    internal static delegate* unmanaged<float, float, float, float, float, float, void> _glFrustumf = null;
    
    public static void glGetClipPlanef(uint plane, float* equation) { QGLFeature.VerifyFunc((nint)_glGetClipPlanef); _glGetClipPlanef(plane, equation); }
    internal static delegate* unmanaged<uint, float*, void> _glGetClipPlanef = null;
    
    public static void glGetFloatv(uint pname, float* data) { QGLFeature.VerifyFunc((nint)_glGetFloatv); _glGetFloatv(pname, data); }
    internal static delegate* unmanaged<uint, float*, void> _glGetFloatv = null;
    
    public static void glGetLightfv(uint light, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetLightfv); _glGetLightfv(light, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetLightfv = null;
    
    public static void glGetMaterialfv(uint face, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetMaterialfv); _glGetMaterialfv(face, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetMaterialfv = null;
    
    public static void glGetTexEnvfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetTexEnvfv); _glGetTexEnvfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetTexEnvfv = null;
    
    public static void glGetTexParameterfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetTexParameterfv); _glGetTexParameterfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetTexParameterfv = null;
    
    public static void glLightModelf(uint pname, float param) { QGLFeature.VerifyFunc((nint)_glLightModelf); _glLightModelf(pname, param); }
    internal static delegate* unmanaged<uint, float, void> _glLightModelf = null;
    
    public static void glLightModelfv(uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glLightModelfv); _glLightModelfv(pname, @params); }
    internal static delegate* unmanaged<uint, float*, void> _glLightModelfv = null;
    
    public static void glLightf(uint light, uint pname, float param) { QGLFeature.VerifyFunc((nint)_glLightf); _glLightf(light, pname, param); }
    internal static delegate* unmanaged<uint, uint, float, void> _glLightf = null;
    
    public static void glLightfv(uint light, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glLightfv); _glLightfv(light, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glLightfv = null;
    
    public static void glLineWidth(float width) { QGLFeature.VerifyFunc((nint)_glLineWidth); _glLineWidth(width); }
    internal static delegate* unmanaged<float, void> _glLineWidth = null;
    
    public static void glLoadMatrixf(float* m) { QGLFeature.VerifyFunc((nint)_glLoadMatrixf); _glLoadMatrixf(m); }
    internal static delegate* unmanaged<float*, void> _glLoadMatrixf = null;
    
    public static void glMaterialf(uint face, uint pname, float param) { QGLFeature.VerifyFunc((nint)_glMaterialf); _glMaterialf(face, pname, param); }
    internal static delegate* unmanaged<uint, uint, float, void> _glMaterialf = null;
    
    public static void glMaterialfv(uint face, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glMaterialfv); _glMaterialfv(face, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glMaterialfv = null;
    
    public static void glMultMatrixf(float* m) { QGLFeature.VerifyFunc((nint)_glMultMatrixf); _glMultMatrixf(m); }
    internal static delegate* unmanaged<float*, void> _glMultMatrixf = null;
    
    public static void glMultiTexCoord4f(uint target, float s, float t, float r, float q) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord4f); _glMultiTexCoord4f(target, s, t, r, q); }
    internal static delegate* unmanaged<uint, float, float, float, float, void> _glMultiTexCoord4f = null;
    
    public static void glNormal3f(float nx, float ny, float nz) { QGLFeature.VerifyFunc((nint)_glNormal3f); _glNormal3f(nx, ny, nz); }
    internal static delegate* unmanaged<float, float, float, void> _glNormal3f = null;
    
    public static void glOrthof(float l, float r, float b, float t, float n, float f) { QGLFeature.VerifyFunc((nint)_glOrthof); _glOrthof(l, r, b, t, n, f); }
    internal static delegate* unmanaged<float, float, float, float, float, float, void> _glOrthof = null;
    
    public static void glPointParameterf(uint pname, float param) { QGLFeature.VerifyFunc((nint)_glPointParameterf); _glPointParameterf(pname, param); }
    internal static delegate* unmanaged<uint, float, void> _glPointParameterf = null;
    
    public static void glPointParameterfv(uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glPointParameterfv); _glPointParameterfv(pname, @params); }
    internal static delegate* unmanaged<uint, float*, void> _glPointParameterfv = null;
    
    public static void glPointSize(float size) { QGLFeature.VerifyFunc((nint)_glPointSize); _glPointSize(size); }
    internal static delegate* unmanaged<float, void> _glPointSize = null;
    
    public static void glPolygonOffset(float factor, float units) { QGLFeature.VerifyFunc((nint)_glPolygonOffset); _glPolygonOffset(factor, units); }
    internal static delegate* unmanaged<float, float, void> _glPolygonOffset = null;
    
    public static void glRotatef(float angle, float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glRotatef); _glRotatef(angle, x, y, z); }
    internal static delegate* unmanaged<float, float, float, float, void> _glRotatef = null;
    
    public static void glScalef(float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glScalef); _glScalef(x, y, z); }
    internal static delegate* unmanaged<float, float, float, void> _glScalef = null;
    
    public static void glTexEnvf(uint target, uint pname, float param) { QGLFeature.VerifyFunc((nint)_glTexEnvf); _glTexEnvf(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, float, void> _glTexEnvf = null;
    
    public static void glTexEnvfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glTexEnvfv); _glTexEnvfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glTexEnvfv = null;
    
    public static void glTexParameterf(uint target, uint pname, float param) { QGLFeature.VerifyFunc((nint)_glTexParameterf); _glTexParameterf(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, float, void> _glTexParameterf = null;
    
    public static void glTexParameterfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glTexParameterfv); _glTexParameterfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glTexParameterfv = null;
    
    public static void glTranslatef(float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glTranslatef); _glTranslatef(x, y, z); }
    internal static delegate* unmanaged<float, float, float, void> _glTranslatef = null;
    
    public static void glActiveTexture(uint texture) { QGLFeature.VerifyFunc((nint)_glActiveTexture); _glActiveTexture(texture); }
    internal static delegate* unmanaged<uint, void> _glActiveTexture = null;
    
    public static void glAlphaFuncx(uint func, int @ref) { QGLFeature.VerifyFunc((nint)_glAlphaFuncx); _glAlphaFuncx(func, @ref); }
    internal static delegate* unmanaged<uint, int, void> _glAlphaFuncx = null;
    
    public static void glBindBuffer(uint target, uint buffer) { QGLFeature.VerifyFunc((nint)_glBindBuffer); _glBindBuffer(target, buffer); }
    internal static delegate* unmanaged<uint, uint, void> _glBindBuffer = null;
    
    public static void glBindTexture(uint target, uint texture) { QGLFeature.VerifyFunc((nint)_glBindTexture); _glBindTexture(target, texture); }
    internal static delegate* unmanaged<uint, uint, void> _glBindTexture = null;
    
    public static void glBlendFunc(uint sfactor, uint dfactor) { QGLFeature.VerifyFunc((nint)_glBlendFunc); _glBlendFunc(sfactor, dfactor); }
    internal static delegate* unmanaged<uint, uint, void> _glBlendFunc = null;
    
    public static void glBufferData(uint target, nint size, void* data, uint usage) { QGLFeature.VerifyFunc((nint)_glBufferData); _glBufferData(target, size, data, usage); }
    internal static delegate* unmanaged<uint, nint, void*, uint, void> _glBufferData = null;
    
    public static void glBufferSubData(uint target, nint offset, nint size, void* data) { QGLFeature.VerifyFunc((nint)_glBufferSubData); _glBufferSubData(target, offset, size, data); }
    internal static delegate* unmanaged<uint, nint, nint, void*, void> _glBufferSubData = null;
    
    public static void glClear(uint mask) { QGLFeature.VerifyFunc((nint)_glClear); _glClear(mask); }
    internal static delegate* unmanaged<uint, void> _glClear = null;
    
    public static void glClearColorx(int red, int green, int blue, int alpha) { QGLFeature.VerifyFunc((nint)_glClearColorx); _glClearColorx(red, green, blue, alpha); }
    internal static delegate* unmanaged<int, int, int, int, void> _glClearColorx = null;
    
    public static void glClearDepthx(int depth) { QGLFeature.VerifyFunc((nint)_glClearDepthx); _glClearDepthx(depth); }
    internal static delegate* unmanaged<int, void> _glClearDepthx = null;
    
    public static void glClearStencil(int s) { QGLFeature.VerifyFunc((nint)_glClearStencil); _glClearStencil(s); }
    internal static delegate* unmanaged<int, void> _glClearStencil = null;
    
    public static void glClientActiveTexture(uint texture) { QGLFeature.VerifyFunc((nint)_glClientActiveTexture); _glClientActiveTexture(texture); }
    internal static delegate* unmanaged<uint, void> _glClientActiveTexture = null;
    
    public static void glClipPlanex(uint plane, int* equation) { QGLFeature.VerifyFunc((nint)_glClipPlanex); _glClipPlanex(plane, equation); }
    internal static delegate* unmanaged<uint, int*, void> _glClipPlanex = null;
    
    public static void glColor4ub(byte red, byte green, byte blue, byte alpha) { QGLFeature.VerifyFunc((nint)_glColor4ub); _glColor4ub(red, green, blue, alpha); }
    internal static delegate* unmanaged<byte, byte, byte, byte, void> _glColor4ub = null;
    
    public static void glColor4x(int red, int green, int blue, int alpha) { QGLFeature.VerifyFunc((nint)_glColor4x); _glColor4x(red, green, blue, alpha); }
    internal static delegate* unmanaged<int, int, int, int, void> _glColor4x = null;
    
    public static void glColorMask(bool red, bool green, bool blue, bool alpha) { QGLFeature.VerifyFunc((nint)_glColorMask); _glColorMask(red, green, blue, alpha); }
    internal static delegate* unmanaged<bool, bool, bool, bool, void> _glColorMask = null;
    
    public static void glColorPointer(int size, uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glColorPointer); _glColorPointer(size, type, stride, pointer); }
    internal static delegate* unmanaged<int, uint, int, void*, void> _glColorPointer = null;
    
    public static void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data) { QGLFeature.VerifyFunc((nint)_glCompressedTexImage2D); _glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data); }
    internal static delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void> _glCompressedTexImage2D = null;
    
    public static void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data) { QGLFeature.VerifyFunc((nint)_glCompressedTexSubImage2D); _glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void> _glCompressedTexSubImage2D = null;
    
    public static void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border) { QGLFeature.VerifyFunc((nint)_glCopyTexImage2D); _glCopyTexImage2D(target, level, internalformat, x, y, width, height, border); }
    internal static delegate* unmanaged<uint, int, uint, int, int, int, int, int, void> _glCopyTexImage2D = null;
    
    public static void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) { QGLFeature.VerifyFunc((nint)_glCopyTexSubImage2D); _glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, void> _glCopyTexSubImage2D = null;
    
    public static void glCullFace(uint mode) { QGLFeature.VerifyFunc((nint)_glCullFace); _glCullFace(mode); }
    internal static delegate* unmanaged<uint, void> _glCullFace = null;
    
    public static void glDeleteBuffers(int n, uint* buffers) { QGLFeature.VerifyFunc((nint)_glDeleteBuffers); _glDeleteBuffers(n, buffers); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteBuffers = null;
    
    public static void glDeleteTextures(int n, uint* textures) { QGLFeature.VerifyFunc((nint)_glDeleteTextures); _glDeleteTextures(n, textures); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteTextures = null;
    
    public static void glDepthFunc(uint func) { QGLFeature.VerifyFunc((nint)_glDepthFunc); _glDepthFunc(func); }
    internal static delegate* unmanaged<uint, void> _glDepthFunc = null;
    
    public static void glDepthMask(bool flag) { QGLFeature.VerifyFunc((nint)_glDepthMask); _glDepthMask(flag); }
    internal static delegate* unmanaged<bool, void> _glDepthMask = null;
    
    public static void glDepthRangex(int n, int f) { QGLFeature.VerifyFunc((nint)_glDepthRangex); _glDepthRangex(n, f); }
    internal static delegate* unmanaged<int, int, void> _glDepthRangex = null;
    
    public static void glDisable(uint cap) { QGLFeature.VerifyFunc((nint)_glDisable); _glDisable(cap); }
    internal static delegate* unmanaged<uint, void> _glDisable = null;
    
    public static void glDisableClientState(uint array) { QGLFeature.VerifyFunc((nint)_glDisableClientState); _glDisableClientState(array); }
    internal static delegate* unmanaged<uint, void> _glDisableClientState = null;
    
    public static void glDrawArrays(uint mode, int first, int count) { QGLFeature.VerifyFunc((nint)_glDrawArrays); _glDrawArrays(mode, first, count); }
    internal static delegate* unmanaged<uint, int, int, void> _glDrawArrays = null;
    
    public static void glDrawElements(uint mode, int count, uint type, void* indices) { QGLFeature.VerifyFunc((nint)_glDrawElements); _glDrawElements(mode, count, type, indices); }
    internal static delegate* unmanaged<uint, int, uint, void*, void> _glDrawElements = null;
    
    public static void glEnable(uint cap) { QGLFeature.VerifyFunc((nint)_glEnable); _glEnable(cap); }
    internal static delegate* unmanaged<uint, void> _glEnable = null;
    
    public static void glEnableClientState(uint array) { QGLFeature.VerifyFunc((nint)_glEnableClientState); _glEnableClientState(array); }
    internal static delegate* unmanaged<uint, void> _glEnableClientState = null;
    
    public static void glFinish() { QGLFeature.VerifyFunc((nint)_glFinish); _glFinish(); }
    internal static delegate* unmanaged<void> _glFinish = null;
    
    public static void glFlush() { QGLFeature.VerifyFunc((nint)_glFlush); _glFlush(); }
    internal static delegate* unmanaged<void> _glFlush = null;
    
    public static void glFogx(uint pname, int param) { QGLFeature.VerifyFunc((nint)_glFogx); _glFogx(pname, param); }
    internal static delegate* unmanaged<uint, int, void> _glFogx = null;
    
    public static void glFogxv(uint pname, int* param) { QGLFeature.VerifyFunc((nint)_glFogxv); _glFogxv(pname, param); }
    internal static delegate* unmanaged<uint, int*, void> _glFogxv = null;
    
    public static void glFrontFace(uint mode) { QGLFeature.VerifyFunc((nint)_glFrontFace); _glFrontFace(mode); }
    internal static delegate* unmanaged<uint, void> _glFrontFace = null;
    
    public static void glFrustumx(int l, int r, int b, int t, int n, int f) { QGLFeature.VerifyFunc((nint)_glFrustumx); _glFrustumx(l, r, b, t, n, f); }
    internal static delegate* unmanaged<int, int, int, int, int, int, void> _glFrustumx = null;
    
    public static void glGetBooleanv(uint pname, bool* data) { QGLFeature.VerifyFunc((nint)_glGetBooleanv); _glGetBooleanv(pname, data); }
    internal static delegate* unmanaged<uint, bool*, void> _glGetBooleanv = null;
    
    public static void glGetBufferParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetBufferParameteriv); _glGetBufferParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetBufferParameteriv = null;
    
    public static void glGetClipPlanex(uint plane, int* equation) { QGLFeature.VerifyFunc((nint)_glGetClipPlanex); _glGetClipPlanex(plane, equation); }
    internal static delegate* unmanaged<uint, int*, void> _glGetClipPlanex = null;
    
    public static void glGenBuffers(int n, uint* buffers) { QGLFeature.VerifyFunc((nint)_glGenBuffers); _glGenBuffers(n, buffers); }
    internal static delegate* unmanaged<int, uint*, void> _glGenBuffers = null;
    
    public static void glGenTextures(int n, uint* textures) { QGLFeature.VerifyFunc((nint)_glGenTextures); _glGenTextures(n, textures); }
    internal static delegate* unmanaged<int, uint*, void> _glGenTextures = null;
    
    public static uint glGetError() { QGLFeature.VerifyFunc((nint)_glGetError); return _glGetError(); }
    internal static delegate* unmanaged<uint> _glGetError = null;
    
    public static void glGetFixedv(uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetFixedv); _glGetFixedv(pname, @params); }
    internal static delegate* unmanaged<uint, int*, void> _glGetFixedv = null;
    
    public static void glGetIntegerv(uint pname, int* data) { QGLFeature.VerifyFunc((nint)_glGetIntegerv); _glGetIntegerv(pname, data); }
    internal static delegate* unmanaged<uint, int*, void> _glGetIntegerv = null;
    
    public static void glGetLightxv(uint light, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetLightxv); _glGetLightxv(light, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetLightxv = null;
    
    public static void glGetMaterialxv(uint face, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetMaterialxv); _glGetMaterialxv(face, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetMaterialxv = null;
    
    public static void glGetPointerv(uint pname, void** @params) { QGLFeature.VerifyFunc((nint)_glGetPointerv); _glGetPointerv(pname, @params); }
    internal static delegate* unmanaged<uint, void**, void> _glGetPointerv = null;
    
    public static byte* glGetString(uint name) { QGLFeature.VerifyFunc((nint)_glGetString); return _glGetString(name); }
    internal static delegate* unmanaged<uint, byte*> _glGetString = null;
    
    public static void glGetTexEnviv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetTexEnviv); _glGetTexEnviv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexEnviv = null;
    
    public static void glGetTexEnvxv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetTexEnvxv); _glGetTexEnvxv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexEnvxv = null;
    
    public static void glGetTexParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetTexParameteriv); _glGetTexParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexParameteriv = null;
    
    public static void glGetTexParameterxv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetTexParameterxv); _glGetTexParameterxv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexParameterxv = null;
    
    public static void glHint(uint target, uint mode) { QGLFeature.VerifyFunc((nint)_glHint); _glHint(target, mode); }
    internal static delegate* unmanaged<uint, uint, void> _glHint = null;
    
    public static bool glIsBuffer(uint buffer) { QGLFeature.VerifyFunc((nint)_glIsBuffer); return _glIsBuffer(buffer); }
    internal static delegate* unmanaged<uint, bool> _glIsBuffer = null;
    
    public static bool glIsEnabled(uint cap) { QGLFeature.VerifyFunc((nint)_glIsEnabled); return _glIsEnabled(cap); }
    internal static delegate* unmanaged<uint, bool> _glIsEnabled = null;
    
    public static bool glIsTexture(uint texture) { QGLFeature.VerifyFunc((nint)_glIsTexture); return _glIsTexture(texture); }
    internal static delegate* unmanaged<uint, bool> _glIsTexture = null;
    
    public static void glLightModelx(uint pname, int param) { QGLFeature.VerifyFunc((nint)_glLightModelx); _glLightModelx(pname, param); }
    internal static delegate* unmanaged<uint, int, void> _glLightModelx = null;
    
    public static void glLightModelxv(uint pname, int* param) { QGLFeature.VerifyFunc((nint)_glLightModelxv); _glLightModelxv(pname, param); }
    internal static delegate* unmanaged<uint, int*, void> _glLightModelxv = null;
    
    public static void glLightx(uint light, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glLightx); _glLightx(light, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glLightx = null;
    
    public static void glLightxv(uint light, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glLightxv); _glLightxv(light, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glLightxv = null;
    
    public static void glLineWidthx(int width) { QGLFeature.VerifyFunc((nint)_glLineWidthx); _glLineWidthx(width); }
    internal static delegate* unmanaged<int, void> _glLineWidthx = null;
    
    public static void glLoadIdentity() { QGLFeature.VerifyFunc((nint)_glLoadIdentity); _glLoadIdentity(); }
    internal static delegate* unmanaged<void> _glLoadIdentity = null;
    
    public static void glLoadMatrixx(int* m) { QGLFeature.VerifyFunc((nint)_glLoadMatrixx); _glLoadMatrixx(m); }
    internal static delegate* unmanaged<int*, void> _glLoadMatrixx = null;
    
    public static void glLogicOp(uint opcode) { QGLFeature.VerifyFunc((nint)_glLogicOp); _glLogicOp(opcode); }
    internal static delegate* unmanaged<uint, void> _glLogicOp = null;
    
    public static void glMaterialx(uint face, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glMaterialx); _glMaterialx(face, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glMaterialx = null;
    
    public static void glMaterialxv(uint face, uint pname, int* param) { QGLFeature.VerifyFunc((nint)_glMaterialxv); _glMaterialxv(face, pname, param); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glMaterialxv = null;
    
    public static void glMatrixMode(uint mode) { QGLFeature.VerifyFunc((nint)_glMatrixMode); _glMatrixMode(mode); }
    internal static delegate* unmanaged<uint, void> _glMatrixMode = null;
    
    public static void glMultMatrixx(int* m) { QGLFeature.VerifyFunc((nint)_glMultMatrixx); _glMultMatrixx(m); }
    internal static delegate* unmanaged<int*, void> _glMultMatrixx = null;
    
    public static void glMultiTexCoord4x(uint texture, int s, int t, int r, int q) { QGLFeature.VerifyFunc((nint)_glMultiTexCoord4x); _glMultiTexCoord4x(texture, s, t, r, q); }
    internal static delegate* unmanaged<uint, int, int, int, int, void> _glMultiTexCoord4x = null;
    
    public static void glNormal3x(int nx, int ny, int nz) { QGLFeature.VerifyFunc((nint)_glNormal3x); _glNormal3x(nx, ny, nz); }
    internal static delegate* unmanaged<int, int, int, void> _glNormal3x = null;
    
    public static void glNormalPointer(uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glNormalPointer); _glNormalPointer(type, stride, pointer); }
    internal static delegate* unmanaged<uint, int, void*, void> _glNormalPointer = null;
    
    public static void glOrthox(int l, int r, int b, int t, int n, int f) { QGLFeature.VerifyFunc((nint)_glOrthox); _glOrthox(l, r, b, t, n, f); }
    internal static delegate* unmanaged<int, int, int, int, int, int, void> _glOrthox = null;
    
    public static void glPixelStorei(uint pname, int param) { QGLFeature.VerifyFunc((nint)_glPixelStorei); _glPixelStorei(pname, param); }
    internal static delegate* unmanaged<uint, int, void> _glPixelStorei = null;
    
    public static void glPointParameterx(uint pname, int param) { QGLFeature.VerifyFunc((nint)_glPointParameterx); _glPointParameterx(pname, param); }
    internal static delegate* unmanaged<uint, int, void> _glPointParameterx = null;
    
    public static void glPointParameterxv(uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glPointParameterxv); _glPointParameterxv(pname, @params); }
    internal static delegate* unmanaged<uint, int*, void> _glPointParameterxv = null;
    
    public static void glPointSizex(int size) { QGLFeature.VerifyFunc((nint)_glPointSizex); _glPointSizex(size); }
    internal static delegate* unmanaged<int, void> _glPointSizex = null;
    
    public static void glPolygonOffsetx(int factor, int units) { QGLFeature.VerifyFunc((nint)_glPolygonOffsetx); _glPolygonOffsetx(factor, units); }
    internal static delegate* unmanaged<int, int, void> _glPolygonOffsetx = null;
    
    public static void glPopMatrix() { QGLFeature.VerifyFunc((nint)_glPopMatrix); _glPopMatrix(); }
    internal static delegate* unmanaged<void> _glPopMatrix = null;
    
    public static void glPushMatrix() { QGLFeature.VerifyFunc((nint)_glPushMatrix); _glPushMatrix(); }
    internal static delegate* unmanaged<void> _glPushMatrix = null;
    
    public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels) { QGLFeature.VerifyFunc((nint)_glReadPixels); _glReadPixels(x, y, width, height, format, type, pixels); }
    internal static delegate* unmanaged<int, int, int, int, uint, uint, void*, void> _glReadPixels = null;
    
    public static void glRotatex(int angle, int x, int y, int z) { QGLFeature.VerifyFunc((nint)_glRotatex); _glRotatex(angle, x, y, z); }
    internal static delegate* unmanaged<int, int, int, int, void> _glRotatex = null;
    
    public static void glSampleCoverage(float value, bool invert) { QGLFeature.VerifyFunc((nint)_glSampleCoverage); _glSampleCoverage(value, invert); }
    internal static delegate* unmanaged<float, bool, void> _glSampleCoverage = null;
    
    public static void glSampleCoveragex(int value, bool invert) { QGLFeature.VerifyFunc((nint)_glSampleCoveragex); _glSampleCoveragex(value, invert); }
    internal static delegate* unmanaged<int, bool, void> _glSampleCoveragex = null;
    
    public static void glScalex(int x, int y, int z) { QGLFeature.VerifyFunc((nint)_glScalex); _glScalex(x, y, z); }
    internal static delegate* unmanaged<int, int, int, void> _glScalex = null;
    
    public static void glScissor(int x, int y, int width, int height) { QGLFeature.VerifyFunc((nint)_glScissor); _glScissor(x, y, width, height); }
    internal static delegate* unmanaged<int, int, int, int, void> _glScissor = null;
    
    public static void glShadeModel(uint mode) { QGLFeature.VerifyFunc((nint)_glShadeModel); _glShadeModel(mode); }
    internal static delegate* unmanaged<uint, void> _glShadeModel = null;
    
    public static void glStencilFunc(uint func, int @ref, uint mask) { QGLFeature.VerifyFunc((nint)_glStencilFunc); _glStencilFunc(func, @ref, mask); }
    internal static delegate* unmanaged<uint, int, uint, void> _glStencilFunc = null;
    
    public static void glStencilMask(uint mask) { QGLFeature.VerifyFunc((nint)_glStencilMask); _glStencilMask(mask); }
    internal static delegate* unmanaged<uint, void> _glStencilMask = null;
    
    public static void glStencilOp(uint fail, uint zfail, uint zpass) { QGLFeature.VerifyFunc((nint)_glStencilOp); _glStencilOp(fail, zfail, zpass); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glStencilOp = null;
    
    public static void glTexCoordPointer(int size, uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glTexCoordPointer); _glTexCoordPointer(size, type, stride, pointer); }
    internal static delegate* unmanaged<int, uint, int, void*, void> _glTexCoordPointer = null;
    
    public static void glTexEnvi(uint target, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glTexEnvi); _glTexEnvi(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glTexEnvi = null;
    
    public static void glTexEnvx(uint target, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glTexEnvx); _glTexEnvx(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glTexEnvx = null;
    
    public static void glTexEnviv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glTexEnviv); _glTexEnviv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glTexEnviv = null;
    
    public static void glTexEnvxv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glTexEnvxv); _glTexEnvxv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glTexEnvxv = null;
    
    public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels) { QGLFeature.VerifyFunc((nint)_glTexImage2D); _glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void> _glTexImage2D = null;
    
    public static void glTexParameteri(uint target, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glTexParameteri); _glTexParameteri(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glTexParameteri = null;
    
    public static void glTexParameterx(uint target, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glTexParameterx); _glTexParameterx(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glTexParameterx = null;
    
    public static void glTexParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glTexParameteriv); _glTexParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glTexParameteriv = null;
    
    public static void glTexParameterxv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glTexParameterxv); _glTexParameterxv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glTexParameterxv = null;
    
    public static void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) { QGLFeature.VerifyFunc((nint)_glTexSubImage2D); _glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void> _glTexSubImage2D = null;
    
    public static void glTranslatex(int x, int y, int z) { QGLFeature.VerifyFunc((nint)_glTranslatex); _glTranslatex(x, y, z); }
    internal static delegate* unmanaged<int, int, int, void> _glTranslatex = null;
    
    public static void glVertexPointer(int size, uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glVertexPointer); _glVertexPointer(size, type, stride, pointer); }
    internal static delegate* unmanaged<int, uint, int, void*, void> _glVertexPointer = null;
    
    public static void glViewport(int x, int y, int width, int height) { QGLFeature.VerifyFunc((nint)_glViewport); _glViewport(x, y, width, height); }
    internal static delegate* unmanaged<int, int, int, int, void> _glViewport = null;
     #endregion
    
    internal static void Load()
    {
        _glAlphaFunc = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glAlphaFunc");
        _glClearColor = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glClearColor");
        _glClearDepthf = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glClearDepthf");
        _glClipPlanef = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glClipPlanef");
        _glColor4f = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glColor4f");
        _glDepthRangef = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glDepthRangef");
        _glFogf = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glFogf");
        _glFogfv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glFogfv");
        _glFrustumf = (delegate* unmanaged<float, float, float, float, float, float, void>)QuickGL.GetGLProcAddress("glFrustumf");
        _glGetClipPlanef = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glGetClipPlanef");
        _glGetFloatv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glGetFloatv");
        _glGetLightfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetLightfv");
        _glGetMaterialfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetMaterialfv");
        _glGetTexEnvfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetTexEnvfv");
        _glGetTexParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetTexParameterfv");
        _glLightModelf = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glLightModelf");
        _glLightModelfv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glLightModelfv");
        _glLightf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glLightf");
        _glLightfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glLightfv");
        _glLineWidth = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glLineWidth");
        _glLoadMatrixf = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glLoadMatrixf");
        _glMaterialf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glMaterialf");
        _glMaterialfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glMaterialfv");
        _glMultMatrixf = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glMultMatrixf");
        _glMultiTexCoord4f = (delegate* unmanaged<uint, float, float, float, float, void>)QuickGL.GetGLProcAddress("glMultiTexCoord4f");
        _glNormal3f = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glNormal3f");
        _glOrthof = (delegate* unmanaged<float, float, float, float, float, float, void>)QuickGL.GetGLProcAddress("glOrthof");
        _glPointParameterf = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glPointParameterf");
        _glPointParameterfv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glPointParameterfv");
        _glPointSize = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glPointSize");
        _glPolygonOffset = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glPolygonOffset");
        _glRotatef = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glRotatef");
        _glScalef = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glScalef");
        _glTexEnvf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glTexEnvf");
        _glTexEnvfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glTexEnvfv");
        _glTexParameterf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glTexParameterf");
        _glTexParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glTexParameterfv");
        _glTranslatef = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glTranslatef");
        _glActiveTexture = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glActiveTexture");
        _glAlphaFuncx = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glAlphaFuncx");
        _glBindBuffer = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBindBuffer");
        _glBindTexture = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBindTexture");
        _glBlendFunc = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBlendFunc");
        _glBufferData = (delegate* unmanaged<uint, nint, void*, uint, void>)QuickGL.GetGLProcAddress("glBufferData");
        _glBufferSubData = (delegate* unmanaged<uint, nint, nint, void*, void>)QuickGL.GetGLProcAddress("glBufferSubData");
        _glClear = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glClear");
        _glClearColorx = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glClearColorx");
        _glClearDepthx = (delegate* unmanaged<int, void>)QuickGL.GetGLProcAddress("glClearDepthx");
        _glClearStencil = (delegate* unmanaged<int, void>)QuickGL.GetGLProcAddress("glClearStencil");
        _glClientActiveTexture = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glClientActiveTexture");
        _glClipPlanex = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glClipPlanex");
        _glColor4ub = (delegate* unmanaged<byte, byte, byte, byte, void>)QuickGL.GetGLProcAddress("glColor4ub");
        _glColor4x = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glColor4x");
        _glColorMask = (delegate* unmanaged<bool, bool, bool, bool, void>)QuickGL.GetGLProcAddress("glColorMask");
        _glColorPointer = (delegate* unmanaged<int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glColorPointer");
        _glCompressedTexImage2D = (delegate* unmanaged<uint, int, uint, int, int, int, int, void*, void>)QuickGL.GetGLProcAddress("glCompressedTexImage2D");
        _glCompressedTexSubImage2D = (delegate* unmanaged<uint, int, int, int, int, int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glCompressedTexSubImage2D");
        _glCopyTexImage2D = (delegate* unmanaged<uint, int, uint, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyTexImage2D");
        _glCopyTexSubImage2D = (delegate* unmanaged<uint, int, int, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyTexSubImage2D");
        _glCullFace = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glCullFace");
        _glDeleteBuffers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteBuffers");
        _glDeleteTextures = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteTextures");
        _glDepthFunc = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDepthFunc");
        _glDepthMask = (delegate* unmanaged<bool, void>)QuickGL.GetGLProcAddress("glDepthMask");
        _glDepthRangex = (delegate* unmanaged<int, int, void>)QuickGL.GetGLProcAddress("glDepthRangex");
        _glDisable = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDisable");
        _glDisableClientState = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDisableClientState");
        _glDrawArrays = (delegate* unmanaged<uint, int, int, void>)QuickGL.GetGLProcAddress("glDrawArrays");
        _glDrawElements = (delegate* unmanaged<uint, int, uint, void*, void>)QuickGL.GetGLProcAddress("glDrawElements");
        _glEnable = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glEnable");
        _glEnableClientState = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glEnableClientState");
        _glFinish = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glFinish");
        _glFlush = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glFlush");
        _glFogx = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glFogx");
        _glFogxv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glFogxv");
        _glFrontFace = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glFrontFace");
        _glFrustumx = (delegate* unmanaged<int, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glFrustumx");
        _glGetBooleanv = (delegate* unmanaged<uint, bool*, void>)QuickGL.GetGLProcAddress("glGetBooleanv");
        _glGetBufferParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetBufferParameteriv");
        _glGetClipPlanex = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glGetClipPlanex");
        _glGenBuffers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenBuffers");
        _glGenTextures = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenTextures");
        _glGetError = (delegate* unmanaged<uint>)QuickGL.GetGLProcAddress("glGetError");
        _glGetFixedv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glGetFixedv");
        _glGetIntegerv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glGetIntegerv");
        _glGetLightxv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetLightxv");
        _glGetMaterialxv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetMaterialxv");
        _glGetPointerv = (delegate* unmanaged<uint, void**, void>)QuickGL.GetGLProcAddress("glGetPointerv");
        _glGetString = (delegate* unmanaged<uint, byte*>)QuickGL.GetGLProcAddress("glGetString");
        _glGetTexEnviv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetTexEnviv");
        _glGetTexEnvxv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetTexEnvxv");
        _glGetTexParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetTexParameteriv");
        _glGetTexParameterxv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetTexParameterxv");
        _glHint = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glHint");
        _glIsBuffer = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsBuffer");
        _glIsEnabled = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsEnabled");
        _glIsTexture = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsTexture");
        _glLightModelx = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glLightModelx");
        _glLightModelxv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glLightModelxv");
        _glLightx = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glLightx");
        _glLightxv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glLightxv");
        _glLineWidthx = (delegate* unmanaged<int, void>)QuickGL.GetGLProcAddress("glLineWidthx");
        _glLoadIdentity = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glLoadIdentity");
        _glLoadMatrixx = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glLoadMatrixx");
        _glLogicOp = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glLogicOp");
        _glMaterialx = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glMaterialx");
        _glMaterialxv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glMaterialxv");
        _glMatrixMode = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glMatrixMode");
        _glMultMatrixx = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glMultMatrixx");
        _glMultiTexCoord4x = (delegate* unmanaged<uint, int, int, int, int, void>)QuickGL.GetGLProcAddress("glMultiTexCoord4x");
        _glNormal3x = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glNormal3x");
        _glNormalPointer = (delegate* unmanaged<uint, int, void*, void>)QuickGL.GetGLProcAddress("glNormalPointer");
        _glOrthox = (delegate* unmanaged<int, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glOrthox");
        _glPixelStorei = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glPixelStorei");
        _glPointParameterx = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glPointParameterx");
        _glPointParameterxv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glPointParameterxv");
        _glPointSizex = (delegate* unmanaged<int, void>)QuickGL.GetGLProcAddress("glPointSizex");
        _glPolygonOffsetx = (delegate* unmanaged<int, int, void>)QuickGL.GetGLProcAddress("glPolygonOffsetx");
        _glPopMatrix = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glPopMatrix");
        _glPushMatrix = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glPushMatrix");
        _glReadPixels = (delegate* unmanaged<int, int, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glReadPixels");
        _glRotatex = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glRotatex");
        _glSampleCoverage = (delegate* unmanaged<float, bool, void>)QuickGL.GetGLProcAddress("glSampleCoverage");
        _glSampleCoveragex = (delegate* unmanaged<int, bool, void>)QuickGL.GetGLProcAddress("glSampleCoveragex");
        _glScalex = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glScalex");
        _glScissor = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glScissor");
        _glShadeModel = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glShadeModel");
        _glStencilFunc = (delegate* unmanaged<uint, int, uint, void>)QuickGL.GetGLProcAddress("glStencilFunc");
        _glStencilMask = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glStencilMask");
        _glStencilOp = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glStencilOp");
        _glTexCoordPointer = (delegate* unmanaged<int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glTexCoordPointer");
        _glTexEnvi = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glTexEnvi");
        _glTexEnvx = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glTexEnvx");
        _glTexEnviv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glTexEnviv");
        _glTexEnvxv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glTexEnvxv");
        _glTexImage2D = (delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glTexImage2D");
        _glTexParameteri = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glTexParameteri");
        _glTexParameterx = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glTexParameterx");
        _glTexParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glTexParameteriv");
        _glTexParameterxv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glTexParameterxv");
        _glTexSubImage2D = (delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glTexSubImage2D");
        _glTranslatex = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glTranslatex");
        _glVertexPointer = (delegate* unmanaged<int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glVertexPointer");
        _glViewport = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glViewport");
    }
    
    internal static void Unload()
    {
        _glAlphaFunc = null;
        _glClearColor = null;
        _glClearDepthf = null;
        _glClipPlanef = null;
        _glColor4f = null;
        _glDepthRangef = null;
        _glFogf = null;
        _glFogfv = null;
        _glFrustumf = null;
        _glGetClipPlanef = null;
        _glGetFloatv = null;
        _glGetLightfv = null;
        _glGetMaterialfv = null;
        _glGetTexEnvfv = null;
        _glGetTexParameterfv = null;
        _glLightModelf = null;
        _glLightModelfv = null;
        _glLightf = null;
        _glLightfv = null;
        _glLineWidth = null;
        _glLoadMatrixf = null;
        _glMaterialf = null;
        _glMaterialfv = null;
        _glMultMatrixf = null;
        _glMultiTexCoord4f = null;
        _glNormal3f = null;
        _glOrthof = null;
        _glPointParameterf = null;
        _glPointParameterfv = null;
        _glPointSize = null;
        _glPolygonOffset = null;
        _glRotatef = null;
        _glScalef = null;
        _glTexEnvf = null;
        _glTexEnvfv = null;
        _glTexParameterf = null;
        _glTexParameterfv = null;
        _glTranslatef = null;
        _glActiveTexture = null;
        _glAlphaFuncx = null;
        _glBindBuffer = null;
        _glBindTexture = null;
        _glBlendFunc = null;
        _glBufferData = null;
        _glBufferSubData = null;
        _glClear = null;
        _glClearColorx = null;
        _glClearDepthx = null;
        _glClearStencil = null;
        _glClientActiveTexture = null;
        _glClipPlanex = null;
        _glColor4ub = null;
        _glColor4x = null;
        _glColorMask = null;
        _glColorPointer = null;
        _glCompressedTexImage2D = null;
        _glCompressedTexSubImage2D = null;
        _glCopyTexImage2D = null;
        _glCopyTexSubImage2D = null;
        _glCullFace = null;
        _glDeleteBuffers = null;
        _glDeleteTextures = null;
        _glDepthFunc = null;
        _glDepthMask = null;
        _glDepthRangex = null;
        _glDisable = null;
        _glDisableClientState = null;
        _glDrawArrays = null;
        _glDrawElements = null;
        _glEnable = null;
        _glEnableClientState = null;
        _glFinish = null;
        _glFlush = null;
        _glFogx = null;
        _glFogxv = null;
        _glFrontFace = null;
        _glFrustumx = null;
        _glGetBooleanv = null;
        _glGetBufferParameteriv = null;
        _glGetClipPlanex = null;
        _glGenBuffers = null;
        _glGenTextures = null;
        _glGetError = null;
        _glGetFixedv = null;
        _glGetIntegerv = null;
        _glGetLightxv = null;
        _glGetMaterialxv = null;
        _glGetPointerv = null;
        _glGetString = null;
        _glGetTexEnviv = null;
        _glGetTexEnvxv = null;
        _glGetTexParameteriv = null;
        _glGetTexParameterxv = null;
        _glHint = null;
        _glIsBuffer = null;
        _glIsEnabled = null;
        _glIsTexture = null;
        _glLightModelx = null;
        _glLightModelxv = null;
        _glLightx = null;
        _glLightxv = null;
        _glLineWidthx = null;
        _glLoadIdentity = null;
        _glLoadMatrixx = null;
        _glLogicOp = null;
        _glMaterialx = null;
        _glMaterialxv = null;
        _glMatrixMode = null;
        _glMultMatrixx = null;
        _glMultiTexCoord4x = null;
        _glNormal3x = null;
        _glNormalPointer = null;
        _glOrthox = null;
        _glPixelStorei = null;
        _glPointParameterx = null;
        _glPointParameterxv = null;
        _glPointSizex = null;
        _glPolygonOffsetx = null;
        _glPopMatrix = null;
        _glPushMatrix = null;
        _glReadPixels = null;
        _glRotatex = null;
        _glSampleCoverage = null;
        _glSampleCoveragex = null;
        _glScalex = null;
        _glScissor = null;
        _glShadeModel = null;
        _glStencilFunc = null;
        _glStencilMask = null;
        _glStencilOp = null;
        _glTexCoordPointer = null;
        _glTexEnvi = null;
        _glTexEnvx = null;
        _glTexEnviv = null;
        _glTexEnvxv = null;
        _glTexImage2D = null;
        _glTexParameteri = null;
        _glTexParameterx = null;
        _glTexParameteriv = null;
        _glTexParameterxv = null;
        _glTexSubImage2D = null;
        _glTranslatex = null;
        _glVertexPointer = null;
        _glViewport = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_VERSION_ES_CM_1_0", false, true);
}
