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

// Bindings generated at 2025-09-20 18:58:19.709624
namespace QuickGLNS.Bindings;

public static unsafe class GL10
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
    public const int GL_QUADS = 0x7;
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
    public const int GL_NONE = 0x0;
    public const int GL_FRONT_LEFT = 0x400;
    public const int GL_FRONT_RIGHT = 0x401;
    public const int GL_BACK_LEFT = 0x402;
    public const int GL_BACK_RIGHT = 0x403;
    public const int GL_FRONT = 0x404;
    public const int GL_BACK = 0x405;
    public const int GL_LEFT = 0x406;
    public const int GL_RIGHT = 0x407;
    public const int GL_FRONT_AND_BACK = 0x408;
    public const int GL_NO_ERROR = 0x0;
    public const int GL_INVALID_ENUM = 0x500;
    public const int GL_INVALID_VALUE = 0x501;
    public const int GL_INVALID_OPERATION = 0x502;
    public const int GL_OUT_OF_MEMORY = 0x505;
    public const int GL_CW = 0x900;
    public const int GL_CCW = 0x901;
    public const int GL_POINT_SIZE = 0xB11;
    public const int GL_POINT_SIZE_RANGE = 0xB12;
    public const int GL_POINT_SIZE_GRANULARITY = 0xB13;
    public const int GL_LINE_SMOOTH = 0xB20;
    public const int GL_LINE_WIDTH = 0xB21;
    public const int GL_LINE_WIDTH_RANGE = 0xB22;
    public const int GL_LINE_WIDTH_GRANULARITY = 0xB23;
    public const int GL_POLYGON_MODE = 0xB40;
    public const int GL_POLYGON_SMOOTH = 0xB41;
    public const int GL_CULL_FACE = 0xB44;
    public const int GL_CULL_FACE_MODE = 0xB45;
    public const int GL_FRONT_FACE = 0xB46;
    public const int GL_DEPTH_RANGE = 0xB70;
    public const int GL_DEPTH_TEST = 0xB71;
    public const int GL_DEPTH_WRITEMASK = 0xB72;
    public const int GL_DEPTH_CLEAR_VALUE = 0xB73;
    public const int GL_DEPTH_FUNC = 0xB74;
    public const int GL_STENCIL_TEST = 0xB90;
    public const int GL_STENCIL_CLEAR_VALUE = 0xB91;
    public const int GL_STENCIL_FUNC = 0xB92;
    public const int GL_STENCIL_VALUE_MASK = 0xB93;
    public const int GL_STENCIL_FAIL = 0xB94;
    public const int GL_STENCIL_PASS_DEPTH_FAIL = 0xB95;
    public const int GL_STENCIL_PASS_DEPTH_PASS = 0xB96;
    public const int GL_STENCIL_REF = 0xB97;
    public const int GL_STENCIL_WRITEMASK = 0xB98;
    public const int GL_VIEWPORT = 0xBA2;
    public const int GL_DITHER = 0xBD0;
    public const int GL_BLEND_DST = 0xBE0;
    public const int GL_BLEND_SRC = 0xBE1;
    public const int GL_BLEND = 0xBE2;
    public const int GL_LOGIC_OP_MODE = 0xBF0;
    public const int GL_DRAW_BUFFER = 0xC01;
    public const int GL_READ_BUFFER = 0xC02;
    public const int GL_SCISSOR_BOX = 0xC10;
    public const int GL_SCISSOR_TEST = 0xC11;
    public const int GL_COLOR_CLEAR_VALUE = 0xC22;
    public const int GL_COLOR_WRITEMASK = 0xC23;
    public const int GL_DOUBLEBUFFER = 0xC32;
    public const int GL_STEREO = 0xC33;
    public const int GL_LINE_SMOOTH_HINT = 0xC52;
    public const int GL_POLYGON_SMOOTH_HINT = 0xC53;
    public const int GL_UNPACK_SWAP_BYTES = 0xCF0;
    public const int GL_UNPACK_LSB_FIRST = 0xCF1;
    public const int GL_UNPACK_ROW_LENGTH = 0xCF2;
    public const int GL_UNPACK_SKIP_ROWS = 0xCF3;
    public const int GL_UNPACK_SKIP_PIXELS = 0xCF4;
    public const int GL_UNPACK_ALIGNMENT = 0xCF5;
    public const int GL_PACK_SWAP_BYTES = 0xD00;
    public const int GL_PACK_LSB_FIRST = 0xD01;
    public const int GL_PACK_ROW_LENGTH = 0xD02;
    public const int GL_PACK_SKIP_ROWS = 0xD03;
    public const int GL_PACK_SKIP_PIXELS = 0xD04;
    public const int GL_PACK_ALIGNMENT = 0xD05;
    public const int GL_MAX_TEXTURE_SIZE = 0xD33;
    public const int GL_MAX_VIEWPORT_DIMS = 0xD3A;
    public const int GL_SUBPIXEL_BITS = 0xD50;
    public const int GL_TEXTURE_1D = 0xDE0;
    public const int GL_TEXTURE_2D = 0xDE1;
    public const int GL_TEXTURE_WIDTH = 0x1000;
    public const int GL_TEXTURE_HEIGHT = 0x1001;
    public const int GL_TEXTURE_BORDER_COLOR = 0x1004;
    public const int GL_DONT_CARE = 0x1100;
    public const int GL_FASTEST = 0x1101;
    public const int GL_NICEST = 0x1102;
    public const int GL_BYTE = 0x1400;
    public const int GL_UNSIGNED_BYTE = 0x1401;
    public const int GL_SHORT = 0x1402;
    public const int GL_UNSIGNED_SHORT = 0x1403;
    public const int GL_INT = 0x1404;
    public const int GL_UNSIGNED_INT = 0x1405;
    public const int GL_FLOAT = 0x1406;
    public const int GL_STACK_OVERFLOW = 0x503;
    public const int GL_STACK_UNDERFLOW = 0x504;
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
    public const int GL_TEXTURE = 0x1702;
    public const int GL_COLOR = 0x1800;
    public const int GL_DEPTH = 0x1801;
    public const int GL_STENCIL = 0x1802;
    public const int GL_STENCIL_INDEX = 0x1901;
    public const int GL_DEPTH_COMPONENT = 0x1902;
    public const int GL_RED = 0x1903;
    public const int GL_GREEN = 0x1904;
    public const int GL_BLUE = 0x1905;
    public const int GL_ALPHA = 0x1906;
    public const int GL_RGB = 0x1907;
    public const int GL_RGBA = 0x1908;
    public const int GL_POINT = 0x1B00;
    public const int GL_LINE = 0x1B01;
    public const int GL_FILL = 0x1B02;
    public const int GL_KEEP = 0x1E00;
    public const int GL_REPLACE = 0x1E01;
    public const int GL_INCR = 0x1E02;
    public const int GL_DECR = 0x1E03;
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
    public const int GL_REPEAT = 0x2901;
    public const int GL_CURRENT_BIT = 0x1;
    public const int GL_POINT_BIT = 0x2;
    public const int GL_LINE_BIT = 0x4;
    public const int GL_POLYGON_BIT = 0x8;
    public const int GL_POLYGON_STIPPLE_BIT = 0x10;
    public const int GL_PIXEL_MODE_BIT = 0x20;
    public const int GL_LIGHTING_BIT = 0x40;
    public const int GL_FOG_BIT = 0x80;
    public const int GL_ACCUM_BUFFER_BIT = 0x200;
    public const int GL_VIEWPORT_BIT = 0x800;
    public const int GL_TRANSFORM_BIT = 0x1000;
    public const int GL_ENABLE_BIT = 0x2000;
    public const int GL_HINT_BIT = 0x8000;
    public const int GL_EVAL_BIT = 0x10000;
    public const int GL_LIST_BIT = 0x20000;
    public const int GL_TEXTURE_BIT = 0x40000;
    public const int GL_SCISSOR_BIT = 0x80000;
    public const uint GL_ALL_ATTRIB_BITS = 0xFFFFFFFF;
    public const int GL_QUAD_STRIP = 0x8;
    public const int GL_POLYGON = 0x9;
    public const int GL_ACCUM = 0x100;
    public const int GL_LOAD = 0x101;
    public const int GL_RETURN = 0x102;
    public const int GL_MULT = 0x103;
    public const int GL_ADD = 0x104;
    public const int GL_AUX0 = 0x409;
    public const int GL_AUX1 = 0x40A;
    public const int GL_AUX2 = 0x40B;
    public const int GL_AUX3 = 0x40C;
    public const int GL_2D = 0x600;
    public const int GL_3D = 0x601;
    public const int GL_3D_COLOR = 0x602;
    public const int GL_3D_COLOR_TEXTURE = 0x603;
    public const int GL_4D_COLOR_TEXTURE = 0x604;
    public const int GL_PASS_THROUGH_TOKEN = 0x700;
    public const int GL_POINT_TOKEN = 0x701;
    public const int GL_LINE_TOKEN = 0x702;
    public const int GL_POLYGON_TOKEN = 0x703;
    public const int GL_BITMAP_TOKEN = 0x704;
    public const int GL_DRAW_PIXEL_TOKEN = 0x705;
    public const int GL_COPY_PIXEL_TOKEN = 0x706;
    public const int GL_LINE_RESET_TOKEN = 0x707;
    public const int GL_EXP = 0x800;
    public const int GL_EXP2 = 0x801;
    public const int GL_COEFF = 0xA00;
    public const int GL_ORDER = 0xA01;
    public const int GL_DOMAIN = 0xA02;
    public const int GL_PIXEL_MAP_I_TO_I = 0xC70;
    public const int GL_PIXEL_MAP_S_TO_S = 0xC71;
    public const int GL_PIXEL_MAP_I_TO_R = 0xC72;
    public const int GL_PIXEL_MAP_I_TO_G = 0xC73;
    public const int GL_PIXEL_MAP_I_TO_B = 0xC74;
    public const int GL_PIXEL_MAP_I_TO_A = 0xC75;
    public const int GL_PIXEL_MAP_R_TO_R = 0xC76;
    public const int GL_PIXEL_MAP_G_TO_G = 0xC77;
    public const int GL_PIXEL_MAP_B_TO_B = 0xC78;
    public const int GL_PIXEL_MAP_A_TO_A = 0xC79;
    public const int GL_CURRENT_COLOR = 0xB00;
    public const int GL_CURRENT_INDEX = 0xB01;
    public const int GL_CURRENT_NORMAL = 0xB02;
    public const int GL_CURRENT_TEXTURE_COORDS = 0xB03;
    public const int GL_CURRENT_RASTER_COLOR = 0xB04;
    public const int GL_CURRENT_RASTER_INDEX = 0xB05;
    public const int GL_CURRENT_RASTER_TEXTURE_COORDS = 0xB06;
    public const int GL_CURRENT_RASTER_POSITION = 0xB07;
    public const int GL_CURRENT_RASTER_POSITION_VALID = 0xB08;
    public const int GL_CURRENT_RASTER_DISTANCE = 0xB09;
    public const int GL_POINT_SMOOTH = 0xB10;
    public const int GL_LINE_STIPPLE = 0xB24;
    public const int GL_LINE_STIPPLE_PATTERN = 0xB25;
    public const int GL_LINE_STIPPLE_REPEAT = 0xB26;
    public const int GL_LIST_MODE = 0xB30;
    public const int GL_MAX_LIST_NESTING = 0xB31;
    public const int GL_LIST_BASE = 0xB32;
    public const int GL_LIST_INDEX = 0xB33;
    public const int GL_POLYGON_STIPPLE = 0xB42;
    public const int GL_EDGE_FLAG = 0xB43;
    public const int GL_LIGHTING = 0xB50;
    public const int GL_LIGHT_MODEL_LOCAL_VIEWER = 0xB51;
    public const int GL_LIGHT_MODEL_TWO_SIDE = 0xB52;
    public const int GL_LIGHT_MODEL_AMBIENT = 0xB53;
    public const int GL_SHADE_MODEL = 0xB54;
    public const int GL_COLOR_MATERIAL_FACE = 0xB55;
    public const int GL_COLOR_MATERIAL_PARAMETER = 0xB56;
    public const int GL_COLOR_MATERIAL = 0xB57;
    public const int GL_FOG = 0xB60;
    public const int GL_FOG_INDEX = 0xB61;
    public const int GL_FOG_DENSITY = 0xB62;
    public const int GL_FOG_START = 0xB63;
    public const int GL_FOG_END = 0xB64;
    public const int GL_FOG_MODE = 0xB65;
    public const int GL_FOG_COLOR = 0xB66;
    public const int GL_ACCUM_CLEAR_VALUE = 0xB80;
    public const int GL_MATRIX_MODE = 0xBA0;
    public const int GL_NORMALIZE = 0xBA1;
    public const int GL_MODELVIEW_STACK_DEPTH = 0xBA3;
    public const int GL_PROJECTION_STACK_DEPTH = 0xBA4;
    public const int GL_TEXTURE_STACK_DEPTH = 0xBA5;
    public const int GL_MODELVIEW_MATRIX = 0xBA6;
    public const int GL_PROJECTION_MATRIX = 0xBA7;
    public const int GL_TEXTURE_MATRIX = 0xBA8;
    public const int GL_ATTRIB_STACK_DEPTH = 0xBB0;
    public const int GL_ALPHA_TEST = 0xBC0;
    public const int GL_ALPHA_TEST_FUNC = 0xBC1;
    public const int GL_ALPHA_TEST_REF = 0xBC2;
    public const int GL_LOGIC_OP = 0xBF1;
    public const int GL_AUX_BUFFERS = 0xC00;
    public const int GL_INDEX_CLEAR_VALUE = 0xC20;
    public const int GL_INDEX_WRITEMASK = 0xC21;
    public const int GL_INDEX_MODE = 0xC30;
    public const int GL_RGBA_MODE = 0xC31;
    public const int GL_RENDER_MODE = 0xC40;
    public const int GL_PERSPECTIVE_CORRECTION_HINT = 0xC50;
    public const int GL_POINT_SMOOTH_HINT = 0xC51;
    public const int GL_FOG_HINT = 0xC54;
    public const int GL_TEXTURE_GEN_S = 0xC60;
    public const int GL_TEXTURE_GEN_T = 0xC61;
    public const int GL_TEXTURE_GEN_R = 0xC62;
    public const int GL_TEXTURE_GEN_Q = 0xC63;
    public const int GL_PIXEL_MAP_I_TO_I_SIZE = 0xCB0;
    public const int GL_PIXEL_MAP_S_TO_S_SIZE = 0xCB1;
    public const int GL_PIXEL_MAP_I_TO_R_SIZE = 0xCB2;
    public const int GL_PIXEL_MAP_I_TO_G_SIZE = 0xCB3;
    public const int GL_PIXEL_MAP_I_TO_B_SIZE = 0xCB4;
    public const int GL_PIXEL_MAP_I_TO_A_SIZE = 0xCB5;
    public const int GL_PIXEL_MAP_R_TO_R_SIZE = 0xCB6;
    public const int GL_PIXEL_MAP_G_TO_G_SIZE = 0xCB7;
    public const int GL_PIXEL_MAP_B_TO_B_SIZE = 0xCB8;
    public const int GL_PIXEL_MAP_A_TO_A_SIZE = 0xCB9;
    public const int GL_MAP_COLOR = 0xD10;
    public const int GL_MAP_STENCIL = 0xD11;
    public const int GL_INDEX_SHIFT = 0xD12;
    public const int GL_INDEX_OFFSET = 0xD13;
    public const int GL_RED_SCALE = 0xD14;
    public const int GL_RED_BIAS = 0xD15;
    public const int GL_ZOOM_X = 0xD16;
    public const int GL_ZOOM_Y = 0xD17;
    public const int GL_GREEN_SCALE = 0xD18;
    public const int GL_GREEN_BIAS = 0xD19;
    public const int GL_BLUE_SCALE = 0xD1A;
    public const int GL_BLUE_BIAS = 0xD1B;
    public const int GL_ALPHA_SCALE = 0xD1C;
    public const int GL_ALPHA_BIAS = 0xD1D;
    public const int GL_DEPTH_SCALE = 0xD1E;
    public const int GL_DEPTH_BIAS = 0xD1F;
    public const int GL_MAX_EVAL_ORDER = 0xD30;
    public const int GL_MAX_LIGHTS = 0xD31;
    public const int GL_MAX_CLIP_PLANES = 0xD32;
    public const int GL_MAX_PIXEL_MAP_TABLE = 0xD34;
    public const int GL_MAX_ATTRIB_STACK_DEPTH = 0xD35;
    public const int GL_MAX_MODELVIEW_STACK_DEPTH = 0xD36;
    public const int GL_MAX_NAME_STACK_DEPTH = 0xD37;
    public const int GL_MAX_PROJECTION_STACK_DEPTH = 0xD38;
    public const int GL_MAX_TEXTURE_STACK_DEPTH = 0xD39;
    public const int GL_INDEX_BITS = 0xD51;
    public const int GL_RED_BITS = 0xD52;
    public const int GL_GREEN_BITS = 0xD53;
    public const int GL_BLUE_BITS = 0xD54;
    public const int GL_ALPHA_BITS = 0xD55;
    public const int GL_DEPTH_BITS = 0xD56;
    public const int GL_STENCIL_BITS = 0xD57;
    public const int GL_ACCUM_RED_BITS = 0xD58;
    public const int GL_ACCUM_GREEN_BITS = 0xD59;
    public const int GL_ACCUM_BLUE_BITS = 0xD5A;
    public const int GL_ACCUM_ALPHA_BITS = 0xD5B;
    public const int GL_NAME_STACK_DEPTH = 0xD70;
    public const int GL_AUTO_NORMAL = 0xD80;
    public const int GL_MAP1_COLOR_4 = 0xD90;
    public const int GL_MAP1_INDEX = 0xD91;
    public const int GL_MAP1_NORMAL = 0xD92;
    public const int GL_MAP1_TEXTURE_COORD_1 = 0xD93;
    public const int GL_MAP1_TEXTURE_COORD_2 = 0xD94;
    public const int GL_MAP1_TEXTURE_COORD_3 = 0xD95;
    public const int GL_MAP1_TEXTURE_COORD_4 = 0xD96;
    public const int GL_MAP1_VERTEX_3 = 0xD97;
    public const int GL_MAP1_VERTEX_4 = 0xD98;
    public const int GL_MAP2_COLOR_4 = 0xDB0;
    public const int GL_MAP2_INDEX = 0xDB1;
    public const int GL_MAP2_NORMAL = 0xDB2;
    public const int GL_MAP2_TEXTURE_COORD_1 = 0xDB3;
    public const int GL_MAP2_TEXTURE_COORD_2 = 0xDB4;
    public const int GL_MAP2_TEXTURE_COORD_3 = 0xDB5;
    public const int GL_MAP2_TEXTURE_COORD_4 = 0xDB6;
    public const int GL_MAP2_VERTEX_3 = 0xDB7;
    public const int GL_MAP2_VERTEX_4 = 0xDB8;
    public const int GL_MAP1_GRID_DOMAIN = 0xDD0;
    public const int GL_MAP1_GRID_SEGMENTS = 0xDD1;
    public const int GL_MAP2_GRID_DOMAIN = 0xDD2;
    public const int GL_MAP2_GRID_SEGMENTS = 0xDD3;
    public const int GL_TEXTURE_COMPONENTS = 0x1003;
    public const int GL_TEXTURE_BORDER = 0x1005;
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
    public const int GL_COMPILE = 0x1300;
    public const int GL_COMPILE_AND_EXECUTE = 0x1301;
    public const int GL_2_BYTES = 0x1407;
    public const int GL_3_BYTES = 0x1408;
    public const int GL_4_BYTES = 0x1409;
    public const int GL_EMISSION = 0x1600;
    public const int GL_SHININESS = 0x1601;
    public const int GL_AMBIENT_AND_DIFFUSE = 0x1602;
    public const int GL_COLOR_INDEXES = 0x1603;
    public const int GL_MODELVIEW = 0x1700;
    public const int GL_PROJECTION = 0x1701;
    public const int GL_COLOR_INDEX = 0x1900;
    public const int GL_LUMINANCE = 0x1909;
    public const int GL_LUMINANCE_ALPHA = 0x190A;
    public const int GL_BITMAP = 0x1A00;
    public const int GL_RENDER = 0x1C00;
    public const int GL_FEEDBACK = 0x1C01;
    public const int GL_SELECT = 0x1C02;
    public const int GL_FLAT = 0x1D00;
    public const int GL_SMOOTH = 0x1D01;
    public const int GL_S = 0x2000;
    public const int GL_T = 0x2001;
    public const int GL_R = 0x2002;
    public const int GL_Q = 0x2003;
    public const int GL_MODULATE = 0x2100;
    public const int GL_DECAL = 0x2101;
    public const int GL_TEXTURE_ENV_MODE = 0x2200;
    public const int GL_TEXTURE_ENV_COLOR = 0x2201;
    public const int GL_TEXTURE_ENV = 0x2300;
    public const int GL_EYE_LINEAR = 0x2400;
    public const int GL_OBJECT_LINEAR = 0x2401;
    public const int GL_SPHERE_MAP = 0x2402;
    public const int GL_TEXTURE_GEN_MODE = 0x2500;
    public const int GL_OBJECT_PLANE = 0x2501;
    public const int GL_EYE_PLANE = 0x2502;
    public const int GL_CLAMP = 0x2900;
    public const int GL_CLIP_PLANE0 = 0x3000;
    public const int GL_CLIP_PLANE1 = 0x3001;
    public const int GL_CLIP_PLANE2 = 0x3002;
    public const int GL_CLIP_PLANE3 = 0x3003;
    public const int GL_CLIP_PLANE4 = 0x3004;
    public const int GL_CLIP_PLANE5 = 0x3005;
    public const int GL_LIGHT0 = 0x4000;
    public const int GL_LIGHT1 = 0x4001;
    public const int GL_LIGHT2 = 0x4002;
    public const int GL_LIGHT3 = 0x4003;
    public const int GL_LIGHT4 = 0x4004;
    public const int GL_LIGHT5 = 0x4005;
    public const int GL_LIGHT6 = 0x4006;
    public const int GL_LIGHT7 = 0x4007;
    #endregion
    
    #region Commands
    public static void glCullFace(uint mode) { QGLFeature.VerifyFunc((nint)_glCullFace); _glCullFace(mode); }
    internal static delegate* unmanaged<uint, void> _glCullFace = null;
    
    public static void glFrontFace(uint mode) { QGLFeature.VerifyFunc((nint)_glFrontFace); _glFrontFace(mode); }
    internal static delegate* unmanaged<uint, void> _glFrontFace = null;
    
    public static void glHint(uint target, uint mode) { QGLFeature.VerifyFunc((nint)_glHint); _glHint(target, mode); }
    internal static delegate* unmanaged<uint, uint, void> _glHint = null;
    
    public static void glLineWidth(float width) { QGLFeature.VerifyFunc((nint)_glLineWidth); _glLineWidth(width); }
    internal static delegate* unmanaged<float, void> _glLineWidth = null;
    
    public static void glPointSize(float size) { QGLFeature.VerifyFunc((nint)_glPointSize); _glPointSize(size); }
    internal static delegate* unmanaged<float, void> _glPointSize = null;
    
    public static void glPolygonMode(uint face, uint mode) { QGLFeature.VerifyFunc((nint)_glPolygonMode); _glPolygonMode(face, mode); }
    internal static delegate* unmanaged<uint, uint, void> _glPolygonMode = null;
    
    public static void glScissor(int x, int y, int width, int height) { QGLFeature.VerifyFunc((nint)_glScissor); _glScissor(x, y, width, height); }
    internal static delegate* unmanaged<int, int, int, int, void> _glScissor = null;
    
    public static void glTexParameterf(uint target, uint pname, float param) { QGLFeature.VerifyFunc((nint)_glTexParameterf); _glTexParameterf(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, float, void> _glTexParameterf = null;
    
    public static void glTexParameterfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glTexParameterfv); _glTexParameterfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glTexParameterfv = null;
    
    public static void glTexParameteri(uint target, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glTexParameteri); _glTexParameteri(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glTexParameteri = null;
    
    public static void glTexParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glTexParameteriv); _glTexParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glTexParameteriv = null;
    
    public static void glTexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels) { QGLFeature.VerifyFunc((nint)_glTexImage1D); _glTexImage1D(target, level, internalformat, width, border, format, type, pixels); }
    internal static delegate* unmanaged<uint, int, int, int, int, uint, uint, void*, void> _glTexImage1D = null;
    
    public static void glTexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels) { QGLFeature.VerifyFunc((nint)_glTexImage2D); _glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void> _glTexImage2D = null;
    
    public static void glDrawBuffer(uint buf) { QGLFeature.VerifyFunc((nint)_glDrawBuffer); _glDrawBuffer(buf); }
    internal static delegate* unmanaged<uint, void> _glDrawBuffer = null;
    
    public static void glClear(uint mask) { QGLFeature.VerifyFunc((nint)_glClear); _glClear(mask); }
    internal static delegate* unmanaged<uint, void> _glClear = null;
    
    public static void glClearColor(float red, float green, float blue, float alpha) { QGLFeature.VerifyFunc((nint)_glClearColor); _glClearColor(red, green, blue, alpha); }
    internal static delegate* unmanaged<float, float, float, float, void> _glClearColor = null;
    
    public static void glClearStencil(int s) { QGLFeature.VerifyFunc((nint)_glClearStencil); _glClearStencil(s); }
    internal static delegate* unmanaged<int, void> _glClearStencil = null;
    
    public static void glClearDepth(double depth) { QGLFeature.VerifyFunc((nint)_glClearDepth); _glClearDepth(depth); }
    internal static delegate* unmanaged<double, void> _glClearDepth = null;
    
    public static void glStencilMask(uint mask) { QGLFeature.VerifyFunc((nint)_glStencilMask); _glStencilMask(mask); }
    internal static delegate* unmanaged<uint, void> _glStencilMask = null;
    
    public static void glColorMask(bool red, bool green, bool blue, bool alpha) { QGLFeature.VerifyFunc((nint)_glColorMask); _glColorMask(red, green, blue, alpha); }
    internal static delegate* unmanaged<bool, bool, bool, bool, void> _glColorMask = null;
    
    public static void glDepthMask(bool flag) { QGLFeature.VerifyFunc((nint)_glDepthMask); _glDepthMask(flag); }
    internal static delegate* unmanaged<bool, void> _glDepthMask = null;
    
    public static void glDisable(uint cap) { QGLFeature.VerifyFunc((nint)_glDisable); _glDisable(cap); }
    internal static delegate* unmanaged<uint, void> _glDisable = null;
    
    public static void glEnable(uint cap) { QGLFeature.VerifyFunc((nint)_glEnable); _glEnable(cap); }
    internal static delegate* unmanaged<uint, void> _glEnable = null;
    
    public static void glFinish() { QGLFeature.VerifyFunc((nint)_glFinish); _glFinish(); }
    internal static delegate* unmanaged<void> _glFinish = null;
    
    public static void glFlush() { QGLFeature.VerifyFunc((nint)_glFlush); _glFlush(); }
    internal static delegate* unmanaged<void> _glFlush = null;
    
    public static void glBlendFunc(uint sfactor, uint dfactor) { QGLFeature.VerifyFunc((nint)_glBlendFunc); _glBlendFunc(sfactor, dfactor); }
    internal static delegate* unmanaged<uint, uint, void> _glBlendFunc = null;
    
    public static void glLogicOp(uint opcode) { QGLFeature.VerifyFunc((nint)_glLogicOp); _glLogicOp(opcode); }
    internal static delegate* unmanaged<uint, void> _glLogicOp = null;
    
    public static void glStencilFunc(uint func, int @ref, uint mask) { QGLFeature.VerifyFunc((nint)_glStencilFunc); _glStencilFunc(func, @ref, mask); }
    internal static delegate* unmanaged<uint, int, uint, void> _glStencilFunc = null;
    
    public static void glStencilOp(uint fail, uint zfail, uint zpass) { QGLFeature.VerifyFunc((nint)_glStencilOp); _glStencilOp(fail, zfail, zpass); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glStencilOp = null;
    
    public static void glDepthFunc(uint func) { QGLFeature.VerifyFunc((nint)_glDepthFunc); _glDepthFunc(func); }
    internal static delegate* unmanaged<uint, void> _glDepthFunc = null;
    
    public static void glPixelStoref(uint pname, float param) { QGLFeature.VerifyFunc((nint)_glPixelStoref); _glPixelStoref(pname, param); }
    internal static delegate* unmanaged<uint, float, void> _glPixelStoref = null;
    
    public static void glPixelStorei(uint pname, int param) { QGLFeature.VerifyFunc((nint)_glPixelStorei); _glPixelStorei(pname, param); }
    internal static delegate* unmanaged<uint, int, void> _glPixelStorei = null;
    
    public static void glReadBuffer(uint src) { QGLFeature.VerifyFunc((nint)_glReadBuffer); _glReadBuffer(src); }
    internal static delegate* unmanaged<uint, void> _glReadBuffer = null;
    
    public static void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels) { QGLFeature.VerifyFunc((nint)_glReadPixels); _glReadPixels(x, y, width, height, format, type, pixels); }
    internal static delegate* unmanaged<int, int, int, int, uint, uint, void*, void> _glReadPixels = null;
    
    public static void glGetBooleanv(uint pname, bool* data) { QGLFeature.VerifyFunc((nint)_glGetBooleanv); _glGetBooleanv(pname, data); }
    internal static delegate* unmanaged<uint, bool*, void> _glGetBooleanv = null;
    
    public static void glGetDoublev(uint pname, double* data) { QGLFeature.VerifyFunc((nint)_glGetDoublev); _glGetDoublev(pname, data); }
    internal static delegate* unmanaged<uint, double*, void> _glGetDoublev = null;
    
    public static uint glGetError() { QGLFeature.VerifyFunc((nint)_glGetError); return _glGetError(); }
    internal static delegate* unmanaged<uint> _glGetError = null;
    
    public static void glGetFloatv(uint pname, float* data) { QGLFeature.VerifyFunc((nint)_glGetFloatv); _glGetFloatv(pname, data); }
    internal static delegate* unmanaged<uint, float*, void> _glGetFloatv = null;
    
    public static void glGetIntegerv(uint pname, int* data) { QGLFeature.VerifyFunc((nint)_glGetIntegerv); _glGetIntegerv(pname, data); }
    internal static delegate* unmanaged<uint, int*, void> _glGetIntegerv = null;
    
    public static byte* glGetString(uint name) { QGLFeature.VerifyFunc((nint)_glGetString); return _glGetString(name); }
    internal static delegate* unmanaged<uint, byte*> _glGetString = null;
    
    public static void glGetTexImage(uint target, int level, uint format, uint type, void* pixels) { QGLFeature.VerifyFunc((nint)_glGetTexImage); _glGetTexImage(target, level, format, type, pixels); }
    internal static delegate* unmanaged<uint, int, uint, uint, void*, void> _glGetTexImage = null;
    
    public static void glGetTexParameterfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetTexParameterfv); _glGetTexParameterfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetTexParameterfv = null;
    
    public static void glGetTexParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetTexParameteriv); _glGetTexParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexParameteriv = null;
    
    public static void glGetTexLevelParameterfv(uint target, int level, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetTexLevelParameterfv); _glGetTexLevelParameterfv(target, level, pname, @params); }
    internal static delegate* unmanaged<uint, int, uint, float*, void> _glGetTexLevelParameterfv = null;
    
    public static void glGetTexLevelParameteriv(uint target, int level, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetTexLevelParameteriv); _glGetTexLevelParameteriv(target, level, pname, @params); }
    internal static delegate* unmanaged<uint, int, uint, int*, void> _glGetTexLevelParameteriv = null;
    
    public static bool glIsEnabled(uint cap) { QGLFeature.VerifyFunc((nint)_glIsEnabled); return _glIsEnabled(cap); }
    internal static delegate* unmanaged<uint, bool> _glIsEnabled = null;
    
    public static void glDepthRange(double n, double f) { QGLFeature.VerifyFunc((nint)_glDepthRange); _glDepthRange(n, f); }
    internal static delegate* unmanaged<double, double, void> _glDepthRange = null;
    
    public static void glViewport(int x, int y, int width, int height) { QGLFeature.VerifyFunc((nint)_glViewport); _glViewport(x, y, width, height); }
    internal static delegate* unmanaged<int, int, int, int, void> _glViewport = null;
    
    public static void glNewList(uint list, uint mode) { QGLFeature.VerifyFunc((nint)_glNewList); _glNewList(list, mode); }
    internal static delegate* unmanaged<uint, uint, void> _glNewList = null;
    
    public static void glEndList() { QGLFeature.VerifyFunc((nint)_glEndList); _glEndList(); }
    internal static delegate* unmanaged<void> _glEndList = null;
    
    public static void glCallList(uint list) { QGLFeature.VerifyFunc((nint)_glCallList); _glCallList(list); }
    internal static delegate* unmanaged<uint, void> _glCallList = null;
    
    public static void glCallLists(int n, uint type, void* lists) { QGLFeature.VerifyFunc((nint)_glCallLists); _glCallLists(n, type, lists); }
    internal static delegate* unmanaged<int, uint, void*, void> _glCallLists = null;
    
    public static void glDeleteLists(uint list, int range) { QGLFeature.VerifyFunc((nint)_glDeleteLists); _glDeleteLists(list, range); }
    internal static delegate* unmanaged<uint, int, void> _glDeleteLists = null;
    
    public static uint glGenLists(int range) { QGLFeature.VerifyFunc((nint)_glGenLists); return _glGenLists(range); }
    internal static delegate* unmanaged<int, uint> _glGenLists = null;
    
    public static void glListBase(uint @base) { QGLFeature.VerifyFunc((nint)_glListBase); _glListBase(@base); }
    internal static delegate* unmanaged<uint, void> _glListBase = null;
    
    public static void glBegin(uint mode) { QGLFeature.VerifyFunc((nint)_glBegin); _glBegin(mode); }
    internal static delegate* unmanaged<uint, void> _glBegin = null;
    
    public static void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap) { QGLFeature.VerifyFunc((nint)_glBitmap); _glBitmap(width, height, xorig, yorig, xmove, ymove, bitmap); }
    internal static delegate* unmanaged<int, int, float, float, float, float, byte*, void> _glBitmap = null;
    
    public static void glColor3b(sbyte red, sbyte green, sbyte blue) { QGLFeature.VerifyFunc((nint)_glColor3b); _glColor3b(red, green, blue); }
    internal static delegate* unmanaged<sbyte, sbyte, sbyte, void> _glColor3b = null;
    
    public static void glColor3bv(sbyte* v) { QGLFeature.VerifyFunc((nint)_glColor3bv); _glColor3bv(v); }
    internal static delegate* unmanaged<sbyte*, void> _glColor3bv = null;
    
    public static void glColor3d(double red, double green, double blue) { QGLFeature.VerifyFunc((nint)_glColor3d); _glColor3d(red, green, blue); }
    internal static delegate* unmanaged<double, double, double, void> _glColor3d = null;
    
    public static void glColor3dv(double* v) { QGLFeature.VerifyFunc((nint)_glColor3dv); _glColor3dv(v); }
    internal static delegate* unmanaged<double*, void> _glColor3dv = null;
    
    public static void glColor3f(float red, float green, float blue) { QGLFeature.VerifyFunc((nint)_glColor3f); _glColor3f(red, green, blue); }
    internal static delegate* unmanaged<float, float, float, void> _glColor3f = null;
    
    public static void glColor3fv(float* v) { QGLFeature.VerifyFunc((nint)_glColor3fv); _glColor3fv(v); }
    internal static delegate* unmanaged<float*, void> _glColor3fv = null;
    
    public static void glColor3i(int red, int green, int blue) { QGLFeature.VerifyFunc((nint)_glColor3i); _glColor3i(red, green, blue); }
    internal static delegate* unmanaged<int, int, int, void> _glColor3i = null;
    
    public static void glColor3iv(int* v) { QGLFeature.VerifyFunc((nint)_glColor3iv); _glColor3iv(v); }
    internal static delegate* unmanaged<int*, void> _glColor3iv = null;
    
    public static void glColor3s(short red, short green, short blue) { QGLFeature.VerifyFunc((nint)_glColor3s); _glColor3s(red, green, blue); }
    internal static delegate* unmanaged<short, short, short, void> _glColor3s = null;
    
    public static void glColor3sv(short* v) { QGLFeature.VerifyFunc((nint)_glColor3sv); _glColor3sv(v); }
    internal static delegate* unmanaged<short*, void> _glColor3sv = null;
    
    public static void glColor3ub(byte red, byte green, byte blue) { QGLFeature.VerifyFunc((nint)_glColor3ub); _glColor3ub(red, green, blue); }
    internal static delegate* unmanaged<byte, byte, byte, void> _glColor3ub = null;
    
    public static void glColor3ubv(byte* v) { QGLFeature.VerifyFunc((nint)_glColor3ubv); _glColor3ubv(v); }
    internal static delegate* unmanaged<byte*, void> _glColor3ubv = null;
    
    public static void glColor3ui(uint red, uint green, uint blue) { QGLFeature.VerifyFunc((nint)_glColor3ui); _glColor3ui(red, green, blue); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glColor3ui = null;
    
    public static void glColor3uiv(uint* v) { QGLFeature.VerifyFunc((nint)_glColor3uiv); _glColor3uiv(v); }
    internal static delegate* unmanaged<uint*, void> _glColor3uiv = null;
    
    public static void glColor3us(ushort red, ushort green, ushort blue) { QGLFeature.VerifyFunc((nint)_glColor3us); _glColor3us(red, green, blue); }
    internal static delegate* unmanaged<ushort, ushort, ushort, void> _glColor3us = null;
    
    public static void glColor3usv(ushort* v) { QGLFeature.VerifyFunc((nint)_glColor3usv); _glColor3usv(v); }
    internal static delegate* unmanaged<ushort*, void> _glColor3usv = null;
    
    public static void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha) { QGLFeature.VerifyFunc((nint)_glColor4b); _glColor4b(red, green, blue, alpha); }
    internal static delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void> _glColor4b = null;
    
    public static void glColor4bv(sbyte* v) { QGLFeature.VerifyFunc((nint)_glColor4bv); _glColor4bv(v); }
    internal static delegate* unmanaged<sbyte*, void> _glColor4bv = null;
    
    public static void glColor4d(double red, double green, double blue, double alpha) { QGLFeature.VerifyFunc((nint)_glColor4d); _glColor4d(red, green, blue, alpha); }
    internal static delegate* unmanaged<double, double, double, double, void> _glColor4d = null;
    
    public static void glColor4dv(double* v) { QGLFeature.VerifyFunc((nint)_glColor4dv); _glColor4dv(v); }
    internal static delegate* unmanaged<double*, void> _glColor4dv = null;
    
    public static void glColor4f(float red, float green, float blue, float alpha) { QGLFeature.VerifyFunc((nint)_glColor4f); _glColor4f(red, green, blue, alpha); }
    internal static delegate* unmanaged<float, float, float, float, void> _glColor4f = null;
    
    public static void glColor4fv(float* v) { QGLFeature.VerifyFunc((nint)_glColor4fv); _glColor4fv(v); }
    internal static delegate* unmanaged<float*, void> _glColor4fv = null;
    
    public static void glColor4i(int red, int green, int blue, int alpha) { QGLFeature.VerifyFunc((nint)_glColor4i); _glColor4i(red, green, blue, alpha); }
    internal static delegate* unmanaged<int, int, int, int, void> _glColor4i = null;
    
    public static void glColor4iv(int* v) { QGLFeature.VerifyFunc((nint)_glColor4iv); _glColor4iv(v); }
    internal static delegate* unmanaged<int*, void> _glColor4iv = null;
    
    public static void glColor4s(short red, short green, short blue, short alpha) { QGLFeature.VerifyFunc((nint)_glColor4s); _glColor4s(red, green, blue, alpha); }
    internal static delegate* unmanaged<short, short, short, short, void> _glColor4s = null;
    
    public static void glColor4sv(short* v) { QGLFeature.VerifyFunc((nint)_glColor4sv); _glColor4sv(v); }
    internal static delegate* unmanaged<short*, void> _glColor4sv = null;
    
    public static void glColor4ub(byte red, byte green, byte blue, byte alpha) { QGLFeature.VerifyFunc((nint)_glColor4ub); _glColor4ub(red, green, blue, alpha); }
    internal static delegate* unmanaged<byte, byte, byte, byte, void> _glColor4ub = null;
    
    public static void glColor4ubv(byte* v) { QGLFeature.VerifyFunc((nint)_glColor4ubv); _glColor4ubv(v); }
    internal static delegate* unmanaged<byte*, void> _glColor4ubv = null;
    
    public static void glColor4ui(uint red, uint green, uint blue, uint alpha) { QGLFeature.VerifyFunc((nint)_glColor4ui); _glColor4ui(red, green, blue, alpha); }
    internal static delegate* unmanaged<uint, uint, uint, uint, void> _glColor4ui = null;
    
    public static void glColor4uiv(uint* v) { QGLFeature.VerifyFunc((nint)_glColor4uiv); _glColor4uiv(v); }
    internal static delegate* unmanaged<uint*, void> _glColor4uiv = null;
    
    public static void glColor4us(ushort red, ushort green, ushort blue, ushort alpha) { QGLFeature.VerifyFunc((nint)_glColor4us); _glColor4us(red, green, blue, alpha); }
    internal static delegate* unmanaged<ushort, ushort, ushort, ushort, void> _glColor4us = null;
    
    public static void glColor4usv(ushort* v) { QGLFeature.VerifyFunc((nint)_glColor4usv); _glColor4usv(v); }
    internal static delegate* unmanaged<ushort*, void> _glColor4usv = null;
    
    public static void glEdgeFlag(bool flag) { QGLFeature.VerifyFunc((nint)_glEdgeFlag); _glEdgeFlag(flag); }
    internal static delegate* unmanaged<bool, void> _glEdgeFlag = null;
    
    public static void glEdgeFlagv(bool* flag) { QGLFeature.VerifyFunc((nint)_glEdgeFlagv); _glEdgeFlagv(flag); }
    internal static delegate* unmanaged<bool*, void> _glEdgeFlagv = null;
    
    public static void glEnd() { QGLFeature.VerifyFunc((nint)_glEnd); _glEnd(); }
    internal static delegate* unmanaged<void> _glEnd = null;
    
    public static void glIndexd(double c) { QGLFeature.VerifyFunc((nint)_glIndexd); _glIndexd(c); }
    internal static delegate* unmanaged<double, void> _glIndexd = null;
    
    public static void glIndexdv(double* c) { QGLFeature.VerifyFunc((nint)_glIndexdv); _glIndexdv(c); }
    internal static delegate* unmanaged<double*, void> _glIndexdv = null;
    
    public static void glIndexf(float c) { QGLFeature.VerifyFunc((nint)_glIndexf); _glIndexf(c); }
    internal static delegate* unmanaged<float, void> _glIndexf = null;
    
    public static void glIndexfv(float* c) { QGLFeature.VerifyFunc((nint)_glIndexfv); _glIndexfv(c); }
    internal static delegate* unmanaged<float*, void> _glIndexfv = null;
    
    public static void glIndexi(int c) { QGLFeature.VerifyFunc((nint)_glIndexi); _glIndexi(c); }
    internal static delegate* unmanaged<int, void> _glIndexi = null;
    
    public static void glIndexiv(int* c) { QGLFeature.VerifyFunc((nint)_glIndexiv); _glIndexiv(c); }
    internal static delegate* unmanaged<int*, void> _glIndexiv = null;
    
    public static void glIndexs(short c) { QGLFeature.VerifyFunc((nint)_glIndexs); _glIndexs(c); }
    internal static delegate* unmanaged<short, void> _glIndexs = null;
    
    public static void glIndexsv(short* c) { QGLFeature.VerifyFunc((nint)_glIndexsv); _glIndexsv(c); }
    internal static delegate* unmanaged<short*, void> _glIndexsv = null;
    
    public static void glNormal3b(sbyte nx, sbyte ny, sbyte nz) { QGLFeature.VerifyFunc((nint)_glNormal3b); _glNormal3b(nx, ny, nz); }
    internal static delegate* unmanaged<sbyte, sbyte, sbyte, void> _glNormal3b = null;
    
    public static void glNormal3bv(sbyte* v) { QGLFeature.VerifyFunc((nint)_glNormal3bv); _glNormal3bv(v); }
    internal static delegate* unmanaged<sbyte*, void> _glNormal3bv = null;
    
    public static void glNormal3d(double nx, double ny, double nz) { QGLFeature.VerifyFunc((nint)_glNormal3d); _glNormal3d(nx, ny, nz); }
    internal static delegate* unmanaged<double, double, double, void> _glNormal3d = null;
    
    public static void glNormal3dv(double* v) { QGLFeature.VerifyFunc((nint)_glNormal3dv); _glNormal3dv(v); }
    internal static delegate* unmanaged<double*, void> _glNormal3dv = null;
    
    public static void glNormal3f(float nx, float ny, float nz) { QGLFeature.VerifyFunc((nint)_glNormal3f); _glNormal3f(nx, ny, nz); }
    internal static delegate* unmanaged<float, float, float, void> _glNormal3f = null;
    
    public static void glNormal3fv(float* v) { QGLFeature.VerifyFunc((nint)_glNormal3fv); _glNormal3fv(v); }
    internal static delegate* unmanaged<float*, void> _glNormal3fv = null;
    
    public static void glNormal3i(int nx, int ny, int nz) { QGLFeature.VerifyFunc((nint)_glNormal3i); _glNormal3i(nx, ny, nz); }
    internal static delegate* unmanaged<int, int, int, void> _glNormal3i = null;
    
    public static void glNormal3iv(int* v) { QGLFeature.VerifyFunc((nint)_glNormal3iv); _glNormal3iv(v); }
    internal static delegate* unmanaged<int*, void> _glNormal3iv = null;
    
    public static void glNormal3s(short nx, short ny, short nz) { QGLFeature.VerifyFunc((nint)_glNormal3s); _glNormal3s(nx, ny, nz); }
    internal static delegate* unmanaged<short, short, short, void> _glNormal3s = null;
    
    public static void glNormal3sv(short* v) { QGLFeature.VerifyFunc((nint)_glNormal3sv); _glNormal3sv(v); }
    internal static delegate* unmanaged<short*, void> _glNormal3sv = null;
    
    public static void glRasterPos2d(double x, double y) { QGLFeature.VerifyFunc((nint)_glRasterPos2d); _glRasterPos2d(x, y); }
    internal static delegate* unmanaged<double, double, void> _glRasterPos2d = null;
    
    public static void glRasterPos2dv(double* v) { QGLFeature.VerifyFunc((nint)_glRasterPos2dv); _glRasterPos2dv(v); }
    internal static delegate* unmanaged<double*, void> _glRasterPos2dv = null;
    
    public static void glRasterPos2f(float x, float y) { QGLFeature.VerifyFunc((nint)_glRasterPos2f); _glRasterPos2f(x, y); }
    internal static delegate* unmanaged<float, float, void> _glRasterPos2f = null;
    
    public static void glRasterPos2fv(float* v) { QGLFeature.VerifyFunc((nint)_glRasterPos2fv); _glRasterPos2fv(v); }
    internal static delegate* unmanaged<float*, void> _glRasterPos2fv = null;
    
    public static void glRasterPos2i(int x, int y) { QGLFeature.VerifyFunc((nint)_glRasterPos2i); _glRasterPos2i(x, y); }
    internal static delegate* unmanaged<int, int, void> _glRasterPos2i = null;
    
    public static void glRasterPos2iv(int* v) { QGLFeature.VerifyFunc((nint)_glRasterPos2iv); _glRasterPos2iv(v); }
    internal static delegate* unmanaged<int*, void> _glRasterPos2iv = null;
    
    public static void glRasterPos2s(short x, short y) { QGLFeature.VerifyFunc((nint)_glRasterPos2s); _glRasterPos2s(x, y); }
    internal static delegate* unmanaged<short, short, void> _glRasterPos2s = null;
    
    public static void glRasterPos2sv(short* v) { QGLFeature.VerifyFunc((nint)_glRasterPos2sv); _glRasterPos2sv(v); }
    internal static delegate* unmanaged<short*, void> _glRasterPos2sv = null;
    
    public static void glRasterPos3d(double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glRasterPos3d); _glRasterPos3d(x, y, z); }
    internal static delegate* unmanaged<double, double, double, void> _glRasterPos3d = null;
    
    public static void glRasterPos3dv(double* v) { QGLFeature.VerifyFunc((nint)_glRasterPos3dv); _glRasterPos3dv(v); }
    internal static delegate* unmanaged<double*, void> _glRasterPos3dv = null;
    
    public static void glRasterPos3f(float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glRasterPos3f); _glRasterPos3f(x, y, z); }
    internal static delegate* unmanaged<float, float, float, void> _glRasterPos3f = null;
    
    public static void glRasterPos3fv(float* v) { QGLFeature.VerifyFunc((nint)_glRasterPos3fv); _glRasterPos3fv(v); }
    internal static delegate* unmanaged<float*, void> _glRasterPos3fv = null;
    
    public static void glRasterPos3i(int x, int y, int z) { QGLFeature.VerifyFunc((nint)_glRasterPos3i); _glRasterPos3i(x, y, z); }
    internal static delegate* unmanaged<int, int, int, void> _glRasterPos3i = null;
    
    public static void glRasterPos3iv(int* v) { QGLFeature.VerifyFunc((nint)_glRasterPos3iv); _glRasterPos3iv(v); }
    internal static delegate* unmanaged<int*, void> _glRasterPos3iv = null;
    
    public static void glRasterPos3s(short x, short y, short z) { QGLFeature.VerifyFunc((nint)_glRasterPos3s); _glRasterPos3s(x, y, z); }
    internal static delegate* unmanaged<short, short, short, void> _glRasterPos3s = null;
    
    public static void glRasterPos3sv(short* v) { QGLFeature.VerifyFunc((nint)_glRasterPos3sv); _glRasterPos3sv(v); }
    internal static delegate* unmanaged<short*, void> _glRasterPos3sv = null;
    
    public static void glRasterPos4d(double x, double y, double z, double w) { QGLFeature.VerifyFunc((nint)_glRasterPos4d); _glRasterPos4d(x, y, z, w); }
    internal static delegate* unmanaged<double, double, double, double, void> _glRasterPos4d = null;
    
    public static void glRasterPos4dv(double* v) { QGLFeature.VerifyFunc((nint)_glRasterPos4dv); _glRasterPos4dv(v); }
    internal static delegate* unmanaged<double*, void> _glRasterPos4dv = null;
    
    public static void glRasterPos4f(float x, float y, float z, float w) { QGLFeature.VerifyFunc((nint)_glRasterPos4f); _glRasterPos4f(x, y, z, w); }
    internal static delegate* unmanaged<float, float, float, float, void> _glRasterPos4f = null;
    
    public static void glRasterPos4fv(float* v) { QGLFeature.VerifyFunc((nint)_glRasterPos4fv); _glRasterPos4fv(v); }
    internal static delegate* unmanaged<float*, void> _glRasterPos4fv = null;
    
    public static void glRasterPos4i(int x, int y, int z, int w) { QGLFeature.VerifyFunc((nint)_glRasterPos4i); _glRasterPos4i(x, y, z, w); }
    internal static delegate* unmanaged<int, int, int, int, void> _glRasterPos4i = null;
    
    public static void glRasterPos4iv(int* v) { QGLFeature.VerifyFunc((nint)_glRasterPos4iv); _glRasterPos4iv(v); }
    internal static delegate* unmanaged<int*, void> _glRasterPos4iv = null;
    
    public static void glRasterPos4s(short x, short y, short z, short w) { QGLFeature.VerifyFunc((nint)_glRasterPos4s); _glRasterPos4s(x, y, z, w); }
    internal static delegate* unmanaged<short, short, short, short, void> _glRasterPos4s = null;
    
    public static void glRasterPos4sv(short* v) { QGLFeature.VerifyFunc((nint)_glRasterPos4sv); _glRasterPos4sv(v); }
    internal static delegate* unmanaged<short*, void> _glRasterPos4sv = null;
    
    public static void glRectd(double x1, double y1, double x2, double y2) { QGLFeature.VerifyFunc((nint)_glRectd); _glRectd(x1, y1, x2, y2); }
    internal static delegate* unmanaged<double, double, double, double, void> _glRectd = null;
    
    public static void glRectdv(double* v1, double* v2) { QGLFeature.VerifyFunc((nint)_glRectdv); _glRectdv(v1, v2); }
    internal static delegate* unmanaged<double*, double*, void> _glRectdv = null;
    
    public static void glRectf(float x1, float y1, float x2, float y2) { QGLFeature.VerifyFunc((nint)_glRectf); _glRectf(x1, y1, x2, y2); }
    internal static delegate* unmanaged<float, float, float, float, void> _glRectf = null;
    
    public static void glRectfv(float* v1, float* v2) { QGLFeature.VerifyFunc((nint)_glRectfv); _glRectfv(v1, v2); }
    internal static delegate* unmanaged<float*, float*, void> _glRectfv = null;
    
    public static void glRecti(int x1, int y1, int x2, int y2) { QGLFeature.VerifyFunc((nint)_glRecti); _glRecti(x1, y1, x2, y2); }
    internal static delegate* unmanaged<int, int, int, int, void> _glRecti = null;
    
    public static void glRectiv(int* v1, int* v2) { QGLFeature.VerifyFunc((nint)_glRectiv); _glRectiv(v1, v2); }
    internal static delegate* unmanaged<int*, int*, void> _glRectiv = null;
    
    public static void glRects(short x1, short y1, short x2, short y2) { QGLFeature.VerifyFunc((nint)_glRects); _glRects(x1, y1, x2, y2); }
    internal static delegate* unmanaged<short, short, short, short, void> _glRects = null;
    
    public static void glRectsv(short* v1, short* v2) { QGLFeature.VerifyFunc((nint)_glRectsv); _glRectsv(v1, v2); }
    internal static delegate* unmanaged<short*, short*, void> _glRectsv = null;
    
    public static void glTexCoord1d(double s) { QGLFeature.VerifyFunc((nint)_glTexCoord1d); _glTexCoord1d(s); }
    internal static delegate* unmanaged<double, void> _glTexCoord1d = null;
    
    public static void glTexCoord1dv(double* v) { QGLFeature.VerifyFunc((nint)_glTexCoord1dv); _glTexCoord1dv(v); }
    internal static delegate* unmanaged<double*, void> _glTexCoord1dv = null;
    
    public static void glTexCoord1f(float s) { QGLFeature.VerifyFunc((nint)_glTexCoord1f); _glTexCoord1f(s); }
    internal static delegate* unmanaged<float, void> _glTexCoord1f = null;
    
    public static void glTexCoord1fv(float* v) { QGLFeature.VerifyFunc((nint)_glTexCoord1fv); _glTexCoord1fv(v); }
    internal static delegate* unmanaged<float*, void> _glTexCoord1fv = null;
    
    public static void glTexCoord1i(int s) { QGLFeature.VerifyFunc((nint)_glTexCoord1i); _glTexCoord1i(s); }
    internal static delegate* unmanaged<int, void> _glTexCoord1i = null;
    
    public static void glTexCoord1iv(int* v) { QGLFeature.VerifyFunc((nint)_glTexCoord1iv); _glTexCoord1iv(v); }
    internal static delegate* unmanaged<int*, void> _glTexCoord1iv = null;
    
    public static void glTexCoord1s(short s) { QGLFeature.VerifyFunc((nint)_glTexCoord1s); _glTexCoord1s(s); }
    internal static delegate* unmanaged<short, void> _glTexCoord1s = null;
    
    public static void glTexCoord1sv(short* v) { QGLFeature.VerifyFunc((nint)_glTexCoord1sv); _glTexCoord1sv(v); }
    internal static delegate* unmanaged<short*, void> _glTexCoord1sv = null;
    
    public static void glTexCoord2d(double s, double t) { QGLFeature.VerifyFunc((nint)_glTexCoord2d); _glTexCoord2d(s, t); }
    internal static delegate* unmanaged<double, double, void> _glTexCoord2d = null;
    
    public static void glTexCoord2dv(double* v) { QGLFeature.VerifyFunc((nint)_glTexCoord2dv); _glTexCoord2dv(v); }
    internal static delegate* unmanaged<double*, void> _glTexCoord2dv = null;
    
    public static void glTexCoord2f(float s, float t) { QGLFeature.VerifyFunc((nint)_glTexCoord2f); _glTexCoord2f(s, t); }
    internal static delegate* unmanaged<float, float, void> _glTexCoord2f = null;
    
    public static void glTexCoord2fv(float* v) { QGLFeature.VerifyFunc((nint)_glTexCoord2fv); _glTexCoord2fv(v); }
    internal static delegate* unmanaged<float*, void> _glTexCoord2fv = null;
    
    public static void glTexCoord2i(int s, int t) { QGLFeature.VerifyFunc((nint)_glTexCoord2i); _glTexCoord2i(s, t); }
    internal static delegate* unmanaged<int, int, void> _glTexCoord2i = null;
    
    public static void glTexCoord2iv(int* v) { QGLFeature.VerifyFunc((nint)_glTexCoord2iv); _glTexCoord2iv(v); }
    internal static delegate* unmanaged<int*, void> _glTexCoord2iv = null;
    
    public static void glTexCoord2s(short s, short t) { QGLFeature.VerifyFunc((nint)_glTexCoord2s); _glTexCoord2s(s, t); }
    internal static delegate* unmanaged<short, short, void> _glTexCoord2s = null;
    
    public static void glTexCoord2sv(short* v) { QGLFeature.VerifyFunc((nint)_glTexCoord2sv); _glTexCoord2sv(v); }
    internal static delegate* unmanaged<short*, void> _glTexCoord2sv = null;
    
    public static void glTexCoord3d(double s, double t, double r) { QGLFeature.VerifyFunc((nint)_glTexCoord3d); _glTexCoord3d(s, t, r); }
    internal static delegate* unmanaged<double, double, double, void> _glTexCoord3d = null;
    
    public static void glTexCoord3dv(double* v) { QGLFeature.VerifyFunc((nint)_glTexCoord3dv); _glTexCoord3dv(v); }
    internal static delegate* unmanaged<double*, void> _glTexCoord3dv = null;
    
    public static void glTexCoord3f(float s, float t, float r) { QGLFeature.VerifyFunc((nint)_glTexCoord3f); _glTexCoord3f(s, t, r); }
    internal static delegate* unmanaged<float, float, float, void> _glTexCoord3f = null;
    
    public static void glTexCoord3fv(float* v) { QGLFeature.VerifyFunc((nint)_glTexCoord3fv); _glTexCoord3fv(v); }
    internal static delegate* unmanaged<float*, void> _glTexCoord3fv = null;
    
    public static void glTexCoord3i(int s, int t, int r) { QGLFeature.VerifyFunc((nint)_glTexCoord3i); _glTexCoord3i(s, t, r); }
    internal static delegate* unmanaged<int, int, int, void> _glTexCoord3i = null;
    
    public static void glTexCoord3iv(int* v) { QGLFeature.VerifyFunc((nint)_glTexCoord3iv); _glTexCoord3iv(v); }
    internal static delegate* unmanaged<int*, void> _glTexCoord3iv = null;
    
    public static void glTexCoord3s(short s, short t, short r) { QGLFeature.VerifyFunc((nint)_glTexCoord3s); _glTexCoord3s(s, t, r); }
    internal static delegate* unmanaged<short, short, short, void> _glTexCoord3s = null;
    
    public static void glTexCoord3sv(short* v) { QGLFeature.VerifyFunc((nint)_glTexCoord3sv); _glTexCoord3sv(v); }
    internal static delegate* unmanaged<short*, void> _glTexCoord3sv = null;
    
    public static void glTexCoord4d(double s, double t, double r, double q) { QGLFeature.VerifyFunc((nint)_glTexCoord4d); _glTexCoord4d(s, t, r, q); }
    internal static delegate* unmanaged<double, double, double, double, void> _glTexCoord4d = null;
    
    public static void glTexCoord4dv(double* v) { QGLFeature.VerifyFunc((nint)_glTexCoord4dv); _glTexCoord4dv(v); }
    internal static delegate* unmanaged<double*, void> _glTexCoord4dv = null;
    
    public static void glTexCoord4f(float s, float t, float r, float q) { QGLFeature.VerifyFunc((nint)_glTexCoord4f); _glTexCoord4f(s, t, r, q); }
    internal static delegate* unmanaged<float, float, float, float, void> _glTexCoord4f = null;
    
    public static void glTexCoord4fv(float* v) { QGLFeature.VerifyFunc((nint)_glTexCoord4fv); _glTexCoord4fv(v); }
    internal static delegate* unmanaged<float*, void> _glTexCoord4fv = null;
    
    public static void glTexCoord4i(int s, int t, int r, int q) { QGLFeature.VerifyFunc((nint)_glTexCoord4i); _glTexCoord4i(s, t, r, q); }
    internal static delegate* unmanaged<int, int, int, int, void> _glTexCoord4i = null;
    
    public static void glTexCoord4iv(int* v) { QGLFeature.VerifyFunc((nint)_glTexCoord4iv); _glTexCoord4iv(v); }
    internal static delegate* unmanaged<int*, void> _glTexCoord4iv = null;
    
    public static void glTexCoord4s(short s, short t, short r, short q) { QGLFeature.VerifyFunc((nint)_glTexCoord4s); _glTexCoord4s(s, t, r, q); }
    internal static delegate* unmanaged<short, short, short, short, void> _glTexCoord4s = null;
    
    public static void glTexCoord4sv(short* v) { QGLFeature.VerifyFunc((nint)_glTexCoord4sv); _glTexCoord4sv(v); }
    internal static delegate* unmanaged<short*, void> _glTexCoord4sv = null;
    
    public static void glVertex2d(double x, double y) { QGLFeature.VerifyFunc((nint)_glVertex2d); _glVertex2d(x, y); }
    internal static delegate* unmanaged<double, double, void> _glVertex2d = null;
    
    public static void glVertex2dv(double* v) { QGLFeature.VerifyFunc((nint)_glVertex2dv); _glVertex2dv(v); }
    internal static delegate* unmanaged<double*, void> _glVertex2dv = null;
    
    public static void glVertex2f(float x, float y) { QGLFeature.VerifyFunc((nint)_glVertex2f); _glVertex2f(x, y); }
    internal static delegate* unmanaged<float, float, void> _glVertex2f = null;
    
    public static void glVertex2fv(float* v) { QGLFeature.VerifyFunc((nint)_glVertex2fv); _glVertex2fv(v); }
    internal static delegate* unmanaged<float*, void> _glVertex2fv = null;
    
    public static void glVertex2i(int x, int y) { QGLFeature.VerifyFunc((nint)_glVertex2i); _glVertex2i(x, y); }
    internal static delegate* unmanaged<int, int, void> _glVertex2i = null;
    
    public static void glVertex2iv(int* v) { QGLFeature.VerifyFunc((nint)_glVertex2iv); _glVertex2iv(v); }
    internal static delegate* unmanaged<int*, void> _glVertex2iv = null;
    
    public static void glVertex2s(short x, short y) { QGLFeature.VerifyFunc((nint)_glVertex2s); _glVertex2s(x, y); }
    internal static delegate* unmanaged<short, short, void> _glVertex2s = null;
    
    public static void glVertex2sv(short* v) { QGLFeature.VerifyFunc((nint)_glVertex2sv); _glVertex2sv(v); }
    internal static delegate* unmanaged<short*, void> _glVertex2sv = null;
    
    public static void glVertex3d(double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glVertex3d); _glVertex3d(x, y, z); }
    internal static delegate* unmanaged<double, double, double, void> _glVertex3d = null;
    
    public static void glVertex3dv(double* v) { QGLFeature.VerifyFunc((nint)_glVertex3dv); _glVertex3dv(v); }
    internal static delegate* unmanaged<double*, void> _glVertex3dv = null;
    
    public static void glVertex3f(float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glVertex3f); _glVertex3f(x, y, z); }
    internal static delegate* unmanaged<float, float, float, void> _glVertex3f = null;
    
    public static void glVertex3fv(float* v) { QGLFeature.VerifyFunc((nint)_glVertex3fv); _glVertex3fv(v); }
    internal static delegate* unmanaged<float*, void> _glVertex3fv = null;
    
    public static void glVertex3i(int x, int y, int z) { QGLFeature.VerifyFunc((nint)_glVertex3i); _glVertex3i(x, y, z); }
    internal static delegate* unmanaged<int, int, int, void> _glVertex3i = null;
    
    public static void glVertex3iv(int* v) { QGLFeature.VerifyFunc((nint)_glVertex3iv); _glVertex3iv(v); }
    internal static delegate* unmanaged<int*, void> _glVertex3iv = null;
    
    public static void glVertex3s(short x, short y, short z) { QGLFeature.VerifyFunc((nint)_glVertex3s); _glVertex3s(x, y, z); }
    internal static delegate* unmanaged<short, short, short, void> _glVertex3s = null;
    
    public static void glVertex3sv(short* v) { QGLFeature.VerifyFunc((nint)_glVertex3sv); _glVertex3sv(v); }
    internal static delegate* unmanaged<short*, void> _glVertex3sv = null;
    
    public static void glVertex4d(double x, double y, double z, double w) { QGLFeature.VerifyFunc((nint)_glVertex4d); _glVertex4d(x, y, z, w); }
    internal static delegate* unmanaged<double, double, double, double, void> _glVertex4d = null;
    
    public static void glVertex4dv(double* v) { QGLFeature.VerifyFunc((nint)_glVertex4dv); _glVertex4dv(v); }
    internal static delegate* unmanaged<double*, void> _glVertex4dv = null;
    
    public static void glVertex4f(float x, float y, float z, float w) { QGLFeature.VerifyFunc((nint)_glVertex4f); _glVertex4f(x, y, z, w); }
    internal static delegate* unmanaged<float, float, float, float, void> _glVertex4f = null;
    
    public static void glVertex4fv(float* v) { QGLFeature.VerifyFunc((nint)_glVertex4fv); _glVertex4fv(v); }
    internal static delegate* unmanaged<float*, void> _glVertex4fv = null;
    
    public static void glVertex4i(int x, int y, int z, int w) { QGLFeature.VerifyFunc((nint)_glVertex4i); _glVertex4i(x, y, z, w); }
    internal static delegate* unmanaged<int, int, int, int, void> _glVertex4i = null;
    
    public static void glVertex4iv(int* v) { QGLFeature.VerifyFunc((nint)_glVertex4iv); _glVertex4iv(v); }
    internal static delegate* unmanaged<int*, void> _glVertex4iv = null;
    
    public static void glVertex4s(short x, short y, short z, short w) { QGLFeature.VerifyFunc((nint)_glVertex4s); _glVertex4s(x, y, z, w); }
    internal static delegate* unmanaged<short, short, short, short, void> _glVertex4s = null;
    
    public static void glVertex4sv(short* v) { QGLFeature.VerifyFunc((nint)_glVertex4sv); _glVertex4sv(v); }
    internal static delegate* unmanaged<short*, void> _glVertex4sv = null;
    
    public static void glClipPlane(uint plane, double* equation) { QGLFeature.VerifyFunc((nint)_glClipPlane); _glClipPlane(plane, equation); }
    internal static delegate* unmanaged<uint, double*, void> _glClipPlane = null;
    
    public static void glColorMaterial(uint face, uint mode) { QGLFeature.VerifyFunc((nint)_glColorMaterial); _glColorMaterial(face, mode); }
    internal static delegate* unmanaged<uint, uint, void> _glColorMaterial = null;
    
    public static void glFogf(uint pname, float param) { QGLFeature.VerifyFunc((nint)_glFogf); _glFogf(pname, param); }
    internal static delegate* unmanaged<uint, float, void> _glFogf = null;
    
    public static void glFogfv(uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glFogfv); _glFogfv(pname, @params); }
    internal static delegate* unmanaged<uint, float*, void> _glFogfv = null;
    
    public static void glFogi(uint pname, int param) { QGLFeature.VerifyFunc((nint)_glFogi); _glFogi(pname, param); }
    internal static delegate* unmanaged<uint, int, void> _glFogi = null;
    
    public static void glFogiv(uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glFogiv); _glFogiv(pname, @params); }
    internal static delegate* unmanaged<uint, int*, void> _glFogiv = null;
    
    public static void glLightf(uint light, uint pname, float param) { QGLFeature.VerifyFunc((nint)_glLightf); _glLightf(light, pname, param); }
    internal static delegate* unmanaged<uint, uint, float, void> _glLightf = null;
    
    public static void glLightfv(uint light, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glLightfv); _glLightfv(light, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glLightfv = null;
    
    public static void glLighti(uint light, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glLighti); _glLighti(light, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glLighti = null;
    
    public static void glLightiv(uint light, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glLightiv); _glLightiv(light, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glLightiv = null;
    
    public static void glLightModelf(uint pname, float param) { QGLFeature.VerifyFunc((nint)_glLightModelf); _glLightModelf(pname, param); }
    internal static delegate* unmanaged<uint, float, void> _glLightModelf = null;
    
    public static void glLightModelfv(uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glLightModelfv); _glLightModelfv(pname, @params); }
    internal static delegate* unmanaged<uint, float*, void> _glLightModelfv = null;
    
    public static void glLightModeli(uint pname, int param) { QGLFeature.VerifyFunc((nint)_glLightModeli); _glLightModeli(pname, param); }
    internal static delegate* unmanaged<uint, int, void> _glLightModeli = null;
    
    public static void glLightModeliv(uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glLightModeliv); _glLightModeliv(pname, @params); }
    internal static delegate* unmanaged<uint, int*, void> _glLightModeliv = null;
    
    public static void glLineStipple(int factor, ushort pattern) { QGLFeature.VerifyFunc((nint)_glLineStipple); _glLineStipple(factor, pattern); }
    internal static delegate* unmanaged<int, ushort, void> _glLineStipple = null;
    
    public static void glMaterialf(uint face, uint pname, float param) { QGLFeature.VerifyFunc((nint)_glMaterialf); _glMaterialf(face, pname, param); }
    internal static delegate* unmanaged<uint, uint, float, void> _glMaterialf = null;
    
    public static void glMaterialfv(uint face, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glMaterialfv); _glMaterialfv(face, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glMaterialfv = null;
    
    public static void glMateriali(uint face, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glMateriali); _glMateriali(face, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glMateriali = null;
    
    public static void glMaterialiv(uint face, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glMaterialiv); _glMaterialiv(face, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glMaterialiv = null;
    
    public static void glPolygonStipple(byte* mask) { QGLFeature.VerifyFunc((nint)_glPolygonStipple); _glPolygonStipple(mask); }
    internal static delegate* unmanaged<byte*, void> _glPolygonStipple = null;
    
    public static void glShadeModel(uint mode) { QGLFeature.VerifyFunc((nint)_glShadeModel); _glShadeModel(mode); }
    internal static delegate* unmanaged<uint, void> _glShadeModel = null;
    
    public static void glTexEnvf(uint target, uint pname, float param) { QGLFeature.VerifyFunc((nint)_glTexEnvf); _glTexEnvf(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, float, void> _glTexEnvf = null;
    
    public static void glTexEnvfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glTexEnvfv); _glTexEnvfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glTexEnvfv = null;
    
    public static void glTexEnvi(uint target, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glTexEnvi); _glTexEnvi(target, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glTexEnvi = null;
    
    public static void glTexEnviv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glTexEnviv); _glTexEnviv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glTexEnviv = null;
    
    public static void glTexGend(uint coord, uint pname, double param) { QGLFeature.VerifyFunc((nint)_glTexGend); _glTexGend(coord, pname, param); }
    internal static delegate* unmanaged<uint, uint, double, void> _glTexGend = null;
    
    public static void glTexGendv(uint coord, uint pname, double* @params) { QGLFeature.VerifyFunc((nint)_glTexGendv); _glTexGendv(coord, pname, @params); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glTexGendv = null;
    
    public static void glTexGenf(uint coord, uint pname, float param) { QGLFeature.VerifyFunc((nint)_glTexGenf); _glTexGenf(coord, pname, param); }
    internal static delegate* unmanaged<uint, uint, float, void> _glTexGenf = null;
    
    public static void glTexGenfv(uint coord, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glTexGenfv); _glTexGenfv(coord, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glTexGenfv = null;
    
    public static void glTexGeni(uint coord, uint pname, int param) { QGLFeature.VerifyFunc((nint)_glTexGeni); _glTexGeni(coord, pname, param); }
    internal static delegate* unmanaged<uint, uint, int, void> _glTexGeni = null;
    
    public static void glTexGeniv(uint coord, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glTexGeniv); _glTexGeniv(coord, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glTexGeniv = null;
    
    public static void glFeedbackBuffer(int size, uint type, float* buffer) { QGLFeature.VerifyFunc((nint)_glFeedbackBuffer); _glFeedbackBuffer(size, type, buffer); }
    internal static delegate* unmanaged<int, uint, float*, void> _glFeedbackBuffer = null;
    
    public static void glSelectBuffer(int size, uint* buffer) { QGLFeature.VerifyFunc((nint)_glSelectBuffer); _glSelectBuffer(size, buffer); }
    internal static delegate* unmanaged<int, uint*, void> _glSelectBuffer = null;
    
    public static int glRenderMode(uint mode) { QGLFeature.VerifyFunc((nint)_glRenderMode); return _glRenderMode(mode); }
    internal static delegate* unmanaged<uint, int> _glRenderMode = null;
    
    public static void glInitNames() { QGLFeature.VerifyFunc((nint)_glInitNames); _glInitNames(); }
    internal static delegate* unmanaged<void> _glInitNames = null;
    
    public static void glLoadName(uint name) { QGLFeature.VerifyFunc((nint)_glLoadName); _glLoadName(name); }
    internal static delegate* unmanaged<uint, void> _glLoadName = null;
    
    public static void glPassThrough(float token) { QGLFeature.VerifyFunc((nint)_glPassThrough); _glPassThrough(token); }
    internal static delegate* unmanaged<float, void> _glPassThrough = null;
    
    public static void glPopName() { QGLFeature.VerifyFunc((nint)_glPopName); _glPopName(); }
    internal static delegate* unmanaged<void> _glPopName = null;
    
    public static void glPushName(uint name) { QGLFeature.VerifyFunc((nint)_glPushName); _glPushName(name); }
    internal static delegate* unmanaged<uint, void> _glPushName = null;
    
    public static void glClearAccum(float red, float green, float blue, float alpha) { QGLFeature.VerifyFunc((nint)_glClearAccum); _glClearAccum(red, green, blue, alpha); }
    internal static delegate* unmanaged<float, float, float, float, void> _glClearAccum = null;
    
    public static void glClearIndex(float c) { QGLFeature.VerifyFunc((nint)_glClearIndex); _glClearIndex(c); }
    internal static delegate* unmanaged<float, void> _glClearIndex = null;
    
    public static void glIndexMask(uint mask) { QGLFeature.VerifyFunc((nint)_glIndexMask); _glIndexMask(mask); }
    internal static delegate* unmanaged<uint, void> _glIndexMask = null;
    
    public static void glAccum(uint op, float value) { QGLFeature.VerifyFunc((nint)_glAccum); _glAccum(op, value); }
    internal static delegate* unmanaged<uint, float, void> _glAccum = null;
    
    public static void glPopAttrib() { QGLFeature.VerifyFunc((nint)_glPopAttrib); _glPopAttrib(); }
    internal static delegate* unmanaged<void> _glPopAttrib = null;
    
    public static void glPushAttrib(uint mask) { QGLFeature.VerifyFunc((nint)_glPushAttrib); _glPushAttrib(mask); }
    internal static delegate* unmanaged<uint, void> _glPushAttrib = null;
    
    public static void glMap1d(uint target, double u1, double u2, int stride, int order, double* points) { QGLFeature.VerifyFunc((nint)_glMap1d); _glMap1d(target, u1, u2, stride, order, points); }
    internal static delegate* unmanaged<uint, double, double, int, int, double*, void> _glMap1d = null;
    
    public static void glMap1f(uint target, float u1, float u2, int stride, int order, float* points) { QGLFeature.VerifyFunc((nint)_glMap1f); _glMap1f(target, u1, u2, stride, order, points); }
    internal static delegate* unmanaged<uint, float, float, int, int, float*, void> _glMap1f = null;
    
    public static void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points) { QGLFeature.VerifyFunc((nint)_glMap2d); _glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points); }
    internal static delegate* unmanaged<uint, double, double, int, int, double, double, int, int, double*, void> _glMap2d = null;
    
    public static void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points) { QGLFeature.VerifyFunc((nint)_glMap2f); _glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points); }
    internal static delegate* unmanaged<uint, float, float, int, int, float, float, int, int, float*, void> _glMap2f = null;
    
    public static void glMapGrid1d(int un, double u1, double u2) { QGLFeature.VerifyFunc((nint)_glMapGrid1d); _glMapGrid1d(un, u1, u2); }
    internal static delegate* unmanaged<int, double, double, void> _glMapGrid1d = null;
    
    public static void glMapGrid1f(int un, float u1, float u2) { QGLFeature.VerifyFunc((nint)_glMapGrid1f); _glMapGrid1f(un, u1, u2); }
    internal static delegate* unmanaged<int, float, float, void> _glMapGrid1f = null;
    
    public static void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2) { QGLFeature.VerifyFunc((nint)_glMapGrid2d); _glMapGrid2d(un, u1, u2, vn, v1, v2); }
    internal static delegate* unmanaged<int, double, double, int, double, double, void> _glMapGrid2d = null;
    
    public static void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2) { QGLFeature.VerifyFunc((nint)_glMapGrid2f); _glMapGrid2f(un, u1, u2, vn, v1, v2); }
    internal static delegate* unmanaged<int, float, float, int, float, float, void> _glMapGrid2f = null;
    
    public static void glEvalCoord1d(double u) { QGLFeature.VerifyFunc((nint)_glEvalCoord1d); _glEvalCoord1d(u); }
    internal static delegate* unmanaged<double, void> _glEvalCoord1d = null;
    
    public static void glEvalCoord1dv(double* u) { QGLFeature.VerifyFunc((nint)_glEvalCoord1dv); _glEvalCoord1dv(u); }
    internal static delegate* unmanaged<double*, void> _glEvalCoord1dv = null;
    
    public static void glEvalCoord1f(float u) { QGLFeature.VerifyFunc((nint)_glEvalCoord1f); _glEvalCoord1f(u); }
    internal static delegate* unmanaged<float, void> _glEvalCoord1f = null;
    
    public static void glEvalCoord1fv(float* u) { QGLFeature.VerifyFunc((nint)_glEvalCoord1fv); _glEvalCoord1fv(u); }
    internal static delegate* unmanaged<float*, void> _glEvalCoord1fv = null;
    
    public static void glEvalCoord2d(double u, double v) { QGLFeature.VerifyFunc((nint)_glEvalCoord2d); _glEvalCoord2d(u, v); }
    internal static delegate* unmanaged<double, double, void> _glEvalCoord2d = null;
    
    public static void glEvalCoord2dv(double* u) { QGLFeature.VerifyFunc((nint)_glEvalCoord2dv); _glEvalCoord2dv(u); }
    internal static delegate* unmanaged<double*, void> _glEvalCoord2dv = null;
    
    public static void glEvalCoord2f(float u, float v) { QGLFeature.VerifyFunc((nint)_glEvalCoord2f); _glEvalCoord2f(u, v); }
    internal static delegate* unmanaged<float, float, void> _glEvalCoord2f = null;
    
    public static void glEvalCoord2fv(float* u) { QGLFeature.VerifyFunc((nint)_glEvalCoord2fv); _glEvalCoord2fv(u); }
    internal static delegate* unmanaged<float*, void> _glEvalCoord2fv = null;
    
    public static void glEvalMesh1(uint mode, int i1, int i2) { QGLFeature.VerifyFunc((nint)_glEvalMesh1); _glEvalMesh1(mode, i1, i2); }
    internal static delegate* unmanaged<uint, int, int, void> _glEvalMesh1 = null;
    
    public static void glEvalPoint1(int i) { QGLFeature.VerifyFunc((nint)_glEvalPoint1); _glEvalPoint1(i); }
    internal static delegate* unmanaged<int, void> _glEvalPoint1 = null;
    
    public static void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2) { QGLFeature.VerifyFunc((nint)_glEvalMesh2); _glEvalMesh2(mode, i1, i2, j1, j2); }
    internal static delegate* unmanaged<uint, int, int, int, int, void> _glEvalMesh2 = null;
    
    public static void glEvalPoint2(int i, int j) { QGLFeature.VerifyFunc((nint)_glEvalPoint2); _glEvalPoint2(i, j); }
    internal static delegate* unmanaged<int, int, void> _glEvalPoint2 = null;
    
    public static void glAlphaFunc(uint func, float @ref) { QGLFeature.VerifyFunc((nint)_glAlphaFunc); _glAlphaFunc(func, @ref); }
    internal static delegate* unmanaged<uint, float, void> _glAlphaFunc = null;
    
    public static void glPixelZoom(float xfactor, float yfactor) { QGLFeature.VerifyFunc((nint)_glPixelZoom); _glPixelZoom(xfactor, yfactor); }
    internal static delegate* unmanaged<float, float, void> _glPixelZoom = null;
    
    public static void glPixelTransferf(uint pname, float param) { QGLFeature.VerifyFunc((nint)_glPixelTransferf); _glPixelTransferf(pname, param); }
    internal static delegate* unmanaged<uint, float, void> _glPixelTransferf = null;
    
    public static void glPixelTransferi(uint pname, int param) { QGLFeature.VerifyFunc((nint)_glPixelTransferi); _glPixelTransferi(pname, param); }
    internal static delegate* unmanaged<uint, int, void> _glPixelTransferi = null;
    
    public static void glPixelMapfv(uint map, int mapsize, float* values) { QGLFeature.VerifyFunc((nint)_glPixelMapfv); _glPixelMapfv(map, mapsize, values); }
    internal static delegate* unmanaged<uint, int, float*, void> _glPixelMapfv = null;
    
    public static void glPixelMapuiv(uint map, int mapsize, uint* values) { QGLFeature.VerifyFunc((nint)_glPixelMapuiv); _glPixelMapuiv(map, mapsize, values); }
    internal static delegate* unmanaged<uint, int, uint*, void> _glPixelMapuiv = null;
    
    public static void glPixelMapusv(uint map, int mapsize, ushort* values) { QGLFeature.VerifyFunc((nint)_glPixelMapusv); _glPixelMapusv(map, mapsize, values); }
    internal static delegate* unmanaged<uint, int, ushort*, void> _glPixelMapusv = null;
    
    public static void glCopyPixels(int x, int y, int width, int height, uint type) { QGLFeature.VerifyFunc((nint)_glCopyPixels); _glCopyPixels(x, y, width, height, type); }
    internal static delegate* unmanaged<int, int, int, int, uint, void> _glCopyPixels = null;
    
    public static void glDrawPixels(int width, int height, uint format, uint type, void* pixels) { QGLFeature.VerifyFunc((nint)_glDrawPixels); _glDrawPixels(width, height, format, type, pixels); }
    internal static delegate* unmanaged<int, int, uint, uint, void*, void> _glDrawPixels = null;
    
    public static void glGetClipPlane(uint plane, double* equation) { QGLFeature.VerifyFunc((nint)_glGetClipPlane); _glGetClipPlane(plane, equation); }
    internal static delegate* unmanaged<uint, double*, void> _glGetClipPlane = null;
    
    public static void glGetLightfv(uint light, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetLightfv); _glGetLightfv(light, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetLightfv = null;
    
    public static void glGetLightiv(uint light, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetLightiv); _glGetLightiv(light, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetLightiv = null;
    
    public static void glGetMapdv(uint target, uint query, double* v) { QGLFeature.VerifyFunc((nint)_glGetMapdv); _glGetMapdv(target, query, v); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glGetMapdv = null;
    
    public static void glGetMapfv(uint target, uint query, float* v) { QGLFeature.VerifyFunc((nint)_glGetMapfv); _glGetMapfv(target, query, v); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetMapfv = null;
    
    public static void glGetMapiv(uint target, uint query, int* v) { QGLFeature.VerifyFunc((nint)_glGetMapiv); _glGetMapiv(target, query, v); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetMapiv = null;
    
    public static void glGetMaterialfv(uint face, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetMaterialfv); _glGetMaterialfv(face, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetMaterialfv = null;
    
    public static void glGetMaterialiv(uint face, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetMaterialiv); _glGetMaterialiv(face, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetMaterialiv = null;
    
    public static void glGetPixelMapfv(uint map, float* values) { QGLFeature.VerifyFunc((nint)_glGetPixelMapfv); _glGetPixelMapfv(map, values); }
    internal static delegate* unmanaged<uint, float*, void> _glGetPixelMapfv = null;
    
    public static void glGetPixelMapuiv(uint map, uint* values) { QGLFeature.VerifyFunc((nint)_glGetPixelMapuiv); _glGetPixelMapuiv(map, values); }
    internal static delegate* unmanaged<uint, uint*, void> _glGetPixelMapuiv = null;
    
    public static void glGetPixelMapusv(uint map, ushort* values) { QGLFeature.VerifyFunc((nint)_glGetPixelMapusv); _glGetPixelMapusv(map, values); }
    internal static delegate* unmanaged<uint, ushort*, void> _glGetPixelMapusv = null;
    
    public static void glGetPolygonStipple(byte* mask) { QGLFeature.VerifyFunc((nint)_glGetPolygonStipple); _glGetPolygonStipple(mask); }
    internal static delegate* unmanaged<byte*, void> _glGetPolygonStipple = null;
    
    public static void glGetTexEnvfv(uint target, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetTexEnvfv); _glGetTexEnvfv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetTexEnvfv = null;
    
    public static void glGetTexEnviv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetTexEnviv); _glGetTexEnviv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexEnviv = null;
    
    public static void glGetTexGendv(uint coord, uint pname, double* @params) { QGLFeature.VerifyFunc((nint)_glGetTexGendv); _glGetTexGendv(coord, pname, @params); }
    internal static delegate* unmanaged<uint, uint, double*, void> _glGetTexGendv = null;
    
    public static void glGetTexGenfv(uint coord, uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glGetTexGenfv); _glGetTexGenfv(coord, pname, @params); }
    internal static delegate* unmanaged<uint, uint, float*, void> _glGetTexGenfv = null;
    
    public static void glGetTexGeniv(uint coord, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetTexGeniv); _glGetTexGeniv(coord, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetTexGeniv = null;
    
    public static bool glIsList(uint list) { QGLFeature.VerifyFunc((nint)_glIsList); return _glIsList(list); }
    internal static delegate* unmanaged<uint, bool> _glIsList = null;
    
    public static void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar) { QGLFeature.VerifyFunc((nint)_glFrustum); _glFrustum(left, right, bottom, top, zNear, zFar); }
    internal static delegate* unmanaged<double, double, double, double, double, double, void> _glFrustum = null;
    
    public static void glLoadIdentity() { QGLFeature.VerifyFunc((nint)_glLoadIdentity); _glLoadIdentity(); }
    internal static delegate* unmanaged<void> _glLoadIdentity = null;
    
    public static void glLoadMatrixf(float* m) { QGLFeature.VerifyFunc((nint)_glLoadMatrixf); _glLoadMatrixf(m); }
    internal static delegate* unmanaged<float*, void> _glLoadMatrixf = null;
    
    public static void glLoadMatrixd(double* m) { QGLFeature.VerifyFunc((nint)_glLoadMatrixd); _glLoadMatrixd(m); }
    internal static delegate* unmanaged<double*, void> _glLoadMatrixd = null;
    
    public static void glMatrixMode(uint mode) { QGLFeature.VerifyFunc((nint)_glMatrixMode); _glMatrixMode(mode); }
    internal static delegate* unmanaged<uint, void> _glMatrixMode = null;
    
    public static void glMultMatrixf(float* m) { QGLFeature.VerifyFunc((nint)_glMultMatrixf); _glMultMatrixf(m); }
    internal static delegate* unmanaged<float*, void> _glMultMatrixf = null;
    
    public static void glMultMatrixd(double* m) { QGLFeature.VerifyFunc((nint)_glMultMatrixd); _glMultMatrixd(m); }
    internal static delegate* unmanaged<double*, void> _glMultMatrixd = null;
    
    public static void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar) { QGLFeature.VerifyFunc((nint)_glOrtho); _glOrtho(left, right, bottom, top, zNear, zFar); }
    internal static delegate* unmanaged<double, double, double, double, double, double, void> _glOrtho = null;
    
    public static void glPopMatrix() { QGLFeature.VerifyFunc((nint)_glPopMatrix); _glPopMatrix(); }
    internal static delegate* unmanaged<void> _glPopMatrix = null;
    
    public static void glPushMatrix() { QGLFeature.VerifyFunc((nint)_glPushMatrix); _glPushMatrix(); }
    internal static delegate* unmanaged<void> _glPushMatrix = null;
    
    public static void glRotated(double angle, double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glRotated); _glRotated(angle, x, y, z); }
    internal static delegate* unmanaged<double, double, double, double, void> _glRotated = null;
    
    public static void glRotatef(float angle, float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glRotatef); _glRotatef(angle, x, y, z); }
    internal static delegate* unmanaged<float, float, float, float, void> _glRotatef = null;
    
    public static void glScaled(double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glScaled); _glScaled(x, y, z); }
    internal static delegate* unmanaged<double, double, double, void> _glScaled = null;
    
    public static void glScalef(float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glScalef); _glScalef(x, y, z); }
    internal static delegate* unmanaged<float, float, float, void> _glScalef = null;
    
    public static void glTranslated(double x, double y, double z) { QGLFeature.VerifyFunc((nint)_glTranslated); _glTranslated(x, y, z); }
    internal static delegate* unmanaged<double, double, double, void> _glTranslated = null;
    
    public static void glTranslatef(float x, float y, float z) { QGLFeature.VerifyFunc((nint)_glTranslatef); _glTranslatef(x, y, z); }
    internal static delegate* unmanaged<float, float, float, void> _glTranslatef = null;
     #endregion
    
    internal static void Load()
    {
        _glCullFace = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glCullFace");
        _glFrontFace = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glFrontFace");
        _glHint = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glHint");
        _glLineWidth = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glLineWidth");
        _glPointSize = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glPointSize");
        _glPolygonMode = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glPolygonMode");
        _glScissor = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glScissor");
        _glTexParameterf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glTexParameterf");
        _glTexParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glTexParameterfv");
        _glTexParameteri = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glTexParameteri");
        _glTexParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glTexParameteriv");
        _glTexImage1D = (delegate* unmanaged<uint, int, int, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glTexImage1D");
        _glTexImage2D = (delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glTexImage2D");
        _glDrawBuffer = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDrawBuffer");
        _glClear = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glClear");
        _glClearColor = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glClearColor");
        _glClearStencil = (delegate* unmanaged<int, void>)QuickGL.GetGLProcAddress("glClearStencil");
        _glClearDepth = (delegate* unmanaged<double, void>)QuickGL.GetGLProcAddress("glClearDepth");
        _glStencilMask = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glStencilMask");
        _glColorMask = (delegate* unmanaged<bool, bool, bool, bool, void>)QuickGL.GetGLProcAddress("glColorMask");
        _glDepthMask = (delegate* unmanaged<bool, void>)QuickGL.GetGLProcAddress("glDepthMask");
        _glDisable = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDisable");
        _glEnable = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glEnable");
        _glFinish = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glFinish");
        _glFlush = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glFlush");
        _glBlendFunc = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBlendFunc");
        _glLogicOp = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glLogicOp");
        _glStencilFunc = (delegate* unmanaged<uint, int, uint, void>)QuickGL.GetGLProcAddress("glStencilFunc");
        _glStencilOp = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glStencilOp");
        _glDepthFunc = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDepthFunc");
        _glPixelStoref = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glPixelStoref");
        _glPixelStorei = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glPixelStorei");
        _glReadBuffer = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glReadBuffer");
        _glReadPixels = (delegate* unmanaged<int, int, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glReadPixels");
        _glGetBooleanv = (delegate* unmanaged<uint, bool*, void>)QuickGL.GetGLProcAddress("glGetBooleanv");
        _glGetDoublev = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glGetDoublev");
        _glGetError = (delegate* unmanaged<uint>)QuickGL.GetGLProcAddress("glGetError");
        _glGetFloatv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glGetFloatv");
        _glGetIntegerv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glGetIntegerv");
        _glGetString = (delegate* unmanaged<uint, byte*>)QuickGL.GetGLProcAddress("glGetString");
        _glGetTexImage = (delegate* unmanaged<uint, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glGetTexImage");
        _glGetTexParameterfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetTexParameterfv");
        _glGetTexParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetTexParameteriv");
        _glGetTexLevelParameterfv = (delegate* unmanaged<uint, int, uint, float*, void>)QuickGL.GetGLProcAddress("glGetTexLevelParameterfv");
        _glGetTexLevelParameteriv = (delegate* unmanaged<uint, int, uint, int*, void>)QuickGL.GetGLProcAddress("glGetTexLevelParameteriv");
        _glIsEnabled = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsEnabled");
        _glDepthRange = (delegate* unmanaged<double, double, void>)QuickGL.GetGLProcAddress("glDepthRange");
        _glViewport = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glViewport");
        _glNewList = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glNewList");
        _glEndList = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glEndList");
        _glCallList = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glCallList");
        _glCallLists = (delegate* unmanaged<int, uint, void*, void>)QuickGL.GetGLProcAddress("glCallLists");
        _glDeleteLists = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glDeleteLists");
        _glGenLists = (delegate* unmanaged<int, uint>)QuickGL.GetGLProcAddress("glGenLists");
        _glListBase = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glListBase");
        _glBegin = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glBegin");
        _glBitmap = (delegate* unmanaged<int, int, float, float, float, float, byte*, void>)QuickGL.GetGLProcAddress("glBitmap");
        _glColor3b = (delegate* unmanaged<sbyte, sbyte, sbyte, void>)QuickGL.GetGLProcAddress("glColor3b");
        _glColor3bv = (delegate* unmanaged<sbyte*, void>)QuickGL.GetGLProcAddress("glColor3bv");
        _glColor3d = (delegate* unmanaged<double, double, double, void>)QuickGL.GetGLProcAddress("glColor3d");
        _glColor3dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glColor3dv");
        _glColor3f = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glColor3f");
        _glColor3fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glColor3fv");
        _glColor3i = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glColor3i");
        _glColor3iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glColor3iv");
        _glColor3s = (delegate* unmanaged<short, short, short, void>)QuickGL.GetGLProcAddress("glColor3s");
        _glColor3sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glColor3sv");
        _glColor3ub = (delegate* unmanaged<byte, byte, byte, void>)QuickGL.GetGLProcAddress("glColor3ub");
        _glColor3ubv = (delegate* unmanaged<byte*, void>)QuickGL.GetGLProcAddress("glColor3ubv");
        _glColor3ui = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glColor3ui");
        _glColor3uiv = (delegate* unmanaged<uint*, void>)QuickGL.GetGLProcAddress("glColor3uiv");
        _glColor3us = (delegate* unmanaged<ushort, ushort, ushort, void>)QuickGL.GetGLProcAddress("glColor3us");
        _glColor3usv = (delegate* unmanaged<ushort*, void>)QuickGL.GetGLProcAddress("glColor3usv");
        _glColor4b = (delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void>)QuickGL.GetGLProcAddress("glColor4b");
        _glColor4bv = (delegate* unmanaged<sbyte*, void>)QuickGL.GetGLProcAddress("glColor4bv");
        _glColor4d = (delegate* unmanaged<double, double, double, double, void>)QuickGL.GetGLProcAddress("glColor4d");
        _glColor4dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glColor4dv");
        _glColor4f = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glColor4f");
        _glColor4fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glColor4fv");
        _glColor4i = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glColor4i");
        _glColor4iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glColor4iv");
        _glColor4s = (delegate* unmanaged<short, short, short, short, void>)QuickGL.GetGLProcAddress("glColor4s");
        _glColor4sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glColor4sv");
        _glColor4ub = (delegate* unmanaged<byte, byte, byte, byte, void>)QuickGL.GetGLProcAddress("glColor4ub");
        _glColor4ubv = (delegate* unmanaged<byte*, void>)QuickGL.GetGLProcAddress("glColor4ubv");
        _glColor4ui = (delegate* unmanaged<uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glColor4ui");
        _glColor4uiv = (delegate* unmanaged<uint*, void>)QuickGL.GetGLProcAddress("glColor4uiv");
        _glColor4us = (delegate* unmanaged<ushort, ushort, ushort, ushort, void>)QuickGL.GetGLProcAddress("glColor4us");
        _glColor4usv = (delegate* unmanaged<ushort*, void>)QuickGL.GetGLProcAddress("glColor4usv");
        _glEdgeFlag = (delegate* unmanaged<bool, void>)QuickGL.GetGLProcAddress("glEdgeFlag");
        _glEdgeFlagv = (delegate* unmanaged<bool*, void>)QuickGL.GetGLProcAddress("glEdgeFlagv");
        _glEnd = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glEnd");
        _glIndexd = (delegate* unmanaged<double, void>)QuickGL.GetGLProcAddress("glIndexd");
        _glIndexdv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glIndexdv");
        _glIndexf = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glIndexf");
        _glIndexfv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glIndexfv");
        _glIndexi = (delegate* unmanaged<int, void>)QuickGL.GetGLProcAddress("glIndexi");
        _glIndexiv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glIndexiv");
        _glIndexs = (delegate* unmanaged<short, void>)QuickGL.GetGLProcAddress("glIndexs");
        _glIndexsv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glIndexsv");
        _glNormal3b = (delegate* unmanaged<sbyte, sbyte, sbyte, void>)QuickGL.GetGLProcAddress("glNormal3b");
        _glNormal3bv = (delegate* unmanaged<sbyte*, void>)QuickGL.GetGLProcAddress("glNormal3bv");
        _glNormal3d = (delegate* unmanaged<double, double, double, void>)QuickGL.GetGLProcAddress("glNormal3d");
        _glNormal3dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glNormal3dv");
        _glNormal3f = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glNormal3f");
        _glNormal3fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glNormal3fv");
        _glNormal3i = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glNormal3i");
        _glNormal3iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glNormal3iv");
        _glNormal3s = (delegate* unmanaged<short, short, short, void>)QuickGL.GetGLProcAddress("glNormal3s");
        _glNormal3sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glNormal3sv");
        _glRasterPos2d = (delegate* unmanaged<double, double, void>)QuickGL.GetGLProcAddress("glRasterPos2d");
        _glRasterPos2dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glRasterPos2dv");
        _glRasterPos2f = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glRasterPos2f");
        _glRasterPos2fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glRasterPos2fv");
        _glRasterPos2i = (delegate* unmanaged<int, int, void>)QuickGL.GetGLProcAddress("glRasterPos2i");
        _glRasterPos2iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glRasterPos2iv");
        _glRasterPos2s = (delegate* unmanaged<short, short, void>)QuickGL.GetGLProcAddress("glRasterPos2s");
        _glRasterPos2sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glRasterPos2sv");
        _glRasterPos3d = (delegate* unmanaged<double, double, double, void>)QuickGL.GetGLProcAddress("glRasterPos3d");
        _glRasterPos3dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glRasterPos3dv");
        _glRasterPos3f = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glRasterPos3f");
        _glRasterPos3fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glRasterPos3fv");
        _glRasterPos3i = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glRasterPos3i");
        _glRasterPos3iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glRasterPos3iv");
        _glRasterPos3s = (delegate* unmanaged<short, short, short, void>)QuickGL.GetGLProcAddress("glRasterPos3s");
        _glRasterPos3sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glRasterPos3sv");
        _glRasterPos4d = (delegate* unmanaged<double, double, double, double, void>)QuickGL.GetGLProcAddress("glRasterPos4d");
        _glRasterPos4dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glRasterPos4dv");
        _glRasterPos4f = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glRasterPos4f");
        _glRasterPos4fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glRasterPos4fv");
        _glRasterPos4i = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glRasterPos4i");
        _glRasterPos4iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glRasterPos4iv");
        _glRasterPos4s = (delegate* unmanaged<short, short, short, short, void>)QuickGL.GetGLProcAddress("glRasterPos4s");
        _glRasterPos4sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glRasterPos4sv");
        _glRectd = (delegate* unmanaged<double, double, double, double, void>)QuickGL.GetGLProcAddress("glRectd");
        _glRectdv = (delegate* unmanaged<double*, double*, void>)QuickGL.GetGLProcAddress("glRectdv");
        _glRectf = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glRectf");
        _glRectfv = (delegate* unmanaged<float*, float*, void>)QuickGL.GetGLProcAddress("glRectfv");
        _glRecti = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glRecti");
        _glRectiv = (delegate* unmanaged<int*, int*, void>)QuickGL.GetGLProcAddress("glRectiv");
        _glRects = (delegate* unmanaged<short, short, short, short, void>)QuickGL.GetGLProcAddress("glRects");
        _glRectsv = (delegate* unmanaged<short*, short*, void>)QuickGL.GetGLProcAddress("glRectsv");
        _glTexCoord1d = (delegate* unmanaged<double, void>)QuickGL.GetGLProcAddress("glTexCoord1d");
        _glTexCoord1dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glTexCoord1dv");
        _glTexCoord1f = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glTexCoord1f");
        _glTexCoord1fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glTexCoord1fv");
        _glTexCoord1i = (delegate* unmanaged<int, void>)QuickGL.GetGLProcAddress("glTexCoord1i");
        _glTexCoord1iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glTexCoord1iv");
        _glTexCoord1s = (delegate* unmanaged<short, void>)QuickGL.GetGLProcAddress("glTexCoord1s");
        _glTexCoord1sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glTexCoord1sv");
        _glTexCoord2d = (delegate* unmanaged<double, double, void>)QuickGL.GetGLProcAddress("glTexCoord2d");
        _glTexCoord2dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glTexCoord2dv");
        _glTexCoord2f = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glTexCoord2f");
        _glTexCoord2fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glTexCoord2fv");
        _glTexCoord2i = (delegate* unmanaged<int, int, void>)QuickGL.GetGLProcAddress("glTexCoord2i");
        _glTexCoord2iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glTexCoord2iv");
        _glTexCoord2s = (delegate* unmanaged<short, short, void>)QuickGL.GetGLProcAddress("glTexCoord2s");
        _glTexCoord2sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glTexCoord2sv");
        _glTexCoord3d = (delegate* unmanaged<double, double, double, void>)QuickGL.GetGLProcAddress("glTexCoord3d");
        _glTexCoord3dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glTexCoord3dv");
        _glTexCoord3f = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glTexCoord3f");
        _glTexCoord3fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glTexCoord3fv");
        _glTexCoord3i = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glTexCoord3i");
        _glTexCoord3iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glTexCoord3iv");
        _glTexCoord3s = (delegate* unmanaged<short, short, short, void>)QuickGL.GetGLProcAddress("glTexCoord3s");
        _glTexCoord3sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glTexCoord3sv");
        _glTexCoord4d = (delegate* unmanaged<double, double, double, double, void>)QuickGL.GetGLProcAddress("glTexCoord4d");
        _glTexCoord4dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glTexCoord4dv");
        _glTexCoord4f = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glTexCoord4f");
        _glTexCoord4fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glTexCoord4fv");
        _glTexCoord4i = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glTexCoord4i");
        _glTexCoord4iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glTexCoord4iv");
        _glTexCoord4s = (delegate* unmanaged<short, short, short, short, void>)QuickGL.GetGLProcAddress("glTexCoord4s");
        _glTexCoord4sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glTexCoord4sv");
        _glVertex2d = (delegate* unmanaged<double, double, void>)QuickGL.GetGLProcAddress("glVertex2d");
        _glVertex2dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glVertex2dv");
        _glVertex2f = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glVertex2f");
        _glVertex2fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glVertex2fv");
        _glVertex2i = (delegate* unmanaged<int, int, void>)QuickGL.GetGLProcAddress("glVertex2i");
        _glVertex2iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glVertex2iv");
        _glVertex2s = (delegate* unmanaged<short, short, void>)QuickGL.GetGLProcAddress("glVertex2s");
        _glVertex2sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glVertex2sv");
        _glVertex3d = (delegate* unmanaged<double, double, double, void>)QuickGL.GetGLProcAddress("glVertex3d");
        _glVertex3dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glVertex3dv");
        _glVertex3f = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glVertex3f");
        _glVertex3fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glVertex3fv");
        _glVertex3i = (delegate* unmanaged<int, int, int, void>)QuickGL.GetGLProcAddress("glVertex3i");
        _glVertex3iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glVertex3iv");
        _glVertex3s = (delegate* unmanaged<short, short, short, void>)QuickGL.GetGLProcAddress("glVertex3s");
        _glVertex3sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glVertex3sv");
        _glVertex4d = (delegate* unmanaged<double, double, double, double, void>)QuickGL.GetGLProcAddress("glVertex4d");
        _glVertex4dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glVertex4dv");
        _glVertex4f = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glVertex4f");
        _glVertex4fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glVertex4fv");
        _glVertex4i = (delegate* unmanaged<int, int, int, int, void>)QuickGL.GetGLProcAddress("glVertex4i");
        _glVertex4iv = (delegate* unmanaged<int*, void>)QuickGL.GetGLProcAddress("glVertex4iv");
        _glVertex4s = (delegate* unmanaged<short, short, short, short, void>)QuickGL.GetGLProcAddress("glVertex4s");
        _glVertex4sv = (delegate* unmanaged<short*, void>)QuickGL.GetGLProcAddress("glVertex4sv");
        _glClipPlane = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glClipPlane");
        _glColorMaterial = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glColorMaterial");
        _glFogf = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glFogf");
        _glFogfv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glFogfv");
        _glFogi = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glFogi");
        _glFogiv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glFogiv");
        _glLightf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glLightf");
        _glLightfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glLightfv");
        _glLighti = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glLighti");
        _glLightiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glLightiv");
        _glLightModelf = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glLightModelf");
        _glLightModelfv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glLightModelfv");
        _glLightModeli = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glLightModeli");
        _glLightModeliv = (delegate* unmanaged<uint, int*, void>)QuickGL.GetGLProcAddress("glLightModeliv");
        _glLineStipple = (delegate* unmanaged<int, ushort, void>)QuickGL.GetGLProcAddress("glLineStipple");
        _glMaterialf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glMaterialf");
        _glMaterialfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glMaterialfv");
        _glMateriali = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glMateriali");
        _glMaterialiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glMaterialiv");
        _glPolygonStipple = (delegate* unmanaged<byte*, void>)QuickGL.GetGLProcAddress("glPolygonStipple");
        _glShadeModel = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glShadeModel");
        _glTexEnvf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glTexEnvf");
        _glTexEnvfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glTexEnvfv");
        _glTexEnvi = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glTexEnvi");
        _glTexEnviv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glTexEnviv");
        _glTexGend = (delegate* unmanaged<uint, uint, double, void>)QuickGL.GetGLProcAddress("glTexGend");
        _glTexGendv = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glTexGendv");
        _glTexGenf = (delegate* unmanaged<uint, uint, float, void>)QuickGL.GetGLProcAddress("glTexGenf");
        _glTexGenfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glTexGenfv");
        _glTexGeni = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glTexGeni");
        _glTexGeniv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glTexGeniv");
        _glFeedbackBuffer = (delegate* unmanaged<int, uint, float*, void>)QuickGL.GetGLProcAddress("glFeedbackBuffer");
        _glSelectBuffer = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glSelectBuffer");
        _glRenderMode = (delegate* unmanaged<uint, int>)QuickGL.GetGLProcAddress("glRenderMode");
        _glInitNames = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glInitNames");
        _glLoadName = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glLoadName");
        _glPassThrough = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glPassThrough");
        _glPopName = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glPopName");
        _glPushName = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glPushName");
        _glClearAccum = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glClearAccum");
        _glClearIndex = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glClearIndex");
        _glIndexMask = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glIndexMask");
        _glAccum = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glAccum");
        _glPopAttrib = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glPopAttrib");
        _glPushAttrib = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glPushAttrib");
        _glMap1d = (delegate* unmanaged<uint, double, double, int, int, double*, void>)QuickGL.GetGLProcAddress("glMap1d");
        _glMap1f = (delegate* unmanaged<uint, float, float, int, int, float*, void>)QuickGL.GetGLProcAddress("glMap1f");
        _glMap2d = (delegate* unmanaged<uint, double, double, int, int, double, double, int, int, double*, void>)QuickGL.GetGLProcAddress("glMap2d");
        _glMap2f = (delegate* unmanaged<uint, float, float, int, int, float, float, int, int, float*, void>)QuickGL.GetGLProcAddress("glMap2f");
        _glMapGrid1d = (delegate* unmanaged<int, double, double, void>)QuickGL.GetGLProcAddress("glMapGrid1d");
        _glMapGrid1f = (delegate* unmanaged<int, float, float, void>)QuickGL.GetGLProcAddress("glMapGrid1f");
        _glMapGrid2d = (delegate* unmanaged<int, double, double, int, double, double, void>)QuickGL.GetGLProcAddress("glMapGrid2d");
        _glMapGrid2f = (delegate* unmanaged<int, float, float, int, float, float, void>)QuickGL.GetGLProcAddress("glMapGrid2f");
        _glEvalCoord1d = (delegate* unmanaged<double, void>)QuickGL.GetGLProcAddress("glEvalCoord1d");
        _glEvalCoord1dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glEvalCoord1dv");
        _glEvalCoord1f = (delegate* unmanaged<float, void>)QuickGL.GetGLProcAddress("glEvalCoord1f");
        _glEvalCoord1fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glEvalCoord1fv");
        _glEvalCoord2d = (delegate* unmanaged<double, double, void>)QuickGL.GetGLProcAddress("glEvalCoord2d");
        _glEvalCoord2dv = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glEvalCoord2dv");
        _glEvalCoord2f = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glEvalCoord2f");
        _glEvalCoord2fv = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glEvalCoord2fv");
        _glEvalMesh1 = (delegate* unmanaged<uint, int, int, void>)QuickGL.GetGLProcAddress("glEvalMesh1");
        _glEvalPoint1 = (delegate* unmanaged<int, void>)QuickGL.GetGLProcAddress("glEvalPoint1");
        _glEvalMesh2 = (delegate* unmanaged<uint, int, int, int, int, void>)QuickGL.GetGLProcAddress("glEvalMesh2");
        _glEvalPoint2 = (delegate* unmanaged<int, int, void>)QuickGL.GetGLProcAddress("glEvalPoint2");
        _glAlphaFunc = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glAlphaFunc");
        _glPixelZoom = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glPixelZoom");
        _glPixelTransferf = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glPixelTransferf");
        _glPixelTransferi = (delegate* unmanaged<uint, int, void>)QuickGL.GetGLProcAddress("glPixelTransferi");
        _glPixelMapfv = (delegate* unmanaged<uint, int, float*, void>)QuickGL.GetGLProcAddress("glPixelMapfv");
        _glPixelMapuiv = (delegate* unmanaged<uint, int, uint*, void>)QuickGL.GetGLProcAddress("glPixelMapuiv");
        _glPixelMapusv = (delegate* unmanaged<uint, int, ushort*, void>)QuickGL.GetGLProcAddress("glPixelMapusv");
        _glCopyPixels = (delegate* unmanaged<int, int, int, int, uint, void>)QuickGL.GetGLProcAddress("glCopyPixels");
        _glDrawPixels = (delegate* unmanaged<int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glDrawPixels");
        _glGetClipPlane = (delegate* unmanaged<uint, double*, void>)QuickGL.GetGLProcAddress("glGetClipPlane");
        _glGetLightfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetLightfv");
        _glGetLightiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetLightiv");
        _glGetMapdv = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glGetMapdv");
        _glGetMapfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetMapfv");
        _glGetMapiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetMapiv");
        _glGetMaterialfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetMaterialfv");
        _glGetMaterialiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetMaterialiv");
        _glGetPixelMapfv = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glGetPixelMapfv");
        _glGetPixelMapuiv = (delegate* unmanaged<uint, uint*, void>)QuickGL.GetGLProcAddress("glGetPixelMapuiv");
        _glGetPixelMapusv = (delegate* unmanaged<uint, ushort*, void>)QuickGL.GetGLProcAddress("glGetPixelMapusv");
        _glGetPolygonStipple = (delegate* unmanaged<byte*, void>)QuickGL.GetGLProcAddress("glGetPolygonStipple");
        _glGetTexEnvfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetTexEnvfv");
        _glGetTexEnviv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetTexEnviv");
        _glGetTexGendv = (delegate* unmanaged<uint, uint, double*, void>)QuickGL.GetGLProcAddress("glGetTexGendv");
        _glGetTexGenfv = (delegate* unmanaged<uint, uint, float*, void>)QuickGL.GetGLProcAddress("glGetTexGenfv");
        _glGetTexGeniv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetTexGeniv");
        _glIsList = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsList");
        _glFrustum = (delegate* unmanaged<double, double, double, double, double, double, void>)QuickGL.GetGLProcAddress("glFrustum");
        _glLoadIdentity = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glLoadIdentity");
        _glLoadMatrixf = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glLoadMatrixf");
        _glLoadMatrixd = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glLoadMatrixd");
        _glMatrixMode = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glMatrixMode");
        _glMultMatrixf = (delegate* unmanaged<float*, void>)QuickGL.GetGLProcAddress("glMultMatrixf");
        _glMultMatrixd = (delegate* unmanaged<double*, void>)QuickGL.GetGLProcAddress("glMultMatrixd");
        _glOrtho = (delegate* unmanaged<double, double, double, double, double, double, void>)QuickGL.GetGLProcAddress("glOrtho");
        _glPopMatrix = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glPopMatrix");
        _glPushMatrix = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glPushMatrix");
        _glRotated = (delegate* unmanaged<double, double, double, double, void>)QuickGL.GetGLProcAddress("glRotated");
        _glRotatef = (delegate* unmanaged<float, float, float, float, void>)QuickGL.GetGLProcAddress("glRotatef");
        _glScaled = (delegate* unmanaged<double, double, double, void>)QuickGL.GetGLProcAddress("glScaled");
        _glScalef = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glScalef");
        _glTranslated = (delegate* unmanaged<double, double, double, void>)QuickGL.GetGLProcAddress("glTranslated");
        _glTranslatef = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glTranslatef");
    }
    
    internal static void Unload()
    {
        _glCullFace = null;
        _glFrontFace = null;
        _glHint = null;
        _glLineWidth = null;
        _glPointSize = null;
        _glPolygonMode = null;
        _glScissor = null;
        _glTexParameterf = null;
        _glTexParameterfv = null;
        _glTexParameteri = null;
        _glTexParameteriv = null;
        _glTexImage1D = null;
        _glTexImage2D = null;
        _glDrawBuffer = null;
        _glClear = null;
        _glClearColor = null;
        _glClearStencil = null;
        _glClearDepth = null;
        _glStencilMask = null;
        _glColorMask = null;
        _glDepthMask = null;
        _glDisable = null;
        _glEnable = null;
        _glFinish = null;
        _glFlush = null;
        _glBlendFunc = null;
        _glLogicOp = null;
        _glStencilFunc = null;
        _glStencilOp = null;
        _glDepthFunc = null;
        _glPixelStoref = null;
        _glPixelStorei = null;
        _glReadBuffer = null;
        _glReadPixels = null;
        _glGetBooleanv = null;
        _glGetDoublev = null;
        _glGetError = null;
        _glGetFloatv = null;
        _glGetIntegerv = null;
        _glGetString = null;
        _glGetTexImage = null;
        _glGetTexParameterfv = null;
        _glGetTexParameteriv = null;
        _glGetTexLevelParameterfv = null;
        _glGetTexLevelParameteriv = null;
        _glIsEnabled = null;
        _glDepthRange = null;
        _glViewport = null;
        _glNewList = null;
        _glEndList = null;
        _glCallList = null;
        _glCallLists = null;
        _glDeleteLists = null;
        _glGenLists = null;
        _glListBase = null;
        _glBegin = null;
        _glBitmap = null;
        _glColor3b = null;
        _glColor3bv = null;
        _glColor3d = null;
        _glColor3dv = null;
        _glColor3f = null;
        _glColor3fv = null;
        _glColor3i = null;
        _glColor3iv = null;
        _glColor3s = null;
        _glColor3sv = null;
        _glColor3ub = null;
        _glColor3ubv = null;
        _glColor3ui = null;
        _glColor3uiv = null;
        _glColor3us = null;
        _glColor3usv = null;
        _glColor4b = null;
        _glColor4bv = null;
        _glColor4d = null;
        _glColor4dv = null;
        _glColor4f = null;
        _glColor4fv = null;
        _glColor4i = null;
        _glColor4iv = null;
        _glColor4s = null;
        _glColor4sv = null;
        _glColor4ub = null;
        _glColor4ubv = null;
        _glColor4ui = null;
        _glColor4uiv = null;
        _glColor4us = null;
        _glColor4usv = null;
        _glEdgeFlag = null;
        _glEdgeFlagv = null;
        _glEnd = null;
        _glIndexd = null;
        _glIndexdv = null;
        _glIndexf = null;
        _glIndexfv = null;
        _glIndexi = null;
        _glIndexiv = null;
        _glIndexs = null;
        _glIndexsv = null;
        _glNormal3b = null;
        _glNormal3bv = null;
        _glNormal3d = null;
        _glNormal3dv = null;
        _glNormal3f = null;
        _glNormal3fv = null;
        _glNormal3i = null;
        _glNormal3iv = null;
        _glNormal3s = null;
        _glNormal3sv = null;
        _glRasterPos2d = null;
        _glRasterPos2dv = null;
        _glRasterPos2f = null;
        _glRasterPos2fv = null;
        _glRasterPos2i = null;
        _glRasterPos2iv = null;
        _glRasterPos2s = null;
        _glRasterPos2sv = null;
        _glRasterPos3d = null;
        _glRasterPos3dv = null;
        _glRasterPos3f = null;
        _glRasterPos3fv = null;
        _glRasterPos3i = null;
        _glRasterPos3iv = null;
        _glRasterPos3s = null;
        _glRasterPos3sv = null;
        _glRasterPos4d = null;
        _glRasterPos4dv = null;
        _glRasterPos4f = null;
        _glRasterPos4fv = null;
        _glRasterPos4i = null;
        _glRasterPos4iv = null;
        _glRasterPos4s = null;
        _glRasterPos4sv = null;
        _glRectd = null;
        _glRectdv = null;
        _glRectf = null;
        _glRectfv = null;
        _glRecti = null;
        _glRectiv = null;
        _glRects = null;
        _glRectsv = null;
        _glTexCoord1d = null;
        _glTexCoord1dv = null;
        _glTexCoord1f = null;
        _glTexCoord1fv = null;
        _glTexCoord1i = null;
        _glTexCoord1iv = null;
        _glTexCoord1s = null;
        _glTexCoord1sv = null;
        _glTexCoord2d = null;
        _glTexCoord2dv = null;
        _glTexCoord2f = null;
        _glTexCoord2fv = null;
        _glTexCoord2i = null;
        _glTexCoord2iv = null;
        _glTexCoord2s = null;
        _glTexCoord2sv = null;
        _glTexCoord3d = null;
        _glTexCoord3dv = null;
        _glTexCoord3f = null;
        _glTexCoord3fv = null;
        _glTexCoord3i = null;
        _glTexCoord3iv = null;
        _glTexCoord3s = null;
        _glTexCoord3sv = null;
        _glTexCoord4d = null;
        _glTexCoord4dv = null;
        _glTexCoord4f = null;
        _glTexCoord4fv = null;
        _glTexCoord4i = null;
        _glTexCoord4iv = null;
        _glTexCoord4s = null;
        _glTexCoord4sv = null;
        _glVertex2d = null;
        _glVertex2dv = null;
        _glVertex2f = null;
        _glVertex2fv = null;
        _glVertex2i = null;
        _glVertex2iv = null;
        _glVertex2s = null;
        _glVertex2sv = null;
        _glVertex3d = null;
        _glVertex3dv = null;
        _glVertex3f = null;
        _glVertex3fv = null;
        _glVertex3i = null;
        _glVertex3iv = null;
        _glVertex3s = null;
        _glVertex3sv = null;
        _glVertex4d = null;
        _glVertex4dv = null;
        _glVertex4f = null;
        _glVertex4fv = null;
        _glVertex4i = null;
        _glVertex4iv = null;
        _glVertex4s = null;
        _glVertex4sv = null;
        _glClipPlane = null;
        _glColorMaterial = null;
        _glFogf = null;
        _glFogfv = null;
        _glFogi = null;
        _glFogiv = null;
        _glLightf = null;
        _glLightfv = null;
        _glLighti = null;
        _glLightiv = null;
        _glLightModelf = null;
        _glLightModelfv = null;
        _glLightModeli = null;
        _glLightModeliv = null;
        _glLineStipple = null;
        _glMaterialf = null;
        _glMaterialfv = null;
        _glMateriali = null;
        _glMaterialiv = null;
        _glPolygonStipple = null;
        _glShadeModel = null;
        _glTexEnvf = null;
        _glTexEnvfv = null;
        _glTexEnvi = null;
        _glTexEnviv = null;
        _glTexGend = null;
        _glTexGendv = null;
        _glTexGenf = null;
        _glTexGenfv = null;
        _glTexGeni = null;
        _glTexGeniv = null;
        _glFeedbackBuffer = null;
        _glSelectBuffer = null;
        _glRenderMode = null;
        _glInitNames = null;
        _glLoadName = null;
        _glPassThrough = null;
        _glPopName = null;
        _glPushName = null;
        _glClearAccum = null;
        _glClearIndex = null;
        _glIndexMask = null;
        _glAccum = null;
        _glPopAttrib = null;
        _glPushAttrib = null;
        _glMap1d = null;
        _glMap1f = null;
        _glMap2d = null;
        _glMap2f = null;
        _glMapGrid1d = null;
        _glMapGrid1f = null;
        _glMapGrid2d = null;
        _glMapGrid2f = null;
        _glEvalCoord1d = null;
        _glEvalCoord1dv = null;
        _glEvalCoord1f = null;
        _glEvalCoord1fv = null;
        _glEvalCoord2d = null;
        _glEvalCoord2dv = null;
        _glEvalCoord2f = null;
        _glEvalCoord2fv = null;
        _glEvalMesh1 = null;
        _glEvalPoint1 = null;
        _glEvalMesh2 = null;
        _glEvalPoint2 = null;
        _glAlphaFunc = null;
        _glPixelZoom = null;
        _glPixelTransferf = null;
        _glPixelTransferi = null;
        _glPixelMapfv = null;
        _glPixelMapuiv = null;
        _glPixelMapusv = null;
        _glCopyPixels = null;
        _glDrawPixels = null;
        _glGetClipPlane = null;
        _glGetLightfv = null;
        _glGetLightiv = null;
        _glGetMapdv = null;
        _glGetMapfv = null;
        _glGetMapiv = null;
        _glGetMaterialfv = null;
        _glGetMaterialiv = null;
        _glGetPixelMapfv = null;
        _glGetPixelMapuiv = null;
        _glGetPixelMapusv = null;
        _glGetPolygonStipple = null;
        _glGetTexEnvfv = null;
        _glGetTexEnviv = null;
        _glGetTexGendv = null;
        _glGetTexGenfv = null;
        _glGetTexGeniv = null;
        _glIsList = null;
        _glFrustum = null;
        _glLoadIdentity = null;
        _glLoadMatrixf = null;
        _glLoadMatrixd = null;
        _glMatrixMode = null;
        _glMultMatrixf = null;
        _glMultMatrixd = null;
        _glOrtho = null;
        _glPopMatrix = null;
        _glPushMatrix = null;
        _glRotated = null;
        _glRotatef = null;
        _glScaled = null;
        _glScalef = null;
        _glTranslated = null;
        _glTranslatef = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_VERSION_1_0", false, false);
}
