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

// Bindings generated at 2025-02-22 14:36:34.316517
namespace QuickGLNS.Bindings;

public static unsafe class AL
{
    #region Constants
    public const int AL_INVALID = -0x1;
    public const uint AL_ILLEGAL_ENUM = AL_INVALID_ENUM;
    public const uint AL_ILLEGAL_COMMAND = AL_INVALID_OPERATION;
    public const int AL_NONE = 0x0;
    public const int AL_FALSE = 0x0;
    public const int AL_TRUE = 0x1;
    public const int AL_SOURCE_RELATIVE = 0x202;
    public const int AL_CONE_INNER_ANGLE = 0x1001;
    public const int AL_CONE_OUTER_ANGLE = 0x1002;
    public const int AL_PITCH = 0x1003;
    public const int AL_POSITION = 0x1004;
    public const int AL_DIRECTION = 0x1005;
    public const int AL_VELOCITY = 0x1006;
    public const int AL_LOOPING = 0x1007;
    public const int AL_BUFFER = 0x1009;
    public const int AL_GAIN = 0x100A;
    public const int AL_MIN_GAIN = 0x100D;
    public const int AL_MAX_GAIN = 0x100E;
    public const int AL_ORIENTATION = 0x100F;
    public const int AL_SOURCE_STATE = 0x1010;
    public const int AL_INITIAL = 0x1011;
    public const int AL_PLAYING = 0x1012;
    public const int AL_PAUSED = 0x1013;
    public const int AL_STOPPED = 0x1014;
    public const int AL_BUFFERS_QUEUED = 0x1015;
    public const int AL_BUFFERS_PROCESSED = 0x1016;
    public const int AL_REFERENCE_DISTANCE = 0x1020;
    public const int AL_ROLLOFF_FACTOR = 0x1021;
    public const int AL_CONE_OUTER_GAIN = 0x1022;
    public const int AL_MAX_DISTANCE = 0x1023;
    public const int AL_SEC_OFFSET = 0x1024;
    public const int AL_SAMPLE_OFFSET = 0x1025;
    public const int AL_BYTE_OFFSET = 0x1026;
    public const int AL_SOURCE_TYPE = 0x1027;
    public const int AL_STATIC = 0x1028;
    public const int AL_STREAMING = 0x1029;
    public const int AL_UNDETERMINED = 0x1030;
    public const int AL_FORMAT_MONO8 = 0x1100;
    public const int AL_FORMAT_MONO16 = 0x1101;
    public const int AL_FORMAT_STEREO8 = 0x1102;
    public const int AL_FORMAT_STEREO16 = 0x1103;
    public const int AL_FREQUENCY = 0x2001;
    public const int AL_BITS = 0x2002;
    public const int AL_CHANNELS = 0x2003;
    public const int AL_SIZE = 0x2004;
    public const int AL_UNUSED = 0x2010;
    public const int AL_PENDING = 0x2011;
    public const int AL_PROCESSED = 0x2012;
    public const int AL_NO_ERROR = 0x0;
    public const int AL_INVALID_NAME = 0xA001;
    public const int AL_INVALID_ENUM = 0xA002;
    public const int AL_INVALID_VALUE = 0xA003;
    public const int AL_INVALID_OPERATION = 0xA004;
    public const int AL_OUT_OF_MEMORY = 0xA005;
    public const int AL_VENDOR = 0xB001;
    public const int AL_VERSION = 0xB002;
    public const int AL_RENDERER = 0xB003;
    public const int AL_EXTENSIONS = 0xB004;
    public const int AL_DOPPLER_FACTOR = 0xC000;
    public const int AL_DOPPLER_VELOCITY = 0xC001;
    public const int AL_SPEED_OF_SOUND = 0xC003;
    public const int AL_DISTANCE_MODEL = 0xD000;
    public const int AL_INVERSE_DISTANCE = 0xD001;
    public const int AL_INVERSE_DISTANCE_CLAMPED = 0xD002;
    public const int AL_LINEAR_DISTANCE = 0xD003;
    public const int AL_LINEAR_DISTANCE_CLAMPED = 0xD004;
    public const int AL_EXPONENT_DISTANCE = 0xD005;
    public const int AL_EXPONENT_DISTANCE_CLAMPED = 0xD006;
    #endregion
    
