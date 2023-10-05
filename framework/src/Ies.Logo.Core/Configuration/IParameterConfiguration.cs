using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.Core.Configuration
{
    public interface IParameterConfiguration
    {
        short ReplicMode { get; set; }
        short CheckParams { get; set; }
        short CheckRight { get; set; }
        short ApplyCampaign { get; set; }
        //short Period { get; set; }
        short ApplyCondition { get; set; }
        short FillAccCodes { get; set; }
        short FormSeriLotLines { get; set; }
        short SetClientInfo { get; set; }
    }
}
