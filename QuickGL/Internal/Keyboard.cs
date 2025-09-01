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

using QuickGLNS.Bindings;
using System.Runtime.InteropServices;
using System.Text;
using static QuickGLNS.Bindings.GLFW;

namespace QuickGLNS.Internal;

internal unsafe class Keyboard : IKeyboard
{
    private static readonly Dictionary<int, string> KNOWN_KEY_NAMES = new()
    {
        { GLFW_KEY_SPACE, "SPACE" },
        { GLFW_KEY_ENTER, "ENTER" },
        { GLFW_KEY_BACKSPACE, "BACKSPACE" },
        { GLFW_KEY_TAB, "TAB" },
        { GLFW_KEY_ESCAPE, "ESC" },
        { GLFW_KEY_LEFT_SHIFT, "LSHIFT" },
        { GLFW_KEY_RIGHT_SHIFT, "RSHIFT" },
        { GLFW_KEY_LEFT_CONTROL, "LCTRL" },
        { GLFW_KEY_RIGHT_CONTROL, "RCTRL" },
        { GLFW_KEY_LEFT_ALT, "LALT" },
        { GLFW_KEY_RIGHT_ALT, "RALT" },
        { GLFW_KEY_LEFT_SUPER, "LSUPER" },
        { GLFW_KEY_RIGHT_SUPER, "RSUPER" },
        { GLFW_KEY_CAPS_LOCK, "CAPS LOCK" },
        { GLFW_KEY_SCROLL_LOCK, "SCROLL LOCK" },
        { GLFW_KEY_NUM_LOCK, "NUM LOCK" },
        { GLFW_KEY_PRINT_SCREEN, "PRINT SCR" },
        { GLFW_KEY_PAUSE, "PAUSE" },
        { GLFW_KEY_INSERT, "INSERT" },
        { GLFW_KEY_DELETE, "DELETE" },
        { GLFW_KEY_HOME, "HOME" },
        { GLFW_KEY_END, "END" },
        { GLFW_KEY_PAGE_UP, "PAGE UP" },
        { GLFW_KEY_PAGE_DOWN, "PAGE DOWN" },
        { GLFW_KEY_UP, "UP" },
        { GLFW_KEY_DOWN, "DOWN" },
        { GLFW_KEY_LEFT, "LEFT" },
        { GLFW_KEY_RIGHT, "RIGHT" }
    };
    private nint window;
    private bool fallbackKeyEvent;
    private GLFWkeyfun keyCallback;
    private GLFWcharfun charCallback;
    private readonly Dictionary<int, bool> keys = [];
    // Events that are not yet ready to be handled
    private KeyEvent* pendingEvent;
    private readonly Queue<nint> pendingEvents = [];
    // Fully filled events ready to be handled
    private KeyEvent currentEvent;
    private readonly Queue<KeyEvent> events = [];
    public int EventKey => currentEvent.Key;
    public char EventChar => currentEvent.Character;
    public KeyState EventState => currentEvent.State;
    public bool AllowRepeatEvents { get; set; }

    private struct KeyEvent
    {
        public int Key;
        public char Character;
        public KeyState State;
        public bool Valid;
    }

    public void Init(nint window)
    {
        this.window = window;
        fallbackKeyEvent = glfwGetPlatform() == GLFW_PLATFORM_X11;
        for (int i = GLFW_KEY_SPACE; i <= GLFW_KEY_LAST; i++) 
            keys[i] = false;
        glfwSetKeyCallback(window, keyCallback = KeyCallback);
        if (!fallbackKeyEvent)
            glfwSetCharCallback(window, charCallback = CharCallback);
        else
        {
            Console.Error.WriteLine($"[QuickGL] Using fallback char input on current platform");
            glfwSetInputMode(window, GLFW_LOCK_KEY_MODS, GLFW_TRUE);
        }
    }

    private static char GetCharCodepoint(uint code)
    {
        if (!Rune.TryCreate(code, out Rune rune))
            return '\0';
        Span<char> bytes = stackalloc char[rune.Utf16SequenceLength];
        if (!rune.TryEncodeToUtf16(bytes, out int written))
            return '\0';
        if (written > 1)
        {
            Console.Error.WriteLine($"[QuickGL] Pressed key cannot fit in a single char, ignoring: {new string(bytes)}");
            return '\0';
        }
        return bytes[0];
    }

