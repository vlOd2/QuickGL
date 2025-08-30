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

// Bindings generated at 2025-08-30 15:45:08.478833
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_buffer_storage", true, false)]
public static unsafe class GLEXT_ARBbufferstorage
{
    #region Enums
    public const int GL_MAP_READ_BIT = 0x1;
    public const int GL_MAP_WRITE_BIT = 0x2;
    public const int GL_MAP_PERSISTENT_BIT = 0x40;
    public const int GL_MAP_COHERENT_BIT = 0x80;
    public const int GL_DYNAMIC_STORAGE_BIT = 0x100;
    public const int GL_CLIENT_STORAGE_BIT = 0x200;
    public const int GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x4000;
    public const int GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
    public const int GL_BUFFER_STORAGE_FLAGS = 0x8220;
    #endregion
    
    #region Commands
    public static void glBufferStorage(uint target, nint size, void* data, uint flags) { QGLNativeAPI.Verify((nint)_glBufferStorage); _glBufferStorage(target, size, data, flags); }
    [QGLNativeAPI("glBufferStorage")] internal static delegate* unmanaged<uint, nint, void*, uint, void> _glBufferStorage = null;
     #endregion
}
