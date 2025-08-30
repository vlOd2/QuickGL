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

// Bindings generated at 2025-08-30 15:45:08.761644
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_transform_feedback2", true, false)]
public static unsafe class GLEXT_ARBtransformfeedback2
{
    #region Enums
    public const int GL_TRANSFORM_FEEDBACK = 0x8E22;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
    public const int GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
    public const int GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
    #endregion
    
    #region Commands
    public static void glBindTransformFeedback(uint target, uint id) { QGLNativeAPI.Verify((nint)_glBindTransformFeedback); _glBindTransformFeedback(target, id); }
    [QGLNativeAPI("glBindTransformFeedback")] internal static delegate* unmanaged<uint, uint, void> _glBindTransformFeedback = null;
    
    public static void glDeleteTransformFeedbacks(int n, uint* ids) { QGLNativeAPI.Verify((nint)_glDeleteTransformFeedbacks); _glDeleteTransformFeedbacks(n, ids); }
    [QGLNativeAPI("glDeleteTransformFeedbacks")] internal static delegate* unmanaged<int, uint*, void> _glDeleteTransformFeedbacks = null;
    
    public static void glGenTransformFeedbacks(int n, uint* ids) { QGLNativeAPI.Verify((nint)_glGenTransformFeedbacks); _glGenTransformFeedbacks(n, ids); }
    [QGLNativeAPI("glGenTransformFeedbacks")] internal static delegate* unmanaged<int, uint*, void> _glGenTransformFeedbacks = null;
    
    public static bool glIsTransformFeedback(uint id) { QGLNativeAPI.Verify((nint)_glIsTransformFeedback); return _glIsTransformFeedback(id); }
    [QGLNativeAPI("glIsTransformFeedback")] internal static delegate* unmanaged<uint, bool> _glIsTransformFeedback = null;
    
    public static void glPauseTransformFeedback() { QGLNativeAPI.Verify((nint)_glPauseTransformFeedback); _glPauseTransformFeedback(); }
    [QGLNativeAPI("glPauseTransformFeedback")] internal static delegate* unmanaged<void> _glPauseTransformFeedback = null;
    
    public static void glResumeTransformFeedback() { QGLNativeAPI.Verify((nint)_glResumeTransformFeedback); _glResumeTransformFeedback(); }
    [QGLNativeAPI("glResumeTransformFeedback")] internal static delegate* unmanaged<void> _glResumeTransformFeedback = null;
    
    public static void glDrawTransformFeedback(uint mode, uint id) { QGLNativeAPI.Verify((nint)_glDrawTransformFeedback); _glDrawTransformFeedback(mode, id); }
    [QGLNativeAPI("glDrawTransformFeedback")] internal static delegate* unmanaged<uint, uint, void> _glDrawTransformFeedback = null;
     #endregion
}
