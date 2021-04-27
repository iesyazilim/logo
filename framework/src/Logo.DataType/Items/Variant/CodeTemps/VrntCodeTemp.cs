using System;
using System.Collections.Generic;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.Items
{
    [Serializable]
    public class VrntCodeTemp : ILogo, IDataSiteId, IXmlAttribute, IDataReference
    {
        public virtual Nullable<int> Typ { get; set; }
        public virtual Nullable<short> Increment { get; set; }
        public virtual Nullable<int> Lenght { get; set; }
        public virtual string Sstart { get; set; }
        public virtual string Send { get; set; }
        public virtual string CharAbbrev { get; set; }
        public virtual Nullable<int> LineNr { get; set; }
        public virtual string CharCode { get; set; }
        public virtual string IncCode { get; set; }
        public virtual string TillCode { get; set; }
        public virtual Nullable<short> FirstTime { get; set; }
        public virtual Nullable<int> Visited { get; set; }
        public virtual Nullable<int> Vcount { get; set; }
        public virtual Nullable<int> Count { get; set; }

        #region Implementation
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> XmlAttribute { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        #endregion

        #region SubClasses
        public virtual List<TempVal> TempVals { get; set; }
        #endregion
    }
}
