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

// Bindings generated at 2025-09-20 18:58:20.953639
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
    public static void alEnable(int capability) { QGLFeature.VerifyFunc((nint)_alEnable); _alEnable(capability); }
    internal static delegate* unmanaged[Cdecl]<int, void> _alEnable = null;
    
    public static void alDisable(int capability) { QGLFeature.VerifyFunc((nint)_alDisable); _alDisable(capability); }
    internal static delegate* unmanaged[Cdecl]<int, void> _alDisable = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alIsEnabled(int capability) { QGLFeature.VerifyFunc((nint)_alIsEnabled); return _alIsEnabled(capability); }
    internal static delegate* unmanaged[Cdecl]<int, bool> _alIsEnabled = null;
    
    public static void alDopplerFactor(float value) { QGLFeature.VerifyFunc((nint)_alDopplerFactor); _alDopplerFactor(value); }
    internal static delegate* unmanaged[Cdecl]<float, void> _alDopplerFactor = null;
    
    public static void alDopplerVelocity(float value) { QGLFeature.VerifyFunc((nint)_alDopplerVelocity); _alDopplerVelocity(value); }
    internal static delegate* unmanaged[Cdecl]<float, void> _alDopplerVelocity = null;
    
    public static void alSpeedOfSound(float value) { QGLFeature.VerifyFunc((nint)_alSpeedOfSound); _alSpeedOfSound(value); }
    internal static delegate* unmanaged[Cdecl]<float, void> _alSpeedOfSound = null;
    
    public static void alDistanceModel(int distanceModel) { QGLFeature.VerifyFunc((nint)_alDistanceModel); _alDistanceModel(distanceModel); }
    internal static delegate* unmanaged[Cdecl]<int, void> _alDistanceModel = null;
    
    public static byte* alGetString(int param) { QGLFeature.VerifyFunc((nint)_alGetString); return _alGetString(param); }
    internal static delegate* unmanaged[Cdecl]<int, byte*> _alGetString = null;
    
    public static void alGetBooleanv(int param, [MarshalAs(UnmanagedType.I1)] bool* values) { QGLFeature.VerifyFunc((nint)_alGetBooleanv); _alGetBooleanv(param, values); }
    internal static delegate* unmanaged[Cdecl]<int, bool*, void> _alGetBooleanv = null;
    
    public static void alGetIntegerv(int param, int* values) { QGLFeature.VerifyFunc((nint)_alGetIntegerv); _alGetIntegerv(param, values); }
    internal static delegate* unmanaged[Cdecl]<int, int*, void> _alGetIntegerv = null;
    
    public static void alGetFloatv(int param, float* values) { QGLFeature.VerifyFunc((nint)_alGetFloatv); _alGetFloatv(param, values); }
    internal static delegate* unmanaged[Cdecl]<int, float*, void> _alGetFloatv = null;
    
    public static void alGetDoublev(int param, double* values) { QGLFeature.VerifyFunc((nint)_alGetDoublev); _alGetDoublev(param, values); }
    internal static delegate* unmanaged[Cdecl]<int, double*, void> _alGetDoublev = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alGetBoolean(int param) { QGLFeature.VerifyFunc((nint)_alGetBoolean); return _alGetBoolean(param); }
    internal static delegate* unmanaged[Cdecl]<int, bool> _alGetBoolean = null;
    
    public static int alGetInteger(int param) { QGLFeature.VerifyFunc((nint)_alGetInteger); return _alGetInteger(param); }
    internal static delegate* unmanaged[Cdecl]<int, int> _alGetInteger = null;
    
    public static float alGetFloat(int param) { QGLFeature.VerifyFunc((nint)_alGetFloat); return _alGetFloat(param); }
    internal static delegate* unmanaged[Cdecl]<int, float> _alGetFloat = null;
    
    public static double alGetDouble(int param) { QGLFeature.VerifyFunc((nint)_alGetDouble); return _alGetDouble(param); }
    internal static delegate* unmanaged[Cdecl]<int, double> _alGetDouble = null;
    
    public static int alGetError() { QGLFeature.VerifyFunc((nint)_alGetError); return _alGetError(); }
    internal static delegate* unmanaged[Cdecl]<int> _alGetError = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alIsExtensionPresent(byte* extname) { QGLFeature.VerifyFunc((nint)_alIsExtensionPresent); return _alIsExtensionPresent(extname); }
    internal static delegate* unmanaged[Cdecl]<byte*, bool> _alIsExtensionPresent = null;
    
    public static void* alGetProcAddress(byte* fname) { QGLFeature.VerifyFunc((nint)_alGetProcAddress); return _alGetProcAddress(fname); }
    internal static delegate* unmanaged[Cdecl]<byte*, void*> _alGetProcAddress = null;
    
    public static int alGetEnumValue(byte* ename) { QGLFeature.VerifyFunc((nint)_alGetEnumValue); return _alGetEnumValue(ename); }
    internal static delegate* unmanaged[Cdecl]<byte*, int> _alGetEnumValue = null;
    
    public static void alListenerf(int param, float value) { QGLFeature.VerifyFunc((nint)_alListenerf); _alListenerf(param, value); }
    internal static delegate* unmanaged[Cdecl]<int, float, void> _alListenerf = null;
    
    public static void alListener3f(int param, float value1, float value2, float value3) { QGLFeature.VerifyFunc((nint)_alListener3f); _alListener3f(param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<int, float, float, float, void> _alListener3f = null;
    
    public static void alListenerfv(int param, float* values) { QGLFeature.VerifyFunc((nint)_alListenerfv); _alListenerfv(param, values); }
    internal static delegate* unmanaged[Cdecl]<int, float*, void> _alListenerfv = null;
    
    public static void alListeneri(int param, int value) { QGLFeature.VerifyFunc((nint)_alListeneri); _alListeneri(param, value); }
    internal static delegate* unmanaged[Cdecl]<int, int, void> _alListeneri = null;
    
    public static void alListener3i(int param, int value1, int value2, int value3) { QGLFeature.VerifyFunc((nint)_alListener3i); _alListener3i(param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<int, int, int, int, void> _alListener3i = null;
    
    public static void alListeneriv(int param, int* values) { QGLFeature.VerifyFunc((nint)_alListeneriv); _alListeneriv(param, values); }
    internal static delegate* unmanaged[Cdecl]<int, int*, void> _alListeneriv = null;
    
    public static void alGetListenerf(int param, float* value) { QGLFeature.VerifyFunc((nint)_alGetListenerf); _alGetListenerf(param, value); }
    internal static delegate* unmanaged[Cdecl]<int, float*, void> _alGetListenerf = null;
    
    public static void alGetListener3f(int param, float* value1, float* value2, float* value3) { QGLFeature.VerifyFunc((nint)_alGetListener3f); _alGetListener3f(param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<int, float*, float*, float*, void> _alGetListener3f = null;
    
    public static void alGetListenerfv(int param, float* values) { QGLFeature.VerifyFunc((nint)_alGetListenerfv); _alGetListenerfv(param, values); }
    internal static delegate* unmanaged[Cdecl]<int, float*, void> _alGetListenerfv = null;
    
    public static void alGetListeneri(int param, int* value) { QGLFeature.VerifyFunc((nint)_alGetListeneri); _alGetListeneri(param, value); }
    internal static delegate* unmanaged[Cdecl]<int, int*, void> _alGetListeneri = null;
    
    public static void alGetListener3i(int param, int* value1, int* value2, int* value3) { QGLFeature.VerifyFunc((nint)_alGetListener3i); _alGetListener3i(param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<int, int*, int*, int*, void> _alGetListener3i = null;
    
    public static void alGetListeneriv(int param, int* values) { QGLFeature.VerifyFunc((nint)_alGetListeneriv); _alGetListeneriv(param, values); }
    internal static delegate* unmanaged[Cdecl]<int, int*, void> _alGetListeneriv = null;
    
    public static void alGenSources(int n, uint* sources) { QGLFeature.VerifyFunc((nint)_alGenSources); _alGenSources(n, sources); }
    internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alGenSources = null;
    
    public static void alDeleteSources(int n, uint* sources) { QGLFeature.VerifyFunc((nint)_alDeleteSources); _alDeleteSources(n, sources); }
    internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alDeleteSources = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alIsSource(uint source) { QGLFeature.VerifyFunc((nint)_alIsSource); return _alIsSource(source); }
    internal static delegate* unmanaged[Cdecl]<uint, bool> _alIsSource = null;
    
    public static void alSourcef(uint source, int param, float value) { QGLFeature.VerifyFunc((nint)_alSourcef); _alSourcef(source, param, value); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float, void> _alSourcef = null;
    
    public static void alSource3f(uint source, int param, float value1, float value2, float value3) { QGLFeature.VerifyFunc((nint)_alSource3f); _alSource3f(source, param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float, float, float, void> _alSource3f = null;
    
    public static void alSourcefv(uint source, int param, float* values) { QGLFeature.VerifyFunc((nint)_alSourcefv); _alSourcefv(source, param, values); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alSourcefv = null;
    
    public static void alSourcei(uint source, int param, int value) { QGLFeature.VerifyFunc((nint)_alSourcei); _alSourcei(source, param, value); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int, void> _alSourcei = null;
    
    public static void alSource3i(uint source, int param, int value1, int value2, int value3) { QGLFeature.VerifyFunc((nint)_alSource3i); _alSource3i(source, param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int, int, int, void> _alSource3i = null;
    
    public static void alSourceiv(uint source, int param, int* values) { QGLFeature.VerifyFunc((nint)_alSourceiv); _alSourceiv(source, param, values); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alSourceiv = null;
    
    public static void alGetSourcef(uint source, int param, float* value) { QGLFeature.VerifyFunc((nint)_alGetSourcef); _alGetSourcef(source, param, value); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alGetSourcef = null;
    
    public static void alGetSource3f(uint source, int param, float* value1, float* value2, float* value3) { QGLFeature.VerifyFunc((nint)_alGetSource3f); _alGetSource3f(source, param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float*, float*, float*, void> _alGetSource3f = null;
    
    public static void alGetSourcefv(uint source, int param, float* values) { QGLFeature.VerifyFunc((nint)_alGetSourcefv); _alGetSourcefv(source, param, values); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alGetSourcefv = null;
    
    public static void alGetSourcei(uint source, int param, int* value) { QGLFeature.VerifyFunc((nint)_alGetSourcei); _alGetSourcei(source, param, value); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alGetSourcei = null;
    
    public static void alGetSource3i(uint source, int param, int* value1, int* value2, int* value3) { QGLFeature.VerifyFunc((nint)_alGetSource3i); _alGetSource3i(source, param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int*, int*, int*, void> _alGetSource3i = null;
    
    public static void alGetSourceiv(uint source, int param, int* values) { QGLFeature.VerifyFunc((nint)_alGetSourceiv); _alGetSourceiv(source, param, values); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alGetSourceiv = null;
    
    public static void alSourcePlay(uint source) { QGLFeature.VerifyFunc((nint)_alSourcePlay); _alSourcePlay(source); }
    internal static delegate* unmanaged[Cdecl]<uint, void> _alSourcePlay = null;
    
    public static void alSourceStop(uint source) { QGLFeature.VerifyFunc((nint)_alSourceStop); _alSourceStop(source); }
    internal static delegate* unmanaged[Cdecl]<uint, void> _alSourceStop = null;
    
    public static void alSourceRewind(uint source) { QGLFeature.VerifyFunc((nint)_alSourceRewind); _alSourceRewind(source); }
    internal static delegate* unmanaged[Cdecl]<uint, void> _alSourceRewind = null;
    
    public static void alSourcePause(uint source) { QGLFeature.VerifyFunc((nint)_alSourcePause); _alSourcePause(source); }
    internal static delegate* unmanaged[Cdecl]<uint, void> _alSourcePause = null;
    
    public static void alSourcePlayv(int n, uint* sources) { QGLFeature.VerifyFunc((nint)_alSourcePlayv); _alSourcePlayv(n, sources); }
    internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alSourcePlayv = null;
    
    public static void alSourceStopv(int n, uint* sources) { QGLFeature.VerifyFunc((nint)_alSourceStopv); _alSourceStopv(n, sources); }
    internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alSourceStopv = null;
    
    public static void alSourceRewindv(int n, uint* sources) { QGLFeature.VerifyFunc((nint)_alSourceRewindv); _alSourceRewindv(n, sources); }
    internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alSourceRewindv = null;
    
    public static void alSourcePausev(int n, uint* sources) { QGLFeature.VerifyFunc((nint)_alSourcePausev); _alSourcePausev(n, sources); }
    internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alSourcePausev = null;
    
    public static void alSourceQueueBuffers(uint source, int nb, uint* buffers) { QGLFeature.VerifyFunc((nint)_alSourceQueueBuffers); _alSourceQueueBuffers(source, nb, buffers); }
    internal static delegate* unmanaged[Cdecl]<uint, int, uint*, void> _alSourceQueueBuffers = null;
    
    public static void alSourceUnqueueBuffers(uint source, int nb, uint* buffers) { QGLFeature.VerifyFunc((nint)_alSourceUnqueueBuffers); _alSourceUnqueueBuffers(source, nb, buffers); }
    internal static delegate* unmanaged[Cdecl]<uint, int, uint*, void> _alSourceUnqueueBuffers = null;
    
    public static void alGenBuffers(int n, uint* buffers) { QGLFeature.VerifyFunc((nint)_alGenBuffers); _alGenBuffers(n, buffers); }
    internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alGenBuffers = null;
    
    public static void alDeleteBuffers(int n, uint* buffers) { QGLFeature.VerifyFunc((nint)_alDeleteBuffers); _alDeleteBuffers(n, buffers); }
    internal static delegate* unmanaged[Cdecl]<int, uint*, void> _alDeleteBuffers = null;
    
    [return: MarshalAs(UnmanagedType.I1)] public static bool alIsBuffer(uint buffer) { QGLFeature.VerifyFunc((nint)_alIsBuffer); return _alIsBuffer(buffer); }
    internal static delegate* unmanaged[Cdecl]<uint, bool> _alIsBuffer = null;
    
    public static void alBufferData(uint buffer, int format, void* data, int size, int samplerate) { QGLFeature.VerifyFunc((nint)_alBufferData); _alBufferData(buffer, format, data, size, samplerate); }
    internal static delegate* unmanaged[Cdecl]<uint, int, void*, int, int, void> _alBufferData = null;
    
    public static void alBufferf(uint buffer, int param, float value) { QGLFeature.VerifyFunc((nint)_alBufferf); _alBufferf(buffer, param, value); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float, void> _alBufferf = null;
    
    public static void alBuffer3f(uint buffer, int param, float value1, float value2, float value3) { QGLFeature.VerifyFunc((nint)_alBuffer3f); _alBuffer3f(buffer, param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float, float, float, void> _alBuffer3f = null;
    
    public static void alBufferfv(uint buffer, int param, float* values) { QGLFeature.VerifyFunc((nint)_alBufferfv); _alBufferfv(buffer, param, values); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alBufferfv = null;
    
    public static void alBufferi(uint buffer, int param, int value) { QGLFeature.VerifyFunc((nint)_alBufferi); _alBufferi(buffer, param, value); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int, void> _alBufferi = null;
    
    public static void alBuffer3i(uint buffer, int param, int value1, int value2, int value3) { QGLFeature.VerifyFunc((nint)_alBuffer3i); _alBuffer3i(buffer, param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int, int, int, void> _alBuffer3i = null;
    
    public static void alBufferiv(uint buffer, int param, int* values) { QGLFeature.VerifyFunc((nint)_alBufferiv); _alBufferiv(buffer, param, values); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alBufferiv = null;
    
    public static void alGetBufferf(uint buffer, int param, float* value) { QGLFeature.VerifyFunc((nint)_alGetBufferf); _alGetBufferf(buffer, param, value); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alGetBufferf = null;
    
    public static void alGetBuffer3f(uint buffer, int param, float* value1, float* value2, float* value3) { QGLFeature.VerifyFunc((nint)_alGetBuffer3f); _alGetBuffer3f(buffer, param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float*, float*, float*, void> _alGetBuffer3f = null;
    
    public static void alGetBufferfv(uint buffer, int param, float* values) { QGLFeature.VerifyFunc((nint)_alGetBufferfv); _alGetBufferfv(buffer, param, values); }
    internal static delegate* unmanaged[Cdecl]<uint, int, float*, void> _alGetBufferfv = null;
    
    public static void alGetBufferi(uint buffer, int param, int* value) { QGLFeature.VerifyFunc((nint)_alGetBufferi); _alGetBufferi(buffer, param, value); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alGetBufferi = null;
    
    public static void alGetBuffer3i(uint buffer, int param, int* value1, int* value2, int* value3) { QGLFeature.VerifyFunc((nint)_alGetBuffer3i); _alGetBuffer3i(buffer, param, value1, value2, value3); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int*, int*, int*, void> _alGetBuffer3i = null;
    
    public static void alGetBufferiv(uint buffer, int param, int* values) { QGLFeature.VerifyFunc((nint)_alGetBufferiv); _alGetBufferiv(buffer, param, values); }
    internal static delegate* unmanaged[Cdecl]<uint, int, int*, void> _alGetBufferiv = null;
     #endregion
    
    internal static void Load()
    {
        _alEnable = (delegate* unmanaged[Cdecl]<int, void>)QuickGL.GetALProcAddress("alEnable");
        _alDisable = (delegate* unmanaged[Cdecl]<int, void>)QuickGL.GetALProcAddress("alDisable");
        _alIsEnabled = (delegate* unmanaged[Cdecl]<int, bool>)QuickGL.GetALProcAddress("alIsEnabled");
        _alDopplerFactor = (delegate* unmanaged[Cdecl]<float, void>)QuickGL.GetALProcAddress("alDopplerFactor");
        _alDopplerVelocity = (delegate* unmanaged[Cdecl]<float, void>)QuickGL.GetALProcAddress("alDopplerVelocity");
        _alSpeedOfSound = (delegate* unmanaged[Cdecl]<float, void>)QuickGL.GetALProcAddress("alSpeedOfSound");
        _alDistanceModel = (delegate* unmanaged[Cdecl]<int, void>)QuickGL.GetALProcAddress("alDistanceModel");
        _alGetString = (delegate* unmanaged[Cdecl]<int, byte*>)QuickGL.GetALProcAddress("alGetString");
        _alGetBooleanv = (delegate* unmanaged[Cdecl]<int, bool*, void>)QuickGL.GetALProcAddress("alGetBooleanv");
        _alGetIntegerv = (delegate* unmanaged[Cdecl]<int, int*, void>)QuickGL.GetALProcAddress("alGetIntegerv");
        _alGetFloatv = (delegate* unmanaged[Cdecl]<int, float*, void>)QuickGL.GetALProcAddress("alGetFloatv");
        _alGetDoublev = (delegate* unmanaged[Cdecl]<int, double*, void>)QuickGL.GetALProcAddress("alGetDoublev");
        _alGetBoolean = (delegate* unmanaged[Cdecl]<int, bool>)QuickGL.GetALProcAddress("alGetBoolean");
        _alGetInteger = (delegate* unmanaged[Cdecl]<int, int>)QuickGL.GetALProcAddress("alGetInteger");
        _alGetFloat = (delegate* unmanaged[Cdecl]<int, float>)QuickGL.GetALProcAddress("alGetFloat");
        _alGetDouble = (delegate* unmanaged[Cdecl]<int, double>)QuickGL.GetALProcAddress("alGetDouble");
        _alGetError = (delegate* unmanaged[Cdecl]<int>)QuickGL.GetALProcAddress("alGetError");
        _alIsExtensionPresent = (delegate* unmanaged[Cdecl]<byte*, bool>)QuickGL.GetALProcAddress("alIsExtensionPresent");
        _alGetProcAddress = (delegate* unmanaged[Cdecl]<byte*, void*>)QuickGL.GetALProcAddress("alGetProcAddress");
        _alGetEnumValue = (delegate* unmanaged[Cdecl]<byte*, int>)QuickGL.GetALProcAddress("alGetEnumValue");
        _alListenerf = (delegate* unmanaged[Cdecl]<int, float, void>)QuickGL.GetALProcAddress("alListenerf");
        _alListener3f = (delegate* unmanaged[Cdecl]<int, float, float, float, void>)QuickGL.GetALProcAddress("alListener3f");
        _alListenerfv = (delegate* unmanaged[Cdecl]<int, float*, void>)QuickGL.GetALProcAddress("alListenerfv");
        _alListeneri = (delegate* unmanaged[Cdecl]<int, int, void>)QuickGL.GetALProcAddress("alListeneri");
        _alListener3i = (delegate* unmanaged[Cdecl]<int, int, int, int, void>)QuickGL.GetALProcAddress("alListener3i");
        _alListeneriv = (delegate* unmanaged[Cdecl]<int, int*, void>)QuickGL.GetALProcAddress("alListeneriv");
        _alGetListenerf = (delegate* unmanaged[Cdecl]<int, float*, void>)QuickGL.GetALProcAddress("alGetListenerf");
        _alGetListener3f = (delegate* unmanaged[Cdecl]<int, float*, float*, float*, void>)QuickGL.GetALProcAddress("alGetListener3f");
        _alGetListenerfv = (delegate* unmanaged[Cdecl]<int, float*, void>)QuickGL.GetALProcAddress("alGetListenerfv");
        _alGetListeneri = (delegate* unmanaged[Cdecl]<int, int*, void>)QuickGL.GetALProcAddress("alGetListeneri");
        _alGetListener3i = (delegate* unmanaged[Cdecl]<int, int*, int*, int*, void>)QuickGL.GetALProcAddress("alGetListener3i");
        _alGetListeneriv = (delegate* unmanaged[Cdecl]<int, int*, void>)QuickGL.GetALProcAddress("alGetListeneriv");
        _alGenSources = (delegate* unmanaged[Cdecl]<int, uint*, void>)QuickGL.GetALProcAddress("alGenSources");
        _alDeleteSources = (delegate* unmanaged[Cdecl]<int, uint*, void>)QuickGL.GetALProcAddress("alDeleteSources");
        _alIsSource = (delegate* unmanaged[Cdecl]<uint, bool>)QuickGL.GetALProcAddress("alIsSource");
        _alSourcef = (delegate* unmanaged[Cdecl]<uint, int, float, void>)QuickGL.GetALProcAddress("alSourcef");
        _alSource3f = (delegate* unmanaged[Cdecl]<uint, int, float, float, float, void>)QuickGL.GetALProcAddress("alSource3f");
        _alSourcefv = (delegate* unmanaged[Cdecl]<uint, int, float*, void>)QuickGL.GetALProcAddress("alSourcefv");
        _alSourcei = (delegate* unmanaged[Cdecl]<uint, int, int, void>)QuickGL.GetALProcAddress("alSourcei");
        _alSource3i = (delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)QuickGL.GetALProcAddress("alSource3i");
        _alSourceiv = (delegate* unmanaged[Cdecl]<uint, int, int*, void>)QuickGL.GetALProcAddress("alSourceiv");
        _alGetSourcef = (delegate* unmanaged[Cdecl]<uint, int, float*, void>)QuickGL.GetALProcAddress("alGetSourcef");
        _alGetSource3f = (delegate* unmanaged[Cdecl]<uint, int, float*, float*, float*, void>)QuickGL.GetALProcAddress("alGetSource3f");
        _alGetSourcefv = (delegate* unmanaged[Cdecl]<uint, int, float*, void>)QuickGL.GetALProcAddress("alGetSourcefv");
        _alGetSourcei = (delegate* unmanaged[Cdecl]<uint, int, int*, void>)QuickGL.GetALProcAddress("alGetSourcei");
        _alGetSource3i = (delegate* unmanaged[Cdecl]<uint, int, int*, int*, int*, void>)QuickGL.GetALProcAddress("alGetSource3i");
        _alGetSourceiv = (delegate* unmanaged[Cdecl]<uint, int, int*, void>)QuickGL.GetALProcAddress("alGetSourceiv");
        _alSourcePlay = (delegate* unmanaged[Cdecl]<uint, void>)QuickGL.GetALProcAddress("alSourcePlay");
        _alSourceStop = (delegate* unmanaged[Cdecl]<uint, void>)QuickGL.GetALProcAddress("alSourceStop");
        _alSourceRewind = (delegate* unmanaged[Cdecl]<uint, void>)QuickGL.GetALProcAddress("alSourceRewind");
        _alSourcePause = (delegate* unmanaged[Cdecl]<uint, void>)QuickGL.GetALProcAddress("alSourcePause");
        _alSourcePlayv = (delegate* unmanaged[Cdecl]<int, uint*, void>)QuickGL.GetALProcAddress("alSourcePlayv");
        _alSourceStopv = (delegate* unmanaged[Cdecl]<int, uint*, void>)QuickGL.GetALProcAddress("alSourceStopv");
        _alSourceRewindv = (delegate* unmanaged[Cdecl]<int, uint*, void>)QuickGL.GetALProcAddress("alSourceRewindv");
        _alSourcePausev = (delegate* unmanaged[Cdecl]<int, uint*, void>)QuickGL.GetALProcAddress("alSourcePausev");
        _alSourceQueueBuffers = (delegate* unmanaged[Cdecl]<uint, int, uint*, void>)QuickGL.GetALProcAddress("alSourceQueueBuffers");
        _alSourceUnqueueBuffers = (delegate* unmanaged[Cdecl]<uint, int, uint*, void>)QuickGL.GetALProcAddress("alSourceUnqueueBuffers");
        _alGenBuffers = (delegate* unmanaged[Cdecl]<int, uint*, void>)QuickGL.GetALProcAddress("alGenBuffers");
        _alDeleteBuffers = (delegate* unmanaged[Cdecl]<int, uint*, void>)QuickGL.GetALProcAddress("alDeleteBuffers");
        _alIsBuffer = (delegate* unmanaged[Cdecl]<uint, bool>)QuickGL.GetALProcAddress("alIsBuffer");
        _alBufferData = (delegate* unmanaged[Cdecl]<uint, int, void*, int, int, void>)QuickGL.GetALProcAddress("alBufferData");
        _alBufferf = (delegate* unmanaged[Cdecl]<uint, int, float, void>)QuickGL.GetALProcAddress("alBufferf");
        _alBuffer3f = (delegate* unmanaged[Cdecl]<uint, int, float, float, float, void>)QuickGL.GetALProcAddress("alBuffer3f");
        _alBufferfv = (delegate* unmanaged[Cdecl]<uint, int, float*, void>)QuickGL.GetALProcAddress("alBufferfv");
        _alBufferi = (delegate* unmanaged[Cdecl]<uint, int, int, void>)QuickGL.GetALProcAddress("alBufferi");
        _alBuffer3i = (delegate* unmanaged[Cdecl]<uint, int, int, int, int, void>)QuickGL.GetALProcAddress("alBuffer3i");
        _alBufferiv = (delegate* unmanaged[Cdecl]<uint, int, int*, void>)QuickGL.GetALProcAddress("alBufferiv");
        _alGetBufferf = (delegate* unmanaged[Cdecl]<uint, int, float*, void>)QuickGL.GetALProcAddress("alGetBufferf");
        _alGetBuffer3f = (delegate* unmanaged[Cdecl]<uint, int, float*, float*, float*, void>)QuickGL.GetALProcAddress("alGetBuffer3f");
        _alGetBufferfv = (delegate* unmanaged[Cdecl]<uint, int, float*, void>)QuickGL.GetALProcAddress("alGetBufferfv");
        _alGetBufferi = (delegate* unmanaged[Cdecl]<uint, int, int*, void>)QuickGL.GetALProcAddress("alGetBufferi");
        _alGetBuffer3i = (delegate* unmanaged[Cdecl]<uint, int, int*, int*, int*, void>)QuickGL.GetALProcAddress("alGetBuffer3i");
        _alGetBufferiv = (delegate* unmanaged[Cdecl]<uint, int, int*, void>)QuickGL.GetALProcAddress("alGetBufferiv");
    }
    
    internal static void Unload()
    {
        _alEnable = null;
        _alDisable = null;
        _alIsEnabled = null;
        _alDopplerFactor = null;
        _alDopplerVelocity = null;
        _alSpeedOfSound = null;
        _alDistanceModel = null;
        _alGetString = null;
        _alGetBooleanv = null;
        _alGetIntegerv = null;
        _alGetFloatv = null;
        _alGetDoublev = null;
        _alGetBoolean = null;
        _alGetInteger = null;
        _alGetFloat = null;
        _alGetDouble = null;
        _alGetError = null;
        _alIsExtensionPresent = null;
        _alGetProcAddress = null;
        _alGetEnumValue = null;
        _alListenerf = null;
        _alListener3f = null;
        _alListenerfv = null;
        _alListeneri = null;
        _alListener3i = null;
        _alListeneriv = null;
        _alGetListenerf = null;
        _alGetListener3f = null;
        _alGetListenerfv = null;
        _alGetListeneri = null;
        _alGetListener3i = null;
        _alGetListeneriv = null;
        _alGenSources = null;
        _alDeleteSources = null;
        _alIsSource = null;
        _alSourcef = null;
        _alSource3f = null;
        _alSourcefv = null;
        _alSourcei = null;
        _alSource3i = null;
        _alSourceiv = null;
        _alGetSourcef = null;
        _alGetSource3f = null;
        _alGetSourcefv = null;
        _alGetSourcei = null;
        _alGetSource3i = null;
        _alGetSourceiv = null;
        _alSourcePlay = null;
        _alSourceStop = null;
        _alSourceRewind = null;
        _alSourcePause = null;
        _alSourcePlayv = null;
        _alSourceStopv = null;
        _alSourceRewindv = null;
        _alSourcePausev = null;
        _alSourceQueueBuffers = null;
        _alSourceUnqueueBuffers = null;
        _alGenBuffers = null;
        _alDeleteBuffers = null;
        _alIsBuffer = null;
        _alBufferData = null;
        _alBufferf = null;
        _alBuffer3f = null;
        _alBufferfv = null;
        _alBufferi = null;
        _alBuffer3i = null;
        _alBufferiv = null;
        _alGetBufferf = null;
        _alGetBuffer3f = null;
        _alGetBufferfv = null;
        _alGetBufferi = null;
        _alGetBuffer3i = null;
        _alGetBufferiv = null;
    }
    
}
