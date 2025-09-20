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

// Bindings generated at 2025-09-20 18:58:19.905395
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBinternalformatquery2
{
    #region Enums
    public const int GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
    public const int GL_NUM_SAMPLE_COUNTS = 0x9380;
    public const int GL_RENDERBUFFER = 0x8D41;
    public const int GL_SAMPLES = 0x80A9;
    public const int GL_TEXTURE_1D = 0xDE0;
    public const int GL_TEXTURE_1D_ARRAY = 0x8C18;
    public const int GL_TEXTURE_2D = 0xDE1;
    public const int GL_TEXTURE_2D_ARRAY = 0x8C1A;
    public const int GL_TEXTURE_3D = 0x806F;
    public const int GL_TEXTURE_CUBE_MAP = 0x8513;
    public const int GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
    public const int GL_TEXTURE_RECTANGLE = 0x84F5;
    public const int GL_TEXTURE_BUFFER = 0x8C2A;
    public const int GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
    public const int GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
    public const int GL_TEXTURE_COMPRESSED = 0x86A1;
    public const int GL_INTERNALFORMAT_SUPPORTED = 0x826F;
    public const int GL_INTERNALFORMAT_PREFERRED = 0x8270;
    public const int GL_INTERNALFORMAT_RED_SIZE = 0x8271;
    public const int GL_INTERNALFORMAT_GREEN_SIZE = 0x8272;
    public const int GL_INTERNALFORMAT_BLUE_SIZE = 0x8273;
    public const int GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274;
    public const int GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275;
    public const int GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276;
    public const int GL_INTERNALFORMAT_SHARED_SIZE = 0x8277;
    public const int GL_INTERNALFORMAT_RED_TYPE = 0x8278;
    public const int GL_INTERNALFORMAT_GREEN_TYPE = 0x8279;
    public const int GL_INTERNALFORMAT_BLUE_TYPE = 0x827A;
    public const int GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B;
    public const int GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C;
    public const int GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D;
    public const int GL_MAX_WIDTH = 0x827E;
    public const int GL_MAX_HEIGHT = 0x827F;
    public const int GL_MAX_DEPTH = 0x8280;
    public const int GL_MAX_LAYERS = 0x8281;
    public const int GL_MAX_COMBINED_DIMENSIONS = 0x8282;
    public const int GL_COLOR_COMPONENTS = 0x8283;
    public const int GL_DEPTH_COMPONENTS = 0x8284;
    public const int GL_STENCIL_COMPONENTS = 0x8285;
    public const int GL_COLOR_RENDERABLE = 0x8286;
    public const int GL_DEPTH_RENDERABLE = 0x8287;
    public const int GL_STENCIL_RENDERABLE = 0x8288;
    public const int GL_FRAMEBUFFER_RENDERABLE = 0x8289;
    public const int GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
    public const int GL_FRAMEBUFFER_BLEND = 0x828B;
    public const int GL_READ_PIXELS = 0x828C;
    public const int GL_READ_PIXELS_FORMAT = 0x828D;
    public const int GL_READ_PIXELS_TYPE = 0x828E;
    public const int GL_TEXTURE_IMAGE_FORMAT = 0x828F;
    public const int GL_TEXTURE_IMAGE_TYPE = 0x8290;
    public const int GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291;
    public const int GL_GET_TEXTURE_IMAGE_TYPE = 0x8292;
    public const int GL_MIPMAP = 0x8293;
    public const int GL_MANUAL_GENERATE_MIPMAP = 0x8294;
    public const int GL_AUTO_GENERATE_MIPMAP = 0x8295;
    public const int GL_COLOR_ENCODING = 0x8296;
    public const int GL_SRGB_READ = 0x8297;
    public const int GL_SRGB_WRITE = 0x8298;
    public const int GL_SRGB_DECODE_ARB = 0x8299;
    public const int GL_FILTER = 0x829A;
    public const int GL_VERTEX_TEXTURE = 0x829B;
    public const int GL_TESS_CONTROL_TEXTURE = 0x829C;
    public const int GL_TESS_EVALUATION_TEXTURE = 0x829D;
    public const int GL_GEOMETRY_TEXTURE = 0x829E;
    public const int GL_FRAGMENT_TEXTURE = 0x829F;
    public const int GL_COMPUTE_TEXTURE = 0x82A0;
    public const int GL_TEXTURE_SHADOW = 0x82A1;
    public const int GL_TEXTURE_GATHER = 0x82A2;
    public const int GL_TEXTURE_GATHER_SHADOW = 0x82A3;
    public const int GL_SHADER_IMAGE_LOAD = 0x82A4;
    public const int GL_SHADER_IMAGE_STORE = 0x82A5;
    public const int GL_SHADER_IMAGE_ATOMIC = 0x82A6;
    public const int GL_IMAGE_TEXEL_SIZE = 0x82A7;
    public const int GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8;
    public const int GL_IMAGE_PIXEL_FORMAT = 0x82A9;
    public const int GL_IMAGE_PIXEL_TYPE = 0x82AA;
    public const int GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
    public const int GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
    public const int GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
    public const int GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
    public const int GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
    public const int GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
    public const int GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
    public const int GL_CLEAR_BUFFER = 0x82B4;
    public const int GL_TEXTURE_VIEW = 0x82B5;
    public const int GL_VIEW_COMPATIBILITY_CLASS = 0x82B6;
    public const int GL_FULL_SUPPORT = 0x82B7;
    public const int GL_CAVEAT_SUPPORT = 0x82B8;
    public const int GL_IMAGE_CLASS_4_X_32 = 0x82B9;
    public const int GL_IMAGE_CLASS_2_X_32 = 0x82BA;
    public const int GL_IMAGE_CLASS_1_X_32 = 0x82BB;
    public const int GL_IMAGE_CLASS_4_X_16 = 0x82BC;
    public const int GL_IMAGE_CLASS_2_X_16 = 0x82BD;
    public const int GL_IMAGE_CLASS_1_X_16 = 0x82BE;
    public const int GL_IMAGE_CLASS_4_X_8 = 0x82BF;
    public const int GL_IMAGE_CLASS_2_X_8 = 0x82C0;
    public const int GL_IMAGE_CLASS_1_X_8 = 0x82C1;
    public const int GL_IMAGE_CLASS_11_11_10 = 0x82C2;
    public const int GL_IMAGE_CLASS_10_10_10_2 = 0x82C3;
    public const int GL_VIEW_CLASS_128_BITS = 0x82C4;
    public const int GL_VIEW_CLASS_96_BITS = 0x82C5;
    public const int GL_VIEW_CLASS_64_BITS = 0x82C6;
    public const int GL_VIEW_CLASS_48_BITS = 0x82C7;
    public const int GL_VIEW_CLASS_32_BITS = 0x82C8;
    public const int GL_VIEW_CLASS_24_BITS = 0x82C9;
    public const int GL_VIEW_CLASS_16_BITS = 0x82CA;
    public const int GL_VIEW_CLASS_8_BITS = 0x82CB;
    public const int GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
    public const int GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
    public const int GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
    public const int GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
    public const int GL_VIEW_CLASS_RGTC1_RED = 0x82D0;
    public const int GL_VIEW_CLASS_RGTC2_RG = 0x82D1;
    public const int GL_VIEW_CLASS_BPTC_UNORM = 0x82D2;
    public const int GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3;
    public const int GL_VIEW_CLASS_EAC_R11 = 0x9383;
    public const int GL_VIEW_CLASS_EAC_RG11 = 0x9384;
    public const int GL_VIEW_CLASS_ETC2_RGB = 0x9385;
    public const int GL_VIEW_CLASS_ETC2_RGBA = 0x9386;
    public const int GL_VIEW_CLASS_ETC2_EAC_RGBA = 0x9387;
    public const int GL_VIEW_CLASS_ASTC_4x4_RGBA = 0x9388;
    public const int GL_VIEW_CLASS_ASTC_5x4_RGBA = 0x9389;
    public const int GL_VIEW_CLASS_ASTC_5x5_RGBA = 0x938A;
    public const int GL_VIEW_CLASS_ASTC_6x5_RGBA = 0x938B;
    public const int GL_VIEW_CLASS_ASTC_6x6_RGBA = 0x938C;
    public const int GL_VIEW_CLASS_ASTC_8x5_RGBA = 0x938D;
    public const int GL_VIEW_CLASS_ASTC_8x6_RGBA = 0x938E;
    public const int GL_VIEW_CLASS_ASTC_8x8_RGBA = 0x938F;
    public const int GL_VIEW_CLASS_ASTC_10x5_RGBA = 0x9390;
    public const int GL_VIEW_CLASS_ASTC_10x6_RGBA = 0x9391;
    public const int GL_VIEW_CLASS_ASTC_10x8_RGBA = 0x9392;
    public const int GL_VIEW_CLASS_ASTC_10x10_RGBA = 0x9393;
    public const int GL_VIEW_CLASS_ASTC_12x10_RGBA = 0x9394;
    public const int GL_VIEW_CLASS_ASTC_12x12_RGBA = 0x9395;
    #endregion
    
    #region Commands
    public static void glGetInternalformati64v(uint target, uint internalformat, uint pname, int count, long* @params) { QGLFeature.VerifyFunc((nint)_glGetInternalformati64v); _glGetInternalformati64v(target, internalformat, pname, count, @params); }
    internal static delegate* unmanaged<uint, uint, uint, int, long*, void> _glGetInternalformati64v = null;
     #endregion
    
    internal static void Load()
    {
        _glGetInternalformati64v = (delegate* unmanaged<uint, uint, uint, int, long*, void>)QuickGL.GetGLProcAddress("glGetInternalformati64v");
    }
    
    internal static void Unload()
    {
        _glGetInternalformati64v = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_internalformat_query2", true, false);
}
