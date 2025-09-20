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

// Bindings generated at 2025-09-20 18:58:19.729695
namespace QuickGLNS.Bindings;

public static unsafe class GL11
{
    #region Enums
    public const int GL_COLOR_LOGIC_OP = 0xBF2;
    public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;
    public const int GL_POLYGON_OFFSET_POINT = 0x2A01;
    public const int GL_POLYGON_OFFSET_LINE = 0x2A02;
    public const int GL_POLYGON_OFFSET_FILL = 0x8037;
    public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;
    public const int GL_TEXTURE_BINDING_1D = 0x8068;
    public const int GL_TEXTURE_BINDING_2D = 0x8069;
    public const int GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
    public const int GL_TEXTURE_RED_SIZE = 0x805C;
    public const int GL_TEXTURE_GREEN_SIZE = 0x805D;
    public const int GL_TEXTURE_BLUE_SIZE = 0x805E;
    public const int GL_TEXTURE_ALPHA_SIZE = 0x805F;
    public const int GL_DOUBLE = 0x140A;
    public const int GL_PROXY_TEXTURE_1D = 0x8063;
    public const int GL_PROXY_TEXTURE_2D = 0x8064;
    public const int GL_R3_G3_B2 = 0x2A10;
    public const int GL_RGB4 = 0x804F;
    public const int GL_RGB5 = 0x8050;
    public const int GL_RGB8 = 0x8051;
    public const int GL_RGB10 = 0x8052;
    public const int GL_RGB12 = 0x8053;
    public const int GL_RGB16 = 0x8054;
    public const int GL_RGBA2 = 0x8055;
    public const int GL_RGBA4 = 0x8056;
    public const int GL_RGB5_A1 = 0x8057;
    public const int GL_RGBA8 = 0x8058;
    public const int GL_RGB10_A2 = 0x8059;
    public const int GL_RGBA12 = 0x805A;
    public const int GL_RGBA16 = 0x805B;
    public const int GL_CLIENT_PIXEL_STORE_BIT = 0x1;
    public const int GL_CLIENT_VERTEX_ARRAY_BIT = 0x2;
    public const uint GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;
    public const int GL_VERTEX_ARRAY_POINTER = 0x808E;
    public const int GL_NORMAL_ARRAY_POINTER = 0x808F;
    public const int GL_COLOR_ARRAY_POINTER = 0x8090;
    public const int GL_INDEX_ARRAY_POINTER = 0x8091;
    public const int GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;
    public const int GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;
    public const int GL_FEEDBACK_BUFFER_POINTER = 0xDF0;
    public const int GL_SELECTION_BUFFER_POINTER = 0xDF3;
    public const int GL_CLIENT_ATTRIB_STACK_DEPTH = 0xBB1;
    public const int GL_INDEX_LOGIC_OP = 0xBF1;
    public const int GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0xD3B;
    public const int GL_FEEDBACK_BUFFER_SIZE = 0xDF1;
    public const int GL_FEEDBACK_BUFFER_TYPE = 0xDF2;
    public const int GL_SELECTION_BUFFER_SIZE = 0xDF4;
    public const int GL_VERTEX_ARRAY = 0x8074;
    public const int GL_NORMAL_ARRAY = 0x8075;
    public const int GL_COLOR_ARRAY = 0x8076;
    public const int GL_INDEX_ARRAY = 0x8077;
    public const int GL_TEXTURE_COORD_ARRAY = 0x8078;
    public const int GL_EDGE_FLAG_ARRAY = 0x8079;
    public const int GL_VERTEX_ARRAY_SIZE = 0x807A;
    public const int GL_VERTEX_ARRAY_TYPE = 0x807B;
    public const int GL_VERTEX_ARRAY_STRIDE = 0x807C;
    public const int GL_NORMAL_ARRAY_TYPE = 0x807E;
    public const int GL_NORMAL_ARRAY_STRIDE = 0x807F;
    public const int GL_COLOR_ARRAY_SIZE = 0x8081;
    public const int GL_COLOR_ARRAY_TYPE = 0x8082;
    public const int GL_COLOR_ARRAY_STRIDE = 0x8083;
    public const int GL_INDEX_ARRAY_TYPE = 0x8085;
    public const int GL_INDEX_ARRAY_STRIDE = 0x8086;
    public const int GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;
    public const int GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;
    public const int GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
    public const int GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;
    public const int GL_TEXTURE_LUMINANCE_SIZE = 0x8060;
    public const int GL_TEXTURE_INTENSITY_SIZE = 0x8061;
    public const int GL_TEXTURE_PRIORITY = 0x8066;
    public const int GL_TEXTURE_RESIDENT = 0x8067;
    public const int GL_ALPHA4 = 0x803B;
    public const int GL_ALPHA8 = 0x803C;
    public const int GL_ALPHA12 = 0x803D;
    public const int GL_ALPHA16 = 0x803E;
    public const int GL_LUMINANCE4 = 0x803F;
    public const int GL_LUMINANCE8 = 0x8040;
    public const int GL_LUMINANCE12 = 0x8041;
    public const int GL_LUMINANCE16 = 0x8042;
    public const int GL_LUMINANCE4_ALPHA4 = 0x8043;
    public const int GL_LUMINANCE6_ALPHA2 = 0x8044;
    public const int GL_LUMINANCE8_ALPHA8 = 0x8045;
    public const int GL_LUMINANCE12_ALPHA4 = 0x8046;
    public const int GL_LUMINANCE12_ALPHA12 = 0x8047;
    public const int GL_LUMINANCE16_ALPHA16 = 0x8048;
    public const int GL_INTENSITY = 0x8049;
    public const int GL_INTENSITY4 = 0x804A;
    public const int GL_INTENSITY8 = 0x804B;
    public const int GL_INTENSITY12 = 0x804C;
    public const int GL_INTENSITY16 = 0x804D;
    public const int GL_V2F = 0x2A20;
    public const int GL_V3F = 0x2A21;
    public const int GL_C4UB_V2F = 0x2A22;
    public const int GL_C4UB_V3F = 0x2A23;
    public const int GL_C3F_V3F = 0x2A24;
    public const int GL_N3F_V3F = 0x2A25;
    public const int GL_C4F_N3F_V3F = 0x2A26;
    public const int GL_T2F_V3F = 0x2A27;
    public const int GL_T4F_V4F = 0x2A28;
    public const int GL_T2F_C4UB_V3F = 0x2A29;
    public const int GL_T2F_C3F_V3F = 0x2A2A;
    public const int GL_T2F_N3F_V3F = 0x2A2B;
    public const int GL_T2F_C4F_N3F_V3F = 0x2A2C;
    public const int GL_T4F_C4F_N3F_V4F = 0x2A2D;
    #endregion
    
