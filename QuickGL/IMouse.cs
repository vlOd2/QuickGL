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

namespace QuickGLNS;

/// <summary>
/// Simple event-queue based mouse for GLFW
/// </summary>
public unsafe interface IMouse : IDisposable
{
    #region General properties
    /// <summary>
    /// The X position relative to the top-left corner of the window
    /// </summary>
    int X { get; }
    /// <summary>
    /// The Y position relative to the top-left corner of the window
    /// </summary>
    int Y { get; }
    /// <summary>
    /// The X movement since this was last queried 
    /// </summary>
    int DX { get; }
    /// <summary>
    /// The Y movement since this was last queried 
    /// </summary>
    int DY { get; }
    /// <summary>
    /// The vertical wheel scroll amount since this was last queried
    /// </summary>
    int Wheel { get; }
    #endregion
    #region Event properties
    /// <summary>
    /// The button of the current event
    /// </summary>
    int EventButton { get; }
    /// <summary>
    /// The pressed state of the current event
    /// </summary>
    bool EventState { get; }
    #endregion
    /// <summary>
    /// Whether the mouse is captured and confined to the center of the window or not
    /// </summary>
    bool Captured { get; set; }

    void Init(GLFWwindow* window);

    /// <summary>
    /// De-queues the next event<br/>
    /// NOTE: Accessing any event information 
    /// when this returns false is undefined
    /// </summary>
    /// <returns>if an event was de-queued</returns>
    bool Next();

    /// <summary>
    /// Checks if a button is pressed
    /// </summary>
    /// <param name="button">the ID of the button</param>
    /// <returns></returns>
    bool GetState(int button);
}