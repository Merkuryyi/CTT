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
    public static bool profile = false;
    public static bool topPanel;
    public static bool frame9;
    public static bool frame8;
    public static bool frame7;
    public static bool frame6;
    public static bool frame5;
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
        topPanel topPaneles = new topPanel();
        topPaneles.Structure();
        InitialPage frames1 = new InitialPage();
        frames1.Structure();
        Registration frames2 = new Registration();
        frames2.Structure();
        ConfirmationRegistration frames3 = new ConfirmationRegistration();
        frames3.Structure();
        LogIn frames4 = new LogIn();
        frames4.Structure();
        frames4.restoreAccessSructure();
        MainPage mainPage = new MainPage();
        mainPage.Structure();
        PayTicket frames6 = new PayTicket();
        frames6.Structure();
       
        PayTravelTicket frames7 = new PayTravelTicket();
        frames7.Structure();
        Catalog frames9 = new Catalog();
        frames9.Structure();
        
        News frames8 = new News();
        frames8.Structure();
        
        Profile profiles = new Profile();
        profiles.Structure();
        if (fastLogin)
        {
            frame5 = true;

        }
        else if (!fastLogin)
        { topPanel = false; }

        if (frame9)
        { topPanel = true; }
        if (frame8)
        { topPanel = true; }
        if (frame7)
        { topPanel = true; }
        if (frame6)
        { topPanel = true; }
        if (frame5)
        { topPanel = true; }
        while (_window.IsOpen)
        {    
            _window.Clear(new Color(230, 230, 230));
            Ivents(_window);
            if (frame1)
            { frames1.workProgram(_window); }
            if (frame2)
            { frames2.workProgram(_window); }
            if (frame3)
            { frames3.workProgram(_window); }
            if (frame4)
            { frames4.workProgram(_window); }
            if (frame5)
            { mainPage.workProgram(_window); }
            if (frame6)
            { frames6.workProgram(_window); }
            if (frame7)
            { frames7.workProgram(_window); }
            if (frame8)
            { frames8.workProgram(_window); }
            if (frame9)
            { frames9.workProgram(_window); }
            if (profile)
            { profiles.workProgram(_window); }
            if (topPanel)
            { topPaneles.workProgram(_window); }
            
            
            
            _window.Display();
        }
    }
}

