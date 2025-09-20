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

// Bindings generated at 2025-09-20 18:58:19.832568
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBclipcontrol
{
    #region Enums
    public const int GL_LOWER_LEFT = 0x8CA1;
    public const int GL_UPPER_LEFT = 0x8CA2;
    public const int GL_NEGATIVE_ONE_TO_ONE = 0x935E;
    public const int GL_ZERO_TO_ONE = 0x935F;
    public const int GL_CLIP_ORIGIN = 0x935C;
    public const int GL_CLIP_DEPTH_MODE = 0x935D;
    #endregion
    
    #region Commands
    public static void glClipControl(uint origin, uint depth) { QGLFeature.VerifyFunc((nint)_glClipControl); _glClipControl(origin, depth); }
    internal static delegate* unmanaged<uint, uint, void> _glClipControl = null;
     #endregion
    
    internal static void Load()
    {
        _glClipControl = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glClipControl");
    }
    
    internal static void Unload()
    {
        _glClipControl = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_clip_control", true, false);
}
