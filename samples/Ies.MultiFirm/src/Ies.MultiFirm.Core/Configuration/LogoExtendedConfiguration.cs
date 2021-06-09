using System;
using Ies.Logo.Core.Configuration;

namespace Ies.MultiFirm.Configuration
{
    public class LogoExtendedConfiguration : LogoConnectionConfiguration, ILogoExtendedConfiguration
    {
        public LogoExtendedConfiguration(string connectionString) : base (connectionString)
        {
            
        }

        private string oldFirmNumber;
        public string OldFirmNumber
        {
            get => oldFirmNumber;
            set
            {
                if (value is null)
                {
                    oldFirmNumber = null;
                }
                else
                {
                    value = value.PadLeft(3, '0');
                    if (value.Length == 3 && int.TryParse(value, out _))
                        oldFirmNumber = value;
                    else
                        throw new Exception("FirmNumber casting exception", new Exception("Firma numarası 1-999 arasında bir değer olmalıdır."));
                }
            }
        }

        private string oldFirmPeriod;
        public string OldFirmPeriod
        {
            get
            {
                return oldFirmPeriod;
            }
            set
            {
                if (value is null)
                {
                    oldFirmPeriod = null;
                }
                else
                {
                    value = value.PadLeft(2, '0');
                    if (value.Length == 2 && int.TryParse(value, out _))
                        oldFirmPeriod = value;
                    else
                        throw new Exception("FirmPeriod casting exception", new Exception("Firma dönemi 1-99 arasında bir değer olmalıdır."));
                }
            }
        }
    }
}
