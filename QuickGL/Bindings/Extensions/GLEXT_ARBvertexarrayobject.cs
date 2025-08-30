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

// Bindings generated at 2025-08-30 15:45:08.773809
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_vertex_array_object", true, false)]
public static unsafe class GLEXT_ARBvertexarrayobject
{
    #region Enums
    public const int GL_VERTEX_ARRAY_BINDING = 0x85B5;
    #endregion
    
    #region Commands
    public static void glBindVertexArray(uint array) { QGLNativeAPI.Verify((nint)_glBindVertexArray); _glBindVertexArray(array); }
    [QGLNativeAPI("glBindVertexArray")] internal static delegate* unmanaged<uint, void> _glBindVertexArray = null;
    
    public static void glDeleteVertexArrays(int n, uint* arrays) { QGLNativeAPI.Verify((nint)_glDeleteVertexArrays); _glDeleteVertexArrays(n, arrays); }
    [QGLNativeAPI("glDeleteVertexArrays")] internal static delegate* unmanaged<int, uint*, void> _glDeleteVertexArrays = null;
    
    public static void glGenVertexArrays(int n, uint* arrays) { QGLNativeAPI.Verify((nint)_glGenVertexArrays); _glGenVertexArrays(n, arrays); }
    [QGLNativeAPI("glGenVertexArrays")] internal static delegate* unmanaged<int, uint*, void> _glGenVertexArrays = null;
    
    public static bool glIsVertexArray(uint array) { QGLNativeAPI.Verify((nint)_glIsVertexArray); return _glIsVertexArray(array); }
    [QGLNativeAPI("glIsVertexArray")] internal static delegate* unmanaged<uint, bool> _glIsVertexArray = null;
     #endregion
}
