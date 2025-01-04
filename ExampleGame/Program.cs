using System.Runtime.InteropServices;
using QuickGLNS;
using static QuickGLNS.Bindings.GLFW;
using static QuickGLNS.Bindings.GL10;
using static QuickGLNS.Bindings.GL11;

namespace ExampleGameNS
{
    public unsafe class Program
    {
        public static void Main(string[] args)
        {
            QuickGL.Init();
            if (glfwInit() == GLFW_FALSE) throw new Exception("Failed to initialize GLFW");

            nint window = glfwCreateWindow(640, 480, new QGLString("Game"), 0, 0);
            if (window == 0) throw new Exception("Failed to create window");
            glfwMakeContextCurrent(window);
            QuickGL.LoadGL();

            glMatrixMode(GL_PROJECTION_MATRIX);
            glLoadIdentity();
            glMatrixMode(GL_MODELVIEW_MATRIX);
            glLoadIdentity();
            glViewport(0, 0, 640, 480);
            glClearColor(1.0F, 0.0F, 0.0F, 1.0F);
            
            while (glfwWindowShouldClose(window) == GLFW_FALSE)
            {
                glClear(GL_COLOR_BUFFER_BIT);
                glColor3f(1.0F, 1.0F, 1.0F);
                glBegin(GL_TRIANGLES);
                glVertex2f(-0.5F, -0.5F);
                glVertex2f(0.5F, -0.5F);
                glVertex2f(0.0F, 0.5F);
                glEnd();
                
                glfwPollEvents();
                glfwSwapBuffers(window);
            }

            glfwDestroyWindow(window);
            glfwTerminate();
            QuickGL.Destroy();
        }
    }
}