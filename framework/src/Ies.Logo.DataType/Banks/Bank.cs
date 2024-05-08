using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.DefinitionFields;
using Ies.Logo.DataType.GrpCodes;
using Ies.Logo.DataType.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.Banks
{
    [Serializable]
    public class Bank : AuditedAggregateRoot, IRecordStatus, IAuxilCode, IAuthCode, IDataSiteId
    {
        public static LogoObjectType XmlRoot => LogoObjectType.BANKS;

        public virtual string Code { get; set; }
        public virtual string Title { get; set; }
        public virtual string Division { get; set; }
        public virtual string DivisionId { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string District { get; set; }
        public virtual string Town { get; set; }
        public virtual string City { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual string Country { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Telephone1 { get; set; }
        public virtual string Telephone2 { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Contact { get; set; }
        public virtual string Email { get; set; }
        public virtual string WebUrl { get; set; }
        public virtual string CorrpAcc { get; set; }
        public virtual string Voen { get; set; }

        #region Implementation
        public virtual Nullable<short> RecordStatus { get; set; }
        public virtual string AuxilCode { get; set; }
        public virtual string AuthCode { get; set; }
        public virtual Nullable<int> DataSiteId { get; set; }
        #endregion

        #region SubClasses
        public virtual List<DefnFld> DefnFldsList { get; set; }
        #endregion
    }
}
