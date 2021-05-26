using System;
using System.Collections.Generic;
using Ies.Logo.DataType.AggregateRoot;

namespace Ies.Logo.DataType.MaterialSlips
{
    [Serializable]
    public class Slip : AuditedAggregateRoot
    {
        public static string XmlRoot => "MATERIAL_SLIPS";



        #region Implementation

        #endregion

        #region SubClasses
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
