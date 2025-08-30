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

// Bindings generated at 2025-08-30 15:45:08.693756
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_shading_language_include", true, false)]
public static unsafe class GLEXT_ARBshadinglanguageinclude
{
    #region Enums
    public const int GL_SHADER_INCLUDE_ARB = 0x8DAE;
    public const int GL_NAMED_STRING_LENGTH_ARB = 0x8DE9;
    public const int GL_NAMED_STRING_TYPE_ARB = 0x8DEA;
    #endregion
    
    #region Commands
    public static void glNamedStringARB(uint type, int namelen, byte* name, int stringlen, byte* @string) { QGLNativeAPI.Verify((nint)_glNamedStringARB); _glNamedStringARB(type, namelen, name, stringlen, @string); }
    [QGLNativeAPI("glNamedStringARB")] internal static delegate* unmanaged<uint, int, byte*, int, byte*, void> _glNamedStringARB = null;
    
    public static void glDeleteNamedStringARB(int namelen, byte* name) { QGLNativeAPI.Verify((nint)_glDeleteNamedStringARB); _glDeleteNamedStringARB(namelen, name); }
    [QGLNativeAPI("glDeleteNamedStringARB")] internal static delegate* unmanaged<int, byte*, void> _glDeleteNamedStringARB = null;
    
    public static void glCompileShaderIncludeARB(uint shader, int count, byte** path, int* length) { QGLNativeAPI.Verify((nint)_glCompileShaderIncludeARB); _glCompileShaderIncludeARB(shader, count, path, length); }
    [QGLNativeAPI("glCompileShaderIncludeARB")] internal static delegate* unmanaged<uint, int, byte**, int*, void> _glCompileShaderIncludeARB = null;
    
    public static bool glIsNamedStringARB(int namelen, byte* name) { QGLNativeAPI.Verify((nint)_glIsNamedStringARB); return _glIsNamedStringARB(namelen, name); }
    [QGLNativeAPI("glIsNamedStringARB")] internal static delegate* unmanaged<int, byte*, bool> _glIsNamedStringARB = null;
    
    public static void glGetNamedStringARB(int namelen, byte* name, int bufSize, int* stringlen, byte* @string) { QGLNativeAPI.Verify((nint)_glGetNamedStringARB); _glGetNamedStringARB(namelen, name, bufSize, stringlen, @string); }
    [QGLNativeAPI("glGetNamedStringARB")] internal static delegate* unmanaged<int, byte*, int, int*, byte*, void> _glGetNamedStringARB = null;
    
    public static void glGetNamedStringivARB(int namelen, byte* name, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetNamedStringivARB); _glGetNamedStringivARB(namelen, name, pname, @params); }
    [QGLNativeAPI("glGetNamedStringivARB")] internal static delegate* unmanaged<int, byte*, uint, int*, void> _glGetNamedStringivARB = null;
     #endregion
}
