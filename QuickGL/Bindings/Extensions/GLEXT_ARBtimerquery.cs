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

// Bindings generated at 2025-08-30 15:45:08.760126
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_timer_query", true, false)]
public static unsafe class GLEXT_ARBtimerquery
{
    #region Enums
    public const int GL_TIME_ELAPSED = 0x88BF;
    public const int GL_TIMESTAMP = 0x8E28;
    #endregion
    
    #region Commands
    public static void glQueryCounter(uint id, uint target) { QGLNativeAPI.Verify((nint)_glQueryCounter); _glQueryCounter(id, target); }
    [QGLNativeAPI("glQueryCounter")] internal static delegate* unmanaged<uint, uint, void> _glQueryCounter = null;
    
    public static void glGetQueryObjecti64v(uint id, uint pname, long* @params) { QGLNativeAPI.Verify((nint)_glGetQueryObjecti64v); _glGetQueryObjecti64v(id, pname, @params); }
    [QGLNativeAPI("glGetQueryObjecti64v")] internal static delegate* unmanaged<uint, uint, long*, void> _glGetQueryObjecti64v = null;
    
    public static void glGetQueryObjectui64v(uint id, uint pname, ulong* @params) { QGLNativeAPI.Verify((nint)_glGetQueryObjectui64v); _glGetQueryObjectui64v(id, pname, @params); }
    [QGLNativeAPI("glGetQueryObjectui64v")] internal static delegate* unmanaged<uint, uint, ulong*, void> _glGetQueryObjectui64v = null;
     #endregion
}
