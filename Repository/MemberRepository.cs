using Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Repository
{
    public class MemberRepository : IMemberRepository
    {
        private HmoContext _hmoContext;
        public MemberRepository(HmoContext hmoContext)
        {
            _hmoContext = hmoContext;
        }

        public async Task<IEnumerable<Member>> GetAllMembers()
        {
            IEnumerable<Member> members = await _hmoContext.Members.ToListAsync();
            return members;
        }

        public async Task<Member> addMember(Member member)
        {
            await _hmoContext.Members.AddAsync(member);
            await _hmoContext.SaveChangesAsync();
            return member;
        }
        //public async Task<int> countPatientsInMonth(DateTime d)
        //{
        //    var result = _hmoContext.Members.Where(d => DbFunctions.DiffMonths(new DateTime(2023, 5, 9), d.start_date) == 0 || DbFunctions.DiffMonths(new DateTime(2023, 5, 9), d.end_date) == 0).Count();

        //    var result = _hmoContext.Members.Count(m => m.DiseaseDate.Month == new DateTime(2023, 5, 9).Month || d.end_date.Month == new DateTime(2023, 5, 9).Month);

        //}
        public async Task<int> peopleNotVaccinated()
        {
            var membersWithZeroVaccinationsCount = _hmoContext.Members.Count(m => !_hmoContext.Vaccinations.Any(v => v.MemberId == m.MemberId));
            return membersWithZeroVaccinationsCount;

        }

       
    }
}