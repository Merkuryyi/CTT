namespace CTT.Frame;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Frame6
{
    
    private static Clock clock;
    private static float clickDelay;
    private Database database;
    private FlagFrames flagFrames;
    private Vector2i mousePosition;
    private Button backgroundLeft;
    private Button backgroundRight;
    private Texts titleFrameText;
    private Texts monthText;
    private Texts titleTicketUpper;
    private Texts benefitsSharedText;
    private Texts benefitsPensionText;
    private Texts benefitsStudentText;

    private Texts priceTicketUpper;
    private string warningDocument;
    private string warning;
    private Texts warningText;
    private Texts lineText;
    private Texts lineText2;
    private Texts lineText3;
    private Texts paymentText;
    private Texts amountText;
    private Texts warningPaymentText;
    private Button chooseBenefitsShared;
    private Button chooseBenefitsStudent;
    private Button chooseBenefitsPension;
    private Button lines;
    
    private Button qrCode;
    private Button buttonPayment;
    private Texts paymentTitleText;
    private Texts titleFrameTextRight;
    private Texture chooseBenefitsOnTexture;
    private Texture chooseBenefitsOffTexture;
    private string benefitsShared;
    private string benefitsPension;
    private string benefitsStudent;
    private static bool canClick;
    private static bool ticketUpper = false;
    private static bool ticketMiddle = false;
    private static bool ticketLower = false;
   // public float amount;
    private string amount;
    private Texts priceTicketMiddle;
    private Texts priceTicketLower;
    private string priceShare;
    private string priceStudent;
    private string pricePension;
    private Texts titleTicketMiddle;
    private Texts titleTicketLower;


    public void Display(RenderWindow _window)
    {
        backgroundLeft.Draw(_window);
        backgroundRight.Draw(_window);
        titleFrameText.Draw(_window);
        titleFrameTextRight.Draw(_window);
        monthText.Draw(_window);
       
        benefitsSharedText.Draw(_window);
        benefitsPensionText.Draw(_window);
        benefitsStudentText.Draw(_window);
        
        
        warningText.Draw(_window);
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
      
        qrCode.Draw(_window);
        buttonPayment.Draw(_window);
        paymentTitleText.Draw(_window);
        titleTicketUpper.Draw(_window);
     
        priceTicketUpper.Draw(_window);
        
        
        
        priceTicketMiddle.Draw(_window);
        priceTicketLower.Draw(_window);
        if (ticketMiddle)
        {
            titleTicketMiddle.Draw(_window);
        }
        if (ticketLower)
        {
            titleTicketLower.Draw(_window);
        }
        
        
        
    }
    private string GetMonthName()
    {
        DateTime currentDate = DateTime.Now;
        DateTime monthToReturn = currentDate.Day <= 15 ? currentDate : currentDate.AddMonths(1);
        string monthName = monthToReturn.ToString("MMMM");
        string capitalizedMonthName = char.ToUpper(monthName[0]) + monthName.Substring(1).ToLower();

        return capitalizedMonthName;
    }
    public void Structure()
    {
        clock = new Clock();
        clickDelay = 0.3f;   
        database = new Database();
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
        
        Texture qrCodeTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "qrCode.png"));
        Texture buttonPaymentTexture =
            new Texture(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Frames", "buttonPayment.png"));
        backgroundLeft = new Button(53, 170, backgroundLeftTexture);
        backgroundRight = new Button(994, 170, backgroundRightTexture);
        chooseBenefitsShared = new Button(114, 310, chooseBenefitsOnTexture);
        chooseBenefitsStudent = new Button(285, 310, chooseBenefitsOffTexture);
        chooseBenefitsPension = new Button(530, 310, chooseBenefitsOffTexture);
        lines = new Button(114, 376, lineTexture);
     
        qrCode = new Button(1283, 437, qrCodeTexture);
        buttonPayment = new Button(1310, 878, buttonPaymentTexture);
        
        string titleFrame = "Купить проездной:";
        
        benefitsShared = "Общий";
        benefitsPension = "Пенсионный";
        benefitsStudent = "Студенческий";
        
        
       //"\u20bd";

        priceShare = database.ticketCardPriceGet(benefitsShared);
        priceStudent = database.ticketCardPriceGet(benefitsStudent);
        pricePension = database.ticketCardPriceGet(benefitsPension);
        amount = database.ticketCardPriceGet(benefitsPension);
        
        
        warningDocument = "*необходим документ, можно купить только 1 за месяц";
        warning = "*можно купить только 1 за месяц";
        
        
        string titleFrameRight = "Оплата проездного билета";
        string line = "Для оплаты проезда нажмите “оплатить”, а после  предъявите ";
        string line2 = "необходимые документы кондуктору транспортного средства.";
        string line3 = "Хорошей поездки!";
        string payment = "К оплате:";

        string paymentTitle = "Оплатить";
        string warningPayment = "*недостаточно средств";
        Color baseColorText = new Color(68, 68, 69);
        Color warningTextColor = new Color(202, 128, 128);
        Color colorMessage = new Color(136, 136, 136);
        
        titleFrameText = new Texts(114, 237, font, 36, baseColorText, titleFrame);
        monthText = new Texts(530, 237, font, 36, baseColorText, GetMonthName());
        
        benefitsSharedText = new Texts(169, 313, font, 24, baseColorText, benefitsShared);
        benefitsPensionText = new Texts(585, 313, font, 24, baseColorText, benefitsPension);
        benefitsStudentText = new Texts(340, 313, font, 24, baseColorText, benefitsStudent);
        
        titleTicketUpper = new Texts(293, 423, font, 36, baseColorText, benefitsShared);
        titleTicketMiddle = new Texts(293, 623, font, 36, baseColorText, "");
        titleTicketLower = new Texts(293, 823, font, 36, baseColorText, "");
        
        
        priceTicketUpper = new Texts(133, 513, font, 24, baseColorText, priceShare);
        priceTicketMiddle = new Texts(133, 713, font, 24, baseColorText, "");
        priceTicketLower = new Texts(133, 913, font, 24, baseColorText, "");
        
        warningText = new Texts(134, 660, font, 20, warningTextColor, warning);
        titleFrameTextRight = new Texts(1037, 237, font, 36, baseColorText, titleFrameRight);
        
        lineText = new Texts(1037, 309, font, 24, colorMessage, line);
        lineText2 = new Texts(1037, 345, font, 24, colorMessage, line2);
        lineText3 = new Texts(1037, 379, font, 24, colorMessage, line3);
        paymentText = new Texts(1345, 739, font, 36, baseColorText, payment);
        amountText = new Texts(1345, 786, font, 36, baseColorText, priceShare);
        warningPaymentText = new Texts(1315, 838, font, 20, warningTextColor, warningPayment);
        
        paymentTitleText = new Texts(1345, 886, font, 36, baseColorText, paymentTitle);
        //amount = float.Parse(priceTravelTicket);
    }

    private void setTitleTicket(RenderWindow _window)
    {
        if (priceTicketUpper.IfTexts(priceShare))
        {
            titleTicketUpper.SetText(benefitsShared);
        }

        if (priceTicketLower.IfTexts(priceShare))
        {
            titleTicketLower.SetText(benefitsShared);
        }
    }
    private void ButtonInteraction(RenderWindow _window)
    {
        mousePosition = Mouse.GetPosition(_window);
        if (_window.IsOpen && Mouse.IsButtonPressed(Mouse.Button.Left) && canClick)
        {
            if (chooseBenefitsShared.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (chooseBenefitsShared.IfTexture(chooseBenefitsOffTexture))
                {
                    chooseBenefitsShared.SetTexture(chooseBenefitsOnTexture);
                  //  priceTicketUpper.SetText(database.ticketCardPriceGet(benefitsShared));
                    amountText.SetText(database.ticketCardPriceGet(benefitsShared));
                    titleTicketUpper.SetText(benefitsShared);
                 //   amount = database.ticketCardPriceGet(benefitsShared);
                    if (priceTicketUpper.IfTexts(""))
                    {
                        priceTicketUpper.SetText(priceShare);
                    }
                    else if (priceTicketMiddle.IfTexts(""))
                    {
                        priceTicketMiddle.SetText(priceShare);
                    }
                    else if (priceTicketLower.IfTexts(""))
                    {
                        priceTicketLower.SetText(priceShare);
                    }
                    
                }
                else
                {
                    if (chooseBenefitsPension.IfTexture(chooseBenefitsOnTexture) || chooseBenefitsStudent.IfTexture(chooseBenefitsOnTexture))
                    {
                        chooseBenefitsShared.SetTexture(chooseBenefitsOffTexture);
                        if (priceTicketUpper.IfTexts(priceShare))
                        {
                            priceTicketUpper.SetText("");
                            if (!priceTicketMiddle.IfTexts(""))
                            {
                                priceTicketUpper.SetText(priceTicketMiddle.GetTextString());
                                titleTicketUpper.SetText(titleTicketMiddle.GetTextString());
                                priceTicketMiddle.SetText("");
                                //title not work!!!!!!!!!!
                                titleTicketUpper.SetText("");
                                ticketMiddle = false;
                                if (!priceTicketLower.IfTexts(""))
                                {
                                    priceTicketMiddle.SetText(priceTicketLower.GetTextString());
                                    priceTicketLower.SetText("");
                                    ticketMiddle = true;
                                    ticketLower = false;
                                }
                            }
                        }
                        else if (priceTicketMiddle.IfTexts(priceShare))
                        {
                            priceTicketMiddle.SetText("");
                            ticketMiddle = false;
                            if (!priceTicketLower.IfTexts(""))
                            {
                                priceTicketMiddle.SetText(priceTicketLower.GetTextString());
                                priceTicketLower.SetText("");
                                ticketMiddle = true;
                                ticketLower = false;
                                
                            }
                            
                        }
                        else if (priceTicketLower.IfTexts(priceShare))
                        {
                            priceTicketLower.SetText("");
                            ticketLower = false;
                        }
                        
                        
                    }
                }
            }
            if (chooseBenefitsStudent.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (chooseBenefitsStudent.IfTexture(chooseBenefitsOffTexture))
                {
                    chooseBenefitsStudent.SetTexture(chooseBenefitsOnTexture);
                  //  priceTicketUpper.SetText(database.ticketCardPriceGet(benefitsStudent));
                    amountText.SetText(database.ticketCardPriceGet(benefitsStudent));
                    titleTicketUpper.SetText(benefitsStudent);
                   // amount = database.ticketCardPriceGet(benefitsStudent);
                   if (priceTicketMiddle.IfTexts("") && priceTicketLower.IfTexts("") && priceTicketUpper.IfTexts(""))
                   {
                       priceTicketUpper.SetText(priceStudent);
                   }
                   else if (priceTicketMiddle.IfTexts("") && priceTicketLower.IfTexts("") && !priceTicketUpper.IfTexts(""))
                   {
                       priceTicketMiddle.SetText(priceStudent);
                   }
                   else if (!priceTicketMiddle.IfTexts("") && priceTicketLower.IfTexts("") && !priceTicketUpper.IfTexts(""))
                   {
                       priceTicketLower.SetText(priceStudent);
                   }
                }
                else
                {
                    if (chooseBenefitsShared.IfTexture(chooseBenefitsOnTexture) || chooseBenefitsShared.IfTexture(chooseBenefitsOnTexture))
                    {
                        chooseBenefitsStudent.SetTexture(chooseBenefitsOffTexture);
                        
                        
                        if (priceTicketUpper.IfTexts(priceStudent))
                        {
                            priceTicketUpper.SetText("");
                            if (!priceTicketMiddle.IfTexts(""))
                            {
                                priceTicketUpper.SetText(priceTicketMiddle.GetTextString());
                                priceTicketMiddle.SetText("");
                                ticketMiddle = false;
                                if (!priceTicketLower.IfTexts(""))
                                {
                                    priceTicketMiddle.SetText(priceTicketLower.GetTextString());
                                    priceTicketLower.SetText("");
                                    ticketMiddle = true;
                                    ticketLower = false;

                                }
                                
                            }
                          
                            
                        }
                        else if (priceTicketMiddle.IfTexts(priceStudent))
                        {
                            priceTicketMiddle.SetText("");
                            ticketMiddle = false;
                            if (!priceTicketLower.IfTexts(""))
                            {
                                priceTicketMiddle.SetText(priceTicketLower.GetTextString());
                                priceTicketLower.SetText("");
                                ticketMiddle = true;
                                ticketLower = false;
                                
                                
                            }
                        }
                        else if (priceTicketLower.IfTexts(priceStudent))
                        {
                            priceTicketLower.SetText("");
                            ticketLower = false;
                        }
                    }
                }
            }
            if (chooseBenefitsPension.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                if (chooseBenefitsPension.IfTexture(chooseBenefitsOffTexture))
                {
                    chooseBenefitsPension.SetTexture(chooseBenefitsOnTexture);
                  //  priceTicketUpper.SetText(database.ticketCardPriceGet(benefitsPension));
                    amountText.SetText(database.ticketCardPriceGet(benefitsPension));
                    titleTicketUpper.SetText(benefitsPension);
                  //  amount = database.ticketCardPriceGet(benefitsPension);
                  if (priceTicketMiddle.IfTexts("") && priceTicketLower.IfTexts("") && priceTicketUpper.IfTexts(""))
                  {
                      priceTicketUpper.SetText(pricePension);
                  }
                  else if (priceTicketMiddle.IfTexts("") && priceTicketLower.IfTexts("") && !priceTicketUpper.IfTexts(""))
                  {
                      priceTicketMiddle.SetText(pricePension);
                  }
                  else if (!priceTicketMiddle.IfTexts("") && priceTicketLower.IfTexts("") && !priceTicketUpper.IfTexts(""))
                  {
                      priceTicketLower.SetText(pricePension);
                  }
                }
                else
                {
                    if (chooseBenefitsShared.IfTexture(chooseBenefitsOnTexture) || chooseBenefitsStudent.IfTexture(chooseBenefitsOnTexture))
                    {
                        chooseBenefitsPension.SetTexture(chooseBenefitsOffTexture);
                        
                        
                        if (priceTicketUpper.IfTexts(pricePension))
                        {
                            priceTicketUpper.SetText("");
                            if (!priceTicketMiddle.IfTexts(""))
                            {
                                priceTicketUpper.SetText(priceTicketMiddle.GetTextString());
                                priceTicketMiddle.SetText("");
                                ticketMiddle = false;
                                if (!priceTicketLower.IfTexts(""))
                                {
                                    priceTicketMiddle.SetText(priceTicketLower.GetTextString());
                                    priceTicketLower.SetText("");
                                    ticketMiddle = true;
                                    ticketLower = false;
                                
                                }
                                
                            }
                          
                            
                        }
                        else if (priceTicketMiddle.IfTexts(pricePension))
                        {
                            priceTicketMiddle.SetText("");
                            ticketMiddle = false;
                            if (!priceTicketLower.IfTexts(""))
                            {
                                priceTicketMiddle.SetText(priceTicketLower.GetTextString());
                                priceTicketLower.SetText("");
                                ticketLower = false;
                                ticketMiddle = true;
                                
                            }
                        }
                        else if (priceTicketLower.IfTexts(pricePension))
                        {
                            priceTicketLower.SetText("");
                            ticketLower = false;
                        }
                        
                    }
                    
                }
            }

            if (buttonPayment.GetGlobalBounds().Contains(mousePosition.X, mousePosition.Y))
            {
                string numberPhone = WorkWithJson.ReadPhoneNumberFromFile();
                string email = WorkWithJson.ReadEmailFromFile();
                int id = database.GetUserId(numberPhone, email);
               database.notificationsAdd(id, "Списание", amount);
               //yfgbcfnm ,fkfyc
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