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

// Bindings generated at 2025-01-07 20:24:12.622623
namespace QuickGLNS.Bindings
{
    [GLFeature(false)]
    public static unsafe class GL15
    {
        #region Enums
        public const int GL_BUFFER_SIZE = 0x8764;
        public const int GL_BUFFER_USAGE = 0x8765;
        public const int GL_QUERY_COUNTER_BITS = 0x8864;
        public const int GL_CURRENT_QUERY = 0x8865;
        public const int GL_QUERY_RESULT = 0x8866;
        public const int GL_QUERY_RESULT_AVAILABLE = 0x8867;
        public const int GL_ARRAY_BUFFER = 0x8892;
        public const int GL_ELEMENT_ARRAY_BUFFER = 0x8893;
        public const int GL_ARRAY_BUFFER_BINDING = 0x8894;
        public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
        public const int GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
        public const int GL_READ_ONLY = 0x88B8;
        public const int GL_WRITE_ONLY = 0x88B9;
        public const int GL_READ_WRITE = 0x88BA;
        public const int GL_BUFFER_ACCESS = 0x88BB;
        public const int GL_BUFFER_MAPPED = 0x88BC;
        public const int GL_BUFFER_MAP_POINTER = 0x88BD;
        public const int GL_STREAM_DRAW = 0x88E0;
        public const int GL_STREAM_READ = 0x88E1;
        public const int GL_STREAM_COPY = 0x88E2;
        public const int GL_STATIC_DRAW = 0x88E4;
        public const int GL_STATIC_READ = 0x88E5;
        public const int GL_STATIC_COPY = 0x88E6;
        public const int GL_DYNAMIC_DRAW = 0x88E8;
        public const int GL_DYNAMIC_READ = 0x88E9;
        public const int GL_DYNAMIC_COPY = 0x88EA;
        public const int GL_SAMPLES_PASSED = 0x8914;
        public const int GL_SRC1_ALPHA = 0x8589;
        public const int GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896;
        public const int GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897;
        public const int GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898;
        public const int GL_INDEX_ARRAY_BUFFER_BINDING = 0x8899;
        public const int GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;
        public const int GL_EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;
        public const int GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;
        public const int GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;
        public const int GL_WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;
        public const int GL_FOG_COORD_SRC = 0x8450;
        public const int GL_FOG_COORD = 0x8451;
        public const int GL_CURRENT_FOG_COORD = 0x8453;
        public const int GL_FOG_COORD_ARRAY_TYPE = 0x8454;
        public const int GL_FOG_COORD_ARRAY_STRIDE = 0x8455;
        public const int GL_FOG_COORD_ARRAY_POINTER = 0x8456;
        public const int GL_FOG_COORD_ARRAY = 0x8457;
        public const int GL_FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D;
        public const int GL_SRC0_RGB = 0x8580;
        public const int GL_SRC1_RGB = 0x8581;
        public const int GL_SRC2_RGB = 0x8582;
        public const int GL_SRC0_ALPHA = 0x8588;
        public const int GL_SRC2_ALPHA = 0x858A;
        #endregion
        
        #region Commands
        public static void glGenQueries(int n, uint* ids) => _glGenQueries(n, ids);
        [QGLNativeAPI("glGenQueries")] internal static delegate* unmanaged<int, uint*, void> _glGenQueries = null;
        
        public static void glDeleteQueries(int n, uint* ids) => _glDeleteQueries(n, ids);
        [QGLNativeAPI("glDeleteQueries")] internal static delegate* unmanaged<int, uint*, void> _glDeleteQueries = null;
        
        public static bool glIsQuery(uint id) => _glIsQuery(id);
        [QGLNativeAPI("glIsQuery")] internal static delegate* unmanaged<uint, bool> _glIsQuery = null;
        
        public static void glBeginQuery(uint target, uint id) => _glBeginQuery(target, id);
        [QGLNativeAPI("glBeginQuery")] internal static delegate* unmanaged<uint, uint, void> _glBeginQuery = null;
        
