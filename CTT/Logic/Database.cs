namespace CTT;
using Npgsql;
using System;

public class Database
{
    public NpgsqlConnection GetSqlConnection()
    {
        NpgsqlConnection conn =
            new NpgsqlConnection("Host=localhost;Username=postgres;Password=62389trewq%Y;Database=stt");
        conn.Open();
        return conn;
    }
    public void RegistrationUser(string name, string lname, string numberPhone, string email, string password)
    {
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"INSERT INTO users (Login, username, NumberPhone, Email, Password)
                    VALUES (@name, @lname, @numberPhone, @email, @password)";
                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("lname", lname);
                    command.Parameters.AddWithValue("numberPhone", numberPhone);
                    command.Parameters.AddWithValue("email", email);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        { Console.WriteLine($"Ошибка при регистрации пользователя: {ex.Message}"); }
    }
    public bool LoginUser(string numberPhone, string email, string password)
    {
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"SELECT COUNT(*) FROM users 
                WHERE NumberPhone = @numberPhone AND Email = @email AND Password = @password";
                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("numberPhone", numberPhone);
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 1)
                    {
                        Console.WriteLine("Пользователь успешно авторизован.");
                        return true;
                    }
                    return false;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при авторизации пользователя: {ex.Message}");
            return false;
        }
    }
    public bool UniqueNumberPhone(string numberPhone)
    {
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"
                SELECT COUNT(*) 
                FROM users 
                WHERE NumberPhone = @numberPhone";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("numberPhone", numberPhone);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        Console.WriteLine("Номер телефона уже существует.");
                        return true;
                    }
                    return false;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при проверке уникальности номера телефона: {ex.Message}");
            return false;
        }
    }

    public void UpdateUser(string numberPhone, string email, string newPassword)
    {
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"UPDATE users SET password = @newPassword 
                                WHERE NumberPhone = @numberPhone AND Email = @email";
                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("newPassword", newPassword);
                    command.Parameters.AddWithValue("numberPhone", numberPhone);
                    command.Parameters.AddWithValue("email", email);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        { Console.WriteLine($"Ошибка при обновлении пароля: {ex.Message}"); }
    }
    public void UpdateNameUser(string numberPhone, string email, string newLogin, string newUserName)
    {
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"
                    UPDATE users 
                    SET login = @newLogin, username = @newUserName 
                    WHERE NumberPhone = @numberPhone 
                      AND Email = @email";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("newLogin", newLogin);
                    command.Parameters.AddWithValue("newUserName", newUserName);
                    command.Parameters.AddWithValue("numberPhone", numberPhone);
                    command.Parameters.AddWithValue("email", email);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        { Console.WriteLine($"Ошибка при обновлении логина и имени пользователя: {ex.Message}"); }
    }
    public void NotificationsAdd(int id, string action, float actionMoney)
    {
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"INSERT INTO Notifications (IdUsers, status, action, actionMoney, date)
                    VALUES (@IdUsers, 'unread', @action, @actionMoney, now())";
                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("IdUsers", id);
                    command.Parameters.AddWithValue("action", action);
                    command.Parameters.AddWithValue("actionMoney", actionMoney);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        { Console.WriteLine($"Ошибка при добавлении уведомления: {ex.Message}"); }
    }

    public void NotificationsUpdate(string id)
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
                    WHERE idusers = @idusers AND Status = 'unread'
                    ORDER BY Date ASC
                    LIMIT 1);	";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("login", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        { result = reader.GetString(0); }
                    }
                }
            }
        }
        catch (Exception e)
        { Console.WriteLine(e); }
    }
    public DateTime? NotificationDateGetRead()
    {
        DateTime? latestDate = null;
        try
        {
            latestDate = null;
            var conn = GetSqlConnection();
            using (conn)
            {
                string query = @"SELECT MAX(Date) FROM Notifications where status = 'read'";
                using (var command = new NpgsqlCommand(query, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            { latestDate = reader.GetDateTime(0); }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка {ex.Message}");
            latestDate = null;
        }
        return latestDate;
    }
    public DateTime? NotificationDateGetUnread()
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
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка {ex.Message}");
            return null;
        }

        return latestDate;
    }
    public string NotificationGet(int userId)
    {
        string result = null;
        try
        {
            var conn = GetSqlConnection();
            using (conn)
            {
                string queryUnread = @"SELECT CONCAT(Action, CASE 
                                WHEN Action IN ('Списание', 'Пополнение') THEN ': ' || COALESCE(ActionMoney::TEXT, '')
                                ELSE '' END) AS ActionWithMoney
                    FROM Notifications WHERE IdUsers = @IdUsers AND Status = 'unread' ORDER BY Date ASC LIMIT 1";
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
                                    WHEN Action IN ('Списание', 'Пополнение') THEN ': ' || COALESCE(ActionMoney::TEXT, '')
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
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка {ex.Message}");
            return null;
        }

        return result;
    }
    public int GetUserId(string numberPhone, string email)
    {
        try
        {
            using (var conn = GetSqlConnection())
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
                        { return reader.GetInt32(0); }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка {ex.Message}");
            return 0;
        }
        return 0;
    }
    public int NotificationsCount(int id)
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
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при добавлении уведомления: {ex.Message}");
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
                    return (firstName, lastName);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
            return (null, null);
        }
        return (null, null);
    }
    public string TicketPriceGet(string ticketName)
    {
        string ticketPrice = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = "SELECT ticketPrice FROM tickets WHERE ticketName = @ticketName";
                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("ticketName", ticketName);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    { ticketPrice = result.ToString(); }
                }
            }
        }
        catch (Exception ex)
        {
            ticketPrice = null;
            Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
        }

        return ticketPrice;
    }
    public string TicketDecriptionGet(string ticketName)
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
                    { ticketDecription = result.ToString(); }
                }
            }
        }
        catch (Exception ex)
        {
            ticketDecription = null;
            Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
        }
        return ticketDecription;
    }
    public string TicketCardPriceGet(string ticketName)
    {
        string ticketPrice = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = $"SELECT travelticketsprice FROM tickettravel WHERE travelticketName = '{ticketName}'";
                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                { ticketPrice = command.ExecuteScalar().ToString(); }
            }
        }
        catch (Exception ex)
        {
            ticketPrice = null;
            Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
        }
        return ticketPrice;
    }
    public string TravelTicketTitleGet(int id)
    {
        string ticketTitle = null;
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"
                SELECT travelticketname 
                FROM tickettravel
                JOIN historytravelticket 
                ON tickettravel.idtravelticket = historytravelticket.idtravelticket
                WHERE historytravelticket.id_users = @id
                ORDER BY historytravelticket.date DESC LIMIT 1;";
                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("id", id);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    { ticketTitle = result.ToString(); }
                }
            }
        }
        catch (Exception ex)
        {
            ticketTitle = null;
            Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
        }
        return ticketTitle;
    }
    public string GetNewsTitle(string time)
    {
        string latestNewsTitle = null;
        string query = "";
        try
        {
            using (var conn = GetSqlConnection())
            {
                if (time == "new")
                { query = "SELECT newstitle FROM news WHERE newsdata = (SELECT MAX(newsdata) FROM news)limit 1;"; }
                else if (time == "avarage")
                {
                    query = @"SELECT newstitle FROM news
                    WHERE newsdata = (SELECT newsdata FROM news
                        ORDER BY newsdata DESC
                        LIMIT 1 OFFSET 1 )LIMIT 1;";
                }
                else if (time == "latest")
                {
                    query = @"
                    SELECT newstitle
                    FROM news
                    WHERE newsdata = (
                        SELECT newsdata
                        FROM news
                        ORDER BY newsdata DESC
                        LIMIT 1 OFFSET 2)LIMIT 1;";
                }
                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    { latestNewsTitle = result.ToString(); }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении названия: {ex.Message}");
            latestNewsTitle = null;
        }
        return latestNewsTitle;
    }
    public string GetNewsDescription(string date)
    {
        string latestNewsTitle = null;
        string query = "";
        try
        {
            using (var conn = GetSqlConnection())
            {
               
                if (date == "latest")
                {
                    query = @"SELECT newsshortdescription
                    FROM news
                    WHERE newsdata = (
                        SELECT newsdata
                        FROM news
                        ORDER BY newsdata DESC
                        LIMIT 1 OFFSET 2
                        )LIMIT 1;";
                }
                else if (date == "average")
                {
                    query = @"SELECT newsshortdescription FROM news WHERE newsdata = (
                        SELECT newsdata FROM news
                        ORDER BY newsdata DESC
                        LIMIT 1 OFFSET 1
                    )LIMIT 1;
                ";
                }
                else if (date == "new")
                {
                    query = @"SELECT newsshortdescription FROM news
                WHERE newsdata = (SELECT MAX(newsdata) FROM news) limit 1;
                ";
                }
                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    { latestNewsTitle = result.ToString(); }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении описания: {ex.Message}");
            latestNewsTitle = null;
        }
        return latestNewsTitle;
    }
    public string GetNewsDate(string date)
    {
        string latestNewsTitle = null;
        string query = "";
        try
        {
            using (var conn = GetSqlConnection())
            {
                if (date == "latest")
                {
                    query = @"SELECT newsdata FROM news
                    WHERE newsdata = (SELECT newsdata FROM news
                        ORDER BY newsdata DESC LIMIT 1 OFFSET 2
                    )LIMIT 1;
                ";
                }
                else if (date == "average")
                {
                    query = @"SELECT newsdata FROM news
                    WHERE newsdata = (SELECT newsdata FROM news
                        ORDER BY newsdata DESC LIMIT 1 OFFSET 1
                    )LIMIT 1;
                ";
                }
                else if (date == "new")
                {
                    query = "SELECT newsdata FROM news WHERE newsdata = (SELECT MAX(newsdata) FROM news)limit 1;";
                }
                using (var command = new NpgsqlCommand(query, conn))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    { latestNewsTitle = result.ToString(); }
                }
            }
        }
        catch (Exception ex)
        {
            latestNewsTitle = null;
            Console.WriteLine($"Ошибка : {ex.Message}");
        }
        return latestNewsTitle;
    }
    public string GetTicketName(int userId, string period)
    {
        using (var conn = GetSqlConnection())
        {
            string query = "";
            try
            {
                if (period == "upper")
                {
                    query = @"SELECT ticketname FROM tickets
                    JOIN historytickets ON tickets.idticket = historytickets.idticket
                    WHERE historyTickets.id_users = @userId
                    ORDER BY historytickets.date DESC
                    LIMIT 1;
                    ";
                }
                if (period == "middle")
                {
                    query = @"SELECT ticketname FROM tickets
                    JOIN historytickets ON tickets.idticket = historytickets.idticket
                    WHERE historyTickets.id_users = @userId
                    ORDER BY historytickets.date DESC
                    OFFSET 1 LIMIT 1;
                    ";
                }
                if (period == "lower")
                {
                    query = @"SELECT ticketname FROM tickets
                    JOIN historytickets ON tickets.idticket = historytickets.idticket
                    WHERE historyTickets.id_users = @userId
                    ORDER BY historytickets.date DESC
                    OFFSET 2 LIMIT 1;
                    ";
                }
                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("userId", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        { return reader["ticketname"].ToString(); }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при получении данных: " + ex.Message);
            }
        }
        return null;
    }
    public string GetDateTicket(int userId, string format, string period)
    {
        using (var conn = GetSqlConnection())
        {
            string query = "";
            try
            {
                if (period == "upper")
                {
                    query = @"
                    SELECT ticketname, ticketdescription, date
                    FROM tickets
                    JOIN historytickets ON tickets.idticket = historytickets.idticket
                    WHERE historytickets.id_users = @userId
                    ORDER BY historytickets.date DESC
                    LIMIT 1;
                ";
                }
                if (period == "middle")
                {
                    query = @"
                    SELECT ticketname, ticketdescription, date
                    FROM tickets
                    JOIN historytickets ON tickets.idticket = historytickets.idticket
                    WHERE historytickets.id_users = @userId
                    ORDER BY historytickets.date DESC
                    OFFSET 1 LIMIT 1;";
                }
                if (period == "lower")
                {
                    query = @"
                    SELECT ticketname, ticketdescription, date
                    FROM tickets
                    JOIN historytickets ON tickets.idticket = historytickets.idticket
                    WHERE historytickets.id_users = @userId
                    ORDER BY historytickets.date DESC
                    OFFSET 2 LIMIT 1;";
                }
                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("userId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (format == "time")
                            {
                                DateTime date = Convert.ToDateTime(reader["date"]);
                                return date.ToString("HH:mm");
                            }
                            if (format == "date")
                            {
                                DateTime date = Convert.ToDateTime(reader["date"]);
                                return date.ToString("dd.MM");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { Console.WriteLine("Ошибка при получении данных: " + ex.Message); }
        }
        return null;
    }
    public string GetDateTravelTicket(int userId)
    {
        using (var conn = GetSqlConnection())
        {
            string query = "";
            try
            {
                query = @"
                    SELECT date
                    FROM tickettravel
                    JOIN historytravelticket ON tickettravel.idtravelticket = historytravelticket.idtravelticket
                    WHERE historytravelticket.id_users = '1'
                    ORDER BY historytravelticket.date DESC
                    LIMIT 1;";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("userId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime date = Convert.ToDateTime(reader["date"]);
                            string month = date.ToString("MMMM");
                            return char.ToUpper(month[0]) + month.Substring(1).ToLower();
                        }
                    }
                }
            }
            catch (Exception ex)
            { Console.WriteLine("Ошибка при получении данных: " + ex.Message); }
        }
        return null;
    }
    public void InsertHistoryTravelTicket(int idUsers, int idTravelTicket)
    {
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"
                INSERT INTO historytravelticket (id_users, idtravelticket, date)
                VALUES (@idUsers, @idTravelTicket, now())";

                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("idUsers", idUsers);
                    command.Parameters.AddWithValue("idTravelTicket", idTravelTicket);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        { Console.WriteLine($"Ошибка при добавлении записи в историю: {ex.Message}"); }
    }
    public void InsertHistoryTickets(int idUsers, int idTicket)
    {
        try
        {
            using (var conn = GetSqlConnection())
            {
                string query = @"
                    INSERT INTO historytickets (id_users, idticket, date)
                    VALUES (@idUsers, @idTicket, now())";
                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("idUsers", idUsers);
                    command.Parameters.AddWithValue("idTicket", idTicket);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        { Console.WriteLine($"Ошибка при добавлении записи в историю: {ex.Message}"); }
    }
}