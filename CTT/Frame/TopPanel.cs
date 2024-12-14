namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class TopPanel
{
    private static Clock clock;
    private static float clickDelay;
    private FlagFrames flagFrames;
    private Vector2i mousePosition;
    private Button backgroundProfile;
    private Button photoProfile;
    private Button logoProgram;
    private Button backgroundLogo;
    private Button backgroundSearch;
    private Button backgroundMini;
    private Button backgroundMiniPart;
    private Button searchProgram;
    private Button farther;
    private Button backgroundCatalogOnPanel;
    private Texts nameProgramOnPanel;
    private Texts searchOnPanel;
    private Texts partPanel;
    private Texts partPanel2;
    private Texts catalogOnPanel;
    public static Texts userNameOnPanel;
    private bool profile;
    private bool search;
    private int searchCursor;
    private string searchLineOnPanel;
    private static bool canClick;
    public void Display(RenderWindow window)
    {
        backgroundProfile.Draw(window);
        photoProfile.Draw(window);
        userNameOnPanel.Draw(window);
        backgroundLogo.Draw(window);
        logoProgram.Draw(window);
        nameProgramOnPanel.Draw(window);
        backgroundSearch.Draw(window);
        backgroundMini.Draw(window);
        backgroundMiniPart.Draw(window);
        searchProgram.Draw(window);
        searchOnPanel.Draw(window);
        partPanel.Draw(window);
        partPanel2.Draw(window);
        backgroundCatalogOnPanel.Draw(window);
        farther.Draw(window);
        catalogOnPanel.Draw(window);
    }
    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;   
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
        string partMini = "Купить проездной";
        string partMini2 = "Купить билет";
        string catalog = "Каталог билетов и проездных";
        searchLineOnPanel = "";
        userNameOnPanel = new Texts(126, 87, font, 24, baseColorText, userName);
        nameProgramOnPanel = new Texts(413, 71, font, 48, baseColorText, nameProgram);
        searchOnPanel = new Texts(556, 63, font, 20, baseColorText, search);
        partPanel = new Texts(756, 118, font, 20, baseColorText, partMini);
        partPanel2 = new Texts(556, 118, font, 20, baseColorText, partMini2);
        catalogOnPanel = new Texts(1037, 77, font, 36, baseColorText, catalog);
    }
    private void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        Flags flags = new Flags();
        InputLine line = new InputLine();
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
            if (logoProgram.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)
                || backgroundLogo.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.topPanel = true;
                MainForm.frame5 = true;
            }
            if (searchOnPanel.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)
                || backgroundSearch.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flags.ChangeFlag();
                search = true;
                line.LineParametr(searchLineOnPanel, searchCursor);
            }
            if (partPanel2.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)
                || backgroundMini.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.frame6 = true;
                MainForm.topPanel = true;
            }

            if (partPanel.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)
                || backgroundMiniPart.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                MainForm.frame7 = true;
                MainForm.topPanel = true;
            }
            else
            { search = false; }
            if (searchProgram.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                SearchHandler searchHandler = new SearchHandler();
                searchHandler.Search(searchLineOnPanel);
            }
            else
            { flags.ChangeFlag(); }
            clock.Restart();
            canClick = false;
        }
        if (search)
        {
            searchLineOnPanel = line.GetLine();
            searchOnPanel.SetText(searchLineOnPanel);
            searchCursor = line.GetCursor();
        }
        else if (!search)
        {
            searchOnPanel.SetText("Поиск");
            searchLineOnPanel = "";
            searchCursor = 0;
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
        { canClick = true; }
    }
}