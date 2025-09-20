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

// Bindings generated at 2025-09-20 18:58:20.122720
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBvertexarrayobject
{
    #region Enums
    public const int GL_VERTEX_ARRAY_BINDING = 0x85B5;
    #endregion
    
    #region Commands
    public static void glBindVertexArray(uint array) { QGLFeature.VerifyFunc((nint)_glBindVertexArray); _glBindVertexArray(array); }
    internal static delegate* unmanaged<uint, void> _glBindVertexArray = null;
    
    public static void glDeleteVertexArrays(int n, uint* arrays) { QGLFeature.VerifyFunc((nint)_glDeleteVertexArrays); _glDeleteVertexArrays(n, arrays); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteVertexArrays = null;
    
    public static void glGenVertexArrays(int n, uint* arrays) { QGLFeature.VerifyFunc((nint)_glGenVertexArrays); _glGenVertexArrays(n, arrays); }
    internal static delegate* unmanaged<int, uint*, void> _glGenVertexArrays = null;
    
    public static bool glIsVertexArray(uint array) { QGLFeature.VerifyFunc((nint)_glIsVertexArray); return _glIsVertexArray(array); }
    internal static delegate* unmanaged<uint, bool> _glIsVertexArray = null;
     #endregion
    
    internal static void Load()
    {
        _glBindVertexArray = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glBindVertexArray");
        _glDeleteVertexArrays = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteVertexArrays");
        _glGenVertexArrays = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenVertexArrays");
        _glIsVertexArray = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsVertexArray");
    }
    
    internal static void Unload()
    {
        _glBindVertexArray = null;
        _glDeleteVertexArrays = null;
        _glGenVertexArrays = null;
        _glIsVertexArray = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_vertex_array_object", true, false);
}
