﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Controls;
using Torq.Models.Objects;
using Torq.WPF.SchedualsService;

namespace Torq.WPF.Views
{
	public partial class CalenderPage : Page
	{
		DateTime Date { get; set; }
		Employee Employee { get; set; }

		private DateTime _SelectedDate;
		public DateTime SelectedDate {
			get { return _SelectedDate; }
			set { _SelectedDate = value; }
		}

		public CalenderPage(Employee employee)
		{
			Employee = employee;
			InitializeComponent();
			EmployeeLoggedIn.Content = employee?.FirstName + " " + employee?.LastName;
			Date = DateTime.Now;
			Month_title.Content = Date.Month.ToString() + "/" + Date.Year.ToString();
			FillCalendar(Date);
		}

		private void FillCalendar(DateTime date)
		{
			if (date == null)
				return;

			using (ScheduleServiceClient scheduleService = new ScheduleServiceClient())
			{
				var schedules = scheduleService.GetSchedulesByMonth(date);
				int days = DateTime.DaysInMonth(date.Year, date.Month);
				int weeks = GetWeekNumberOfMonth(date);
				var table = new DataTable();
				table.Columns.Add("Monday");
				table.Columns.Add("Tuesday");
				table.Columns.Add("Wensday");
				table.Columns.Add("thursday");
				table.Columns.Add("Friday");
				table.Columns.Add("Saturday");
				table.Columns.Add("Sunday");
				for (int i=0; i<=weeks; i++)
				{
					DataRow row = table.NewRow();
					for(int j=0; j<=6; j++)
					{
						int day = i * 7 + j + 1;
						var schedule = schedules.FirstOrDefault(s => s.EndTime.Day == day);

						if (day <= days)
							row[j] = day;
					}
					table.Rows.Add(row);
				}

				DataContext = table;
			}
		}

		public int GetWeekNumberOfMonth(DateTime date)
		{
			int mondays = 0;
			int month = date.Month;
			int year = date.Year;
			int daysThisMonth = DateTime.DaysInMonth(year, month);
			DateTime beginingOfThisMonth = new DateTime(year, month, 1);
			for (int i = 0; i < daysThisMonth; i++)
				if (beginingOfThisMonth.AddDays(i).DayOfWeek == DayOfWeek.Monday)
					mondays++;
			return mondays;
		}

		private void OnLogout(object sender, System.Windows.RoutedEventArgs e)
		{
			this.NavigationService.Navigate(new LoginPage());
		}

		private void OnPreviousMonth(object sender, System.Windows.RoutedEventArgs e)
		{
			Date = Date.AddMonths(-1);
			Month_title.Content = Date.Month.ToString() + "/" + Date.Year.ToString();
			FillCalendar(Date);
		}

		private void OnNextMonth(object sender, System.Windows.RoutedEventArgs e)
		{
			Date = Date.AddMonths(1);
			Month_title.Content = Date.Month.ToString()+"/"+Date.Year.ToString();
			FillCalendar(Date);
		}
	}
}
