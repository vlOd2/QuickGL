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

namespace QuickGLNS.Internal
{
    public unsafe class Mouse : IMouse
    {
        private nint window;
        private GLFWcursorposfun positionCallback;
        private GLFWmousebuttonfun buttonCallback;
        private GLFWscrollfun scrollCallback;
        private readonly bool[] buttons = new bool[GLFW_MOUSE_BUTTON_LAST];
        private readonly Queue<MouseButtonEvent> events = [];
        private readonly object eventLock = new();
        private MouseButtonEvent currentEvent;
        private int xo;
        private int yo;
        private int xd;
        private int yd;
        private int wheel;
        public int X => xo;
        public int Y => yo;
        public int DX
        {
            get
            {
                int dx = xd;
                xd = 0;
                return dx;
            }
        }
        public int DY
        {
            get
            {
                int dy = yd;
                yd = 0;
                return dy;
            }
        }
        public int Wheel
        {
            get
            {
                int w = wheel;
                wheel = 0;
                return w;
            }
        }
        public int EventButton => currentEvent.Button;
        public bool EventState => currentEvent.State;
        public bool Captured
        {
            get => glfwGetInputMode(window, GLFW_CURSOR) == GLFW_CURSOR_DISABLED;
            set => glfwSetInputMode(window, GLFW_CURSOR, value ? GLFW_CURSOR_DISABLED : GLFW_CURSOR_NORMAL);
        }

        private struct MouseButtonEvent
        {
            public int Button;
            public bool State;
            public bool Valid;
        }

        public void Init(nint window)
        {
            this.window = window;
            if (glfwRawMouseMotionSupported() != GLFW_FALSE)
                glfwSetInputMode(window, GLFW_RAW_MOUSE_MOTION, GLFW_TRUE);
            glfwSetCursorPosCallback(window, positionCallback = PositionCallback);
            glfwSetMouseButtonCallback(window, buttonCallback = ButtonCallback);
            glfwSetScrollCallback(window, scrollCallback = ScrollCallback);
        }

        private void PositionCallback(nint _, double xpos, double ypos)
        {
            int x = (int)xpos;
            int y = (int)ypos;
            int xd = x - xo;
            int yd = y - yo;
            if (Captured)
            {
                this.xd += xd;
                this.yd -= yd;   
            }
            else
            {
                this.xd = xd;
                this.yd = yd;   
            }
            xo = x;
            yo = y;
        }

        private void ButtonCallback(nint _, int button, int action, int mods)
        {
            lock (eventLock)
            {
                buttons[button] = action == GLFW_PRESS;
                events.Enqueue(new()
                {
                    Button = button,
                    State = buttons[button],
                    Valid = true
                });
            }
        }
        
        private void ScrollCallback(nint _, double xoffset, double yoffset)
            => wheel += (int)yoffset;
        
        public bool Next()
        {
            lock (eventLock)
            {
                if (events.Count == 0)
                {
                    currentEvent.Valid = false;
                    return false;
                }
                while (events.Count > 0 && !(currentEvent = events.Dequeue()).Valid);
                if (events.Count == 0 && !currentEvent.Valid)
                    return false;
                return true;   
            }
        }

        public bool GetState(int button) => buttons[button];
        
        public void Dispose()
        {
            glfwSetCursorPosCallback(window, null);
            glfwSetMouseButtonCallback(window, null);
            glfwSetScrollCallback(window, null);
            positionCallback = null;
            buttonCallback = null;
            scrollCallback = null;
        }
    }
}