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

// Bindings generated at 2025-09-20 18:58:20.020953
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBtexturebufferobject
{
    #region Enums
    public const int GL_TEXTURE_BUFFER_ARB = 0x8C2A;
    public const int GL_MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B;
    public const int GL_TEXTURE_BINDING_BUFFER_ARB = 0x8C2C;
    public const int GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D;
    public const int GL_TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E;
    #endregion
    
    #region Commands
    public static void glTexBufferARB(uint target, uint internalformat, uint buffer) { QGLFeature.VerifyFunc((nint)_glTexBufferARB); _glTexBufferARB(target, internalformat, buffer); }
    internal static delegate* unmanaged<uint, uint, uint, void> _glTexBufferARB = null;
     #endregion
    
    internal static void Load()
    {
        _glTexBufferARB = (delegate* unmanaged<uint, uint, uint, void>)QuickGL.GetGLProcAddress("glTexBufferARB");
    }
    
    internal static void Unload()
    {
        _glTexBufferARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_texture_buffer_object", true, false);
}
