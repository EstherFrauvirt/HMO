using Entities;

namespace Services
{
    public interface IMemberService
    {
        Task<Member> addMember(Member member);
        Task<IEnumerable<Member>> GetAllMembers();
        Task<int> peopleNotVaccinated();
    }
}