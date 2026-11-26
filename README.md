# QuickGL
Straightforward OpenGL and OpenAL bindings for C# targeting .NET 10<br>

# Bindings
The bindings are automatically generated based on the official OpenGL registry and AL/ALC headers<br>
Bindings are exported with pointers, so **unsafe code is required**<br>
You **must** first generate the bindings by running `QGLBindingsGen`

# Utilities
QuickGL includes some optional utilities to help you out with common tasks:
- `QGLString`, to ease the interop between native strings (`byte*`) and managed strings
- `PtrHelper`, to help you use the fast stack memory (`stackalloc`) with AL/GL functions
