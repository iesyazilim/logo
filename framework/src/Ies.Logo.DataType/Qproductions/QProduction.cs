using System;
using System.Collections.Generic;
using System.Text;
using Ies.Logo.DataType.AggregateRoot;

namespace Ies.Logo.DataType.Qproductions
{
    [Serializable]
    public class QProduction : AuditedAggregateRoot
    {
        public static string XmlRoot => "QPRODUCTIONS";



        #region Implementation

        #endregion

        #region SubClasses
        public virtual List<Transaction> Transactions { get; set; }
        #endregion
    }
}
