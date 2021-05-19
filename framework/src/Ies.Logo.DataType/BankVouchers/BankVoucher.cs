using System;
using System.Collections.Generic;
using System.Text;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;

namespace Ies.Logo.DataType.BankVouchers
{
    [Serializable]
    public class BankVoucher : AuditedAggregateRoot
    {
        public static string XmlRoot => "BANK_VOUCHERS";

        #region Implementation

        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