    #region Functions
    public static void alEnable(int capability) => _alEnable(capability);
    [QGLNativeAPI("alEnable")] internal static delegate* unmanaged[Cdecl]<int, void> _alEnable = null;
    
    public static void alDisable(int capability) => _alDisable(capability);
    [QGLNativeAPI("alDisable")] internal static delegate* unmanaged[Cdecl]<int, void> _alDisable = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alIsEnabled(int capability) => _alIsEnabled(capability);
    [QGLNativeAPI("alIsEnabled")] internal static delegate* unmanaged[Cdecl]<int, bool> _alIsEnabled = null;
    
    public static void alDopplerFactor(float value) => _alDopplerFactor(value);
    [QGLNativeAPI("alDopplerFactor")] internal static delegate* unmanaged[Cdecl]<float, void> _alDopplerFactor = null;
    
    public static void alDopplerVelocity(float value) => _alDopplerVelocity(value);
    [QGLNativeAPI("alDopplerVelocity")] internal static delegate* unmanaged[Cdecl]<float, void> _alDopplerVelocity = null;
    
    public static void alSpeedOfSound(float value) => _alSpeedOfSound(value);
    [QGLNativeAPI("alSpeedOfSound")] internal static delegate* unmanaged[Cdecl]<float, void> _alSpeedOfSound = null;
    
    public static void alDistanceModel(int distanceModel) => _alDistanceModel(distanceModel);
    [QGLNativeAPI("alDistanceModel")] internal static delegate* unmanaged[Cdecl]<int, void> _alDistanceModel = null;
    
    public static byte* alGetString(int param) => _alGetString(param);
    [QGLNativeAPI("alGetString")] internal static delegate* unmanaged[Cdecl]<int, byte*> _alGetString = null;
    
    public static void alGetBooleanv(int param, [MarshalAs(UnmanagedType.I1)] bool* values) => _alGetBooleanv(param, values);
    [QGLNativeAPI("alGetBooleanv")] internal static delegate* unmanaged[Cdecl]<int, bool*, void> _alGetBooleanv = null;
    
    public static void alGetIntegerv(int param, int* values) => _alGetIntegerv(param, values);
    [QGLNativeAPI("alGetIntegerv")] internal static delegate* unmanaged[Cdecl]<int, int*, void> _alGetIntegerv = null;
    
    public static void alGetFloatv(int param, float* values) => _alGetFloatv(param, values);
    [QGLNativeAPI("alGetFloatv")] internal static delegate* unmanaged[Cdecl]<int, float*, void> _alGetFloatv = null;
    
    public static void alGetDoublev(int param, double* values) => _alGetDoublev(param, values);
    [QGLNativeAPI("alGetDoublev")] internal static delegate* unmanaged[Cdecl]<int, double*, void> _alGetDoublev = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alGetBoolean(int param) => _alGetBoolean(param);
    [QGLNativeAPI("alGetBoolean")] internal static delegate* unmanaged[Cdecl]<int, bool> _alGetBoolean = null;
    
    public static int alGetInteger(int param) => _alGetInteger(param);
    [QGLNativeAPI("alGetInteger")] internal static delegate* unmanaged[Cdecl]<int, int> _alGetInteger = null;
    
    public static float alGetFloat(int param) => _alGetFloat(param);
    [QGLNativeAPI("alGetFloat")] internal static delegate* unmanaged[Cdecl]<int, float> _alGetFloat = null;
    
    public static double alGetDouble(int param) => _alGetDouble(param);
    [QGLNativeAPI("alGetDouble")] internal static delegate* unmanaged[Cdecl]<int, double> _alGetDouble = null;
    
    public static int alGetError() => _alGetError();
    [QGLNativeAPI("alGetError")] internal static delegate* unmanaged[Cdecl]<int> _alGetError = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alIsExtensionPresent(byte* extname) => _alIsExtensionPresent(extname);
    [QGLNativeAPI("alIsExtensionPresent")] internal static delegate* unmanaged[Cdecl]<byte*, bool> _alIsExtensionPresent = null;
    
    public static void* alGetProcAddress(byte* fname) => _alGetProcAddress(fname);
    [QGLNativeAPI("alGetProcAddress")] internal static delegate* unmanaged[Cdecl]<byte*, void*> _alGetProcAddress = null;
    
