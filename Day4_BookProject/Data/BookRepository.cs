using Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Data;

public class BookRepository :IBookRepository
{
    private readonly List<Book> _bookData;

    public BookRepository()
    {

        // Seed Data
        _bookData = new List<Book>()
        {
              new Book{Id=1,Description="Güzel bir kitap",Price=250,Stock=2500,Title="Sherlock Holmes"},
              new Book{Id=2,Description="Güzel bir kitap",Price=120,Stock=500,Title="Arsen Lüpen"},
              new Book{Id=3,Description="Çok değerli bir kitap",Price=300, Stock=5000, Title="Nutuk"}
        };
    }

    public void Add(Book book)
    {
        _bookData.Add(book);
    }

    public void Delete(int id)
    {
        foreach (Book book in _bookData) 
        {
            if (book.Id == id)
            {
                _bookData.Remove(book);
            }
        }
    }

    public List<Book> GetAllBooks()
    {
        return _bookData;
    }

    public Book? GetById(int id)
    {
        Book? book = _bookData.SingleOrDefault(x=>x.Id==id);

        if(book == null)
        {
            // Exception Fırlat
        }

        else
        {
            return book;
        }

    }
}
