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

// Bindings generated at 2025-09-20 18:58:20.088517
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtexturestorage
{
    #region Enums
    public const int GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
    #endregion
    
    #region Commands
    public static void glTexStorage1D(uint target, int levels, uint internalformat, int width) { QGLFeature.VerifyFunc((nint)_glTexStorage1D); _glTexStorage1D(target, levels, internalformat, width); }
    internal static delegate* unmanaged<uint, int, uint, int, void> _glTexStorage1D = null;
    
    public static void glTexStorage2D(uint target, int levels, uint internalformat, int width, int height) { QGLFeature.VerifyFunc((nint)_glTexStorage2D); _glTexStorage2D(target, levels, internalformat, width, height); }
    internal static delegate* unmanaged<uint, int, uint, int, int, void> _glTexStorage2D = null;
    
    public static void glTexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth) { QGLFeature.VerifyFunc((nint)_glTexStorage3D); _glTexStorage3D(target, levels, internalformat, width, height, depth); }
    internal static delegate* unmanaged<uint, int, uint, int, int, int, void> _glTexStorage3D = null;
     #endregion
    
    internal static void Load()
    {
        _glTexStorage1D = (delegate* unmanaged<uint, int, uint, int, void>)QuickGL.GetGLProcAddress("glTexStorage1D");
        _glTexStorage2D = (delegate* unmanaged<uint, int, uint, int, int, void>)QuickGL.GetGLProcAddress("glTexStorage2D");
        _glTexStorage3D = (delegate* unmanaged<uint, int, uint, int, int, int, void>)QuickGL.GetGLProcAddress("glTexStorage3D");
    }
    
    internal static void Unload()
    {
        _glTexStorage1D = null;
        _glTexStorage2D = null;
        _glTexStorage3D = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_texture_storage", true, false);
}
