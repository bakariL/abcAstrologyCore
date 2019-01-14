using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Extentions
{
    public static class DateTimeExtensions
    {
        public static DateTime EstNow()
        {
            var timeUtc = DateTime.UtcNow;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime estNow = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);
            return estNow;
        }
    }
}
