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

using System.Text;
using QuickGLNS.Bindings;
using static QuickGLNS.Bindings.GLFW;

namespace QuickGLNS.Internal
{
    public unsafe class Keyboard : IKeyboard
    {
        private nint window;
        private GLFWkeyfun keyCallback;
        private GLFWcharfun charCallback;
        private Dictionary<int, bool> keys = [];
        private Queue<KeyEvent> events = [];
        private KeyEvent pendingEvent;
        private KeyEvent currentEvent;
        public int EventKey => currentEvent.Key;
        public int EventChar => currentEvent.Character;
        public int EventState => (int)currentEvent.State;
        
        private enum KeyState
        {
            INVALID,
            RELEASED,
            PRESSED,
            REPEATED
        }
        
        private struct KeyEvent
        {
            public int Key;
            public char Character;
            public KeyState State;
            
            public KeyEvent()
            {
                State = KeyState.INVALID;
            }
        }
        
        public void Init(nint window)
        {
            this.window = window;
            glfwSetKeyCallback(window, keyCallback = KeyCallback);
            glfwSetCharCallback(window, charCallback = CharCallback);
            for (int i = GLFW_KEY_SPACE; i <= GLFW_KEY_MENU; i++) keys[i] = false;
        }

        private void KeyCallback(nint _, int key, int scancode, int action, int mods)
        {
            bool prevState = keys.ContainsKey(key) && keys[key];
            bool state = action == GLFW_PRESS || action == GLFW_REPEAT;

            KeyState keyState;
            if (state && !prevState)
                keyState = KeyState.PRESSED;
            else if (!state && prevState)
                keyState = KeyState.REPEATED;
            else
                keyState = KeyState.RELEASED;

            pendingEvent = new()
            {
                Key = key,
                State = keyState
            };
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
        
        private void CharCallback(nint _, uint code)
        {
            if (pendingEvent.State == KeyState.INVALID)
                return;
            pendingEvent.Character = ConvertCodepoint(code);
        }

        public void Poll()
        {
            if (pendingEvent.State == KeyState.INVALID)
                return;
            events.Enqueue(pendingEvent);
            pendingEvent = new();
        }

        public bool Next()
        {
            if (events.Count == 0)
            {
                currentEvent = new();
                return false;
            }
            currentEvent = events.Dequeue();
            return true;
        }

        public bool GetState(int key) 
            => keys.ContainsKey(key) && keys[key];

        public QGLString GetName(int key)
        {
            byte* ptr = glfwGetKeyName(key, 0);
            if (ptr == (byte*)0)
                return null;
            return new QGLString(ptr);
        }
        
        public void Dispose()
        {
            glfwSetKeyCallback(window, null);
            glfwSetCharCallback(window, null);
            keyCallback = null;
            charCallback = null;
        }
    }
}