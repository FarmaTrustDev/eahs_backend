using EAHS.DTOS;
using EAHS.Interfaces;

namespace EAHS.Services
{
    public class CountryServices
    {
        private readonly ICountryRepository _repo;
        public CountryServices(ICountryRepository repo)
        {
            _repo = repo;
        }
        public CountryListingResponseDTO Get(FiltersRequestDTO request)
        {
            return _repo.Get(request);
        }
    }
}
