using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Runtime.InteropServices;

public class MainForm
{ 
    
    [DllImport("user32.dll")]
    private static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll")]
    private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    private static readonly IntPtr HWND_TOP = IntPtr.Zero;
    private const uint SWP_NOSIZE = 0x0001;
    public static RenderWindow Form()
    {
      
        
         VideoMode videoMode = VideoMode.DesktopMode;
        
        uint customHeight = videoMode.Height; 
            
       RenderWindow _window = new RenderWindow(new VideoMode(videoMode.Width, customHeight), "STT");
       _window.Closed += (sender, e) => _window.Close();
       _window.Resized += OnResize;
       SetWindowToTopLeft(_window);
       
       return _window;
    }
   
    static void OnResize(object sender, SizeEventArgs e)
    {
        RenderWindow window = (RenderWindow)sender;
        FloatRect visibleArea = new FloatRect(0, 0, e.Width, e.Height);
        window.SetView(new View(visibleArea));
    }
   
    public static void Main(string[] args)
    {
      RenderWindow  _window = Form();
       // Frame1 frame1 = new Frame1();
       
      // frame1.Run1(_window);
       
       
     //Frame4 frame4 = new Frame4();
    //frame4.Run4(_window);
    // Frame3 frame3 = new Frame3();
   //   frame3.Run3(_window);
     Frame2 frame2 = new Frame2();
    frame2.Run2(_window);
    }
    static void SetWindowToTopLeft(RenderWindow window)
    {
        IntPtr windowHandle = GetForegroundWindow();
        int x = 0; 
        int y = 0; 
        SetWindowPos(windowHandle, HWND_TOP, x, y, (int)window.Size.X, (int)window.Size.Y, SWP_NOSIZE);
    }



}

