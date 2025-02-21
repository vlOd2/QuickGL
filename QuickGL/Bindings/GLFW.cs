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

// Bindings generated at 2025-02-21 16:29:57.824525
namespace QuickGLNS.Bindings;

#region Callbacks
[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWglproc();

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWvkproc();

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void* GLFWallocatefun(nuint size, void* user);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void* GLFWreallocatefun(void* block, nuint size, void* user);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWdeallocatefun(void* block, void* user);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWerrorfun(int error_code, byte* description);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWwindowposfun(nint window, int xpos, int ypos);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWwindowsizefun(nint window, int width, int height);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWwindowclosefun(nint window);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWwindowrefreshfun(nint window);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWwindowfocusfun(nint window, int focused);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWwindowiconifyfun(nint window, int iconified);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWwindowmaximizefun(nint window, int maximized);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWframebuffersizefun(nint window, int width, int height);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWwindowcontentscalefun(nint window, float xscale, float yscale);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWmousebuttonfun(nint window, int button, int action, int mods);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWcursorposfun(nint window, double xpos, double ypos);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWcursorenterfun(nint window, int entered);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWscrollfun(nint window, double xoffset, double yoffset);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWkeyfun(nint window, int key, int scancode, int action, int mods);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWcharfun(nint window, uint codepoint);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWcharmodsfun(nint window, uint codepoint, int mods);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWdropfun(nint window, int path_count, byte** paths);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWmonitorfun(nint monitor, int @event);

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public unsafe delegate void GLFWjoystickfun(int jid, int @event);
#endregion

public unsafe struct GLFWvidmode
{
    public int width;
    public int height;
    public int redBits;
    public int greenBits;
    public int blueBits;
    public int refreshRate;
}

public unsafe struct GLFWgammaramp
{
    public ushort* red;
    public ushort* green;
    public ushort* blue;
    public uint size;
}

public unsafe struct GLFWimage
{
    public int width;
    public int height;
    public byte* pixels;
}

public unsafe struct GLFWgamepadstate
{
    public fixed byte buttons[15];
    public fixed float axes[6];
}

public unsafe struct GLFWallocator
{
    public nint allocate;
    public nint reallocate;
    public nint deallocate;
    public void* user;
}

public static unsafe class GLFW
{
    #region Constants
    public const int GLFW_VERSION_MAJOR = 0x3;
    public const int GLFW_VERSION_MINOR = 0x5;
    public const int GLFW_VERSION_REVISION = 0x0;
    public const int GLFW_TRUE = 0x1;
    public const int GLFW_FALSE = 0x0;
    public const int GLFW_RELEASE = 0x0;
    public const int GLFW_PRESS = 0x1;
    public const int GLFW_REPEAT = 0x2;
    public const int GLFW_HAT_CENTERED = 0x0;
    public const int GLFW_HAT_UP = 0x1;
    public const int GLFW_HAT_RIGHT = 0x2;
    public const int GLFW_HAT_DOWN = 0x4;
    public const int GLFW_HAT_LEFT = 0x8;
    public const uint GLFW_HAT_RIGHT_UP = (GLFW_HAT_RIGHT | GLFW_HAT_UP);
    public const uint GLFW_HAT_RIGHT_DOWN = (GLFW_HAT_RIGHT | GLFW_HAT_DOWN);
    public const uint GLFW_HAT_LEFT_UP = (GLFW_HAT_LEFT  | GLFW_HAT_UP);
    public const uint GLFW_HAT_LEFT_DOWN = (GLFW_HAT_LEFT  | GLFW_HAT_DOWN);
    public const int GLFW_KEY_UNKNOWN = -0x1;
    public const int GLFW_KEY_SPACE = 0x20;
    public const int GLFW_KEY_APOSTROPHE = 0x27;
    public const int GLFW_KEY_COMMA = 0x2C;
    public const int GLFW_KEY_MINUS = 0x2D;
    public const int GLFW_KEY_PERIOD = 0x2E;
    public const int GLFW_KEY_SLASH = 0x2F;
    public const int GLFW_KEY_0 = 0x30;
    public const int GLFW_KEY_1 = 0x31;
    public const int GLFW_KEY_2 = 0x32;
    public const int GLFW_KEY_3 = 0x33;
    public const int GLFW_KEY_4 = 0x34;
    public const int GLFW_KEY_5 = 0x35;
    public const int GLFW_KEY_6 = 0x36;
    public const int GLFW_KEY_7 = 0x37;
    public const int GLFW_KEY_8 = 0x38;
    public const int GLFW_KEY_9 = 0x39;
    public const int GLFW_KEY_SEMICOLON = 0x3B;
    public const int GLFW_KEY_EQUAL = 0x3D;
    public const int GLFW_KEY_A = 0x41;
    public const int GLFW_KEY_B = 0x42;
    public const int GLFW_KEY_C = 0x43;
    public const int GLFW_KEY_D = 0x44;
    public const int GLFW_KEY_E = 0x45;
    public const int GLFW_KEY_F = 0x46;
    public const int GLFW_KEY_G = 0x47;
    public const int GLFW_KEY_H = 0x48;
    public const int GLFW_KEY_I = 0x49;
    public const int GLFW_KEY_J = 0x4A;
    public const int GLFW_KEY_K = 0x4B;
    public const int GLFW_KEY_L = 0x4C;
    public const int GLFW_KEY_M = 0x4D;
    public const int GLFW_KEY_N = 0x4E;
    public const int GLFW_KEY_O = 0x4F;
    public const int GLFW_KEY_P = 0x50;
    public const int GLFW_KEY_Q = 0x51;
    public const int GLFW_KEY_R = 0x52;
    public const int GLFW_KEY_S = 0x53;
    public const int GLFW_KEY_T = 0x54;
    public const int GLFW_KEY_U = 0x55;
    public const int GLFW_KEY_V = 0x56;
    public const int GLFW_KEY_W = 0x57;
    public const int GLFW_KEY_X = 0x58;
    public const int GLFW_KEY_Y = 0x59;
    public const int GLFW_KEY_Z = 0x5A;
    public const int GLFW_KEY_LEFT_BRACKET = 0x5B;
    public const int GLFW_KEY_BACKSLASH = 0x5C;
    public const int GLFW_KEY_RIGHT_BRACKET = 0x5D;
    public const int GLFW_KEY_GRAVE_ACCENT = 0x60;
    public const int GLFW_KEY_WORLD_1 = 0xA1;
    public const int GLFW_KEY_WORLD_2 = 0xA2;
    public const int GLFW_KEY_ESCAPE = 0x100;
    public const int GLFW_KEY_ENTER = 0x101;
    public const int GLFW_KEY_TAB = 0x102;
    public const int GLFW_KEY_BACKSPACE = 0x103;
    public const int GLFW_KEY_INSERT = 0x104;
    public const int GLFW_KEY_DELETE = 0x105;
    public const int GLFW_KEY_RIGHT = 0x106;
    public const int GLFW_KEY_LEFT = 0x107;
    public const int GLFW_KEY_DOWN = 0x108;
    public const int GLFW_KEY_UP = 0x109;
    public const int GLFW_KEY_PAGE_UP = 0x10A;
    public const int GLFW_KEY_PAGE_DOWN = 0x10B;
    public const int GLFW_KEY_HOME = 0x10C;
    public const int GLFW_KEY_END = 0x10D;
    public const int GLFW_KEY_CAPS_LOCK = 0x118;
    public const int GLFW_KEY_SCROLL_LOCK = 0x119;
    public const int GLFW_KEY_NUM_LOCK = 0x11A;
    public const int GLFW_KEY_PRINT_SCREEN = 0x11B;
    public const int GLFW_KEY_PAUSE = 0x11C;
    public const int GLFW_KEY_F1 = 0x122;
    public const int GLFW_KEY_F2 = 0x123;
    public const int GLFW_KEY_F3 = 0x124;
    public const int GLFW_KEY_F4 = 0x125;
    public const int GLFW_KEY_F5 = 0x126;
    public const int GLFW_KEY_F6 = 0x127;
    public const int GLFW_KEY_F7 = 0x128;
    public const int GLFW_KEY_F8 = 0x129;
    public const int GLFW_KEY_F9 = 0x12A;
    public const int GLFW_KEY_F10 = 0x12B;
    public const int GLFW_KEY_F11 = 0x12C;
    public const int GLFW_KEY_F12 = 0x12D;
    public const int GLFW_KEY_F13 = 0x12E;
    public const int GLFW_KEY_F14 = 0x12F;
    public const int GLFW_KEY_F15 = 0x130;
    public const int GLFW_KEY_F16 = 0x131;
    public const int GLFW_KEY_F17 = 0x132;
    public const int GLFW_KEY_F18 = 0x133;
    public const int GLFW_KEY_F19 = 0x134;
    public const int GLFW_KEY_F20 = 0x135;
    public const int GLFW_KEY_F21 = 0x136;
    public const int GLFW_KEY_F22 = 0x137;
    public const int GLFW_KEY_F23 = 0x138;
    public const int GLFW_KEY_F24 = 0x139;
    public const int GLFW_KEY_F25 = 0x13A;
    public const int GLFW_KEY_KP_0 = 0x140;
    public const int GLFW_KEY_KP_1 = 0x141;
    public const int GLFW_KEY_KP_2 = 0x142;
    public const int GLFW_KEY_KP_3 = 0x143;
    public const int GLFW_KEY_KP_4 = 0x144;
    public const int GLFW_KEY_KP_5 = 0x145;
    public const int GLFW_KEY_KP_6 = 0x146;
    public const int GLFW_KEY_KP_7 = 0x147;
    public const int GLFW_KEY_KP_8 = 0x148;
    public const int GLFW_KEY_KP_9 = 0x149;
    public const int GLFW_KEY_KP_DECIMAL = 0x14A;
    public const int GLFW_KEY_KP_DIVIDE = 0x14B;
    public const int GLFW_KEY_KP_MULTIPLY = 0x14C;
    public const int GLFW_KEY_KP_SUBTRACT = 0x14D;
    public const int GLFW_KEY_KP_ADD = 0x14E;
    public const int GLFW_KEY_KP_ENTER = 0x14F;
    public const int GLFW_KEY_KP_EQUAL = 0x150;
    public const int GLFW_KEY_LEFT_SHIFT = 0x154;
    public const int GLFW_KEY_LEFT_CONTROL = 0x155;
    public const int GLFW_KEY_LEFT_ALT = 0x156;
    public const int GLFW_KEY_LEFT_SUPER = 0x157;
    public const int GLFW_KEY_RIGHT_SHIFT = 0x158;
    public const int GLFW_KEY_RIGHT_CONTROL = 0x159;
    public const int GLFW_KEY_RIGHT_ALT = 0x15A;
    public const int GLFW_KEY_RIGHT_SUPER = 0x15B;
    public const int GLFW_KEY_MENU = 0x15C;
    public const uint GLFW_KEY_LAST = GLFW_KEY_MENU;
    public const int GLFW_MOD_SHIFT = 0x1;
    public const int GLFW_MOD_CONTROL = 0x2;
    public const int GLFW_MOD_ALT = 0x4;
    public const int GLFW_MOD_SUPER = 0x8;
    public const int GLFW_MOD_CAPS_LOCK = 0x10;
    public const int GLFW_MOD_NUM_LOCK = 0x20;
    public const int GLFW_MOUSE_BUTTON_1 = 0x0;
    public const int GLFW_MOUSE_BUTTON_2 = 0x1;
    public const int GLFW_MOUSE_BUTTON_3 = 0x2;
    public const int GLFW_MOUSE_BUTTON_4 = 0x3;
    public const int GLFW_MOUSE_BUTTON_5 = 0x4;
    public const int GLFW_MOUSE_BUTTON_6 = 0x5;
    public const int GLFW_MOUSE_BUTTON_7 = 0x6;
    public const int GLFW_MOUSE_BUTTON_8 = 0x7;
    public const uint GLFW_MOUSE_BUTTON_LAST = GLFW_MOUSE_BUTTON_8;
    public const uint GLFW_MOUSE_BUTTON_LEFT = GLFW_MOUSE_BUTTON_1;
    public const uint GLFW_MOUSE_BUTTON_RIGHT = GLFW_MOUSE_BUTTON_2;
    public const uint GLFW_MOUSE_BUTTON_MIDDLE = GLFW_MOUSE_BUTTON_3;
    public const int GLFW_JOYSTICK_1 = 0x0;
    public const int GLFW_JOYSTICK_2 = 0x1;
    public const int GLFW_JOYSTICK_3 = 0x2;
    public const int GLFW_JOYSTICK_4 = 0x3;
    public const int GLFW_JOYSTICK_5 = 0x4;
    public const int GLFW_JOYSTICK_6 = 0x5;
    public const int GLFW_JOYSTICK_7 = 0x6;
    public const int GLFW_JOYSTICK_8 = 0x7;
    public const int GLFW_JOYSTICK_9 = 0x8;
    public const int GLFW_JOYSTICK_10 = 0x9;
    public const int GLFW_JOYSTICK_11 = 0xA;
    public const int GLFW_JOYSTICK_12 = 0xB;
    public const int GLFW_JOYSTICK_13 = 0xC;
    public const int GLFW_JOYSTICK_14 = 0xD;
    public const int GLFW_JOYSTICK_15 = 0xE;
    public const int GLFW_JOYSTICK_16 = 0xF;
    public const uint GLFW_JOYSTICK_LAST = GLFW_JOYSTICK_16;
    public const int GLFW_GAMEPAD_BUTTON_A = 0x0;
    public const int GLFW_GAMEPAD_BUTTON_B = 0x1;
    public const int GLFW_GAMEPAD_BUTTON_X = 0x2;
    public const int GLFW_GAMEPAD_BUTTON_Y = 0x3;
    public const int GLFW_GAMEPAD_BUTTON_LEFT_BUMPER = 0x4;
    public const int GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER = 0x5;
    public const int GLFW_GAMEPAD_BUTTON_BACK = 0x6;
    public const int GLFW_GAMEPAD_BUTTON_START = 0x7;
    public const int GLFW_GAMEPAD_BUTTON_GUIDE = 0x8;
    public const int GLFW_GAMEPAD_BUTTON_LEFT_THUMB = 0x9;
    public const int GLFW_GAMEPAD_BUTTON_RIGHT_THUMB = 0xA;
    public const int GLFW_GAMEPAD_BUTTON_DPAD_UP = 0xB;
    public const int GLFW_GAMEPAD_BUTTON_DPAD_RIGHT = 0xC;
    public const int GLFW_GAMEPAD_BUTTON_DPAD_DOWN = 0xD;
    public const int GLFW_GAMEPAD_BUTTON_DPAD_LEFT = 0xE;
    public const uint GLFW_GAMEPAD_BUTTON_LAST = GLFW_GAMEPAD_BUTTON_DPAD_LEFT;
    public const uint GLFW_GAMEPAD_BUTTON_CROSS = GLFW_GAMEPAD_BUTTON_A;
    public const uint GLFW_GAMEPAD_BUTTON_CIRCLE = GLFW_GAMEPAD_BUTTON_B;
    public const uint GLFW_GAMEPAD_BUTTON_SQUARE = GLFW_GAMEPAD_BUTTON_X;
    public const uint GLFW_GAMEPAD_BUTTON_TRIANGLE = GLFW_GAMEPAD_BUTTON_Y;
    public const int GLFW_GAMEPAD_AXIS_LEFT_X = 0x0;
    public const int GLFW_GAMEPAD_AXIS_LEFT_Y = 0x1;
    public const int GLFW_GAMEPAD_AXIS_RIGHT_X = 0x2;
    public const int GLFW_GAMEPAD_AXIS_RIGHT_Y = 0x3;
    public const int GLFW_GAMEPAD_AXIS_LEFT_TRIGGER = 0x4;
    public const int GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER = 0x5;
    public const uint GLFW_GAMEPAD_AXIS_LAST = GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER;
    public const int GLFW_NO_ERROR = 0x0;
    public const int GLFW_NOT_INITIALIZED = 0x10001;
    public const int GLFW_NO_CURRENT_CONTEXT = 0x10002;
    public const int GLFW_INVALID_ENUM = 0x10003;
    public const int GLFW_INVALID_VALUE = 0x10004;
    public const int GLFW_OUT_OF_MEMORY = 0x10005;
    public const int GLFW_API_UNAVAILABLE = 0x10006;
    public const int GLFW_VERSION_UNAVAILABLE = 0x10007;
    public const int GLFW_PLATFORM_ERROR = 0x10008;
    public const int GLFW_FORMAT_UNAVAILABLE = 0x10009;
    public const int GLFW_NO_WINDOW_CONTEXT = 0x1000;
    public const int GLFW_CURSOR_UNAVAILABLE = 0x1000;
    public const int GLFW_FEATURE_UNAVAILABLE = 0x1000;
    public const int GLFW_FEATURE_UNIMPLEMENTED = 0x1000;
    public const int GLFW_PLATFORM_UNAVAILABLE = 0x1000;
    public const int GLFW_FOCUSED = 0x20001;
    public const int GLFW_ICONIFIED = 0x20002;
    public const int GLFW_RESIZABLE = 0x20003;
    public const int GLFW_VISIBLE = 0x20004;
    public const int GLFW_DECORATED = 0x20005;
    public const int GLFW_AUTO_ICONIFY = 0x20006;
    public const int GLFW_FLOATING = 0x20007;
    public const int GLFW_MAXIMIZED = 0x20008;
    public const int GLFW_CENTER_CURSOR = 0x20009;
    public const int GLFW_TRANSPARENT_FRAMEBUFFER = 0x2000;
    public const int GLFW_HOVERED = 0x2000;
    public const int GLFW_FOCUS_ON_SHOW = 0x2000;
    public const int GLFW_MOUSE_PASSTHROUGH = 0x2000;
    public const int GLFW_POSITION_X = 0x2000;
    public const int GLFW_POSITION_Y = 0x2000;
    public const int GLFW_RED_BITS = 0x21001;
    public const int GLFW_GREEN_BITS = 0x21002;
    public const int GLFW_BLUE_BITS = 0x21003;
    public const int GLFW_ALPHA_BITS = 0x21004;
    public const int GLFW_DEPTH_BITS = 0x21005;
    public const int GLFW_STENCIL_BITS = 0x21006;
    public const int GLFW_ACCUM_RED_BITS = 0x21007;
    public const int GLFW_ACCUM_GREEN_BITS = 0x21008;
    public const int GLFW_ACCUM_BLUE_BITS = 0x21009;
    public const int GLFW_ACCUM_ALPHA_BITS = 0x2100;
    public const int GLFW_AUX_BUFFERS = 0x2100;
    public const int GLFW_STEREO = 0x2100;
    public const int GLFW_SAMPLES = 0x2100;
    public const int GLFW_SRGB_CAPABLE = 0x2100;
    public const int GLFW_REFRESH_RATE = 0x2100;
    public const int GLFW_DOUBLEBUFFER = 0x21010;
    public const int GLFW_CLIENT_API = 0x22001;
    public const int GLFW_CONTEXT_VERSION_MAJOR = 0x22002;
    public const int GLFW_CONTEXT_VERSION_MINOR = 0x22003;
    public const int GLFW_CONTEXT_REVISION = 0x22004;
    public const int GLFW_CONTEXT_ROBUSTNESS = 0x22005;
    public const int GLFW_OPENGL_FORWARD_COMPAT = 0x22006;
    public const int GLFW_CONTEXT_DEBUG = 0x22007;
    public const uint GLFW_OPENGL_DEBUG_CONTEXT = GLFW_CONTEXT_DEBUG;
    public const int GLFW_OPENGL_PROFILE = 0x22008;
    public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x22009;
    public const int GLFW_CONTEXT_NO_ERROR = 0x2200;
    public const int GLFW_CONTEXT_CREATION_API = 0x2200;
    public const int GLFW_SCALE_TO_MONITOR = 0x2200;
    public const int GLFW_SCALE_FRAMEBUFFER = 0x2200;
    public const int GLFW_COCOA_RETINA_FRAMEBUFFER = 0x23001;
    public const int GLFW_COCOA_FRAME_NAME = 0x23002;
    public const int GLFW_COCOA_GRAPHICS_SWITCHING = 0x23003;
    public const int GLFW_X11_CLASS_NAME = 0x24001;
    public const int GLFW_X11_INSTANCE_NAME = 0x24002;
    public const int GLFW_WIN32_KEYBOARD_MENU = 0x25001;
    public const int GLFW_WIN32_SHOWDEFAULT = 0x25002;
    public const int GLFW_WAYLAND_APP_ID = 0x26001;
    public const int GLFW_NO_API = 0x0;
    public const int GLFW_OPENGL_API = 0x30001;
    public const int GLFW_OPENGL_ES_API = 0x30002;
    public const int GLFW_NO_ROBUSTNESS = 0x0;
    public const int GLFW_NO_RESET_NOTIFICATION = 0x31001;
    public const int GLFW_LOSE_CONTEXT_ON_RESET = 0x31002;
    public const int GLFW_OPENGL_ANY_PROFILE = 0x0;
    public const int GLFW_OPENGL_CORE_PROFILE = 0x32001;
    public const int GLFW_OPENGL_COMPAT_PROFILE = 0x32002;
    public const int GLFW_CURSOR = 0x33001;
    public const int GLFW_STICKY_KEYS = 0x33002;
    public const int GLFW_STICKY_MOUSE_BUTTONS = 0x33003;
    public const int GLFW_LOCK_KEY_MODS = 0x33004;
    public const int GLFW_RAW_MOUSE_MOTION = 0x33005;
    public const int GLFW_UNLIMITED_MOUSE_BUTTONS = 0x33006;
    public const int GLFW_CURSOR_NORMAL = 0x34001;
    public const int GLFW_CURSOR_HIDDEN = 0x34002;
    public const int GLFW_CURSOR_DISABLED = 0x34003;
    public const int GLFW_CURSOR_CAPTURED = 0x34004;
    public const int GLFW_ANY_RELEASE_BEHAVIOR = 0x0;
    public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 0x35001;
    public const int GLFW_RELEASE_BEHAVIOR_NONE = 0x35002;
    public const int GLFW_NATIVE_CONTEXT_API = 0x36001;
    public const int GLFW_EGL_CONTEXT_API = 0x36002;
    public const int GLFW_OSMESA_CONTEXT_API = 0x36003;
    public const int GLFW_ANGLE_PLATFORM_TYPE_NONE = 0x37001;
    public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGL = 0x37002;
    public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGLES = 0x37003;
    public const int GLFW_ANGLE_PLATFORM_TYPE_D3D9 = 0x37004;
    public const int GLFW_ANGLE_PLATFORM_TYPE_D3D11 = 0x37005;
    public const int GLFW_ANGLE_PLATFORM_TYPE_VULKAN = 0x37007;
    public const int GLFW_ANGLE_PLATFORM_TYPE_METAL = 0x37008;
    public const int GLFW_WAYLAND_PREFER_LIBDECOR = 0x38001;
    public const int GLFW_WAYLAND_DISABLE_LIBDECOR = 0x38002;
    public const uint GLFW_ANY_POSITION = 0x80000000;
    public const int GLFW_ARROW_CURSOR = 0x36001;
    public const int GLFW_IBEAM_CURSOR = 0x36002;
    public const int GLFW_CROSSHAIR_CURSOR = 0x36003;
    public const int GLFW_POINTING_HAND_CURSOR = 0x36004;
    public const int GLFW_RESIZE_EW_CURSOR = 0x36005;
    public const int GLFW_RESIZE_NS_CURSOR = 0x36006;
    public const int GLFW_RESIZE_NWSE_CURSOR = 0x36007;
    public const int GLFW_RESIZE_NESW_CURSOR = 0x36008;
    public const int GLFW_RESIZE_ALL_CURSOR = 0x36009;
    public const int GLFW_NOT_ALLOWED_CURSOR = 0x3600;
    public const uint GLFW_HRESIZE_CURSOR = GLFW_RESIZE_EW_CURSOR;
    public const uint GLFW_VRESIZE_CURSOR = GLFW_RESIZE_NS_CURSOR;
    public const uint GLFW_HAND_CURSOR = GLFW_POINTING_HAND_CURSOR;
    public const int GLFW_CONNECTED = 0x40001;
    public const int GLFW_DISCONNECTED = 0x40002;
    public const int GLFW_JOYSTICK_HAT_BUTTONS = 0x50001;
    public const int GLFW_ANGLE_PLATFORM_TYPE = 0x50002;
    public const int GLFW_PLATFORM = 0x50003;
    public const int GLFW_COCOA_CHDIR_RESOURCES = 0x51001;
    public const int GLFW_COCOA_MENUBAR = 0x51002;
    public const int GLFW_X11_XCB_VULKAN_SURFACE = 0x52001;
    public const int GLFW_WAYLAND_LIBDECOR = 0x53001;
    public const int GLFW_ANY_PLATFORM = 0x60000;
    public const int GLFW_PLATFORM_WIN32 = 0x60001;
    public const int GLFW_PLATFORM_COCOA = 0x60002;
    public const int GLFW_PLATFORM_WAYLAND = 0x60003;
    public const int GLFW_PLATFORM_X11 = 0x60004;
    public const int GLFW_PLATFORM_NULL = 0x60005;
    public const int GLFW_DONT_CARE = -0x1;
    #endregion
    
    #region Functions
    public static int glfwInit() => _glfwInit();
    [QGLNativeAPI("glfwInit")] internal static delegate* unmanaged<int> _glfwInit = null;
    
    /// <summary>
    /// Terminates the GLFW library.<br/>
    /// <br/>
    /// This function destroys all remaining windows and cursors, restores any<br/>
    /// modified gamma ramps and frees any other allocated resources.  Once this<br/>
    /// function is called, you must again call <see cref="glfwInit"/> successfully before<br/>
    /// you will be able to use most GLFW functions.<br/>
    /// <br/>
    /// If GLFW has been successfully initialized, this function should be called<br/>
    /// before the application exits.  If initialization fails, there is no need to<br/>
    /// call this function, as it is called by <see cref="glfwInit"/> before it returns<br/>
    /// failure.<br/>
    /// <br/>
    /// This function has no effect if GLFW is not initialized.<br/>
    /// </summary>
    public static void glfwTerminate() => _glfwTerminate();
    [QGLNativeAPI("glfwTerminate")] internal static delegate* unmanaged<void> _glfwTerminate = null;
    
    /// <summary>
    /// Sets the specified init hint to the desired value.<br/>
    /// <br/>
    /// This function sets hints for the next initialization of GLFW.<br/>
    /// <br/>
    /// The values you set hints to are never reset by GLFW, but they only take<br/>
    /// effect during initialization.  Once GLFW has been initialized, any values<br/>
    /// you set will be ignored until the library is terminated and initialized<br/>
    /// again.<br/>
    /// <br/>
    /// Some hints are platform specific.  These may be set on any platform but they<br/>
    /// will only affect their specific platform.  Other platforms will ignore them.<br/>
    /// Setting these hints requires no platform specific headers or functions.<br/>
    /// </summary>
    /// <param name="hint">The <see cref="init_hints">init hint</see> to set.</param>
    /// <param name="value">The new value of the init hint.</param>
    public static void glfwInitHint(int hint, int value) => _glfwInitHint(hint, value);
    [QGLNativeAPI("glfwInitHint")] internal static delegate* unmanaged<int, int, void> _glfwInitHint = null;
    
    /// <summary>
    /// Sets the init allocator to the desired value.<br/>
    /// <br/>
    /// To use the default allocator, call this function with a `NULL` argument.<br/>
    /// <br/>
    /// If you specify an allocator struct, every member must be a valid function<br/>
    /// pointer.  If any member is `NULL`, this function will emit <see cref="GLFW_INVALID_VALUE"/> and the init allocator will be unchanged.<br/>
    /// <br/>
    /// The functions in the allocator must fulfil a number of requirements.  See the<br/>
    /// documentation for <see cref="GLFWallocatefun"/>, <see cref="GLFWreallocatefun"/> and <see cref="GLFWdeallocatefun"/> for details.<br/>
    /// </summary>
    /// <param name="allocator">The allocator to use at the next initialization, or<br/>`NULL` to use the default one.</param>
    public static void glfwInitAllocator(GLFWallocator* allocator) => _glfwInitAllocator(allocator);
    [QGLNativeAPI("glfwInitAllocator")] internal static delegate* unmanaged<GLFWallocator*, void> _glfwInitAllocator = null;
    
    /// <summary>
    /// Retrieves the version of the GLFW library.<br/>
    /// <br/>
    /// This function retrieves the major, minor and revision numbers of the GLFW<br/>
    /// library.  It is intended for when you are using GLFW as a shared library and<br/>
    /// want to ensure that you are using the minimum required version.<br/>
    /// <br/>
    /// Any or all of the version arguments may be `NULL`.<br/>
    /// </summary>
    /// <param name="major">Where to store the major version number, or `NULL`.</param>
    /// <param name="minor">Where to store the minor version number, or `NULL`.</param>
    /// <param name="rev">Where to store the revision number, or `NULL`.</param>
    public static void glfwGetVersion(int* major, int* minor, int* rev) => _glfwGetVersion(major, minor, rev);
    [QGLNativeAPI("glfwGetVersion")] internal static delegate* unmanaged<int*, int*, int*, void> _glfwGetVersion = null;
    
    /// <summary>
    /// Returns a string describing the compile-time configuration.<br/>
    /// <br/>
    /// This function returns the compile-time generated<br/>
    /// <see cref="intro_version_string">version string</see> of the GLFW library binary.  It describes<br/>
    /// the version, platforms, compiler and any platform or operating system specific<br/>
    /// compile-time options.  It should not be confused with the OpenGL or OpenGL ES version<br/>
    /// string, queried with `glGetString`.<br/>
    /// <br/>
    /// __Do not use the version string__ to parse the GLFW library version.  The<br/>
    /// <see cref="glfwGetVersion"/> function provides the version of the running library<br/>
    /// binary in numerical format.<br/>
    /// <br/>
    /// __Do not use the version string__ to parse what platforms are supported.  The <see cref="glfwPlatformSupported"/> function lets you query platform support.<br/>
    /// </summary>
    public static byte* glfwGetVersionString() => _glfwGetVersionString();
    [QGLNativeAPI("glfwGetVersionString")] internal static delegate* unmanaged<byte*> _glfwGetVersionString = null;
    
    /// <summary>
    /// Returns and clears the last error for the calling thread.<br/>
    /// <br/>
    /// This function returns and clears the <see cref="errors">error code</see> of the last<br/>
    /// error that occurred on the calling thread, and optionally a UTF-8 encoded<br/>
    /// human-readable description of it.  If no error has occurred since the last<br/>
    /// call, it returns <see cref="GLFW_NO_ERROR"/> (zero) and the description pointer is<br/>
    /// set to `NULL`.<br/>
    /// </summary>
    /// <param name="description">Where to store the error description pointer, or `NULL`.</param>
    public static int glfwGetError(byte** description) => _glfwGetError(description);
    [QGLNativeAPI("glfwGetError")] internal static delegate* unmanaged<byte**, int> _glfwGetError = null;
    
    /// <summary>
    /// Sets the error callback.<br/>
    /// <br/>
    /// This function sets the error callback, which is called with an error code<br/>
    /// and a human-readable description each time a GLFW error occurs.<br/>
    /// <br/>
    /// The error code is set before the callback is called.  Calling <see cref="glfwGetError"/> from the error callback will return the same value as the error<br/>
    /// code argument.<br/>
    /// <br/>
    /// The error callback is called on the thread where the error occurred.  If you<br/>
    /// are using GLFW from multiple threads, your error callback needs to be<br/>
    /// written accordingly.<br/>
    /// <br/>
    /// Because the description string may have been generated specifically for that<br/>
    /// error, it is not guaranteed to be valid after the callback has returned.  If<br/>
    /// you wish to use it after the callback returns, you need to make a copy.<br/>
    /// <br/>
    /// Once set, the error callback remains set even after the library has been<br/>
    /// terminated.<br/>
    /// </summary>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetErrorCallback(GLFWerrorfun callback) => _glfwSetErrorCallback(callback);
    [QGLNativeAPI("glfwSetErrorCallback")] internal static delegate* unmanaged<GLFWerrorfun, nint> _glfwSetErrorCallback = null;
    
    /// <summary>
    /// Returns the currently selected platform.<br/>
    /// <br/>
    /// This function returns the platform that was selected during initialization.  The<br/>
    /// returned value will be one of `GLFW_PLATFORM_WIN32`, `GLFW_PLATFORM_COCOA`,<br/>
    /// `GLFW_PLATFORM_WAYLAND`, `GLFW_PLATFORM_X11` or `GLFW_PLATFORM_NULL`.<br/>
    /// </summary>
    public static int glfwGetPlatform() => _glfwGetPlatform();
    [QGLNativeAPI("glfwGetPlatform")] internal static delegate* unmanaged<int> _glfwGetPlatform = null;
    
    /// <summary>
    /// Returns whether the library includes support for the specified platform.<br/>
    /// <br/>
    /// This function returns whether the library was compiled with support for the specified<br/>
    /// platform.  The platform must be one of `GLFW_PLATFORM_WIN32`, `GLFW_PLATFORM_COCOA`,<br/>
    /// `GLFW_PLATFORM_WAYLAND`, `GLFW_PLATFORM_X11` or `GLFW_PLATFORM_NULL`.<br/>
    /// </summary>
    /// <param name="platform">The platform to query.</param>
    public static int glfwPlatformSupported(int platform) => _glfwPlatformSupported(platform);
    [QGLNativeAPI("glfwPlatformSupported")] internal static delegate* unmanaged<int, int> _glfwPlatformSupported = null;
    
    /// <summary>
    /// Returns the currently connected monitors.<br/>
    /// <br/>
    /// This function returns an array of handles for all currently connected<br/>
    /// monitors.  The primary monitor is always first in the returned array.  If no<br/>
    /// monitors were found, this function returns `NULL`.<br/>
    /// </summary>
    /// <param name="count">Where to store the number of monitors in the returned<br/>array.  This is set to zero if an error occurred.</param>
    public static nint glfwGetMonitors(int* count) => _glfwGetMonitors(count);
    [QGLNativeAPI("glfwGetMonitors")] internal static delegate* unmanaged<int*, nint> _glfwGetMonitors = null;
    
    /// <summary>
    /// Returns the primary monitor.<br/>
    /// <br/>
    /// This function returns the primary monitor.  This is usually the monitor<br/>
    /// where elements like the task bar or global menu bar are located.<br/>
    /// </summary>
    public static nint glfwGetPrimaryMonitor() => _glfwGetPrimaryMonitor();
    [QGLNativeAPI("glfwGetPrimaryMonitor")] internal static delegate* unmanaged<nint> _glfwGetPrimaryMonitor = null;
    
    /// <summary>
    /// Returns the position of the monitor's viewport on the virtual screen.<br/>
    /// <br/>
    /// This function returns the position, in screen coordinates, of the upper-left<br/>
    /// corner of the specified monitor.<br/>
    /// <br/>
    /// Any or all of the position arguments may be `NULL`.  If an error occurs, all<br/>
    /// non-`NULL` position arguments will be set to zero.<br/>
    /// </summary>
    /// <param name="monitor">The monitor to query.</param>
    /// <param name="xpos">Where to store the monitor x-coordinate, or `NULL`.</param>
    /// <param name="ypos">Where to store the monitor y-coordinate, or `NULL`.</param>
    public static void glfwGetMonitorPos(nint monitor, int* xpos, int* ypos) => _glfwGetMonitorPos(monitor, xpos, ypos);
    [QGLNativeAPI("glfwGetMonitorPos")] internal static delegate* unmanaged<nint, int*, int*, void> _glfwGetMonitorPos = null;
    
    /// <summary>
    /// Retrieves the work area of the monitor.<br/>
    /// <br/>
    /// This function returns the position, in screen coordinates, of the upper-left<br/>
    /// corner of the work area of the specified monitor along with the work area<br/>
    /// size in screen coordinates. The work area is defined as the area of the<br/>
    /// monitor not occluded by the window system task bar where present. If no<br/>
    /// task bar exists then the work area is the monitor resolution in screen<br/>
    /// coordinates.<br/>
    /// <br/>
    /// Any or all of the position and size arguments may be `NULL`.  If an error<br/>
    /// occurs, all non-`NULL` position and size arguments will be set to zero.<br/>
    /// </summary>
    /// <param name="monitor">The monitor to query.</param>
    /// <param name="xpos">Where to store the monitor x-coordinate, or `NULL`.</param>
    /// <param name="ypos">Where to store the monitor y-coordinate, or `NULL`.</param>
    /// <param name="width">Where to store the monitor width, or `NULL`.</param>
    /// <param name="height">Where to store the monitor height, or `NULL`.</param>
    public static void glfwGetMonitorWorkarea(nint monitor, int* xpos, int* ypos, int* width, int* height) => _glfwGetMonitorWorkarea(monitor, xpos, ypos, width, height);
    [QGLNativeAPI("glfwGetMonitorWorkarea")] internal static delegate* unmanaged<nint, int*, int*, int*, int*, void> _glfwGetMonitorWorkarea = null;
    
    /// <summary>
    /// Returns the physical size of the monitor.<br/>
    /// <br/>
    /// This function returns the size, in millimetres, of the display area of the<br/>
    /// specified monitor.<br/>
    /// <br/>
    /// Some platforms do not provide accurate monitor size information, either<br/>
    /// because the monitor [EDID][] data is incorrect or because the driver does<br/>
    /// not report it accurately.<br/>
    /// <br/>
    /// [EDID]: https://en.wikipedia.org/wiki/Extended_display_identification_data<br/>
    /// <br/>
    /// Any or all of the size arguments may be `NULL`.  If an error occurs, all<br/>
    /// non-`NULL` size arguments will be set to zero.<br/>
    /// </summary>
    /// <param name="monitor">The monitor to query.</param>
    /// <param name="widthMM">Where to store the width, in millimetres, of the<br/>monitor's display area, or `NULL`.</param>
    /// <param name="heightMM">Where to store the height, in millimetres, of the<br/>monitor's display area, or `NULL`.</param>
    public static void glfwGetMonitorPhysicalSize(nint monitor, int* widthMM, int* heightMM) => _glfwGetMonitorPhysicalSize(monitor, widthMM, heightMM);
    [QGLNativeAPI("glfwGetMonitorPhysicalSize")] internal static delegate* unmanaged<nint, int*, int*, void> _glfwGetMonitorPhysicalSize = null;
    
    /// <summary>
    /// Retrieves the content scale for the specified monitor.<br/>
    /// <br/>
    /// This function retrieves the content scale for the specified monitor.  The<br/>
    /// content scale is the ratio between the current DPI and the platform's<br/>
    /// default DPI.  This is especially important for text and any UI elements.  If<br/>
    /// the pixel dimensions of your UI scaled by this look appropriate on your<br/>
    /// machine then it should appear at a reasonable size on other machines<br/>
    /// regardless of their DPI and scaling settings.  This relies on the system DPI<br/>
    /// and scaling settings being somewhat correct.<br/>
    /// <br/>
    /// The content scale may depend on both the monitor resolution and pixel<br/>
    /// density and on user settings.  It may be very different from the raw DPI<br/>
    /// calculated from the physical size and current resolution.<br/>
    /// </summary>
    /// <param name="monitor">The monitor to query.</param>
    /// <param name="xscale">Where to store the x-axis content scale, or `NULL`.</param>
    /// <param name="yscale">Where to store the y-axis content scale, or `NULL`.</param>
    public static void glfwGetMonitorContentScale(nint monitor, float* xscale, float* yscale) => _glfwGetMonitorContentScale(monitor, xscale, yscale);
    [QGLNativeAPI("glfwGetMonitorContentScale")] internal static delegate* unmanaged<nint, float*, float*, void> _glfwGetMonitorContentScale = null;
    
    /// <summary>
    /// Returns the name of the specified monitor.<br/>
    /// <br/>
    /// This function returns a human-readable name, encoded as UTF-8, of the<br/>
    /// specified monitor.  The name typically reflects the make and model of the<br/>
    /// monitor and is not guaranteed to be unique among the connected monitors.<br/>
    /// </summary>
    /// <param name="monitor">The monitor to query.</param>
    public static byte* glfwGetMonitorName(nint monitor) => _glfwGetMonitorName(monitor);
    [QGLNativeAPI("glfwGetMonitorName")] internal static delegate* unmanaged<nint, byte*> _glfwGetMonitorName = null;
    
    /// <summary>
    /// Sets the user pointer of the specified monitor.<br/>
    /// <br/>
    /// This function sets the user-defined pointer of the specified monitor.  The<br/>
    /// current value is retained until the monitor is disconnected.  The initial<br/>
    /// value is `NULL`.<br/>
    /// <br/>
    /// This function may be called from the monitor callback, even for a monitor<br/>
    /// that is being disconnected.<br/>
    /// </summary>
    /// <param name="monitor">The monitor whose pointer to set.</param>
    /// <param name="pointer">The new value.</param>
    public static void glfwSetMonitorUserPointer(nint monitor, void* pointer) => _glfwSetMonitorUserPointer(monitor, pointer);
    [QGLNativeAPI("glfwSetMonitorUserPointer")] internal static delegate* unmanaged<nint, void*, void> _glfwSetMonitorUserPointer = null;
    
    /// <summary>
    /// Returns the user pointer of the specified monitor.<br/>
    /// <br/>
    /// This function returns the current value of the user-defined pointer of the<br/>
    /// specified monitor.  The initial value is `NULL`.<br/>
    /// <br/>
    /// This function may be called from the monitor callback, even for a monitor<br/>
    /// that is being disconnected.<br/>
    /// </summary>
    /// <param name="monitor">The monitor whose pointer to return.</param>
    public static void* glfwGetMonitorUserPointer(nint monitor) => _glfwGetMonitorUserPointer(monitor);
    [QGLNativeAPI("glfwGetMonitorUserPointer")] internal static delegate* unmanaged<nint, void*> _glfwGetMonitorUserPointer = null;
    
    /// <summary>
    /// Sets the monitor configuration callback.<br/>
    /// <br/>
    /// This function sets the monitor configuration callback, or removes the<br/>
    /// currently set callback.  This is called when a monitor is connected to or<br/>
    /// disconnected from the system.<br/>
    /// </summary>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetMonitorCallback(GLFWmonitorfun callback) => _glfwSetMonitorCallback(callback);
    [QGLNativeAPI("glfwSetMonitorCallback")] internal static delegate* unmanaged<GLFWmonitorfun, nint> _glfwSetMonitorCallback = null;
    
    /// <summary>
    /// Returns the available video modes for the specified monitor.<br/>
    /// <br/>
    /// This function returns an array of all video modes supported by the specified<br/>
    /// monitor.  The returned array is sorted in ascending order, first by color<br/>
    /// bit depth (the sum of all channel depths), then by resolution area (the<br/>
    /// product of width and height), then resolution width and finally by refresh<br/>
    /// rate.<br/>
    /// </summary>
    /// <param name="monitor">The monitor to query.</param>
    /// <param name="count">Where to store the number of video modes in the returned<br/>array.  This is set to zero if an error occurred.</param>
    public static GLFWvidmode* glfwGetVideoModes(nint monitor, int* count) => _glfwGetVideoModes(monitor, count);
    [QGLNativeAPI("glfwGetVideoModes")] internal static delegate* unmanaged<nint, int*, GLFWvidmode*> _glfwGetVideoModes = null;
    
    /// <summary>
    /// Returns the current mode of the specified monitor.<br/>
    /// <br/>
    /// This function returns the current video mode of the specified monitor.  If<br/>
    /// you have created a full screen window for that monitor, the return value<br/>
    /// will depend on whether that window is iconified.<br/>
    /// </summary>
    /// <param name="monitor">The monitor to query.</param>
    public static GLFWvidmode* glfwGetVideoMode(nint monitor) => _glfwGetVideoMode(monitor);
    [QGLNativeAPI("glfwGetVideoMode")] internal static delegate* unmanaged<nint, GLFWvidmode*> _glfwGetVideoMode = null;
    
    /// <summary>
    /// Generates a gamma ramp and sets it for the specified monitor.<br/>
    /// <br/>
    /// This function generates an appropriately sized gamma ramp from the specified<br/>
    /// exponent and then calls <see cref="glfwSetGammaRamp"/> with it.  The value must be<br/>
    /// a finite number greater than zero.<br/>
    /// <br/>
    /// The software controlled gamma ramp is applied _in addition_ to the hardware<br/>
    /// gamma correction, which today is usually an approximation of sRGB gamma.<br/>
    /// This means that setting a perfectly linear ramp, or gamma 1.0, will produce<br/>
    /// the default (usually sRGB-like) behavior.<br/>
    /// <br/>
    /// For gamma correct rendering with OpenGL or OpenGL ES, see the <see cref="GLFW_SRGB_CAPABLE"/> hint.<br/>
    /// </summary>
    /// <param name="monitor">The monitor whose gamma ramp to set.</param>
    /// <param name="gamma">The desired exponent.</param>
    public static void glfwSetGamma(nint monitor, float gamma) => _glfwSetGamma(monitor, gamma);
    [QGLNativeAPI("glfwSetGamma")] internal static delegate* unmanaged<nint, float, void> _glfwSetGamma = null;
    
    /// <summary>
    /// Returns the current gamma ramp for the specified monitor.<br/>
    /// <br/>
    /// This function returns the current gamma ramp of the specified monitor.<br/>
    /// </summary>
    /// <param name="monitor">The monitor to query.</param>
    public static GLFWgammaramp* glfwGetGammaRamp(nint monitor) => _glfwGetGammaRamp(monitor);
    [QGLNativeAPI("glfwGetGammaRamp")] internal static delegate* unmanaged<nint, GLFWgammaramp*> _glfwGetGammaRamp = null;
    
    /// <summary>
    /// Sets the current gamma ramp for the specified monitor.<br/>
    /// <br/>
    /// This function sets the current gamma ramp for the specified monitor.  The<br/>
    /// original gamma ramp for that monitor is saved by GLFW the first time this<br/>
    /// function is called and is restored by <see cref="glfwTerminate"/>.<br/>
    /// <br/>
    /// The software controlled gamma ramp is applied _in addition_ to the hardware<br/>
    /// gamma correction, which today is usually an approximation of sRGB gamma.<br/>
    /// This means that setting a perfectly linear ramp, or gamma 1.0, will produce<br/>
    /// the default (usually sRGB-like) behavior.<br/>
    /// <br/>
    /// For gamma correct rendering with OpenGL or OpenGL ES, see the <see cref="GLFW_SRGB_CAPABLE"/> hint.<br/>
    /// </summary>
    /// <param name="monitor">The monitor whose gamma ramp to set.</param>
    /// <param name="ramp">The gamma ramp to use.</param>
    public static void glfwSetGammaRamp(nint monitor, GLFWgammaramp* ramp) => _glfwSetGammaRamp(monitor, ramp);
    [QGLNativeAPI("glfwSetGammaRamp")] internal static delegate* unmanaged<nint, GLFWgammaramp*, void> _glfwSetGammaRamp = null;
    
    /// <summary>
    /// Resets all window hints to their default values.<br/>
    /// <br/>
    /// This function resets all window hints to their<br/>
    /// <see cref="window_hints_values">default values</see>.<br/>
    /// </summary>
    public static void glfwDefaultWindowHints() => _glfwDefaultWindowHints();
    [QGLNativeAPI("glfwDefaultWindowHints")] internal static delegate* unmanaged<void> _glfwDefaultWindowHints = null;
    
    /// <summary>
    /// Sets the specified window hint to the desired value.<br/>
    /// <br/>
    /// This function sets hints for the next call to <see cref="glfwCreateWindow"/>.  The<br/>
    /// hints, once set, retain their values until changed by a call to this<br/>
    /// function or <see cref="glfwDefaultWindowHints"/>, or until the library is terminated.<br/>
    /// <br/>
    /// Only integer value hints can be set with this function.  String value hints<br/>
    /// are set with <see cref="glfwWindowHintString"/>.<br/>
    /// <br/>
    /// This function does not check whether the specified hint values are valid.<br/>
    /// If you set hints to invalid values this will instead be reported by the next<br/>
    /// call to <see cref="glfwCreateWindow"/>.<br/>
    /// <br/>
    /// Some hints are platform specific.  These may be set on any platform but they<br/>
    /// will only affect their specific platform.  Other platforms will ignore them.<br/>
    /// Setting these hints requires no platform specific headers or functions.<br/>
    /// </summary>
    /// <param name="hint">The <see cref="window_hints">window hint</see> to set.</param>
    /// <param name="value">The new value of the window hint.</param>
    public static void glfwWindowHint(int hint, int value) => _glfwWindowHint(hint, value);
    [QGLNativeAPI("glfwWindowHint")] internal static delegate* unmanaged<int, int, void> _glfwWindowHint = null;
    
    /// <summary>
    /// Sets the specified window hint to the desired value.<br/>
    /// <br/>
    /// This function sets hints for the next call to <see cref="glfwCreateWindow"/>.  The<br/>
    /// hints, once set, retain their values until changed by a call to this<br/>
    /// function or <see cref="glfwDefaultWindowHints"/>, or until the library is terminated.<br/>
    /// <br/>
    /// Only string type hints can be set with this function.  Integer value hints<br/>
    /// are set with <see cref="glfwWindowHint"/>.<br/>
    /// <br/>
    /// This function does not check whether the specified hint values are valid.<br/>
    /// If you set hints to invalid values this will instead be reported by the next<br/>
    /// call to <see cref="glfwCreateWindow"/>.<br/>
    /// <br/>
    /// Some hints are platform specific.  These may be set on any platform but they<br/>
    /// will only affect their specific platform.  Other platforms will ignore them.<br/>
    /// Setting these hints requires no platform specific headers or functions.<br/>
    /// </summary>
    /// <param name="hint">The <see cref="window_hints">window hint</see> to set.</param>
    /// <param name="value">The new value of the window hint.</param>
    public static void glfwWindowHintString(int hint, byte* value) => _glfwWindowHintString(hint, value);
    [QGLNativeAPI("glfwWindowHintString")] internal static delegate* unmanaged<int, byte*, void> _glfwWindowHintString = null;
    
    /// <summary>
    /// Creates a window and its associated context.<br/>
    /// <br/>
    /// This function creates a window and its associated OpenGL or OpenGL ES<br/>
    /// context.  Most of the options controlling how the window and its context<br/>
    /// should be created are specified with <see cref="window_hints">window hints</see>.<br/>
    /// <br/>
    /// Successful creation does not change which context is current.  Before you<br/>
    /// can use the newly created context, you need to<br/>
    /// <see cref="context_current">make it current</see>.  For information about the `share`<br/>
    /// parameter, see <see cref="context_sharing"/>.<br/>
    /// <br/>
    /// The created window, framebuffer and context may differ from what you<br/>
    /// requested, as not all parameters and hints are<br/>
    /// <see cref="window_hints_hard">hard constraints</see>.  This includes the size of the<br/>
    /// window, especially for full screen windows.  To query the actual attributes<br/>
    /// of the created window, framebuffer and context, see <see cref="glfwGetWindowAttrib"/>, <see cref="glfwGetWindowSize"/> and <see cref="glfwGetFramebufferSize"/>.<br/>
    /// <br/>
    /// To create a full screen window, you need to specify the monitor the window<br/>
    /// will cover.  If no monitor is specified, the window will be windowed mode.<br/>
    /// Unless you have a way for the user to choose a specific monitor, it is<br/>
    /// recommended that you pick the primary monitor.  For more information on how<br/>
    /// to query connected monitors, see <see cref="monitor_monitors"/>.<br/>
    /// <br/>
    /// For full screen windows, the specified size becomes the resolution of the<br/>
    /// window's _desired video mode_.  As long as a full screen window is not<br/>
    /// iconified, the supported video mode most closely matching the desired video<br/>
    /// mode is set for the specified monitor.  For more information about full<br/>
    /// screen windows, including the creation of so called _windowed full screen_<br/>
    /// or _borderless full screen_ windows, see <see cref="window_windowed_full_screen"/>.<br/>
    /// <br/>
    /// Once you have created the window, you can switch it between windowed and<br/>
    /// full screen mode with <see cref="glfwSetWindowMonitor"/>.  This will not affect its<br/>
    /// OpenGL or OpenGL ES context.<br/>
    /// <br/>
    /// By default, newly created windows use the placement recommended by the<br/>
    /// window system.  To create the window at a specific position, set the <see cref="GLFW_POSITION_X"/> and <see cref="GLFW_POSITION_Y"/> window hints before creation.  To<br/>
    /// restore the default behavior, set either or both hints back to<br/>
    /// `GLFW_ANY_POSITION`.<br/>
    /// <br/>
    /// As long as at least one full screen window is not iconified, the screensaver<br/>
    /// is prohibited from starting.<br/>
    /// <br/>
    /// Window systems put limits on window sizes.  Very large or very small window<br/>
    /// dimensions may be overridden by the window system on creation.  Check the<br/>
    /// actual <see cref="window_size">size</see> after creation.<br/>
    /// <br/>
    /// The <see cref="buffer_swap">swap interval</see> is not set during window creation and<br/>
    /// the initial value may vary depending on driver settings and defaults.<br/>
    /// </summary>
    /// <param name="width">The desired width, in screen coordinates, of the window.<br/>This must be greater than zero.</param>
    /// <param name="height">The desired height, in screen coordinates, of the window.<br/>This must be greater than zero.</param>
    /// <param name="title">The initial, UTF-8 encoded window title.</param>
    /// <param name="monitor">The monitor to use for full screen mode, or `NULL` for<br/>windowed mode.</param>
    /// <param name="share">The window whose context to share resources with, or `NULL`<br/>to not share resources.</param>
    public static nint glfwCreateWindow(int width, int height, byte* title, nint monitor, nint share) => _glfwCreateWindow(width, height, title, monitor, share);
    [QGLNativeAPI("glfwCreateWindow")] internal static delegate* unmanaged<int, int, byte*, nint, nint, nint> _glfwCreateWindow = null;
    
    /// <summary>
    /// Destroys the specified window and its context.<br/>
    /// <br/>
    /// This function destroys the specified window and its context.  On calling<br/>
    /// this function, no further callbacks will be called for that window.<br/>
    /// <br/>
    /// If the context of the specified window is current on the main thread, it is<br/>
    /// detached before being destroyed.<br/>
    /// </summary>
    /// <param name="window">The window to destroy.</param>
    public static void glfwDestroyWindow(nint window) => _glfwDestroyWindow(window);
    [QGLNativeAPI("glfwDestroyWindow")] internal static delegate* unmanaged<nint, void> _glfwDestroyWindow = null;
    
    /// <summary>
    /// Checks the close flag of the specified window.<br/>
    /// <br/>
    /// This function returns the value of the close flag of the specified window.<br/>
    /// </summary>
    /// <param name="window">The window to query.</param>
    public static int glfwWindowShouldClose(nint window) => _glfwWindowShouldClose(window);
    [QGLNativeAPI("glfwWindowShouldClose")] internal static delegate* unmanaged<nint, int> _glfwWindowShouldClose = null;
    
    /// <summary>
    /// Sets the close flag of the specified window.<br/>
    /// <br/>
    /// This function sets the value of the close flag of the specified window.<br/>
    /// This can be used to override the user's attempt to close the window, or<br/>
    /// to signal that it should be closed.<br/>
    /// </summary>
    /// <param name="window">The window whose flag to change.</param>
    /// <param name="value">The new value.</param>
    public static void glfwSetWindowShouldClose(nint window, int value) => _glfwSetWindowShouldClose(window, value);
    [QGLNativeAPI("glfwSetWindowShouldClose")] internal static delegate* unmanaged<nint, int, void> _glfwSetWindowShouldClose = null;
    
    /// <summary>
    /// Returns the title of the specified window.<br/>
    /// <br/>
    /// This function returns the window title, encoded as UTF-8, of the specified<br/>
    /// window.  This is the title set previously by <see cref="glfwCreateWindow"/><br/>
    /// or <see cref="glfwSetWindowTitle"/>.<br/>
    /// </summary>
    /// <param name="window">The window to query.</param>
    public static byte* glfwGetWindowTitle(nint window) => _glfwGetWindowTitle(window);
    [QGLNativeAPI("glfwGetWindowTitle")] internal static delegate* unmanaged<nint, byte*> _glfwGetWindowTitle = null;
    
    /// <summary>
    /// Sets the title of the specified window.<br/>
    /// <br/>
    /// This function sets the window title, encoded as UTF-8, of the specified<br/>
    /// window.<br/>
    /// </summary>
    /// <param name="window">The window whose title to change.</param>
    /// <param name="title">The UTF-8 encoded window title.</param>
    public static void glfwSetWindowTitle(nint window, byte* title) => _glfwSetWindowTitle(window, title);
    [QGLNativeAPI("glfwSetWindowTitle")] internal static delegate* unmanaged<nint, byte*, void> _glfwSetWindowTitle = null;
    
    /// <summary>
    /// Sets the icon for the specified window.<br/>
    /// <br/>
    /// This function sets the icon of the specified window.  If passed an array of<br/>
    /// candidate images, those of or closest to the sizes desired by the system are<br/>
    /// selected.  If no images are specified, the window reverts to its default<br/>
    /// icon.<br/>
    /// <br/>
    /// The pixels are 32-bit, little-endian, non-premultiplied RGBA, i.e. eight<br/>
    /// bits per channel with the red channel first.  They are arranged canonically<br/>
    /// as packed sequential rows, starting from the top-left corner.<br/>
    /// <br/>
    /// The desired image sizes varies depending on platform and system settings.<br/>
    /// The selected images will be rescaled as needed.  Good sizes include 16x16,<br/>
    /// 32x32 and 48x48.<br/>
    /// </summary>
    /// <param name="window">The window whose icon to set.</param>
    /// <param name="count">The number of images in the specified array, or zero to<br/>revert to the default window icon.</param>
    /// <param name="images">The images to create the icon from.  This is ignored if<br/>count is zero.</param>
    public static void glfwSetWindowIcon(nint window, int count, GLFWimage* images) => _glfwSetWindowIcon(window, count, images);
    [QGLNativeAPI("glfwSetWindowIcon")] internal static delegate* unmanaged<nint, int, GLFWimage*, void> _glfwSetWindowIcon = null;
    
    /// <summary>
    /// Retrieves the position of the content area of the specified window.<br/>
    /// <br/>
    /// This function retrieves the position, in screen coordinates, of the<br/>
    /// upper-left corner of the content area of the specified window.<br/>
    /// <br/>
    /// Any or all of the position arguments may be `NULL`.  If an error occurs, all<br/>
    /// non-`NULL` position arguments will be set to zero.<br/>
    /// </summary>
    /// <param name="window">The window to query.</param>
    /// <param name="xpos">Where to store the x-coordinate of the upper-left corner of<br/>the content area, or `NULL`.</param>
    /// <param name="ypos">Where to store the y-coordinate of the upper-left corner of<br/>the content area, or `NULL`.</param>
    public static void glfwGetWindowPos(nint window, int* xpos, int* ypos) => _glfwGetWindowPos(window, xpos, ypos);
    [QGLNativeAPI("glfwGetWindowPos")] internal static delegate* unmanaged<nint, int*, int*, void> _glfwGetWindowPos = null;
    
    /// <summary>
    /// Sets the position of the content area of the specified window.<br/>
    /// <br/>
    /// This function sets the position, in screen coordinates, of the upper-left<br/>
    /// corner of the content area of the specified windowed mode window.  If the<br/>
    /// window is a full screen window, this function does nothing.<br/>
    /// <br/>
    /// __Do not use this function__ to move an already visible window unless you<br/>
    /// have very good reasons for doing so, as it will confuse and annoy the user.<br/>
    /// <br/>
    /// The window manager may put limits on what positions are allowed.  GLFW<br/>
    /// cannot and should not override these limits.<br/>
    /// </summary>
    /// <param name="window">The window to query.</param>
    /// <param name="xpos">The x-coordinate of the upper-left corner of the content area.</param>
    /// <param name="ypos">The y-coordinate of the upper-left corner of the content area.</param>
    public static void glfwSetWindowPos(nint window, int xpos, int ypos) => _glfwSetWindowPos(window, xpos, ypos);
    [QGLNativeAPI("glfwSetWindowPos")] internal static delegate* unmanaged<nint, int, int, void> _glfwSetWindowPos = null;
    
    /// <summary>
    /// Retrieves the size of the content area of the specified window.<br/>
    /// <br/>
    /// This function retrieves the size, in screen coordinates, of the content area<br/>
    /// of the specified window.  If you wish to retrieve the size of the<br/>
    /// framebuffer of the window in pixels, see <see cref="glfwGetFramebufferSize"/>.<br/>
    /// <br/>
    /// Any or all of the size arguments may be `NULL`.  If an error occurs, all<br/>
    /// non-`NULL` size arguments will be set to zero.<br/>
    /// </summary>
    /// <param name="window">The window whose size to retrieve.</param>
    /// <param name="width">Where to store the width, in screen coordinates, of the<br/>content area, or `NULL`.</param>
    /// <param name="height">Where to store the height, in screen coordinates, of the<br/>content area, or `NULL`.</param>
    public static void glfwGetWindowSize(nint window, int* width, int* height) => _glfwGetWindowSize(window, width, height);
    [QGLNativeAPI("glfwGetWindowSize")] internal static delegate* unmanaged<nint, int*, int*, void> _glfwGetWindowSize = null;
    
    /// <summary>
    /// Sets the size limits of the specified window.<br/>
    /// <br/>
    /// This function sets the size limits of the content area of the specified<br/>
    /// window.  If the window is full screen, the size limits only take effect<br/>
    /// once it is made windowed.  If the window is not resizable, this function<br/>
    /// does nothing.<br/>
    /// <br/>
    /// The size limits are applied immediately to a windowed mode window and may<br/>
    /// cause it to be resized.<br/>
    /// <br/>
    /// The maximum dimensions must be greater than or equal to the minimum<br/>
    /// dimensions and all must be greater than or equal to zero.<br/>
    /// </summary>
    /// <param name="window">The window to set limits for.</param>
    /// <param name="minwidth">The minimum width, in screen coordinates, of the content<br/>area, or `GLFW_DONT_CARE`.</param>
    /// <param name="minheight">The minimum height, in screen coordinates, of the<br/>content area, or `GLFW_DONT_CARE`.</param>
    /// <param name="maxwidth">The maximum width, in screen coordinates, of the content<br/>area, or `GLFW_DONT_CARE`.</param>
    /// <param name="maxheight">The maximum height, in screen coordinates, of the<br/>content area, or `GLFW_DONT_CARE`.</param>
    public static void glfwSetWindowSizeLimits(nint window, int minwidth, int minheight, int maxwidth, int maxheight) => _glfwSetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);
    [QGLNativeAPI("glfwSetWindowSizeLimits")] internal static delegate* unmanaged<nint, int, int, int, int, void> _glfwSetWindowSizeLimits = null;
    
    /// <summary>
    /// Sets the aspect ratio of the specified window.<br/>
    /// <br/>
    /// This function sets the required aspect ratio of the content area of the<br/>
    /// specified window.  If the window is full screen, the aspect ratio only takes<br/>
    /// effect once it is made windowed.  If the window is not resizable, this<br/>
    /// function does nothing.<br/>
    /// <br/>
    /// The aspect ratio is specified as a numerator and a denominator and both<br/>
    /// values must be greater than zero.  For example, the common 16:9 aspect ratio<br/>
    /// is specified as 16 and 9, respectively.<br/>
    /// <br/>
    /// If the numerator and denominator is set to `GLFW_DONT_CARE` then the aspect<br/>
    /// ratio limit is disabled.<br/>
    /// <br/>
    /// The aspect ratio is applied immediately to a windowed mode window and may<br/>
    /// cause it to be resized.<br/>
    /// </summary>
    /// <param name="window">The window to set limits for.</param>
    /// <param name="numer">The numerator of the desired aspect ratio, or<br/>`GLFW_DONT_CARE`.</param>
    /// <param name="denom">The denominator of the desired aspect ratio, or<br/>`GLFW_DONT_CARE`.</param>
    public static void glfwSetWindowAspectRatio(nint window, int numer, int denom) => _glfwSetWindowAspectRatio(window, numer, denom);
    [QGLNativeAPI("glfwSetWindowAspectRatio")] internal static delegate* unmanaged<nint, int, int, void> _glfwSetWindowAspectRatio = null;
    
    /// <summary>
    /// Sets the size of the content area of the specified window.<br/>
    /// <br/>
    /// This function sets the size, in screen coordinates, of the content area of<br/>
    /// the specified window.<br/>
    /// <br/>
    /// For full screen windows, this function updates the resolution of its desired<br/>
    /// video mode and switches to the video mode closest to it, without affecting<br/>
    /// the window's context.  As the context is unaffected, the bit depths of the<br/>
    /// framebuffer remain unchanged.<br/>
    /// <br/>
    /// If you wish to update the refresh rate of the desired video mode in addition<br/>
    /// to its resolution, see <see cref="glfwSetWindowMonitor"/>.<br/>
    /// <br/>
    /// The window manager may put limits on what sizes are allowed.  GLFW cannot<br/>
    /// and should not override these limits.<br/>
    /// </summary>
    /// <param name="window">The window to resize.</param>
    /// <param name="width">The desired width, in screen coordinates, of the window<br/>content area.</param>
    /// <param name="height">The desired height, in screen coordinates, of the window<br/>content area.</param>
    public static void glfwSetWindowSize(nint window, int width, int height) => _glfwSetWindowSize(window, width, height);
    [QGLNativeAPI("glfwSetWindowSize")] internal static delegate* unmanaged<nint, int, int, void> _glfwSetWindowSize = null;
    
    /// <summary>
    /// Retrieves the size of the framebuffer of the specified window.<br/>
    /// <br/>
    /// This function retrieves the size, in pixels, of the framebuffer of the<br/>
    /// specified window.  If you wish to retrieve the size of the window in screen<br/>
    /// coordinates, see <see cref="glfwGetWindowSize"/>.<br/>
    /// <br/>
    /// Any or all of the size arguments may be `NULL`.  If an error occurs, all<br/>
    /// non-`NULL` size arguments will be set to zero.<br/>
    /// </summary>
    /// <param name="window">The window whose framebuffer to query.</param>
    /// <param name="width">Where to store the width, in pixels, of the framebuffer,<br/>or `NULL`.</param>
    /// <param name="height">Where to store the height, in pixels, of the framebuffer,<br/>or `NULL`.</param>
    public static void glfwGetFramebufferSize(nint window, int* width, int* height) => _glfwGetFramebufferSize(window, width, height);
    [QGLNativeAPI("glfwGetFramebufferSize")] internal static delegate* unmanaged<nint, int*, int*, void> _glfwGetFramebufferSize = null;
    
    /// <summary>
    /// Retrieves the size of the frame of the window.<br/>
    /// <br/>
    /// This function retrieves the size, in screen coordinates, of each edge of the<br/>
    /// frame of the specified window.  This size includes the title bar, if the<br/>
    /// window has one.  The size of the frame may vary depending on the<br/>
    /// [window-related hints](<see cref=""/> window_hints_wnd) used to create it.<br/>
    /// <br/>
    /// Because this function retrieves the size of each window frame edge and not<br/>
    /// the offset along a particular coordinate axis, the retrieved values will<br/>
    /// always be zero or positive.<br/>
    /// <br/>
    /// Any or all of the size arguments may be `NULL`.  If an error occurs, all<br/>
    /// non-`NULL` size arguments will be set to zero.<br/>
    /// </summary>
    /// <param name="window">The window whose frame size to query.</param>
    /// <param name="left">Where to store the size, in screen coordinates, of the left<br/>edge of the window frame, or `NULL`.</param>
    /// <param name="top">Where to store the size, in screen coordinates, of the top<br/>edge of the window frame, or `NULL`.</param>
    /// <param name="right">Where to store the size, in screen coordinates, of the<br/>right edge of the window frame, or `NULL`.</param>
    /// <param name="bottom">Where to store the size, in screen coordinates, of the<br/>bottom edge of the window frame, or `NULL`.</param>
    public static void glfwGetWindowFrameSize(nint window, int* left, int* top, int* right, int* bottom) => _glfwGetWindowFrameSize(window, left, top, right, bottom);
    [QGLNativeAPI("glfwGetWindowFrameSize")] internal static delegate* unmanaged<nint, int*, int*, int*, int*, void> _glfwGetWindowFrameSize = null;
    
    /// <summary>
    /// Retrieves the content scale for the specified window.<br/>
    /// <br/>
    /// This function retrieves the content scale for the specified window.  The<br/>
    /// content scale is the ratio between the current DPI and the platform's<br/>
    /// default DPI.  This is especially important for text and any UI elements.  If<br/>
    /// the pixel dimensions of your UI scaled by this look appropriate on your<br/>
    /// machine then it should appear at a reasonable size on other machines<br/>
    /// regardless of their DPI and scaling settings.  This relies on the system DPI<br/>
    /// and scaling settings being somewhat correct.<br/>
    /// <br/>
    /// On platforms where each monitors can have its own content scale, the window<br/>
    /// content scale will depend on which monitor the system considers the window<br/>
    /// to be on.<br/>
    /// </summary>
    /// <param name="window">The window to query.</param>
    /// <param name="xscale">Where to store the x-axis content scale, or `NULL`.</param>
    /// <param name="yscale">Where to store the y-axis content scale, or `NULL`.</param>
    public static void glfwGetWindowContentScale(nint window, float* xscale, float* yscale) => _glfwGetWindowContentScale(window, xscale, yscale);
    [QGLNativeAPI("glfwGetWindowContentScale")] internal static delegate* unmanaged<nint, float*, float*, void> _glfwGetWindowContentScale = null;
    
    /// <summary>
    /// Returns the opacity of the whole window.<br/>
    /// <br/>
    /// This function returns the opacity of the window, including any decorations.<br/>
    /// <br/>
    /// The opacity (or alpha) value is a positive finite number between zero and<br/>
    /// one, where zero is fully transparent and one is fully opaque.  If the system<br/>
    /// does not support whole window transparency, this function always returns one.<br/>
    /// <br/>
    /// The initial opacity value for newly created windows is one.<br/>
    /// </summary>
    /// <param name="window">The window to query.</param>
    public static float glfwGetWindowOpacity(nint window) => _glfwGetWindowOpacity(window);
    [QGLNativeAPI("glfwGetWindowOpacity")] internal static delegate* unmanaged<nint, float> _glfwGetWindowOpacity = null;
    
    /// <summary>
    /// Sets the opacity of the whole window.<br/>
    /// <br/>
    /// This function sets the opacity of the window, including any decorations.<br/>
    /// <br/>
    /// The opacity (or alpha) value is a positive finite number between zero and<br/>
    /// one, where zero is fully transparent and one is fully opaque.<br/>
    /// <br/>
    /// The initial opacity value for newly created windows is one.<br/>
    /// <br/>
    /// A window created with framebuffer transparency may not use whole window<br/>
    /// transparency.  The results of doing this are undefined.<br/>
    /// </summary>
    /// <param name="window">The window to set the opacity for.</param>
    /// <param name="opacity">The desired opacity of the specified window.</param>
    public static void glfwSetWindowOpacity(nint window, float opacity) => _glfwSetWindowOpacity(window, opacity);
    [QGLNativeAPI("glfwSetWindowOpacity")] internal static delegate* unmanaged<nint, float, void> _glfwSetWindowOpacity = null;
    
    /// <summary>
    /// Iconifies the specified window.<br/>
    /// <br/>
    /// This function iconifies (minimizes) the specified window if it was<br/>
    /// previously restored.  If the window is already iconified, this function does<br/>
    /// nothing.<br/>
    /// <br/>
    /// If the specified window is a full screen window, GLFW restores the original<br/>
    /// video mode of the monitor.  The window's desired video mode is set again<br/>
    /// when the window is restored.<br/>
    /// </summary>
    /// <param name="window">The window to iconify.</param>
    public static void glfwIconifyWindow(nint window) => _glfwIconifyWindow(window);
    [QGLNativeAPI("glfwIconifyWindow")] internal static delegate* unmanaged<nint, void> _glfwIconifyWindow = null;
    
    /// <summary>
    /// Restores the specified window.<br/>
    /// <br/>
    /// This function restores the specified window if it was previously iconified<br/>
    /// (minimized) or maximized.  If the window is already restored, this function<br/>
    /// does nothing.<br/>
    /// <br/>
    /// If the specified window is an iconified full screen window, its desired<br/>
    /// video mode is set again for its monitor when the window is restored.<br/>
    /// </summary>
    /// <param name="window">The window to restore.</param>
    public static void glfwRestoreWindow(nint window) => _glfwRestoreWindow(window);
    [QGLNativeAPI("glfwRestoreWindow")] internal static delegate* unmanaged<nint, void> _glfwRestoreWindow = null;
    
    /// <summary>
    /// Maximizes the specified window.<br/>
    /// <br/>
    /// This function maximizes the specified window if it was previously not<br/>
    /// maximized.  If the window is already maximized, this function does nothing.<br/>
    /// <br/>
    /// If the specified window is a full screen window, this function does nothing.<br/>
    /// </summary>
    /// <param name="window">The window to maximize.</param>
    public static void glfwMaximizeWindow(nint window) => _glfwMaximizeWindow(window);
    [QGLNativeAPI("glfwMaximizeWindow")] internal static delegate* unmanaged<nint, void> _glfwMaximizeWindow = null;
    
    /// <summary>
    /// Makes the specified window visible.<br/>
    /// <br/>
    /// This function makes the specified window visible if it was previously<br/>
    /// hidden.  If the window is already visible or is in full screen mode, this<br/>
    /// function does nothing.<br/>
    /// <br/>
    /// By default, windowed mode windows are focused when shown<br/>
    /// Set the <see cref="GLFW_FOCUS_ON_SHOW_hint">GLFW_FOCUS_ON_SHOW</see> window hint<br/>
    /// to change this behavior for all newly created windows, or change the<br/>
    /// behavior for an existing window with <see cref="glfwSetWindowAttrib"/>.<br/>
    /// </summary>
    /// <param name="window">The window to make visible.</param>
    public static void glfwShowWindow(nint window) => _glfwShowWindow(window);
    [QGLNativeAPI("glfwShowWindow")] internal static delegate* unmanaged<nint, void> _glfwShowWindow = null;
    
    /// <summary>
    /// Hides the specified window.<br/>
    /// <br/>
    /// This function hides the specified window if it was previously visible.  If<br/>
    /// the window is already hidden or is in full screen mode, this function does<br/>
    /// nothing.<br/>
    /// </summary>
    /// <param name="window">The window to hide.</param>
    public static void glfwHideWindow(nint window) => _glfwHideWindow(window);
    [QGLNativeAPI("glfwHideWindow")] internal static delegate* unmanaged<nint, void> _glfwHideWindow = null;
    
    /// <summary>
    /// Brings the specified window to front and sets input focus.<br/>
    /// <br/>
    /// This function brings the specified window to front and sets input focus.<br/>
    /// The window should already be visible and not iconified.<br/>
    /// <br/>
    /// By default, both windowed and full screen mode windows are focused when<br/>
    /// initially created.  Set the <see cref="GLFW_FOCUSED_hint">GLFW_FOCUSED</see> to<br/>
    /// disable this behavior.<br/>
    /// <br/>
    /// Also by default, windowed mode windows are focused when shown<br/>
    /// with <see cref="glfwShowWindow"/>. Set the<br/>
    /// <see cref="GLFW_FOCUS_ON_SHOW_hint">GLFW_FOCUS_ON_SHOW</see> to disable this behavior.<br/>
    /// <br/>
    /// __Do not use this function__ to steal focus from other applications unless<br/>
    /// you are certain that is what the user wants.  Focus stealing can be<br/>
    /// extremely disruptive.<br/>
    /// <br/>
    /// For a less disruptive way of getting the user's attention, see<br/>
    /// <see cref="window_attention">attention requests</see>.<br/>
    /// </summary>
    /// <param name="window">The window to give input focus.</param>
    public static void glfwFocusWindow(nint window) => _glfwFocusWindow(window);
    [QGLNativeAPI("glfwFocusWindow")] internal static delegate* unmanaged<nint, void> _glfwFocusWindow = null;
    
    /// <summary>
    /// Requests user attention to the specified window.<br/>
    /// <br/>
    /// This function requests user attention to the specified window.  On<br/>
    /// platforms where this is not supported, attention is requested to the<br/>
    /// application as a whole.<br/>
    /// <br/>
    /// Once the user has given attention, usually by focusing the window or<br/>
    /// application, the system will end the request automatically.<br/>
    /// </summary>
    /// <param name="window">The window to request attention to.</param>
    public static void glfwRequestWindowAttention(nint window) => _glfwRequestWindowAttention(window);
    [QGLNativeAPI("glfwRequestWindowAttention")] internal static delegate* unmanaged<nint, void> _glfwRequestWindowAttention = null;
    
    /// <summary>
    /// Returns the monitor that the window uses for full screen mode.<br/>
    /// <br/>
    /// This function returns the handle of the monitor that the specified window is<br/>
    /// in full screen on.<br/>
    /// </summary>
    /// <param name="window">The window to query.</param>
    public static nint glfwGetWindowMonitor(nint window) => _glfwGetWindowMonitor(window);
    [QGLNativeAPI("glfwGetWindowMonitor")] internal static delegate* unmanaged<nint, nint> _glfwGetWindowMonitor = null;
    
    /// <summary>
    /// Sets the mode, monitor, video mode and placement of a window.<br/>
    /// <br/>
    /// This function sets the monitor that the window uses for full screen mode or,<br/>
    /// if the monitor is `NULL`, makes it windowed mode.<br/>
    /// <br/>
    /// When setting a monitor, this function updates the width, height and refresh<br/>
    /// rate of the desired video mode and switches to the video mode closest to it.<br/>
    /// The window position is ignored when setting a monitor.<br/>
    /// <br/>
    /// When the monitor is `NULL`, the position, width and height are used to<br/>
    /// place the window content area.  The refresh rate is ignored when no monitor<br/>
    /// is specified.<br/>
    /// <br/>
    /// If you only wish to update the resolution of a full screen window or the<br/>
    /// size of a windowed mode window, see <see cref="glfwSetWindowSize"/>.<br/>
    /// <br/>
    /// When a window transitions from full screen to windowed mode, this function<br/>
    /// restores any previous window settings such as whether it is decorated,<br/>
    /// floating, resizable, has size or aspect ratio limits, etc.<br/>
    /// </summary>
    /// <param name="window">The window whose monitor, size or video mode to set.</param>
    /// <param name="monitor">The desired monitor, or `NULL` to set windowed mode.</param>
    /// <param name="xpos">The desired x-coordinate of the upper-left corner of the<br/>content area.</param>
    /// <param name="ypos">The desired y-coordinate of the upper-left corner of the<br/>content area.</param>
    /// <param name="width">The desired with, in screen coordinates, of the content<br/>area or video mode.</param>
    /// <param name="height">The desired height, in screen coordinates, of the content<br/>area or video mode.</param>
    /// <param name="refreshRate">The desired refresh rate, in Hz, of the video mode,<br/>or `GLFW_DONT_CARE`.</param>
    public static void glfwSetWindowMonitor(nint window, nint monitor, int xpos, int ypos, int width, int height, int refreshRate) => _glfwSetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);
    [QGLNativeAPI("glfwSetWindowMonitor")] internal static delegate* unmanaged<nint, nint, int, int, int, int, int, void> _glfwSetWindowMonitor = null;
    
    /// <summary>
    /// Returns an attribute of the specified window.<br/>
    /// <br/>
    /// This function returns the value of an attribute of the specified window or<br/>
    /// its OpenGL or OpenGL ES context.<br/>
    /// </summary>
    /// <param name="window">The window to query.</param>
    /// <param name="attrib">The <see cref="window_attribs">window attribute</see> whose value to<br/>return.</param>
    public static int glfwGetWindowAttrib(nint window, int attrib) => _glfwGetWindowAttrib(window, attrib);
    [QGLNativeAPI("glfwGetWindowAttrib")] internal static delegate* unmanaged<nint, int, int> _glfwGetWindowAttrib = null;
    
    /// <summary>
    /// Sets an attribute of the specified window.<br/>
    /// <br/>
    /// This function sets the value of an attribute of the specified window.<br/>
    /// <br/>
    /// The supported attributes are <see cref="GLFW_DECORATED_attrib">GLFW_DECORATED</see>,<br/>
    /// <see cref="GLFW_RESIZABLE_attrib">GLFW_RESIZABLE</see>,<br/>
    /// <see cref="GLFW_FLOATING_attrib">GLFW_FLOATING</see>,<br/>
    /// <see cref="GLFW_AUTO_ICONIFY_attrib">GLFW_AUTO_ICONIFY</see> and<br/>
    /// <see cref="GLFW_FOCUS_ON_SHOW_attrib">GLFW_FOCUS_ON_SHOW</see>.<br/>
    /// <see cref="GLFW_MOUSE_PASSTHROUGH_attrib">GLFW_MOUSE_PASSTHROUGH</see><br/>
    /// <br/>
    /// Some of these attributes are ignored for full screen windows.  The new<br/>
    /// value will take effect if the window is later made windowed.<br/>
    /// <br/>
    /// Some of these attributes are ignored for windowed mode windows.  The new<br/>
    /// value will take effect if the window is later made full screen.<br/>
    /// </summary>
    /// <param name="window">The window to set the attribute for.</param>
    /// <param name="attrib">A supported window attribute.</param>
    /// <param name="value">`GLFW_TRUE` or `GLFW_FALSE`.</param>
    public static void glfwSetWindowAttrib(nint window, int attrib, int value) => _glfwSetWindowAttrib(window, attrib, value);
    [QGLNativeAPI("glfwSetWindowAttrib")] internal static delegate* unmanaged<nint, int, int, void> _glfwSetWindowAttrib = null;
    
    /// <summary>
    /// Sets the user pointer of the specified window.<br/>
    /// <br/>
    /// This function sets the user-defined pointer of the specified window.  The<br/>
    /// current value is retained until the window is destroyed.  The initial value<br/>
    /// is `NULL`.<br/>
    /// </summary>
    /// <param name="window">The window whose pointer to set.</param>
    /// <param name="pointer">The new value.</param>
    public static void glfwSetWindowUserPointer(nint window, void* pointer) => _glfwSetWindowUserPointer(window, pointer);
    [QGLNativeAPI("glfwSetWindowUserPointer")] internal static delegate* unmanaged<nint, void*, void> _glfwSetWindowUserPointer = null;
    
    /// <summary>
    /// Returns the user pointer of the specified window.<br/>
    /// <br/>
    /// This function returns the current value of the user-defined pointer of the<br/>
    /// specified window.  The initial value is `NULL`.<br/>
    /// </summary>
    /// <param name="window">The window whose pointer to return.</param>
    public static void* glfwGetWindowUserPointer(nint window) => _glfwGetWindowUserPointer(window);
    [QGLNativeAPI("glfwGetWindowUserPointer")] internal static delegate* unmanaged<nint, void*> _glfwGetWindowUserPointer = null;
    
    /// <summary>
    /// Sets the position callback for the specified window.<br/>
    /// <br/>
    /// This function sets the position callback of the specified window, which is<br/>
    /// called when the window is moved.  The callback is provided with the<br/>
    /// position, in screen coordinates, of the upper-left corner of the content<br/>
    /// area of the window.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetWindowPosCallback(nint window, GLFWwindowposfun callback) => _glfwSetWindowPosCallback(window, callback);
    [QGLNativeAPI("glfwSetWindowPosCallback")] internal static delegate* unmanaged<nint, GLFWwindowposfun, nint> _glfwSetWindowPosCallback = null;
    
    /// <summary>
    /// Sets the size callback for the specified window.<br/>
    /// <br/>
    /// This function sets the size callback of the specified window, which is<br/>
    /// called when the window is resized.  The callback is provided with the size,<br/>
    /// in screen coordinates, of the content area of the window.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetWindowSizeCallback(nint window, GLFWwindowsizefun callback) => _glfwSetWindowSizeCallback(window, callback);
    [QGLNativeAPI("glfwSetWindowSizeCallback")] internal static delegate* unmanaged<nint, GLFWwindowsizefun, nint> _glfwSetWindowSizeCallback = null;
    
    /// <summary>
    /// Sets the close callback for the specified window.<br/>
    /// <br/>
    /// This function sets the close callback of the specified window, which is<br/>
    /// called when the user attempts to close the window, for example by clicking<br/>
    /// the close widget in the title bar.<br/>
    /// <br/>
    /// The close flag is set before this callback is called, but you can modify it<br/>
    /// at any time with <see cref="glfwSetWindowShouldClose"/>.<br/>
    /// <br/>
    /// The close callback is not triggered by <see cref="glfwDestroyWindow"/>.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetWindowCloseCallback(nint window, GLFWwindowclosefun callback) => _glfwSetWindowCloseCallback(window, callback);
    [QGLNativeAPI("glfwSetWindowCloseCallback")] internal static delegate* unmanaged<nint, GLFWwindowclosefun, nint> _glfwSetWindowCloseCallback = null;
    
    /// <summary>
    /// Sets the refresh callback for the specified window.<br/>
    /// <br/>
    /// This function sets the refresh callback of the specified window, which is<br/>
    /// called when the content area of the window needs to be redrawn, for example<br/>
    /// if the window has been exposed after having been covered by another window.<br/>
    /// <br/>
    /// On compositing window systems such as Aero, Compiz, Aqua or Wayland, where<br/>
    /// the window contents are saved off-screen, this callback may be called only<br/>
    /// very infrequently or never at all.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetWindowRefreshCallback(nint window, GLFWwindowrefreshfun callback) => _glfwSetWindowRefreshCallback(window, callback);
    [QGLNativeAPI("glfwSetWindowRefreshCallback")] internal static delegate* unmanaged<nint, GLFWwindowrefreshfun, nint> _glfwSetWindowRefreshCallback = null;
    
    /// <summary>
    /// Sets the focus callback for the specified window.<br/>
    /// <br/>
    /// This function sets the focus callback of the specified window, which is<br/>
    /// called when the window gains or loses input focus.<br/>
    /// <br/>
    /// After the focus callback is called for a window that lost input focus,<br/>
    /// synthetic key and mouse button release events will be generated for all such<br/>
    /// that had been pressed.  For more information, see <see cref="glfwSetKeyCallback"/><br/>
    /// and <see cref="glfwSetMouseButtonCallback"/>.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetWindowFocusCallback(nint window, GLFWwindowfocusfun callback) => _glfwSetWindowFocusCallback(window, callback);
    [QGLNativeAPI("glfwSetWindowFocusCallback")] internal static delegate* unmanaged<nint, GLFWwindowfocusfun, nint> _glfwSetWindowFocusCallback = null;
    
    /// <summary>
    /// Sets the iconify callback for the specified window.<br/>
    /// <br/>
    /// This function sets the iconification callback of the specified window, which<br/>
    /// is called when the window is iconified or restored.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetWindowIconifyCallback(nint window, GLFWwindowiconifyfun callback) => _glfwSetWindowIconifyCallback(window, callback);
    [QGLNativeAPI("glfwSetWindowIconifyCallback")] internal static delegate* unmanaged<nint, GLFWwindowiconifyfun, nint> _glfwSetWindowIconifyCallback = null;
    
    /// <summary>
    /// Sets the maximize callback for the specified window.<br/>
    /// <br/>
    /// This function sets the maximization callback of the specified window, which<br/>
    /// is called when the window is maximized or restored.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetWindowMaximizeCallback(nint window, GLFWwindowmaximizefun callback) => _glfwSetWindowMaximizeCallback(window, callback);
    [QGLNativeAPI("glfwSetWindowMaximizeCallback")] internal static delegate* unmanaged<nint, GLFWwindowmaximizefun, nint> _glfwSetWindowMaximizeCallback = null;
    
    /// <summary>
    /// Sets the framebuffer resize callback for the specified window.<br/>
    /// <br/>
    /// This function sets the framebuffer resize callback of the specified window,<br/>
    /// which is called when the framebuffer of the specified window is resized.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetFramebufferSizeCallback(nint window, GLFWframebuffersizefun callback) => _glfwSetFramebufferSizeCallback(window, callback);
    [QGLNativeAPI("glfwSetFramebufferSizeCallback")] internal static delegate* unmanaged<nint, GLFWframebuffersizefun, nint> _glfwSetFramebufferSizeCallback = null;
    
    /// <summary>
    /// Sets the window content scale callback for the specified window.<br/>
    /// <br/>
    /// This function sets the window content scale callback of the specified window,<br/>
    /// which is called when the content scale of the specified window changes.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetWindowContentScaleCallback(nint window, GLFWwindowcontentscalefun callback) => _glfwSetWindowContentScaleCallback(window, callback);
    [QGLNativeAPI("glfwSetWindowContentScaleCallback")] internal static delegate* unmanaged<nint, GLFWwindowcontentscalefun, nint> _glfwSetWindowContentScaleCallback = null;
    
    /// <summary>
    /// Processes all pending events.<br/>
    /// <br/>
    /// This function processes only those events that are already in the event<br/>
    /// queue and then returns immediately.  Processing events will cause the window<br/>
    /// and input callbacks associated with those events to be called.<br/>
    /// <br/>
    /// On some platforms, a window move, resize or menu operation will cause event<br/>
    /// processing to block.  This is due to how event processing is designed on<br/>
    /// those platforms.  You can use the<br/>
    /// <see cref="window_refresh">window refresh callback</see> to redraw the contents of<br/>
    /// your window when necessary during such operations.<br/>
    /// <br/>
    /// Do not assume that callbacks you set will _only_ be called in response to<br/>
    /// event processing functions like this one.  While it is necessary to poll for<br/>
    /// events, window systems that require GLFW to register callbacks of its own<br/>
    /// can pass events to GLFW in response to many window system function calls.<br/>
    /// GLFW will pass those events on to the application callbacks before<br/>
    /// returning.<br/>
    /// <br/>
    /// Event processing is not required for joystick input to work.<br/>
    /// </summary>
    public static void glfwPollEvents() => _glfwPollEvents();
    [QGLNativeAPI("glfwPollEvents")] internal static delegate* unmanaged<void> _glfwPollEvents = null;
    
    /// <summary>
    /// Waits until events are queued and processes them.<br/>
    /// <br/>
    /// This function puts the calling thread to sleep until at least one event is<br/>
    /// available in the event queue.  Once one or more events are available,<br/>
    /// it behaves exactly like <see cref="glfwPollEvents"/>, i.e. the events in the queue<br/>
    /// are processed and the function then returns immediately.  Processing events<br/>
    /// will cause the window and input callbacks associated with those events to be<br/>
    /// called.<br/>
    /// <br/>
    /// Since not all events are associated with callbacks, this function may return<br/>
    /// without a callback having been called even if you are monitoring all<br/>
    /// callbacks.<br/>
    /// <br/>
    /// On some platforms, a window move, resize or menu operation will cause event<br/>
    /// processing to block.  This is due to how event processing is designed on<br/>
    /// those platforms.  You can use the<br/>
    /// <see cref="window_refresh">window refresh callback</see> to redraw the contents of<br/>
    /// your window when necessary during such operations.<br/>
    /// <br/>
    /// Do not assume that callbacks you set will _only_ be called in response to<br/>
    /// event processing functions like this one.  While it is necessary to poll for<br/>
    /// events, window systems that require GLFW to register callbacks of its own<br/>
    /// can pass events to GLFW in response to many window system function calls.<br/>
    /// GLFW will pass those events on to the application callbacks before<br/>
    /// returning.<br/>
    /// <br/>
    /// Event processing is not required for joystick input to work.<br/>
    /// </summary>
    public static void glfwWaitEvents() => _glfwWaitEvents();
    [QGLNativeAPI("glfwWaitEvents")] internal static delegate* unmanaged<void> _glfwWaitEvents = null;
    
    /// <summary>
    /// Waits with timeout until events are queued and processes them.<br/>
    /// <br/>
    /// This function puts the calling thread to sleep until at least one event is<br/>
    /// available in the event queue, or until the specified timeout is reached.  If<br/>
    /// one or more events are available, it behaves exactly like <see cref="glfwPollEvents"/>, i.e. the events in the queue are processed and the function<br/>
    /// then returns immediately.  Processing events will cause the window and input<br/>
    /// callbacks associated with those events to be called.<br/>
    /// <br/>
    /// The timeout value must be a positive finite number.<br/>
    /// <br/>
    /// Since not all events are associated with callbacks, this function may return<br/>
    /// without a callback having been called even if you are monitoring all<br/>
    /// callbacks.<br/>
    /// <br/>
    /// On some platforms, a window move, resize or menu operation will cause event<br/>
    /// processing to block.  This is due to how event processing is designed on<br/>
    /// those platforms.  You can use the<br/>
    /// <see cref="window_refresh">window refresh callback</see> to redraw the contents of<br/>
    /// your window when necessary during such operations.<br/>
    /// <br/>
    /// Do not assume that callbacks you set will _only_ be called in response to<br/>
    /// event processing functions like this one.  While it is necessary to poll for<br/>
    /// events, window systems that require GLFW to register callbacks of its own<br/>
    /// can pass events to GLFW in response to many window system function calls.<br/>
    /// GLFW will pass those events on to the application callbacks before<br/>
    /// returning.<br/>
    /// <br/>
    /// Event processing is not required for joystick input to work.<br/>
    /// </summary>
    /// <param name="timeout">The maximum amount of time, in seconds, to wait.</param>
    public static void glfwWaitEventsTimeout(double timeout) => _glfwWaitEventsTimeout(timeout);
    [QGLNativeAPI("glfwWaitEventsTimeout")] internal static delegate* unmanaged<double, void> _glfwWaitEventsTimeout = null;
    
    /// <summary>
    /// Posts an empty event to the event queue.<br/>
    /// <br/>
    /// This function posts an empty event from the current thread to the event<br/>
    /// queue, causing <see cref="glfwWaitEvents"/> or <see cref="glfwWaitEventsTimeout"/> to return.<br/>
    /// </summary>
    public static void glfwPostEmptyEvent() => _glfwPostEmptyEvent();
    [QGLNativeAPI("glfwPostEmptyEvent")] internal static delegate* unmanaged<void> _glfwPostEmptyEvent = null;
    
    /// <summary>
    /// Returns the value of an input option for the specified window.<br/>
    /// <br/>
    /// This function returns the value of an input option for the specified window.<br/>
    /// The mode must be one of <see cref="GLFW_CURSOR"/>, <see cref="GLFW_STICKY_KEYS"/>,<br/>
    /// <see cref="GLFW_STICKY_MOUSE_BUTTONS"/>, <see cref="GLFW_LOCK_KEY_MODS"/> or<br/>
    /// <see cref="GLFW_RAW_MOUSE_MOTION"/>.<br/>
    /// </summary>
    /// <param name="window">The window to query.</param>
    /// <param name="mode">One of `GLFW_CURSOR`, `GLFW_STICKY_KEYS`,<br/>`GLFW_STICKY_MOUSE_BUTTONS`, `GLFW_LOCK_KEY_MODS` or<br/>`GLFW_RAW_MOUSE_MOTION`.</param>
    public static int glfwGetInputMode(nint window, int mode) => _glfwGetInputMode(window, mode);
    [QGLNativeAPI("glfwGetInputMode")] internal static delegate* unmanaged<nint, int, int> _glfwGetInputMode = null;
    
    /// <summary>
    /// Sets an input option for the specified window.<br/>
    /// <br/>
    /// This function sets an input mode option for the specified window.  The mode<br/>
    /// must be one of <see cref="GLFW_CURSOR"/>, <see cref="GLFW_STICKY_KEYS"/>,<br/>
    /// <see cref="GLFW_STICKY_MOUSE_BUTTONS"/>, <see cref="GLFW_LOCK_KEY_MODS"/><br/>
    /// <see cref="GLFW_RAW_MOUSE_MOTION"/>, or <see cref="GLFW_UNLIMITED_MOUSE_BUTTONS"/>.<br/>
    /// <br/>
    /// If the mode is `GLFW_CURSOR`, the value must be one of the following cursor<br/>
    /// modes:<br/>
    /// - `GLFW_CURSOR_NORMAL` makes the cursor visible and behaving normally.<br/>
    /// - `GLFW_CURSOR_HIDDEN` makes the cursor invisible when it is over the<br/>
    /// content area of the window but does not restrict the cursor from leaving.<br/>
    /// - `GLFW_CURSOR_DISABLED` hides and grabs the cursor, providing virtual<br/>
    /// and unlimited cursor movement.  This is useful for implementing for<br/>
    /// example 3D camera controls.<br/>
    /// - `GLFW_CURSOR_CAPTURED` makes the cursor visible and confines it to the<br/>
    /// content area of the window.<br/>
    /// <br/>
    /// If the mode is `GLFW_STICKY_KEYS`, the value must be either `GLFW_TRUE` to<br/>
    /// enable sticky keys, or `GLFW_FALSE` to disable it.  If sticky keys are<br/>
    /// enabled, a key press will ensure that <see cref="glfwGetKey"/> returns `GLFW_PRESS`<br/>
    /// the next time it is called even if the key had been released before the<br/>
    /// call.  This is useful when you are only interested in whether keys have been<br/>
    /// pressed but not when or in which order.<br/>
    /// <br/>
    /// If the mode is `GLFW_STICKY_MOUSE_BUTTONS`, the value must be either<br/>
    /// `GLFW_TRUE` to enable sticky mouse buttons, or `GLFW_FALSE` to disable it.<br/>
    /// If sticky mouse buttons are enabled, a mouse button press will ensure that<br/>
    /// <see cref="glfwGetMouseButton"/> returns `GLFW_PRESS` the next time it is called even<br/>
    /// if the mouse button had been released before the call.  This is useful when<br/>
    /// you are only interested in whether mouse buttons have been pressed but not<br/>
    /// when or in which order.<br/>
    /// <br/>
    /// If the mode is `GLFW_LOCK_KEY_MODS`, the value must be either `GLFW_TRUE` to<br/>
    /// enable lock key modifier bits, or `GLFW_FALSE` to disable them.  If enabled,<br/>
    /// callbacks that receive modifier bits will also have the <see cref="GLFW_MOD_CAPS_LOCK"/> bit set when the event was generated with Caps Lock on,<br/>
    /// and the <see cref="GLFW_MOD_NUM_LOCK"/> bit when Num Lock was on.<br/>
    /// <br/>
    /// If the mode is `GLFW_RAW_MOUSE_MOTION`, the value must be either `GLFW_TRUE`<br/>
    /// to enable raw (unscaled and unaccelerated) mouse motion when the cursor is<br/>
    /// disabled, or `GLFW_FALSE` to disable it.  If raw motion is not supported,<br/>
    /// attempting to set this will emit <see cref="GLFW_FEATURE_UNAVAILABLE"/>.  Call <see cref="glfwRawMouseMotionSupported"/> to check for support.<br/>
    /// <br/>
    /// If the mode is `GLFW_UNLIMITED_MOUSE_BUTTONS`, the value must be either<br/>
    /// `GLFW_TRUE` to disable the mouse button limit when calling the mouse button<br/>
    /// callback, or `GLFW_FALSE` to limit the mouse buttons sent to the callback<br/>
    /// to the mouse button token values up to `GLFW_MOUSE_BUTTON_LAST`.<br/>
    /// </summary>
    /// <param name="window">The window whose input mode to set.</param>
    /// <param name="mode">One of `GLFW_CURSOR`, `GLFW_STICKY_KEYS`,<br/>`GLFW_STICKY_MOUSE_BUTTONS`, `GLFW_LOCK_KEY_MODS` or<br/>`GLFW_RAW_MOUSE_MOTION`.</param>
    /// <param name="value">The new value of the specified input mode.</param>
    public static void glfwSetInputMode(nint window, int mode, int value) => _glfwSetInputMode(window, mode, value);
    [QGLNativeAPI("glfwSetInputMode")] internal static delegate* unmanaged<nint, int, int, void> _glfwSetInputMode = null;
    
    /// <summary>
    /// Returns whether raw mouse motion is supported.<br/>
    /// <br/>
    /// This function returns whether raw mouse motion is supported on the current<br/>
    /// system.  This status does not change after GLFW has been initialized so you<br/>
    /// only need to check this once.  If you attempt to enable raw motion on<br/>
    /// a system that does not support it, <see cref="GLFW_PLATFORM_ERROR"/> will be emitted.<br/>
    /// <br/>
    /// Raw mouse motion is closer to the actual motion of the mouse across<br/>
    /// a surface.  It is not affected by the scaling and acceleration applied to<br/>
    /// the motion of the desktop cursor.  That processing is suitable for a cursor<br/>
    /// while raw motion is better for controlling for example a 3D camera.  Because<br/>
    /// of this, raw mouse motion is only provided when the cursor is disabled.<br/>
    /// </summary>
    public static int glfwRawMouseMotionSupported() => _glfwRawMouseMotionSupported();
    [QGLNativeAPI("glfwRawMouseMotionSupported")] internal static delegate* unmanaged<int> _glfwRawMouseMotionSupported = null;
    
    /// <summary>
    /// Returns the layout-specific name of the specified printable key.<br/>
    /// <br/>
    /// This function returns the name of the specified printable key, encoded as<br/>
    /// UTF-8.  This is typically the character that key would produce without any<br/>
    /// modifier keys, intended for displaying key bindings to the user.  For dead<br/>
    /// keys, it is typically the diacritic it would add to a character.<br/>
    /// <br/>
    /// __Do not use this function__ for <see cref="input_char">text input</see>.  You will<br/>
    /// break text input for many languages even if it happens to work for yours.<br/>
    /// <br/>
    /// If the key is `GLFW_KEY_UNKNOWN`, the scancode is used to identify the key,<br/>
    /// otherwise the scancode is ignored.  If you specify a non-printable key, or<br/>
    /// `GLFW_KEY_UNKNOWN` and a scancode that maps to a non-printable key, this<br/>
    /// function returns `NULL` but does not emit an error.<br/>
    /// <br/>
    /// This behavior allows you to always pass in the arguments in the<br/>
    /// <see cref="input_key">key callback</see> without modification.<br/>
    /// <br/>
    /// The printable keys are:<br/>
    /// - `GLFW_KEY_APOSTROPHE`<br/>
    /// - `GLFW_KEY_COMMA`<br/>
    /// - `GLFW_KEY_MINUS`<br/>
    /// - `GLFW_KEY_PERIOD`<br/>
    /// - `GLFW_KEY_SLASH`<br/>
    /// - `GLFW_KEY_SEMICOLON`<br/>
    /// - `GLFW_KEY_EQUAL`<br/>
    /// - `GLFW_KEY_LEFT_BRACKET`<br/>
    /// - `GLFW_KEY_RIGHT_BRACKET`<br/>
    /// - `GLFW_KEY_BACKSLASH`<br/>
    /// - `GLFW_KEY_WORLD_1`<br/>
    /// - `GLFW_KEY_WORLD_2`<br/>
    /// - `GLFW_KEY_0` to `GLFW_KEY_9`<br/>
    /// - `GLFW_KEY_A` to `GLFW_KEY_Z`<br/>
    /// - `GLFW_KEY_KP_0` to `GLFW_KEY_KP_9`<br/>
    /// - `GLFW_KEY_KP_DECIMAL`<br/>
    /// - `GLFW_KEY_KP_DIVIDE`<br/>
    /// - `GLFW_KEY_KP_MULTIPLY`<br/>
    /// - `GLFW_KEY_KP_SUBTRACT`<br/>
    /// - `GLFW_KEY_KP_ADD`<br/>
    /// - `GLFW_KEY_KP_EQUAL`<br/>
    /// <br/>
    /// Names for printable keys depend on keyboard layout, while names for<br/>
    /// non-printable keys are the same across layouts but depend on the application<br/>
    /// language and should be localized along with other user interface text.<br/>
    /// </summary>
    /// <param name="key">The key to query, or `GLFW_KEY_UNKNOWN`.</param>
    /// <param name="scancode">The scancode of the key to query.</param>
    public static byte* glfwGetKeyName(int key, int scancode) => _glfwGetKeyName(key, scancode);
    [QGLNativeAPI("glfwGetKeyName")] internal static delegate* unmanaged<int, int, byte*> _glfwGetKeyName = null;
    
    /// <summary>
    /// Returns the platform-specific scancode of the specified key.<br/>
    /// <br/>
    /// This function returns the platform-specific scancode of the specified key.<br/>
    /// <br/>
    /// If the specified <see cref="keys">key token</see> corresponds to a physical key not<br/>
    /// supported on the current platform then this method will return `-1`.<br/>
    /// Calling this function with anything other than a key token will return `-1`<br/>
    /// and generate a <see cref="GLFW_INVALID_ENUM"/> error.<br/>
    /// </summary>
    /// <param name="key">Any <see cref="keys">key token</see>.</param>
    public static int glfwGetKeyScancode(int key) => _glfwGetKeyScancode(key);
    [QGLNativeAPI("glfwGetKeyScancode")] internal static delegate* unmanaged<int, int> _glfwGetKeyScancode = null;
    
    /// <summary>
    /// Returns the last reported state of a keyboard key for the specified<br/>
    /// window.<br/>
    /// <br/>
    /// This function returns the last state reported for the specified key to the<br/>
    /// specified window.  The returned state is one of `GLFW_PRESS` or<br/>
    /// `GLFW_RELEASE`.  The action `GLFW_REPEAT` is only reported to the key callback.<br/>
    /// <br/>
    /// If the <see cref="GLFW_STICKY_KEYS"/> input mode is enabled, this function returns<br/>
    /// `GLFW_PRESS` the first time you call it for a key that was pressed, even if<br/>
    /// that key has already been released.<br/>
    /// <br/>
    /// The key functions deal with physical keys, with <see cref="keys">key tokens</see><br/>
    /// named after their use on the standard US keyboard layout.  If you want to<br/>
    /// input text, use the Unicode character callback instead.<br/>
    /// <br/>
    /// The <see cref="mods">modifier key bit masks</see> are not key tokens and cannot be<br/>
    /// used with this function.<br/>
    /// <br/>
    /// __Do not use this function__ to implement <see cref="input_char">text input</see>.<br/>
    /// </summary>
    /// <param name="window">The desired window.</param>
    /// <param name="key">The desired <see cref="keys">keyboard key</see>.  `GLFW_KEY_UNKNOWN` is<br/>not a valid key for this function.</param>
    public static int glfwGetKey(nint window, int key) => _glfwGetKey(window, key);
    [QGLNativeAPI("glfwGetKey")] internal static delegate* unmanaged<nint, int, int> _glfwGetKey = null;
    
    /// <summary>
    /// Returns the last reported state of a mouse button for the specified<br/>
    /// window.<br/>
    /// <br/>
    /// This function returns the last state reported for the specified mouse button<br/>
    /// to the specified window.  The returned state is one of `GLFW_PRESS` or<br/>
    /// `GLFW_RELEASE`.<br/>
    /// <br/>
    /// If the <see cref="GLFW_STICKY_MOUSE_BUTTONS"/> input mode is enabled, this function<br/>
    /// returns `GLFW_PRESS` the first time you call it for a mouse button that was<br/>
    /// pressed, even if that mouse button has already been released.<br/>
    /// <br/>
    /// The <see cref="GLFW_UNLIMITED_MOUSE_BUTTONS"/> input mode does not effect the<br/>
    /// limit on buttons which can be polled with this function.<br/>
    /// </summary>
    /// <param name="window">The desired window.</param>
    /// <param name="button">The desired <see cref="buttons">mouse button token</see>.</param>
    public static int glfwGetMouseButton(nint window, int button) => _glfwGetMouseButton(window, button);
    [QGLNativeAPI("glfwGetMouseButton")] internal static delegate* unmanaged<nint, int, int> _glfwGetMouseButton = null;
    
    /// <summary>
    /// Retrieves the position of the cursor relative to the content area of<br/>
    /// the window.<br/>
    /// <br/>
    /// This function returns the position of the cursor, in screen coordinates,<br/>
    /// relative to the upper-left corner of the content area of the specified<br/>
    /// window.<br/>
    /// <br/>
    /// If the cursor is disabled (with `GLFW_CURSOR_DISABLED`) then the cursor<br/>
    /// position is unbounded and limited only by the minimum and maximum values of<br/>
    /// a `double`.<br/>
    /// <br/>
    /// The coordinate can be converted to their integer equivalents with the<br/>
    /// `floor` function.  Casting directly to an integer type works for positive<br/>
    /// coordinates, but fails for negative ones.<br/>
    /// <br/>
    /// Any or all of the position arguments may be `NULL`.  If an error occurs, all<br/>
    /// non-`NULL` position arguments will be set to zero.<br/>
    /// </summary>
    /// <param name="window">The desired window.</param>
    /// <param name="xpos">Where to store the cursor x-coordinate, relative to the<br/>left edge of the content area, or `NULL`.</param>
    /// <param name="ypos">Where to store the cursor y-coordinate, relative to the to<br/>top edge of the content area, or `NULL`.</param>
    public static void glfwGetCursorPos(nint window, double* xpos, double* ypos) => _glfwGetCursorPos(window, xpos, ypos);
    [QGLNativeAPI("glfwGetCursorPos")] internal static delegate* unmanaged<nint, double*, double*, void> _glfwGetCursorPos = null;
    
    /// <summary>
    /// Sets the position of the cursor, relative to the content area of the<br/>
    /// window.<br/>
    /// <br/>
    /// This function sets the position, in screen coordinates, of the cursor<br/>
    /// relative to the upper-left corner of the content area of the specified<br/>
    /// window.  The window must have input focus.  If the window does not have<br/>
    /// input focus when this function is called, it fails silently.<br/>
    /// <br/>
    /// __Do not use this function__ to implement things like camera controls.  GLFW<br/>
    /// already provides the `GLFW_CURSOR_DISABLED` cursor mode that hides the<br/>
    /// cursor, transparently re-centers it and provides unconstrained cursor<br/>
    /// motion.  See <see cref="glfwSetInputMode"/> for more information.<br/>
    /// <br/>
    /// If the cursor mode is `GLFW_CURSOR_DISABLED` then the cursor position is<br/>
    /// unconstrained and limited only by the minimum and maximum values of<br/>
    /// a `double`.<br/>
    /// </summary>
    /// <param name="window">The desired window.</param>
    /// <param name="xpos">The desired x-coordinate, relative to the left edge of the<br/>content area.</param>
    /// <param name="ypos">The desired y-coordinate, relative to the top edge of the<br/>content area.</param>
    public static void glfwSetCursorPos(nint window, double xpos, double ypos) => _glfwSetCursorPos(window, xpos, ypos);
    [QGLNativeAPI("glfwSetCursorPos")] internal static delegate* unmanaged<nint, double, double, void> _glfwSetCursorPos = null;
    
    /// <summary>
    /// Creates a custom cursor.<br/>
    /// <br/>
    /// Creates a new custom cursor image that can be set for a window with <see cref="glfwSetCursor"/>.  The cursor can be destroyed with <see cref="glfwDestroyCursor"/>.<br/>
    /// Any remaining cursors are destroyed by <see cref="glfwTerminate"/>.<br/>
    /// <br/>
    /// The pixels are 32-bit, little-endian, non-premultiplied RGBA, i.e. eight<br/>
    /// bits per channel with the red channel first.  They are arranged canonically<br/>
    /// as packed sequential rows, starting from the top-left corner.<br/>
    /// <br/>
    /// The cursor hotspot is specified in pixels, relative to the upper-left corner<br/>
    /// of the cursor image.  Like all other coordinate systems in GLFW, the X-axis<br/>
    /// points to the right and the Y-axis points down.<br/>
    /// </summary>
    /// <param name="image">The desired cursor image.</param>
    /// <param name="xhot">The desired x-coordinate, in pixels, of the cursor hotspot.</param>
    /// <param name="yhot">The desired y-coordinate, in pixels, of the cursor hotspot.</param>
    public static nint glfwCreateCursor(GLFWimage* image, int xhot, int yhot) => _glfwCreateCursor(image, xhot, yhot);
    [QGLNativeAPI("glfwCreateCursor")] internal static delegate* unmanaged<GLFWimage*, int, int, nint> _glfwCreateCursor = null;
    
    /// <summary>
    /// Creates a cursor with a standard shape.<br/>
    /// <br/>
    /// Returns a cursor with a standard shape, that can be set for a window with<br/>
    /// <see cref="glfwSetCursor"/>.  The images for these cursors come from the system<br/>
    /// cursor theme and their exact appearance will vary between platforms.<br/>
    /// <br/>
    /// Most of these shapes are guaranteed to exist on every supported platform but<br/>
    /// a few may not be present.  See the table below for details.<br/>
    /// <br/>
    /// Cursor shape                   | Windows | macOS | X11    | Wayland<br/>
    /// ------------------------------ | ------- | ----- | ------ | -------<br/>
    /// <see cref="GLFW_ARROW_CURSOR"/>         | Yes     | Yes   | Yes    | Yes<br/>
    /// <see cref="GLFW_IBEAM_CURSOR"/>         | Yes     | Yes   | Yes    | Yes<br/>
    /// <see cref="GLFW_CROSSHAIR_CURSOR"/>     | Yes     | Yes   | Yes    | Yes<br/>
    /// <see cref="GLFW_POINTING_HAND_CURSOR"/> | Yes     | Yes   | Yes    | Yes<br/>
    /// <see cref="GLFW_RESIZE_EW_CURSOR"/>     | Yes     | Yes   | Yes    | Yes<br/>
    /// <see cref="GLFW_RESIZE_NS_CURSOR"/>     | Yes     | Yes   | Yes    | Yes<br/>
    /// <see cref="GLFW_RESIZE_NWSE_CURSOR"/>   | Yes     | Yes<sup>1</sup> | Maybe<sup>2</sup> | Maybe<sup>2</sup><br/>
    /// <see cref="GLFW_RESIZE_NESW_CURSOR"/>   | Yes     | Yes<sup>1</sup> | Maybe<sup>2</sup> | Maybe<sup>2</sup><br/>
    /// <see cref="GLFW_RESIZE_ALL_CURSOR"/>    | Yes     | Yes   | Yes    | Yes<br/>
    /// <see cref="GLFW_NOT_ALLOWED_CURSOR"/>   | Yes     | Yes   | Maybe<sup>2</sup> | Maybe<sup>2</sup><br/>
    /// <br/>
    /// 1) This uses a private system API and may fail in the future.<br/>
    /// <br/>
    /// 2) This uses a newer standard that not all cursor themes support.<br/>
    /// <br/>
    /// If the requested shape is not available, this function emits a <see cref="GLFW_CURSOR_UNAVAILABLE"/> error and returns `NULL`.<br/>
    /// </summary>
    /// <param name="shape">One of the <see cref="shapes">standard shapes</see>.</param>
    public static nint glfwCreateStandardCursor(int shape) => _glfwCreateStandardCursor(shape);
    [QGLNativeAPI("glfwCreateStandardCursor")] internal static delegate* unmanaged<int, nint> _glfwCreateStandardCursor = null;
    
    /// <summary>
    /// Destroys a cursor.<br/>
    /// <br/>
    /// This function destroys a cursor previously created with <see cref="glfwCreateCursor"/>.  Any remaining cursors will be destroyed by <see cref="glfwTerminate"/>.<br/>
    /// <br/>
    /// If the specified cursor is current for any window, that window will be<br/>
    /// reverted to the default cursor.  This does not affect the cursor mode.<br/>
    /// </summary>
    /// <param name="cursor">The cursor object to destroy.</param>
    public static void glfwDestroyCursor(nint cursor) => _glfwDestroyCursor(cursor);
    [QGLNativeAPI("glfwDestroyCursor")] internal static delegate* unmanaged<nint, void> _glfwDestroyCursor = null;
    
    /// <summary>
    /// Sets the cursor for the window.<br/>
    /// <br/>
    /// This function sets the cursor image to be used when the cursor is over the<br/>
    /// content area of the specified window.  The set cursor will only be visible<br/>
    /// when the <see cref="cursor_mode">cursor mode</see> of the window is<br/>
    /// `GLFW_CURSOR_NORMAL`.<br/>
    /// <br/>
    /// On some platforms, the set cursor may not be visible unless the window also<br/>
    /// has input focus.<br/>
    /// </summary>
    /// <param name="window">The window to set the cursor for.</param>
    /// <param name="cursor">The cursor to set, or `NULL` to switch back to the default<br/>arrow cursor.</param>
    public static void glfwSetCursor(nint window, nint cursor) => _glfwSetCursor(window, cursor);
    [QGLNativeAPI("glfwSetCursor")] internal static delegate* unmanaged<nint, nint, void> _glfwSetCursor = null;
    
    /// <summary>
    /// Sets the key callback.<br/>
    /// <br/>
    /// This function sets the key callback of the specified window, which is called<br/>
    /// when a key is pressed, repeated or released.<br/>
    /// <br/>
    /// The key functions deal with physical keys, with layout independent<br/>
    /// <see cref="keys">key tokens</see> named after their values in the standard US keyboard<br/>
    /// layout.  If you want to input text, use the<br/>
    /// <see cref="glfwSetCharCallback">character callback</see> instead.<br/>
    /// <br/>
    /// When a window loses input focus, it will generate synthetic key release<br/>
    /// events for all pressed keys with associated key tokens.  You can tell these<br/>
    /// events from user-generated events by the fact that the synthetic ones are<br/>
    /// generated after the focus loss event has been processed, i.e. after the<br/>
    /// <see cref="glfwSetWindowFocusCallback">window focus callback</see> has been called.<br/>
    /// <br/>
    /// The scancode of a key is specific to that platform or sometimes even to that<br/>
    /// machine.  Scancodes are intended to allow users to bind keys that don't have<br/>
    /// a GLFW key token.  Such keys have `key` set to `GLFW_KEY_UNKNOWN`, their<br/>
    /// state is not saved and so it cannot be queried with <see cref="glfwGetKey"/>.<br/>
    /// <br/>
    /// Sometimes GLFW needs to generate synthetic key events, in which case the<br/>
    /// scancode may be zero.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new key callback, or `NULL` to remove the currently<br/>set callback.</param>
    public static nint glfwSetKeyCallback(nint window, GLFWkeyfun callback) => _glfwSetKeyCallback(window, callback);
    [QGLNativeAPI("glfwSetKeyCallback")] internal static delegate* unmanaged<nint, GLFWkeyfun, nint> _glfwSetKeyCallback = null;
    
    /// <summary>
    /// Sets the Unicode character callback.<br/>
    /// <br/>
    /// This function sets the character callback of the specified window, which is<br/>
    /// called when a Unicode character is input.<br/>
    /// <br/>
    /// The character callback is intended for Unicode text input.  As it deals with<br/>
    /// characters, it is keyboard layout dependent, whereas the<br/>
    /// <see cref="glfwSetKeyCallback">key callback</see> is not.  Characters do not map 1:1<br/>
    /// to physical keys, as a key may produce zero, one or more characters.  If you<br/>
    /// want to know whether a specific physical key was pressed or released, see<br/>
    /// the key callback instead.<br/>
    /// <br/>
    /// The character callback behaves as system text input normally does and will<br/>
    /// not be called if modifier keys are held down that would prevent normal text<br/>
    /// input on that platform, for example a Super (Command) key on macOS or Alt key<br/>
    /// on Windows.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetCharCallback(nint window, GLFWcharfun callback) => _glfwSetCharCallback(window, callback);
    [QGLNativeAPI("glfwSetCharCallback")] internal static delegate* unmanaged<nint, GLFWcharfun, nint> _glfwSetCharCallback = null;
    
    /// <summary>
    /// Sets the Unicode character with modifiers callback.<br/>
    /// <br/>
    /// This function sets the character with modifiers callback of the specified<br/>
    /// window, which is called when a Unicode character is input regardless of what<br/>
    /// modifier keys are used.<br/>
    /// <br/>
    /// The character with modifiers callback is intended for implementing custom<br/>
    /// Unicode character input.  For regular Unicode text input, see the<br/>
    /// <see cref="glfwSetCharCallback">character callback</see>.  Like the character<br/>
    /// callback, the character with modifiers callback deals with characters and is<br/>
    /// keyboard layout dependent.  Characters do not map 1:1 to physical keys, as<br/>
    /// a key may produce zero, one or more characters.  If you want to know whether<br/>
    /// a specific physical key was pressed or released, see the<br/>
    /// <see cref="glfwSetKeyCallback">key callback</see> instead.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetCharModsCallback(nint window, GLFWcharmodsfun callback) => _glfwSetCharModsCallback(window, callback);
    [QGLNativeAPI("glfwSetCharModsCallback")] internal static delegate* unmanaged<nint, GLFWcharmodsfun, nint> _glfwSetCharModsCallback = null;
    
    /// <summary>
    /// Sets the mouse button callback.<br/>
    /// <br/>
    /// This function sets the mouse button callback of the specified window, which<br/>
    /// is called when a mouse button is pressed or released.<br/>
    /// <br/>
    /// When a window loses input focus, it will generate synthetic mouse button<br/>
    /// release events for all pressed mouse buttons with associated button tokens.<br/>
    /// You can tell these events from user-generated events by the fact that the<br/>
    /// synthetic ones are generated after the focus loss event has been processed,<br/>
    /// i.e. after the <see cref="glfwSetWindowFocusCallback">window focus callback</see> has<br/>
    /// been called.<br/>
    /// <br/>
    /// The reported `button` value can be higher than `GLFW_MOUSE_BUTTON_LAST` if<br/>
    /// the button does not have an associated <see cref="buttons">button token</see> and the<br/>
    /// <see cref="GLFW_UNLIMITED_MOUSE_BUTTONS"/> input mode is set.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetMouseButtonCallback(nint window, GLFWmousebuttonfun callback) => _glfwSetMouseButtonCallback(window, callback);
    [QGLNativeAPI("glfwSetMouseButtonCallback")] internal static delegate* unmanaged<nint, GLFWmousebuttonfun, nint> _glfwSetMouseButtonCallback = null;
    
    /// <summary>
    /// Sets the cursor position callback.<br/>
    /// <br/>
    /// This function sets the cursor position callback of the specified window,<br/>
    /// which is called when the cursor is moved.  The callback is provided with the<br/>
    /// position, in screen coordinates, relative to the upper-left corner of the<br/>
    /// content area of the window.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetCursorPosCallback(nint window, GLFWcursorposfun callback) => _glfwSetCursorPosCallback(window, callback);
    [QGLNativeAPI("glfwSetCursorPosCallback")] internal static delegate* unmanaged<nint, GLFWcursorposfun, nint> _glfwSetCursorPosCallback = null;
    
    /// <summary>
    /// Sets the cursor enter/leave callback.<br/>
    /// <br/>
    /// This function sets the cursor boundary crossing callback of the specified<br/>
    /// window, which is called when the cursor enters or leaves the content area of<br/>
    /// the window.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetCursorEnterCallback(nint window, GLFWcursorenterfun callback) => _glfwSetCursorEnterCallback(window, callback);
    [QGLNativeAPI("glfwSetCursorEnterCallback")] internal static delegate* unmanaged<nint, GLFWcursorenterfun, nint> _glfwSetCursorEnterCallback = null;
    
    /// <summary>
    /// Sets the scroll callback.<br/>
    /// <br/>
    /// This function sets the scroll callback of the specified window, which is<br/>
    /// called when a scrolling device is used, such as a mouse wheel or scrolling<br/>
    /// area of a touchpad.<br/>
    /// <br/>
    /// The scroll callback receives all scrolling input, like that from a mouse<br/>
    /// wheel or a touchpad scrolling area.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new scroll callback, or `NULL` to remove the<br/>currently set callback.</param>
    public static nint glfwSetScrollCallback(nint window, GLFWscrollfun callback) => _glfwSetScrollCallback(window, callback);
    [QGLNativeAPI("glfwSetScrollCallback")] internal static delegate* unmanaged<nint, GLFWscrollfun, nint> _glfwSetScrollCallback = null;
    
    /// <summary>
    /// Sets the path drop callback.<br/>
    /// <br/>
    /// This function sets the path drop callback of the specified window, which is<br/>
    /// called when one or more dragged paths are dropped on the window.<br/>
    /// <br/>
    /// Because the path array and its strings may have been generated specifically<br/>
    /// for that event, they are not guaranteed to be valid after the callback has<br/>
    /// returned.  If you wish to use them after the callback returns, you need to<br/>
    /// make a deep copy.<br/>
    /// </summary>
    /// <param name="window">The window whose callback to set.</param>
    /// <param name="callback">The new file drop callback, or `NULL` to remove the<br/>currently set callback.</param>
    public static nint glfwSetDropCallback(nint window, GLFWdropfun callback) => _glfwSetDropCallback(window, callback);
    [QGLNativeAPI("glfwSetDropCallback")] internal static delegate* unmanaged<nint, GLFWdropfun, nint> _glfwSetDropCallback = null;
    
    /// <summary>
    /// Returns whether the specified joystick is present.<br/>
    /// <br/>
    /// This function returns whether the specified joystick is present.<br/>
    /// <br/>
    /// There is no need to call this function before other functions that accept<br/>
    /// a joystick ID, as they all check for presence before performing any other<br/>
    /// work.<br/>
    /// </summary>
    /// <param name="jid">The <see cref="joysticks">joystick</see> to query.</param>
    public static int glfwJoystickPresent(int jid) => _glfwJoystickPresent(jid);
    [QGLNativeAPI("glfwJoystickPresent")] internal static delegate* unmanaged<int, int> _glfwJoystickPresent = null;
    
    /// <summary>
    /// Returns the values of all axes of the specified joystick.<br/>
    /// <br/>
    /// This function returns the values of all axes of the specified joystick.<br/>
    /// Each element in the array is a value between -1.0 and 1.0.<br/>
    /// <br/>
    /// If the specified joystick is not present this function will return `NULL`<br/>
    /// but will not generate an error.  This can be used instead of first calling<br/>
    /// <see cref="glfwJoystickPresent"/>.<br/>
    /// </summary>
    /// <param name="jid">The <see cref="joysticks">joystick</see> to query.</param>
    /// <param name="count">Where to store the number of axis values in the returned<br/>array.  This is set to zero if the joystick is not present or an error<br/>occurred.</param>
    public static float* glfwGetJoystickAxes(int jid, int* count) => _glfwGetJoystickAxes(jid, count);
    [QGLNativeAPI("glfwGetJoystickAxes")] internal static delegate* unmanaged<int, int*, float*> _glfwGetJoystickAxes = null;
    
    /// <summary>
    /// Returns the state of all buttons of the specified joystick.<br/>
    /// <br/>
    /// This function returns the state of all buttons of the specified joystick.<br/>
    /// Each element in the array is either `GLFW_PRESS` or `GLFW_RELEASE`.<br/>
    /// <br/>
    /// For backward compatibility with earlier versions that did not have <see cref="glfwGetJoystickHats"/>, the button array also includes all hats, each<br/>
    /// represented as four buttons.  The hats are in the same order as returned by<br/>
    /// __glfwGetJoystickHats__ and are in the order _up_, _right_, _down_ and<br/>
    /// _left_.  To disable these extra buttons, set the <see cref="GLFW_JOYSTICK_HAT_BUTTONS"/> init hint before initialization.<br/>
    /// <br/>
    /// If the specified joystick is not present this function will return `NULL`<br/>
    /// but will not generate an error.  This can be used instead of first calling<br/>
    /// <see cref="glfwJoystickPresent"/>.<br/>
    /// </summary>
    /// <param name="jid">The <see cref="joysticks">joystick</see> to query.</param>
    /// <param name="count">Where to store the number of button states in the returned<br/>array.  This is set to zero if the joystick is not present or an error<br/>occurred.</param>
    public static byte* glfwGetJoystickButtons(int jid, int* count) => _glfwGetJoystickButtons(jid, count);
    [QGLNativeAPI("glfwGetJoystickButtons")] internal static delegate* unmanaged<int, int*, byte*> _glfwGetJoystickButtons = null;
    
    /// <summary>
    /// Returns the state of all hats of the specified joystick.<br/>
    /// <br/>
    /// This function returns the state of all hats of the specified joystick.<br/>
    /// Each element in the array is one of the following values:<br/>
    /// <br/>
    /// Name                  | Value<br/>
    /// ----                  | -----<br/>
    /// `GLFW_HAT_CENTERED`   | 0<br/>
    /// `GLFW_HAT_UP`         | 1<br/>
    /// `GLFW_HAT_RIGHT`      | 2<br/>
    /// `GLFW_HAT_DOWN`       | 4<br/>
    /// `GLFW_HAT_LEFT`       | 8<br/>
    /// `GLFW_HAT_RIGHT_UP`   | `GLFW_HAT_RIGHT` \| `GLFW_HAT_UP`<br/>
    /// `GLFW_HAT_RIGHT_DOWN` | `GLFW_HAT_RIGHT` \| `GLFW_HAT_DOWN`<br/>
    /// `GLFW_HAT_LEFT_UP`    | `GLFW_HAT_LEFT` \| `GLFW_HAT_UP`<br/>
    /// `GLFW_HAT_LEFT_DOWN`  | `GLFW_HAT_LEFT` \| `GLFW_HAT_DOWN`<br/>
    /// <br/>
    /// The diagonal directions are bitwise combinations of the primary (up, right,<br/>
    /// down and left) directions and you can test for these individually by ANDing<br/>
    /// it with the corresponding direction.<br/>
    /// </summary>
    /// <param name="jid">The <see cref="joysticks">joystick</see> to query.</param>
    /// <param name="count">Where to store the number of hat states in the returned<br/>array.  This is set to zero if the joystick is not present or an error<br/>occurred.</param>
    public static byte* glfwGetJoystickHats(int jid, int* count) => _glfwGetJoystickHats(jid, count);
    [QGLNativeAPI("glfwGetJoystickHats")] internal static delegate* unmanaged<int, int*, byte*> _glfwGetJoystickHats = null;
    
    /// <summary>
    /// Returns the name of the specified joystick.<br/>
    /// <br/>
    /// This function returns the name, encoded as UTF-8, of the specified joystick.<br/>
    /// The returned string is allocated and freed by GLFW.  You should not free it<br/>
    /// yourself.<br/>
    /// <br/>
    /// If the specified joystick is not present this function will return `NULL`<br/>
    /// but will not generate an error.  This can be used instead of first calling<br/>
    /// <see cref="glfwJoystickPresent"/>.<br/>
    /// </summary>
    /// <param name="jid">The <see cref="joysticks">joystick</see> to query.</param>
    public static byte* glfwGetJoystickName(int jid) => _glfwGetJoystickName(jid);
    [QGLNativeAPI("glfwGetJoystickName")] internal static delegate* unmanaged<int, byte*> _glfwGetJoystickName = null;
    
    /// <summary>
    /// Returns the SDL compatible GUID of the specified joystick.<br/>
    /// <br/>
    /// This function returns the SDL compatible GUID, as a UTF-8 encoded<br/>
    /// hexadecimal string, of the specified joystick.  The returned string is<br/>
    /// allocated and freed by GLFW.  You should not free it yourself.<br/>
    /// <br/>
    /// The GUID is what connects a joystick to a gamepad mapping.  A connected<br/>
    /// joystick will always have a GUID even if there is no gamepad mapping<br/>
    /// assigned to it.<br/>
    /// <br/>
    /// If the specified joystick is not present this function will return `NULL`<br/>
    /// but will not generate an error.  This can be used instead of first calling<br/>
    /// <see cref="glfwJoystickPresent"/>.<br/>
    /// <br/>
    /// The GUID uses the format introduced in SDL 2.0.5.  This GUID tries to<br/>
    /// uniquely identify the make and model of a joystick but does not identify<br/>
    /// a specific unit, e.g. all wired Xbox 360 controllers will have the same<br/>
    /// GUID on that platform.  The GUID for a unit may vary between platforms<br/>
    /// depending on what hardware information the platform specific APIs provide.<br/>
    /// </summary>
    /// <param name="jid">The <see cref="joysticks">joystick</see> to query.</param>
    public static byte* glfwGetJoystickGUID(int jid) => _glfwGetJoystickGUID(jid);
    [QGLNativeAPI("glfwGetJoystickGUID")] internal static delegate* unmanaged<int, byte*> _glfwGetJoystickGUID = null;
    
    /// <summary>
    /// Sets the user pointer of the specified joystick.<br/>
    /// <br/>
    /// This function sets the user-defined pointer of the specified joystick.  The<br/>
    /// current value is retained until the joystick is disconnected.  The initial<br/>
    /// value is `NULL`.<br/>
    /// <br/>
    /// This function may be called from the joystick callback, even for a joystick<br/>
    /// that is being disconnected.<br/>
    /// </summary>
    /// <param name="jid">The joystick whose pointer to set.</param>
    /// <param name="pointer">The new value.</param>
    public static void glfwSetJoystickUserPointer(int jid, void* pointer) => _glfwSetJoystickUserPointer(jid, pointer);
    [QGLNativeAPI("glfwSetJoystickUserPointer")] internal static delegate* unmanaged<int, void*, void> _glfwSetJoystickUserPointer = null;
    
    /// <summary>
    /// Returns the user pointer of the specified joystick.<br/>
    /// <br/>
    /// This function returns the current value of the user-defined pointer of the<br/>
    /// specified joystick.  The initial value is `NULL`.<br/>
    /// <br/>
    /// This function may be called from the joystick callback, even for a joystick<br/>
    /// that is being disconnected.<br/>
    /// </summary>
    /// <param name="jid">The joystick whose pointer to return.</param>
    public static void* glfwGetJoystickUserPointer(int jid) => _glfwGetJoystickUserPointer(jid);
    [QGLNativeAPI("glfwGetJoystickUserPointer")] internal static delegate* unmanaged<int, void*> _glfwGetJoystickUserPointer = null;
    
    /// <summary>
    /// Returns whether the specified joystick has a gamepad mapping.<br/>
    /// <br/>
    /// This function returns whether the specified joystick is both present and has<br/>
    /// a gamepad mapping.<br/>
    /// <br/>
    /// If the specified joystick is present but does not have a gamepad mapping<br/>
    /// this function will return `GLFW_FALSE` but will not generate an error.  Call<br/>
    /// <see cref="glfwJoystickPresent"/> to check if a joystick is present regardless of<br/>
    /// whether it has a mapping.<br/>
    /// </summary>
    /// <param name="jid">The <see cref="joysticks">joystick</see> to query.</param>
    public static int glfwJoystickIsGamepad(int jid) => _glfwJoystickIsGamepad(jid);
    [QGLNativeAPI("glfwJoystickIsGamepad")] internal static delegate* unmanaged<int, int> _glfwJoystickIsGamepad = null;
    
    /// <summary>
    /// Sets the joystick configuration callback.<br/>
    /// <br/>
    /// This function sets the joystick configuration callback, or removes the<br/>
    /// currently set callback.  This is called when a joystick is connected to or<br/>
    /// disconnected from the system.<br/>
    /// <br/>
    /// For joystick connection and disconnection events to be delivered on all<br/>
    /// platforms, you need to call one of the <see cref="events">event processing</see><br/>
    /// functions.  Joystick disconnection may also be detected and the callback<br/>
    /// called by joystick functions.  The function will then return whatever it<br/>
    /// returns if the joystick is not present.<br/>
    /// </summary>
    /// <param name="callback">The new callback, or `NULL` to remove the currently set<br/>callback.</param>
    public static nint glfwSetJoystickCallback(GLFWjoystickfun callback) => _glfwSetJoystickCallback(callback);
    [QGLNativeAPI("glfwSetJoystickCallback")] internal static delegate* unmanaged<GLFWjoystickfun, nint> _glfwSetJoystickCallback = null;
    
    /// <summary>
    /// Adds the specified SDL_GameControllerDB gamepad mappings.<br/>
    /// <br/>
    /// This function parses the specified ASCII encoded string and updates the<br/>
    /// internal list with any gamepad mappings it finds.  This string may<br/>
    /// contain either a single gamepad mapping or many mappings separated by<br/>
    /// newlines.  The parser supports the full format of the `gamecontrollerdb.txt`<br/>
    /// source file including empty lines and comments.<br/>
    /// <br/>
    /// See <see cref="gamepad_mapping"/> for a description of the format.<br/>
    /// <br/>
    /// If there is already a gamepad mapping for a given GUID in the internal list,<br/>
    /// it will be replaced by the one passed to this function.  If the library is<br/>
    /// terminated and re-initialized the internal list will revert to the built-in<br/>
    /// default.<br/>
    /// </summary>
    /// <param name="string">The string containing the gamepad mappings.</param>
    public static int glfwUpdateGamepadMappings(byte* @string) => _glfwUpdateGamepadMappings(@string);
    [QGLNativeAPI("glfwUpdateGamepadMappings")] internal static delegate* unmanaged<byte*, int> _glfwUpdateGamepadMappings = null;
    
    /// <summary>
    /// Returns the human-readable gamepad name for the specified joystick.<br/>
    /// <br/>
    /// This function returns the human-readable name of the gamepad from the<br/>
    /// gamepad mapping assigned to the specified joystick.<br/>
    /// <br/>
    /// If the specified joystick is not present or does not have a gamepad mapping<br/>
    /// this function will return `NULL` but will not generate an error.  Call<br/>
    /// <see cref="glfwJoystickPresent"/> to check whether it is present regardless of<br/>
    /// whether it has a mapping.<br/>
    /// </summary>
    /// <param name="jid">The <see cref="joysticks">joystick</see> to query.</param>
    public static byte* glfwGetGamepadName(int jid) => _glfwGetGamepadName(jid);
    [QGLNativeAPI("glfwGetGamepadName")] internal static delegate* unmanaged<int, byte*> _glfwGetGamepadName = null;
    
    /// <summary>
    /// Retrieves the state of the specified joystick remapped as a gamepad.<br/>
    /// <br/>
    /// This function retrieves the state of the specified joystick remapped to<br/>
    /// an Xbox-like gamepad.<br/>
    /// <br/>
    /// If the specified joystick is not present or does not have a gamepad mapping<br/>
    /// this function will return `GLFW_FALSE` but will not generate an error.  Call<br/>
    /// <see cref="glfwJoystickPresent"/> to check whether it is present regardless of<br/>
    /// whether it has a mapping.<br/>
    /// <br/>
    /// The Guide button may not be available for input as it is often hooked by the<br/>
    /// system or the Steam client.<br/>
    /// <br/>
    /// Not all devices have all the buttons or axes provided by <see cref="GLFWgamepadstate"/>.  Unavailable buttons and axes will always report<br/>
    /// `GLFW_RELEASE` and 0.0 respectively.<br/>
    /// </summary>
    /// <param name="jid">The <see cref="joysticks">joystick</see> to query.</param>
    /// <param name="state">The gamepad input state of the joystick.</param>
    public static int glfwGetGamepadState(int jid, GLFWgamepadstate* state) => _glfwGetGamepadState(jid, state);
    [QGLNativeAPI("glfwGetGamepadState")] internal static delegate* unmanaged<int, GLFWgamepadstate*, int> _glfwGetGamepadState = null;
    
    /// <summary>
    /// Sets the clipboard to the specified string.<br/>
    /// <br/>
    /// This function sets the system clipboard to the specified, UTF-8 encoded<br/>
    /// string.<br/>
    /// </summary>
    /// <param name="window">Deprecated.  Any valid window or `NULL`.</param>
    /// <param name="string">A UTF-8 encoded string.</param>
    public static void glfwSetClipboardString(nint window, byte* @string) => _glfwSetClipboardString(window, @string);
    [QGLNativeAPI("glfwSetClipboardString")] internal static delegate* unmanaged<nint, byte*, void> _glfwSetClipboardString = null;
    
    /// <summary>
    /// Returns the contents of the clipboard as a string.<br/>
    /// <br/>
    /// This function returns the contents of the system clipboard, if it contains<br/>
    /// or is convertible to a UTF-8 encoded string.  If the clipboard is empty or<br/>
    /// if its contents cannot be converted, `NULL` is returned and a <see cref="GLFW_FORMAT_UNAVAILABLE"/> error is generated.<br/>
    /// </summary>
    /// <param name="window">Deprecated.  Any valid window or `NULL`.</param>
    public static byte* glfwGetClipboardString(nint window) => _glfwGetClipboardString(window);
    [QGLNativeAPI("glfwGetClipboardString")] internal static delegate* unmanaged<nint, byte*> _glfwGetClipboardString = null;
    
    /// <summary>
    /// Returns the GLFW time.<br/>
    /// <br/>
    /// This function returns the current GLFW time, in seconds.  Unless the time<br/>
    /// has been set using <see cref="glfwSetTime"/> it measures time elapsed since GLFW was<br/>
    /// initialized.<br/>
    /// <br/>
    /// This function and <see cref="glfwSetTime"/> are helper functions on top of <see cref="glfwGetTimerFrequency"/> and <see cref="glfwGetTimerValue"/>.<br/>
    /// <br/>
    /// The resolution of the timer is system dependent, but is usually on the order<br/>
    /// of a few micro- or nanoseconds.  It uses the highest-resolution monotonic<br/>
    /// time source on each operating system.<br/>
    /// </summary>
    public static double glfwGetTime() => _glfwGetTime();
    [QGLNativeAPI("glfwGetTime")] internal static delegate* unmanaged<double> _glfwGetTime = null;
    
    /// <summary>
    /// Sets the GLFW time.<br/>
    /// <br/>
    /// This function sets the current GLFW time, in seconds.  The value must be<br/>
    /// a positive finite number less than or equal to 18446744073.0, which is<br/>
    /// approximately 584.5 years.<br/>
    /// <br/>
    /// This function and <see cref="glfwGetTime"/> are helper functions on top of <see cref="glfwGetTimerFrequency"/> and <see cref="glfwGetTimerValue"/>.<br/>
    /// </summary>
    /// <param name="time">The new value, in seconds.</param>
    public static void glfwSetTime(double time) => _glfwSetTime(time);
    [QGLNativeAPI("glfwSetTime")] internal static delegate* unmanaged<double, void> _glfwSetTime = null;
    
    /// <summary>
    /// Returns the current value of the raw timer.<br/>
    /// <br/>
    /// This function returns the current value of the raw timer, measured in<br/>
    /// 1&nbsp;/&nbsp;frequency seconds.  To get the frequency, call <see cref="glfwGetTimerFrequency"/>.<br/>
    /// </summary>
    public static ulong glfwGetTimerValue() => _glfwGetTimerValue();
    [QGLNativeAPI("glfwGetTimerValue")] internal static delegate* unmanaged<ulong> _glfwGetTimerValue = null;
    
    /// <summary>
    /// Returns the frequency, in Hz, of the raw timer.<br/>
    /// <br/>
    /// This function returns the frequency, in Hz, of the raw timer.<br/>
    /// </summary>
    public static ulong glfwGetTimerFrequency() => _glfwGetTimerFrequency();
    [QGLNativeAPI("glfwGetTimerFrequency")] internal static delegate* unmanaged<ulong> _glfwGetTimerFrequency = null;
    
    /// <summary>
    /// Makes the context of the specified window current for the calling<br/>
    /// thread.<br/>
    /// <br/>
    /// This function makes the OpenGL or OpenGL ES context of the specified window<br/>
    /// current on the calling thread.  It can also detach the current context from<br/>
    /// the calling thread without making a new one current by passing in `NULL`.<br/>
    /// <br/>
    /// A context must only be made current on a single thread at a time and each<br/>
    /// thread can have only a single current context at a time.  Making a context<br/>
    /// current detaches any previously current context on the calling thread.<br/>
    /// <br/>
    /// When moving a context between threads, you must detach it (make it<br/>
    /// non-current) on the old thread before making it current on the new one.<br/>
    /// <br/>
    /// By default, making a context non-current implicitly forces a pipeline flush.<br/>
    /// On machines that support `GL_KHR_context_flush_control`, you can control<br/>
    /// whether a context performs this flush by setting the<br/>
    /// <see cref="GLFW_CONTEXT_RELEASE_BEHAVIOR_hint">GLFW_CONTEXT_RELEASE_BEHAVIOR</see><br/>
    /// hint.<br/>
    /// <br/>
    /// The specified window must have an OpenGL or OpenGL ES context.  Specifying<br/>
    /// a window without a context will generate a <see cref="GLFW_NO_WINDOW_CONTEXT"/><br/>
    /// error.<br/>
    /// </summary>
    /// <param name="window">The window whose context to make current, or `NULL` to<br/>detach the current context.</param>
    public static void glfwMakeContextCurrent(nint window) => _glfwMakeContextCurrent(window);
    [QGLNativeAPI("glfwMakeContextCurrent")] internal static delegate* unmanaged<nint, void> _glfwMakeContextCurrent = null;
    
    /// <summary>
    /// Returns the window whose context is current on the calling thread.<br/>
    /// <br/>
    /// This function returns the window whose OpenGL or OpenGL ES context is<br/>
    /// current on the calling thread.<br/>
    /// </summary>
    public static nint glfwGetCurrentContext() => _glfwGetCurrentContext();
    [QGLNativeAPI("glfwGetCurrentContext")] internal static delegate* unmanaged<nint> _glfwGetCurrentContext = null;
    
    /// <summary>
    /// Swaps the front and back buffers of the specified window.<br/>
    /// <br/>
    /// This function swaps the front and back buffers of the specified window when<br/>
    /// rendering with OpenGL or OpenGL ES.  If the swap interval is greater than<br/>
    /// zero, the GPU driver waits the specified number of screen updates before<br/>
    /// swapping the buffers.<br/>
    /// <br/>
    /// The specified window must have an OpenGL or OpenGL ES context.  Specifying<br/>
    /// a window without a context will generate a <see cref="GLFW_NO_WINDOW_CONTEXT"/><br/>
    /// error.<br/>
    /// <br/>
    /// This function does not apply to Vulkan.  If you are rendering with Vulkan,<br/>
    /// see `vkQueuePresentKHR` instead.<br/>
    /// </summary>
    /// <param name="window">The window whose buffers to swap.</param>
    public static void glfwSwapBuffers(nint window) => _glfwSwapBuffers(window);
    [QGLNativeAPI("glfwSwapBuffers")] internal static delegate* unmanaged<nint, void> _glfwSwapBuffers = null;
    
    /// <summary>
    /// Sets the swap interval for the current context.<br/>
    /// <br/>
    /// This function sets the swap interval for the current OpenGL or OpenGL ES<br/>
    /// context, i.e. the number of screen updates to wait from the time <see cref="glfwSwapBuffers"/> was called before swapping the buffers and returning.  This<br/>
    /// is sometimes called _vertical synchronization_, _vertical retrace<br/>
    /// synchronization_ or just _vsync_.<br/>
    /// <br/>
    /// A context that supports either of the `WGL_EXT_swap_control_tear` and<br/>
    /// `GLX_EXT_swap_control_tear` extensions also accepts _negative_ swap<br/>
    /// intervals, which allows the driver to swap immediately even if a frame<br/>
    /// arrives a little bit late.  You can check for these extensions with <see cref="glfwExtensionSupported"/>.<br/>
    /// <br/>
    /// A context must be current on the calling thread.  Calling this function<br/>
    /// without a current context will cause a <see cref="GLFW_NO_CURRENT_CONTEXT"/> error.<br/>
    /// <br/>
    /// This function does not apply to Vulkan.  If you are rendering with Vulkan,<br/>
    /// see the present mode of your swapchain instead.<br/>
    /// </summary>
    /// <param name="interval">The minimum number of screen updates to wait for<br/>until the buffers are swapped by <see cref="glfwSwapBuffers"/>.</param>
    public static void glfwSwapInterval(int interval) => _glfwSwapInterval(interval);
    [QGLNativeAPI("glfwSwapInterval")] internal static delegate* unmanaged<int, void> _glfwSwapInterval = null;
    
    /// <summary>
    /// Returns whether the specified extension is available.<br/>
    /// <br/>
    /// This function returns whether the specified<br/>
    /// <see cref="context_glext">API extension</see> is supported by the current OpenGL or<br/>
    /// OpenGL ES context.  It searches both for client API extension and context<br/>
    /// creation API extensions.<br/>
    /// <br/>
    /// A context must be current on the calling thread.  Calling this function<br/>
    /// without a current context will cause a <see cref="GLFW_NO_CURRENT_CONTEXT"/> error.<br/>
    /// <br/>
    /// As this functions retrieves and searches one or more extension strings each<br/>
    /// call, it is recommended that you cache its results if it is going to be used<br/>
    /// frequently.  The extension strings will not change during the lifetime of<br/>
    /// a context, so there is no danger in doing this.<br/>
    /// <br/>
    /// This function does not apply to Vulkan.  If you are using Vulkan, see <see cref="glfwGetRequiredInstanceExtensions"/>, `vkEnumerateInstanceExtensionProperties`<br/>
    /// and `vkEnumerateDeviceExtensionProperties` instead.<br/>
    /// </summary>
    /// <param name="extension">The ASCII encoded name of the extension.</param>
    public static int glfwExtensionSupported(byte* extension) => _glfwExtensionSupported(extension);
    [QGLNativeAPI("glfwExtensionSupported")] internal static delegate* unmanaged<byte*, int> _glfwExtensionSupported = null;
    
    /// <summary>
    /// Returns the address of the specified function for the current<br/>
    /// context.<br/>
    /// <br/>
    /// This function returns the address of the specified OpenGL or OpenGL ES<br/>
    /// <see cref="context_glext">core or extension function</see>, if it is supported<br/>
    /// by the current context.<br/>
    /// <br/>
    /// A context must be current on the calling thread.  Calling this function<br/>
    /// without a current context will cause a <see cref="GLFW_NO_CURRENT_CONTEXT"/> error.<br/>
    /// <br/>
    /// This function does not apply to Vulkan.  If you are rendering with Vulkan,<br/>
    /// see <see cref="glfwGetInstanceProcAddress"/>, `vkGetInstanceProcAddr` and<br/>
    /// `vkGetDeviceProcAddr` instead.<br/>
    /// </summary>
    /// <param name="procname">The ASCII encoded name of the function.</param>
    public static nint glfwGetProcAddress(byte* procname) => _glfwGetProcAddress(procname);
    [QGLNativeAPI("glfwGetProcAddress")] internal static delegate* unmanaged<byte*, nint> _glfwGetProcAddress = null;
    
    /// <summary>
    /// Returns whether the Vulkan loader and an ICD have been found.<br/>
    /// <br/>
    /// This function returns whether the Vulkan loader and any minimally functional<br/>
    /// ICD have been found.<br/>
    /// <br/>
    /// The availability of a Vulkan loader and even an ICD does not by itself guarantee that<br/>
    /// surface creation or even instance creation is possible.  Call <see cref="glfwGetRequiredInstanceExtensions"/> to check whether the extensions necessary for Vulkan<br/>
    /// surface creation are available and <see cref="glfwGetPhysicalDevicePresentationSupport"/> to<br/>
    /// check whether a queue family of a physical device supports image presentation.<br/>
    /// </summary>
    public static int glfwVulkanSupported() => _glfwVulkanSupported();
    [QGLNativeAPI("glfwVulkanSupported")] internal static delegate* unmanaged<int> _glfwVulkanSupported = null;
    
    /// <summary>
    /// Returns the Vulkan instance extensions required by GLFW.<br/>
    /// <br/>
    /// This function returns an array of names of Vulkan instance extensions required<br/>
    /// by GLFW for creating Vulkan surfaces for GLFW windows.  If successful, the<br/>
    /// list will always contain `VK_KHR_surface`, so if you don't require any<br/>
    /// additional extensions you can pass this list directly to the<br/>
    /// `VkInstanceCreateInfo` struct.<br/>
    /// <br/>
    /// If Vulkan is not available on the machine, this function returns `NULL` and<br/>
    /// generates a <see cref="GLFW_API_UNAVAILABLE"/> error.  Call <see cref="glfwVulkanSupported"/><br/>
    /// to check whether Vulkan is at least minimally available.<br/>
    /// <br/>
    /// If Vulkan is available but no set of extensions allowing window surface<br/>
    /// creation was found, this function returns `NULL`.  You may still use Vulkan<br/>
    /// for off-screen rendering and compute work.<br/>
    /// </summary>
    /// <param name="count">Where to store the number of extensions in the returned<br/>array.  This is set to zero if an error occurred.</param>
    public static byte** glfwGetRequiredInstanceExtensions(uint* count) => _glfwGetRequiredInstanceExtensions(count);
    [QGLNativeAPI("glfwGetRequiredInstanceExtensions")] internal static delegate* unmanaged<uint*, byte**> _glfwGetRequiredInstanceExtensions = null;
     #endregion
}
