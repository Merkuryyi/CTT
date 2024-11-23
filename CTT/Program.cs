using System.Diagnostics.CodeAnalysis;
using SFML.Graphics;
using SFML.Window;

public class MainForm
{
    public static RenderWindow Form()
    {
        VideoMode videoMode = VideoMode.DesktopMode;
        uint customHeight = videoMode.Height; 
        RenderWindow _window = new RenderWindow(new VideoMode(videoMode.Width, customHeight), "STT");
        _window.Closed += (sender, e) => _window.Close();
        _window.Resized += OnResize;

        return _window;
    }

    static void OnResize(object sender, SizeEventArgs e)
    {
        RenderWindow window = (RenderWindow)sender;
        FloatRect visibleArea = new FloatRect(0, 0, e.Width, e.Height);
        window.SetView(new View(visibleArea));
    }

    [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.EventHandler`1[SFML.Window.KeyEventArgs]; size: 271MB")]
    public static void Main(string[] args)
    {
        RenderWindow  _window = Form();
        
        Frame1 frame1 = new Frame1();
        frame1.Sructure1();
        Frame2 frame2 = new Frame2();
        frame2. Structure();
        Frame3 frame3 = new Frame3();
        frame3.Structure();
       
        Frame4 frame4 = new Frame4();
        frame4.Structure();
        frame4.restoreAccessSructure();
     //   frame4.workProgram(_window);
         frame1.workProgram(_window);
         
        // frame3.workProgram(_window);
      
        // frame2.workProgram(_window);
    }




}

