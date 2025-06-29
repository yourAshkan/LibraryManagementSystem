using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Repositories.Interfaces;

public interface IMemberRepository
{
    void Add(Member member);
    Member GetbyId(int id);
    Member GetbyNationalCode(int code);
    List<Member> GetAll();
}
