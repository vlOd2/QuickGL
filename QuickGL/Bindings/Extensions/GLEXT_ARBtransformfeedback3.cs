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

// Bindings generated at 2025-09-20 18:58:20.107086
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtransformfeedback3
{
    #region Enums
    public const int GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
    public const int GL_MAX_VERTEX_STREAMS = 0x8E71;
    #endregion
    
    #region Commands
    public static void glDrawTransformFeedbackStream(uint mode, uint id, uint stream) { QGLFeature.VerifyFunc((nint)_glDrawTransformFeedbackStream); _glDrawTransformFeedbackStream(mode, id, stream); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glDrawTransformFeedbackStream = null;
    
    public static void glBeginQueryIndexed(uint target, uint index, uint id) { QGLFeature.VerifyFunc((nint)_glBeginQueryIndexed); _glBeginQueryIndexed(target, index, id); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glBeginQueryIndexed = null;
    
    public static void glEndQueryIndexed(uint target, uint index) { QGLFeature.VerifyFunc((nint)_glEndQueryIndexed); _glEndQueryIndexed(target, index); }
    internal static delegate* unmanaged<uint, uint, void> _glEndQueryIndexed = null;
    
    public static void glGetQueryIndexediv(uint target, uint index, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetQueryIndexediv); _glGetQueryIndexediv(target, index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetQueryIndexediv = null;
     #endregion
    
    internal static void Load()
    {
        _glDrawTransformFeedbackStream = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glDrawTransformFeedbackStream");
        _glBeginQueryIndexed = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glBeginQueryIndexed");
        _glEndQueryIndexed = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glEndQueryIndexed");
        _glGetQueryIndexediv = (delegate* unmanaged<uint, uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetQueryIndexediv");
    }
    
    internal static void Unload()
    {
        _glDrawTransformFeedbackStream = null;
        _glBeginQueryIndexed = null;
        _glEndQueryIndexed = null;
        _glGetQueryIndexediv = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_transform_feedback3", true, false);
}
