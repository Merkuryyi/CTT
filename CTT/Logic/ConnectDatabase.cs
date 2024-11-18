namespace CTT;
using  Npgsql;
public class Database
{
    public class connectionString
    {
        public static NpgsqlConnection GetSqlConnection()
        {
            NpgsqlConnection conn =
                new NpgsqlConnection(@"Host=localhost;Username=postgres;Password=qwerty;Database=postgrs");
            conn.Open();
            return conn;
        }

        public static void registrationUser(string name, string lname, string numberPhone, string email,  string password)
        {
            var conn = GetSqlConnection();
            NpgsqlCommand command = new NpgsqlCommand(
                $"insert into users(name, lname, numberPhone, email,  password) values('{name}','{lname}', '{numberPhone}','{email}','{password}' )", conn);
            command.ExecuteNonQuery();
        }
        public static void loginUser( string numberPhone, string email, string password)
        {
            var conn = GetSqlConnection();
            NpgsqlCommand command = new NpgsqlCommand(
                $"select * from users where '{numberPhone}' and '{email}' and '{password}' ", conn);
            command.ExecuteNonQuery();
        }
        public static void updateUser(string numberPhone, string email, string password)
        {
            var conn = GetSqlConnection();
            NpgsqlCommand command = new NpgsqlCommand(
                $"update users set password = '{password} 'where '{numberPhone}' and '{email}' ", conn);
            command.ExecuteNonQuery();
        }

    }
}