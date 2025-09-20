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

// Bindings generated at 2025-09-20 18:58:20.104937
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtransformfeedback2
{
    #region Enums
    public const int GL_TRANSFORM_FEEDBACK = 0x8E22;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
    public const int GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
    #endregion
    
    #region Commands
    public static void glBindTransformFeedback(uint target, uint id) { QGLFeature.VerifyFunc((nint)_glBindTransformFeedback); _glBindTransformFeedback(target, id); }
    internal static delegate* unmanaged<uint, uint, void> _glBindTransformFeedback = null;
    
    public static void glDeleteTransformFeedbacks(int n, uint* ids) { QGLFeature.VerifyFunc((nint)_glDeleteTransformFeedbacks); _glDeleteTransformFeedbacks(n, ids); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteTransformFeedbacks = null;
    
    public static void glGenTransformFeedbacks(int n, uint* ids) { QGLFeature.VerifyFunc((nint)_glGenTransformFeedbacks); _glGenTransformFeedbacks(n, ids); }
    internal static delegate* unmanaged<int, uint*, void> _glGenTransformFeedbacks = null;
    
    public static bool glIsTransformFeedback(uint id) { QGLFeature.VerifyFunc((nint)_glIsTransformFeedback); return _glIsTransformFeedback(id); }
    internal static delegate* unmanaged<uint, bool> _glIsTransformFeedback = null;
    
    public static void glPauseTransformFeedback() { QGLFeature.VerifyFunc((nint)_glPauseTransformFeedback); _glPauseTransformFeedback(); }
    internal static delegate* unmanaged<void> _glPauseTransformFeedback = null;
    
    public static void glResumeTransformFeedback() { QGLFeature.VerifyFunc((nint)_glResumeTransformFeedback); _glResumeTransformFeedback(); }
    internal static delegate* unmanaged<void> _glResumeTransformFeedback = null;
    
    public static void glDrawTransformFeedback(uint mode, uint id) { QGLFeature.VerifyFunc((nint)_glDrawTransformFeedback); _glDrawTransformFeedback(mode, id); }
    internal static delegate* unmanaged<uint, uint, void> _glDrawTransformFeedback = null;
     #endregion
    
    internal static void Load()
    {
        _glBindTransformFeedback = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBindTransformFeedback");
        _glDeleteTransformFeedbacks = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteTransformFeedbacks");
        _glGenTransformFeedbacks = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenTransformFeedbacks");
        _glIsTransformFeedback = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsTransformFeedback");
        _glPauseTransformFeedback = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glPauseTransformFeedback");
        _glResumeTransformFeedback = (delegate* unmanaged<void>)QuickGL.GetGLProcAddress("glResumeTransformFeedback");
        _glDrawTransformFeedback = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glDrawTransformFeedback");
    }
    
    internal static void Unload()
    {
        _glBindTransformFeedback = null;
        _glDeleteTransformFeedbacks = null;
        _glGenTransformFeedbacks = null;
        _glIsTransformFeedback = null;
        _glPauseTransformFeedback = null;
        _glResumeTransformFeedback = null;
        _glDrawTransformFeedback = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_transform_feedback2", true, false);
}
