namespace LibraryManagementSystem.Models;

public class Borrow
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }

    public int MemberId { get; set; }
    public Member Member { get; set; }

    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }
}
