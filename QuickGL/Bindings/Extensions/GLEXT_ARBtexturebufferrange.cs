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

// Bindings generated at 2025-09-20 18:58:20.022855
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtexturebufferrange
{
    #region Enums
    public const int GL_TEXTURE_BUFFER_OFFSET = 0x919D;
    public const int GL_TEXTURE_BUFFER_SIZE = 0x919E;
    public const int GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
    #endregion
    
    #region Commands
    public static void glTexBufferRange(uint target, uint internalformat, uint buffer, nint offset, nint size) { QGLFeature.VerifyFunc((nint)_glTexBufferRange); _glTexBufferRange(target, internalformat, buffer, offset, size); }
    internal static delegate* unmanaged<uint, uint, uint, nint, nint, void> _glTexBufferRange = null;
     #endregion
    
    internal static void Load()
    {
        _glTexBufferRange = (delegate* unmanaged<uint, uint, uint, nint, nint, void>)QuickGL.GetGLProcAddress("glTexBufferRange");
    }
    
    internal static void Unload()
    {
        _glTexBufferRange = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_texture_buffer_range", true, false);
}
