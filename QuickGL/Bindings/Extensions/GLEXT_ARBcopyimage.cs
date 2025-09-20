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

// Bindings generated at 2025-09-20 18:58:19.842212
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBcopyimage
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glCopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) { QGLFeature.VerifyFunc((nint)_glCopyImageSubData); _glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth); }
    internal static delegate* unmanaged<uint, uint, int, int, int, int, uint, uint, int, int, int, int, int, int, int, void> _glCopyImageSubData = null;
     #endregion
    
    internal static void Load()
    {
        _glCopyImageSubData = (delegate* unmanaged<uint, uint, int, int, int, int, uint, uint, int, int, int, int, int, int, int, void>)QuickGL.GetGLProcAddress("glCopyImageSubData");
    }
    
    internal static void Unload()
    {
        _glCopyImageSubData = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_copy_image", true, false);
}
