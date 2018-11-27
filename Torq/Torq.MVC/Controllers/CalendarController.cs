﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Torq.Models.Objects;

namespace Torq.MVC.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            Schedule[] MockArray = new Schedule[] {
           new Schedule { Id = 1, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 1, 18, 30, 52), StartTime = new DateTime(2018, 5, 1, 8, 30, 52), Salary = null },
           new Schedule { Id = 2, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 2, 18, 30, 52), StartTime = new DateTime(2018, 5, 2, 8, 30, 52), Salary = null },
           new Schedule { Id = 3, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 3, 18, 30, 52), StartTime = new DateTime(2018, 5, 3, 8, 30, 52), Salary = null },
           new Schedule { Id = 4, ClockedIn = true, Employee = new Employee { Id = 1, FirstName = "Tobb", LastName = "Fobbs", IsOnline = false }, EndTime = new DateTime(2018, 5, 4, 18, 30, 52), StartTime = new DateTime(2018, 5, 4, 8, 30, 52), Salary = null },
            new Schedule { Id = 5, ClockedIn = false, Employee = new Employee { Id = 2, FirstName = "Mobbs", LastName = "Robbs", IsOnline = false }, EndTime = new DateTime(2018, 5, 5, 18, 30, 52), StartTime = new DateTime(2018, 5, 5, 8, 30, 52), Salary = null },

        };

            List<Schedule> MockList = new List<Schedule>();
            MockList.Add(new Schedule { Id = 1, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 1, 18, 30, 52), StartTime = new DateTime(2018, 5, 1, 8, 30, 52), Salary = null });
            MockList.Add(new Schedule { Id = 2, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 2, 18, 30, 52), StartTime = new DateTime(2018, 5, 2, 8, 30, 52), Salary = null });
            MockList.Add(new Schedule { Id = 3, ClockedIn = false, Employee = null, EndTime = new DateTime(2018, 5, 3, 18, 30, 52), StartTime = new DateTime(2018, 5, 3, 8, 30, 52), Salary = null });
            MockList.Add(new Schedule { Id = 4, ClockedIn = true, Employee = new Employee { Id = 1, FirstName = "Tobb", LastName = "Fobbs", IsOnline = false }, EndTime = new DateTime(2018, 5, 4, 18, 30, 52), StartTime = new DateTime(2018, 5, 4, 8, 30, 52), Salary = null });
            MockList.Add(new Schedule { Id = 5, ClockedIn = false, Employee = new Employee { Id = 2, FirstName = "Mobbs", LastName = "Robbs", IsOnline = false }, EndTime = new DateTime(2018, 5, 5, 18, 30, 52), StartTime = new DateTime(2018, 5, 5, 8, 30, 52), Salary = null });

            ViewBag.CalendarDataArray = MockArray;
            ViewBag.CalendarDataList = MockList;
            //@model Torq.Models.Objects.Schema[]
            //@model List<Torq.Models.Objects.Schema>
            return View(MockArray);
        }
    }
}