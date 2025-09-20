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

// Bindings generated at 2025-09-20 18:58:20.108700
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtransformfeedbackinstanced
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glDrawTransformFeedbackInstanced(uint mode, uint id, int instancecount) { QGLFeature.VerifyFunc((nint)_glDrawTransformFeedbackInstanced); _glDrawTransformFeedbackInstanced(mode, id, instancecount); }
    internal static delegate* unmanaged<uint, uint, int, void> _glDrawTransformFeedbackInstanced = null;
    
    public static void glDrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount) { QGLFeature.VerifyFunc((nint)_glDrawTransformFeedbackStreamInstanced); _glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount); }
    internal static delegate* unmanaged<uint, uint, uint, int, void> _glDrawTransformFeedbackStreamInstanced = null;
     #endregion
    
    internal static void Load()
    {
        _glDrawTransformFeedbackInstanced = (delegate* unmanaged<uint, uint, int, void>)QuickGL.GetGLProcAddress("glDrawTransformFeedbackInstanced");
        _glDrawTransformFeedbackStreamInstanced = (delegate* unmanaged<uint, uint, uint, int, void>)QuickGL.GetGLProcAddress("glDrawTransformFeedbackStreamInstanced");
    }
    
    internal static void Unload()
    {
        _glDrawTransformFeedbackInstanced = null;
        _glDrawTransformFeedbackStreamInstanced = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_transform_feedback_instanced", true, false);
}
