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

// Bindings generated at 2025-08-30 15:45:08.698224
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_sparse_buffer", true, false)]
public static unsafe class GLEXT_ARBsparsebuffer
{
    #region Enums
    public const int GL_SPARSE_STORAGE_BIT_ARB = 0x400;
    public const int GL_SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8;
    #endregion
    
    #region Commands
    public static void glBufferPageCommitmentARB(uint target, nint offset, nint size, bool commit) { QGLNativeAPI.Verify((nint)_glBufferPageCommitmentARB); _glBufferPageCommitmentARB(target, offset, size, commit); }
    [QGLNativeAPI("glBufferPageCommitmentARB")] internal static delegate* unmanaged<uint, nint, nint, bool, void> _glBufferPageCommitmentARB = null;
    
    public static void glNamedBufferPageCommitmentEXT(uint buffer, nint offset, nint size, bool commit) { QGLNativeAPI.Verify((nint)_glNamedBufferPageCommitmentEXT); _glNamedBufferPageCommitmentEXT(buffer, offset, size, commit); }
    [QGLNativeAPI("glNamedBufferPageCommitmentEXT")] internal static delegate* unmanaged<uint, nint, nint, bool, void> _glNamedBufferPageCommitmentEXT = null;
    
    public static void glNamedBufferPageCommitmentARB(uint buffer, nint offset, nint size, bool commit) { QGLNativeAPI.Verify((nint)_glNamedBufferPageCommitmentARB); _glNamedBufferPageCommitmentARB(buffer, offset, size, commit); }
    [QGLNativeAPI("glNamedBufferPageCommitmentARB")] internal static delegate* unmanaged<uint, nint, nint, bool, void> _glNamedBufferPageCommitmentARB = null;
     #endregion
}
