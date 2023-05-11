using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class VaccinationService : IVaccinationService
    {
        private IVaccinationRepository _vacccinationRepository;
        public VaccinationService(IVaccinationRepository vacccinationRepository)
        {
            _vacccinationRepository = vacccinationRepository;
        }
        public async Task<IEnumerable<Vaccination>> getAllVaccinations()
        {
            IEnumerable<Vaccination> vaccinations = await _vacccinationRepository.getAllVaccinations();
            return vaccinations;
        }
        public async Task<IEnumerable<Vaccination>> getVaccinationsByMemberId(string id)
        {
            IEnumerable<Vaccination> vaccinations = await _vacccinationRepository.getVaccinationsByMemberId(id);
            if (vaccinations != null)
                return vaccinations;
            else return null;
        }
        public async Task<Vaccination> addVaccination(Vaccination vaccin)
        {
            Vaccination vaccination= await _vacccinationRepository.addVaccination(vaccin);
            if (vaccination != null)
                return vaccination;
            else return null;

        }
    }
}