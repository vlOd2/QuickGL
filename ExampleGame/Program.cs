using System.Numerics;
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
            
            uniform float time;
            uniform mat4 projMatrix;
            uniform mat4 viewMatrix;
            
            out vec3 fragColor;
            
            void main() {
                gl_Position = projMatrix * viewMatrix * vec4(vertex, 1.0F);
                fragColor = color * sin(time);
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
        private float cameraX;
        private float cameraY;
        private float cameraZ;
        private float cameraYaw;
        private float cameraPitch;
        
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
            glfwSwapInterval(0);
            
            glfwMakeContextCurrent(window);
            QuickGL.LoadGL();
            Input.Create(window);
            Input.GetMouse(window).Captured = true;

            Console.WriteLine($"Vendor: {new QGLString(glGetString(GL_VENDOR)).Data}");
            Console.WriteLine($"Version: {new QGLString(glGetString(GL_VERSION)).Data}");
            Console.WriteLine($"Renderer: {new QGLString(glGetString(GL_RENDERER)).Data}");
            Console.WriteLine($"QGL parsed version: {QuickGL.GLVersionMajor}.{QuickGL.GLVersionMinor}");
            
            if (!QuickGL.IsGLVersionAvailable(3, 0))
                throw new Exception("Required OpenGL version is not available");
        }

        private static float ToRad(float deg)
            => deg * ((float)Math.PI / 180);
        
        private void MoveCamera(float xa, float za, float speed)
        {
            float magnitude = xa * xa + za * za;
            if (magnitude < 0.01F) return;
            
            magnitude = speed / (float)Math.Sqrt(magnitude);
            xa *= magnitude;
            za *= magnitude;
            
            float sin = (float)Math.Sin(ToRad(cameraYaw));
            float cos = (float)Math.Cos(ToRad(cameraYaw));
            cameraX += xa * cos - za * sin;
            cameraZ += za * cos + xa * sin;
        }

        private void RotateCamera(float yaw, float pitch, float sensitivity)
        {
            cameraYaw += yaw * sensitivity;
            cameraPitch -= pitch * sensitivity;
            cameraPitch = Math.Clamp(cameraPitch, -90.0F, 90.0F);
        }

        private void HandleInput(float deltaTime)
        {
            IMouse mouse = Input.GetMouse(window);
            IKeyboard keyboard = Input.GetKeyboard(window);

            float xa = 0;
            float za = 0;
            if (keyboard.GetState(GLFW_KEY_W))
                za++;
            if (keyboard.GetState(GLFW_KEY_S))
                za--;
            if (keyboard.GetState(GLFW_KEY_A))
                xa++;
            if (keyboard.GetState(GLFW_KEY_D))
                xa--;

            MoveCamera(xa, za, 5.0F * deltaTime);
            RotateCamera(mouse.DX, mouse.DY, 15F * deltaTime);

            while (keyboard.Next())
            {
                if (!keyboard.IsPressedEvent) continue;

                switch (keyboard.EventKey)
                {
                    case GLFW_KEY_R:
                        cameraX = cameraY = cameraZ = cameraYaw = cameraPitch = 0.0F;
                        break;
                    case GLFW_KEY_ESCAPE:
                        mouse.Captured = !mouse.Captured;
                        break;
                }
            }
        }
        
        public void Run()
        {
            Init();

            ReadOnlySpan<float> data = [
                // Vertices         Colors
                -0.5F, -0.5F, -2.0F, 1.0F, 0.0F, 0.0F,
                0.5F, -0.5F, -2.0F,  0.0F, 1.0F, 0.0F,
                0.0F, 0.5F, -2.0F,   0.0F, 0.0F, 1.0F,
                
                -0.5F, -0.5F, -2.0F, 1.0F, 0.0F, 0.0F,
                0.0F, 0.5F, -2.0F,   0.0F, 0.0F, 1.0F,
                0.5F, -0.5F, -2.0F,  0.0F, 1.0F, 0.0F
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
            glEnable(GL_CULL_FACE);

            float deltaTime = 0.0F;
            while (glfwWindowShouldClose(window) == GLFW_FALSE)
            {
                double startTime = glfwGetTime();
                HandleInput(deltaTime);
                
                Matrix4x4 proj = Matrix4x4.CreatePerspectiveFieldOfView(
                    ToRad(70.0F), 
                    width / (float)height,
                    0.01F,
                    100F);
                Matrix4x4 view = Matrix4x4.Identity;
                view *= Matrix4x4.CreateTranslation(cameraX, cameraY, cameraZ);
                view *= Matrix4x4.CreateRotationY(ToRad(cameraYaw));
                view *= Matrix4x4.CreateRotationX(ToRad(cameraPitch));
                
                int timeUniform = glGetUniformLocation(program, new QGLString("time"));
                int projUniform = glGetUniformLocation(program, new QGLString("projMatrix"));
                int viewUniform = glGetUniformLocation(program, new QGLString("viewMatrix"));
                glUniform1f(timeUniform, (float)glfwGetTime());
                glUniformMatrix4fv(projUniform, 1, false, &proj.M11);
                glUniformMatrix4fv(viewUniform, 1, false, &view.M11);
                
                glClear(GL_COLOR_BUFFER_BIT);
                glUseProgram(program);
                glBindVertexArray(vao);
                glDrawArrays(GL_TRIANGLES, 0, data.Length / 6);
                
                glfwPollEvents();
                glfwSwapBuffers(window);
                deltaTime = (float)(glfwGetTime() - startTime);
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