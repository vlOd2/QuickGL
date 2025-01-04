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

namespace QuickGLNS
{
    /// <summary>
    /// Simple event-queue based keyboard for GLFW
    /// </summary>
    public interface IKeyboard : IDisposable
    {
        /// <summary>
        /// The key of the current event<br/>
        /// Undefined if the current event is a character event<br/>
        /// See <see cref="EventState"/> and <see cref="KeyState"/>
        /// to check for a character event
        /// </summary>
        public int EventKey { get; }
        /// <summary>
        /// The character of the current event<br/>
        /// Undefined if the current event is not a character event<br/>
        /// See <see cref="EventState"/> and <see cref="KeyState"/>
        /// to check for a character event
        /// </summary>
        public char EventChar { get; }
        /// <summary>
        /// The key state of the current event
        /// </summary>
        public KeyState EventState { get; }

        void Init(nint window);

        void Poll();

        /// <summary>
        /// De-queues the next event<br/>
        /// NOTE: Accessing any event information 
        /// when this returns false is undefined
        /// </summary>
        /// <returns>if an event was de-queued</returns>
        bool Next();

        /// <summary>
        /// Checks if a key is pressed
        /// </summary>
        /// <param name="key">the key</param>
        /// <returns>true if the key is pressed, false if otherwise</returns>
        bool GetState(int key);

        /// <summary>
        /// Gets the friendly name of a key
        /// </summary>
        /// <param name="key">the key</param>
        /// <returns>the friendly name or null</returns>
        QGLString GetName(int key);
    }
}