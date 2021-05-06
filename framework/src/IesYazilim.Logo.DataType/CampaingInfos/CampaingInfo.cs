using System;
using IesYazilim.Logo.DataType.Infrastructure;

namespace IesYazilim.Logo.DataType.CampaingInfos
{
    [Serializable]
    public class CampaingInfo : ILogo
    {
        public virtual string Campcode1 { get; set; }
        public virtual string Campcode2 { get; set; }
        public virtual string Campcode3 { get; set; }
        public virtual string Campcode4 { get; set; }
        public virtual string Campcode5 { get; set; }
        public virtual string Pcampcode { get; set; }
        public virtual Nullable<int> CampLnNo { get; set; }
    }
}
