using System.Reflection;
using System.Runtime.InteropServices;
using QuickGLNS.Bindings;
using QuickGLNS.Internal;

namespace QuickGLNS
{
    public unsafe class QuickGL
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
        /// <exception cref="Exception"></exception>
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
        /// </summary>
        public static void LoadGL()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetCustomAttribute<GLFeature>() == null)
                    continue;
                
                foreach (FieldInfo field in type.GetFields(BINDING_FLAGS))
                {
                    QGLNativeAPI nativeAPI = field.GetCustomAttribute<QGLNativeAPI>();
                    if (nativeAPI == null) continue;
                    nint handle = (nint)GLFW.glfwGetProcAddress(new QGLString(nativeAPI.Name));
                    if (handle == nint.Zero)
                    {
                        Console.Error.WriteLine($"Could not find GL method: {nativeAPI.Name}");
                        continue;
                    }
                    field.SetValue(null, handle);
                }
            }
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
    }
}