using System;
using IesYazilim.Logo.DataType.Infrastructure;

namespace IesYazilim.Logo.DataType.Units
{
    [Serializable]
    public class Barcode : ILogo, IDataReference, IGlobalId
    {
        public virtual string BARCODE { get; set; }
        public virtual Nullable<int> Type { get; set; }
        public virtual Nullable<short> WbarcodeShift { get; set; }

        #region Implementation
        public virtual Nullable<int> DataReference { get; set; }
        public virtual string GlobalId { get; set; }
        #endregion
    }
}
