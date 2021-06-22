using System;

namespace Ies.Logo.Core.Extensions
{
    public static class LogoExtension
    {
        public static DateTime ToLogoTime(this int time)
        {
            int HH, MM, SS;
            HH = (time - (time % 65536)) / 65536 / 256;
            MM = ((time - (time % 65536)) / 65536 - ((time - (time % 65536)) / 65536 / 256) * 256);
            SS = (((time % 65536) - ((time % 65536) % 256)) / 256);
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, HH, MM, SS);
        }

        public static int ToLogoTime(this DateTime time) => (time.Hour * 65536 * 256) + (time.Minute * 65536) + (time.Second * 256);
    }
}
