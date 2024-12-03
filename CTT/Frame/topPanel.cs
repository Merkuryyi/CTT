namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class topPanel
{
    private static Clock clock;
    private static float clickDelay;
    private Database database;
    private FlagFrames flagFrames;
    private Vector2i mousePosition;
    private Button backgroundProfile;
    private Button photoProfile;
    private static bool canClick;
    public void Display(RenderWindow _window)
    {
        
  
    }

    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;   
        database = new Database();
        flagFrames = new FlagFrames();
        
        Texture backgroundProfileArea =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundProfileTop.png"));
        Texture photoProfileArea =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "profilePfotoArea.png"));
        Texture backgroundLogoArea =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundLogo.png"));
        Texture logo =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "logo.png"));
        
        Texture backgroundSearchArea =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundSearch.png"));
        Texture backgroundMiniArea =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backroundMiniTop.png"));
        Texture backgroundMiniAreaPart =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backroundMiniTopPart.png"));
        Texture backgroundCatalog =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundCatalog.png"));
        Texture serchIcon =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "searchIcon.png"));
        
        Texture fartherIcon =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fartherIcon.png"));
        
        
        backgroundProfile = new Button(53, 53, backgroundProfileArea);
        photoProfile = new Button(68, 79, photoProfileArea);
    }

    private void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        clic();
    }
    public void workProgram(RenderWindow _window)
    {
        Display(_window);
        ButtonInteraction(_window);
    }
    public void clic()
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }
    }
}