namespace CTT;
using System;
using System.IO;
using System.Text.Json;

public class SavingLogin
{
    private static string filePath = "userdata.json";
    public static void SaveToJson(string name, string lname, string phoneNumber, string email, string password)
    {
        UserData userData = new UserData
        {
            Name = name,
            Lname = lname,
            PhoneNumber = phoneNumber,
            Email = email,
            Password = password
        };

        // Сериализуем объект в JSON
        string jsonString = JsonSerializer.Serialize(userData);
        File.WriteAllText(filePath, jsonString);

        Console.WriteLine("Данные успешно записаны в файл " + filePath);
    }

    public static bool AreValuesFilled()
    {
        try
        {
            // Читаем JSON из файла
            string jsonString = File.ReadAllText(filePath);

            // Десериализуем JSON в объект UserData
            UserData userData = JsonSerializer.Deserialize<UserData>(jsonString);

            // Проверяем, заполнены ли значения
            if (string.IsNullOrEmpty(userData.Name) ||
                string.IsNullOrEmpty(userData.Lname) ||
                string.IsNullOrEmpty(userData.PhoneNumber) ||
                string.IsNullOrEmpty(userData.Email) ||
                string.IsNullOrEmpty(userData.Password))
            {
                return false;
            }

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            return false;
        }
    }
    public static string ReadNameFromFile()
    {
        
        try
        {
            string jsonString = File.ReadAllText(filePath);
            
            UserData userData = JsonSerializer.Deserialize<UserData>(jsonString);
            
            return userData.Name;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            return null;
        }
    }
    
    public static string ReadLNameFromFile()
    {
        
        try
        {
            string jsonString = File.ReadAllText(filePath);
            
            UserData userData = JsonSerializer.Deserialize<UserData>(jsonString);
            
            return userData.Lname;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            return null;
        }
    }
    
}

public class UserData
{
    public string Name { get; set; }
    public string Lname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
}