using Entities;

namespace Repository
{
    public interface IVaccinationRepository
    {
        Task<IEnumerable<Vaccination>> getAllVaccinations();
        Task<Vaccination> addVaccination(Vaccination vaccination);
        Task<IEnumerable<Vaccination>> getVaccinationsByMemberId(string id);
    }
}