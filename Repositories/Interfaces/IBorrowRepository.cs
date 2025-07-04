using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Repositories.Interfaces;

public interface IBorrowRepository
{
    void BorrowBook(int bookid, int memberid,DateTime date);
    void ReturnBook(int id,DateTime date);
    List<Borrow> GetAllBorrows();
    List<Borrow> GetActiveBorrow();
}
