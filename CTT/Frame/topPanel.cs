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
    private Texts userNameOnPanel;
    private Texts nameProgramOnPanel;
    private Button logoProgram;
    private Button backgroundLogo;
    private Button backgroundSearch;
    private Button backgroundMini;
    private Button backgroundMiniPart;
    private Button searchProgram;
    private Texts searchOnPanel;
    private Texts refundOnPanel;
    private Texts detailsOnPanel;
    private Button backgroundCatalogOnPanel;
    private Texts catalogOnPanel;
    private Button farther;
    private bool profile;
    private static bool canClick;
    public void Display(RenderWindow _window)
    {
        backgroundProfile.Draw(_window);
        photoProfile.Draw(_window);
        userNameOnPanel.Draw(_window);
       
      
        backgroundLogo.Draw(_window);
        logoProgram.Draw(_window);
        nameProgramOnPanel.Draw(_window);
        backgroundSearch.Draw(_window);
        backgroundMini.Draw(_window);
        backgroundMiniPart.Draw(_window);
        
        searchProgram.Draw(_window);
        searchOnPanel.Draw(_window);
        refundOnPanel.Draw(_window);
        detailsOnPanel.Draw(_window);
        backgroundCatalogOnPanel.Draw(_window);
        farther.Draw(_window);
        catalogOnPanel.Draw(_window);
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
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        
        backgroundProfile = new Button(53, 53, backgroundProfileArea);
        photoProfile = new Button(68, 79, photoProfileArea);
        backgroundLogo = new Button(279, 53, backgroundLogoArea);
        logoProgram = new Button(280, 63, logo);
        backgroundSearch = new Button(543, 53, backgroundSearchArea);
        farther = new Button(1790, 87, fartherIcon);
        
        backgroundMini = new Button(543, 111, backgroundMiniArea);
        backgroundMiniPart = new Button(741, 111, backgroundMiniAreaPart);
        searchProgram = new Button(917, 67, serchIcon);
        backgroundCatalogOnPanel = new Button(994, 53, backgroundCatalog);
        
        backgroundCatalogOnPanel = new Button(994, 53, backgroundCatalog);
        Color baseColorText = new Color(68, 68, 69);

        string userName = WorkWithJson.ReadLNameFromFile();
        string nameProgram = "CTT";
        string search = "Поиск";
        string refund = "Возврат средств";
        string details = "Подробности";
        string catalog = "Каталог билетов и проездных";
        userNameOnPanel = new Texts(126, 79, font, 32, baseColorText, userName);
        nameProgramOnPanel = new Texts(413, 71, font, 48, baseColorText, nameProgram);
        searchOnPanel = new Texts(556, 63, font, 20, baseColorText, search);
        refundOnPanel = new Texts(756, 118, font, 20, baseColorText, refund);
        detailsOnPanel = new Texts(556, 118, font, 20, baseColorText, details);
        catalogOnPanel = new Texts(1037, 77, font, 36, baseColorText, catalog);
    }
    private void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (userNameOnPanel.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)
                || backgroundProfile.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)
                || photoProfile.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (!profile)
                {
                    MainForm.profile = true;
                    MainForm.topPanel = true;
                    profile = true;
                }
                else
                {
                    MainForm.profile = false;
                    MainForm.topPanel = true;
                    profile = false;
                }
            }

            if (backgroundCatalogOnPanel.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                || catalogOnPanel.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) 
                || farther.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.topPanel = true;
                MainForm.frame9 = true;
            }
            clock.Restart();
            canClick = false;
        }
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