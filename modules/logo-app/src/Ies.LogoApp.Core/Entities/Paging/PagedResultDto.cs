using System;
using System.Collections.Generic;

namespace Ies.LogoApp.Core.Entities
{
    [Serializable]
    public class PagedResultDto<T> : IDto
    {
        public int CurrentPage { get; set; }

        public int PageCount { get; set; }

        public int PageSize { get; set; }

        public long TotalCount { get; set; }

        public long FirstRowOnPage => (CurrentPage - 1) * PageSize + 1;

        public long LastRowOnPage => Math.Min(CurrentPage * PageSize, TotalCount);

        public IList<T> Items { get; set; }

        public PagedResultDto()
        {

        }

        public PagedResultDto(int currentPage, int pageCount, int pageSize, long totalCount, IList<T> items)
        {
            CurrentPage = currentPage;
            PageCount = pageCount;
            PageSize = pageSize;
            TotalCount = totalCount;
            Items = items;
        }
    }
}