        public static void glEndQuery(uint target) => _glEndQuery(target);
        [QGLNativeAPI("glEndQuery")] internal static delegate* unmanaged<uint, void> _glEndQuery = null;
        
        public static void glGetQueryiv(uint target, uint pname, int* @params) => _glGetQueryiv(target, pname, @params);
        [QGLNativeAPI("glGetQueryiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetQueryiv = null;
        
        public static void glGetQueryObjectiv(uint id, uint pname, int* @params) => _glGetQueryObjectiv(id, pname, @params);
        [QGLNativeAPI("glGetQueryObjectiv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetQueryObjectiv = null;
        
        public static void glGetQueryObjectuiv(uint id, uint pname, uint* @params) => _glGetQueryObjectuiv(id, pname, @params);
        [QGLNativeAPI("glGetQueryObjectuiv")] internal static delegate* unmanaged<uint, uint, uint*, void> _glGetQueryObjectuiv = null;
        
        public static void glBindBuffer(uint target, uint buffer) => _glBindBuffer(target, buffer);
        [QGLNativeAPI("glBindBuffer")] internal static delegate* unmanaged<uint, uint, void> _glBindBuffer = null;
        
        public static void glDeleteBuffers(int n, uint* buffers) => _glDeleteBuffers(n, buffers);
        [QGLNativeAPI("glDeleteBuffers")] internal static delegate* unmanaged<int, uint*, void> _glDeleteBuffers = null;
        
        public static void glGenBuffers(int n, uint* buffers) => _glGenBuffers(n, buffers);
        [QGLNativeAPI("glGenBuffers")] internal static delegate* unmanaged<int, uint*, void> _glGenBuffers = null;
        
        public static bool glIsBuffer(uint buffer) => _glIsBuffer(buffer);
        [QGLNativeAPI("glIsBuffer")] internal static delegate* unmanaged<uint, bool> _glIsBuffer = null;
        
        public static void glBufferData(uint target, nint size, void* data, uint usage) => _glBufferData(target, size, data, usage);
        [QGLNativeAPI("glBufferData")] internal static delegate* unmanaged<uint, nint, void*, uint, void> _glBufferData = null;
        
        public static void glBufferSubData(uint target, nint offset, nint size, void* data) => _glBufferSubData(target, offset, size, data);
        [QGLNativeAPI("glBufferSubData")] internal static delegate* unmanaged<uint, nint, nint, void*, void> _glBufferSubData = null;
        
        public static void glGetBufferSubData(uint target, nint offset, nint size, void* data) => _glGetBufferSubData(target, offset, size, data);
        [QGLNativeAPI("glGetBufferSubData")] internal static delegate* unmanaged<uint, nint, nint, void*, void> _glGetBufferSubData = null;
        
        public static void* glMapBuffer(uint target, uint access) => _glMapBuffer(target, access);
        [QGLNativeAPI("glMapBuffer")] internal static delegate* unmanaged<uint, uint, void*> _glMapBuffer = null;
        
        public static bool glUnmapBuffer(uint target) => _glUnmapBuffer(target);
        [QGLNativeAPI("glUnmapBuffer")] internal static delegate* unmanaged<uint, bool> _glUnmapBuffer = null;
        
        public static void glGetBufferParameteriv(uint target, uint pname, int* @params) => _glGetBufferParameteriv(target, pname, @params);
        [QGLNativeAPI("glGetBufferParameteriv")] internal static delegate* unmanaged<uint, uint, int*, void> _glGetBufferParameteriv = null;
        
        public static void glGetBufferPointerv(uint target, uint pname, void** @params) => _glGetBufferPointerv(target, pname, @params);
        [QGLNativeAPI("glGetBufferPointerv")] internal static delegate* unmanaged<uint, uint, void**, void> _glGetBufferPointerv = null;
        #endregion
    }
}
