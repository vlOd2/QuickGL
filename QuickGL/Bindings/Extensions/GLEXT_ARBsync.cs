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

// Bindings generated at 2025-08-30 15:45:08.709459
namespace QuickGLNS.Bindings.Extensions;

[QGLFeature("GL_ARB_sync", true, false)]
public static unsafe class GLEXT_ARBsync
{
    #region Enums
    public const int GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
    public const int GL_OBJECT_TYPE = 0x9112;
    public const int GL_SYNC_CONDITION = 0x9113;
    public const int GL_SYNC_STATUS = 0x9114;
    public const int GL_SYNC_FLAGS = 0x9115;
    public const int GL_SYNC_FENCE = 0x9116;
    public const int GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
    public const int GL_UNSIGNALED = 0x9118;
    public const int GL_SIGNALED = 0x9119;
    public const int GL_ALREADY_SIGNALED = 0x911A;
    public const int GL_TIMEOUT_EXPIRED = 0x911B;
    public const int GL_CONDITION_SATISFIED = 0x911C;
    public const int GL_WAIT_FAILED = 0x911D;
    public const int GL_SYNC_FLUSH_COMMANDS_BIT = 0x1;
    public const ulong GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
    #endregion
    
    #region Commands
    public static nint glFenceSync(uint condition, uint flags) { QGLNativeAPI.Verify((nint)_glFenceSync); return _glFenceSync(condition, flags); }
    [QGLNativeAPI("glFenceSync")] internal static delegate* unmanaged<uint, uint, nint> _glFenceSync = null;
    
    public static bool glIsSync(nint sync) { QGLNativeAPI.Verify((nint)_glIsSync); return _glIsSync(sync); }
    [QGLNativeAPI("glIsSync")] internal static delegate* unmanaged<nint, bool> _glIsSync = null;
    
    public static void glDeleteSync(nint sync) { QGLNativeAPI.Verify((nint)_glDeleteSync); _glDeleteSync(sync); }
    [QGLNativeAPI("glDeleteSync")] internal static delegate* unmanaged<nint, void> _glDeleteSync = null;
    
    public static uint glClientWaitSync(nint sync, uint flags, ulong timeout) { QGLNativeAPI.Verify((nint)_glClientWaitSync); return _glClientWaitSync(sync, flags, timeout); }
    [QGLNativeAPI("glClientWaitSync")] internal static delegate* unmanaged<nint, uint, ulong, uint> _glClientWaitSync = null;
    
    public static void glWaitSync(nint sync, uint flags, ulong timeout) { QGLNativeAPI.Verify((nint)_glWaitSync); _glWaitSync(sync, flags, timeout); }
    [QGLNativeAPI("glWaitSync")] internal static delegate* unmanaged<nint, uint, ulong, void> _glWaitSync = null;
    
    public static void glGetInteger64v(uint pname, long* data) { QGLNativeAPI.Verify((nint)_glGetInteger64v); _glGetInteger64v(pname, data); }
    [QGLNativeAPI("glGetInteger64v")] internal static delegate* unmanaged<uint, long*, void> _glGetInteger64v = null;
    
    public static void glGetSynciv(nint sync, uint pname, int count, int* length, int* values) { QGLNativeAPI.Verify((nint)_glGetSynciv); _glGetSynciv(sync, pname, count, length, values); }
    [QGLNativeAPI("glGetSynciv")] internal static delegate* unmanaged<nint, uint, int, int*, int*, void> _glGetSynciv = null;
     #endregion
}