    public static int alGetEnumValue(byte* ename) => _alGetEnumValue(ename);
    [QGLNativeAPI("alGetEnumValue")] internal static delegate* unmanaged[Cdecl]<byte*, int> _alGetEnumValue = null;
    
    public static void alListenerf(int param, float value) => _alListenerf(param, value);
    [QGLNativeAPI("alListenerf")] internal static delegate* unmanaged[Cdecl]<int, float, void> _alListenerf = null;
    
    public static void alListener3f(int param, float value1, float value2, float value3) => _alListener3f(param, value1, value2, value3);
    [QGLNativeAPI("alListener3f")] internal static delegate* unmanaged[Cdecl]<int, float, float, float, void> _alListener3f = null;
    
    public static void alListenerfv(int param, float* values) => _alListenerfv(param, values);
    [QGLNativeAPI("alListenerfv")] internal static delegate* unmanaged[Cdecl]<int, float*, void> _alListenerfv = null;
    
    public static void alListeneri(int param, int value) => _alListeneri(param, value);
    [QGLNativeAPI("alListeneri")] internal static delegate* unmanaged[Cdecl]<int, int, void> _alListeneri = null;
    
    public static void alListener3i(int param, int value1, int value2, int value3) => _alListener3i(param, value1, value2, value3);
    [QGLNativeAPI("alListener3i")] internal static delegate* unmanaged[Cdecl]<int, int, int, int, void> _alListener3i = null;
    
    public static void alListeneriv(int param, int* values) => _alListeneriv(param, values);
    [QGLNativeAPI("alListeneriv")] internal static delegate* unmanaged[Cdecl]<int, int*, void> _alListeneriv = null;
    
    public static void alGetListenerf(int param, float* value) => _alGetListenerf(param, value);
    [QGLNativeAPI("alGetListenerf")] internal static delegate* unmanaged[Cdecl]<int, float*, void> _alGetListenerf = null;
    
    public static void alGetListener3f(int param, float* value1, float* value2, float* value3) => _alGetListener3f(param, value1, value2, value3);
    [QGLNativeAPI("alGetListener3f")] internal static delegate* unmanaged[Cdecl]<int, float*, float*, float*, void> _alGetListener3f = null;
    
    public static void alGetListenerfv(int param, float* values) => _alGetListenerfv(param, values);
    [QGLNativeAPI("alGetListenerfv")] internal static delegate* unmanaged[Cdecl]<int, float*, void> _alGetListenerfv = null;
    
    public static void alGetListeneri(int param, int* value) => _alGetListeneri(param, value);
    [QGLNativeAPI("alGetListeneri")] internal static delegate* unmanaged[Cdecl]<int, int*, void> _alGetListeneri = null;
    
    public static void alGetListener3i(int param, int* value1, int* value2, int* value3) => _alGetListener3i(param, value1, value2, value3);
    [QGLNativeAPI("alGetListener3i")] internal static delegate* unmanaged[Cdecl]<int, int*, int*, int*, void> _alGetListener3i = null;
    
    public static void alGetListeneriv(int param, int* values) => _alGetListeneriv(param, values);
    [QGLNativeAPI("alGetListeneriv")] internal static delegate* unmanaged[Cdecl]<int, int*, void> _alGetListeneriv = null;
    
    public static void alGenSources(int n, uint* sources) => _alGenSources(n, sources);
    [QGLNativeAPI("alGenSources")] internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alGenSources = null;
    
    public static void alDeleteSources(int n, uint* sources) => _alDeleteSources(n, sources);
    [QGLNativeAPI("alDeleteSources")] internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alDeleteSources = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alIsSource(uint source) => _alIsSource(source);
    [QGLNativeAPI("alIsSource")] internal static delegate* unmanaged[Cdecl]<uint, bool> _alIsSource = null;
    
    public static void alSourcef(uint source, int param, float value) => _alSourcef(source, param, value);
    [QGLNativeAPI("alSourcef")] internal static delegate* unmanaged[Cdecl]<uint, int, float, void> _alSourcef = null;
    
    public static void alSource3f(uint source, int param, float value1, float value2, float value3) => _alSource3f(source, param, value1, value2, value3);
    [QGLNativeAPI("alSource3f")] internal static delegate* unmanaged[Cdecl]<uint, int, float, float, float, void> _alSource3f = null;
    
