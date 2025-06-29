using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories.Interfaces;

namespace LibraryManagementSystem.Repositories;

public class MemberRepository : IMemberRepository
{
    private readonly AppDBContext _context;
    public MemberRepository()
    {
        _context = new AppDBContext();
    }
    public void Add(Member member)
    {
        _context.Members.Add(member);
        _context.SaveChanges();
    }
    public Member GetbyId(int id) => _context.Members.Find(id);
    public List<Member> GetAll() => _context.Members.ToList();
    public Member GetbyNationalCode(int code) => _context.Members.FirstOrDefault(x => x.NationalCode == code);
}
