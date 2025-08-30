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

// Bindings generated at 2025-08-30 15:45:08.473629
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_ES3_2_compatibility", true, false)]
public static unsafe class GLEXT_ARBES32compatibility
{
    #region Enums
    public const int GL_PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE;
    public const int GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381;
    public const int GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382;
    #endregion
    
    #region Commands
    public static void glPrimitiveBoundingBoxARB(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW) { QGLNativeAPI.Verify((nint)_glPrimitiveBoundingBoxARB); _glPrimitiveBoundingBoxARB(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW); }
    [QGLNativeAPI("glPrimitiveBoundingBoxARB")] internal static delegate* unmanaged<float, float, float, float, float, float, float, float, void> _glPrimitiveBoundingBoxARB = null;
     #endregion
}
