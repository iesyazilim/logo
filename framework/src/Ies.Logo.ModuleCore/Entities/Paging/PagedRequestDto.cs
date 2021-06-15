using System;
using System.ComponentModel.DataAnnotations;

namespace Ies.Logo.ModuleCore.Entities
{
    [Serializable]
    public class PagedRequestDto : IDto
    {
        public static int DefaultPageSize { get; set; } = 10;

        public static int MaxPageSize { get; set; } = 1000;

        [Range(1, int.MaxValue)]
        public int Page { get; set; } = 1;

        private int pageSize;
        public int PageSize
        {
            get => pageSize == 0 ? DefaultPageSize : pageSize;
            set
            {
                if (value > MaxPageSize)
                    throw new BusinessException($"Pagesize must less than or equals to {MaxPageSize}");

                pageSize = value;
            }
        }
    }
}
