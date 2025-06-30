using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;

namespace LibraryManagementSystem.Services;

public class BorrowService
{
    private readonly IBorrowRepository _repo;
    private readonly IBookRepository _bookRepo;
    public BorrowService()
    {
        _repo = new BorrowRepository();
        _bookRepo = new BookRepository();
    }
    public void BorrowBook()
    {
        var availablebook = _bookRepo.GetAll();
        if (availablebook.Count != 0)
        {
            Console.WriteLine("Book ID: ");
            int bookId = int.Parse(Console.ReadLine());
            Console.WriteLine("Member ID: ");
            int memeberId = int.Parse(Console.ReadLine());

            try
            {
                _repo.BorrowBook(bookId, memeberId);
                Console.WriteLine("Book Borrowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        else
            Console.WriteLine("There is no Book for Borrow!");
    }
    public void ReturnBook()
    {
        Console.WriteLine("Borrow ID: ");
        int borrowId = int.Parse(Console.ReadLine());
        _repo.ReturnBook(borrowId);
        Console.WriteLine("Book Returned!");
    }
    public void ListAllBorrows()
    {
        var borrows = _repo.GetAllBorrows();
        Console.WriteLine("\nBorrowed Book: ");
        foreach (var borrow in borrows)
        {
            var status = borrow.ReturnDate == null ? "Not Returned!" : $"Returned on {borrow.ReturnDate.Value.ToShortDateString()}";
            Console.WriteLine($"{borrow.Id}: {borrow.Book.Title}Borrowed to {borrow.Member.FirstName + " " + borrow.Member.LastName} | {borrow.BorrowDate.ToShortDateString()} | {status}");
        }
    }
}
