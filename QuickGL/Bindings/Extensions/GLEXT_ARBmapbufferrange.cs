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

// Bindings generated at 2025-09-20 18:58:19.908614
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBmapbufferrange
{
    #region Enums
    public const int GL_MAP_READ_BIT = 0x1;
    public const int GL_MAP_WRITE_BIT = 0x2;
    public const int GL_MAP_INVALIDATE_RANGE_BIT = 0x4;
    public const int GL_MAP_INVALIDATE_BUFFER_BIT = 0x8;
    public const int GL_MAP_FLUSH_EXPLICIT_BIT = 0x10;
    public const int GL_MAP_UNSYNCHRONIZED_BIT = 0x20;
    #endregion
    
    #region Commands
    public static void* glMapBufferRange(uint target, nint offset, nint length, uint access) { QGLFeature.VerifyFunc((nint)_glMapBufferRange); return _glMapBufferRange(target, offset, length, access); }
    internal static delegate* unmanaged<uint, nint, nint, uint, void*> _glMapBufferRange = null;
    
    public static void glFlushMappedBufferRange(uint target, nint offset, nint length) { QGLFeature.VerifyFunc((nint)_glFlushMappedBufferRange); _glFlushMappedBufferRange(target, offset, length); }
    internal static delegate* unmanaged<uint, nint, nint, void> _glFlushMappedBufferRange = null;
     #endregion
    
    internal static void Load()
    {
        _glMapBufferRange = (delegate* unmanaged<uint, nint, nint, uint, void*>)QuickGL.GetGLProcAddress("glMapBufferRange");
        _glFlushMappedBufferRange = (delegate* unmanaged<uint, nint, nint, void>)QuickGL.GetGLProcAddress("glFlushMappedBufferRange");
    }
    
    internal static void Unload()
    {
        _glMapBufferRange = null;
        _glFlushMappedBufferRange = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_map_buffer_range", true, false);
}
