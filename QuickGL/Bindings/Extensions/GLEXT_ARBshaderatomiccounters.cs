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

// Bindings generated at 2025-09-20 18:58:19.959422
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBshaderatomiccounters
{
    #region Enums
    public const int GL_ATOMIC_COUNTER_BUFFER = 0x92C0;
    public const int GL_ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
    public const int GL_ATOMIC_COUNTER_BUFFER_START = 0x92C2;
    public const int GL_ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
    public const int GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
    public const int GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
    public const int GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
    public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
    public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
    public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
    public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
    public const int GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
    public const int GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
    public const int GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
    public const int GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
    public const int GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
    public const int GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
    public const int GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
    public const int GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
    public const int GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
    public const int GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
    public const int GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
    public const int GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
    public const int GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
    public const int GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
    public const int GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
    public const int GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
    public const int GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
    public const int GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
    #endregion
    
    #region Commands
    public static void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* @params) { QGLFeature.VerifyFunc((nint)_glGetActiveAtomicCounterBufferiv); _glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, @params); }
    internal static delegate* unmanaged<uint, uint, uint, int*, void> _glGetActiveAtomicCounterBufferiv = null;
     #endregion
    
    internal static void Load()
    {
        _glGetActiveAtomicCounterBufferiv = (delegate* unmanaged<uint, uint, uint, int*, void>)QuickGL.GetGLProcAddress("glGetActiveAtomicCounterBufferiv");
    }
    
    internal static void Unload()
    {
        _glGetActiveAtomicCounterBufferiv = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_shader_atomic_counters", true, false);
}
