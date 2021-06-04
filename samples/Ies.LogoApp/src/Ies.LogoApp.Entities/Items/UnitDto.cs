namespace Ies.LogoApp.Entities.Items
{
    public class UnitDto : IDto
    {
        public string UnitCode { get; set; }
        public decimal ConversionFactor1 { get; set; }
        public decimal ConversionFactor2 { get; set; }
    }
}
