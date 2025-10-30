using QuickGLNS;
using QuickGLNS.Bindings;
using static QuickGLNS.Bindings.LibUI;

namespace ExampleAppNS;

internal unsafe class Program
{
    private static uiWindow* window;

    static int OnShouldQuit(void* data)
    {
        uiControlDestroy((uiControl*)window);
        return 1;
    }

    static int OnClosing(uiWindow* w, void* data)
    {
        uiControlDestroy((uiControl*)window);
        uiQuit();
        return 0;
    }

    static void Main(string[] args)
    {
        QuickGL.InitRaw(null);
        QuickGL.LoadLibUI();

        uiInitOptions options = new();
        uiInit(&options);
        uiOnShouldQuit(OnShouldQuit, null);

        window = uiNewWindow(QGLString.CreatePool("Hello World"), 640, 480, 1);
        uiWindowOnClosing(window, OnClosing, null);
        uiControlShow((uiControl*)window);

        uiMain();
        // for some reason, this crashes
        //uiUninit();

        QuickGL.Destroy();
    }
}
