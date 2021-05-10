using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.DefinitionFields
{
    [Serializable]
    public class DefnFld : ILogo, IDataReference, IDataSiteId, IXmlAttribute
    {
        public virtual Nullable<int> ModuleNr { get; set; }
        public virtual Nullable<short> Level { get; set; }
        public virtual Nullable<int> ParentRef { get; set; }
        public virtual Nullable<int> OwnerRef { get; set; }

        #region Text,Num fields
        public virtual string TextFlds1 { get; set; }
        public virtual string TextFlds2 { get; set; }
        public virtual string TextFlds3 { get; set; }
        public virtual string TextFlds4 { get; set; }
        public virtual string TextFlds5 { get; set; }
        public virtual string TextFlds6 { get; set; }
        public virtual string TextFlds7 { get; set; }
        public virtual string TextFlds8 { get; set; }
        public virtual string TextFlds9 { get; set; }
        public virtual string TextFlds10 { get; set; }
        public virtual string TextFlds11 { get; set; }
        public virtual string TextFlds12 { get; set; }
        public virtual string TextFlds13 { get; set; }
        public virtual string TextFlds14 { get; set; }
        public virtual string TextFlds15 { get; set; }
        public virtual string TextFlds16 { get; set; }
        public virtual string TextFlds17 { get; set; }
        public virtual string TextFlds18 { get; set; }
        public virtual string TextFlds19 { get; set; }
        public virtual string TextFlds20 { get; set; }
        public virtual string TextFlds21 { get; set; }
        public virtual string TextFlds22 { get; set; }
        public virtual string TextFlds23 { get; set; }
        public virtual string TextFlds24 { get; set; }
        public virtual string TextFlds25 { get; set; }
        public virtual string TextFlds26 { get; set; }
        public virtual string TextFlds27 { get; set; }
        public virtual string TextFlds28 { get; set; }
        public virtual string TextFlds29 { get; set; }
        public virtual string TextFlds30 { get; set; }
        public virtual string TextFlds31 { get; set; }
        public virtual string TextFlds32 { get; set; }
        public virtual string TextFlds33 { get; set; }
        public virtual string TextFlds34 { get; set; }
        public virtual string TextFlds35 { get; set; }
        public virtual string TextFlds36 { get; set; }
        public virtual string TextFlds37 { get; set; }
        public virtual string TextFlds38 { get; set; }
        public virtual string TextFlds39 { get; set; }
        public virtual string TextFlds40 { get; set; }
        public virtual string TextFlds41 { get; set; }
        public virtual string TextFlds42 { get; set; }
        public virtual string TextFlds43 { get; set; }
        public virtual string TextFlds44 { get; set; }
        public virtual string TextFlds45 { get; set; }
        public virtual string TextFlds46 { get; set; }
        public virtual string TextFlds47 { get; set; }
        public virtual string TextFlds48 { get; set; }
        public virtual string TextFlds49 { get; set; }
        public virtual string TextFlds50 { get; set; }

        public virtual Nullable<decimal> NumFlds1 { get; set; }
        public virtual Nullable<decimal> NumFlds2 { get; set; }
        public virtual Nullable<decimal> NumFlds3 { get; set; }
        public virtual Nullable<decimal> NumFlds4 { get; set; }
        public virtual Nullable<decimal> NumFlds5 { get; set; }
        public virtual Nullable<decimal> NumFlds6 { get; set; }
        public virtual Nullable<decimal> NumFlds7 { get; set; }
        public virtual Nullable<decimal> NumFlds8 { get; set; }
        public virtual Nullable<decimal> NumFlds9 { get; set; }
        public virtual Nullable<decimal> NumFlds10 { get; set; }
        public virtual Nullable<decimal> NumFlds11 { get; set; }
        public virtual Nullable<decimal> NumFlds12 { get; set; }
        public virtual Nullable<decimal> NumFlds13 { get; set; }
        public virtual Nullable<decimal> NumFlds14 { get; set; }
        public virtual Nullable<decimal> NumFlds15 { get; set; }
        public virtual Nullable<decimal> NumFlds16 { get; set; }
        public virtual Nullable<decimal> NumFlds17 { get; set; }
        public virtual Nullable<decimal> NumFlds18 { get; set; }
        public virtual Nullable<decimal> NumFlds19 { get; set; }
        public virtual Nullable<decimal> NumFlds20 { get; set; }
        public virtual Nullable<decimal> NumFlds21 { get; set; }
        public virtual Nullable<decimal> NumFlds22 { get; set; }
        public virtual Nullable<decimal> NumFlds23 { get; set; }
        public virtual Nullable<decimal> NumFlds24 { get; set; }
        public virtual Nullable<decimal> NumFlds25 { get; set; }
        public virtual Nullable<decimal> NumFlds26 { get; set; }
        public virtual Nullable<decimal> NumFlds27 { get; set; }
        public virtual Nullable<decimal> NumFlds28 { get; set; }
        public virtual Nullable<decimal> NumFlds29 { get; set; }
        public virtual Nullable<decimal> NumFlds30 { get; set; }
        public virtual Nullable<decimal> NumFlds31 { get; set; }
        public virtual Nullable<decimal> NumFlds32 { get; set; }
        public virtual Nullable<decimal> NumFlds33 { get; set; }
        public virtual Nullable<decimal> NumFlds34 { get; set; }
        public virtual Nullable<decimal> NumFlds35 { get; set; }
        public virtual Nullable<decimal> NumFlds36 { get; set; }
        public virtual Nullable<decimal> NumFlds37 { get; set; }
        public virtual Nullable<decimal> NumFlds38 { get; set; }
        public virtual Nullable<decimal> NumFlds39 { get; set; }
        public virtual Nullable<decimal> NumFlds40 { get; set; }
        public virtual Nullable<decimal> NumFlds41 { get; set; }
        public virtual Nullable<decimal> NumFlds42 { get; set; }
        public virtual Nullable<decimal> NumFlds43 { get; set; }
        public virtual Nullable<decimal> NumFlds44 { get; set; }
        public virtual Nullable<decimal> NumFlds45 { get; set; }
        public virtual Nullable<decimal> NumFlds46 { get; set; }
        public virtual Nullable<decimal> NumFlds47 { get; set; }
        public virtual Nullable<decimal> NumFlds48 { get; set; }
        public virtual Nullable<decimal> NumFlds49 { get; set; }
        public virtual Nullable<decimal> NumFlds50 { get; set; }
        #endregion

        #region Implementation
        public virtual Nullable<int> XmlAttribute { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        #endregion
    }
}
