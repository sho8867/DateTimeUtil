using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class DateTimeUtil
    {
        public DateTime? StrToDate(string date, string time)
        {
            var result = DateTime.Parse(date);

            var hourMinute = time.Split(':');
            var hour = (int)int.Parse(hourMinute[0]);
            var minute = (int)int.Parse(hourMinute[1]);

            result = result.AddHours(hour);
            result = result.AddMinutes(minute);

            return result;
        }
    }
}
