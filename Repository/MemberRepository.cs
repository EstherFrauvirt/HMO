using Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System;
using System.Linq;



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
       
        public async Task<int> peopleNotVaccinated()
        {
            var membersWithZeroVaccinationsCount = _hmoContext.Members.Count(m => !_hmoContext.Vaccinations.Any(v => v.MemberId == m.MemberId));
            return membersWithZeroVaccinationsCount;

        }
        public async Task<int> countSickPeoplePerDay(DateTime d)
        {
            DateTime fourteenDaysAgo = d.AddDays(-14);

            int totalMembers = _hmoContext.Members
                .Where(m => m.DiseaseDate >= fourteenDaysAgo)
                .Count();




            return totalMembers;

        }




    }
}