using System.Collections.Generic;

namespace EAHS.DTOS
{
    public class CountryResponseDTO
    {
    }

    public class CountryPaginatedResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string ISO { get; set; }
        public string FlagPath { get; set; }
    }

    public class CountryListingResponseDTO : PaginateDTO
    {
        List<CountryPaginatedResponseDTO> data { get; set; }

    }
    public class PaginateDTO
    {
        public int? From { get; set; }
        public int? Last_Page { get; set; }
        public int? PageSize { get; set; }
        public int? Total { get; set; }
        public int? To { get; set; }
        public int? Current { get; set; }
        public dynamic Data { get; set; }
    }
}
