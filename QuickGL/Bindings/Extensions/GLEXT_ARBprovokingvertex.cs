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

// Bindings generated at 2025-08-30 15:45:08.571287
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_provoking_vertex", true, false)]
public static unsafe class GLEXT_ARBprovokingvertex
{
    #region Enums
    public const int GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
    public const int GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
    public const int GL_LAST_VERTEX_CONVENTION = 0x8E4E;
    public const int GL_PROVOKING_VERTEX = 0x8E4F;
    #endregion
    
    #region Commands
    public static void glProvokingVertex(uint mode) { QGLNativeAPI.Verify((nint)_glProvokingVertex); _glProvokingVertex(mode); }
    [QGLNativeAPI("glProvokingVertex")] internal static delegate* unmanaged<uint, void> _glProvokingVertex = null;
     #endregion
}
