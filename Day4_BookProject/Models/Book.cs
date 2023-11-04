namespace Day4_BookProject.Models;

public class Book :EntityBase<int>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public string CategoryId { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Başlık : {Title}, Açıklama : {Description}, Değeri :{Price}, Stok : {Stock} Category Id :{CategoryId}";
    }

}
