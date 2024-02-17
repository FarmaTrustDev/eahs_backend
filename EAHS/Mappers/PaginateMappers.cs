using EAHS.Core;
using EAHS.DTOS;

namespace EAHS.Mappers
{
    public class PaginationMappers : BaseMappers
    {

        public static Paginate GetDefaultValue(Paginate paginate, PaginateDTO request)
        {
            request.Current = paginate.Current;
            request.PageSize = paginate.PageSize;
            request.Total = paginate.Total;
            request.From = paginate.From;

            request.Current = paginate.Current;
            return paginate;
        }
    }
}
