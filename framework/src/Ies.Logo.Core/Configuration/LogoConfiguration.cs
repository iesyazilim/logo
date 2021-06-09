using System;

namespace Ies.Logo.Core.Configuration
{
    public class LogoConfiguration : ILogoConfiguration
    {
        private string firmNumber;
        public string FirmNumber
        {
            get => firmNumber;
            set
            {
                if (value is null)
                {
                    firmNumber = null;
                }
                else
                {
                    value = value.PadLeft(3, '0');
                    if (value.Length == 3 && int.TryParse(value, out _))
                        firmNumber = value;
                    else
                        throw new Exception("FirmNumber casting exception", new Exception("Firma numarası 1-999 arasında bir değer olmalıdır."));
                }
            }
        }

        private string firmPeriod;
        public string FirmPeriod
        {
            get
            {
                return firmPeriod;
            }
            set
            {
                if (value is null)
                {
                    firmPeriod = null;
                }
                else
                {
                    value = value.PadLeft(2, '0');
                    if (value.Length == 2 && int.TryParse(value, out _))
                        firmPeriod = value;
                    else
                        throw new Exception("FirmPeriod casting exception", new Exception("Firma dönemi 1-99 arasında bir değer olmalıdır."));
                }
            }
        }
    }
}
