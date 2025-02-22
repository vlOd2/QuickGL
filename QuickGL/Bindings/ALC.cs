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

// Bindings generated at 2025-02-22 14:36:34.325284
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
    public static nint alcCreateContext(nint device, int* attrlist) => _alcCreateContext(device, attrlist);
    [QGLNativeAPI("alcCreateContext")] internal static delegate* unmanaged[Cdecl]<nint, int*, nint> _alcCreateContext = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alcMakeContextCurrent(nint context) => _alcMakeContextCurrent(context);
    [QGLNativeAPI("alcMakeContextCurrent")] internal static delegate* unmanaged[Cdecl]<nint, bool> _alcMakeContextCurrent = null;
    
    public static void alcProcessContext(nint context) => _alcProcessContext(context);
    [QGLNativeAPI("alcProcessContext")] internal static delegate* unmanaged[Cdecl]<nint, void> _alcProcessContext = null;
    
    public static void alcSuspendContext(nint context) => _alcSuspendContext(context);
    [QGLNativeAPI("alcSuspendContext")] internal static delegate* unmanaged[Cdecl]<nint, void> _alcSuspendContext = null;
    
    public static void alcDestroyContext(nint context) => _alcDestroyContext(context);
    [QGLNativeAPI("alcDestroyContext")] internal static delegate* unmanaged[Cdecl]<nint, void> _alcDestroyContext = null;
    
    public static nint alcGetCurrentContext() => _alcGetCurrentContext();
    [QGLNativeAPI("alcGetCurrentContext")] internal static delegate* unmanaged[Cdecl]<nint> _alcGetCurrentContext = null;
    
    public static nint alcGetContextsDevice(nint context) => _alcGetContextsDevice(context);
    [QGLNativeAPI("alcGetContextsDevice")] internal static delegate* unmanaged[Cdecl]<nint, nint> _alcGetContextsDevice = null;
    
    public static nint alcOpenDevice(byte* devicename) => _alcOpenDevice(devicename);
    [QGLNativeAPI("alcOpenDevice")] internal static delegate* unmanaged[Cdecl]<byte*, nint> _alcOpenDevice = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alcCloseDevice(nint device) => _alcCloseDevice(device);
    [QGLNativeAPI("alcCloseDevice")] internal static delegate* unmanaged[Cdecl]<nint, bool> _alcCloseDevice = null;
    
    public static int alcGetError(nint device) => _alcGetError(device);
    [QGLNativeAPI("alcGetError")] internal static delegate* unmanaged[Cdecl]<nint, int> _alcGetError = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alcIsExtensionPresent(nint device, byte* extname) => _alcIsExtensionPresent(device, extname);
    [QGLNativeAPI("alcIsExtensionPresent")] internal static delegate* unmanaged[Cdecl]<nint, byte*, bool> _alcIsExtensionPresent = null;
    
    public static void* alcGetProcAddress(nint device, byte* funcname) => _alcGetProcAddress(device, funcname);
    [QGLNativeAPI("alcGetProcAddress")] internal static delegate* unmanaged[Cdecl]<nint, byte*, void*> _alcGetProcAddress = null;
    
    public static int alcGetEnumValue(nint device, byte* enumname) => _alcGetEnumValue(device, enumname);
    [QGLNativeAPI("alcGetEnumValue")] internal static delegate* unmanaged[Cdecl]<nint, byte*, int> _alcGetEnumValue = null;
    
    public static byte* alcGetString(nint device, int param) => _alcGetString(device, param);
    [QGLNativeAPI("alcGetString")] internal static delegate* unmanaged[Cdecl]<nint, int, byte*> _alcGetString = null;
    
    public static void alcGetIntegerv(nint device, int param, int size, int* values) => _alcGetIntegerv(device, param, size, values);
    [QGLNativeAPI("alcGetIntegerv")] internal static delegate* unmanaged[Cdecl]<nint, int, int, int*, void> _alcGetIntegerv = null;
    
    public static nint alcCaptureOpenDevice(byte* devicename, uint frequency, int format, int buffersize) => _alcCaptureOpenDevice(devicename, frequency, format, buffersize);
    [QGLNativeAPI("alcCaptureOpenDevice")] internal static delegate* unmanaged[Cdecl]<byte*, uint, int, int, nint> _alcCaptureOpenDevice = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alcCaptureCloseDevice(nint device) => _alcCaptureCloseDevice(device);
    [QGLNativeAPI("alcCaptureCloseDevice")] internal static delegate* unmanaged[Cdecl]<nint, bool> _alcCaptureCloseDevice = null;
    
    public static void alcCaptureStart(nint device) => _alcCaptureStart(device);
    [QGLNativeAPI("alcCaptureStart")] internal static delegate* unmanaged[Cdecl]<nint, void> _alcCaptureStart = null;
    
    public static void alcCaptureStop(nint device) => _alcCaptureStop(device);
    [QGLNativeAPI("alcCaptureStop")] internal static delegate* unmanaged[Cdecl]<nint, void> _alcCaptureStop = null;
    
    public static void alcCaptureSamples(nint device, void* buffer, int samples) => _alcCaptureSamples(device, buffer, samples);
    [QGLNativeAPI("alcCaptureSamples")] internal static delegate* unmanaged[Cdecl]<nint, void*, int, void> _alcCaptureSamples = null;
     #endregion
}
