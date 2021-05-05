using System;
using System.Collections.Generic;

namespace Ies.Logo.DataType.QcList
{
    [Serializable]
    public class QccValueEntry : Value
    {
        #region SubClasses
        public virtual List<Value> ValList { get; set; }
        #endregion
    }
}
