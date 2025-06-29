using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;

namespace LibraryManagementSystem.Services;

public class MemberService
{
    private readonly IMemberRepository _repo;
    public MemberService()
    {
        _repo = new MemberRepository();
    }
    public void AddMember()
    {
        Console.WriteLine("FirstName: ");
        var firstname = Console.ReadLine();
        Console.WriteLine("LastName: ");
        var lastname = Console.ReadLine();
        Console.WriteLine("NationalCode: ");
        var nationalcode = int.Parse(Console.ReadLine());
        Console.WriteLine("PhoneNumber: ");
        var phonenumber = Console.ReadLine();
        Console.WriteLine("EmailAddress(Optioanl): ");
        var email = Console.ReadLine();
        Console.WriteLine("Address: ");
        var address = Console.ReadLine();

        var member = new Member
        {
            FirstName = firstname,
            LastName = lastname,
            NationalCode = nationalcode,
            PhoneNumber = phonenumber,
            EmailAddress = email,
            Address = address,
            JoinDate = DateTime.Now
        };
        _repo.Add(member);
        Console.WriteLine("New Member Registered!");
    }
    public void ListMember()
    {
        var Memeber = _repo.GetAll();
        Console.WriteLine("\nMembers List: ");
        foreach (var member in Memeber)
        {
            Console.WriteLine($"{member.Id}: {member.FirstName} {member.LastName} | {member.NationalCode}");
        }
    }
}
