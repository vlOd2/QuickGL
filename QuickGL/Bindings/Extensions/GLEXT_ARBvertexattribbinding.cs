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

// Bindings generated at 2025-08-30 15:45:08.776407
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_vertex_attrib_binding", true, false)]
public static unsafe class GLEXT_ARBvertexattribbinding
{
    #region Enums
    public const int GL_VERTEX_ATTRIB_BINDING = 0x82D4;
    public const int GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
    public const int GL_VERTEX_BINDING_DIVISOR = 0x82D6;
    public const int GL_VERTEX_BINDING_OFFSET = 0x82D7;
    public const int GL_VERTEX_BINDING_STRIDE = 0x82D8;
    public const int GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
    public const int GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
    #endregion
    
    #region Commands
    public static void glBindVertexBuffer(uint bindingindex, uint buffer, nint offset, int stride) { QGLNativeAPI.Verify((nint)_glBindVertexBuffer); _glBindVertexBuffer(bindingindex, buffer, offset, stride); }
    [QGLNativeAPI("glBindVertexBuffer")] internal static delegate* unmanaged<uint, uint, nint, int, void> _glBindVertexBuffer = null;
    
    public static void glVertexAttribFormat(uint attribindex, int size, uint type, bool normalized, uint relativeoffset) { QGLNativeAPI.Verify((nint)_glVertexAttribFormat); _glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset); }
    [QGLNativeAPI("glVertexAttribFormat")] internal static delegate* unmanaged<uint, int, uint, bool, uint, void> _glVertexAttribFormat = null;
    
    public static void glVertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset) { QGLNativeAPI.Verify((nint)_glVertexAttribIFormat); _glVertexAttribIFormat(attribindex, size, type, relativeoffset); }
    [QGLNativeAPI("glVertexAttribIFormat")] internal static delegate* unmanaged<uint, int, uint, uint, void> _glVertexAttribIFormat = null;
    
    public static void glVertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset) { QGLNativeAPI.Verify((nint)_glVertexAttribLFormat); _glVertexAttribLFormat(attribindex, size, type, relativeoffset); }
    [QGLNativeAPI("glVertexAttribLFormat")] internal static delegate* unmanaged<uint, int, uint, uint, void> _glVertexAttribLFormat = null;
    
    public static void glVertexAttribBinding(uint attribindex, uint bindingindex) { QGLNativeAPI.Verify((nint)_glVertexAttribBinding); _glVertexAttribBinding(attribindex, bindingindex); }
    [QGLNativeAPI("glVertexAttribBinding")] internal static delegate* unmanaged<uint, uint, void> _glVertexAttribBinding = null;
    
    public static void glVertexBindingDivisor(uint bindingindex, uint divisor) { QGLNativeAPI.Verify((nint)_glVertexBindingDivisor); _glVertexBindingDivisor(bindingindex, divisor); }
    [QGLNativeAPI("glVertexBindingDivisor")] internal static delegate* unmanaged<uint, uint, void> _glVertexBindingDivisor = null;
     #endregion
}
