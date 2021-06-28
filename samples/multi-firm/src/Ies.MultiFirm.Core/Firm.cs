namespace Ies.MultiFirm
{
    public class Firm
    {
        public string Name { get; set; }
        public string FirmNumber { get; set; }
        public string FirmPeriod { get; set; }
        public string OldFirmNumber { get; set; }
        public string OldFirmPeriod { get; set; }
        public string ConnectionString { get; set; }
        public string EndpointAddress { get; set; }
        public string SecurityCode { get; set; }
        public string Lbsloadpass { get; set; }
        public bool UseCompressedString { get; set; }
    }
}
