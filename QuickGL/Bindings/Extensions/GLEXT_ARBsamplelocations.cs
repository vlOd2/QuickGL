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

// Bindings generated at 2025-09-20 18:58:19.947115
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBsamplelocations
{
    #region Enums
    public const int GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D;
    public const int GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E;
    public const int GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F;
    public const int GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340;
    public const int GL_SAMPLE_LOCATION_ARB = 0x8E50;
    public const int GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341;
    public const int GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342;
    public const int GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343;
    #endregion
    
    #region Commands
    public static void glFramebufferSampleLocationsfvARB(uint target, uint start, int count, float* v) { QGLFeature.VerifyFunc((nint)_glFramebufferSampleLocationsfvARB); _glFramebufferSampleLocationsfvARB(target, start, count, v); }
    internal static delegate* unmanaged<uint, uint, int, float*, void> _glFramebufferSampleLocationsfvARB = null;
    
    public static void glNamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, float* v) { QGLFeature.VerifyFunc((nint)_glNamedFramebufferSampleLocationsfvARB); _glNamedFramebufferSampleLocationsfvARB(framebuffer, start, count, v); }
    internal static delegate* unmanaged<uint, uint, int, float*, void> _glNamedFramebufferSampleLocationsfvARB = null;
    
    public static void glEvaluateDepthValuesARB() { QGLFeature.VerifyFunc((nint)_glEvaluateDepthValuesARB); _glEvaluateDepthValuesARB(); }
    internal static delegate* unmanaged<void> _glEvaluateDepthValuesARB = null;
     #endregion
    
    internal static void Load()
    {
        _glFramebufferSampleLocationsfvARB = (delegate* unmanaged<uint, uint, int, float*, void>)QuickGL.GetGLProcAddress("glFramebufferSampleLocationsfvARB");
        _glNamedFramebufferSampleLocationsfvARB = (delegate* unmanaged<uint, uint, int, float*, void>)QuickGL.GetGLProcAddress("glNamedFramebufferSampleLocationsfvARB");
        _glEvaluateDepthValuesARB = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glEvaluateDepthValuesARB");
    }
    
    internal static void Unload()
    {
        _glFramebufferSampleLocationsfvARB = null;
        _glNamedFramebufferSampleLocationsfvARB = null;
        _glEvaluateDepthValuesARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_sample_locations", true, false);
}
