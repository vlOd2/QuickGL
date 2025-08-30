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

// Bindings generated at 2025-08-30 15:45:08.681547
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_shader_storage_buffer_object", true, false)]
public static unsafe class GLEXT_ARBshaderstoragebufferobject
{
    #region Enums
    public const int GL_SHADER_STORAGE_BUFFER = 0x90D2;
    public const int GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
    public const int GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
    public const int GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
    public const int GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
    public const int GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
    public const int GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
    public const int GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
    public const int GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
    public const int GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
    public const int GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
    public const int GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
    public const int GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
    public const int GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
    public const int GL_SHADER_STORAGE_BARRIER_BIT = 0x2000;
    public const int GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
    public const int GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
    #endregion
    
    #region Commands
    public static void glShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding) { QGLNativeAPI.Verify((nint)_glShaderStorageBlockBinding); _glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding); }
    [QGLNativeAPI("glShaderStorageBlockBinding")] internal static delegate* unmanaged<uint, uint, uint, void> _glShaderStorageBlockBinding = null;
     #endregion
}
