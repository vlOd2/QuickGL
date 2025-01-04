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

// Bindings generated at 2025-01-04 19:06:28.365183
namespace QuickGLNS.Bindings
{
    [GLFeature]
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
        [QGLNativeAPI("glGenQueries")] public static delegate* unmanaged<int, uint*, void> glGenQueries;
        [QGLNativeAPI("glDeleteQueries")] public static delegate* unmanaged<int, uint*, void> glDeleteQueries;
        [QGLNativeAPI("glIsQuery")] public static delegate* unmanaged<uint, bool> glIsQuery;
        [QGLNativeAPI("glBeginQuery")] public static delegate* unmanaged<uint, uint, void> glBeginQuery;
        [QGLNativeAPI("glEndQuery")] public static delegate* unmanaged<uint, void> glEndQuery;
        [QGLNativeAPI("glGetQueryiv")] public static delegate* unmanaged<uint, uint, int*, void> glGetQueryiv;
        [QGLNativeAPI("glGetQueryObjectiv")] public static delegate* unmanaged<uint, uint, int*, void> glGetQueryObjectiv;
        [QGLNativeAPI("glGetQueryObjectuiv")] public static delegate* unmanaged<uint, uint, uint*, void> glGetQueryObjectuiv;
        [QGLNativeAPI("glBindBuffer")] public static delegate* unmanaged<uint, uint, void> glBindBuffer;
        [QGLNativeAPI("glDeleteBuffers")] public static delegate* unmanaged<int, uint*, void> glDeleteBuffers;
        [QGLNativeAPI("glGenBuffers")] public static delegate* unmanaged<int, uint*, void> glGenBuffers;
        [QGLNativeAPI("glIsBuffer")] public static delegate* unmanaged<uint, bool> glIsBuffer;
        [QGLNativeAPI("glBufferData")] public static delegate* unmanaged<uint, nint, void*, uint, void> glBufferData;
        [QGLNativeAPI("glBufferSubData")] public static delegate* unmanaged<uint, nint, nint, void*, void> glBufferSubData;
        [QGLNativeAPI("glGetBufferSubData")] public static delegate* unmanaged<uint, nint, nint, void*, void> glGetBufferSubData;
        [QGLNativeAPI("glMapBuffer")] public static delegate* unmanaged<uint, uint, void*> glMapBuffer;
        [QGLNativeAPI("glUnmapBuffer")] public static delegate* unmanaged<uint, bool> glUnmapBuffer;
        [QGLNativeAPI("glGetBufferParameteriv")] public static delegate* unmanaged<uint, uint, int*, void> glGetBufferParameteriv;
        [QGLNativeAPI("glGetBufferPointerv")] public static delegate* unmanaged<uint, uint, void**, void> glGetBufferPointerv;
        #endregion
    }
}
