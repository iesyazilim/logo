using System;
using System.Xml.Serialization;

namespace Ies.Logo.ServiceAdapter
{
    [Serializable]
    [XmlRoot("Parameters")]
    public class Parameter
    {
        public short ReplicMode { get; set; } = 1;
        public short CheckParams { get; set; }
        public short CheckRight { get; set; }
        public short ApplyCampaign { get; set; }
        public short Period { get; set; }
        public short ApplyCondition { get; set; }
        public short FillAccCodes { get; set; } = 1;
        public short FormSeriLotLines { get; set; }
        public short SetClientInfo { get; set; }
    }
}
