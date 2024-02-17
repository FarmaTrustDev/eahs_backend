using EAHS.DTOS;
using EAHS.Models;

namespace EAHS.Interfaces
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        public CountryListingResponseDTO Get(FiltersRequestDTO filterRequest);
    }
}
