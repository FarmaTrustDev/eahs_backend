using EAHS.DTOS;
using System.Linq;
using System;

namespace EAHS.Core
{
    public class Paginate
    {
        public int From { get; set; } // which index of the list started       
        public int PageSize { get; set; }
        public int Total { get; set; }
        public int To { get; set; }
        public int Current { get; set; }
        public Uri FirstPageURL { get; set; }
        public int LastPage { get; set; }
        public Uri NextPageURL { get; set; }
        public Uri PreviousPage { get; set; }

        private IQueryable<dynamic> Query { get; set; }
        public dynamic Data { get; set; }

        public Paginate(IQueryable<dynamic> query, PaginateDTO paginate)
        {
            SetTotal(query);
            SetPerPage(paginate);
            SetAttributes(paginate);
            SetLastPage();
            Query = query;
        }

        /// <summary>
        /// Making query exensive method do not use multiple times
        /// </summary>
        /// <param name="query"></param>
        private void SetTotal(IQueryable<dynamic> query)
        {
            Total = query.Count();
        }

        private void SetPerPage(PaginateDTO paginate)
        {
            PageSize = (int)(paginate.PageSize != null ? paginate.PageSize : 25);
        }

        private void SetCurrentPage(PaginateDTO paginate)
        {
            Current = (int)(paginate.Current != null ? paginate.Current : 1);
        }

        private void SetFrom(PaginateDTO paginate)
        {
            From = (Current - 1) * PageSize;
        }

        private void SetLastPage()
        {
            decimal lastPage = Total / PageSize;
            if (lastPage > 0)
            {
                LastPage = (int)Math.Round(lastPage);
            }
            else
            {
                LastPage = 0;
            }

        }
        private void SetTo(PaginateDTO paginate)
        {
            To = From + PageSize;
        }

        public Paginate Get()
        {
            ComputeQuery().PaginatedData();
            return this;
        }

        public Paginate ComputeQuery()
        {
            int take = PageSize;
            Data = Query.Skip(From).Take(take).ToList();
            return this;
        }

        public PaginateDTO Paginated()
        {
            Get();
            return PaginatedData();
        }


        public PaginateDTO PaginatedData()
        {
            return new PaginateDTO()
            {
                Current = Current,
                PageSize = PageSize,
                From = From,
                To = To,
                Total = Total,
                Last_Page = LastPage,
                Data = Data,
            };
        }

        private void SetAttributes(PaginateDTO paginate)
        {
            SetCurrentPage(paginate);
            SetFrom(paginate);
            SetTo(paginate);
        }

        public Paginate SetData(dynamic data)
        {
            Data = data;
            return this;
        }
    }

    public class TotalCounter
    {
        public dynamic Id;
    }
}