    private static char GetShiftASCII(char c)
    {
        switch (c)
        {
            case '1': return '!';
            case '2': return '@';
            case '3': return '#';
            case '4': return '$';
            case '5': return '%';
            case '6': return '^';
            case '7': return '&';
            case '8': return '*';
            case '9': return '(';
            case '0': return ')';
            case '-': return '_';
            case '=': return '+';
            case '[': return '{';
            case ']': return '}';
            case '\\': return '|';
            case ';': return ':';
            case '\'': return '"';
            case ',': return '<';
            case '.': return '>';
            case '/': return '?';
            default:
                return c;
        }
    }

    private static char GetCharFallback(int key, int mods)
    {
        if (key < 0x20 || key > 0x7F)
            return '\0';
        char c = (char)key;
        bool hasCaps = (mods & GLFW_MOD_CAPS_LOCK) != 0;
        bool hasShift = (mods & GLFW_MOD_SHIFT) != 0;

        if (c >= 'A' && c <= 'Z')
        {
            if ((!hasCaps && !hasShift) || (hasCaps && hasShift))
                c = (char)(key + 32);
        }
        else if (hasShift)
            c = GetShiftASCII(c);

        return c;
    }

    private void KeyCallback(nint _, int key, int scancode, int action, int mods)
    {
        lock (pendingEvents)
        {
            bool prevState = keys.ContainsKey(key) && keys[key];
            bool state = action == GLFW_PRESS || action == GLFW_REPEAT;
            keys[key] = state;

            KeyState keyState;
            if (state && !prevState)
                keyState = KeyState.PRESSED;
            else if (!state && prevState)
                keyState = KeyState.RELEASED;
            else
            {
                if (!AllowRepeatEvents) return;
                keyState = KeyState.REPEATED;
            }

            KeyEvent* @event = (KeyEvent*)NativeMemory.AllocZeroed((uint)sizeof(KeyEvent));
            @event->Key = key;
            @event->State = keyState;
            @event->Valid = true;

            if (state && fallbackKeyEvent)
                @event->Character = GetCharFallback(key, mods);
            else
                pendingEvent = state && !fallbackKeyEvent ? @event : null;

            pendingEvents.Enqueue((nint)@event);
        }
    }

    private void CharCallback(nint _, uint code)
    {
        if (fallbackKeyEvent)
            return;
        lock (pendingEvents)
        {
            if (pendingEvent != null && pendingEvent->Character == 0)
                pendingEvent->Character = GetCharCodepoint(code);
            pendingEvent = null;
        }
    }

    private static bool IsValidEvent(KeyEvent e) => e.Valid && (e.Character != 0 || e.Key > 0);

    public bool Next()
    {
        lock (pendingEvents)
        {
            while (pendingEvents.Count > 0)
            {
                KeyEvent* ptr = (KeyEvent*)pendingEvents.Dequeue();
                if (ptr == null)
                    continue;
                events.Enqueue(*ptr);
                NativeMemory.Free(ptr);
            }
        }

        if (events.Count == 0)
        {
            currentEvent.Valid = false;
            return false;
        }

        while (events.Count > 0 && !IsValidEvent(currentEvent = events.Dequeue())) ;

        if (events.Count == 0 && !IsValidEvent(currentEvent))
            return false;

        return true;
    }

    public bool GetState(int key) => keys.ContainsKey(key) && keys[key];

    public string GetName(int key)
    {
        if (KNOWN_KEY_NAMES.TryGetValue(key, out string data))
            return data;
        byte* ptr = glfwGetKeyName(key, 0);
        if (ptr == (byte*)0)
            return null;
        using QGLString str = new(ptr);
        data = str.Data.ToUpper();
        return data;
    }

    public void Dispose()
    {
        lock (pendingEvents)
        {
            if (pendingEvent != null)
            {
                NativeMemory.Free(pendingEvent);
                pendingEvent = null;
            }
            foreach (nint ptr in pendingEvents) 
            {
                if (ptr == 0)
                    continue;
                NativeMemory.Free((KeyEvent*)ptr);
            }
            pendingEvents.Clear();
        }
        glfwSetKeyCallback(window, null);
        glfwSetCharCallback(window, null);
        keyCallback = null;
        charCallback = null;
    }
}