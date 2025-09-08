using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.ItemCharacteristics.Values
{
    [Serializable]
    public class CharacteristicValue : ILogo
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual int ValNo { get; set; }
    }
}
