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
        RenderWindow window = new RenderWindow(new VideoMode(videoMode.Width, customHeight), "STT");
        window.Closed += (sender, e) => window.Close();
        window.Resized += OnResize;
        return window;
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
    { _window.DispatchEvents(); }
    public static MainPage mainPage;
    public static PayTravelTicket payTravelTicket;
    public static void Main()
    {
        RenderWindow window = Form();
        bool fastLogin = !IsFileFilledWithZeros();
        InputLine inputLine = new InputLine();
        TopPanel topPaneles = new TopPanel();
        InitialPage initialPage = new InitialPage();
        Registration registration = new Registration();
        ConfirmationRegistration confirmationRegistration = new ConfirmationRegistration();
        Login login = new Login();
        PayTicket payTicket = new PayTicket();
        Catalog catalog = new Catalog();
        News news = new News();
        Profile profiles = new Profile();
        mainPage = new MainPage();
        payTravelTicket = new PayTravelTicket();
        topPaneles.Structure();
        initialPage.Structure();
        registration.Structure();  
        confirmationRegistration.Structure();
        login.Structure();
        login.restoreAccessSructure();
        mainPage.Structure();
        mainPage.UpdateTickets();
        payTicket.Structure();
        payTravelTicket.Structure();
        catalog.Structure();
        news.Structure();
        profiles.Structure();
        window.KeyPressed += inputLine.OnKeyPressedName;
        if (fastLogin)
        { frame5 = true; }
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
        while (window.IsOpen)
        {    
            window.Clear(new Color(230, 230, 230));
            Ivents(window);
            if (frame1)
            { initialPage.workProgram(window); }
            if (frame2)
            { registration.workProgram(window); }
            if (frame3)
            { confirmationRegistration.workProgram(window); }
            if (frame4)
            { login.workProgram(window); }
            if (frame5)
            { mainPage.workProgram(window); }
            if (frame6)
            { payTicket.workProgram(window); }
            if (frame7)
            { payTravelTicket.workProgram(window); }
            if (frame8)
            { news.workProgram(window); }
            if (frame9)
            { catalog.workProgram(window); }
            if (profile)
            { profiles.workProgram(window); }
            if (topPanel)
            { topPaneles.workProgram(window); }
            window.Display();
        }
    }
}

