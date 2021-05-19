using System;
using System.Collections.Generic;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Payments;

namespace Ies.Logo.DataType.BankVouchers
{
    [Serializable]
    public class Transaction : ILogo
    {

        #region Implementation
     
        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        public virtual List<Payment> PaymentList { get; set; }
        #endregion
    }
}
