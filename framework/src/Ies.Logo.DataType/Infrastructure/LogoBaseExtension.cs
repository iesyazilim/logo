using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using Ies.Logo.DataType.Auditing;

namespace Ies.Logo.DataType.Infrastructure
{
    public static class LogoBaseExtension
    {
        public static void Set<T>(this List<T> data) where T : ILogoBase
        {
            data.Select(d => { d.Set(); return d; }).ToList();
        }

        public static void Set<T>(this T data) where T : ILogoBase
        {
            if (data?.DataReference > 0)
            {
                data.Dbop = Dbop.UPD;
                SetForUpdate(data);
            }
            else
            {
                data.Dbop = Dbop.INS;
                SetForAdd(data);
            }
        }

        private static void SetForAdd<T>(T data)
        {
            if (typeof(ICreationAuditedObject).IsAssignableFrom(typeof(T)))
            {
                var createdObject = data as ICreationAuditedObject;
                createdObject.CreationDate = DateTime.Now;
                createdObject.CreationHour = (short)DateTime.Now.Hour;
                createdObject.CreationMinute = (short)DateTime.Now.Minute;
                createdObject.CreationSecond = (short)DateTime.Now.Second;
                createdObject.CreatorId = Thread.CurrentPrincipal.FindUserNumber();
            }

            if (typeof(IDataNo).IsAssignableFrom(typeof(T)))
            {
                var createdObject = data as IDataNo;
                if (string.IsNullOrWhiteSpace(createdObject.DataNumber))
                    createdObject.DataNumber = "~";
            }
        }

        private static void SetForUpdate<T>(T data)
        {
            if (typeof(IModificationAuditedObject).IsAssignableFrom(typeof(T)))
            {
                var updatedObject = data as IModificationAuditedObject;
                updatedObject.LastModificationDate = DateTime.Now;
                updatedObject.LastModificationHour = (short)DateTime.Now.Hour;
                updatedObject.LastModificationMinute = (short)DateTime.Now.Minute;
                updatedObject.LastModificationSecond = (short)DateTime.Now.Second;
                updatedObject.LastModifierId = Thread.CurrentPrincipal.FindUserNumber();
            }
        }
    }
}
