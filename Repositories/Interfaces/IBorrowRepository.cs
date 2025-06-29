using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Repositories.Interfaces;

public interface IBorrowRepository
{
    void BorrowBook(int bookid, int memberid);
    void ReturnBook(int id);
    List<Borrow> GetAllBorrows();
    List<Borrow> GetActiveBorrow();
}