    public static void alSourcefv(uint source, int param, float* values) => _alSourcefv(source, param, values);
    [QGLNativeAPI("alSourcefv")] internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alSourcefv = null;
    
    public static void alSourcei(uint source, int param, int value) => _alSourcei(source, param, value);
    [QGLNativeAPI("alSourcei")] internal static delegate* unmanaged[Cdecl]<uint, int, int, void> _alSourcei = null;
    
    public static void alSource3i(uint source, int param, int value1, int value2, int value3) => _alSource3i(source, param, value1, value2, value3);
    [QGLNativeAPI("alSource3i")] internal static delegate* unmanaged[Cdecl]<uint, int, int, int, int, void> _alSource3i = null;
    
    public static void alSourceiv(uint source, int param, int* values) => _alSourceiv(source, param, values);
    [QGLNativeAPI("alSourceiv")] internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alSourceiv = null;
    
    public static void alGetSourcef(uint source, int param, float* value) => _alGetSourcef(source, param, value);
    [QGLNativeAPI("alGetSourcef")] internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alGetSourcef = null;
    
    public static void alGetSource3f(uint source, int param, float* value1, float* value2, float* value3) => _alGetSource3f(source, param, value1, value2, value3);
    [QGLNativeAPI("alGetSource3f")] internal static delegate* unmanaged[Cdecl]<uint, int, float*, float*, float*, void> _alGetSource3f = null;
    
    public static void alGetSourcefv(uint source, int param, float* values) => _alGetSourcefv(source, param, values);
    [QGLNativeAPI("alGetSourcefv")] internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alGetSourcefv = null;
    
    public static void alGetSourcei(uint source, int param, int* value) => _alGetSourcei(source, param, value);
    [QGLNativeAPI("alGetSourcei")] internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alGetSourcei = null;
    
    public static void alGetSource3i(uint source, int param, int* value1, int* value2, int* value3) => _alGetSource3i(source, param, value1, value2, value3);
    [QGLNativeAPI("alGetSource3i")] internal static delegate* unmanaged[Cdecl]<uint, int, int*, int*, int*, void> _alGetSource3i = null;
    
    public static void alGetSourceiv(uint source, int param, int* values) => _alGetSourceiv(source, param, values);
    [QGLNativeAPI("alGetSourceiv")] internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alGetSourceiv = null;
    
    public static void alSourcePlay(uint source) => _alSourcePlay(source);
    [QGLNativeAPI("alSourcePlay")] internal static delegate* unmanaged[Cdecl]<uint, void> _alSourcePlay = null;
    
    public static void alSourceStop(uint source) => _alSourceStop(source);
    [QGLNativeAPI("alSourceStop")] internal static delegate* unmanaged[Cdecl]<uint, void> _alSourceStop = null;
    
    public static void alSourceRewind(uint source) => _alSourceRewind(source);
    [QGLNativeAPI("alSourceRewind")] internal static delegate* unmanaged[Cdecl]<uint, void> _alSourceRewind = null;
    
    public static void alSourcePause(uint source) => _alSourcePause(source);
    [QGLNativeAPI("alSourcePause")] internal static delegate* unmanaged[Cdecl]<uint, void> _alSourcePause = null;
    
    public static void alSourcePlayv(int n, uint* sources) => _alSourcePlayv(n, sources);
    [QGLNativeAPI("alSourcePlayv")] internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alSourcePlayv = null;
    
    public static void alSourceStopv(int n, uint* sources) => _alSourceStopv(n, sources);
    [QGLNativeAPI("alSourceStopv")] internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alSourceStopv = null;
    
    public static void alSourceRewindv(int n, uint* sources) => _alSourceRewindv(n, sources);
    [QGLNativeAPI("alSourceRewindv")] internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alSourceRewindv = null;
    
    public static void alSourcePausev(int n, uint* sources) => _alSourcePausev(n, sources);
    [QGLNativeAPI("alSourcePausev")] internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alSourcePausev = null;
    
    public static void alSourceQueueBuffers(uint source, int nb, uint* buffers) => _alSourceQueueBuffers(source, nb, buffers);
    [QGLNativeAPI("alSourceQueueBuffers")] internal static delegate* unmanaged[Cdecl]<uint, int, uint*, void> _alSourceQueueBuffers = null;
    
