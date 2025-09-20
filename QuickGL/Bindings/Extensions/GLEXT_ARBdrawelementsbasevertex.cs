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

// Bindings generated at 2025-09-20 18:58:19.864170
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBdrawelementsbasevertex
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glDrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex) { QGLFeature.VerifyFunc((nint)_glDrawElementsBaseVertex); _glDrawElementsBaseVertex(mode, count, type, indices, basevertex); }
    internal static delegate* unmanaged<uint, int, uint, void*, int, void> _glDrawElementsBaseVertex = null;
    
    public static void glDrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex) { QGLFeature.VerifyFunc((nint)_glDrawRangeElementsBaseVertex); _glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex); }
    internal static delegate* unmanaged<uint, uint, uint, int, uint, void*, int, void> _glDrawRangeElementsBaseVertex = null;
    
    public static void glDrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex) { QGLFeature.VerifyFunc((nint)_glDrawElementsInstancedBaseVertex); _glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex); }
    internal static delegate* unmanaged<uint, int, uint, void*, int, int, void> _glDrawElementsInstancedBaseVertex = null;
    
    public static void glMultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex) { QGLFeature.VerifyFunc((nint)_glMultiDrawElementsBaseVertex); _glMultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex); }
    internal static delegate* unmanaged<uint, int*, uint, void**, int, int*, void> _glMultiDrawElementsBaseVertex = null;
     #endregion
    
    internal static void Load()
    {
        _glDrawElementsBaseVertex = (delegate* unmanaged<uint, int, uint, void*, int, void>)QuickGL.GetGLProcAddress("glDrawElementsBaseVertex");
        _glDrawRangeElementsBaseVertex = (delegate* unmanaged<uint, uint, uint, int, uint, void*, int, void>)QuickGL.GetGLProcAddress("glDrawRangeElementsBaseVertex");
        _glDrawElementsInstancedBaseVertex = (delegate* unmanaged<uint, int, uint, void*, int, int, void>)QuickGL.GetGLProcAddress("glDrawElementsInstancedBaseVertex");
        _glMultiDrawElementsBaseVertex = (delegate* unmanaged<uint, int*, uint, void**, int, int*, void>)QuickGL.GetGLProcAddress("glMultiDrawElementsBaseVertex");
    }
    
    internal static void Unload()
    {
        _glDrawElementsBaseVertex = null;
        _glDrawRangeElementsBaseVertex = null;
        _glDrawElementsInstancedBaseVertex = null;
        _glMultiDrawElementsBaseVertex = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_draw_elements_base_vertex", true, false);
}
