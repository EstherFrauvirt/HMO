using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VaccinationRepository : IVaccinationRepository
    {
        HmoContext _hmoContext;
        public VaccinationRepository(HmoContext hmoContext)
        {
            _hmoContext = hmoContext;

        }
        public async Task<IEnumerable<Vaccination>> getAllVaccinations()
        {
            IEnumerable<Vaccination> vaccinations= await _hmoContext.Vaccinations.ToListAsync();
            return vaccinations;
        }
        public async Task<IEnumerable<Vaccination>> getVaccinationsByMemberId(string id)
        {
            var member = _hmoContext.Members.Where(  m =>
              m.Id==id).FirstOrDefault();

            
            var query = _hmoContext.Vaccinations.Where(vaccin => vaccin.MemberId == member.MemberId);
            return query.ToList();

        }
        public async Task<Vaccination> addVaccination(Vaccination vaccination)
        {
            await _hmoContext.Vaccinations.AddAsync(vaccination);
            await _hmoContext.SaveChangesAsync();
            return vaccination;

        }
    }
}
