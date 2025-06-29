using LibraryManagementSystem.Models;
using Microsoft.Identity.Client;

namespace LibraryManagementSystem.Repositories.Interfaces;

public interface IBookRepository
{
    void Add(Book book);
    void Update(Book book);
    void Delete(int id);
    Book GetbyId(int id);
    Book GetbyISBN(string isbn);

    List<Book> GetAll();
}
