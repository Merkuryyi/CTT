namespace CTT;
using Npgsql;
using System;

public class Database
{
    private static bool read;

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
            $"insert into users(Login, username, NumberPhone, Email, Password) values('{name}','{lname}', '{numberPhone}','{email}','{password}' )",
            conn);
        command.ExecuteNonQuery();
        conn.Close();
    }

    public bool loginUser(string numberPhone, string email, string password)
    {
        var conn = GetSqlConnection();
        bool flag = true;

        NpgsqlCommand command = new NpgsqlCommand(
            $"SELECT COUNT(*) FROM users WHERE NumberPhone = '{numberPhone}' and email = '{email}' and password = '{password}'",
            conn);
        int count = Convert.ToInt32(command.ExecuteScalar());
        conn.Close();
        if (count == 1)
        {
            Console.WriteLine("fff");
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
            $"update users set password = '{newPassword}' where NumberPhone = '{numberPhone}' and Email = '{email}'",
            conn);
        command.ExecuteNonQuery();
        conn.Close();
    }

    public void updateNameUser(string numberPhone, string email, string newLogin, string newUserName)
    {
        var conn = GetSqlConnection();
        NpgsqlCommand command = new NpgsqlCommand(
            $"update users set login = '{newLogin}' where NumberPhone = '{numberPhone}' and Email = '{email}'", conn);
        NpgsqlCommand commandUserNameUpdate = new NpgsqlCommand(
            $"update users set username = '{newUserName}' where NumberPhone = '{numberPhone}' and Email = '{email}'",
            conn);
        command.ExecuteNonQuery();
        commandUserNameUpdate.ExecuteNonQuery();
        conn.Close();
    }

    public void notificationsAdd(int id, string action, string actionMoney)
    {
        var conn = GetSqlConnection();
        NpgsqlCommand command = new NpgsqlCommand(
            $"INSERT INTO Notifications (IdUsers, status, action, actionMoney, date) VALUES('{id}', 'unread', '{action}', '{actionMoney}', now())",
            conn);
        command.ExecuteNonQuery();
        conn.Close();
    }

    public void notificationsUpdate(string id)
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
                command.Parameters.AddWithValue("login", id);

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

    public DateTime? notificationDateGetRead()
    {
        DateTime? latestDate = null;

        var conn = GetSqlConnection();



        using (conn)
        {
            string query = @"
                SELECT MAX(Date)
                FROM Notifications where status = 'read'";

            using (var command = new NpgsqlCommand(query, conn))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            latestDate = reader.GetDateTime(0);
                        }
                    }
                }
            }
        }

        return latestDate;

    }

    public DateTime? notificationDateGetUnread()
    {
        DateTime? latestDate = null;

        var conn = GetSqlConnection();

        using (conn)
        {
            string query = @"
               SELECT min(Date) FROM Notifications where status = 'unread'";

            using (var command = new NpgsqlCommand(query, conn))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            latestDate = reader.GetDateTime(0);
                        }
                    }
                }
            }
        }

        return latestDate;


    }


       public string notificationGet(int userId)
    {
        string result = null;
     
        var conn = GetSqlConnection();

        using (conn)
        {
            string queryUnread = @"
                SELECT 
                    CONCAT(
                        Action, 
                        CASE 
                            WHEN Action IN ('Списание', 'Пополнение') THEN ': ' || COALESCE(ActionMoney::TEXT, '') || '₽'
                            ELSE ''
                        END
                    ) AS ActionWithMoney
                FROM Notifications
                WHERE IdUsers = @IdUsers AND Status = 'unread'
                ORDER BY Date ASC
                LIMIT 1";

            using (var commandUnread = new NpgsqlCommand(queryUnread, conn))
            {
                commandUnread.Parameters.AddWithValue("IdUsers", NpgsqlTypes.NpgsqlDbType.Integer, userId);

                using (var readerUnread = commandUnread.ExecuteReader())
                {
                    if (readerUnread.Read())
                    {
                        result = readerUnread.GetString(0);
                    }
                }
            }

            if (result == null)
            {
                string queryRead = @"
                    SELECT 
                        CONCAT(
                            Action, 
                            CASE 
                                WHEN Action IN ('Списание', 'Пополнение') THEN ': ' || COALESCE(ActionMoney::TEXT, '') || '₽'
                                ELSE ''
                            END
                        ) AS ActionWithMoney
                    FROM Notifications
                    WHERE IdUsers = @IdUsers AND Status = 'read'
                    ORDER BY Date DESC
                    LIMIT 1";

                using (var commandRead = new NpgsqlCommand(queryRead, conn))
                {
                    commandRead.Parameters.AddWithValue("IdUsers", NpgsqlTypes.NpgsqlDbType.Integer, userId);

                    using (var readerRead = commandRead.ExecuteReader())
                    {
                        if (readerRead.Read())
                        {
                            result = readerRead.GetString(0);
                        }
                    }
                }
            }
        }

        return result;
    }

    public int GetUserId(string numberPhone, string email)
    {
        var conn = GetSqlConnection();
        using (conn)
        {
            string query = @"
                SELECT Id_Users
                FROM Users
                WHERE Email = @email AND NumberPhone = @numberPhone";

            using (var command = new NpgsqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("email", NpgsqlTypes.NpgsqlDbType.Text, email);
                command.Parameters.AddWithValue("numberPhone", NpgsqlTypes.NpgsqlDbType.Text, numberPhone);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
        }

        return 0;
    }

    public int notificationsCount(int id)
        {
            var conn = GetSqlConnection();
            NpgsqlCommand command = new NpgsqlCommand(
                $"select count(*) from notifications where Status = 'unread' and idusers = '{id}' ", conn);
            int count = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return count;
        }

        public (string FirstName, string LastName) GetUserFullName(string numberPhone, string email, string password)
        {
            var conn = GetSqlConnection();
            NpgsqlCommand command = new NpgsqlCommand(
                $"SELECT Login, username FROM users WHERE NumberPhone = '{numberPhone}' and Email = '{email}' and password = '{password}'",
                conn);

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
