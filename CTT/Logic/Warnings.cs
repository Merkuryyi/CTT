namespace CTT.Frame;

public class Warnings
{
    private static bool flag;

    public bool GetWarningFlag()
    {
        return flag;
    }

    public string WarningLineName(string line)
    {
        string warning = "";
        Database database = new Database();
        if (line == "")
        {
            flag = true;
            warning = "*обязательно";
        }
        else if (database.uniqueNumberPhone(line))
        {
            flag = true;
            warning = "*Не уникально";
        }
        else if (line.Length < 6)
        {
            flag = true;
            warning = "*Длина должна быть более 6";
        }
       else
       {
           flag = false;
       }
        return warning;
       
    }
    public string WarningLinePassword(string line)
    {
        string warning = "";
        InputLine lines = new InputLine();
        if (line == "")
        {
            flag = true;
            warning = "*обязательно";
        }
        else if (line.Length < 6)
        {
               
            flag = true;
            warning = "*Длина должна быть более 6";
        }
        else if (!lines.ContainsSpecialCharsOrDigits())
        {
            
            flag = true;
            warning = "*необходимы цифры, спецсимволы, буквы";
        }
        else
        {
            flag = false;
        }
        return warning;
    }
    public string WarningLineNumberPhone(string line)
    {
        InputLine lines = new InputLine();
        string warning = "";
        bool format = lines.NumberPhoneFormat(line);
        Database database = new Database();
        if (line == "")
        {
            flag = true;
            warning = "*обязательно";
        }
        else if (database.uniqueNumberPhone(line))
        {
            flag = true;
            warning = "*Не уникально";
        }
        else if (!format)
        {
            flag = true;
            warning = "*Неверный формат";
        }
        
        else
        {
            flag = false;
        }
        return warning;
    }
    public string WarningLineNumberPhoneLogin(string line)
    {
        InputLine lines = new InputLine();
        string warning = "";
        bool format = lines.NumberPhoneFormat(line);
        if (line == "")
        {
            flag = true;
            warning = "*обязательно";
        }
        else if (!format)
        {
            flag = true;
            warning = "*Неверный формат";
        }
        
        else
        {
            flag = false;
        }
        return warning;
    }
    public string WarningLineEmail(string line)
    {
        InputLine lines = new InputLine();
        string warning = "";
        bool formatEmail = lines.EmailFormat(line);
       
        if (line == "")
        {
            flag = true;
            warning = "*обязательно";
        }
        else if (!formatEmail)
        {
               
            flag = true;
            warning = "*Неверный формат";
        }
       
        else
        {
            flag = false;
        }
        return warning;
    }
    public string WarningLineRepeatPassword(string repeatPassword, string password)
    {
        
        InputLine lines = new InputLine();
        string warning = "";
        if (password == "")
        {
            flag = true;
            warning = "*обязательно";
        }
        else if (password.Length < 6)
        {
               
            flag = true;
            warning = "*Длина должна быть более 6";
        }
        else if (repeatPassword != password)
        {
            warning = "*пароли не совпадают";
        }
        else if (!lines.ContainsSpecialCharsOrDigits())
        {
            
            flag = true;
            warning = "*необходимы цифры, спецсимволы";
        }
        else
        {
            flag = false;
        }
        return warning;
    }
    public string WarningLineCode(string code, string number)
    {
        string warning = "";
        if (code == "")
        {
            flag = true;
            warning = "*обязательно";
        }
        else if (code != number)
        {
            warning = "*неверный код";
        }
        
        else
        {
            flag = false;
        }
        return warning;
    }
    
}