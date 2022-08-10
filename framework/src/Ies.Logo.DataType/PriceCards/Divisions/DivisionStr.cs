using Ies.Logo.DataType.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.PriceCards.Divisions
{
    [Serializable]
    public class DivisionStr : ILogo, IInternalReference
    {
        public Nullable<int> InternalReference { get; set; }
        public Nullable<short> DivisionCodes { get; set; }
    }
}
