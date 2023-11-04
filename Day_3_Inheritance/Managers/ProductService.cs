namespace Day_3_Inheritance.Managers;

public class ProductService : ICrudService
{
    public void Add()
    {
        Console.WriteLine("Ürün eklendi.");
    }

    public void Delete()
    {
        Console.WriteLine("Ürün silindi.");
    }

    public void GetAll()
    {
        Console.WriteLine("Ürün listelendi.");
    }

    public void Update()
    {
        Console.WriteLine("Ürün güncellendi.");
    }
}
