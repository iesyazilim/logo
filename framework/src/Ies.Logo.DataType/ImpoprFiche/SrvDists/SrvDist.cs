using Ies.Logo.DataType.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.ImpoprFiche.SrvDists
{
    public class SrvDist : ILogo
    {
        public Nullable<short> InfoDistType { get; set; }
        public string SrvCode { get; set; }
        public string SrvDefinition { get; set; }
        public Nullable<int> InternalReference { get; set; }
    }
}
