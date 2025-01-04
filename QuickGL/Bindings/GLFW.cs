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

// Bindings generated at 2025-01-04 22:18:32.705860
namespace QuickGLNS.Bindings
{
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
        public const int GLFW_GAMEPAD_AXIS_LEFT_X = 0x0;
        public const int GLFW_GAMEPAD_AXIS_LEFT_Y = 0x1;
        public const int GLFW_GAMEPAD_AXIS_RIGHT_X = 0x2;
        public const int GLFW_GAMEPAD_AXIS_RIGHT_Y = 0x3;
        public const int GLFW_GAMEPAD_AXIS_LEFT_TRIGGER = 0x4;
        public const int GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER = 0x5;
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
        #endregion
        
        #region Functions
        [QGLNativeAPI("glfwInit")] public static delegate* unmanaged<int> glfwInit;
        
        [QGLNativeAPI("glfwTerminate")] public static delegate* unmanaged<void> glfwTerminate;
        
        [QGLNativeAPI("glfwInitHint")] public static delegate* unmanaged<int, int, void> glfwInitHint;
        
        [QGLNativeAPI("glfwInitAllocator")] public static delegate* unmanaged<GLFWallocator*, void> glfwInitAllocator;
        
        [QGLNativeAPI("glfwGetVersion")] public static delegate* unmanaged<int*, int*, int*, void> glfwGetVersion;
        
        [QGLNativeAPI("glfwGetVersionString")] public static delegate* unmanaged<byte*> glfwGetVersionString;
        
        [QGLNativeAPI("glfwGetError")] public static delegate* unmanaged<byte**, int> glfwGetError;
        
        [QGLNativeAPI("glfwSetErrorCallback")] public static delegate* unmanaged<GLFWerrorfun, nint> glfwSetErrorCallback;
        
        [QGLNativeAPI("glfwGetPlatform")] public static delegate* unmanaged<int> glfwGetPlatform;
        
        [QGLNativeAPI("glfwPlatformSupported")] public static delegate* unmanaged<int, int> glfwPlatformSupported;
        
        [QGLNativeAPI("glfwGetMonitors")] public static delegate* unmanaged<int*, nint> glfwGetMonitors;
        
        [QGLNativeAPI("glfwGetPrimaryMonitor")] public static delegate* unmanaged<nint> glfwGetPrimaryMonitor;
        
        [QGLNativeAPI("glfwGetMonitorPos")] public static delegate* unmanaged<nint, int*, int*, void> glfwGetMonitorPos;
        
        [QGLNativeAPI("glfwGetMonitorWorkarea")] public static delegate* unmanaged<nint, int*, int*, int*, int*, void> glfwGetMonitorWorkarea;
        
        [QGLNativeAPI("glfwGetMonitorPhysicalSize")] public static delegate* unmanaged<nint, int*, int*, void> glfwGetMonitorPhysicalSize;
        
        [QGLNativeAPI("glfwGetMonitorContentScale")] public static delegate* unmanaged<nint, float*, float*, void> glfwGetMonitorContentScale;
        
        [QGLNativeAPI("glfwGetMonitorName")] public static delegate* unmanaged<nint, byte*> glfwGetMonitorName;
        
        [QGLNativeAPI("glfwSetMonitorUserPointer")] public static delegate* unmanaged<nint, void*, void> glfwSetMonitorUserPointer;
        
        [QGLNativeAPI("glfwGetMonitorUserPointer")] public static delegate* unmanaged<nint, void*> glfwGetMonitorUserPointer;
        
        [QGLNativeAPI("glfwSetMonitorCallback")] public static delegate* unmanaged<GLFWmonitorfun, nint> glfwSetMonitorCallback;
        
        [QGLNativeAPI("glfwGetVideoModes")] public static delegate* unmanaged<nint, int*, GLFWvidmode*> glfwGetVideoModes;
        
        [QGLNativeAPI("glfwGetVideoMode")] public static delegate* unmanaged<nint, GLFWvidmode*> glfwGetVideoMode;
        
        [QGLNativeAPI("glfwSetGamma")] public static delegate* unmanaged<nint, float, void> glfwSetGamma;
        
        [QGLNativeAPI("glfwGetGammaRamp")] public static delegate* unmanaged<nint, GLFWgammaramp*> glfwGetGammaRamp;
        
        [QGLNativeAPI("glfwSetGammaRamp")] public static delegate* unmanaged<nint, GLFWgammaramp*, void> glfwSetGammaRamp;
        
        [QGLNativeAPI("glfwDefaultWindowHints")] public static delegate* unmanaged<void> glfwDefaultWindowHints;
        
        [QGLNativeAPI("glfwWindowHint")] public static delegate* unmanaged<int, int, void> glfwWindowHint;
        
