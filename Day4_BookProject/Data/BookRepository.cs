using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;
namespace Day4_BookProject.Data;

public class BookRepository :IBookRepository
{
    private readonly List<Book> _bookData;

    public BookRepository()
    {
        // Seed Data
        _bookData = new List<Book>()
        {
              new Book{Id=1,CategoryId="A", Description="Güzel bir kitap",Price=250,Stock=2500,Title="Sherlock Holmes"},
              new Book{Id=2,CategoryId="A", Description="Güzel bir kitap",Price=120,Stock=500,Title="Arsen Lüpen"},
              new Book{Id=3,CategoryId="B", Description="Çok değerli bir kitap",Price=300, Stock=5000, Title="Nutuk"},
              new Book{Id=4,CategoryId="B", Description="Güzel bir kitap",Price=125,Stock=1000,Title="Cengiz Han ın Hayatı"},
              new Book{Id=5,CategoryId="B", Description="Güzel bir kitap",Price=1020,Stock=5000,Title="Atilla"},
              new Book{Id=6,CategoryId="B", Description="Çok değerli bir kitap",Price=3000, Stock=5000, Title="Sümerin Göksel Ataları"},
              new Book{Id=7,CategoryId="C", Description="Güzel bir kitap",Price=25,Stock=140,Title="İyi Hissetmek"},
              new Book{Id=8,CategoryId="C", Description="Güzel bir kitap",Price=300,Stock=50,Title="Psikoloji"},
              new Book{Id=9,CategoryId="C", Description="Çok değerli bir kitap",Price=145, Stock=100, Title="Psikoloji1"},
        };
    }


    public void Add(Book book)
    {
        _bookData.Add(book);
    }

    public void Delete(int id)
    {
        Book? book = _bookData.Where(x=>x.Id==id).SingleOrDefault();
        if (book is null ) 
        {
            throw new BookNotFoundException(id);
        }
        _bookData.Remove(book);
    }

    public List<Book> GetAll()
    {
        return _bookData;
    }

    public Book? GetById(int id)
    {
        Book? book = _bookData.SingleOrDefault(x=>x.Id==id);

        if(book == null)
        {
            throw new BookNotFoundException(id);
        } 
        return book;
    }
}
