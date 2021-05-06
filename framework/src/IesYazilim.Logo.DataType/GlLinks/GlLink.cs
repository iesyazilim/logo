using System;
using IesYazilim.Logo.DataType.Infrastructure;

namespace IesYazilim.Logo.DataType.GlLinks
{
    [Serializable]
    public class GlLink : ILogo, IDataReference, IDataSiteId
    {
        public virtual Nullable<int> InfoType { get; set; }
        public virtual string GlaccCode { get; set; }
        public virtual string OhpCode { get; set; }

        #region Implementation
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        #endregion
    }
}