        [QGLNativeAPI("glfwWindowHintString")] public static delegate* unmanaged<int, byte*, void> glfwWindowHintString;
        
        [QGLNativeAPI("glfwCreateWindow")] public static delegate* unmanaged<int, int, byte*, nint, nint, nint> glfwCreateWindow;
        
        [QGLNativeAPI("glfwDestroyWindow")] public static delegate* unmanaged<nint, void> glfwDestroyWindow;
        
        [QGLNativeAPI("glfwWindowShouldClose")] public static delegate* unmanaged<nint, int> glfwWindowShouldClose;
        
        [QGLNativeAPI("glfwSetWindowShouldClose")] public static delegate* unmanaged<nint, int, void> glfwSetWindowShouldClose;
        
        [QGLNativeAPI("glfwGetWindowTitle")] public static delegate* unmanaged<nint, byte*> glfwGetWindowTitle;
        
        [QGLNativeAPI("glfwSetWindowTitle")] public static delegate* unmanaged<nint, byte*, void> glfwSetWindowTitle;
        
        [QGLNativeAPI("glfwSetWindowIcon")] public static delegate* unmanaged<nint, int, GLFWimage*, void> glfwSetWindowIcon;
        
        [QGLNativeAPI("glfwGetWindowPos")] public static delegate* unmanaged<nint, int*, int*, void> glfwGetWindowPos;
        
        [QGLNativeAPI("glfwSetWindowPos")] public static delegate* unmanaged<nint, int, int, void> glfwSetWindowPos;
        
        [QGLNativeAPI("glfwGetWindowSize")] public static delegate* unmanaged<nint, int*, int*, void> glfwGetWindowSize;
        
        [QGLNativeAPI("glfwSetWindowSizeLimits")] public static delegate* unmanaged<nint, int, int, int, int, void> glfwSetWindowSizeLimits;
        
        [QGLNativeAPI("glfwSetWindowAspectRatio")] public static delegate* unmanaged<nint, int, int, void> glfwSetWindowAspectRatio;
        
        [QGLNativeAPI("glfwSetWindowSize")] public static delegate* unmanaged<nint, int, int, void> glfwSetWindowSize;
        
        [QGLNativeAPI("glfwGetFramebufferSize")] public static delegate* unmanaged<nint, int*, int*, void> glfwGetFramebufferSize;
        
        [QGLNativeAPI("glfwGetWindowFrameSize")] public static delegate* unmanaged<nint, int*, int*, int*, int*, void> glfwGetWindowFrameSize;
        
        [QGLNativeAPI("glfwGetWindowContentScale")] public static delegate* unmanaged<nint, float*, float*, void> glfwGetWindowContentScale;
        
        [QGLNativeAPI("glfwGetWindowOpacity")] public static delegate* unmanaged<nint, float> glfwGetWindowOpacity;
        
        [QGLNativeAPI("glfwSetWindowOpacity")] public static delegate* unmanaged<nint, float, void> glfwSetWindowOpacity;
        
        [QGLNativeAPI("glfwIconifyWindow")] public static delegate* unmanaged<nint, void> glfwIconifyWindow;
        
        [QGLNativeAPI("glfwRestoreWindow")] public static delegate* unmanaged<nint, void> glfwRestoreWindow;
        
        [QGLNativeAPI("glfwMaximizeWindow")] public static delegate* unmanaged<nint, void> glfwMaximizeWindow;
        
        [QGLNativeAPI("glfwShowWindow")] public static delegate* unmanaged<nint, void> glfwShowWindow;
        
        [QGLNativeAPI("glfwHideWindow")] public static delegate* unmanaged<nint, void> glfwHideWindow;
        
        [QGLNativeAPI("glfwFocusWindow")] public static delegate* unmanaged<nint, void> glfwFocusWindow;
        
        [QGLNativeAPI("glfwRequestWindowAttention")] public static delegate* unmanaged<nint, void> glfwRequestWindowAttention;
        
        [QGLNativeAPI("glfwGetWindowMonitor")] public static delegate* unmanaged<nint, nint> glfwGetWindowMonitor;
        
        [QGLNativeAPI("glfwSetWindowMonitor")] public static delegate* unmanaged<nint, nint, int, int, int, int, int, void> glfwSetWindowMonitor;
        
        [QGLNativeAPI("glfwGetWindowAttrib")] public static delegate* unmanaged<nint, int, int> glfwGetWindowAttrib;
        
        [QGLNativeAPI("glfwSetWindowAttrib")] public static delegate* unmanaged<nint, int, int, void> glfwSetWindowAttrib;
        
        [QGLNativeAPI("glfwSetWindowUserPointer")] public static delegate* unmanaged<nint, void*, void> glfwSetWindowUserPointer;
        
        [QGLNativeAPI("glfwGetWindowUserPointer")] public static delegate* unmanaged<nint, void*> glfwGetWindowUserPointer;
        
