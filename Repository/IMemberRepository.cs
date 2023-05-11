using Entities;

namespace Repository
{
    public interface IMemberRepository
    {
        Task<Member> addMember(Member member);
        Task<IEnumerable<Member>> GetAllMembers();
        Task<int> peopleNotVaccinated();
    }
}