using System;
using System.Collections.Generic;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;

namespace Ies.Logo.DataType.CqpnRolls
{
    [Serializable]
    public  class CqpnRoll : AuditedAggregateRoot
    {

        #region Implementation

        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
