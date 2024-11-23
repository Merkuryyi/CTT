namespace CTT;
using  Npgsql;
public class Database
{
    
    public  NpgsqlConnection GetSqlConnection()
    {
        NpgsqlConnection conn =
        new NpgsqlConnection(@"Host=localhost;Username=postgres;Password=62389trewq%Y;Database=stt");
        conn.Open();
        return conn;
    }

    public void registrationUser(string name, string lname, string numberPhone, string email,  string password)
    {
        var conn = GetSqlConnection();
        NpgsqlCommand command = new NpgsqlCommand(
            $"insert into users(FName, LName, NumberPfone, Email,  Password) values('{name}','{lname}', '{numberPhone}','{email}','{password}' )", conn);
        command.ExecuteNonQuery();
        conn.Close();
    }
    public bool loginUser(string numberPhone, string email, string password)
    {
        var conn = GetSqlConnection();
        bool  flag = true;

        NpgsqlCommand command = new NpgsqlCommand(
            $"SELECT COUNT(*) FROM users WHERE NumberPfone = '{numberPhone}' and email = '{email}' and password = '{password}'", conn);
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
            $"update users set password = '{newPassword} 'where '{numberPhone}' and '{email}' ", conn);
        command.ExecuteNonQuery();
        conn.Close();
    }

    
}