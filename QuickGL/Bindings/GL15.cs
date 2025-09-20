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

// Bindings generated at 2025-09-20 18:58:19.744045
namespace QuickGLNS.Bindings;

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
    public static void glGenQueries(int n, uint* ids) { QGLFeature.VerifyFunc((nint)_glGenQueries); _glGenQueries(n, ids); }
    internal static delegate* unmanaged<int, uint*, void> _glGenQueries = null;
    
    public static void glDeleteQueries(int n, uint* ids) { QGLFeature.VerifyFunc((nint)_glDeleteQueries); _glDeleteQueries(n, ids); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteQueries = null;
    
    public static bool glIsQuery(uint id) { QGLFeature.VerifyFunc((nint)_glIsQuery); return _glIsQuery(id); }
    internal static delegate* unmanaged<uint, bool> _glIsQuery = null;
    
    public static void glBeginQuery(uint target, uint id) { QGLFeature.VerifyFunc((nint)_glBeginQuery); _glBeginQuery(target, id); }
    internal static delegate* unmanaged<uint, uint, void> _glBeginQuery = null;
    
    public static void glEndQuery(uint target) { QGLFeature.VerifyFunc((nint)_glEndQuery); _glEndQuery(target); }
    internal static delegate* unmanaged<uint, void> _glEndQuery = null;
    
    public static void glGetQueryiv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetQueryiv); _glGetQueryiv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetQueryiv = null;
    
    public static void glGetQueryObjectiv(uint id, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetQueryObjectiv); _glGetQueryObjectiv(id, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetQueryObjectiv = null;
    
    public static void glGetQueryObjectuiv(uint id, uint pname, uint* @params) { QGLFeature.VerifyFunc((nint)_glGetQueryObjectuiv); _glGetQueryObjectuiv(id, pname, @params); }
    internal static delegate* unmanaged<uint, uint, uint*, void> _glGetQueryObjectuiv = null;
    
    public static void glBindBuffer(uint target, uint buffer) { QGLFeature.VerifyFunc((nint)_glBindBuffer); _glBindBuffer(target, buffer); }
    internal static delegate* unmanaged<uint, uint, void> _glBindBuffer = null;
    
    public static void glDeleteBuffers(int n, uint* buffers) { QGLFeature.VerifyFunc((nint)_glDeleteBuffers); _glDeleteBuffers(n, buffers); }
    internal static delegate* unmanaged<int, uint*, void> _glDeleteBuffers = null;
    
    public static void glGenBuffers(int n, uint* buffers) { QGLFeature.VerifyFunc((nint)_glGenBuffers); _glGenBuffers(n, buffers); }
    internal static delegate* unmanaged<int, uint*, void> _glGenBuffers = null;
    
    public static bool glIsBuffer(uint buffer) { QGLFeature.VerifyFunc((nint)_glIsBuffer); return _glIsBuffer(buffer); }
    internal static delegate* unmanaged<uint, bool> _glIsBuffer = null;
    
    public static void glBufferData(uint target, nint size, void* data, uint usage) { QGLFeature.VerifyFunc((nint)_glBufferData); _glBufferData(target, size, data, usage); }
    internal static delegate* unmanaged<uint, nint, void*, uint, void> _glBufferData = null;
    
    public static void glBufferSubData(uint target, nint offset, nint size, void* data) { QGLFeature.VerifyFunc((nint)_glBufferSubData); _glBufferSubData(target, offset, size, data); }
    internal static delegate* unmanaged<uint, nint, nint, void*, void> _glBufferSubData = null;
    
    public static void glGetBufferSubData(uint target, nint offset, nint size, void* data) { QGLFeature.VerifyFunc((nint)_glGetBufferSubData); _glGetBufferSubData(target, offset, size, data); }
    internal static delegate* unmanaged<uint, nint, nint, void*, void> _glGetBufferSubData = null;
    
    public static void* glMapBuffer(uint target, uint access) { QGLFeature.VerifyFunc((nint)_glMapBuffer); return _glMapBuffer(target, access); }
    internal static delegate* unmanaged<uint, uint, void*> _glMapBuffer = null;
    
    public static bool glUnmapBuffer(uint target) { QGLFeature.VerifyFunc((nint)_glUnmapBuffer); return _glUnmapBuffer(target); }
    internal static delegate* unmanaged<uint, bool> _glUnmapBuffer = null;
    
    public static void glGetBufferParameteriv(uint target, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetBufferParameteriv); _glGetBufferParameteriv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, int*, void> _glGetBufferParameteriv = null;
    
    public static void glGetBufferPointerv(uint target, uint pname, void** @params) { QGLFeature.VerifyFunc((nint)_glGetBufferPointerv); _glGetBufferPointerv(target, pname, @params); }
    internal static delegate* unmanaged<uint, uint, void**, void> _glGetBufferPointerv = null;
     #endregion
    
    internal static void Load()
    {
        _glGenQueries = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenQueries");
        _glDeleteQueries = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteQueries");
        _glIsQuery = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsQuery");
        _glBeginQuery = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBeginQuery");
        _glEndQuery = (delegate* unmanaged<uint, void>)QuickGL.GetGLProcAddress("glEndQuery");
        _glGetQueryiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetQueryiv");
        _glGetQueryObjectiv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetQueryObjectiv");
        _glGetQueryObjectuiv = (delegate* unmanaged<uint, uint, uint*, void>)QuickGL.GetGLProcAddress("glGetQueryObjectuiv");
        _glBindBuffer = (delegate* unmanaged<uint, uint, void>)QuickGL.GetGLProcAddress("glBindBuffer");
        _glDeleteBuffers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glDeleteBuffers");
        _glGenBuffers = (delegate* unmanaged<int, uint*, void>)QuickGL.GetGLProcAddress("glGenBuffers");
        _glIsBuffer = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glIsBuffer");
        _glBufferData = (delegate* unmanaged<uint, nint, void*, uint, void>)QuickGL.GetGLProcAddress("glBufferData");
        _glBufferSubData = (delegate* unmanaged<uint, nint, nint, void*, void>)QuickGL.GetGLProcAddress("glBufferSubData");
        _glGetBufferSubData = (delegate* unmanaged<uint, nint, nint, void*, void>)QuickGL.GetGLProcAddress("glGetBufferSubData");
        _glMapBuffer = (delegate* unmanaged<uint, uint, void*>)QuickGL.GetGLProcAddress("glMapBuffer");
        _glUnmapBuffer = (delegate* unmanaged<uint, bool>)QuickGL.GetGLProcAddress("glUnmapBuffer");
        _glGetBufferParameteriv = (delegate* unmanaged<uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetBufferParameteriv");
        _glGetBufferPointerv = (delegate* unmanaged<uint, uint, void**, void>)QuickGL.GetGLProcAddress("glGetBufferPointerv");
    }
    
    internal static void Unload()
    {
        _glGenQueries = null;
        _glDeleteQueries = null;
        _glIsQuery = null;
        _glBeginQuery = null;
        _glEndQuery = null;
        _glGetQueryiv = null;
        _glGetQueryObjectiv = null;
        _glGetQueryObjectuiv = null;
        _glBindBuffer = null;
        _glDeleteBuffers = null;
        _glGenBuffers = null;
        _glIsBuffer = null;
        _glBufferData = null;
        _glBufferSubData = null;
        _glGetBufferSubData = null;
        _glMapBuffer = null;
        _glUnmapBuffer = null;
        _glGetBufferParameteriv = null;
        _glGetBufferPointerv = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_VERSION_1_5", false, false);
}
