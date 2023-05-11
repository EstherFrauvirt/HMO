using Entities;

namespace Services
{
    public interface IVaccinationService
    {
        Task<IEnumerable<Vaccination>> getAllVaccinations();

        Task<Vaccination> addVaccination(Vaccination vaccin);
        Task<IEnumerable<Vaccination>> getVaccinationsByMemberId(string id);
    }
}