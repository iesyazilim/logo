using Ies.Logo.Core;
using Ies.Logo.DataType.CqpnRolls;
using System;
using System.Collections.Generic;

namespace Ies.Logo.DataType.BankVouchers
{
    [Serializable]
    public class BankVoucherWithRoll : BankVoucher
    {
        public static new LogoObjectType XmlRoot => BankVoucher.XmlRoot;

        public virtual string BnAccCode { get; set; }
        public List<CqpnRoll> AttachmentRolls { get; set; }
    }
}
