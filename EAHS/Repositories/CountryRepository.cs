using EAHS.Interfaces;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System;
using EAHS.Models;
using EAHS.DTOS;
using EAHS.Core;
using EAHS.Mappers;
using LinqKit;

namespace EAHS.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        private readonly EAHSDbContext _cGTContext;
        public CountryRepository(EAHSDbContext cGTContext) : base(cGTContext)
        {
            _cGTContext = cGTContext;
        }
        public CountryListingResponseDTO Get(FiltersRequestDTO filterRequest)
        {
            try
            {
                //return _cGTContext.Set<TEntity>().Where(x => true).ToList();

                ExpressionStarter<Country> searchQuery = AppliesQueryParams(filterRequest);

                IQueryable<CountryPaginatedResponseDTO> builder = _cGTContext.Country.Where(searchQuery)
                    .Select(country =>
                    new CountryPaginatedResponseDTO()
                    {
                        Id = country.Id,
                        Name = country.Name,
                        ISO = country.ISO,
                        CountryCode = country.CountryCode
                    });

                Paginate paginate = new Paginate(builder, filterRequest);
                paginate.Get();


                List<dynamic> paginatedData = paginate.Data;

                List<CountryPaginatedResponseDTO> result = paginatedData.Select(country =>
                    new CountryPaginatedResponseDTO()
                    {
                        Id = country.Id,
                        Name = country.Name,
                        ISO = country.ISO,
                        CountryCode = country.CountryCode

                    }).ToList();

                // stupid work
                CountryListingResponseDTO request = new CountryListingResponseDTO();
                PaginationMappers.GetDefaultValue(paginate, request);
                request.Data = result;
                return request;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ExpressionStarter<Country> AppliesQueryParams(FiltersRequestDTO filters)
        {
            Expression<Func<Country, bool>> expersion = e => true;

            var predicate = PredicateBuilder.New<Country>(true);

            if (filters.Name != null && (filters.Name != ""))
            {
                var prefix = expersion.Compile();

                expersion = country => country.Name.Contains(filters.Name);
                predicate.And(expersion);
            }
            if (filters.Ids != null)
            {
                var prefix = expersion.Compile();

                expersion = country => filters.Ids.Contains(country.Id);
                predicate.Or(expersion);
            }
            if (filters.CountryCode != null)
            {
                var prefix = expersion.Compile();
                expersion = country => country.CountryCode.Contains(filters.CountryCode);
                predicate.Or(expersion);
            }
            if (filters.Iso != null)
            {
                var prefix = expersion.Compile();
                expersion = country => country.ISO.Contains(filters.Iso);
                predicate.Or(expersion);
            }
            return predicate;
        }
    }
}
