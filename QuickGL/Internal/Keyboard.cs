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
using static QuickGLNS.Bindings.GLFW;

namespace QuickGLNS.Internal;

internal unsafe class Keyboard : IKeyboard
{
    private static readonly Dictionary<int, string> KEY_NAMES = new()
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
    private GLFWkeyfun keyCallback;
    private GLFWcharfun charCallback;
    private readonly Dictionary<int, bool> keys = [];
    private readonly Queue<KeyEvent> events = [];
    private readonly object eventLock = new();
    private KeyEvent pendingEvent;
    private KeyEvent currentEvent;
    public int EventKey => currentEvent.Key;
    public char EventChar => currentEvent.Character;
    public KeyState EventState => currentEvent.State;
    public bool AllowRepeatEvents { get; set; }
    public bool FastMode { get; set; }

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
        glfwSetKeyCallback(window, keyCallback = KeyCallback);
        glfwSetCharCallback(window, charCallback = CharCallback);
        for (int i = GLFW_KEY_SPACE; i <= GLFW_KEY_LAST; i++) keys[i] = false;
    }

    private static char ConvertCodepoint(uint code)
    {
        char c = '\0';

        if (code <= 0x7F)
            c = (char)code;
        else if (code <= 0x7FF)
        {
            byte c0 = (byte)(0xC0 | (code >> 6));
            byte c1 = (byte)(0x80 | (code & 0x3F));
            c = (char)(c0 | c1);
        }

        return c;
    }

    private void KeyCallback(nint _, int key, int scancode, int action, int mods)
    {
        lock (eventLock)
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

            pendingEvent = new()
            {
                Key = key,
                State = keyState,
                Valid = true
            };

            if (!FastMode && state && key <= 0x7F)
                return;
            events.Enqueue(pendingEvent);
            pendingEvent.Valid = false;
        }
    }

    private void CharCallback(nint _, uint code)
    {
        if (FastMode) return;
        lock (eventLock)
        {
            if (!pendingEvent.Valid)
                return;
            pendingEvent.Character = ConvertCodepoint(code);
            events.Enqueue(pendingEvent);
            pendingEvent.Valid = false;
        }
    }

    private bool IsCharOnlyEvent(KeyEvent e) => e.Key < 0 && e.Character != '\0';

    private bool IsValidEvent(KeyEvent e) => e.Valid && (IsCharOnlyEvent(e) || currentEvent.Key > 0);

    public bool Next()
    {
        lock (eventLock)
        {
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
    }

    public bool GetState(int key) => keys.ContainsKey(key) && keys[key];

    public string GetName(int key)
    {
        if (KEY_NAMES.TryGetValue(key, out string data))
            return data;
        byte* ptr = glfwGetKeyName(key, 0);
        if (ptr == (byte*)0)
            return null;
        QGLString str = new(ptr);
        data = str.Data.ToUpper();
        str.Dispose();
        return data;
    }

    public void Dispose()
    {
        glfwSetKeyCallback(window, null);
        glfwSetCharCallback(window, null);
        keyCallback = null;
        charCallback = null;
    }
}