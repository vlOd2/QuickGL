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

// Bindings generated at 2025-09-20 18:58:19.817141
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBES32compatibility
{
    #region Enums
    public const int GL_PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE;
    public const int GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381;
    public const int GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382;
    #endregion
    
    #region Commands
    public static void glPrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) { QGLFeature.VerifyFunc((nint)_glPrimitiveBoundingBoxARB); _glPrimitiveBoundingBoxARB(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW); }
    internal static delegate* unmanaged<float, float, float, float, float, float, float, float, void> _glPrimitiveBoundingBoxARB = null;
     #endregion
    
    internal static void Load()
    {
        _glPrimitiveBoundingBoxARB = (delegate* unmanaged<float, float, float, float, float, float, float, float, void>)QuickGL.GetGLProcAddress("glPrimitiveBoundingBoxARB");
    }
    
    internal static void Unload()
    {
        _glPrimitiveBoundingBoxARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_ES3_2_compatibility", true, false);
}
