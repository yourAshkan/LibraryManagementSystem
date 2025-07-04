using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repositories;

public class BorrowRepository : IBorrowRepository
{
    private readonly AppDBContext _context;
    public BorrowRepository()
    {
        _context = new AppDBContext();
    }
    public void BorrowBook(int bookid, int memberid, DateTime date)
    {
        var book = _context.books.Find(bookid);
        if (book == null || book.AvailableCopies <= 0)
            throw new Exception("Book Unavailable");

        var borrow = new Borrow()
        {
            BookId = bookid,
            MemberId = memberid,
            BorrowDate = Tools.PersianCalendar(date),
        };

        book.AvailableCopies--;
        _context.Borrows.Add(borrow);
        _context.SaveChanges();
    }
    public void ReturnBook(int id,DateTime date)
    {
        var borrow = _context.Borrows.Include(x=>x.Book).FirstOrDefault(x=>x.Id == id && x.ReturnDate == null);
        if (borrow != null)
        {
            borrow.ReturnDate = Tools.PersianCalendar(date);
            borrow.Book.AvailableCopies++;
            _context.SaveChanges();
        }

    }
    public List<Borrow> GetActiveBorrow() => _context.Borrows
        .Include(x=>x.Book)
        .Include(x=>x.Member)
        .Where(x=>x.ReturnDate == null)
        .ToList();

    public List<Borrow> GetAllBorrows() => _context.Borrows.Include(x => x.Book).Include(x=>x.Member).ToList();
}
