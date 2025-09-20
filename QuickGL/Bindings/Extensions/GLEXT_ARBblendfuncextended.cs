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

// Bindings generated at 2025-09-20 18:58:19.822720
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBblendfuncextended
{
    #region Enums
    public const int GL_SRC1_COLOR = 0x88F9;
    public const int GL_SRC1_ALPHA = 0x8589;
    public const int GL_ONE_MINUS_SRC1_COLOR = 0x88FA;
    public const int GL_ONE_MINUS_SRC1_ALPHA = 0x88FB;
    public const int GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
    #endregion
    
    #region Commands
    public static void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, byte* name) { QGLFeature.VerifyFunc((nint)_glBindFragDataLocationIndexed); _glBindFragDataLocationIndexed(program, colorNumber, index, name); }
    internal static delegate* unmanaged<uint, uint, uint, byte*, void> _glBindFragDataLocationIndexed = null;
    
    public static int glGetFragDataIndex(uint program, byte* name) { QGLFeature.VerifyFunc((nint)_glGetFragDataIndex); return _glGetFragDataIndex(program, name); }
    internal static delegate* unmanaged<uint, byte*, int> _glGetFragDataIndex = null;
     #endregion
    
    internal static void Load()
    {
        _glBindFragDataLocationIndexed = (delegate* unmanaged<uint, uint, uint, byte*, void>)QuickGL.GetGLProcAddress("glBindFragDataLocationIndexed");
        _glGetFragDataIndex = (delegate* unmanaged<uint, byte*, int>)QuickGL.GetGLProcAddress("glGetFragDataIndex");
    }
    
    internal static void Unload()
    {
        _glBindFragDataLocationIndexed = null;
        _glGetFragDataIndex = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_blend_func_extended", true, false);
}
