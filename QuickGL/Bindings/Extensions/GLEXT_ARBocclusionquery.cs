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

// Bindings generated at 2025-08-30 15:45:08.558773
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_occlusion_query", true, false)]
public static unsafe class GLEXT_ARBocclusionquery
{
    #region Enums
    public const int GL_QUERY_COUNTER_BITS_ARB = 0x8864;
    public const int GL_CURRENT_QUERY_ARB = 0x8865;
    public const int GL_QUERY_RESULT_ARB = 0x8866;
    public const int GL_QUERY_RESULT_AVAILABLE_ARB = 0x8867;
    public const int GL_SAMPLES_PASSED_ARB = 0x8914;
    #endregion
    
    #region Commands
    public static void glGenQueriesARB(int n, uint* ids) { QGLNativeAPI.Verify((nint)_glGenQueriesARB); _glGenQueriesARB(n, ids); }
    [QGLNativeAPI("glGenQueriesARB")] internal static delegate* unmanaged<int, uint*, void> _glGenQueriesARB = null;
    
    public static void glDeleteQueriesARB(int n, uint* ids) { QGLNativeAPI.Verify((nint)_glDeleteQueriesARB); _glDeleteQueriesARB(n, ids); }
    [QGLNativeAPI("glDeleteQueriesARB")] internal static delegate* unmanaged<int, uint*, void> _glDeleteQueriesARB = null;
    
    public static bool glIsQueryARB(uint id) { QGLNativeAPI.Verify((nint)_glIsQueryARB); return _glIsQueryARB(id); }
    [QGLNativeAPI("glIsQueryARB")] internal static delegate* unmanaged<uint, bool> _glIsQueryARB = null;
    
    public static void glBeginQueryARB(uint target, uint id) { QGLNativeAPI.Verify((nint)_glBeginQueryARB); _glBeginQueryARB(target, id); }
    [QGLNativeAPI("glBeginQueryARB")] internal static delegate* unmanaged<uint, uint, void> _glBeginQueryARB = null;
    
    public static void glEndQueryARB(uint target) { QGLNativeAPI.Verify((nint)_glEndQueryARB); _glEndQueryARB(target); }
    [QGLNativeAPI("glEndQueryARB")] internal static delegate* unmanaged<uint, void> _glEndQueryARB = null;
    
    public static void glGetQueryivARB(uint target, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetQueryivARB); _glGetQueryivARB(target, pname, @params); }
    [QGLNativeAPI("glGetQueryivARB")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetQueryivARB = null;
    
    public static void glGetQueryObjectivARB(uint id, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetQueryObjectivARB); _glGetQueryObjectivARB(id, pname, @params); }
    [QGLNativeAPI("glGetQueryObjectivARB")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetQueryObjectivARB = null;
    
    public static void glGetQueryObjectuivARB(uint id, uint pname, uint* @params) { QGLNativeAPI.Verify((nint)_glGetQueryObjectuivARB); _glGetQueryObjectuivARB(id, pname, @params); }
    [QGLNativeAPI("glGetQueryObjectuivARB")] internal static delegate* unmanaged<uint, uint, uint*, void> _glGetQueryObjectuivARB = null;
     #endregion
}
