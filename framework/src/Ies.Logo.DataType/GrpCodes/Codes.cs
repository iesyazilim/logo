using System;
using Ies.Logo.Core;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.GrpCodes
{
    [Serializable]
    public class Codes : LogoBase, IGlobalId, IDataSiteId, IDataNo
    {
        public static LogoObjectType XmlRoot => LogoObjectType.GRP_CODES;

        public virtual Nullable<int> CodeType{ get; set; }
        public virtual Nullable<int> SpeCodeType{ get; set; }
        public string DataNumber { get => Code; set => Code = value; }
        public virtual string Code{ get; set; }
        public virtual string Definition { get; set; }
        public virtual string Definition2 { get; set; }
        public virtual string Definition3 { get; set; }
        public virtual Nullable<int> Color{ get; set; }
        public virtual Nullable<int> Wincolor{ get; set; }

        #region Implementation
        public virtual string GlobalId { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        #endregion
    }
}
