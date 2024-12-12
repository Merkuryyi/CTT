using CTT.Logic;
namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Threading.Tasks;
public class PayTicket
{
    private static Clock clock;
    private static float clickDelay;
    private FlagFrames flagFrames;
    private string benefitsShared;
    private string benefitsPension;
    private string benefitsBaggage;
    private static bool canClick;
    private static bool ticketUpper = false;
    private static bool ticketMiddle;
    private static bool ticketLower;
    private string amount;
    private string priceShare;
    private string priceStudent;
    private string pricePension;
    private string warningDocument;
    private string warning;
    private string countsUpper = "1";
    private string countsMiddle = "1";
    private string countsLower = "1";
    private float amountCount;
    private float sumsUpper = 0.0f;
    private float sumMiddle = 0.0f;
    private float sumLower = 0.0f;
    private string countPlus(Texts text, string count)
    {
        int counts = int.Parse(count) + 1;
        text.SetText(counts.ToString());
        return counts.ToString(); 
    }
    private string countMinus(Texts text, string count)
    {
        int counts = int.Parse(count) - 1;
        if (counts > 0)
        {
            text.SetText(counts.ToString());
            return counts.ToString(); 
        }
        return count; 
    }
    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;
        Database database = new Database();
        flagFrames = new FlagFrames();
        Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");
        Texture backgroundLeftTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundLeftWithTop.png"));
        Texture backgroundRightTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundRightWithTop.png"));
        chooseBenefitsOnTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "chooseBenefitsOn.png"));
        chooseBenefitsOffTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "chooseBenefitsOff.png"));
        Texture lineTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "line.png"));
        Texture buttonPaymentTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonPayment.png"));
        Texture backgroundTicket =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "backgroundTicket.png"));
        Texture placeForCount =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "placeForCount.png"));
        Texture plus =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "plus.png"));
        Texture minus =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "minus.png"));
        backgroundLeft = new Button(53, 170, backgroundLeftTexture);
        backgroundRight = new Button(994, 170, backgroundRightTexture);
        backgroundTicketUpper = new Button(108, 396, backgroundTicket);
        backgroundTicketLower = new Button(108, 796, backgroundTicket);
        backgroundTicketMiddle = new Button(108, 596, backgroundTicket);
        plusTicketUpper = new Button(293, 514, plus);
        plusTicketLower = new Button(293, 914, plus);
        plusTicketMiddle = new Button(293, 714, plus);
        minusTicketUpper = new Button(459, 514, minus);
        minusTicketLower = new Button(459, 914, minus);
        minusTicketMiddle = new Button(459, 714, minus);
        forCountUpper = new Button(344, 514, placeForCount);
        forCountMiddle = new Button(344, 714, placeForCount);
        forCountLower = new Button(344, 914, placeForCount);
        chooseBenefitsShared = new Button(114, 310, chooseBenefitsOnTexture);
        chooseBenefitsStudent = new Button(285, 310, chooseBenefitsOffTexture);
        chooseBenefitsPension = new Button(530, 310, chooseBenefitsOffTexture);
        lines = new Button(114, 376, lineTexture);
        buttonPayment = new Button(1310, 717, buttonPaymentTexture);
        benefitsShared = "Общий";
        benefitsPension = "Пенсионный";
        benefitsBaggage = "Багажный";
        priceShare = database.TicketPriceGet(benefitsShared);
        priceStudent = database.TicketPriceGet(benefitsBaggage);
        pricePension = database.TicketPriceGet(benefitsPension);
        warningDocument = "*необходим документ";
        string titleFrame = "Купить разовый билет";
        string titleFrameRight = "Оплата разового билета";
        string line = "Для оплаты проезда нажмите “оплатить”, а после  предъявите ";
        string line2 = "необходимые документы кондуктору транспортного средства.";
        string line3 = "Хорошей поездки!";
        string payment = "К оплате:";
        string paymentTitle = "Оплатить";
        Color baseColorText = new Color(68, 68, 69);
        Color warningTextColor = new Color(202, 128, 128);
        Color colorMessage = new Color(136, 136, 136);
        titleFrameText = new Texts(114, 237, font, 36, baseColorText, titleFrame);
        benefitsSharedText = new Texts(169, 313, font, 24, baseColorText, benefitsShared);
        benefitsPensionText = new Texts(585, 313, font, 24, baseColorText, benefitsPension);
        benefitsBaggageText = new Texts(340, 313, font, 24, baseColorText, benefitsBaggage);
        priceTicketUpper = new Texts(133, 513, font, 24, baseColorText, priceShare);
        priceTicketMiddle = new Texts(133, 713, font, 24, baseColorText, "");
        priceTicketLower = new Texts(133, 913, font, 24, baseColorText, "");
        titleFrameTextRight = new Texts(1037, 237, font, 36, baseColorText, titleFrameRight);
        lineText = new Texts(1037, 309, font, 24, colorMessage, line);
        lineText2 = new Texts(1037, 345, font, 24, colorMessage, line2);
        lineText3 = new Texts(1037, 379, font, 24, colorMessage, line3);
        paymentText = new Texts(1345, 579, font, 36, baseColorText, payment);
        amountText = new Texts(1345, 625, font, 36, baseColorText, "");
        warningPaymentText = new Texts(1315, 677, font, 20, warningTextColor, "");
        paymentTitleText = new Texts(1345, 725, font, 36, baseColorText, paymentTitle);
        titleTicketUpper = new Texts(293, 423, font, 36, baseColorText, benefitsShared);
        titleTicketMiddle = new Texts(293, 623, font, 36, baseColorText, "");
        titleTicketLower = new Texts(293, 823, font, 36, baseColorText, "");
        warningTextUpper = new Texts(725, 449, font, 20, warningTextColor, "");
        warningTextMiddle = new Texts(725, 649, font, 20, warningTextColor, "");
        warningTextLower = new Texts(725, 849, font, 20, warningTextColor, "");
        countUpper = new Texts(391, 515, font, 24, baseColorText, countsUpper);
        countMiddle = new Texts(391, 715, font, 24, baseColorText, countsMiddle);
        countLower = new Texts(391, 915, font, 24, baseColorText, countsLower);
        SetAmountPlus();
    }
    private void Warning()
    {
        if (titleTicketLower.IfTexts(benefitsPension))
        { warningTextLower.SetText(warningDocument); }
        if (titleTicketMiddle.IfTexts(benefitsPension))
        { warningTextMiddle.SetText(warningDocument); }
        if (titleTicketUpper.IfTexts(benefitsPension))
        { warningTextUpper.SetText(warningDocument); }
    }
    private void SetPrice(string price, string title)
    {
        if (priceTicketUpper.IfTexts(""))
        {
            priceTicketUpper.SetText(price);
            titleTicketUpper.SetText(title);
        }
        else if (priceTicketMiddle.IfTexts(""))
        {
            priceTicketMiddle.SetText(price);
            titleTicketMiddle.SetText(title);
            ticketMiddle = true;
        }
        else if (priceTicketLower.IfTexts(""))
        {
            priceTicketLower.SetText(price);
            titleTicketLower.SetText(title);
            ticketLower = true;
        }
    }
    private void SetAmountPlus()
    {
        float sumUpper = 0;
        float sumMiddle = 0;
        float sumLower = 0;
        if (priceTicketUpper.GetTextString() != "")
        { sumUpper = float.Parse(priceTicketUpper.GetTextString()) * int.Parse(countsUpper); }
        if (ticketLower && priceTicketLower.GetTextString() != "")
        { sumLower = float.Parse(priceTicketLower.GetTextString()) * int.Parse(countsLower); }
        if (ticketMiddle &&  priceTicketMiddle.GetTextString() != "")
        { sumMiddle = float.Parse(priceTicketMiddle.GetTextString()) * int.Parse(countsMiddle); }
        amountCount = (sumUpper + sumLower + sumMiddle);
        amountText.SetText(amountCount.ToString());
    }
    private void deleteWarning()
    {
        if (priceTicketUpper.IfTexts("") 
            || priceTicketUpper.IfTexts(priceShare))
        { warningTextUpper.SetText(""); }
        if (priceTicketMiddle.IfTexts("")
                 || priceTicketMiddle.IfTexts(priceShare))
        { warningTextMiddle.SetText(""); }
        if (priceTicketLower.IfTexts("")
                 || priceTicketLower.IfTexts(priceShare))
        { warningTextLower.SetText(""); }
    }
    private void DeletePrice(string price)
    {
        if (priceTicketUpper.IfTexts(price))
        {
            priceTicketUpper.SetText("");
            titleTicketUpper.SetText("");
            if (!priceTicketMiddle.IfTexts(""))
            {
                priceTicketUpper.SetText(priceTicketMiddle.GetTextString());
                titleTicketUpper.SetText(titleTicketMiddle.GetTextString());
                priceTicketMiddle.SetText("");
                titleTicketMiddle.SetText("");
                ticketMiddle = false;
                if (!priceTicketLower.IfTexts(""))
                {
                    priceTicketMiddle.SetText(priceTicketLower.GetTextString());
                    titleTicketMiddle.SetText(titleTicketLower.GetTextString());
                    priceTicketLower.SetText("");
                    titleTicketLower.SetText("");
                    ticketMiddle = true;
                    ticketLower = false;
                }
            }
        }
        else if (priceTicketMiddle.IfTexts(price))
        {
            priceTicketMiddle.SetText("");
            titleTicketMiddle.SetText("");
            ticketMiddle = false;
            if (!priceTicketLower.IfTexts(""))
            {
                priceTicketMiddle.SetText(priceTicketLower.GetTextString());
                titleTicketMiddle.SetText(titleTicketLower.GetTextString());
                priceTicketLower.SetText("");
                titleTicketLower.SetText("");
                ticketMiddle = true;
                ticketLower = false;
            }
        }
        else if (priceTicketLower.IfTexts(price))
        {
            priceTicketLower.SetText("");
            ticketLower = false;
            titleTicketLower.SetText("");
        }
    }
    private void ButtonInteraction(RenderWindow _window)
    {
        clic();
        Vector2i mousePosition = Mouse.GetPosition(_window);
        Database database = new Database();
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (plusTicketUpper.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                countsUpper = countPlus(countUpper, countsUpper);
                SetAmountPlus();
            }
            if (plusTicketMiddle.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                countsMiddle = countPlus(countMiddle, countsMiddle);
                SetAmountPlus();
            }
            if (plusTicketLower.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                countsLower = countPlus(countLower, countsLower);
                SetAmountPlus();
            }
            if (minusTicketUpper.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                countsUpper = countMinus(countUpper, countsUpper); 
                SetAmountPlus();
            }
            if (minusTicketMiddle.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                countsMiddle = countMinus(countMiddle, countsMiddle); 
                SetAmountPlus();
            }
            if (minusTicketLower.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                countsLower = countMinus(countLower, countsLower); 
                SetAmountPlus();
            }
            if (chooseBenefitsShared.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (chooseBenefitsShared.IfTexture(chooseBenefitsOffTexture))
                {
                    chooseBenefitsShared.SetTexture(chooseBenefitsOnTexture);
                    SetPrice(priceShare, benefitsShared);
                    Warning();
                    SetAmountPlus();
                }
                else if (chooseBenefitsPension.IfTexture(chooseBenefitsOnTexture) 
                         || chooseBenefitsStudent.IfTexture(chooseBenefitsOnTexture))
                {
                    chooseBenefitsShared.SetTexture(chooseBenefitsOffTexture);
                    DeletePrice(priceShare);
                    Warning();
                    deleteWarning();
                    SetAmountPlus();
                }
            }
            if (chooseBenefitsStudent.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (chooseBenefitsStudent.IfTexture(chooseBenefitsOffTexture))
                {
                    chooseBenefitsStudent.SetTexture(chooseBenefitsOnTexture);
                    SetPrice(priceStudent, benefitsBaggage);
                    Warning();
                    SetAmountPlus();
                }
                else
                {
                    if (chooseBenefitsShared.IfTexture(chooseBenefitsOnTexture) || chooseBenefitsShared.IfTexture(chooseBenefitsOnTexture))
                    {
                        chooseBenefitsStudent.SetTexture(chooseBenefitsOffTexture);
                        DeletePrice(priceStudent);
                        Warning();
                        deleteWarning();
                        SetAmountPlus();
                    }
                }
            }
            if (chooseBenefitsPension.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (chooseBenefitsPension.IfTexture(chooseBenefitsOffTexture))
                {
                    chooseBenefitsPension.SetTexture(chooseBenefitsOnTexture);
                    SetPrice(pricePension, benefitsPension);
                    Warning();
                    SetAmountPlus();
                }
                else if (chooseBenefitsPension.IfTexture(chooseBenefitsOnTexture))
                {
                    chooseBenefitsPension.SetTexture(chooseBenefitsOffTexture);
                    DeletePrice(pricePension);
                    Warning();
                    deleteWarning();
                    SetAmountPlus();
                }
            }
            if (paymentTitleText.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y)
                || buttonPayment.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                amount = amountCount.ToString();
                if (!_isProcessing)
                {
                    _isProcessing = true;
                    if (float.TryParse(amount, out float parsedAmount))
                    {
                        Task.Run(async () =>
                        {
                            try
                            {
                                PaymentService paymentService = new PaymentService();
                                string payUrl = await paymentService.CreateInvoiceAsync(parsedAmount);
                                Console.WriteLine("Invoice created successfully. Opening payment URL...");
                                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                                {
                                    FileName = payUrl,
                                    UseShellExecute = true
                                });
                                string numberPhone = WorkWithJson.ReadPhoneNumberFromFile();
                                string email = WorkWithJson.ReadEmailFromFile();
                                int id = database.GetUserId(numberPhone, email);
                             
                                if (!titleTicketUpper.IfTexts(""))
                                {
                                    HistoryTickets(titleTicketUpper, countsUpper, id);
                                    if (!titleTicketMiddle.IfTexts(""))
                                    {
                                        HistoryTickets(titleTicketMiddle, countsMiddle, id);
                                        if (!titleTicketLower.IfTexts(""))
                                        { HistoryTickets(titleTicketLower, countsLower, id); }
                                    }
                                }
                                database.NotificationsAdd(id, "Списание", amountCount);
                                MainForm.mainPage.Structure();
                                MainForm.mainPage.UpdateTickets();
                            }
                            catch (Exception ex)
                            { Console.WriteLine("Error: " + ex.Message); }
                            finally
                            { _isProcessing = false; }
                        });
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount format.");
                        _isProcessing = false;
                    }
                }
                else
                { Console.WriteLine("Request is already being processed."); }
                flagFrames.ChangeFlagsFrame();
                MainForm.topPanel = true;
                MainForm.frame5 = true;
            }
            clock.Restart();
            canClick = false;
        }
    }
    public void HistoryTickets(Texts text, string count, int id)
    {
        Database database = new Database();
        if (text.IfTexts("Общий"))
        {
            for (int i = 0; i < int.Parse(count); i++)
            { database.InsertHistoryTickets(id, 2); }
        }
        else if (text.IfTexts("Багажный"))
        {
            for (int i = 0; i < int.Parse(count); i++)
            { database.InsertHistoryTickets(id, 3); }
        }
        else if (text.IfTexts("Пенсионный"))
        {
            for (int i = 0; i < int.Parse(count); i++)
            { database.InsertHistoryTickets(id, 1); }
        }
    }
    private bool _isProcessing;
    public void workProgram(RenderWindow window)
    {
        Display(window);
        ButtonInteraction(window);
    }
    public void clic()
    {
        if (!canClick && clock.ElapsedTime.AsSeconds() >= clickDelay)
        { canClick = true; }
    }
    public void Display(RenderWindow _window)
    {
        backgroundLeft.Draw(_window);
        backgroundRight.Draw(_window);
        titleFrameText.Draw(_window);
        titleFrameTextRight.Draw(_window);
        backgroundTicketUpper.Draw(_window); 
        plusTicketUpper.Draw(_window);  
        minusTicketUpper.Draw(_window);  
        forCountUpper.Draw(_window);  
        countUpper.Draw(_window);
        if (ticketLower)
        {
            backgroundTicketLower.Draw(_window);
            forCountLower.Draw(_window); 
            plusTicketLower.Draw(_window); 
            minusTicketLower.Draw(_window); 
            countLower.Draw(_window);
        }
        if (ticketMiddle)
        {
            backgroundTicketMiddle.Draw(_window);
            forCountMiddle.Draw(_window);
            plusTicketMiddle.Draw(_window); 
            minusTicketMiddle.Draw(_window);  
            countMiddle.Draw(_window);
        }
        benefitsSharedText.Draw(_window);
        benefitsPensionText.Draw(_window);
        benefitsBaggageText.Draw(_window);
        lineText.Draw(_window);
        lineText2.Draw(_window);
        lineText3.Draw(_window);
        paymentText.Draw(_window);
        amountText.Draw(_window);
        warningPaymentText.Draw(_window);
        chooseBenefitsShared.Draw(_window);
        chooseBenefitsStudent.Draw(_window);
        chooseBenefitsPension.Draw(_window);
        lines.Draw(_window);
        buttonPayment.Draw(_window);
        paymentTitleText.Draw(_window);
        priceTicketUpper.Draw(_window);
        priceTicketMiddle.Draw(_window);
        priceTicketLower.Draw(_window);
        titleTicketUpper.Draw(_window);
        titleTicketMiddle.Draw(_window);
        titleTicketLower.Draw(_window);
        warningTextLower.Draw(_window);
        warningTextUpper.Draw(_window);
        warningTextMiddle.Draw(_window);
    }
    private Texts lineText;
    private Texts lineText2;
    private Texts lineText3;
    private Texts paymentText;
    private Texts amountText;
    private Texts warningPaymentText;
    private Texts titleFrameText;
    private Texts titleTicketUpper;
    private Texts benefitsSharedText;
    private Texts benefitsPensionText;
    private Texts benefitsBaggageText;
    private Texts priceTicketUpper;
    private Texts countUpper;
    private Texts countMiddle;
    private Texts countLower;
    private Texts paymentTitleText;
    private Texts titleFrameTextRight;
    private Texts priceTicketMiddle;
    private Texts priceTicketLower;
    private Texts titleTicketMiddle;
    private Texts titleTicketLower;
    private Texts warningTextLower;
    private Texts warningTextUpper;
    private Texts warningTextMiddle;
    private Texture chooseBenefitsOnTexture;
    private Texture chooseBenefitsOffTexture;
    private Button backgroundTicketUpper;
    private Button backgroundTicketLower;
    private Button backgroundTicketMiddle;
    private Button forCountUpper;
    private Button forCountMiddle;
    private Button forCountLower;
    private Button plusTicketUpper;
    private Button plusTicketLower;
    private Button plusTicketMiddle;
    private Button minusTicketUpper;
    private Button minusTicketLower;
    private Button minusTicketMiddle;
    private Button backgroundLeft;
    private Button backgroundRight;
    private Button chooseBenefitsShared;
    private Button chooseBenefitsStudent;
    private Button chooseBenefitsPension;
    private Button lines;
    private Button buttonPayment;
}