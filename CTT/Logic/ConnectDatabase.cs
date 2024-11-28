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
    public void notificationsUpdate(string login)
    {
        string result = null;
        var conn = GetSqlConnection();
        using (conn)
        {
     

            string query = @"UPDATE Notifications
                SET Status = 'read'
                WHERE IdNotifications = (
                    SELECT IdNotifications
                    FROM Notifications
                    WHERE Login = @login AND Status = 'unread'
                    ORDER BY Date ASC
                    LIMIT 1);	";

            using (var command = new NpgsqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("login", login);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = reader.GetString(0);
                    }
                }
            }
        }

    }
    public string notificationGet(string login)
    {
        string result = null;
        var conn = GetSqlConnection();
        using (conn)
        {
     

            string query = @"
                SELECT Action
                FROM Notifications
                WHERE Login = @login AND Status = 'unread'
                ORDER BY Date asc
                LIMIT 1";

            using (var command = new NpgsqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("login", login);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = reader.GetString(0);
                    }
                }
            }
        }

        return result;
    }
    public int notificationsCount()
    {
        var conn = GetSqlConnection();
        NpgsqlCommand command = new NpgsqlCommand(
            $"select count(*) from notifications where Status = 'unread'", conn);
        int count = Convert.ToInt32(command.ExecuteScalar());
        conn.Close();
        return count;
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