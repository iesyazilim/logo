using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Orders
{
    [Serializable]
    public class Transaction : ILogo
    {
     

        #region Implementation
        
        #endregion

        #region SubClasses
        public virtual List<Detail> Details { get; set; }
        #endregion
    }
}
