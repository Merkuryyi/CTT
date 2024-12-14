namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Text.RegularExpressions;
public class Profile
{
    public void Display(RenderWindow _window)
    {
        if (mainProfileFlag)
        {
            backgroundFrame.Draw(_window);
            notificationText.Draw(_window);
            securityText.Draw(_window);
            if (int.TryParse(countNotifications, out int count) && count > 0 && notificationWork)
            {
                circleNotifications.Draw(_window);
                countNotificationsText.Draw(_window);
            }
            fartherIconSecure.Draw(_window);
        }
        if (notificationsFlag)
        {
            backgroundFrameMax.Draw(_window);
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
        { settings.Draw(_window); }
        photoAreaButton.Draw(_window);
        lastName.Draw(_window);
        firstName.Draw(_window);
        profileExit.Draw(_window);
        fartherIconNotification.Draw(_window);
    }
    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;  
        line = new InputLine();
        warnings = new Warnings();
        database = new Database();
        flagFrames = new FlagFrames();
        flags = new Flags();
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
        Texture profileOutExit=
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "exitOutProfile.png"));
        backgroundFrame = new Button(53, 180, background);
        backgroundFrameMax = new Button(53, 180, backgroundMax);
        photoAreaButton = new Button(78, 210, photoArea);
        settings = new Button(590, 210, settingsIcon);
        checkMark = new Button(595, 230, checkMarkIcon);
        circleNotifications = new Button(383, 390, circleOfNotifications);
        fartherIconNotification = new Button(600, 390, fartherIcon);
        fartherIconSecure = new Button(600, 488, fartherIcon);
        emptyNameButton = new Button(255, 210, emptyButton);
        emptyLNameButton = new Button(255, 288, emptyButton);
        baseColorText = new Color(68, 68, 69);
        warningTextColor = new Color(202, 128, 128);
        nullColorText = new Color(255,255, 255);
        switchNotifications = new Button(388, 393, switchPart);
        switchNotificationsCircle = new Button(433, 400, miniCircle);
        elementNotifications = new Button(95, 473, elementOfNotificationsOff);
        profileExit = new Button(600, 295, profileOutExit);
        elementNotifications = new Button(95, 473, elementOfNotifications);
        numberPhoneInformation = new Button(350, 461, profileInformation);
        emailInformation = new Button(350, 526, profileInformation);
        passwordInformation = new Button(350, 591, profileInformation);
        loginMiniText = WorkWithJson.ReadNameFromFile();
        userNameMiniText = WorkWithJson.ReadLNameFromFile();
        notifications = "Уведомления";
        security = "Безопасность";
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        firstName = new Texts(283, 217, font, 40, baseColorText, loginMiniText);
        lastName = new Texts(283, 295, font, 40, baseColorText, userNameMiniText);
        notificationText = new Texts(95, 383, font, 40, baseColorText, notifications);
        securityText = new Texts(95, 476, font, 40, baseColorText, security);
        warningNameText = new Texts(563, 234, font, 20, warningTextColor, "");
        warningLNameText = new Texts(563, 315, font, 20, warningTextColor, "");
        countNotificationsText = new Texts(397, 397, font, 20, baseColorText, "");
        string markNotifications = "Отметить как прочитанное";
        informationNotificationsText = new Texts(266, 473, font, 32, baseColorText, "");
        dateNotificationsText = new Texts(266, 540, font, 24, baseColorText, "");
        markNotificationsText = new Texts(227, 590, font, 24, baseColorText, markNotifications);
        string password = WorkWithJson.ReadPasswordFromFile();
        email = MaskEmail();
        numberPhone = MaskPhoneNumber();
        numberPhoneInformationText = new Texts(359, 462, font, 24, baseColorText, numberPhone);
        emailInformationText = new Texts(359, 526, font, 24, baseColorText, email);
        passwordInformationText = new Texts(359, 593, font, 24, baseColorText, password);
        string passwordText = "Пароль";
        string emailText = "Почта";
        string numberPhoneText = "Номер телефона";
        numberPhoneInformationTitleText = new Texts(95, 462, font, 24, baseColorText, numberPhoneText);
        emailInformationTitleText = new Texts(95, 526, font, 24, baseColorText, emailText);
        passwordInformationTitleText = new Texts(95, 593, font, 24, baseColorText, passwordText);
        int id = database.GetUserId(WorkWithJson.ReadPhoneNumberFromFile(), WorkWithJson.ReadEmailFromFile());
        CountNotifications(id);
        dateNotificationsText.SetText(notificationsReadOrUnread());
        informationNotificationsText.SetText(database.NotificationGet(id));
        cursorLogin = WorkWithJson.ReadNameFromFile().Length;
        cursorUserName = WorkWithJson.ReadLNameFromFile().Length;
    }
    private void CountNotifications(int id)
    {
        if (notificationWork)
        {
            countNotifications = database.NotificationsCount(id).ToString();
            countNotificationsText.SetText(countNotifications);
        }
    }
    private void updateNotifications()
    {
        if (notificationWork)
        {
            if (int.Parse(countNotifications) == 0)
            { elementNotifications.SetTexture(elementOfNotificationsOff); }
            if (int.Parse(countNotifications) > 0)
            { elementNotifications.SetTexture(elementOfNotifications); }
        }
    }
    private string notificationsReadOrUnread()
    {
        if (int.Parse(countNotifications) > 0)
        { return database.NotificationDateGetUnread().ToString(); }
        return database.NotificationDateGetRead().ToString();
    }
    private void Warning()
    {
        clic();
        warnings.WarningLineName(loginMiniText);
        warningLogin = warnings.GetWarningFlag();
        if (warningLogin)
        { warningNameText.SetText("*"); }
        else
        { warningNameText.SetText(""); }
        warningUserName = warnings.GetWarningFlag();
        warnings.WarningLineName(userNameMiniText);
        if (warningUserName)
        { warningLNameText.SetText("*"); }
        else
        { warningLNameText.SetText(""); }
        if (!warningLogin && !warningUserName)
        {
            database.UpdateNameUser(WorkWithJson.ReadPhoneNumberFromFile(), WorkWithJson.ReadEmailFromFile(), loginMiniText, userNameMiniText);
            WorkWithJson.UpdateLoginAndUserNameInJson(loginMiniText, userNameMiniText);
            TopPanel.userNameOnPanel.SetText(userNameMiniText);
        }  
    }
    public string MaskEmail()
    {
        string email = WorkWithJson.ReadEmailFromFile();
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        if (Regex.IsMatch(email, pattern))
        {
            string[] emailParts = email.Split('@');
            string username = emailParts[0];
            string domain = emailParts[1];
            if (username.Length > 3)
            { username = username.Substring(0, 3) + new string('*', username.Length - 3); }
            else
            { username = new string('*', username.Length); }
            return $"{username}@{domain}";
        }
        return null;
    }
    public string MaskPhoneNumber()
    {
        string phoneNumber = WorkWithJson.ReadPhoneNumberFromFile();
        string pattern = @"^8\d{10}$";
        if (Regex.IsMatch(phoneNumber, pattern))
        {
            string maskedPhoneNumber = $"8 *** *** ** {phoneNumber.Substring(9, 2)}";
            return maskedPhoneNumber;
        }
        return null;
    }
    private void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        int id = database.GetUserId(WorkWithJson.ReadPhoneNumberFromFile(), WorkWithJson.ReadEmailFromFile());
        clic();
        if (Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (profileExit.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                flagFrames.ChangeFlagsFrame();
                WorkWithJson.cleanLoginData();
                MainForm.frame1 = true;
            }
            if (checkMark.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            { Warning(); }
            if (settings.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (!settingsFlag && !warningLogin && !warningUserName)
                { settingsFlag = true; }
                else
                { settingsFlag = false; }
                Warning();
            }
            if (emptyNameButton.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (!settingsFlag)
                {
                    flags.ChangeFlag();
                    flagLogin = true;
                    line.LineParametr(loginMiniText, cursorLogin);
                }
            }
            if (emptyLNameButton.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (!settingsFlag)
                {
                    flags.ChangeFlag();
                    flagUserName = true;
                    line.LineParametr(userNameMiniText, cursorUserName);
                }
            }
            if ((notificationText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) ||
                 fartherIconNotification.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)) &&
                mainProfileFlag)
            {
                notificationsFlag = true;
                mainProfileFlag = false;
                securityFlag = false;
            }
            else if ((notificationText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) ||
                      fartherIconNotification.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)) &&
                     !mainProfileFlag)
            {
                notificationsFlag = false;
                mainProfileFlag = true;
                securityFlag = false;
                CountNotifications(id);
                notificationText.SetText(notifications);
                informationNotificationsText.SetText(database.NotificationGet(id));
                dateNotificationsText.SetText(notificationsReadOrUnread());
                updateNotifications();
            }
            else if (securityText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y) || 
                     fartherIconSecure.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                notificationsFlag = false;
                mainProfileFlag = false;
                securityFlag = true;
                notificationText.SetText(security);
            }
            if (markNotificationsText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                database.NotificationsUpdate(id.ToString());
                CountNotifications(id);
                informationNotificationsText.SetText(database.NotificationGet(id));
                dateNotificationsText.SetText(notificationsReadOrUnread());
                updateNotifications();
            }
            if (switchNotifications.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (switchNotifications.IfTexture(switchPartOff))
                {
                    switchNotifications.SetTexture(switchPart);
                    switchNotificationsCircle.SetPosition(433, 400);
                    notificationWork = true;
                    updateNotifications();
                }
                else if (switchNotifications.IfTexture(switchPart))
                {
                    switchNotifications.SetTexture(switchPartOff);
                    switchNotificationsCircle.SetPosition(395, 400);
                    notificationWork = false;
                    elementNotifications.SetTexture(elementOfNotificationsOff);
                }
            }
            clock.Restart();
            canClick = false;
        }
        if (flagLogin)
        {
            loginMiniText = line.GetLine();
            firstName.SetText(loginMiniText);
            cursorLogin = line.GetCursor();
        }
        if (flagUserName)
        {
            userNameMiniText = line.GetLine();
            lastName.SetText(userNameMiniText);
            cursorUserName = line.GetCursor();
        }
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
    private string email;
    private string numberPhone;
    private bool warningUserName;
    private bool warningLogin;
    private Button profileExit;
    private Texts passwordInformationTitleText;
    private Texts emailInformationTitleText;
    private Texts numberPhoneInformationTitleText;
    private Texts passwordInformationText;
    private Texts emailInformationText;
    private Texts numberPhoneInformationText;
    private Button passwordInformation;
    private Button emailInformation;
    private Button numberPhoneInformation;
    private Texture circleOfNotifications;
    private Button elementNotifications;
    private Button switchNotificationsCircle;
    private Button switchNotifications;
    private Texts markNotificationsText;
    private Texts dateNotificationsText;
    private Texts informationNotificationsText;
    private Texts warningLNameText;
    private Texts warningNameText;
    private Button emptyLNameButton;
    private Button emptyNameButton;
    private Button checkMark;
    private Texts countNotificationsText;
    private string countNotifications;
    private Texts securityText;
    private Texts notificationText;
    private Texts lastName;
 
    private Texts firstName;
    private Color nullColorText;
    private Button fartherIconNotification;
    private Button fartherIconSecure;
    private Color baseColorText;
    private Color warningTextColor;
    private Button circleNotifications;
    private Button settings;
    private Button photoAreaButton;
    private Texture checkMarkIcon;
    private Texture  settingsIcon;
    private Button backgroundFrameMax;
    private Button backgroundFrame;
    private InputLine line;
    private Texture background;
    private Texture backgroundMax;
    private Texture fartherIcon;
    private Texture emptyButton;
    private Texture miniCircle;
    private Texture elementOfNotifications;
    private Texture elementOfNotificationsOff;
    private Texture switchPart;
    private Texture switchPartOff;
    private string security;
    private string notifications;
    private string userNameMiniText;
    private string loginMiniText;
    public static bool flagLogin;
    public static bool flagUserName;
    private bool canClick;
    private bool securityFlag;
    private bool notificationsFlag;
    private bool mainProfileFlag = true;
    private bool profileFlag = false;
    private bool settingsFlag = true;
    private bool notificationWork = true;
    private int cursorLogin;
    private int cursorUserName;
    private Clock clock;
    private float clickDelay;
    private Warnings warnings;
    private Database database;
    private FlagFrames flagFrames;
    private Flags flags;
    private Vector2i mousePosition;
}