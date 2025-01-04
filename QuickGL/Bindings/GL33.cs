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

// Bindings generated at 2025-01-04 01:08:51.543158
namespace QuickGLNS.Bindings
{
    [GLFeature]
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
        [QGLNativeAPI("glBindFragDataLocationIndexed")] public static delegate* unmanaged<uint, uint, uint, char*, void> glBindFragDataLocationIndexed;
        [QGLNativeAPI("glGetFragDataIndex")] public static delegate* unmanaged<uint, char*, int> glGetFragDataIndex;
        [QGLNativeAPI("glGenSamplers")] public static delegate* unmanaged<int, uint*, void> glGenSamplers;
        [QGLNativeAPI("glDeleteSamplers")] public static delegate* unmanaged<int, uint*, void> glDeleteSamplers;
        [QGLNativeAPI("glIsSampler")] public static delegate* unmanaged<uint, bool> glIsSampler;
        [QGLNativeAPI("glBindSampler")] public static delegate* unmanaged<uint, uint, void> glBindSampler;
        [QGLNativeAPI("glSamplerParameteri")] public static delegate* unmanaged<uint, uint, int, void> glSamplerParameteri;
        [QGLNativeAPI("glSamplerParameteriv")] public static delegate* unmanaged<uint, uint, int*, void> glSamplerParameteriv;
        [QGLNativeAPI("glSamplerParameterf")] public static delegate* unmanaged<uint, uint, float, void> glSamplerParameterf;
        [QGLNativeAPI("glSamplerParameterfv")] public static delegate* unmanaged<uint, uint, float*, void> glSamplerParameterfv;
        [QGLNativeAPI("glSamplerParameterIiv")] public static delegate* unmanaged<uint, uint, int*, void> glSamplerParameterIiv;
        [QGLNativeAPI("glSamplerParameterIuiv")] public static delegate* unmanaged<uint, uint, uint*, void> glSamplerParameterIuiv;
        [QGLNativeAPI("glGetSamplerParameteriv")] public static delegate* unmanaged<uint, uint, int*, void> glGetSamplerParameteriv;
        [QGLNativeAPI("glGetSamplerParameterIiv")] public static delegate* unmanaged<uint, uint, int*, void> glGetSamplerParameterIiv;
        [QGLNativeAPI("glGetSamplerParameterfv")] public static delegate* unmanaged<uint, uint, float*, void> glGetSamplerParameterfv;
        [QGLNativeAPI("glGetSamplerParameterIuiv")] public static delegate* unmanaged<uint, uint, uint*, void> glGetSamplerParameterIuiv;
        [QGLNativeAPI("glQueryCounter")] public static delegate* unmanaged<uint, uint, void> glQueryCounter;
        [QGLNativeAPI("glGetQueryObjecti64v")] public static delegate* unmanaged<uint, uint, long*, void> glGetQueryObjecti64v;
        [QGLNativeAPI("glGetQueryObjectui64v")] public static delegate* unmanaged<uint, uint, ulong*, void> glGetQueryObjectui64v;
        [QGLNativeAPI("glVertexAttribDivisor")] public static delegate* unmanaged<uint, uint, void> glVertexAttribDivisor;
        [QGLNativeAPI("glVertexAttribP1ui")] public static delegate* unmanaged<uint, uint, bool, uint, void> glVertexAttribP1ui;
        [QGLNativeAPI("glVertexAttribP1uiv")] public static delegate* unmanaged<uint, uint, bool, uint*, void> glVertexAttribP1uiv;
        [QGLNativeAPI("glVertexAttribP2ui")] public static delegate* unmanaged<uint, uint, bool, uint, void> glVertexAttribP2ui;
        [QGLNativeAPI("glVertexAttribP2uiv")] public static delegate* unmanaged<uint, uint, bool, uint*, void> glVertexAttribP2uiv;
        [QGLNativeAPI("glVertexAttribP3ui")] public static delegate* unmanaged<uint, uint, bool, uint, void> glVertexAttribP3ui;
        [QGLNativeAPI("glVertexAttribP3uiv")] public static delegate* unmanaged<uint, uint, bool, uint*, void> glVertexAttribP3uiv;
        [QGLNativeAPI("glVertexAttribP4ui")] public static delegate* unmanaged<uint, uint, bool, uint, void> glVertexAttribP4ui;
        [QGLNativeAPI("glVertexAttribP4uiv")] public static delegate* unmanaged<uint, uint, bool, uint*, void> glVertexAttribP4uiv;
        [QGLNativeAPI("glVertexP2ui")] public static delegate* unmanaged<uint, uint, void> glVertexP2ui;
        [QGLNativeAPI("glVertexP2uiv")] public static delegate* unmanaged<uint, uint*, void> glVertexP2uiv;
        [QGLNativeAPI("glVertexP3ui")] public static delegate* unmanaged<uint, uint, void> glVertexP3ui;
        [QGLNativeAPI("glVertexP3uiv")] public static delegate* unmanaged<uint, uint*, void> glVertexP3uiv;
        [QGLNativeAPI("glVertexP4ui")] public static delegate* unmanaged<uint, uint, void> glVertexP4ui;
        [QGLNativeAPI("glVertexP4uiv")] public static delegate* unmanaged<uint, uint*, void> glVertexP4uiv;
        [QGLNativeAPI("glTexCoordP1ui")] public static delegate* unmanaged<uint, uint, void> glTexCoordP1ui;
        [QGLNativeAPI("glTexCoordP1uiv")] public static delegate* unmanaged<uint, uint*, void> glTexCoordP1uiv;
        [QGLNativeAPI("glTexCoordP2ui")] public static delegate* unmanaged<uint, uint, void> glTexCoordP2ui;
        [QGLNativeAPI("glTexCoordP2uiv")] public static delegate* unmanaged<uint, uint*, void> glTexCoordP2uiv;
        [QGLNativeAPI("glTexCoordP3ui")] public static delegate* unmanaged<uint, uint, void> glTexCoordP3ui;
        [QGLNativeAPI("glTexCoordP3uiv")] public static delegate* unmanaged<uint, uint*, void> glTexCoordP3uiv;
        [QGLNativeAPI("glTexCoordP4ui")] public static delegate* unmanaged<uint, uint, void> glTexCoordP4ui;
        [QGLNativeAPI("glTexCoordP4uiv")] public static delegate* unmanaged<uint, uint*, void> glTexCoordP4uiv;
        [QGLNativeAPI("glMultiTexCoordP1ui")] public static delegate* unmanaged<uint, uint, uint, void> glMultiTexCoordP1ui;
        [QGLNativeAPI("glMultiTexCoordP1uiv")] public static delegate* unmanaged<uint, uint, uint*, void> glMultiTexCoordP1uiv;
        [QGLNativeAPI("glMultiTexCoordP2ui")] public static delegate* unmanaged<uint, uint, uint, void> glMultiTexCoordP2ui;
        [QGLNativeAPI("glMultiTexCoordP2uiv")] public static delegate* unmanaged<uint, uint, uint*, void> glMultiTexCoordP2uiv;
        [QGLNativeAPI("glMultiTexCoordP3ui")] public static delegate* unmanaged<uint, uint, uint, void> glMultiTexCoordP3ui;
        [QGLNativeAPI("glMultiTexCoordP3uiv")] public static delegate* unmanaged<uint, uint, uint*, void> glMultiTexCoordP3uiv;
        [QGLNativeAPI("glMultiTexCoordP4ui")] public static delegate* unmanaged<uint, uint, uint, void> glMultiTexCoordP4ui;
        [QGLNativeAPI("glMultiTexCoordP4uiv")] public static delegate* unmanaged<uint, uint, uint*, void> glMultiTexCoordP4uiv;
        [QGLNativeAPI("glNormalP3ui")] public static delegate* unmanaged<uint, uint, void> glNormalP3ui;
        [QGLNativeAPI("glNormalP3uiv")] public static delegate* unmanaged<uint, uint*, void> glNormalP3uiv;
        [QGLNativeAPI("glColorP3ui")] public static delegate* unmanaged<uint, uint, void> glColorP3ui;
        [QGLNativeAPI("glColorP3uiv")] public static delegate* unmanaged<uint, uint*, void> glColorP3uiv;
        [QGLNativeAPI("glColorP4ui")] public static delegate* unmanaged<uint, uint, void> glColorP4ui;
        [QGLNativeAPI("glColorP4uiv")] public static delegate* unmanaged<uint, uint*, void> glColorP4uiv;
        [QGLNativeAPI("glSecondaryColorP3ui")] public static delegate* unmanaged<uint, uint, void> glSecondaryColorP3ui;
        [QGLNativeAPI("glSecondaryColorP3uiv")] public static delegate* unmanaged<uint, uint*, void> glSecondaryColorP3uiv;
        #endregion
    }
}
