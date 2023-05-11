using AutoMapper;
using Entities;
using DTO;

namespace HMO_backend
{
    public class Mapper:Profile
    {
        public Mapper()
        {

            CreateMap<Member, MemberDTO>().ReverseMap();
            CreateMap<Vaccination, VaccinationDTO>().ReverseMap();

        }
    }
}
