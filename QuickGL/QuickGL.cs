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

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using QuickGLNS.Bindings;
using QuickGLNS.Internal;

namespace QuickGLNS
{
    public static unsafe class QuickGL
    {
        private const BindingFlags BINDING_FLAGS = BindingFlags.Public | BindingFlags.Static;
        private static GLFWLoader glfwLoader;
        private static bool initialized;
        /// <summary>
        /// The major version of the current OpenGL context
        /// </summary>
        public static int GLVersionMajor { get; private set; }
        /// <summary>
        /// The minor version of the current OpenGL context
        /// </summary>
        public static int GLVersionMinor { get; private set; }

        /// <summary>
        /// Initializes QuickGL and loads GLFW functions
        /// </summary>
        /// <exception cref="GLException">if GLFW could not be loaded successfully</exception>
        public static void Init()
        {
            glfwLoader = new GLFWLoader();
            
            foreach (FieldInfo field in typeof(GLFW).GetFields(BINDING_FLAGS))
            {
                QGLNativeAPI nativeAPI = field.GetCustomAttribute<QGLNativeAPI>();
                if (nativeAPI == null) continue;
                nint handle = glfwLoader.GetProcAddress(nativeAPI.Name);
                if (handle == nint.Zero)
                {
                    Destroy();
                    throw new GLException($"Could not find GLFW method: {nativeAPI.Name}");
                }
                field.SetValue(null, handle);
            }

            initialized = true;
        }

        private static void ParseGLVersion()
        {
            nint handle = GLFW.glfwGetProcAddress(new QGLString("glGetString"));
            if (handle == nint.Zero) 
                throw new GLException("Could not initialize OpenGL");
            
            GL10.glGetString = (delegate*unmanaged<uint, byte*>)handle;
            byte* strPtr = GL10.glGetString(GL10.GL_VERSION);
            if (strPtr == null) 
                throw new GLException("Invalid OpenGL context");
            
            Match match = Regex.Match(new QGLString(strPtr), @"(\d)\.(\d)(?:\.\d)?(?= )");
            if (!match.Success) throw new GLException("Could not figure out OpenGL version");
            GLVersionMajor = int.Parse(match.Groups[1].Value);
            GLVersionMinor = int.Parse(match.Groups[2].Value);
        }

        /// <summary>
        /// Loads OpenGL functions<br/>
        /// NOTE: You must have an active OpenGL context, see <see cref="GLFW.glfwMakeContextCurrent"/>
        /// </summary>
        /// <exception cref="GLException"></exception>
        public static void LoadGL()
        {
            if (!initialized)
                throw new GLException("Not initialized");
            if (GLFW.glfwGetCurrentContext() == 0)
                throw new GLException("No OpenGL context found");
            ParseGLVersion();
            
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetCustomAttribute<GLFeature>() == null)
                    continue;

                foreach (FieldInfo field in type.GetFields(BINDING_FLAGS))
                {
                    QGLNativeAPI nativeAPI = field.GetCustomAttribute<QGLNativeAPI>();
                    if (nativeAPI == null) continue;
                    nint handle = GLFW.glfwGetProcAddress(new QGLString(nativeAPI.Name));
                    // The result could be anything even if the command doesn't exist, so this is useless
                    // if (handle == nint.Zero) break;
                    field.SetValue(null, handle);
                }
            }
        }

        /// <summary>
        /// Checks if the given OpenGL version can be used
        /// </summary>
        /// <param name="major">the major part of the version</param>
        /// <param name="minor">the minor part of the version</param>
        /// <returns>true if the version can be used, false if otherwise</returns>
        /// <exception cref="GLException">if not initialized or no context is found</exception>
        public static bool IsGLVersionAvailable(int major, int minor)
        {
            if (!initialized)
                throw new GLException("Not initialized");
            if (GLFW.glfwGetCurrentContext() == 0 || GLVersionMajor == 0)
                throw new GLException("No OpenGL context found");
            return GLVersionMajor > major || (GLVersionMajor == major && GLVersionMinor >= minor);
        }

        /// <summary>
        /// Cleans up QuickGL and releases any OpenGL and GLFW functions
        /// </summary>
        public static void Destroy()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetCustomAttribute<GLFeature>() == null)
                    continue;
                
                foreach (FieldInfo field in type.GetFields(BINDING_FLAGS))
                {
                    QGLNativeAPI nativeAPI = field.GetCustomAttribute<QGLNativeAPI>();
                    if (nativeAPI == null) continue;
                    field.SetValue(null, nint.Zero);
                }
            }
            
            foreach (FieldInfo field in typeof(GLFW).GetFields(BINDING_FLAGS))
            {
                QGLNativeAPI nativeAPI = field.GetCustomAttribute<QGLNativeAPI>();
                if (nativeAPI == null) continue;
                field.SetValue(null, nint.Zero);
            }

            glfwLoader.Dispose();
            glfwLoader = null;
            GLVersionMajor = GLVersionMinor = 0;
            initialized = false;
        }
        
        /// <summary>
        /// Helper function to get a pointer to stack allocated span's data
        /// </summary>
        /// <param name="span">the span to convert</param>
        /// <typeparam name="T">the type of the span</typeparam>
        /// <returns>the pointer to the span's data</returns>
        public static T* ToPtr<T>(Span<T> span) where T : unmanaged
            => (T*)Unsafe.AsPointer(ref span.GetPinnableReference());

        /// <summary>
        /// Helper function to get a pointer to stack allocated read only span's data<br/>
        /// NOTE: Make sure the function accesing the returned pointer does not try to modify it
        /// </summary>
        /// <param name="span">the span to convert</param>
        /// <typeparam name="T">the type of the span</typeparam>
        /// <returns>the pointer to the span's data</returns>
        public static T* ToPtr<T>(ReadOnlySpan<T> span) where T : unmanaged
            => (T*)Unsafe.AsPointer(ref Unsafe.AsRef(in span.GetPinnableReference()));
    }
}