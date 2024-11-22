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
    }
    public bool loginUser( string numberPhone, string email, string password)
    {
        var conn = GetSqlConnection();
        bool  flag = true;
        try
        {
            NpgsqlCommand command = new NpgsqlCommand(
                $"select * from users where '{numberPhone}' and '{email}' and '{password}' ", conn);
            command.ExecuteNonQuery();
           
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Login failed"); 
        }

        return flag;
    }
    public  void updateUser(string numberPhone, string email, string password)
    {
        var conn = GetSqlConnection();
        NpgsqlCommand command = new NpgsqlCommand(
            $"update users set password = '{password} 'where '{numberPhone}' and '{email}' ", conn);
        command.ExecuteNonQuery();
    }

    
}