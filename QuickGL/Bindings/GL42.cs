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

// Bindings generated at 2025-01-04 19:06:28.375042
namespace QuickGLNS.Bindings
{
    [GLFeature]
    public static unsafe class GL42
    {
        #region Enums
        public const int GL_COPY_READ_BUFFER_BINDING = 0x8F36;
        public const int GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;
        public const int GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
        public const int GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
        public const int GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
        public const int GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
        public const int GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
        public const int GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
        public const int GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
        public const int GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
        public const int GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
        public const int GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
        public const int GL_NUM_SAMPLE_COUNTS = 0x9380;
        public const int GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
        public const int GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
        public const int GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
        public const int GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;
        public const int GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
        public const int GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
        public const int GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
        public const int GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
        public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
        public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
        public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
        public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
        public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
        public const int GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
        public const int GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
        public const int GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
        public const int GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
        public const int GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
        public const int GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
        public const int GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
        public const int GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
        public const int GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
        public const int GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
        public const int GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
        public const int GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
        public const int GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
        public const int GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
        public const int GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
        public const int GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
        public const int GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
        public const int GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x1;
        public const int GL_ELEMENT_ARRAY_BARRIER_BIT = 0x2;
        public const int GL_UNIFORM_BARRIER_BIT = 0x4;
        public const int GL_TEXTURE_FETCH_BARRIER_BIT = 0x8;
        public const int GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x20;
        public const int GL_COMMAND_BARRIER_BIT = 0x40;
        public const int GL_PIXEL_BUFFER_BARRIER_BIT = 0x80;
        public const int GL_TEXTURE_UPDATE_BARRIER_BIT = 0x100;
        public const int GL_BUFFER_UPDATE_BARRIER_BIT = 0x200;
        public const int GL_FRAMEBUFFER_BARRIER_BIT = 0x400;
        public const int GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x800;
        public const int GL_ATOMIC_COUNTER_BARRIER_BIT = 0x1000;
        public const uint GL_ALL_BARRIER_BITS = 0xFFFFFFFF;
        public const int GL_MAX_IMAGE_UNITS = 0x8F38;
        public const int GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
        public const int GL_IMAGE_BINDING_NAME = 0x8F3A;
        public const int GL_IMAGE_BINDING_LEVEL = 0x8F3B;
        public const int GL_IMAGE_BINDING_LAYERED = 0x8F3C;
        public const int GL_IMAGE_BINDING_LAYER = 0x8F3D;
        public const int GL_IMAGE_BINDING_ACCESS = 0x8F3E;
        public const int GL_IMAGE_1D = 0x904C;
        public const int GL_IMAGE_2D = 0x904D;
        public const int GL_IMAGE_3D = 0x904E;
        public const int GL_IMAGE_2D_RECT = 0x904F;
        public const int GL_IMAGE_CUBE = 0x9050;
        public const int GL_IMAGE_BUFFER = 0x9051;
        public const int GL_IMAGE_1D_ARRAY = 0x9052;
        public const int GL_IMAGE_2D_ARRAY = 0x9053;
        public const int GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;
        public const int GL_IMAGE_2D_MULTISAMPLE = 0x9055;
        public const int GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
        public const int GL_INT_IMAGE_1D = 0x9057;
        public const int GL_INT_IMAGE_2D = 0x9058;
        public const int GL_INT_IMAGE_3D = 0x9059;
        public const int GL_INT_IMAGE_2D_RECT = 0x905A;
        public const int GL_INT_IMAGE_CUBE = 0x905B;
        public const int GL_INT_IMAGE_BUFFER = 0x905C;
        public const int GL_INT_IMAGE_1D_ARRAY = 0x905D;
        public const int GL_INT_IMAGE_2D_ARRAY = 0x905E;
        public const int GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
        public const int GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060;
        public const int GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
        public const int GL_UNSIGNED_INT_IMAGE_1D = 0x9062;
        public const int GL_UNSIGNED_INT_IMAGE_2D = 0x9063;
        public const int GL_UNSIGNED_INT_IMAGE_3D = 0x9064;
        public const int GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
        public const int GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066;
        public const int GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
        public const int GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
        public const int GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
        public const int GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
        public const int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
        public const int GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
        public const int GL_MAX_IMAGE_SAMPLES = 0x906D;
        public const int GL_IMAGE_BINDING_FORMAT = 0x906E;
        public const int GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
        public const int GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
        public const int GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
        public const int GL_MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
        public const int GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
        public const int GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
        public const int GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
        public const int GL_MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
        public const int GL_MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
        public const int GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;
        public const int GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;
        public const int GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;
        public const int GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;
        public const int GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
        #endregion
        
        #region Commands
        [QGLNativeAPI("glDrawArraysInstancedBaseInstance")] public static delegate* unmanaged<uint, int, int, int, uint, void> glDrawArraysInstancedBaseInstance;
        [QGLNativeAPI("glDrawElementsInstancedBaseInstance")] public static delegate* unmanaged<uint, int, uint, void*, int, uint, void> glDrawElementsInstancedBaseInstance;
        [QGLNativeAPI("glDrawElementsInstancedBaseVertexBaseInstance")] public static delegate* unmanaged<uint, int, uint, void*, int, int, uint, void> glDrawElementsInstancedBaseVertexBaseInstance;
        [QGLNativeAPI("glGetInternalformativ")] public static delegate* unmanaged<uint, uint, uint, int, int*, void> glGetInternalformativ;
        [QGLNativeAPI("glGetActiveAtomicCounterBufferiv")] public static delegate* unmanaged<uint, uint, uint, int*, void> glGetActiveAtomicCounterBufferiv;
        [QGLNativeAPI("glBindImageTexture")] public static delegate* unmanaged<uint, uint, int, bool, int, uint, uint, void> glBindImageTexture;
        [QGLNativeAPI("glMemoryBarrier")] public static delegate* unmanaged<uint, void> glMemoryBarrier;
        [QGLNativeAPI("glTexStorage1D")] public static delegate* unmanaged<uint, int, uint, int, void> glTexStorage1D;
        [QGLNativeAPI("glTexStorage2D")] public static delegate* unmanaged<uint, int, uint, int, int, void> glTexStorage2D;
        [QGLNativeAPI("glTexStorage3D")] public static delegate* unmanaged<uint, int, uint, int, int, int, void> glTexStorage3D;
        [QGLNativeAPI("glDrawTransformFeedbackInstanced")] public static delegate* unmanaged<uint, uint, int, void> glDrawTransformFeedbackInstanced;
        [QGLNativeAPI("glDrawTransformFeedbackStreamInstanced")] public static delegate* unmanaged<uint, uint, uint, int, void> glDrawTransformFeedbackStreamInstanced;
        #endregion
    }
}
