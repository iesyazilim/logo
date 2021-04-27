using System;

namespace Logo.DataType.Infrastructure
{
    public interface IConvFacts
    {
        string UnitCode { get; set; }
        Nullable<decimal> UnitConv1 { get; set; }
        Nullable<decimal> UnitConv2 { get; set; }
        Nullable<decimal> UnitConv3 { get; set; }
        Nullable<decimal> UnitConv4 { get; set; }
        Nullable<decimal> UnitConv5 { get; set; }
        Nullable<decimal> UnitConv6 { get; set; }
        Nullable<decimal> UnitConv7 { get; set; }
        Nullable<decimal> UnitConv8 { get; set; }
    }
}
