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

// Bindings generated at 2025-08-30 15:45:08.477017
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_bindless_texture", true, false)]
public static unsafe class GLEXT_ARBbindlesstexture
{
    #region Enums
    public const int GL_UNSIGNED_INT64_ARB = 0x140F;
    #endregion
    
    #region Commands
    public static ulong glGetTextureHandleARB(uint texture) { QGLNativeAPI.Verify((nint)_glGetTextureHandleARB); return _glGetTextureHandleARB(texture); }
    [QGLNativeAPI("glGetTextureHandleARB")] internal static delegate* unmanaged<uint, ulong> _glGetTextureHandleARB = null;
    
    public static ulong glGetTextureSamplerHandleARB(uint texture, uint sampler) { QGLNativeAPI.Verify((nint)_glGetTextureSamplerHandleARB); return _glGetTextureSamplerHandleARB(texture, sampler); }
    [QGLNativeAPI("glGetTextureSamplerHandleARB")] internal static delegate* unmanaged<uint, uint, ulong> _glGetTextureSamplerHandleARB = null;
    
    public static void glMakeTextureHandleResidentARB(ulong handle) { QGLNativeAPI.Verify((nint)_glMakeTextureHandleResidentARB); _glMakeTextureHandleResidentARB(handle); }
    [QGLNativeAPI("glMakeTextureHandleResidentARB")] internal static delegate* unmanaged<ulong, void> _glMakeTextureHandleResidentARB = null;
    
    public static void glMakeTextureHandleNonResidentARB(ulong handle) { QGLNativeAPI.Verify((nint)_glMakeTextureHandleNonResidentARB); _glMakeTextureHandleNonResidentARB(handle); }
    [QGLNativeAPI("glMakeTextureHandleNonResidentARB")] internal static delegate* unmanaged<ulong, void> _glMakeTextureHandleNonResidentARB = null;
    
    public static ulong glGetImageHandleARB(uint texture, int level, bool layered, int layer, uint format) { QGLNativeAPI.Verify((nint)_glGetImageHandleARB); return _glGetImageHandleARB(texture, level, layered, layer, format); }
    [QGLNativeAPI("glGetImageHandleARB")] internal static delegate* unmanaged<uint, int, bool, int, uint, ulong> _glGetImageHandleARB = null;
    
    public static void glMakeImageHandleResidentARB(ulong handle, uint access) { QGLNativeAPI.Verify((nint)_glMakeImageHandleResidentARB); _glMakeImageHandleResidentARB(handle, access); }
    [QGLNativeAPI("glMakeImageHandleResidentARB")] internal static delegate* unmanaged<ulong, uint, void> _glMakeImageHandleResidentARB = null;
    
    public static void glMakeImageHandleNonResidentARB(ulong handle) { QGLNativeAPI.Verify((nint)_glMakeImageHandleNonResidentARB); _glMakeImageHandleNonResidentARB(handle); }
    [QGLNativeAPI("glMakeImageHandleNonResidentARB")] internal static delegate* unmanaged<ulong, void> _glMakeImageHandleNonResidentARB = null;
    
    public static void glUniformHandleui64ARB(int location, ulong value) { QGLNativeAPI.Verify((nint)_glUniformHandleui64ARB); _glUniformHandleui64ARB(location, value); }
    [QGLNativeAPI("glUniformHandleui64ARB")] internal static delegate* unmanaged<int, ulong, void> _glUniformHandleui64ARB = null;
    
    public static void glUniformHandleui64vARB(int location, int count, ulong* value) { QGLNativeAPI.Verify((nint)_glUniformHandleui64vARB); _glUniformHandleui64vARB(location, count, value); }
    [QGLNativeAPI("glUniformHandleui64vARB")] internal static delegate* unmanaged<int, int, ulong*, void> _glUniformHandleui64vARB = null;
    
    public static void glProgramUniformHandleui64ARB(uint program, int location, ulong value) { QGLNativeAPI.Verify((nint)_glProgramUniformHandleui64ARB); _glProgramUniformHandleui64ARB(program, location, value); }
    [QGLNativeAPI("glProgramUniformHandleui64ARB")] internal static delegate* unmanaged<uint, int, ulong, void> _glProgramUniformHandleui64ARB = null;
    
    public static void glProgramUniformHandleui64vARB(uint program, int location, int count, ulong* values) { QGLNativeAPI.Verify((nint)_glProgramUniformHandleui64vARB); _glProgramUniformHandleui64vARB(program, location, count, values); }
    [QGLNativeAPI("glProgramUniformHandleui64vARB")] internal static delegate* unmanaged<uint, int, int, ulong*, void> _glProgramUniformHandleui64vARB = null;
    
    public static bool glIsTextureHandleResidentARB(ulong handle) { QGLNativeAPI.Verify((nint)_glIsTextureHandleResidentARB); return _glIsTextureHandleResidentARB(handle); }
    [QGLNativeAPI("glIsTextureHandleResidentARB")] internal static delegate* unmanaged<ulong, bool> _glIsTextureHandleResidentARB = null;
    
    public static bool glIsImageHandleResidentARB(ulong handle) { QGLNativeAPI.Verify((nint)_glIsImageHandleResidentARB); return _glIsImageHandleResidentARB(handle); }
    [QGLNativeAPI("glIsImageHandleResidentARB")] internal static delegate* unmanaged<ulong, bool> _glIsImageHandleResidentARB = null;
    
    public static void glVertexAttribL1ui64ARB(uint index, ulong x) { QGLNativeAPI.Verify((nint)_glVertexAttribL1ui64ARB); _glVertexAttribL1ui64ARB(index, x); }
    [QGLNativeAPI("glVertexAttribL1ui64ARB")] internal static delegate* unmanaged<uint, ulong, void> _glVertexAttribL1ui64ARB = null;
    
    public static void glVertexAttribL1ui64vARB(uint index, ulong* v) { QGLNativeAPI.Verify((nint)_glVertexAttribL1ui64vARB); _glVertexAttribL1ui64vARB(index, v); }
    [QGLNativeAPI("glVertexAttribL1ui64vARB")] internal static delegate* unmanaged<uint, ulong*, void> _glVertexAttribL1ui64vARB = null;
    
    public static void glGetVertexAttribLui64vARB(uint index, uint pname, ulong* @params) { QGLNativeAPI.Verify((nint)_glGetVertexAttribLui64vARB); _glGetVertexAttribLui64vARB(index, pname, @params); }
    [QGLNativeAPI("glGetVertexAttribLui64vARB")] internal static delegate* unmanaged<uint, uint, ulong*, void> _glGetVertexAttribLui64vARB = null;
     #endregion
}
