using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class DateTime_ExMethod
    {
        public static string ToPersianDateTime(this DateTime datetime)
        {
            PersianCalendar pc = new PersianCalendar();

            string date_time =
                pc.GetYear(datetime) + "/" + pc.GetMonth(datetime) + "/" + pc.GetDayOfMonth(datetime) + " - " +
                pc.GetHour(datetime) + ":" + pc.GetMinute(datetime) + ":" + pc.GetSecond(datetime);

            return date_time;
        }

        // public static string TopPersianDateTime(this DateTime datetime)
        // {
        //     PersianCalendar pc = new PersianCalendar();

        //     string date_time =
        //         pc.GetYear(datetime) + "/" + pc.GetMonth(datetime) + "/" + pc.GetDayOfMonth(datetime) + " - " +
        //         pc.GetHour(datetime) + ":" + pc.GetMinute(datetime) + ":" + pc.GetSecond(datetime);

        //     return date_time;
        // }
        
    }
}