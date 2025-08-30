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

// Bindings generated at 2025-08-30 15:45:08.779305
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_vertex_buffer_object", true, false)]
public static unsafe class GLEXT_ARBvertexbufferobject
{
    #region Enums
    public const int GL_BUFFER_SIZE_ARB = 0x8764;
    public const int GL_BUFFER_USAGE_ARB = 0x8765;
    public const int GL_ARRAY_BUFFER_ARB = 0x8892;
    public const int GL_ELEMENT_ARRAY_BUFFER_ARB = 0x8893;
    public const int GL_ARRAY_BUFFER_BINDING_ARB = 0x8894;
    public const int GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895;
    public const int GL_VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896;
    public const int GL_NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897;
    public const int GL_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898;
    public const int GL_INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899;
    public const int GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A;
    public const int GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B;
    public const int GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C;
    public const int GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D;
    public const int GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E;
    public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F;
    public const int GL_READ_ONLY_ARB = 0x88B8;
    public const int GL_WRITE_ONLY_ARB = 0x88B9;
    public const int GL_READ_WRITE_ARB = 0x88BA;
    public const int GL_BUFFER_ACCESS_ARB = 0x88BB;
    public const int GL_BUFFER_MAPPED_ARB = 0x88BC;
    public const int GL_BUFFER_MAP_POINTER_ARB = 0x88BD;
    public const int GL_STREAM_DRAW_ARB = 0x88E0;
    public const int GL_STREAM_READ_ARB = 0x88E1;
    public const int GL_STREAM_COPY_ARB = 0x88E2;
    public const int GL_STATIC_DRAW_ARB = 0x88E4;
    public const int GL_STATIC_READ_ARB = 0x88E5;
    public const int GL_STATIC_COPY_ARB = 0x88E6;
    public const int GL_DYNAMIC_DRAW_ARB = 0x88E8;
    public const int GL_DYNAMIC_READ_ARB = 0x88E9;
    public const int GL_DYNAMIC_COPY_ARB = 0x88EA;
    #endregion
    
    #region Commands
    public static void glBindBufferARB(uint target, uint buffer) { QGLNativeAPI.Verify((nint)_glBindBufferARB); _glBindBufferARB(target, buffer); }
    [QGLNativeAPI("glBindBufferARB")] internal static delegate* unmanaged<uint, uint, void> _glBindBufferARB = null;
    
    public static void glDeleteBuffersARB(int n, uint* buffers) { QGLNativeAPI.Verify((nint)_glDeleteBuffersARB); _glDeleteBuffersARB(n, buffers); }
    [QGLNativeAPI("glDeleteBuffersARB")] internal static delegate* unmanaged<int, uint*, void> _glDeleteBuffersARB = null;
    
    public static void glGenBuffersARB(int n, uint* buffers) { QGLNativeAPI.Verify((nint)_glGenBuffersARB); _glGenBuffersARB(n, buffers); }
    [QGLNativeAPI("glGenBuffersARB")] internal static delegate* unmanaged<int, uint*, void> _glGenBuffersARB = null;
    
    public static bool glIsBufferARB(uint buffer) { QGLNativeAPI.Verify((nint)_glIsBufferARB); return _glIsBufferARB(buffer); }
    [QGLNativeAPI("glIsBufferARB")] internal static delegate* unmanaged<uint, bool> _glIsBufferARB = null;
    
    public static void glBufferDataARB(uint target, nint size, void* data, uint usage) { QGLNativeAPI.Verify((nint)_glBufferDataARB); _glBufferDataARB(target, size, data, usage); }
    [QGLNativeAPI("glBufferDataARB")] internal static delegate* unmanaged<uint, nint, void*, uint, void> _glBufferDataARB = null;
    
    public static void glBufferSubDataARB(uint target, nint offset, nint size, void* data) { QGLNativeAPI.Verify((nint)_glBufferSubDataARB); _glBufferSubDataARB(target, offset, size, data); }
    [QGLNativeAPI("glBufferSubDataARB")] internal static delegate* unmanaged<uint, nint, nint, void*, void> _glBufferSubDataARB = null;
    
    public static void glGetBufferSubDataARB(uint target, nint offset, nint size, void* data) { QGLNativeAPI.Verify((nint)_glGetBufferSubDataARB); _glGetBufferSubDataARB(target, offset, size, data); }
    [QGLNativeAPI("glGetBufferSubDataARB")] internal static delegate* unmanaged<uint, nint, nint, void*, void> _glGetBufferSubDataARB = null;
    
    public static void* glMapBufferARB(uint target, uint access) { QGLNativeAPI.Verify((nint)_glMapBufferARB); return _glMapBufferARB(target, access); }
    [QGLNativeAPI("glMapBufferARB")] internal static delegate* unmanaged<uint, uint, void*> _glMapBufferARB = null;
    
    public static bool glUnmapBufferARB(uint target) { QGLNativeAPI.Verify((nint)_glUnmapBufferARB); return _glUnmapBufferARB(target); }
    [QGLNativeAPI("glUnmapBufferARB")] internal static delegate* unmanaged<uint, bool> _glUnmapBufferARB = null;
    
    public static void glGetBufferParameterivARB(uint target, uint pname, int* @params) { QGLNativeAPI.Verify((nint)_glGetBufferParameterivARB); _glGetBufferParameterivARB(target, pname, @params); }
    [QGLNativeAPI("glGetBufferParameterivARB")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetBufferParameterivARB = null;
    
    public static void glGetBufferPointervARB(uint target, uint pname, void** @params) { QGLNativeAPI.Verify((nint)_glGetBufferPointervARB); _glGetBufferPointervARB(target, pname, @params); }
    [QGLNativeAPI("glGetBufferPointervARB")] internal static delegate* unmanaged<uint, uint, void**, void> _glGetBufferPointervARB = null;
     #endregion
}
