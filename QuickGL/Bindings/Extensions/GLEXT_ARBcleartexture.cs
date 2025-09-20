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

// Bindings generated at 2025-09-20 18:58:19.831074
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBcleartexture
{
    #region Enums
    public const int GL_CLEAR_TEXTURE = 0x9365;
    #endregion
    
    #region Commands
    public static void glClearTexImage(uint texture, int level, uint format, uint type, void* data) { QGLFeature.VerifyFunc((nint)_glClearTexImage); _glClearTexImage(texture, level, format, type, data); }
    internal static delegate* unmanaged<uint, int, uint, uint, void*, void> _glClearTexImage = null;
    
    public static void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data) { QGLFeature.VerifyFunc((nint)_glClearTexSubImage); _glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data); }
    internal static delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void> _glClearTexSubImage = null;
     #endregion
    
    internal static void Load()
    {
        _glClearTexImage = (delegate* unmanaged<uint, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glClearTexImage");
        _glClearTexSubImage = (delegate* unmanaged<uint, int, int, int, int, int, int, int, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glClearTexSubImage");
    }
    
    internal static void Unload()
    {
        _glClearTexImage = null;
        _glClearTexSubImage = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_clear_texture", true, false);
}
