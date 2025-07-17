# QuickGL
Straightforward GLFW, OpenGL and OpenAL bindings for C# targeting .NET 8<br>
The main goal is to keep the experience as similar to C/C++ as possible<br>
This meant exporting the bindings with pointers, so **unsafe code is required**

# Example
More information is available on the wiki, but you can get a GLFW window and OpenGL context with just 5 lines of code:
```
QuickGL.Init();
glfwInit();
nint window = glfwCreateWindow(640, 480, new QGLString("Game"), 0, 0);
glfwMakeContextCurrent(window);
QuickGL.LoadGL();
```

# Utilities
QuickGL includes some utilities to help you out with repetitive tasks:
- `QGLString`, to ease the interop between native strings (`byte*`) and managed strings
- `QuickGL::ToPtr`, to help you use the fast stack memory (`stackalloc`) with GLFW/GL functions
- `Input`, a wrapper around GLFW for keyboard and mouse input

>[!NOTE]
>All of these are optional and you can just use QuickGL for the bindings just fine without them

# Bindings
The bindings are automatically generated based on the official GLFW, AL/ALC headers and OpenGL registry<br>
You may generate your own custom bindings using [QGLBindingsGen](https://github.com/vlOd2/QGLBindingsGen)
