using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Runtime.InteropServices;

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
   
    public static void Main(string[] args)
    {
      RenderWindow  _window = Form();
     // Frame1 frame1 = new Frame1();
       
    //  frame1.Run1(_window);
       
       
   Frame4 frame4 = new Frame4();
  frame4.Run4(_window);
 //  Frame3 frame3 = new Frame3();
 // frame3.Run3(_window);
    // Frame2 frame2 = new Frame2();
   // frame2.Run2(_window);
    }




}

