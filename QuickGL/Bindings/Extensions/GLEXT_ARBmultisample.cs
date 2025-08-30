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

// Bindings generated at 2025-08-30 15:45:08.555768
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_multisample", true, false)]
public static unsafe class GLEXT_ARBmultisample
{
    #region Enums
    public const int GL_MULTISAMPLE_ARB = 0x809D;
    public const int GL_SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;
    public const int GL_SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;
    public const int GL_SAMPLE_COVERAGE_ARB = 0x80A0;
    public const int GL_SAMPLE_BUFFERS_ARB = 0x80A8;
    public const int GL_SAMPLES_ARB = 0x80A9;
    public const int GL_SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;
    public const int GL_SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;
    public const int GL_MULTISAMPLE_BIT_ARB = 0x20000000;
    #endregion
    
    #region Commands
    public static void glSampleCoverageARB(float value, bool invert) { QGLNativeAPI.Verify((nint)_glSampleCoverageARB); _glSampleCoverageARB(value, invert); }
    [QGLNativeAPI("glSampleCoverageARB")] internal static delegate* unmanaged<float, bool, void> _glSampleCoverageARB = null;
     #endregion
}