    #region Commands
    public static void glDrawArrays(uint mode, int first, int count) { QGLFeature.VerifyFunc((nint)_glDrawArrays); _glDrawArrays(mode, first, count); }
    internal static delegate* unmanaged<uint, int, int, void> _glDrawArrays = null;
    
    public static void glDrawElements(uint mode, int count, uint type, void* indices) { QGLFeature.VerifyFunc((nint)_glDrawElements); _glDrawElements(mode, count, type, indices); }
    internal static delegate* unmanaged<uint, int, uint, void*, void> _glDrawElements = null;
    
    public static void glGetPointerv(uint pname, void** @params) { QGLFeature.VerifyFunc((nint)_glGetPointerv); _glGetPointerv(pname, @params); }
    internal static delegate* unmanaged<uint, void**, void> _glGetPointerv = null;
    
    public static void glPolygonOffset(float factor, float units) { QGLFeature.VerifyFunc((nint)_glPolygonOffset); _glPolygonOffset(factor, units); }
    internal static delegate* unmanaged<float, float, void> _glPolygonOffset = null;
    
    public static void glCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border) { QGLFeature.VerifyFunc((nint)_glCopyTexImage1D); _glCopyTexImage1D(target, level, internalformat, x, y, width, border); }
    internal static delegate* unmanaged<uint, int, uint, int, int, int, int, void> _glCopyTexImage1D = null;
    
    public static void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border) { QGLFeature.VerifyFunc((nint)_glCopyTexImage2D); _glCopyTexImage2D(target, level, internalformat, x, y, width, height, border); }
    internal static delegate* unmanaged<uint, int, uint, int, int, int, int, int, void> _glCopyTexImage2D = null;
    
    public static void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width) { QGLFeature.VerifyFunc((nint)_glCopyTexSubImage1D); _glCopyTexSubImage1D(target, level, xoffset, x, y, width); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, void> _glCopyTexSubImage1D = null;
    
    public static void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) { QGLFeature.VerifyFunc((nint)_glCopyTexSubImage2D); _glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, void> _glCopyTexSubImage2D = null;
    
    public static void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels) { QGLFeature.VerifyFunc((nint)_glTexSubImage1D); _glTexSubImage1D(target, level, xoffset, width, format, type, pixels); }
    internal static delegate* unmanaged<uint, int, int, int, uint, uint, void*, void> _glTexSubImage1D = null;
    
    public static void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels) { QGLFeature.VerifyFunc((nint)_glTexSubImage2D); _glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void> _glTexSubImage2D = null;
    
    public static void glBindTexture(uint target, uint texture) { QGLFeature.VerifyFunc((nint)_glBindTexture); _glBindTexture(target, texture); }
    internal static delegate* unmanaged<uint, uint, void> _glBindTexture = null;
    
    public static void glDeleteTextures(int n, uint* textures) { QGLFeature.VerifyFunc((nint)_glDeleteTextures); _glDeleteTextures(n, textures); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteTextures = null;
    
    public static void glGenTextures(int n, uint* textures) { QGLFeature.VerifyFunc((nint)_glGenTextures); _glGenTextures(n, textures); }
    internal static delegate* unmanaged<int, uint*, void> _glGenTextures = null;
    
    public static bool glIsTexture(uint texture) { QGLFeature.VerifyFunc((nint)_glIsTexture); return _glIsTexture(texture); }
    internal static delegate* unmanaged<uint, bool> _glIsTexture = null;
    
    public static void glArrayElement(int i) { QGLFeature.VerifyFunc((nint)_glArrayElement); _glArrayElement(i); }
    internal static delegate* unmanaged<int, void> _glArrayElement = null;
    
    public static void glColorPointer(int size, uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glColorPointer); _glColorPointer(size, type, stride, pointer); }
    internal static delegate* unmanaged<int, uint, int, void*, void> _glColorPointer = null;
    
    public static void glDisableClientState(uint array) { QGLFeature.VerifyFunc((nint)_glDisableClientState); _glDisableClientState(array); }
    internal static delegate* unmanaged<uint, void> _glDisableClientState = null;
    
    public static void glEdgeFlagPointer(int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glEdgeFlagPointer); _glEdgeFlagPointer(stride, pointer); }
    internal static delegate* unmanaged<int, void*, void> _glEdgeFlagPointer = null;
    
    public static void glEnableClientState(uint array) { QGLFeature.VerifyFunc((nint)_glEnableClientState); _glEnableClientState(array); }
    internal static delegate* unmanaged<uint, void> _glEnableClientState = null;
    
    public static void glIndexPointer(uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glIndexPointer); _glIndexPointer(type, stride, pointer); }
    internal static delegate* unmanaged<uint, int, void*, void> _glIndexPointer = null;
    
    public static void glInterleavedArrays(uint format, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glInterleavedArrays); _glInterleavedArrays(format, stride, pointer); }
    internal static delegate* unmanaged<uint, int, void*, void> _glInterleavedArrays = null;
    
    public static void glNormalPointer(uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glNormalPointer); _glNormalPointer(type, stride, pointer); }
    internal static delegate* unmanaged<uint, int, void*, void> _glNormalPointer = null;
    
    public static void glTexCoordPointer(int size, uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glTexCoordPointer); _glTexCoordPointer(size, type, stride, pointer); }
    internal static delegate* unmanaged<int, uint, int, void*, void> _glTexCoordPointer = null;
    
    public static void glVertexPointer(int size, uint type, int stride, void* pointer) { QGLFeature.VerifyFunc((nint)_glVertexPointer); _glVertexPointer(size, type, stride, pointer); }
    internal static delegate* unmanaged<int, uint, int, void*, void> _glVertexPointer = null;
    
    public static bool glAreTexturesResident(int n, uint* textures, bool* residences) { QGLFeature.VerifyFunc((nint)_glAreTexturesResident); return _glAreTexturesResident(n, textures, residences); }
    internal static delegate* unmanaged<int, uint*, bool*, bool> _glAreTexturesResident = null;
    
    public static void glPrioritizeTextures(int n, uint* textures, float* priorities) { QGLFeature.VerifyFunc((nint)_glPrioritizeTextures); _glPrioritizeTextures(n, textures, priorities); }
    internal static delegate* unmanaged<int, uint*, float*, void> _glPrioritizeTextures = null;
    
    public static void glIndexub(byte c) { QGLFeature.VerifyFunc((nint)_glIndexub); _glIndexub(c); }
    internal static delegate* unmanaged<byte, void> _glIndexub = null;
    
    public static void glIndexubv(byte* c) { QGLFeature.VerifyFunc((nint)_glIndexubv); _glIndexubv(c); }
    internal static delegate* unmanaged<byte*, void> _glIndexubv = null;
    
    public static void glPopClientAttrib() { QGLFeature.VerifyFunc((nint)_glPopClientAttrib); _glPopClientAttrib(); }
    internal static delegate* unmanaged<void> _glPopClientAttrib = null;
    
    public static void glPushClientAttrib(uint mask) { QGLFeature.VerifyFunc((nint)_glPushClientAttrib); _glPushClientAttrib(mask); }
    internal static delegate* unmanaged<uint, void> _glPushClientAttrib = null;
     #endregion
    
    internal static void Load()
    {
        _glDrawArrays = (delegate* unmanaged<uint, int, int, void>)QuickGL.GetGLProcAddress("glDrawArrays");
        _glDrawElements = (delegate* unmanaged<uint, int, uint, void*, void>)QuickGL.GetGLProcAddress("glDrawElements");
        _glGetPointerv = (delegate* unmanaged<uint, void**, void>)QuickGL.GetGLProcAddress("glGetPointerv");
        _glPolygonOffset = (delegate* unmanaged<float, float, void>)QuickGL.GetGLProcAddress("glPolygonOffset");
        _glCopyTexImage1D = (delegate* unmanaged<uint, int, uint, int, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyTexImage1D");
        _glCopyTexImage2D = (delegate* unmanaged<uint, int, uint, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyTexImage2D");
        _glCopyTexSubImage1D = (delegate* unmanaged<uint, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyTexSubImage1D");
        _glCopyTexSubImage2D = (delegate* unmanaged<uint, int, int, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyTexSubImage2D");
        _glTexSubImage1D = (delegate* unmanaged<uint, int, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glTexSubImage1D");
        _glTexSubImage2D = (delegate* unmanaged<uint, int, int, int, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glTexSubImage2D");
        _glBindTexture = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBindTexture");
        _glDeleteTextures = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteTextures");
        _glGenTextures = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenTextures");
        _glIsTexture = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsTexture");
        _glArrayElement = (delegate* unmanaged<int, void>)QuickGL.GetGLProcAddress("glArrayElement");
        _glColorPointer = (delegate* unmanaged<int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glColorPointer");
        _glDisableClientState = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glDisableClientState");
        _glEdgeFlagPointer = (delegate* unmanaged<int, void*, void>)QuickGL.GetGLProcAddress("glEdgeFlagPointer");
        _glEnableClientState = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glEnableClientState");
        _glIndexPointer = (delegate* unmanaged<uint, int, void*, void>)QuickGL.GetGLProcAddress("glIndexPointer");
        _glInterleavedArrays = (delegate* unmanaged<uint, int, void*, void>)QuickGL.GetGLProcAddress("glInterleavedArrays");
        _glNormalPointer = (delegate* unmanaged<uint, int, void*, void>)QuickGL.GetGLProcAddress("glNormalPointer");
        _glTexCoordPointer = (delegate* unmanaged<int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glTexCoordPointer");
        _glVertexPointer = (delegate* unmanaged<int, uint, int, void*, void>)QuickGL.GetGLProcAddress("glVertexPointer");
        _glAreTexturesResident = (delegate* unmanaged<int, uint*, bool*, bool>)QuickGL.GetGLProcAddress("glAreTexturesResident");
        _glPrioritizeTextures = (delegate* unmanaged<int, uint*, float*, void>)QuickGL.GetGLProcAddress("glPrioritizeTextures");
        _glIndexub = (delegate* unmanaged<byte, void>)QuickGL.GetGLProcAddress("glIndexub");
        _glIndexubv = (delegate* unmanaged<byte*, void>)QuickGL.GetGLProcAddress("glIndexubv");
        _glPopClientAttrib = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glPopClientAttrib");
        _glPushClientAttrib = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glPushClientAttrib");
    }
    
    internal static void Unload()
    {
        _glDrawArrays = null;
        _glDrawElements = null;
        _glGetPointerv = null;
        _glPolygonOffset = null;
        _glCopyTexImage1D = null;
        _glCopyTexImage2D = null;
        _glCopyTexSubImage1D = null;
        _glCopyTexSubImage2D = null;
        _glTexSubImage1D = null;
        _glTexSubImage2D = null;
        _glBindTexture = null;
        _glDeleteTextures = null;
        _glGenTextures = null;
        _glIsTexture = null;
        _glArrayElement = null;
        _glColorPointer = null;
        _glDisableClientState = null;
        _glEdgeFlagPointer = null;
        _glEnableClientState = null;
        _glIndexPointer = null;
        _glInterleavedArrays = null;
        _glNormalPointer = null;
        _glTexCoordPointer = null;
        _glVertexPointer = null;
        _glAreTexturesResident = null;
        _glPrioritizeTextures = null;
        _glIndexub = null;
        _glIndexubv = null;
        _glPopClientAttrib = null;
        _glPushClientAttrib = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_VERSION_1_1", false, false);
}
