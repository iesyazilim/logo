using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.Core
{
    public class PagedQueryResponse<T>
    {
        public List<T> Rows { get; set; }
        public int TotalCount { get; set; }
    }
}
