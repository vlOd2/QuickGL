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

// Bindings generated at 2025-01-04 19:06:28.371627
namespace QuickGLNS.Bindings
{
    [GLFeature]
    public static unsafe class GL32
    {
        #region Enums
        public const int GL_CONTEXT_CORE_PROFILE_BIT = 0x1;
        public const int GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x2;
        public const int GL_LINES_ADJACENCY = 0xA;
        public const int GL_LINE_STRIP_ADJACENCY = 0xB;
        public const int GL_TRIANGLES_ADJACENCY = 0xC;
        public const int GL_TRIANGLE_STRIP_ADJACENCY = 0xD;
        public const int GL_PROGRAM_POINT_SIZE = 0x8642;
        public const int GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
        public const int GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
        public const int GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
        public const int GL_GEOMETRY_SHADER = 0x8DD9;
        public const int GL_GEOMETRY_VERTICES_OUT = 0x8916;
        public const int GL_GEOMETRY_INPUT_TYPE = 0x8917;
        public const int GL_GEOMETRY_OUTPUT_TYPE = 0x8918;
        public const int GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
        public const int GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
        public const int GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
        public const int GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
        public const int GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
        public const int GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
        public const int GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
        public const int GL_CONTEXT_PROFILE_MASK = 0x9126;
        public const int GL_DEPTH_CLAMP = 0x864F;
        public const int GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
        public const int GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
        public const int GL_LAST_VERTEX_CONVENTION = 0x8E4E;
        public const int GL_PROVOKING_VERTEX = 0x8E4F;
        public const int GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
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
        public const ulong GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
        public const int GL_SYNC_FLUSH_COMMANDS_BIT = 0x1;
        public const int GL_SAMPLE_POSITION = 0x8E50;
        public const int GL_SAMPLE_MASK = 0x8E51;
        public const int GL_SAMPLE_MASK_VALUE = 0x8E52;
        public const int GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
        public const int GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
        public const int GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
        public const int GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
        public const int GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
        public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
        public const int GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
        public const int GL_TEXTURE_SAMPLES = 0x9106;
        public const int GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
        public const int GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
        public const int GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
        public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
        public const int GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
        public const int GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
        public const int GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
        public const int GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
        public const int GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
        public const int GL_MAX_INTEGER_SAMPLES = 0x9110;
        #endregion
        
        #region Commands
        [QGLNativeAPI("glDrawElementsBaseVertex")] public static delegate* unmanaged<uint, int, uint, void*, int, void> glDrawElementsBaseVertex;
        [QGLNativeAPI("glDrawRangeElementsBaseVertex")] public static delegate* unmanaged<uint, uint, uint, int, uint, void*, int, void> glDrawRangeElementsBaseVertex;
        [QGLNativeAPI("glDrawElementsInstancedBaseVertex")] public static delegate* unmanaged<uint, int, uint, void*, int, int, void> glDrawElementsInstancedBaseVertex;
        [QGLNativeAPI("glMultiDrawElementsBaseVertex")] public static delegate* unmanaged<uint, int*, uint, void**, int, int*, void> glMultiDrawElementsBaseVertex;
        [QGLNativeAPI("glProvokingVertex")] public static delegate* unmanaged<uint, void> glProvokingVertex;
        [QGLNativeAPI("glFenceSync")] public static delegate* unmanaged<uint, uint, nint> glFenceSync;
        [QGLNativeAPI("glIsSync")] public static delegate* unmanaged<nint, bool> glIsSync;
        [QGLNativeAPI("glDeleteSync")] public static delegate* unmanaged<nint, void> glDeleteSync;
        [QGLNativeAPI("glClientWaitSync")] public static delegate* unmanaged<nint, uint, ulong, uint> glClientWaitSync;
        [QGLNativeAPI("glWaitSync")] public static delegate* unmanaged<nint, uint, ulong, void> glWaitSync;
        [QGLNativeAPI("glGetInteger64v")] public static delegate* unmanaged<uint, long*, void> glGetInteger64v;
        [QGLNativeAPI("glGetSynciv")] public static delegate* unmanaged<nint, uint, int, int*, int*, void> glGetSynciv;
        [QGLNativeAPI("glGetInteger64i_v")] public static delegate* unmanaged<uint, uint, long*, void> glGetInteger64i_v;
        [QGLNativeAPI("glGetBufferParameteri64v")] public static delegate* unmanaged<uint, uint, long*, void> glGetBufferParameteri64v;
        [QGLNativeAPI("glFramebufferTexture")] public static delegate* unmanaged<uint, uint, uint, int, void> glFramebufferTexture;
        [QGLNativeAPI("glTexImage2DMultisample")] public static delegate* unmanaged<uint, int, uint, int, int, bool, void> glTexImage2DMultisample;
        [QGLNativeAPI("glTexImage3DMultisample")] public static delegate* unmanaged<uint, int, uint, int, int, int, bool, void> glTexImage3DMultisample;
        [QGLNativeAPI("glGetMultisamplefv")] public static delegate* unmanaged<uint, uint, float*, void> glGetMultisamplefv;
        [QGLNativeAPI("glSampleMaski")] public static delegate* unmanaged<uint, uint, void> glSampleMaski;
        #endregion
    }
}
