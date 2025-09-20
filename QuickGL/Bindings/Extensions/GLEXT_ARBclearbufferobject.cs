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

// Bindings generated at 2025-09-20 18:58:19.828514
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBclearbufferobject
{
    #region Enums
    #endregion
    
    #region Commands
    public static void glClearBufferData(uint target, uint internalformat, uint format, uint type, void* data) { QGLFeature.VerifyFunc((nint)_glClearBufferData); _glClearBufferData(target, internalformat, format, type, data); }
    internal static delegate* unmanaged<uint, uint, uint, uint, void*, void> _glClearBufferData = null;
    
    public static void glClearBufferSubData(uint target, uint internalformat, nint offset, nint size, uint format, uint type, void* data) { QGLFeature.VerifyFunc((nint)_glClearBufferSubData); _glClearBufferSubData(target, internalformat, offset, size, format, type, data); }
    internal static delegate* unmanaged<uint, uint, nint, nint, uint, uint, void*, void> _glClearBufferSubData = null;
     #endregion
    
    internal static void Load()
    {
        _glClearBufferData = (delegate* unmanaged<uint, uint, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glClearBufferData");
        _glClearBufferSubData = (delegate* unmanaged<uint, uint, nint, nint, uint, uint, void*, void>)QuickGL.GetGLProcAddress("glClearBufferSubData");
    }
    
    internal static void Unload()
    {
        _glClearBufferData = null;
        _glClearBufferSubData = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_clear_buffer_object", true, false);
}
