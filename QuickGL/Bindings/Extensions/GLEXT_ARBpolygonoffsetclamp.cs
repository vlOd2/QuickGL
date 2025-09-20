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

// Bindings generated at 2025-09-20 18:58:19.931152
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBpolygonoffsetclamp
{
    #region Enums
    public const int GL_POLYGON_OFFSET_CLAMP = 0x8E1B;
    #endregion
    
    #region Commands
    public static void glPolygonOffsetClamp(float factor, float units, float clamp) { QGLFeature.VerifyFunc((nint)_glPolygonOffsetClamp); _glPolygonOffsetClamp(factor, units, clamp); }
    internal static delegate* unmanaged<float, float, float, void> _glPolygonOffsetClamp = null;
     #endregion
    
    internal static void Load()
    {
        _glPolygonOffsetClamp = (delegate* unmanaged<float, float, float, void>)QuickGL.GetGLProcAddress("glPolygonOffsetClamp");
    }
    
    internal static void Unload()
    {
        _glPolygonOffsetClamp = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_polygon_offset_clamp", true, false);
}
