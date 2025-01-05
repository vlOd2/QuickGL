using QuickGLNS;
using QuickGLNS.Bindings;
using static QuickGLNS.Bindings.GLFW;
using static QuickGLNS.Bindings.GL10;
using static QuickGLNS.Bindings.GL11;
using static QuickGLNS.Bindings.GL15;
using static QuickGLNS.Bindings.GL20;
using static QuickGLNS.Bindings.GL30;

namespace ExampleGameNS
{
    public unsafe class Program
    {
        private const string VERTEX_SHADER = """
            #version 330 core
        
            layout (location = 0) in vec3 vertex;
            layout (location = 1) in vec3 color;
            
            out vec3 fragColor;
            
            void main() {
                gl_Position = vec4(vertex, 1.0F);
                fragColor = color;
            }
        """;
        private const string FRAGMENT_SHADER = """
            #version 330 core

            in vec3 fragColor;
            out vec4 resultColor;

            void main() {
                resultColor = vec4(fragColor, 1.0F);
            }
        """;
        private nint window;
        private int width;
        private int height;
        // Need to keep a reference otherwise the GC will collect it
        private GLFWwindowsizefun sizeCallback;
        
        private static uint CompileShader(uint type, string source)
        {
            uint shader = glCreateShader(type);
            byte* str = new QGLString(source);
            glShaderSource(shader, 1, &str, (int*)0);
            glCompileShader(shader);
            
            int compileStatus = 0;
            str = new QGLString(512);
            glGetShaderiv(shader, GL_COMPILE_STATUS, &compileStatus);
            if (compileStatus == GL_FALSE)
            {
                glGetShaderInfoLog(shader, 512, (int*)0, str);
                Console.Error.WriteLine((QGLString)str);
            }

            return shader;
        }
        
        private static uint LinkProgram()
        {
            uint vertShader = CompileShader(GL_VERTEX_SHADER, VERTEX_SHADER);
            uint fragShader = CompileShader(GL_FRAGMENT_SHADER, FRAGMENT_SHADER);
            uint program = glCreateProgram();
            glAttachShader(program, vertShader);
            glAttachShader(program, fragShader);
            
            glLinkProgram(program);
            glDeleteShader(vertShader);
            glDeleteShader(fragShader);
            
            int success = 0;
            byte* str = new QGLString(512);
            glGetProgramiv(program, GL_LINK_STATUS, &success);
            if (success == GL_FALSE) 
            {
                glGetProgramInfoLog(program, 512, (int*)0, str);
                Console.Error.WriteLine((QGLString)str);
            }

            return program;
        }

        private void WindowResized(nint _, int width, int height)
        {
            Console.WriteLine($"Resized to {width}x{height}");
            glViewport(0, 0, width, height);
            this.width = width;
            this.height = height;
        }

        private void Init()
        {
            QuickGL.Init();
            if (glfwInit() == GLFW_FALSE) 
                throw new Exception("Failed to initialize GLFW");

            // The driver usually picks the latest version
            // glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 3);
            // glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 2);
            // glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);

            width = 640;
            height = 480;
            window = glfwCreateWindow(width, height, new QGLString("QuickGL - Example Game"), 0, 0);
            if (window == 0) throw new Exception("Failed to create window");
            glfwSetWindowSizeCallback(window, sizeCallback = WindowResized);

            glfwMakeContextCurrent(window);
            QuickGL.LoadGL();
            Input.Create(window);

            Console.WriteLine($"Vendor: {new QGLString(glGetString(GL_VENDOR)).Data}");
            Console.WriteLine($"Version: {new QGLString(glGetString(GL_VERSION)).Data}");
            Console.WriteLine($"Renderer: {new QGLString(glGetString(GL_RENDERER)).Data}");
            Console.WriteLine($"QGL parsed version: {QuickGL.GLVersionMajor}.{QuickGL.GLVersionMinor}");
            
            if (!QuickGL.IsGLVersionAvailable(3, 0))
                throw new Exception("Required OpenGL version is not available");
        }
        
        public void Run()
        {
            Init();

            ReadOnlySpan<float> data = [
                // Vertices         Colors
                -0.5F, -0.5F, 0.0F, 1.0F, 0.0F, 0.0F,
                0.5F, -0.5F, 0.0F,  0.0F, 1.0F, 0.0F,
                0.0F, 0.5F, 0.0F,   0.0F, 0.0F, 1.0F
            ];
            
            uint vao = 0;
            uint vbo = 0;
            glGenVertexArrays(1, &vao);
            glGenBuffers(1, &vbo);
            glBindVertexArray(vao);
            
            glBindBuffer(GL_ARRAY_BUFFER, vbo);
            glBufferData(GL_ARRAY_BUFFER, data.Length * sizeof(float), QuickGL.ToPtr(data), GL_STATIC_DRAW);
            glVertexAttribPointer(0, 3, GL_FLOAT, false, 6 * sizeof(float), (void*)0);
            glEnableVertexAttribArray(0);
            glVertexAttribPointer(1, 3, GL_FLOAT, false, 6 * sizeof(float), (void*)(3 * sizeof(float)));
            glEnableVertexAttribArray(1);

            uint program = LinkProgram();
            glViewport(0, 0, width, height);
            glClearColor(0.3F, 0.5F, 0.8F, 1.0F);
            
            while (glfwWindowShouldClose(window) == GLFW_FALSE)
            {
                IKeyboard keyboard = Input.GetKeyboard(window);
                while (keyboard.Next())
                {
                    Console.WriteLine($"{keyboard.EventKey} {keyboard.EventChar} {keyboard.EventState}");
                    if (!keyboard.IsPressedEvent) 
                        continue;
                    if (keyboard.EventKey == GLFW_KEY_R)
                    {
                        keyboard.AllowRepeatEvents = !keyboard.AllowRepeatEvents;
                        Console.WriteLine($"Repeat events: {keyboard.AllowRepeatEvents}");
                    }
                    if (keyboard.EventKey == GLFW_KEY_F)
                    {
                        keyboard.FastMode = !keyboard.FastMode;
                        Console.WriteLine($"Fast mode: {keyboard.FastMode}");
                    }
                }
                
                glClear(GL_COLOR_BUFFER_BIT);
                glUseProgram(program);
                glBindVertexArray(vao);
                glDrawArrays(GL_TRIANGLES, 0, data.Length / 6);
                
                glfwPollEvents();
                glfwSwapBuffers(window);
                
                // If you uncomment this, it will force the GC to be aggresive
                // You can use this to test the callbacks as this would 
                // cause a non-referenced callback to become null, resulting in a crash
                // GC.AddMemoryPressure(uint.MaxValue);
                // GC.Collect();
                // GC.RemoveMemoryPressure(uint.MaxValue);
            }

            Input.Destroy(window);
            glfwDestroyWindow(window);
            glfwTerminate();
            sizeCallback = null;
            QuickGL.Destroy();
        }
        
        public static void Main(string[] args) => new Program().Run();
    }
}