    public static void alSourceUnqueueBuffers(uint source, int nb, uint* buffers) => _alSourceUnqueueBuffers(source, nb, buffers);
    [QGLNativeAPI("alSourceUnqueueBuffers")] internal static delegate* unmanaged[Cdecl]<uint, int, uint*, void> _alSourceUnqueueBuffers = null;
    
    public static void alGenBuffers(int n, uint* buffers) => _alGenBuffers(n, buffers);
    [QGLNativeAPI("alGenBuffers")] internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alGenBuffers = null;
    
    public static void alDeleteBuffers(int n, uint* buffers) => _alDeleteBuffers(n, buffers);
    [QGLNativeAPI("alDeleteBuffers")] internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alDeleteBuffers = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alIsBuffer(uint buffer) => _alIsBuffer(buffer);
    [QGLNativeAPI("alIsBuffer")] internal static delegate* unmanaged[Cdecl]<uint, bool> _alIsBuffer = null;
    
    public static void alBufferData(uint buffer, int format, void* data, int size, int samplerate) => _alBufferData(buffer, format, data, size, samplerate);
    [QGLNativeAPI("alBufferData")] internal static delegate* unmanaged[Cdecl]<uint, int, void*, int, int, void> _alBufferData = null;
    
    public static void alBufferf(uint buffer, int param, float value) => _alBufferf(buffer, param, value);
    [QGLNativeAPI("alBufferf")] internal static delegate* unmanaged[Cdecl]<uint, int, float, void> _alBufferf = null;
    
    public static void alBuffer3f(uint buffer, int param, float value1, float value2, float value3) => _alBuffer3f(buffer, param, value1, value2, value3);
    [QGLNativeAPI("alBuffer3f")] internal static delegate* unmanaged[Cdecl]<uint, int, float, float, float, void> _alBuffer3f = null;
    
    public static void alBufferfv(uint buffer, int param, float* values) => _alBufferfv(buffer, param, values);
    [QGLNativeAPI("alBufferfv")] internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alBufferfv = null;
    
    public static void alBufferi(uint buffer, int param, int value) => _alBufferi(buffer, param, value);
    [QGLNativeAPI("alBufferi")] internal static delegate* unmanaged[Cdecl]<uint, int, int, void> _alBufferi = null;
    
    public static void alBuffer3i(uint buffer, int param, int value1, int value2, int value3) => _alBuffer3i(buffer, param, value1, value2, value3);
    [QGLNativeAPI("alBuffer3i")] internal static delegate* unmanaged[Cdecl]<uint, int, int, int, int, void> _alBuffer3i = null;
    
    public static void alBufferiv(uint buffer, int param, int* values) => _alBufferiv(buffer, param, values);
    [QGLNativeAPI("alBufferiv")] internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alBufferiv = null;
    
    public static void alGetBufferf(uint buffer, int param, float* value) => _alGetBufferf(buffer, param, value);
    [QGLNativeAPI("alGetBufferf")] internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alGetBufferf = null;
    
    public static void alGetBuffer3f(uint buffer, int param, float* value1, float* value2, float* value3) => _alGetBuffer3f(buffer, param, value1, value2, value3);
    [QGLNativeAPI("alGetBuffer3f")] internal static delegate* unmanaged[Cdecl]<uint, int, float*, float*, float*, void> _alGetBuffer3f = null;
    
    public static void alGetBufferfv(uint buffer, int param, float* values) => _alGetBufferfv(buffer, param, values);
    [QGLNativeAPI("alGetBufferfv")] internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alGetBufferfv = null;
    
    public static void alGetBufferi(uint buffer, int param, int* value) => _alGetBufferi(buffer, param, value);
    [QGLNativeAPI("alGetBufferi")] internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alGetBufferi = null;
    
    public static void alGetBuffer3i(uint buffer, int param, int* value1, int* value2, int* value3) => _alGetBuffer3i(buffer, param, value1, value2, value3);
    [QGLNativeAPI("alGetBuffer3i")] internal static delegate* unmanaged[Cdecl]<uint, int, int*, int*, int*, void> _alGetBuffer3i = null;
    
    public static void alGetBufferiv(uint buffer, int param, int* values) => _alGetBufferiv(buffer, param, values);
    [QGLNativeAPI("alGetBufferiv")] internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alGetBufferiv = null;
     #endregion
}
