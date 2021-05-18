using System;
using System.Collections.Generic;
using System.Text;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;

namespace Ies.Logo.DataType.ArpVouchers
{
    [Serializable]
    public class ArpVoucher : AuditedAggregateRoot
    {


        #region Implementation

        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
