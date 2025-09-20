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

using System.Runtime.InteropServices;
using QuickGLNS.Internal;

// Bindings generated at 2025-09-20 18:58:20.963499
namespace QuickGLNS.Bindings;

public static unsafe class ALC
{
    #region Constants
    public const int ALC_INVALID = 0x0;
    public const int ALC_VERSION_0_1 = 0x1;
    public const int ALC_FALSE = 0x0;
    public const int ALC_TRUE = 0x1;
    public const int ALC_FREQUENCY = 0x1007;
    public const int ALC_REFRESH = 0x1008;
    public const int ALC_SYNC = 0x1009;
    public const int ALC_MONO_SOURCES = 0x1010;
    public const int ALC_STEREO_SOURCES = 0x1011;
    public const int ALC_NO_ERROR = 0x0;
    public const int ALC_INVALID_DEVICE = 0xA001;
    public const int ALC_INVALID_CONTEXT = 0xA002;
    public const int ALC_INVALID_ENUM = 0xA003;
    public const int ALC_INVALID_VALUE = 0xA004;
    public const int ALC_OUT_OF_MEMORY = 0xA005;
    public const int ALC_MAJOR_VERSION = 0x1000;
    public const int ALC_MINOR_VERSION = 0x1001;
    public const int ALC_ATTRIBUTES_SIZE = 0x1002;
    public const int ALC_ALL_ATTRIBUTES = 0x1003;
    public const int ALC_DEFAULT_DEVICE_SPECIFIER = 0x1004;
    public const int ALC_DEVICE_SPECIFIER = 0x1005;
    public const int ALC_EXTENSIONS = 0x1006;
    public const int ALC_EXT_CAPTURE = 0x1;
    public const int ALC_CAPTURE_DEVICE_SPECIFIER = 0x310;
    public const int ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER = 0x311;
    public const int ALC_CAPTURE_SAMPLES = 0x312;
    public const int ALC_ENUMERATE_ALL_EXT = 0x1;
    public const int ALC_DEFAULT_ALL_DEVICES_SPECIFIER = 0x1012;
    public const int ALC_ALL_DEVICES_SPECIFIER = 0x1013;
    #endregion
    
    #region Functions
    public static nint alcCreateContext(nint device, int* attrlist) { QGLFeature.VerifyFunc((nint)_alcCreateContext); return _alcCreateContext(device, attrlist); }
    internal static delegate* unmanaged[Cdecl]<nint, int*, nint> _alcCreateContext = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alcMakeContextCurrent(nint context) { QGLFeature.VerifyFunc((nint)_alcMakeContextCurrent); return _alcMakeContextCurrent(context); }
    internal static delegate* unmanaged[Cdecl]<nint, bool> _alcMakeContextCurrent = null;
    
    public static void alcProcessContext(nint context) { QGLFeature.VerifyFunc((nint)_alcProcessContext); _alcProcessContext(context); }
    internal static delegate* unmanaged[Cdecl]<nint, void> _alcProcessContext = null;
    
    public static void alcSuspendContext(nint context) { QGLFeature.VerifyFunc((nint)_alcSuspendContext); _alcSuspendContext(context); }
    internal static delegate* unmanaged[Cdecl]<nint, void> _alcSuspendContext = null;
    
    public static void alcDestroyContext(nint context) { QGLFeature.VerifyFunc((nint)_alcDestroyContext); _alcDestroyContext(context); }
    internal static delegate* unmanaged[Cdecl]<nint, void> _alcDestroyContext = null;
    
    public static nint alcGetCurrentContext() { QGLFeature.VerifyFunc((nint)_alcGetCurrentContext); return _alcGetCurrentContext(); }
    internal static delegate* unmanaged[Cdecl]<nint> _alcGetCurrentContext = null;
    
    public static nint alcGetContextsDevice(nint context) { QGLFeature.VerifyFunc((nint)_alcGetContextsDevice); return _alcGetContextsDevice(context); }
    internal static delegate* unmanaged[Cdecl]<nint, nint> _alcGetContextsDevice = null;
    
