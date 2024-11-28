using SFML.Graphics;
using SFML.Window;
using SFML.System;
namespace CTT.Frame;

public class MainForm
{
    public static bool frame1 = false;
    public static bool frame2 = false;
    public static bool frame3 = false;
    public static bool frame4 = false;
    public static bool profile = true;
    
   

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
 
    public static void Ivents(RenderWindow _window)
    {
        
        _window.DispatchEvents();
        _window.Closed += (sender, _) => _window.Close();
      
    }
    public static void Main(string[] args)
    {
        
        RenderWindow  _window = Form();
        
        
      
        
        InputLine inputLine = new InputLine();
        _window.KeyPressed += inputLine.OnKeyPressedName;
        Frame1 frames1 = new Frame1();
        frames1.Sructure1();
        
        Frame2 frames2 = new Frame2();
        frames2.Structure();
        
        Frame3 frames3 = new Frame3();
        frames3.Structure();

       
        
       
        Frame4 frames4 = new Frame4();
        frames4.Structure();
        frames4.restoreAccessSructure();
        Profile profiles = new Profile();
        profiles.Structure();
    
      while (_window.IsOpen)
      {  
          Ivents(_window);
          
          if (frame1)
          {
              frames1.workProgram(_window);
          }

          if (frame2)
          {
              frames2.workProgram(_window);
          }
          if (frame3)
          {
              frames3.workProgram(_window);
          }
          if (frame4)
          {
              frames4.workProgram(_window);
              
          }
          if (profile)
          {
              profiles.workProgram(_window);
              
          }
          _window.Display();
      }

  
    }





}

