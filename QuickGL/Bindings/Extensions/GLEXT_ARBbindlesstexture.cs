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

// Bindings generated at 2025-09-20 18:58:19.820979
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBbindlesstexture
{
    #region Enums
    public const int GL_UNSIGNED_INT64_ARB = 0x140F;
    #endregion
    
    #region Commands
    public static ulong glGetTextureHandleARB(uint texture) { QGLFeature.VerifyFunc((nint)_glGetTextureHandleARB); return _glGetTextureHandleARB(texture); }
    internal static delegate* unmanaged<uint, ulong> _glGetTextureHandleARB = null;
    
    public static ulong glGetTextureSamplerHandleARB(uint texture, uint sampler) { QGLFeature.VerifyFunc((nint)_glGetTextureSamplerHandleARB); return _glGetTextureSamplerHandleARB(texture, sampler); }
    internal static delegate* unmanaged<uint, uint, ulong> _glGetTextureSamplerHandleARB = null;
    
    public static void glMakeTextureHandleResidentARB(ulong handle) { QGLFeature.VerifyFunc((nint)_glMakeTextureHandleResidentARB); _glMakeTextureHandleResidentARB(handle); }
    internal static delegate* unmanaged<ulong, void> _glMakeTextureHandleResidentARB = null;
    
    public static void glMakeTextureHandleNonResidentARB(ulong handle) { QGLFeature.VerifyFunc((nint)_glMakeTextureHandleNonResidentARB); _glMakeTextureHandleNonResidentARB(handle); }
    internal static delegate* unmanaged<ulong, void> _glMakeTextureHandleNonResidentARB = null;
    
    public static ulong glGetImageHandleARB(uint texture, int level, bool layered, int layer, uint format) { QGLFeature.VerifyFunc((nint)_glGetImageHandleARB); return _glGetImageHandleARB(texture, level, layered, layer, format); }
    internal static delegate* unmanaged<uint, int, bool, int, uint, ulong> _glGetImageHandleARB = null;
    
    public static void glMakeImageHandleResidentARB(ulong handle, uint access) { QGLFeature.VerifyFunc((nint)_glMakeImageHandleResidentARB); _glMakeImageHandleResidentARB(handle, access); }
    internal static delegate* unmanaged<ulong, uint, void> _glMakeImageHandleResidentARB = null;
    
    public static void glMakeImageHandleNonResidentARB(ulong handle) { QGLFeature.VerifyFunc((nint)_glMakeImageHandleNonResidentARB); _glMakeImageHandleNonResidentARB(handle); }
    internal static delegate* unmanaged<ulong, void> _glMakeImageHandleNonResidentARB = null;
    
    public static void glUniformHandleui64ARB(int location, ulong value) { QGLFeature.VerifyFunc((nint)_glUniformHandleui64ARB); _glUniformHandleui64ARB(location, value); }
    internal static delegate* unmanaged<int, ulong, void> _glUniformHandleui64ARB = null;
    
    public static void glUniformHandleui64vARB(int location, int count, ulong* value) { QGLFeature.VerifyFunc((nint)_glUniformHandleui64vARB); _glUniformHandleui64vARB(location, count, value); }
    internal static delegate* unmanaged<int, int, ulong*, void> _glUniformHandleui64vARB = null;
    
    public static void glProgramUniformHandleui64ARB(uint program, int location, ulong value) { QGLFeature.VerifyFunc((nint)_glProgramUniformHandleui64ARB); _glProgramUniformHandleui64ARB(program, location, value); }
    internal static delegate* unmanaged<uint, int, ulong, void> _glProgramUniformHandleui64ARB = null;
    
    public static void glProgramUniformHandleui64vARB(uint program, int location, int count, ulong* values) { QGLFeature.VerifyFunc((nint)_glProgramUniformHandleui64vARB); _glProgramUniformHandleui64vARB(program, location, count, values); }
    internal static delegate* unmanaged<uint, int, int, ulong*, void> _glProgramUniformHandleui64vARB = null;
    
    public static bool glIsTextureHandleResidentARB(ulong handle) { QGLFeature.VerifyFunc((nint)_glIsTextureHandleResidentARB); return _glIsTextureHandleResidentARB(handle); }
    internal static delegate* unmanaged<ulong, bool> _glIsTextureHandleResidentARB = null;
    
    public static bool glIsImageHandleResidentARB(ulong handle) { QGLFeature.VerifyFunc((nint)_glIsImageHandleResidentARB); return _glIsImageHandleResidentARB(handle); }
    internal static delegate* unmanaged<ulong, bool> _glIsImageHandleResidentARB = null;
    
    public static void glVertexAttribL1ui64ARB(uint index, ulong x) { QGLFeature.VerifyFunc((nint)_glVertexAttribL1ui64ARB); _glVertexAttribL1ui64ARB(index, x); }
    internal static delegate* unmanaged<uint, ulong, void> _glVertexAttribL1ui64ARB = null;
    
    public static void glVertexAttribL1ui64vARB(uint index, ulong* v) { QGLFeature.VerifyFunc((nint)_glVertexAttribL1ui64vARB); _glVertexAttribL1ui64vARB(index, v); }
    internal static delegate* unmanaged<uint, ulong*, void> _glVertexAttribL1ui64vARB = null;
    
    public static void glGetVertexAttribLui64vARB(uint index, uint pname, ulong* @params) { QGLFeature.VerifyFunc((nint)_glGetVertexAttribLui64vARB); _glGetVertexAttribLui64vARB(index, pname, @params); }
    internal static delegate* unmanaged<uint, uint, ulong*, void> _glGetVertexAttribLui64vARB = null;
     #endregion
    
    internal static void Load()
    {
        _glGetTextureHandleARB = (delegate* unmanaged<uint, ulong>)QuickGL.GetGLProcAddress("glGetTextureHandleARB");
        _glGetTextureSamplerHandleARB = (delegate* unmanaged<uint, uint, ulong>)QuickGL.GetGLProcAddress("glGetTextureSamplerHandleARB");
        _glMakeTextureHandleResidentARB = (delegate* unmanaged<ulong, void>)QuickGL.GetGLProcAddress("glMakeTextureHandleResidentARB");
        _glMakeTextureHandleNonResidentARB = (delegate* unmanaged<ulong, void>)QuickGL.GetGLProcAddress("glMakeTextureHandleNonResidentARB");
        _glGetImageHandleARB = (delegate* unmanaged<uint, int, bool, int, uint, ulong>)QuickGL.GetGLProcAddress("glGetImageHandleARB");
        _glMakeImageHandleResidentARB = (delegate* unmanaged<ulong, uint, void>)QuickGL.GetGLProcAddress("glMakeImageHandleResidentARB");
        _glMakeImageHandleNonResidentARB = (delegate* unmanaged<ulong, void>)QuickGL.GetGLProcAddress("glMakeImageHandleNonResidentARB");
        _glUniformHandleui64ARB = (delegate* unmanaged<int, ulong, void>)QuickGL.GetGLProcAddress("glUniformHandleui64ARB");
        _glUniformHandleui64vARB = (delegate* unmanaged<int, int, ulong*, void>)QuickGL.GetGLProcAddress("glUniformHandleui64vARB");
        _glProgramUniformHandleui64ARB = (delegate* unmanaged<uint, int, ulong, void>)QuickGL.GetGLProcAddress("glProgramUniformHandleui64ARB");
        _glProgramUniformHandleui64vARB = (delegate* unmanaged<uint, int, int, ulong*, void>)QuickGL.GetGLProcAddress("glProgramUniformHandleui64vARB");
        _glIsTextureHandleResidentARB = (delegate* unmanaged<ulong, bool>)QuickGL.GetGLProcAddress("glIsTextureHandleResidentARB");
        _glIsImageHandleResidentARB = (delegate* unmanaged<ulong, bool>)QuickGL.GetGLProcAddress("glIsImageHandleResidentARB");
        _glVertexAttribL1ui64ARB = (delegate* unmanaged<uint, ulong, void>)QuickGL.GetGLProcAddress("glVertexAttribL1ui64ARB");
        _glVertexAttribL1ui64vARB = (delegate* unmanaged<uint, ulong*, void>)QuickGL.GetGLProcAddress("glVertexAttribL1ui64vARB");
        _glGetVertexAttribLui64vARB = (delegate* unmanaged<uint, uint, ulong*, void>)QuickGL.GetGLProcAddress("glGetVertexAttribLui64vARB");
    }
    
    internal static void Unload()
    {
        _glGetTextureHandleARB = null;
        _glGetTextureSamplerHandleARB = null;
        _glMakeTextureHandleResidentARB = null;
        _glMakeTextureHandleNonResidentARB = null;
        _glGetImageHandleARB = null;
        _glMakeImageHandleResidentARB = null;
        _glMakeImageHandleNonResidentARB = null;
        _glUniformHandleui64ARB = null;
        _glUniformHandleui64vARB = null;
        _glProgramUniformHandleui64ARB = null;
        _glProgramUniformHandleui64vARB = null;
        _glIsTextureHandleResidentARB = null;
        _glIsImageHandleResidentARB = null;
        _glVertexAttribL1ui64ARB = null;
        _glVertexAttribL1ui64vARB = null;
        _glGetVertexAttribLui64vARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_bindless_texture", true, false);
}
