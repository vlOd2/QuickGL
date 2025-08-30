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

// Bindings generated at 2025-08-30 15:45:08.427662
namespace QuickGLNS.Bindings;

[QGLFeature("GL_VERSION_3_1", false, false)]
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
    public static void glDrawArraysInstanced(uint mode, int first, int count, int instancecount) { QGLNativeAPI.Verify((nint)_glDrawArraysInstanced); _glDrawArraysInstanced(mode, first, count, instancecount); }
    [QGLNativeAPI("glDrawArraysInstanced")] internal static delegate* unmanaged<uint, int, int, int, void> _glDrawArraysInstanced = null;
    
    public static void glDrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount) { QGLNativeAPI.Verify((nint)_glDrawElementsInstanced); _glDrawElementsInstanced(mode, count, type, indices, instancecount); }
    [QGLNativeAPI("glDrawElementsInstanced")] internal static delegate* unmanaged<uint, int, uint, void*, int, void> _glDrawElementsInstanced = null;
    
    public static void glTexBuffer(uint target, uint internalformat, uint buffer) { QGLNativeAPI.Verify((nint)_glTexBuffer); _glTexBuffer(target, internalformat, buffer); }
    [QGLNativeAPI("glTexBuffer")] internal static delegate* unmanaged<uint, uint, uint, void> _glTexBuffer = null;
    
    public static void glPrimitiveRestartIndex(uint index) { QGLNativeAPI.Verify((nint)_glPrimitiveRestartIndex); _glPrimitiveRestartIndex(index); }
    [QGLNativeAPI("glPrimitiveRestartIndex")] internal static delegate* unmanaged<uint, void> _glPrimitiveRestartIndex = null;
    
    public static void glCopyBufferSubData(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size) { QGLNativeAPI.Verify((nint)_glCopyBufferSubData); _glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size); }
    [QGLNativeAPI("glCopyBufferSubData")] internal static delegate* unmanaged<uint, uint, nint, nint, nint, void> _glCopyBufferSubData = null;
    
    public static void glGetUniformIndices(uint program, int uniformCount, byte** uniformNames, uint* uniformIndices) { QGLNativeAPI.Verify((nint)_glGetUniformIndices); _glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices); }
    [QGLNativeAPI("glGetUniformIndices")] internal static delegate* unmanaged<uint, int, byte**, uint*, void> _glGetUniformIndices = null;
    
    public static void glGetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetActiveUniformsiv); _glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, @params); }
    [QGLNativeAPI("glGetActiveUniformsiv")] internal static delegate* unmanaged<uint, int, uint*, uint, int*, void> _glGetActiveUniformsiv = null;
    
    public static void glGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, byte* uniformName) { QGLNativeAPI.Verify((nint)_glGetActiveUniformName); _glGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName); }
    [QGLNativeAPI("glGetActiveUniformName")] internal static delegate* unmanaged<uint, uint, int, int*, byte*, void> _glGetActiveUniformName = null;
    
    public static uint glGetUniformBlockIndex(uint program, byte* uniformBlockName) { QGLNativeAPI.Verify((nint)_glGetUniformBlockIndex); return _glGetUniformBlockIndex(program, uniformBlockName); }
    [QGLNativeAPI("glGetUniformBlockIndex")] internal static delegate* unmanaged<uint, byte*, uint> _glGetUniformBlockIndex = null;
    
    public static void glGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetActiveUniformBlockiv); _glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, @params); }
    [QGLNativeAPI("glGetActiveUniformBlockiv")] internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetActiveUniformBlockiv = null;
    
    public static void glGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, byte* uniformBlockName) { QGLNativeAPI.Verify((nint)_glGetActiveUniformBlockName); _glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName); }
    [QGLNativeAPI("glGetActiveUniformBlockName")] internal static delegate* unmanaged<uint, uint, int, int*, byte*, void> _glGetActiveUniformBlockName = null;
    
    public static void glUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) { QGLNativeAPI.Verify((nint)_glUniformBlockBinding); _glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding); }
    [QGLNativeAPI("glUniformBlockBinding")] internal static delegate* unmanaged<uint, uint, uint, void> _glUniformBlockBinding = null;
    
    public static void glBindBufferRange(uint target, uint index, uint buffer, nint offset, nint size) { QGLNativeAPI.Verify((nint)_glBindBufferRange); _glBindBufferRange(target, index, buffer, offset, size); }
    [QGLNativeAPI("glBindBufferRange")] internal static delegate* unmanaged<uint, uint, uint, nint, nint, void> _glBindBufferRange = null;
    
    public static void glBindBufferBase(uint target, uint index, uint buffer) { QGLNativeAPI.Verify((nint)_glBindBufferBase); _glBindBufferBase(target, index, buffer); }
    [QGLNativeAPI("glBindBufferBase")] internal static delegate* unmanaged<uint, uint, uint, void> _glBindBufferBase = null;
    
    public static void glGetIntegeri_v(uint target, uint index, int* data) { QGLNativeAPI.Verify((nint)_glGetIntegeri_v); _glGetIntegeri_v(target, index, data); }
    [QGLNativeAPI("glGetIntegeri_v")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetIntegeri_v = null;
     #endregion
}
