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

// Bindings generated at 2025-09-20 18:58:19.925329
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBpointparameters
{
    #region Enums
    public const int GL_POINT_SIZE_MIN_ARB = 0x8126;
    public const int GL_POINT_SIZE_MAX_ARB = 0x8127;
    public const int GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128;
    public const int GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129;
    #endregion
    
    #region Commands
    public static void glPointParameterfARB(uint pname, float param) { QGLFeature.VerifyFunc((nint)_glPointParameterfARB); _glPointParameterfARB(pname, param); }
    internal static delegate* unmanaged<uint, float, void> _glPointParameterfARB = null;
    
    public static void glPointParameterfvARB(uint pname, float* @params) { QGLFeature.VerifyFunc((nint)_glPointParameterfvARB); _glPointParameterfvARB(pname, @params); }
    internal static delegate* unmanaged<uint, float*, void> _glPointParameterfvARB = null;
     #endregion
    
    internal static void Load()
    {
        _glPointParameterfARB = (delegate* unmanaged<uint, float, void>)QuickGL.GetGLProcAddress("glPointParameterfARB");
        _glPointParameterfvARB = (delegate* unmanaged<uint, float*, void>)QuickGL.GetGLProcAddress("glPointParameterfvARB");
    }
    
    internal static void Unload()
    {
        _glPointParameterfARB = null;
        _glPointParameterfvARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_point_parameters", true, false);
}
