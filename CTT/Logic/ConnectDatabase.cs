namespace CTT;
using Npgsql;
using System;

public class Database
{
    public NpgsqlConnection GetSqlConnection()
    {
        NpgsqlConnection conn =
        new NpgsqlConnection(@"Host=localhost;Username=postgres;Password=62389trewq%Y;Database=stt");
        conn.Open();
        return conn;
    }

    public void registrationUser(string name, string lname, string numberPhone, string email, string password)
    {
        var conn = GetSqlConnection();
        NpgsqlCommand command = new NpgsqlCommand(
            $"insert into users(Login, username, NumberPhone, Email, Password) values('{name}','{lname}', '{numberPhone}','{email}','{password}' )", conn);
        command.ExecuteNonQuery();
        conn.Close();
    }

    public bool loginUser(string numberPhone, string email, string password)
    {
        var conn = GetSqlConnection();
        bool flag = true;

        NpgsqlCommand command = new NpgsqlCommand(
            $"SELECT COUNT(*) FROM users WHERE NumberPhone = '{numberPhone}' and email = '{email}' and password = '{password}'", conn);
        int count = Convert.ToInt32(command.ExecuteScalar());
        conn.Close();
        if (count == 1)
        {
            return true;
        }
        return false;
    }

    public bool uniqueNumberPhone(string numberPhone)
    {
        var conn = GetSqlConnection();
        bool flag = true;

        NpgsqlCommand command = new NpgsqlCommand(
            $"SELECT COUNT(*) FROM users WHERE NumberPhone = '{numberPhone}'", conn);
        int count = Convert.ToInt32(command.ExecuteScalar());
        conn.Close();
        if (count == 1)
        {
            return true;
        }
        return false;
    }
    public void updateUser(string numberPhone, string email, string newPassword)
    {
        var conn = GetSqlConnection();
        NpgsqlCommand command = new NpgsqlCommand(
            $"update users set password = '{newPassword}' where NumberPhone = '{numberPhone}' and Email = '{email}'", conn);
        command.ExecuteNonQuery();
        conn.Close();
    }
    public void notificationsAdd(string login, string action, string actionMoney)
    {
        var conn = GetSqlConnection();
        NpgsqlCommand command = new NpgsqlCommand(
            $"INSERT INTO Notifications (Login, status, action, actionMoney, date)VALUES('{login}', 'unread', '{action}', '{actionMoney}', now())", conn);
        command.ExecuteNonQuery();
        conn.Close();
    }
    
    public (string FirstName, string LastName) GetUserFullName(string numberPhone, string email, string password)
    {
        var conn = GetSqlConnection();
        NpgsqlCommand command = new NpgsqlCommand(
            $"SELECT Login, username FROM users WHERE NumberPhone = '{numberPhone}' and Email = '{email}' and password = '{password}'", conn);

        using (var reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                string firstName = reader.GetString(0);
                string lastName = reader.GetString(1);
                conn.Close();
                return (firstName, lastName);
            }
        }

        conn.Close();
        return (null, null);
    }
}