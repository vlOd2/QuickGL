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

// Bindings generated at 2025-09-20 18:58:19.987693
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBshadinglanguageinclude
{
    #region Enums
    public const int GL_SHADER_INCLUDE_ARB = 0x8DAE;
    public const int GL_NAMED_STRING_LENGTH_ARB = 0x8DE9;
    public const int GL_NAMED_STRING_TYPE_ARB = 0x8DEA;
    #endregion
    
    #region Commands
    public static void glNamedStringARB(uint type, int namelen, byte* name, int stringlen, byte* @string) { QGLFeature.VerifyFunc((nint)_glNamedStringARB); _glNamedStringARB(type, namelen, name, stringlen, @string); }
    internal static delegate* unmanaged<uint, int, byte*, int, byte*, void> _glNamedStringARB = null;
    
    public static void glDeleteNamedStringARB(int namelen, byte* name) { QGLFeature.VerifyFunc((nint)_glDeleteNamedStringARB); _glDeleteNamedStringARB(namelen, name); }
    internal static delegate* unmanaged<int, byte*, void> _glDeleteNamedStringARB = null;
    
    public static void glCompileShaderIncludeARB(uint shader, int count, byte** path, int* length) { QGLFeature.VerifyFunc((nint)_glCompileShaderIncludeARB); _glCompileShaderIncludeARB(shader, count, path, length); }
    internal static delegate* unmanaged<uint, int, byte**, int*, void> _glCompileShaderIncludeARB = null;
    
    public static bool glIsNamedStringARB(int namelen, byte* name) { QGLFeature.VerifyFunc((nint)_glIsNamedStringARB); return _glIsNamedStringARB(namelen, name); }
    internal static delegate* unmanaged<int, byte*, bool> _glIsNamedStringARB = null;
    
    public static void glGetNamedStringARB(int namelen, byte* name, int bufSize, int* stringlen, byte* @string) { QGLFeature.VerifyFunc((nint)_glGetNamedStringARB); _glGetNamedStringARB(namelen, name, bufSize, stringlen, @string); }
    internal static delegate* unmanaged<int, byte*, int, int*, byte*, void> _glGetNamedStringARB = null;
    
    public static void glGetNamedStringivARB(int namelen, byte* name, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetNamedStringivARB); _glGetNamedStringivARB(namelen, name, pname, @params); }
    internal static delegate* unmanaged<int, byte*, uint, int*, void> _glGetNamedStringivARB = null;
     #endregion
    
    internal static void Load()
    {
        _glNamedStringARB = (delegate* unmanaged<uint, int, byte*, int, byte*, void>)QuickGL.GetGLProcAddress("glNamedStringARB");
        _glDeleteNamedStringARB = (delegate* unmanaged<int, byte*, void>)QuickGL.GetGLProcAddress("glDeleteNamedStringARB");
        _glCompileShaderIncludeARB = (delegate* unmanaged<uint, int, byte**, int*, void>)QuickGL.GetGLProcAddress("glCompileShaderIncludeARB");
        _glIsNamedStringARB = (delegate* unmanaged<int, byte*, bool>)QuickGL.GetGLProcAddress("glIsNamedStringARB");
        _glGetNamedStringARB = (delegate* unmanaged<int, byte*, int, int*, byte*, void>)QuickGL.GetGLProcAddress("glGetNamedStringARB");
        _glGetNamedStringivARB = (delegate* unmanaged<int, byte*, uint, int*, void>)QuickGL.GetGLProcAddress("glGetNamedStringivARB");
    }
    
    internal static void Unload()
    {
        _glNamedStringARB = null;
        _glDeleteNamedStringARB = null;
        _glCompileShaderIncludeARB = null;
        _glIsNamedStringARB = null;
        _glGetNamedStringARB = null;
        _glGetNamedStringivARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_shading_language_include", true, false);
}
