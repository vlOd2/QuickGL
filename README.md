# ℹ QuickGL
Straightforward OpenGL and GLFW bindings for C# targeting .NET 8<br>
The main goal is to keep the experience as similar to C/C++ as possible<br>
This meant exporting the bindings with pointers, so **unsafe code is required**

# 🤔 Why is it called QuickGL?
Because with QuickGL, you can be writing OpenGL code in minutes<br>

More information is available on the wiki, but you can get a GLFW window and OpenGL context with just 5 lines of code:
```
QuickGL.Init();
glfwInit();
nint window = glfwCreateWindow(640, 480, new QGLString("Game"), 0, 0);
glfwMakeContextCurrent(window);
QuickGL.LoadGL();
```

# 🔧 Utilities
QuickGL includes some utilities to try and speed up your development times:
- `QGLString`, to ease the interop between native strings (`byte*`) and managed strings
- `QuickGL::ToPtr`, to help you use the fast stack memory (`stackalloc`) with GLFW/GL functions
- `Input`, a wrapper around GLFW for keyboard and mouse input

# ⚙ Bindings
The bindings are automatically generated based on the official GLFW header and OpenGL registry<br>
You may generate your own custom bindings using [QGLBindingsGen](https://github.com/vlOd2/QGLBindingsGen)

# ⚖ License
This project is licensed under the MIT license
<br>
You may refer to the "LICENSE" file for more information
