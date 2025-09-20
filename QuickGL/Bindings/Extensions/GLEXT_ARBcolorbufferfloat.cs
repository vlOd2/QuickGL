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

// Bindings generated at 2025-09-20 18:58:19.833599
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBcolorbufferfloat
{
    #region Enums
    public const int GL_RGBA_FLOAT_MODE_ARB = 0x8820;
    public const int GL_CLAMP_VERTEX_COLOR_ARB = 0x891A;
    public const int GL_CLAMP_FRAGMENT_COLOR_ARB = 0x891B;
    public const int GL_CLAMP_READ_COLOR_ARB = 0x891C;
    public const int GL_FIXED_ONLY_ARB = 0x891D;
    #endregion
    
    #region Commands
    public static void glClampColorARB(uint target, uint clamp) { QGLFeature.VerifyFunc((nint)_glClampColorARB); _glClampColorARB(target, clamp); }
    internal static delegate* unmanaged<uint, uint, void> _glClampColorARB = null;
     #endregion
    
    internal static void Load()
    {
        _glClampColorARB = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glClampColorARB");
    }
    
    internal static void Unload()
    {
        _glClampColorARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_color_buffer_float", true, false);
}
