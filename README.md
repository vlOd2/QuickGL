# ⚠ Not yet ready for production
This project is not yet done and lacks some pretty important features and QoL improvements

# QuickGL
Straightforward OpenGL and GLFW bindings for C# targeting .NET 8<br>
It's main goal is to keep the experience as similar to C/C++ as possible<br>
QuickGL exports it's bindings with pointers, so **unsafe code is required**

With QuickGL, you can be writing OpenGL code in minutes<br>
You can get a GLFW window and OpenGL context with just 5 lines of code:
```
QuickGL.Init();
glfwInit();
nint window = glfwCreateWindow(640, 480, new QGLString("Game"), 0, 0);
glfwMakeContextCurrent(window);
QuickGL.LoadGL();
```

# Utilities
QuickGL includes some utilities to try and speed up your development times<br>
These include:
- Easy to use native string interop (QGLString)
- Methods to convert stack allocated spans to pointers (QuickGL::ToPtr)
- Easy to use, optional, input wrapper for GLFW (Input)

# Bindings
The bindings used by QuickGL are automatically generated based on the official GLFW header and OpenGL registry<br>
You may generate your own custom bindings using [QGLBindingsGen](https://github.com/vlOd2/QGLBindingsGen)

# ⚖ License
This project is licensed under the MIT license
<br>
You may refer to the "LICENSE" file for more information
