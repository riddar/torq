using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Torq.MVC.MethodLiberary
{
    public static class DateHandler
    {
        public static DayOfWeek GetDayOfWeek(int day)
        {
            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);
            return dateTime.DayOfWeek;
        }
    }
}