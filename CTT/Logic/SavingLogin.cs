namespace CTT;
using System;
using System.IO;
using System.Text.Json;
public class SavingLogin
{
    private static string filePath = "userdata.json";
    public static void SaveToJson(string name, string lname, string phoneNumber, string email, string password)
    {
        Database database = new Database();
        UserData userData = new UserData
        {
            Id = database.GetUserId(phoneNumber, email),
            Name = name,
            Lname = lname,
            PhoneNumber = phoneNumber,
            Email = email,
            Password = password
        };
        
        string jsonString = JsonSerializer.Serialize(userData);
        File.WriteAllText(filePath, jsonString);
    }
    
    public static void UpdatePasswordInJson(string newPassword)
    {
       
        string jsonString = File.ReadAllText(filePath);
        UserData userData = JsonSerializer.Deserialize<UserData>(jsonString);
            
        userData.Password = newPassword;
            
        string updatedJsonString = JsonSerializer.Serialize(userData, new JsonSerializerOptions { WriteIndented = true });
            
        File.WriteAllText(filePath, updatedJsonString);
      
    }
    public static void UpdateLoginAndUserNameInJson(string newlogin, string newUserName)
    {
       
        string jsonString = File.ReadAllText(filePath);
        UserData userData = JsonSerializer.Deserialize<UserData>(jsonString);
            
        userData.Name = newlogin;
        userData.Lname = newUserName;
        string updatedJsonString = JsonSerializer.Serialize(userData, new JsonSerializerOptions { WriteIndented = true });
            
        File.WriteAllText(filePath, updatedJsonString);
      
    }

    public static void cleanLoginData()
    {
  
        string json = File.ReadAllText(filePath);
        UserData loginData = JsonSerializer.Deserialize<UserData>(json);
        loginData.Id = 0;
        loginData.Name = "0";
        loginData.Lname = "0";
        loginData.Email = "0";
        loginData.Password = "0";
        loginData.PhoneNumber = "0";

        string updatedJson = JsonSerializer.Serialize(loginData, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, updatedJson);
    }

   

    public static string ReadNameFromFile()
    {
            string jsonString = File.ReadAllText(filePath);
            UserData userData = JsonSerializer.Deserialize<UserData>(jsonString);
            return userData.Name;
        
      
    }
    
    public static string ReadLNameFromFile()
    {
        try
        {
            string jsonString = File.ReadAllText(filePath);
            UserData userData = JsonSerializer.Deserialize<UserData>(jsonString);
            return userData.Lname;
        }
        catch (Exception)
        {
            return null;
        }
    }
    public static string ReadPasswordFromFile()
    {
        try
        {
            string jsonString = File.ReadAllText(filePath);
            UserData userData = JsonSerializer.Deserialize<UserData>(jsonString);
            string password = userData.Password;
            return new string('*', password.Length);
        }
        catch (Exception)
        {
            return null;
        }
    }
    public static string ReadPhoneNumberFromFile()
    {
        try
        {
            string jsonString = File.ReadAllText(filePath);
            UserData userData = JsonSerializer.Deserialize<UserData>(jsonString);
            return userData.PhoneNumber;
        }
        catch (Exception)
        {
            return null;
        }
    } 
    public static string ReadEmailFromFile()
    {
        try
        {
            string jsonString = File.ReadAllText(filePath);
            UserData userData = JsonSerializer.Deserialize<UserData>(jsonString);
            return userData.Email;
        }
        catch (Exception)
        {
            return null;
        }
    }
}

public class UserData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
}