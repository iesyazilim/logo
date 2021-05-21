using System;
using System.Collections.Generic;
using Ies.Logo.DataType.AggregateRoot;

namespace Ies.Logo.DataType.GlVouchers
{
    [Serializable]
    public class GlVoucher : AuditedAggregateRoot
    {
        public static string XmlRoot => "GL_VOUCHERS";


    }
}
