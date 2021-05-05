using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Items
{
    [Serializable]
    public class Class : ILogo
    {
        public virtual Nullable<int> DomType { get; set; }
        public virtual string ClassCode { get; set; }
    }
}
