using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;

namespace LibraryManagementSystem.Services;

public class BookService
{
    private readonly IBookRepository _repo;
    public BookService()
    {
        _repo = new BookRepository();
    }
    public void AddBook()
    {
        Console.WriteLine("Title: ");
        var title = Console.ReadLine();
        Console.WriteLine("Author: ");
        var author = Console.ReadLine();
        Console.WriteLine("ISBN: ");
        var isbn = Console.ReadLine();
        Console.WriteLine("Available Copies: ");
        var copies = int.Parse(Console.ReadLine());


        var book = new Book
        {
            Title = title,
            Author = author,
            ISBN = isbn,
            AvailableCopies = copies
        };

        _repo.Add(book);
        Console.WriteLine("Book Added!");
    }
    public void ListBook()
    {
        var books = _repo.GetAll();
        if (books.Count > 0)
        {
            Console.WriteLine("\nBook List: ");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}: {book.Title} by {book.Author} - Copies: {book.AvailableCopies}");
            }
        }
        if (books.Count == 0)
            Console.WriteLine("Library is Empty!");
    }
}
