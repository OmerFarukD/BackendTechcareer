
using Day4_BookProject.Models;

namespace Day4_BookProject.Data;

public interface IBookRepository
{
    void Add(Book book);
    void Delete(int id);

    List<Book> GetAllBooks();

    Book? GetById(int id);
}
