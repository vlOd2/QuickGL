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

using QuickGLNS.Internal;

namespace QuickGLNS;

/// <summary>
/// Easy to use, optional, input wrapper for GLFW
/// </summary>
public static class Input
{
    private static Dictionary<nint, IMouse> mouse = [];
    private static Dictionary<nint, IKeyboard> keyboard = [];

    private static void EnsureCreated(nint window)
    {
        if (mouse.ContainsKey(window) && keyboard.ContainsKey(window))
            return;
        throw new ArgumentException("Window does not have an input system");
    }

    /// <summary>
    /// Initializes the input system for the given window
    /// </summary>
    /// <param name="window">the window</param>
    /// <exception cref="ArgumentException">if an input system is already assigned</exception>
    public static void Create(nint window)
    {
        if (!QuickGL.initialized)
            throw new GLException("QuickGL not initialized");
        if (QuickGL.doNotUseGLFW)
            throw new InvalidOperationException("QuickGL initialized without GLFW");
        if (mouse.ContainsKey(window) && keyboard.ContainsKey(window))
            throw new ArgumentException("Window already has an input system");
        mouse[window] = new Mouse();
        mouse[window].Init(window);
        keyboard[window] = new Keyboard();
        keyboard[window].Init(window);
    }

    /// <summary>
    /// Gets the first available mouse<br/>
    /// Useful if you have only a single window
    /// </summary>
    /// <returns>the mouse</returns>
    /// <exception cref="InvalidOperationException">if there is no mouse available</exception>
    public static IMouse GetFirstMouse()
    {
        if (mouse.Count == 0)
            throw new InvalidOperationException("No mouse has been created");
        return mouse.First().Value;
    }

    /// <summary>
    /// Gets the first available keyboard<br/>
    /// Useful if you have only a single window
    /// </summary>
    /// <returns>the keyboard</returns>
    /// <exception cref="InvalidOperationException">if there are no keyboards available</exception>
    public static IKeyboard GetFirstKeyboard()
    {
        if (keyboard.Count == 0)
            throw new InvalidOperationException("No keyboards have been created");
        return keyboard.First().Value;
    }

    /// <summary>
    /// Gets the mouse associated with the given window
    /// </summary>
    /// <param name="window">the window</param>
    /// <returns>the mouse</returns>
    /// <exception cref="ArgumentException">if an input system is not assigned</exception>
    public static IMouse GetMouse(nint window)
    {
        EnsureCreated(window);
        return mouse[window];
    }

    /// <summary>
    /// Gets the keyboard associated with the given window
    /// </summary>
    /// <param name="window">the window</param>
    /// <returns>the keyboard</returns>
    /// <exception cref="ArgumentException">if an input system is not assigned</exception>
    public static IKeyboard GetKeyboard(nint window)
    {
        EnsureCreated(window);
        return keyboard[window];
    }

    /// <summary>
    /// Destroys the input system allocated for the given window
    /// </summary>
    /// <param name="window">the window</param>
    public static void Destroy(nint window)
    {
        if (mouse.ContainsKey(window))
            mouse[window].Dispose();
        if (keyboard.ContainsKey(window))
            keyboard[window].Dispose();
        mouse.Remove(window);
        keyboard.Remove(window);
    }
}