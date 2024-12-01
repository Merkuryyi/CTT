namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using System.IO;
using System.Text.Json;
public class MainForm
{
    public static bool frame1;
    public static bool frame2 = false;
    public static bool frame3 = false;
    public static bool frame4 = false;
    public static bool profile;
    private static string filePath = "userdata.json";
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
    public static bool IsFileFilledWithZeros()
    {
        string json = File.ReadAllText(filePath);
        UserData loginData = JsonSerializer.Deserialize<UserData>(json);
        return loginData.Name == "0" &&
               loginData.Lname == "0" &&
               loginData.Email == "0" &&
               loginData.Password == "0" &&
               loginData.PhoneNumber == "0";
    }
    public static void Ivents(RenderWindow _window)
    {
        _window.DispatchEvents();
    }
    public static void Main(string[] args)
    {
        RenderWindow _window = Form();
        bool fastLogin = !IsFileFilledWithZeros();
 
        InputLine inputLine = new InputLine();
        _window.KeyPressed += inputLine.OnKeyPressedName;
        Frame1 frames1 = new Frame1();
        frames1.Structure();
        Frame2 frames2 = new Frame2();
        frames2.Structure();
        Frame3 frames3 = new Frame3();
        frames3.Structure();
        Frame4 frames4 = new Frame4();
        frames4.Structure();
        frames4.restoreAccessSructure();
        Profile profiles = new Profile();
        profiles.Structure();
        if (fastLogin)
        {
            profile = true;
        }
        else if (!fastLogin)
        { 
            frame1 = true;
        }
        while (_window.IsOpen)
        {  
            Ivents(_window);
            if (frame1)
            { frames1.workProgram(_window); }
            if (frame2)
            { frames2.workProgram(_window); }
            if (frame3)
            { frames3.workProgram(_window); }
            if (frame4)
            { frames4.workProgram(_window); }
            if (profile)
            { profiles.workProgram(_window); }
            _window.Display();
        }
    }
}

