﻿using System;
using Allegory.Standart.Filter.Concrete;

namespace Ies.LogoApp.Entities
{
    [Serializable]
    public class ListRequestDto : IListRequestDto
    {
        public string OrderBy { get; set; }

        public Condition Conditions { get; set; }
    }
}
