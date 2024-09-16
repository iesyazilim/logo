using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.Core.Configuration
{
    public class ParameterConfiguration : IParameterConfiguration
    {
        public short ReplicMode { get; set; } = 1;
        public short CheckParams { get; set; }
        public short CheckRight { get; set; }
        public short ApplyCampaign { get; set; }
        public short ApplyCondition { get; set; }
        public short FillAccCodes { get; set; } = 1;
        public short FormSeriLotLines { get; set; }
        public short SetClientInfo { get; set; }
    }
}
