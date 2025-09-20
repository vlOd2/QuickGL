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

// Bindings generated at 2025-09-20 18:58:19.819656
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBbaseinstance
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glDrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance) { QGLFeature.VerifyFunc((nint)_glDrawArraysInstancedBaseInstance); _glDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance); }
    internal static delegate* unmanaged<uint, int, int, int, uint, void> _glDrawArraysInstancedBaseInstance = null;
    
    public static void glDrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance) { QGLFeature.VerifyFunc((nint)_glDrawElementsInstancedBaseInstance); _glDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance); }
    internal static delegate* unmanaged<uint, int, uint, void*, int, uint, void> _glDrawElementsInstancedBaseInstance = null;
    
    public static void glDrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance) { QGLFeature.VerifyFunc((nint)_glDrawElementsInstancedBaseVertexBaseInstance); _glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance); }
    internal static delegate* unmanaged<uint, int, uint, void*, int, int, uint, void> _glDrawElementsInstancedBaseVertexBaseInstance = null;
     #endregion
    
    internal static void Load()
    {
        _glDrawArraysInstancedBaseInstance = (delegate* unmanaged<uint, int, int, int, uint, void>)QuickGL.GetGLProcAddress("glDrawArraysInstancedBaseInstance");
        _glDrawElementsInstancedBaseInstance = (delegate* unmanaged<uint, int, uint, void*, int, uint, void>)QuickGL.GetGLProcAddress("glDrawElementsInstancedBaseInstance");
        _glDrawElementsInstancedBaseVertexBaseInstance = (delegate* unmanaged<uint, int, uint, void*, int, int, uint, void>)QuickGL.GetGLProcAddress("glDrawElementsInstancedBaseVertexBaseInstance");
    }
    
    internal static void Unload()
    {
        _glDrawArraysInstancedBaseInstance = null;
        _glDrawElementsInstancedBaseInstance = null;
        _glDrawElementsInstancedBaseVertexBaseInstance = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_base_instance", true, false);
}
