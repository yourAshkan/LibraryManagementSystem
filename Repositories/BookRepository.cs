using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories.Interfaces;

namespace LibraryManagementSystem.Repositories;

public class BookRepository : IBookRepository
{
    private readonly AppDBContext _context;
    public BookRepository()
    {
        _context = new AppDBContext();
    }
    public void Add(Book book)
    {
        _context.Add(book);
        _context.SaveChanges();
    }
    public void Update(Book book)
    {
        _context.Update(book);
        _context.SaveChanges();
    }
    public void Delete(int id)
    {
        var book = _context.books.Find(id);
        if (book != null)
        {
            _context.books.Remove(book);
            _context.SaveChanges();
        }
    }
    public Book GetbyId(int id) => _context.books.Find(id);
    public Book GetbyISBN(string isbn) => _context.books.FirstOrDefault(x=>x.ISBN == isbn);
    public List<Book> GetAll() => _context.books.ToList();
}
