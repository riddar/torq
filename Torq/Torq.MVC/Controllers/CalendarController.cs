using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Torq.MethodLiberary;

namespace Torq.MVC.Controllers
{
    public  class CalendarController : Controller
    {
        DateHandler dateHandler = new DateHandler();

        // GET: Calendar
        public ActionResult Index()
        {
            ViewBag.DayOfWeek = dateHandler.GetDayOfWeek(1);
            return View();
        }

        

        
    }
}