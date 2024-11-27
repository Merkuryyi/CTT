using CTT;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Profile
{
    private static Texts passwordInformationTitleText;
    private static Texts emailInformationTitleText;
    private static Texts numberPhoneInformationTitleText;
    private static Texts passwordInformationText;
    private static Texts emailInformationText;
    private static Texts numberPhoneInformationText;
    private static Button passwordInformation;
    private static Button emailInformation;
    private static Button numberPhoneInformation;
    private static string security;
    private static string notifications;
    private static Texture circleOfNotifications;
    private static Button elementNotifications;
    private static Button switchNotificationsCircle;
    private static Button switchNotifications;
    private static Texts markNotificationsText;
    private static Texts dateNotificationsText;
    private static Texts informationNotificationsText;
    private static string dateOfNotifications;
    private static string informationNotifications;
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

    private static Texture background;
    private static Texture backgroundMax;
    private static Texture fartherIcon;
    private static Texture emptyButton;
    private static Texture miniCircle;
    private static Texture elementOfNotifications;
    private static Texture elementOfNotificationsOff;
    private static Texture switchPart;
    private static Texture switchPartOff;
    private static bool canClick ;
    private static bool securityFlag;
    private static bool notificationsFlag;
    private static bool mainProfileFlag = true;
    private static bool profileFlag = false;
    private static bool settingsFlag = true;
    private static bool  notificationWork = true;
          //      private static 
    public void Display(RenderWindow _window)
    {
        _window.Clear(new Color(233, 233, 233));
     
        if (mainProfileFlag)
        {
            backgroundFrame.Draw(_window);
            notificationText.Draw(_window);
            securityText.Draw(_window);
            fartherIconNotification.Draw(_window);
            fartherIconSecure.Draw(_window);
            if (int.TryParse(countNotifications, out int count) && count > 0 && notificationWork)
            {
                circleNotifications.Draw(_window);
                countNotificationsText.Draw(_window);
            }
        }
        
        if (notificationsFlag)
        {
           
            backgroundFrameMax.Draw(_window);
            fartherIconNotification.Draw(_window);
            notificationText.Draw(_window);
            informationNotificationsText.Draw(_window);
            dateNotificationsText.Draw(_window);
            markNotificationsText.Draw(_window);
            switchNotifications.Draw(_window);
            switchNotificationsCircle.Draw(_window);
            elementNotifications.Draw(_window);
        }

        if (securityFlag)
        {
            backgroundFrameMax.Draw(_window);  
            fartherIconNotification.Draw(_window);
            notificationText.Draw(_window);
            numberPhoneInformation.Draw(_window);  
            emailInformation.Draw(_window);  
            passwordInformation.Draw(_window);  
            numberPhoneInformationText.Draw(_window);  
            emailInformationText.Draw(_window);  
            passwordInformationText.Draw(_window);  
        
            numberPhoneInformationTitleText.Draw(_window);  
            emailInformationTitleText.Draw(_window);  
            passwordInformationTitleText.Draw(_window);  
            
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
        
        photoAreaButton.Draw(_window);
        lastName.Draw(_window);
        firstName.Draw(_window);

    }

    public void Structure()
    {
      
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
        circleOfNotifications =  
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "circleNotifications.png"));
        elementOfNotificationsOff = 
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "elementsNotificationsOff.png"));
        elementOfNotifications =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "elementsNotifications.png"));
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
        circleNotifications = new Button(383, 400, circleOfNotifications);
        
        fartherIconNotification = new Button(600, 400, fartherIcon);
        fartherIconSecure = new Button(600, 498, fartherIcon);
        emptyNameButton = new Button(255, 220, emptyButton);
        emptyLNameButton = new Button(255, 298, emptyButton);
        baseColorText = new Color(68, 68, 69);
        warningTextColor = new Color(202, 128, 128);
        nullColorText = new Color(255,255, 255);
        
        switchNotifications = new Button(388, 403, switchPart);
        switchNotificationsCircle = new Button(433, 410, miniCircle);
        elementNotifications = new Button(95, 483, elementOfNotifications);
        
        numberPhoneInformation = new Button(350, 471, profileInformation);
        emailInformation = new Button(350, 536, profileInformation);
        passwordInformation = new Button(350, 601, profileInformation);
        
        fname = SavingLogin.ReadNameFromFile();
        lname = SavingLogin.ReadLNameFromFile();
        string warnings = "*";
        notifications = "Уведомления";
        security = "Безопасность";
        countNotifications = "2";
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        
        firstName = new Texts(283, 227, font, 40, baseColorText, fname);
        lastName = new Texts(283, 305, font, 40, baseColorText, lname);
        notificationText = new Texts(95, 393, font, 40, baseColorText, notifications);
        securityText = new Texts(95, 486, font, 40, baseColorText, security);
        warningNameText = new Texts(563, 244, font, 20, warningTextColor, warnings);
        warningLNameText = new Texts(563, 325, font, 20, warningTextColor, warnings);
        countNotificationsText = new Texts(397, 407, font, 20, baseColorText, countNotifications);

        informationNotifications = "Поступление:";
        dateOfNotifications = "01.01.2024";
        string markNotifications = "Отметить как прочитанное";
        informationNotificationsText = new Texts(266, 483, font, 32, baseColorText, informationNotifications);
        dateNotificationsText = new Texts(266, 550, font, 24, baseColorText, dateOfNotifications);
        markNotificationsText = new Texts(227, 600, font, 24, baseColorText, markNotifications);
        string password = "******";
        string email = "nikk***@gmail.com";
        string numberPhone = "+7********51";
        
        numberPhoneInformationText = new Texts(359, 472, font, 24, baseColorText, numberPhone);
        emailInformationText = new Texts(359, 536, font, 24, baseColorText, email);
        passwordInformationText = new Texts(359, 603, font, 24, baseColorText, password);
        
        string passwordText = "Пароль";
        string emailText = "Почта";
        string numberPhoneText = "Номер телефона";
        
        numberPhoneInformationTitleText = new Texts(95, 472, font, 24, baseColorText, numberPhoneText);
        emailInformationTitleText = new Texts(95, 536, font, 24, baseColorText, emailText);
        passwordInformationTitleText = new Texts(95, 603, font, 24, baseColorText, passwordText);
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
        
        canClick = DelayClic.clic(canClick);

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
            

            if ((notificationText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) || 
                fartherIconNotification.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)) && mainProfileFlag)
            {
                notificationsFlag = true;
                mainProfileFlag = false;
                securityFlag = false;
                
            }
            else if ((notificationText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) || 
                 fartherIconNotification.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)) && !mainProfileFlag)
            {
                notificationsFlag = false;
                mainProfileFlag = true;
                securityFlag = false;
                notificationText.SetText(notifications);
            }
            
           else if (securityText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
           {
               notificationsFlag =  false;
               mainProfileFlag = false;
               securityFlag = true;
               notificationText.SetText(security);
           }
          
           
            if (markNotificationsText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                elementNotifications.SetTexture(elementOfNotificationsOff);
            }
            if (switchNotifications.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (switchNotifications.IfTexture(switchPartOff))
                {
                    switchNotifications.SetTexture(switchPart);
                    switchNotificationsCircle.SetPosition(433, 410);
                    notificationWork = true;
                }
                else
                {
                    switchNotifications.SetTexture(switchPartOff);
                    switchNotificationsCircle.SetPosition(395, 410);
                    notificationWork = false;
                }
                
            }
         
            
        }

        Warning(_window);
    }
 
    public void workProgram(RenderWindow _window)
    {
            Display(_window);
            ButtonInteraction(_window);
        
    }
    

}