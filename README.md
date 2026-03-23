>[!WARNING]
>I have stopped maintaining QuickGL to focus my attention on a pure C# windowing library<br/>
>QuickGL should still work just fine for a long time, I will just not be improving the quality of the bindings<br/>
>It can be used only for OpenGL bindings (without GLFW or AL), so it may be still useful to some people

# QuickGL
Straightforward GLFW, OpenGL and OpenAL bindings for C# targeting .NET 8<br>

# Bindings
The bindings are automatically generated based on the official GLFW, AL/ALC headers and OpenGL registry<br>
Bindings are exported with pointers, so **unsafe code is required**<br>
You may generate your own custom bindings using `QGLBindingsGen` and replace the contents of the `Bindings` folder

# Example
More information is available on the wiki, but you can get a GLFW window and OpenGL context with just 5 lines of code:
```
QGL.Init();
glfwInit();
nint window = glfwCreateWindow(640, 480, new QGLString("Game"), 0, 0);
glfwMakeContextCurrent(window);
QGL.LoadGL();
```

# Utilities
QuickGL includes some utilities to help you out with common tasks:
- `QGLString`, to ease the interop between native strings (`byte*`) and managed strings
- `PtrHelper`, to help you use the fast stack memory (`stackalloc`) with GLFW/GL functions
- `Input`, an easy to use event polling oriented wrapper around GLFW for keyboard and mouse input

>[!NOTE]
>All of these are optional and you can just use QuickGL for the bindings just fine without them