        [QGLNativeAPI("glfwSetWindowPosCallback")] public static delegate* unmanaged<nint, GLFWwindowposfun, nint> glfwSetWindowPosCallback;
        
        [QGLNativeAPI("glfwSetWindowSizeCallback")] public static delegate* unmanaged<nint, GLFWwindowsizefun, nint> glfwSetWindowSizeCallback;
        
        [QGLNativeAPI("glfwSetWindowCloseCallback")] public static delegate* unmanaged<nint, GLFWwindowclosefun, nint> glfwSetWindowCloseCallback;
        
        [QGLNativeAPI("glfwSetWindowRefreshCallback")] public static delegate* unmanaged<nint, GLFWwindowrefreshfun, nint> glfwSetWindowRefreshCallback;
        
        [QGLNativeAPI("glfwSetWindowFocusCallback")] public static delegate* unmanaged<nint, GLFWwindowfocusfun, nint> glfwSetWindowFocusCallback;
        
        [QGLNativeAPI("glfwSetWindowIconifyCallback")] public static delegate* unmanaged<nint, GLFWwindowiconifyfun, nint> glfwSetWindowIconifyCallback;
        
        [QGLNativeAPI("glfwSetWindowMaximizeCallback")] public static delegate* unmanaged<nint, GLFWwindowmaximizefun, nint> glfwSetWindowMaximizeCallback;
        
        [QGLNativeAPI("glfwSetFramebufferSizeCallback")] public static delegate* unmanaged<nint, GLFWframebuffersizefun, nint> glfwSetFramebufferSizeCallback;
        
        [QGLNativeAPI("glfwSetWindowContentScaleCallback")] public static delegate* unmanaged<nint, GLFWwindowcontentscalefun, nint> glfwSetWindowContentScaleCallback;
        
        [QGLNativeAPI("glfwPollEvents")] public static delegate* unmanaged<void> glfwPollEvents;
        
        [QGLNativeAPI("glfwWaitEvents")] public static delegate* unmanaged<void> glfwWaitEvents;
        
        [QGLNativeAPI("glfwWaitEventsTimeout")] public static delegate* unmanaged<double, void> glfwWaitEventsTimeout;
        
        [QGLNativeAPI("glfwPostEmptyEvent")] public static delegate* unmanaged<void> glfwPostEmptyEvent;
        
        [QGLNativeAPI("glfwGetInputMode")] public static delegate* unmanaged<nint, int, int> glfwGetInputMode;
        
        [QGLNativeAPI("glfwSetInputMode")] public static delegate* unmanaged<nint, int, int, void> glfwSetInputMode;
        
        [QGLNativeAPI("glfwRawMouseMotionSupported")] public static delegate* unmanaged<int> glfwRawMouseMotionSupported;
        
        [QGLNativeAPI("glfwGetKeyName")] public static delegate* unmanaged<int, int, byte*> glfwGetKeyName;
        
        [QGLNativeAPI("glfwGetKeyScancode")] public static delegate* unmanaged<int, int> glfwGetKeyScancode;
        
        [QGLNativeAPI("glfwGetKey")] public static delegate* unmanaged<nint, int, int> glfwGetKey;
        
        [QGLNativeAPI("glfwGetMouseButton")] public static delegate* unmanaged<nint, int, int> glfwGetMouseButton;
        
        [QGLNativeAPI("glfwGetCursorPos")] public static delegate* unmanaged<nint, double*, double*, void> glfwGetCursorPos;
        
        [QGLNativeAPI("glfwSetCursorPos")] public static delegate* unmanaged<nint, double, double, void> glfwSetCursorPos;
        
        [QGLNativeAPI("glfwCreateCursor")] public static delegate* unmanaged<GLFWimage*, int, int, nint> glfwCreateCursor;
        
        [QGLNativeAPI("glfwCreateStandardCursor")] public static delegate* unmanaged<int, nint> glfwCreateStandardCursor;
        
        [QGLNativeAPI("glfwDestroyCursor")] public static delegate* unmanaged<nint, void> glfwDestroyCursor;
        
        [QGLNativeAPI("glfwSetCursor")] public static delegate* unmanaged<nint, nint, void> glfwSetCursor;
        
        [QGLNativeAPI("glfwSetKeyCallback")] public static delegate* unmanaged<nint, GLFWkeyfun, nint> glfwSetKeyCallback;
        
        [QGLNativeAPI("glfwSetCharCallback")] public static delegate* unmanaged<nint, GLFWcharfun, nint> glfwSetCharCallback;
        
        [QGLNativeAPI("glfwSetCharModsCallback")] public static delegate* unmanaged<nint, GLFWcharmodsfun, nint> glfwSetCharModsCallback;
        
