using System;
using System.Collections.Generic;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Details;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.SlDetails;

namespace Ies.Logo.DataType.MaterialSlips
{
    [Serializable]
    public class Transaction : ILogo
    {

        #region Implementation

        #endregion

        #region SubClasses
        public virtual List<SerialLotTrn> SlDetails { get; set; }
        public virtual List<Detail> Details { get; set; }
        public virtual List<DefnFld> DefnFldsList { get; set; }
        #endregion
    }
}
