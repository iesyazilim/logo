using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Auditing;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Xml
{
    public static partial class XmlMappingExtension
    {
        public static void Configure<T>(this ITypeConfiguration<T> typeConfigurations) where T : ILogo
        {
            var xmlRoot = typeof(T).GetProperty("XmlRoot");
            if (xmlRoot == null)
                typeConfigurations.Type<List<T>>().Name("ListOf" + typeof(T).Name);
            else
                typeConfigurations.Type<List<T>>().Name(xmlRoot.GetValue(null)?.ToString());

            if (typeof(IInternalReference).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, int?>(nameof(IInternalReference.InternalReference))).Name("INTERNAL_REFERENCE")
                  ;
            }

            if (typeof(IDataReference).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, int?>(nameof(IDataReference.DataReference))).Name("DATA_REFERENCE")
                  ;
            }

            if (typeof(ILogoBase).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, Dbop>(nameof(ILogoBase.Dbop))).Name("DBOP").Attribute()
                  .Member(GetMemberExpression<T, string>(nameof(ILogoBase.Guid))).Name("GUID")
                  .Member(GetMemberExpression<T, string>(nameof(ILogoBase.LogoId))).Name("LOGOID")
                  .Member(GetMemberExpression<T, string>(nameof(ILogoBase.OrgLogoId))).Name("ORGLOGOID")
                  ;
            }

            if (typeof(ICreationAuditedObject).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, short?>(nameof(ICreationAuditedObject.CreatorId))).Name("CREATED_BY")
                  .Member(GetMemberExpression<T, DateTime?>(nameof(ICreationAuditedObject.CreationDate))).Name("DATE_CREATED")
                  .Member(GetMemberExpression<T, short?>(nameof(ICreationAuditedObject.CreationHour))).Name("HOUR_CREATED")
                  .Member(GetMemberExpression<T, short?>(nameof(ICreationAuditedObject.CreationMinute))).Name("MIN_CREATED")
                  .Member(GetMemberExpression<T, short?>(nameof(ICreationAuditedObject.CreationSecond))).Name("SEC_CREATED")
                  ;
            }

            if (typeof(IModificationAuditedObject).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, short?>(nameof(IModificationAuditedObject.LastModifierId))).Name("MODIFIED_BY")
                  .Member(GetMemberExpression<T, DateTime?>(nameof(IModificationAuditedObject.LastModificationDate))).Name("DATE_MODIFIED")
                  .Member(GetMemberExpression<T, short?>(nameof(IModificationAuditedObject.LastModificationHour))).Name("HOUR_MODIFIED")
                  .Member(GetMemberExpression<T, short?>(nameof(IModificationAuditedObject.LastModificationMinute))).Name("MIN_MODIFIED")
                  .Member(GetMemberExpression<T, short?>(nameof(IModificationAuditedObject.LastModificationSecond))).Name("SEC_MODIFIED")
                  ;
            }

            if (typeof(IRecordStatus).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, short?>(nameof(IRecordStatus.RecordStatus))).Name("RECORD_STATUS")
                  ;
            }

            if (typeof(IAuthCode).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(IAuthCode.AuthCode))).Name("AUTH_CODE")
                  ;
            }

            if (typeof(IAuxilCode).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(IAuxilCode.AuxilCode))).Name("AUXIL_CODE")
                  ;

                if (typeof(IDetailedAuxilCode).IsAssignableFrom(typeof(T)))
                {
                    typeConfigurations
                      .Member(GetMemberExpression<T, string>(nameof(IDetailedAuxilCode.AuxilCode2))).Name("AUXIL_CODE2")
                      .Member(GetMemberExpression<T, string>(nameof(IDetailedAuxilCode.AuxilCode3))).Name("AUXIL_CODE3")
                      .Member(GetMemberExpression<T, string>(nameof(IDetailedAuxilCode.AuxilCode4))).Name("AUXIL_CODE4")
                      .Member(GetMemberExpression<T, string>(nameof(IDetailedAuxilCode.AuxilCode5))).Name("AUXIL_CODE5")
                      ;
                }
            }

            if (typeof(IGroupCode).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(IGroupCode.GroupCode))).Name("GROUP_CODE")
                  ;
            }

            if (typeof(ICancelled).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, short?>(nameof(ICancelled.Cancelled))).Name("CANCELLED")
                  ;
            }

            if (typeof(IPaymentCode).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(IPaymentCode.PaymentCode))).Name("PAYMENT_CODE")
                  ;
            }

            if (typeof(IProjectCode).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(IProjectCode.ProjectCode))).Name("PROJECT_CODE")
                  ;
            }

            if (typeof(IGlobalId).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(IGlobalId.GlobalId))).Name("GLOBAL_ID")
                  ;
            }

            if (typeof(ITradingGroup).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(ITradingGroup.TradingGrp))).Name("TRADING_GRP")
                  ;
            }

            if (typeof(ISourceIndex).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, short?>(nameof(ISourceIndex.SourceIndex))).Name("SOURCEINDEX")
                  ;
            }

            if (typeof(IDivision).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, short?>(nameof(IDivision.Division))).Name("DIVISION")
                  ;
            }

            if (typeof(IDepartment).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, short?>(nameof(IDepartment.Department))).Name("DEPARTMENT")
                  ;
            }

            if (typeof(IFactory).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, short?>(nameof(IFactory.Factory))).Name("FACTORY")
                  ;
            }

            if (typeof(IDataSiteId).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, int?>(nameof(IDataSiteId.DataSiteId))).Name("DATA_SITEID")
                  ;
            }

            if (typeof(IXmlAttribute).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, int?>(nameof(IXmlAttribute.XmlAttribute))).Name("XML_ATTRIBUTE")
                  ;
            }

            if (typeof(IApprove).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, short?>(nameof(IApprove.Approve))).Name("APPROVE")
                  .Member(GetMemberExpression<T, DateTime?>(nameof(IApprove.ApproveDate))).Name("APPROVE_DATE")
                  ;
            }

            if (typeof(IGlCodes).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(IGlCodes.GlCode1))).Name("GL_CODE1")
                  .Member(GetMemberExpression<T, string>(nameof(IGlCodes.GlCode2))).Name("GL_CODE2")
                  .Member(GetMemberExpression<T, string>(nameof(IGlCodes.GlCode3))).Name("GL_CODE3")
                  .Member(GetMemberExpression<T, string>(nameof(IGlCodes.GlCode4))).Name("GL_CODE4")
                  .Member(GetMemberExpression<T, string>(nameof(IGlCodes.GlCode5))).Name("GL_CODE5")
                  ;
            }

            if (typeof(IOhpCodes).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(IOhpCodes.OhpCode1))).Name("OHP_CODE1")
                  .Member(GetMemberExpression<T, string>(nameof(IOhpCodes.OhpCode2))).Name("OHP_CODE2")
                  .Member(GetMemberExpression<T, string>(nameof(IOhpCodes.OhpCode3))).Name("OHP_CODE3")
                  .Member(GetMemberExpression<T, string>(nameof(IOhpCodes.OhpCode4))).Name("OHP_CODE4")
                  .Member(GetMemberExpression<T, string>(nameof(IOhpCodes.OhpCode5))).Name("OHP_CODE5")
                  ;
            }

            if (typeof(IConvFacts).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(IConvFacts.UnitCode))).Name("UNIT_CODE")
                  .Member(GetMemberExpression<T, decimal?>(nameof(IConvFacts.UnitConv1))).Name("UNIT_CONV1")
                  .Member(GetMemberExpression<T, decimal?>(nameof(IConvFacts.UnitConv2))).Name("UNIT_CONV2")
                  .Member(GetMemberExpression<T, decimal?>(nameof(IConvFacts.UnitConv3))).Name("UNIT_CONV3")
                  .Member(GetMemberExpression<T, decimal?>(nameof(IConvFacts.UnitConv4))).Name("UNIT_CONV4")
                  .Member(GetMemberExpression<T, decimal?>(nameof(IConvFacts.UnitConv5))).Name("UNIT_CONV5")
                  .Member(GetMemberExpression<T, decimal?>(nameof(IConvFacts.UnitConv6))).Name("UNIT_CONV6")
                  .Member(GetMemberExpression<T, decimal?>(nameof(IConvFacts.UnitConv7))).Name("UNIT_CONV7")
                  .Member(GetMemberExpression<T, decimal?>(nameof(IConvFacts.UnitConv8))).Name("UNIT_CONV8")
                  ;
            }

            if (typeof(INotes).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(INotes.Notes1))).Name("NOTES1")
                  .Member(GetMemberExpression<T, string>(nameof(INotes.Notes2))).Name("NOTES2")
                  .Member(GetMemberExpression<T, string>(nameof(INotes.Notes3))).Name("NOTES3")
                  .Member(GetMemberExpression<T, string>(nameof(INotes.Notes4))).Name("NOTES4")
                  ;
            }

            if (typeof(IDataNo).IsAssignableFrom(typeof(T)))
            {
                typeConfigurations
                  .Member(GetMemberExpression<T, string>(nameof(IDataNo.DataNumber))).Ignore()
                  ;
            }
        }
        private static Expression<Func<T, TMember>> GetMemberExpression<T, TMember>(string propertOrFieldName)
        {
            var expressionParameter = Expression.Parameter(typeof(T), "m");
            var memberExpression = Expression.PropertyOrField(expressionParameter, propertOrFieldName);
            var final = Expression.Lambda(memberExpression, expressionParameter);

            return (Expression<Func<T, TMember>>)final;
        }
    }
}
