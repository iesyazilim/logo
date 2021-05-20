using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Auditing;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.DemandVouchers
{
    [Serializable]
    public class Transaction : ILogo
    {

        #region Implementation
      
        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        #endregion
    }
}
