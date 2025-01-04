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
using System.Runtime.InteropServices;
using QuickGLNS.Bindings;
using QuickGLNS.Internal;

namespace QuickGLNS
{
    public static unsafe class QuickGL
    {
        private const BindingFlags BINDING_FLAGS = BindingFlags.Public | BindingFlags.Static;
        private static IGLFWLoader glfwLoader;

        private static void SetupLoader()
        {
            PlatformID platform = Environment.OSVersion.Platform;
            switch (platform)
            {
                case PlatformID.Win32NT:
                    glfwLoader = new Win32GLFWLoader();
                    break;
                case PlatformID.Unix:
                    glfwLoader = new UnixGLFWLoader();
                    break;
                default:
                    throw new PlatformNotSupportedException();
            }
        }
        
        /// <summary>
        /// Initializes QuickGL and loads GLFW functions
        /// </summary>
        /// <exception cref="Exception">if a GLFW method could not be found</exception>
        public static void Init()
        {
            SetupLoader();
            
            foreach (FieldInfo field in typeof(GLFW).GetFields(BINDING_FLAGS))
            {
                QGLNativeAPI nativeAPI = field.GetCustomAttribute<QGLNativeAPI>();
                if (nativeAPI == null) continue;
                nint handle = glfwLoader.GetProcAddress(nativeAPI.Name);
                if (handle == nint.Zero)
                    throw new Exception($"Could not find GLFW method: {nativeAPI.Name}");
                field.SetValue(null, handle);
            }
        }

        /// <summary>
        /// Loads OpenGL functions<br/>
        /// NOTE: You must have an active OpenGL context, see <see cref="GLFW.glfwMakeContextCurrent"/>
        /// <returns>the types of the loaded OpenGL bindings that you may use</returns>
        /// </summary>
        public static List<Type> LoadGL()
        {
            List<Type> loaded = [];
            
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetCustomAttribute<GLFeature>() == null)
                    continue;

                bool failed = false;
                foreach (FieldInfo field in type.GetFields(BINDING_FLAGS))
                {
                    QGLNativeAPI nativeAPI = field.GetCustomAttribute<QGLNativeAPI>();
                    if (nativeAPI == null) continue;
                    nint handle = GLFW.glfwGetProcAddress(new QGLString(nativeAPI.Name));
                    if (handle == nint.Zero)
                    {
                        failed = true;
                        break;
                    }
                    field.SetValue(null, handle);
                }

                if (failed) continue;
                loaded.Add(type);
            }

            return loaded;
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