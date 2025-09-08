using System;
using System.Collections.Generic;
using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.ItemCharacteristics.Values;

namespace Ies.Logo.DataType.ItemCharacteristics
{
    [Serializable]
    public class CharacteristicCode : AuditedAggregateRoot, IAuxilCode, IAuthCode
    {
        public static LogoObjectType XmlRoot => LogoObjectType.ITEM_CHARACTERISTICS;

        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        #region Implementation
        public virtual string AuxilCode { get; set; }
        public virtual string AuthCode { get; set; }
        #endregion

        #region SubClasses
        public virtual List<CharacteristicValue> Values { get; set; }
        #endregion
    }
}
