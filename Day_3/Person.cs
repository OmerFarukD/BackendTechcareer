
namespace Day_3;
public class Person
{
    private string password;

    public string Name {get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }

    // kullanıcı şifre girdiği zaman şifrenin sonuna 123abc. eklesin.
    // Salting 
    // deneme 
    public string Password
    {
        get => password;
        set => password =value+ "123abc.";
    }

    public override string ToString()
    {
        return $"İsim : {Name} , Soyisim : {Surname}, Email : {Email}, Parola : {Password}";
    }

}
