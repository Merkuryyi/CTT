namespace CTT;

public class a
{
    
    //    x = 389;

    /*  if (textWidth > buttonWidth - 90)
      {
          flagP = true;
      }
      else
      {
          flagP = false;
          x = 171;
      }

      if (flagP)
      {
          Color baseColorText = new Color(68, 68, 69);

          Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");

          Texts currentText = new Texts(x,  350,
              font, 32, baseColorText, line);
          text.SetPosition(x - (int)currentText.GetGlobalBounds().Width, 350);
          x -= (int)currentText.GetGlobalBounds().Width;
      }
      else
      {
         // x = 389;
      }*/
    
    
    
    /*   if (flagP)
            {

                Font font = new Font("C:\\Windows\\Fonts\\Arial.ttf");





                switch (e.Code)
                {
                    case Keyboard.Key.BackSpace:
                        if (cursor > 0)
                        {
                            // Получаем символ, который нужно удалить
                            char characterToRemove = line[cursor - 1];

                            // Удаляем символ из строки
                            line = line.Remove(cursor - 1, 1);
                            cursor--;

                            // Обновляем позицию x
                            Text tempText = new Text(characterToRemove.ToString(), font, 32);
                            x -= (int)tempText.GetGlobalBounds().Width; // Уменьшаем x
                            text.SetPosition(x, 350);
                        }
                        break;

                    case Keyboard.Key.Delete:
                        if (cursor < line.Length)
                        {
                            line = line.Remove(cursor, 1);
                        }
                        break;

                    case Keyboard.Key.Left:
                        if (cursor > 0)
                        {
                            cursor--;
                        }
                        break;

                    case Keyboard.Key.Right:
                        if (cursor < line.Length)
                        {
                            cursor++;
                        }
                        break;
                }
            }
            else
            {*/
    
    /*   private static Button Buttons;
    private static Texts TextBox;
    private static int Cursors;
    public static string Line;
    private static bool Flag = true;
    private static bool IsVisible = false; */



    //  private static int x;
    /*    public InputLine(Button button, Texts text, int cursor, string line, bool flag, bool isVisible)
        {
            Buttons = button;
            TextBox = text;
            Cursors = cursor;
            Line = line;
            Flag = flag;
            IsVisible = isVisible;
     } */
    
    
    /*public void parametr()
        {
            if (Frame2.flagLName)
            {
                button = Frame2.buttonLNameSprite;
                text = Frame2.lNameMiniText;
                flag = Frame2.flagLName;
            }
            else if (Frame2.flagName)
            {
                button = Frame2.buttonNameSprite;
                text = Frame2.nameMiniText;
                flag = Frame2.flagName;
            }
            else if (Frame2.flagPassword)
            {
                button = Frame2.buttonPasswordSprite;
                text = Frame2.passwordMiniText;
                flag = Frame2.flagPassword;
                isVisible = Frame2.isVisiblePassword;
            }
            else if (Frame2.flagRepeatPassword)
            {
                button = Frame2.buttonRepeatPasswordSprite;
                text = Frame2.repeatPasswordMiniText;
                flag = Frame2.flagRepeatPassword;
                isVisible = Frame2.isVisibleRepeatPassword;
            }
            else if (Frame2.flagNumberPhone)
            {
                button = Frame2.buttonNumberPhoneSprite;
                text = Frame2.numberPhoneMiniText;
                flag = Frame2.flagNumberPhone;

            }
            else if (Frame2.flagEmail)
            {
                button = Frame2.buttonEmailSprite;
                text = Frame2.emailMiniText;
                flag = Frame2.flagEmail;

            }
            else if (Frame3.flagNumberPhone)
            {
                
            }
        }*/
    
    /*
    private static Button button;
    private static Texts text;
    private static int cursor;
    public static string line;
    private static bool flag = true;
    private static bool isVisible = false;
    
    
        public void ClearLine()
        {
            if (Frame2.flagName)
            {
                line = Frame2.nameMiniTextFrame2;
                cursor = Frame2.cursorNamePosition;
            }
            else if (Frame2.flagLName)
            {
                line = Frame2.lMiniTextFrame2;
                cursor = Frame2.cursorLnamePosition;
            }
            else if (Frame2.flagPassword)
            {
                line = Frame2.passwordMiniTextFrame2;
                cursor = Frame2.cursorPasswordPosition;
            }
            else if (Frame2.flagRepeatPassword)
            {
                line = Frame2.repeatPasswordMiniTextFrame2;
                cursor = Frame2.cursorRepeatPasswordPosition;
            }
            else if (Frame2.flagNumberPhone)
            {
                line = Frame2.numberPhoneMiniTextFrame2;
                cursor = Frame2.cursorNumberPhonePosition;
            }
            else if (Frame2.flagEmail)
            {
                line = Frame2.emailMiniTextFrame2;
                cursor = Frame2.cursorEmailPosition;
            }

        }
         private static Button Buttons;
        private static Texts TextBox;
        private static int Cursors;
        public static string Line;
        private static bool Flag = true;
        private static bool IsVisible = false;
       
        
        
      //  private static int x;
      public InputLine(Button buttons, Texts textBox, int cursors, string line, bool flag, bool isVisible)
      {
          Buttons = button;
          TextBox = textBox;
          Cursors = cursor;
          Line = line;
          Flag = flag;
      }*/
    
}