    public static nint alcOpenDevice(byte* devicename) { QGLFeature.VerifyFunc((nint)_alcOpenDevice); return _alcOpenDevice(devicename); }
    internal static delegate* unmanaged[Cdecl]<byte*, nint> _alcOpenDevice = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alcCloseDevice(nint device) { QGLFeature.VerifyFunc((nint)_alcCloseDevice); return _alcCloseDevice(device); }
    internal static delegate* unmanaged[Cdecl]<nint, bool> _alcCloseDevice = null;
    
    public static int alcGetError(nint device) { QGLFeature.VerifyFunc((nint)_alcGetError); return _alcGetError(device); }
    internal static delegate* unmanaged[Cdecl]<nint, int> _alcGetError = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alcIsExtensionPresent(nint device, byte* extname) { QGLFeature.VerifyFunc((nint)_alcIsExtensionPresent); return _alcIsExtensionPresent(device, extname); }
    internal static delegate* unmanaged[Cdecl]<nint, byte*, bool> _alcIsExtensionPresent = null;
    
    public static void* alcGetProcAddress(nint device, byte* funcname) { QGLFeature.VerifyFunc((nint)_alcGetProcAddress); return _alcGetProcAddress(device, funcname); }
    internal static delegate* unmanaged[Cdecl]<nint, byte*, void*> _alcGetProcAddress = null;
    
    public static int alcGetEnumValue(nint device, byte* enumname) { QGLFeature.VerifyFunc((nint)_alcGetEnumValue); return _alcGetEnumValue(device, enumname); }
    internal static delegate* unmanaged[Cdecl]<nint, byte*, int> _alcGetEnumValue = null;
    
    public static byte* alcGetString(nint device, int param) { QGLFeature.VerifyFunc((nint)_alcGetString); return _alcGetString(device, param); }
    internal static delegate* unmanaged[Cdecl]<nint, int, byte*> _alcGetString = null;
    
    public static void alcGetIntegerv(nint device, int param, int size, int* values) { QGLFeature.VerifyFunc((nint)_alcGetIntegerv); _alcGetIntegerv(device, param, size, values); }
    internal static delegate* unmanaged[Cdecl]<nint, int, int, int*, void> _alcGetIntegerv = null;
    
    public static nint alcCaptureOpenDevice(byte* devicename, uint frequency, int format, int buffersize) { QGLFeature.VerifyFunc((nint)_alcCaptureOpenDevice); return _alcCaptureOpenDevice(devicename, frequency, format, buffersize); }
    internal static delegate* unmanaged[Cdecl]<byte*, uint, int, int, nint> _alcCaptureOpenDevice = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alcCaptureCloseDevice(nint device) { QGLFeature.VerifyFunc((nint)_alcCaptureCloseDevice); return _alcCaptureCloseDevice(device); }
    internal static delegate* unmanaged[Cdecl]<nint, bool> _alcCaptureCloseDevice = null;
    
    public static void alcCaptureStart(nint device) { QGLFeature.VerifyFunc((nint)_alcCaptureStart); _alcCaptureStart(device); }
    internal static delegate* unmanaged[Cdecl]<nint, void> _alcCaptureStart = null;
    
    public static void alcCaptureStop(nint device) { QGLFeature.VerifyFunc((nint)_alcCaptureStop); _alcCaptureStop(device); }
    internal static delegate* unmanaged[Cdecl]<nint, void> _alcCaptureStop = null;
    
    public static void alcCaptureSamples(nint device, void* buffer, int samples) { QGLFeature.VerifyFunc((nint)_alcCaptureSamples); _alcCaptureSamples(device, buffer, samples); }
    internal static delegate* unmanaged[Cdecl]<nint, void*, int, void> _alcCaptureSamples = null;
     #endregion
    
