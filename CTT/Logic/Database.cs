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
        try
        {
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
        }
        catch (Exception)
        {
            return false;
        }

        return false;
    }

    public bool uniqueNumberPhone(string numberPhone)
    {
        var conn = GetSqlConnection();
        try
        {
            bool flag = true;

            NpgsqlCommand command = new NpgsqlCommand(
                $"SELECT COUNT(*) FROM users WHERE NumberPhone = '{numberPhone}'", conn);
            int count = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            if (count == 1)
            {
                return true;
            }
        }
        catch (Exception)
        {
            return false;
        }
        return false;
    }

    public void updateUser(string numberPhone, string email, string newPassword)
    {
        var conn = GetSqlConnection();
        try
        {
            NpgsqlCommand command = new NpgsqlCommand(
                $"update users set password = '{newPassword}' where NumberPhone = '{numberPhone}' and Email = '{email}'",
                conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception ex)
        {
           Console.WriteLine(ex);
        }
      
    }

    public void updateNameUser(string numberPhone, string email, string newLogin, string newUserName)
    {
        try
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
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
       
    }

    public void notificationsAdd(int id, string action, string actionMoney)
    {
        try
        {
            var conn = GetSqlConnection();
            NpgsqlCommand command = new NpgsqlCommand(
                $"INSERT INTO Notifications (IdUsers, status, action, actionMoney, date) VALUES('{id}', 'unread', '{action}', '{actionMoney}', now())",
                conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void notificationsUpdate(string id)
    {
        try
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
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public DateTime? notificationDateGetRead()
    {
        DateTime? latestDate = null;
        try
        {
            latestDate = null;
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

          
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            latestDate = null;
        }
        
        return latestDate;

    }

    public DateTime? notificationDateGetUnread()
    {
        DateTime? latestDate = null;
        try
        {
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
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
        return latestDate;
    }


       public string notificationGet(int userId)
    {
        string result = null;
        try
        {
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
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
      

        return result;
    }

    public int GetUserId(string numberPhone, string email)
    {
        var conn = GetSqlConnection();
        try
        {
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
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return 0;
        }
        return 0;
    }

    public int notificationsCount(int id)
    {
        try
        {
            var conn = GetSqlConnection();
            NpgsqlCommand command = new NpgsqlCommand(
                $"select count(*) from notifications where Status = 'unread' and idusers = '{id}' ", conn);
            int count = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return count;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return 0;
        }
    }

    public (string FirstName, string LastName) GetUserFullName(string numberPhone, string email, string password)
    {
        try
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
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return (null, null);
        }
        return (null, null);
    }
    public string ticketPriceGet(string ticketName)
    {
        string ticketPrice = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = "SELECT CONCAT(ticketPrice, '\u20bd') FROM tickets WHERE ticketName = @ticketName";
                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("ticketName", ticketName);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ticketPrice = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            ticketPrice = null;
        }
        return ticketPrice;
    }
    public string ticketDecriptionGet(string ticketName)
    {
        string ticketDecription = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = "SELECT ticketDescription FROM tickets WHERE ticketName = @ticketName";
                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("ticketName", ticketName);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ticketDecription = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            ticketDecription = null;
        }
        return ticketDecription;
    }
    public string ticketCardPriceGet(string ticketName)
    {
        string ticketPrice = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = "SELECT CONCAT(ticketCardsPrice, '\u20bd') FROM ticketCards WHERE ticketCardName = @ticketName";
                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("ticketName", ticketName);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ticketPrice = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            ticketPrice = null;
        }
        return ticketPrice;
    }
    
    public string GetLatestNewsDate()
    {
        string latestNewsTitle = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"SELECT newsdata FROM news
                WHERE newsdata = (SELECT MAX(newsdata) FROM news)limit 1;
                ";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        latestNewsTitle = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            latestNewsTitle = null;
        }
        return latestNewsTitle;
    }
    public string GetLatestNewsDescription()
    {
        string latestNewsTitle = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"SELECT newsshortdescription FROM news
                WHERE newsdata = (SELECT MAX(newsdata) FROM news)limit 1;
                ";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        latestNewsTitle = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            latestNewsTitle = null;
        }
        return latestNewsTitle;
    }
    public string GetLatestNewsTitle()
    {
        string latestNewsTitle = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"SELECT newstitle FROM news
                WHERE newsdata = (SELECT MAX(newsdata) FROM news)limit 1;
                ";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        latestNewsTitle = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            latestNewsTitle = null;
        }
        return latestNewsTitle;
    }
    
    public string GetAverageNewsTitle()
    {
        string latestNewsTitle = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"SELECT newstitle FROM news
                    WHERE newsdata = (
                        SELECT newsdata
                        FROM news
                        ORDER BY newsdata DESC
                        LIMIT 1 OFFSET 1
                    )LIMIT 1;
                ";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        latestNewsTitle = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            latestNewsTitle = null;
        }
        return latestNewsTitle;
    }
    public string GetAverageNewsDescription()
    {
        
        string latestNewsTitle = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"SELECT newsshortdescription FROM news
                    WHERE newsdata = (
                        SELECT newsdata
                        FROM news
                        ORDER BY newsdata DESC
                        LIMIT 1 OFFSET 1
                    )LIMIT 1;
                ";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        latestNewsTitle = result.ToString();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            latestNewsTitle = null;
            Console.WriteLine(ex);
        }
        return latestNewsTitle;
    }
    public string GetAverageNewsDate()
    {
        string latestNewsTitle = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"SELECT newsdata FROM news
                    WHERE newsdata = (
                        SELECT newsdata
                        FROM news
                        ORDER BY newsdata DESC
                        LIMIT 1 OFFSET 1
                    )LIMIT 1;
                ";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        latestNewsTitle = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            latestNewsTitle = null;
        }
        return latestNewsTitle;
    }
    
    
    
     public string GetNewNewsTitle()
    {
        string latestNewsTitle = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"
                    SELECT newstitle
                    FROM news
                    WHERE newsdata = (
                        SELECT newsdata
                        FROM news
                        ORDER BY newsdata DESC
                        LIMIT 1 OFFSET 2
                    )LIMIT 1;
                ";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        latestNewsTitle = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            latestNewsTitle = null;
        }
        return latestNewsTitle;
    }
    public string GetNewNewsDescription()
    {
        string latestNewsTitle = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"
                    SELECT newsshortdescription
                    FROM news
                    WHERE newsdata = (
                        SELECT newsdata
                        FROM news
                        ORDER BY newsdata DESC
                        LIMIT 1 OFFSET 2
                    )LIMIT 1;
                ";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        latestNewsTitle = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            latestNewsTitle = null;
        }
        return latestNewsTitle;
    }
    public string GetNewNewsDate()
    {
        string latestNewsTitle = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"SELECT newsdata
                    FROM news
                    WHERE newsdata = (
                        SELECT newsdata
                        FROM news
                        ORDER BY newsdata DESC
                        LIMIT 1 OFFSET 2
                    )LIMIT 1;
                ";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        latestNewsTitle = result.ToString();
                    }
                }
            }
        }
        catch (Exception)
        {
            latestNewsTitle = null;
        }
        return latestNewsTitle;
    }
}
