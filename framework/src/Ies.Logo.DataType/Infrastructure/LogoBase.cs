using System;
using Ies.Logo.Core;

namespace Ies.Logo.DataType.Infrastructure
{
    [Serializable]
    public abstract class LogoBase : ILogoBase
    {
        public virtual Dbop Dbop { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual Nullable<int> InternalReference { get; set; }
        public virtual string Guid { get; set; }
        public virtual string LogoId { get; set; }
        public virtual string OrgLogoId { get; set; }

        public virtual LogoObjectType GetRootElementName() => (LogoObjectType)this.GetType().GetProperty("XmlRoot").GetValue(null);
    }
}
