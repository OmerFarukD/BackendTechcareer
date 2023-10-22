namespace Day_2_OOP;

public class KayıtOl
{
    private string username;
    private string password;
    private string city;
    private string state;

    public KayıtOl(string username, string password)
    {
        this.username = username;
        this.password = password;
    }

    public KayıtOl(string username, string password, string city, string state)
    {
        this.username = username;
        this.password = password;
        this.city = city;
        this.state = state;
    }

    public void Success()
    {
        Console.WriteLine($"Kişi başarılı bir şekilde kayıt oldu : {username}, {password}, {city}, {state}");
    }


}
