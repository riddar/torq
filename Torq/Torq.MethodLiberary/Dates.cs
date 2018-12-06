using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torq.MethodLiberary
{
    public class DateHandler
    {
        public  DayOfWeek GetDayOfWeek(int day)
        {
            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            return dateTime.DayOfWeek;
        }
    }
}
