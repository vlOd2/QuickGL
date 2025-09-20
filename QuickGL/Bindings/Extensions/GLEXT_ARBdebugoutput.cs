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

// Bindings generated at 2025-09-20 18:58:19.845476
namespace QuickGLNS.Bindings.Extensions;

public static unsafe class GLEXT_ARBdebugoutput
{
    #region Enums
    public const int GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242;
    public const int GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243;
    public const int GL_DEBUG_CALLBACK_FUNCTION_ARB = 0x8244;
    public const int GL_DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245;
    public const int GL_DEBUG_SOURCE_API_ARB = 0x8246;
    public const int GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247;
    public const int GL_DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248;
    public const int GL_DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249;
    public const int GL_DEBUG_SOURCE_APPLICATION_ARB = 0x824A;
    public const int GL_DEBUG_SOURCE_OTHER_ARB = 0x824B;
    public const int GL_DEBUG_TYPE_ERROR_ARB = 0x824C;
    public const int GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D;
    public const int GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E;
    public const int GL_DEBUG_TYPE_PORTABILITY_ARB = 0x824F;
    public const int GL_DEBUG_TYPE_PERFORMANCE_ARB = 0x8250;
    public const int GL_DEBUG_TYPE_OTHER_ARB = 0x8251;
    public const int GL_MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143;
    public const int GL_MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144;
    public const int GL_DEBUG_LOGGED_MESSAGES_ARB = 0x9145;
    public const int GL_DEBUG_SEVERITY_HIGH_ARB = 0x9146;
    public const int GL_DEBUG_SEVERITY_MEDIUM_ARB = 0x9147;
    public const int GL_DEBUG_SEVERITY_LOW_ARB = 0x9148;
    #endregion
    
    #region Commands
    public static void glDebugMessageControlARB(uint source, uint type, uint severity, int count, uint* ids, bool enabled) { QGLFeature.VerifyFunc((nint)_glDebugMessageControlARB); _glDebugMessageControlARB(source, type, severity, count, ids, enabled); }
    internal static delegate* unmanaged<uint, uint, uint, int, uint*, bool, void> _glDebugMessageControlARB = null;
    
    public static void glDebugMessageInsertARB(uint source, uint type, uint id, uint severity, int length, byte* buf) { QGLFeature.VerifyFunc((nint)_glDebugMessageInsertARB); _glDebugMessageInsertARB(source, type, id, severity, length, buf); }
    internal static delegate* unmanaged<uint, uint, uint, uint, int, byte*, void> _glDebugMessageInsertARB = null;
    
    public static void glDebugMessageCallbackARB(nint callback, void* userParam) { QGLFeature.VerifyFunc((nint)_glDebugMessageCallbackARB); _glDebugMessageCallbackARB(callback, userParam); }
    internal static delegate* unmanaged<nint, void*, void> _glDebugMessageCallbackARB = null;
    
    public static uint glGetDebugMessageLogARB(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, byte* messageLog) { QGLFeature.VerifyFunc((nint)_glGetDebugMessageLogARB); return _glGetDebugMessageLogARB(count, bufSize, sources, types, ids, severities, lengths, messageLog); }
    internal static delegate* unmanaged<uint, int, uint*, uint*, uint*, uint*, int*, byte*, uint> _glGetDebugMessageLogARB = null;
     #endregion
    
    internal static void Load()
    {
        _glDebugMessageControlARB = (delegate* unmanaged<uint, uint, uint, int, uint*, bool, void>)QuickGL.GetGLProcAddress("glDebugMessageControlARB");
        _glDebugMessageInsertARB = (delegate* unmanaged<uint, uint, uint, uint, int, byte*, void>)QuickGL.GetGLProcAddress("glDebugMessageInsertARB");
        _glDebugMessageCallbackARB = (delegate* unmanaged<nint, void*, void>)QuickGL.GetGLProcAddress("glDebugMessageCallbackARB");
        _glGetDebugMessageLogARB = (delegate* unmanaged<uint, int, uint*, uint*, uint*, uint*, int*, byte*, uint>)QuickGL.GetGLProcAddress("glGetDebugMessageLogARB");
    }
    
    internal static void Unload()
    {
        _glDebugMessageControlARB = null;
        _glDebugMessageInsertARB = null;
        _glDebugMessageCallbackARB = null;
        _glGetDebugMessageLogARB = null;
    }
    
    internal static QGLFeature FeatureInfo => new("GL_ARB_debug_output", true, false);
}