    internal static void Load()
    {
        _alcCreateContext = (delegate* unmanaged[Cdecl]<nint, int*, nint>)QuickGL.GetALProcAddress("alcCreateContext");
        _alcMakeContextCurrent = (delegate* unmanaged[Cdecl]<nint, bool>)QuickGL.GetALProcAddress("alcMakeContextCurrent");
        _alcProcessContext = (delegate* unmanaged[Cdecl]<nint, void>)QuickGL.GetALProcAddress("alcProcessContext");
        _alcSuspendContext = (delegate* unmanaged[Cdecl]<nint, void>)QuickGL.GetALProcAddress("alcSuspendContext");
        _alcDestroyContext = (delegate* unmanaged[Cdecl]<nint, void>)QuickGL.GetALProcAddress("alcDestroyContext");
        _alcGetCurrentContext = (delegate* unmanaged[Cdecl]<nint>)QuickGL.GetALProcAddress("alcGetCurrentContext");
        _alcGetContextsDevice = (delegate* unmanaged[Cdecl]<nint, nint>)QuickGL.GetALProcAddress("alcGetContextsDevice");
        _alcOpenDevice = (delegate* unmanaged[Cdecl]<byte*, nint>)QuickGL.GetALProcAddress("alcOpenDevice");
        _alcCloseDevice = (delegate* unmanaged[Cdecl]<nint, bool>)QuickGL.GetALProcAddress("alcCloseDevice");
        _alcGetError = (delegate* unmanaged[Cdecl]<nint, int>)QuickGL.GetALProcAddress("alcGetError");
        _alcIsExtensionPresent = (delegate* unmanaged[Cdecl]<nint, byte*, bool>)QuickGL.GetALProcAddress("alcIsExtensionPresent");
        _alcGetProcAddress = (delegate* unmanaged[Cdecl]<nint, byte*, void*>)QuickGL.GetALProcAddress("alcGetProcAddress");
        _alcGetEnumValue = (delegate* unmanaged[Cdecl]<nint, byte*, int>)QuickGL.GetALProcAddress("alcGetEnumValue");
        _alcGetString = (delegate* unmanaged[Cdecl]<nint, int, byte*>)QuickGL.GetALProcAddress("alcGetString");
        _alcGetIntegerv = (delegate* unmanaged[Cdecl]<nint, int, int, int*, void>)QuickGL.GetALProcAddress("alcGetIntegerv");
        _alcCaptureOpenDevice = (delegate* unmanaged[Cdecl]<byte*, uint, int, int, nint>)QuickGL.GetALProcAddress("alcCaptureOpenDevice");
        _alcCaptureCloseDevice = (delegate* unmanaged[Cdecl]<nint, bool>)QuickGL.GetALProcAddress("alcCaptureCloseDevice");
        _alcCaptureStart = (delegate* unmanaged[Cdecl]<nint, void>)QuickGL.GetALProcAddress("alcCaptureStart");
        _alcCaptureStop = (delegate* unmanaged[Cdecl]<nint, void>)QuickGL.GetALProcAddress("alcCaptureStop");
        _alcCaptureSamples = (delegate* unmanaged[Cdecl]<nint, void*, int, void>)QuickGL.GetALProcAddress("alcCaptureSamples");
    }
    
    internal static void Unload()
    {
        _alcCreateContext = null;
        _alcMakeContextCurrent = null;
        _alcProcessContext = null;
        _alcSuspendContext = null;
        _alcDestroyContext = null;
        _alcGetCurrentContext = null;
        _alcGetContextsDevice = null;
        _alcOpenDevice = null;
        _alcCloseDevice = null;
        _alcGetError = null;
        _alcIsExtensionPresent = null;
        _alcGetProcAddress = null;
        _alcGetEnumValue = null;
        _alcGetString = null;
        _alcGetIntegerv = null;
        _alcCaptureOpenDevice = null;
        _alcCaptureCloseDevice = null;
        _alcCaptureStart = null;
        _alcCaptureStop = null;
        _alcCaptureSamples = null;
    }
    
}
