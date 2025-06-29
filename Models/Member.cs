namespace LibraryManagementSystem.Models;

public class Member
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int NationalCode { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime JoinDate { get; set; }
    public string? EmailAddress { get; set; }
    public string Address { get; set; } = string.Empty;


    public List<Borrow> Borrows { get; set; }
}
