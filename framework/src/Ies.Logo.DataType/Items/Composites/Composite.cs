﻿using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Items
{
    [Serializable]
    public class Composite : ILogo
    {
        public virtual string Code { get; set; }
        public virtual Nullable<decimal> Quantity { get; set; }
        public virtual Nullable<decimal> Price { get; set; }
        public virtual Nullable<decimal> SharePerc { get; set; }
        public virtual string VariantCode { get; set; }
    }
}
