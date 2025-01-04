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

// Bindings generated at 2025-01-04 01:08:51.541642
namespace QuickGLNS.Bindings
{
    [GLFeature]
    public static unsafe class GL31
    {
        #region Enums
        public const int GL_SAMPLER_2D_RECT = 0x8B63;
        public const int GL_SAMPLER_2D_RECT_SHADOW = 0x8B64;
        public const int GL_SAMPLER_BUFFER = 0x8DC2;
        public const int GL_INT_SAMPLER_2D_RECT = 0x8DCD;
        public const int GL_INT_SAMPLER_BUFFER = 0x8DD0;
        public const int GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
        public const int GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
        public const int GL_TEXTURE_BUFFER = 0x8C2A;
        public const int GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
        public const int GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
        public const int GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
        public const int GL_TEXTURE_RECTANGLE = 0x84F5;
        public const int GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
        public const int GL_PROXY_TEXTURE_RECTANGLE = 0x84F7;
        public const int GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
        public const int GL_R8_SNORM = 0x8F94;
        public const int GL_RG8_SNORM = 0x8F95;
        public const int GL_RGB8_SNORM = 0x8F96;
        public const int GL_RGBA8_SNORM = 0x8F97;
        public const int GL_R16_SNORM = 0x8F98;
        public const int GL_RG16_SNORM = 0x8F99;
        public const int GL_RGB16_SNORM = 0x8F9A;
        public const int GL_RGBA16_SNORM = 0x8F9B;
        public const int GL_SIGNED_NORMALIZED = 0x8F9C;
        public const int GL_PRIMITIVE_RESTART = 0x8F9D;
        public const int GL_PRIMITIVE_RESTART_INDEX = 0x8F9E;
        public const int GL_COPY_READ_BUFFER = 0x8F36;
        public const int GL_COPY_WRITE_BUFFER = 0x8F37;
        public const int GL_UNIFORM_BUFFER = 0x8A11;
        public const int GL_UNIFORM_BUFFER_BINDING = 0x8A28;
        public const int GL_UNIFORM_BUFFER_START = 0x8A29;
        public const int GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
        public const int GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
        public const int GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
        public const int GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
        public const int GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
        public const int GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
        public const int GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
        public const int GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
        public const int GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
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
        public const int GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
        public const int GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
        public const uint GL_INVALID_INDEX = 0xFFFFFFFF;
        #endregion
        
        #region Commands
        [QGLNativeAPI("glDrawArraysInstanced")] public static delegate* unmanaged<uint, int, int, int, void> glDrawArraysInstanced;
        [QGLNativeAPI("glDrawElementsInstanced")] public static delegate* unmanaged<uint, int, uint, void*, int, void> glDrawElementsInstanced;
        [QGLNativeAPI("glTexBuffer")] public static delegate* unmanaged<uint, uint, uint, void> glTexBuffer;
        [QGLNativeAPI("glPrimitiveRestartIndex")] public static delegate* unmanaged<uint, void> glPrimitiveRestartIndex;
        [QGLNativeAPI("glCopyBufferSubData")] public static delegate* unmanaged<uint, uint, nint, nint, nint, void> glCopyBufferSubData;
        [QGLNativeAPI("glGetUniformIndices")] public static delegate* unmanaged<uint, int, char**, uint*, void> glGetUniformIndices;
        [QGLNativeAPI("glGetActiveUniformsiv")] public static delegate* unmanaged<uint, int, uint*, uint, int*, void> glGetActiveUniformsiv;
        [QGLNativeAPI("glGetActiveUniformName")] public static delegate* unmanaged<uint, uint, int, int*, char*, void> glGetActiveUniformName;
        [QGLNativeAPI("glGetUniformBlockIndex")] public static delegate* unmanaged<uint, char*, uint> glGetUniformBlockIndex;
        [QGLNativeAPI("glGetActiveUniformBlockiv")] public static delegate* unmanaged<uint, uint, uint, int*, void> glGetActiveUniformBlockiv;
        [QGLNativeAPI("glGetActiveUniformBlockName")] public static delegate* unmanaged<uint, uint, int, int*, char*, void> glGetActiveUniformBlockName;
        [QGLNativeAPI("glUniformBlockBinding")] public static delegate* unmanaged<uint, uint, uint, void> glUniformBlockBinding;
        [QGLNativeAPI("glBindBufferRange")] public static delegate* unmanaged<uint, uint, uint, nint, nint, void> glBindBufferRange;
        [QGLNativeAPI("glBindBufferBase")] public static delegate* unmanaged<uint, uint, uint, void> glBindBufferBase;
        [QGLNativeAPI("glGetIntegeri_v")] public static delegate* unmanaged<uint, uint, int*, void> glGetIntegeri_v;
        #endregion
    }
}
