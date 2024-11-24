using CTT;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Profile
{
    private static Texts warningLNameText;
    private static Texts warningNameText;
    private static Button emptyLNameButton;
    private static Button emptyNameButton;

    private static Button checkMark;
    private static Texts countNotificationsText;
    private static string countNotifications;
    private static Texts securityText;
    private static Texts notificationText;
    private static Texts lastName;
    private static string lname;
    private static string fname;
    private static Texts firstName;
    private static Color nullColorText;
    private static Button fartherIconNotification;
    private static Button fartherIconSecure;
    private static Color baseColorText;
    private static Color warningTextColor;
    private static Button circleNotifications;
    private static Button settings;
    private static Button photoAreaButton;
    private static Texture checkMarkIcon;
    private static Texture  settingsIcon;
    private static Button backgroundFrameMax;
    private static Button backgroundFrame;
    private static InputLine line;
    private static Clock clock;
    private static float clickDelay;
    private static Texture background;
    private static Texture backgroundMax;
    private static Texture fartherIcon;
    private static Texture emptyButton;
    private static Texture miniCircle;
    private static Texture elementOfNotifications;
    private static Texture elementOfNotificationsOff;
    private static Texture switchPart;
    private static Texture switchPartOff;
    private static bool canClick = false;
    private static bool securityFlag = false;
    private static bool notifiationsFlag = false;
    private static bool mainProfileFlag = true;
    private static bool profileFlag = false;
    private static bool settingsFlag = true;
          //      private static 
    public void Display(RenderWindow _window)
    {
        _window.Clear(new Color(233, 233, 233));
        backgroundFrame.Draw(_window);
        photoAreaButton.Draw(_window);
        
        if (mainProfileFlag)
        {
           
         
            
            fartherIconNotification.Draw(_window);
            fartherIconSecure.Draw(_window);
            
            if (int.TryParse(countNotifications, out int count) && count > 0)
            {
                circleNotifications.Draw(_window);
                countNotificationsText.Draw(_window);
                //Console.WriteLine(countNotifications);
            }

            if (!settingsFlag)
            {
                checkMark.Draw(_window);
                emptyNameButton.Draw(_window);
                emptyLNameButton.Draw(_window);
                warningNameText.Draw(_window);
                warningLNameText.Draw(_window);
            }
            else
            {
                settings.Draw(_window);
            }
        }
        
        
        lastName.Draw(_window);
        firstName.Draw(_window);
        
        
        notificationText.Draw(_window);
        securityText.Draw(_window);
        
      //  backgroundFrameMax.Draw(_window);

    }

    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;
        line = new InputLine();
        
        background =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundProfile.png"));
        backgroundMax =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundProfileMax.png"));
        Texture photoArea =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "photoArea.png"));
        settingsIcon =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "settingsProfile.png"));
        checkMarkIcon =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "checkMark.png"));
        fartherIcon =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "fartherIcon.png"));
        emptyButton =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "emptyButton.png"));
        miniCircle =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "partCircleOfSwitch.png"));
        elementOfNotifications =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "circleNotifications.png"));
       switchPart =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "partOfSwitch.png"));
        switchPartOff =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "partOfSwitchOff.png"));
        Texture profileInformation =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "informationsProfile.png"));
        
        backgroundFrame = new Button(53, 190, background);
        backgroundFrameMax = new Button(53, 190, backgroundMax);
        photoAreaButton = new Button(78, 220, photoArea);
        settings = new Button(590, 220, settingsIcon);
        checkMark = new Button(595, 230, checkMarkIcon);
        circleNotifications = new Button(383, 400, elementOfNotifications);
        
        fartherIconNotification = new Button(600, 400, fartherIcon);
        fartherIconSecure = new Button(600, 498, fartherIcon);
        emptyNameButton = new Button(255, 220, emptyButton);
        emptyLNameButton = new Button(255, 298, emptyButton);
        baseColorText = new Color(68, 68, 69);
        warningTextColor = new Color(202, 128, 128);
        nullColorText = new Color(255,255, 255);
        
        fname = "Имя";
        lname = "Фамилия";
        string warnings = "*";
        string notifications = "Уведомления";
        string security = "Безопасность";
        countNotifications = "0";
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        
        firstName = new Texts(283, 227, font, 40, baseColorText, fname);
        lastName = new Texts(283, 305, font, 40, baseColorText, lname);
        notificationText = new Texts(95, 393, font, 40, baseColorText, notifications);
        securityText = new Texts(95, 486, font, 40, baseColorText, security);
        warningNameText = new Texts(563, 244, font, 20, warningTextColor, warnings);
        warningLNameText = new Texts(563, 325, font, 20, warningTextColor, warnings);
    }

    private static string CountNotifications(string countNotifications)
    {
        countNotificationsText.SetText(countNotifications);
        return countNotifications;
    }
    private static void Warning(RenderWindow _window)
    {

    }

    private static void ButtonInteraction(RenderWindow _window)
    {
        Vector2i mousePosition = Mouse.GetPosition(_window);
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        {
            canClick = true;
        }

        if (Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (settings.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (!settingsFlag)
                {
                    settingsFlag = true;
                }
                else
                {
                    settingsFlag = false;
                }
            }
            else
            {
                settingsFlag = false;
            }
            
            canClick = false;
            clock.Restart();
        }

        Warning(_window);
    }
    private void Ivents(RenderWindow _window)
    {
        
        _window.DispatchEvents();
        _window.Closed += (sender, e) => _window.Close();
        _window.KeyPressed += line.OnKeyPressedName;
        
    }
    public void workProgram(RenderWindow _window)
    {
        
        
        while (_window.IsOpen)
        {
            Ivents(_window);
            Display(_window);
            ButtonInteraction(_window);
            
            _window.Display();

        }


    }
    

}