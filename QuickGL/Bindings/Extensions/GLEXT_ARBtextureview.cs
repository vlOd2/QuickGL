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

// Bindings generated at 2025-09-20 18:58:20.101643
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtextureview
{
    #region Enums
    public const int GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
    public const int GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
    public const int GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD;
    public const int GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
    public const int GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
    #endregion
    
    #region Commands
    public static void glTextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) { QGLFeature.VerifyFunc((nint)_glTextureView); _glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers); }
    internal static delegate* unmanaged<uint, uint, uint, uint, uint, uint, uint, uint, void> _glTextureView = null;
     #endregion
    
    internal static void Load()
    {
        _glTextureView = (delegate* unmanaged<uint, uint, uint, uint, uint, uint, uint, uint, void>)QuickGL.GetGLProcAddress("glTextureView");
    }
    
    internal static void Unload()
    {
        _glTextureView = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_texture_view", true, false);
}
