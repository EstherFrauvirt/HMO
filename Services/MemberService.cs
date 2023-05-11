using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MemberService : IMemberService
    {
        private IMemberRepository _memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<IEnumerable<Member>> GetAllMembers()
        {
            IEnumerable<Member> members = await _memberRepository.GetAllMembers();
            if (members != null)
                return members;
            else
                return null;
        }

        public async Task<Member> addMember(Member member)
        {
            await _memberRepository.addMember(member);
            return member;
        }
        public async Task<int> peopleNotVaccinated()
        {
            int count = await _memberRepository.peopleNotVaccinated();
            return count;
        }

    }
}
