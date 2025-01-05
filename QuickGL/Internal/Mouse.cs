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
        private readonly bool[] buttons = new bool[3];
        private readonly Queue<MouseButtonEvent> events = [];
        private readonly object eventLock = new();
        private MouseButtonEvent currentEvent;
        private int xo;
        private int yo;
        private int xd;
        private int yd;
        public int X => xo;
        public int Y => yo;
        public int DX => xd;
        public int DY => yd;
        public int Wheel { get; }
        public int EventButton { get; }
        public bool EventState { get; }
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
                this.yd += yd;   
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
        }
        
        public bool Next()
        {
            lock (eventLock)
            {
                if (events.Count == 0)
                {
                    currentEvent = new();
                    return false;
                }
                while (events.Count > 0 && !(currentEvent = events.Dequeue()).Valid);
                if (events.Count == 0 && !currentEvent.Valid)
                    return false;
                return true;   
            }
        }

        public bool GetButtonState(int id) => false;
        
        public void Dispose()
        {
            glfwSetCursorPosCallback(window, null);
            glfwSetMouseButtonCallback(window, null);
            positionCallback = null;
            buttonCallback = null;
        }
    }
}