        [QGLNativeAPI("glfwSetMouseButtonCallback")] public static delegate* unmanaged<nint, GLFWmousebuttonfun, nint> glfwSetMouseButtonCallback;
        
        [QGLNativeAPI("glfwSetCursorPosCallback")] public static delegate* unmanaged<nint, GLFWcursorposfun, nint> glfwSetCursorPosCallback;
        
        [QGLNativeAPI("glfwSetCursorEnterCallback")] public static delegate* unmanaged<nint, GLFWcursorenterfun, nint> glfwSetCursorEnterCallback;
        
        [QGLNativeAPI("glfwSetScrollCallback")] public static delegate* unmanaged<nint, GLFWscrollfun, nint> glfwSetScrollCallback;
        
        [QGLNativeAPI("glfwSetDropCallback")] public static delegate* unmanaged<nint, GLFWdropfun, nint> glfwSetDropCallback;
        
        [QGLNativeAPI("glfwJoystickPresent")] public static delegate* unmanaged<int, int> glfwJoystickPresent;
        
        [QGLNativeAPI("glfwGetJoystickAxes")] public static delegate* unmanaged<int, int*, float*> glfwGetJoystickAxes;
        
        [QGLNativeAPI("glfwGetJoystickButtons")] public static delegate* unmanaged<int, int*, byte*> glfwGetJoystickButtons;
        
        [QGLNativeAPI("glfwGetJoystickHats")] public static delegate* unmanaged<int, int*, byte*> glfwGetJoystickHats;
        
        [QGLNativeAPI("glfwGetJoystickName")] public static delegate* unmanaged<int, byte*> glfwGetJoystickName;
        
        [QGLNativeAPI("glfwGetJoystickGUID")] public static delegate* unmanaged<int, byte*> glfwGetJoystickGUID;
        
        [QGLNativeAPI("glfwSetJoystickUserPointer")] public static delegate* unmanaged<int, void*, void> glfwSetJoystickUserPointer;
        
        [QGLNativeAPI("glfwGetJoystickUserPointer")] public static delegate* unmanaged<int, void*> glfwGetJoystickUserPointer;
        
        [QGLNativeAPI("glfwJoystickIsGamepad")] public static delegate* unmanaged<int, int> glfwJoystickIsGamepad;
        
        [QGLNativeAPI("glfwSetJoystickCallback")] public static delegate* unmanaged<GLFWjoystickfun, nint> glfwSetJoystickCallback;
        
        [QGLNativeAPI("glfwUpdateGamepadMappings")] public static delegate* unmanaged<byte*, int> glfwUpdateGamepadMappings;
        
        [QGLNativeAPI("glfwGetGamepadName")] public static delegate* unmanaged<int, byte*> glfwGetGamepadName;
        
        [QGLNativeAPI("glfwGetGamepadState")] public static delegate* unmanaged<int, GLFWgamepadstate*, int> glfwGetGamepadState;
        
        [QGLNativeAPI("glfwSetClipboardString")] public static delegate* unmanaged<nint, byte*, void> glfwSetClipboardString;
        
        [QGLNativeAPI("glfwGetClipboardString")] public static delegate* unmanaged<nint, byte*> glfwGetClipboardString;
        
        [QGLNativeAPI("glfwGetTime")] public static delegate* unmanaged<double> glfwGetTime;
        
        [QGLNativeAPI("glfwSetTime")] public static delegate* unmanaged<double, void> glfwSetTime;
        
        [QGLNativeAPI("glfwGetTimerValue")] public static delegate* unmanaged<ulong> glfwGetTimerValue;
        
        [QGLNativeAPI("glfwGetTimerFrequency")] public static delegate* unmanaged<ulong> glfwGetTimerFrequency;
        
        [QGLNativeAPI("glfwMakeContextCurrent")] public static delegate* unmanaged<nint, void> glfwMakeContextCurrent;
        
        [QGLNativeAPI("glfwGetCurrentContext")] public static delegate* unmanaged<nint> glfwGetCurrentContext;
        
        [QGLNativeAPI("glfwSwapBuffers")] public static delegate* unmanaged<nint, void> glfwSwapBuffers;
        
        [QGLNativeAPI("glfwSwapInterval")] public static delegate* unmanaged<int, void> glfwSwapInterval;
        
        [QGLNativeAPI("glfwExtensionSupported")] public static delegate* unmanaged<byte*, int> glfwExtensionSupported;
        
        [QGLNativeAPI("glfwGetProcAddress")] public static delegate* unmanaged<byte*, nint> glfwGetProcAddress;
        
        [QGLNativeAPI("glfwVulkanSupported")] public static delegate* unmanaged<int> glfwVulkanSupported;
        
        [QGLNativeAPI("glfwGetRequiredInstanceExtensions")] public static delegate* unmanaged<uint*, byte**> glfwGetRequiredInstanceExtensions;
        #endregion
    }
}
