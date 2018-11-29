using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows.Controls;
using Torq.Models.Objects;
using Torq.WPF.SchedulesService;

namespace Torq.WPF.Views
{
	public partial class CalenderPage : Page
	{ 
		public CalenderPage(Employee employee)
		{

			InitializeComponent();
			EmployeeLoggedIn.Content = employee?.FirstName + " " + employee?.LastName;
			Month_title.Content = DateTime.Now.Month.ToString();
			FillCalendar();
			using (ScheduleServiceClient scheduleService = new ScheduleServiceClient())
			{
			}
		}

		private void FillCalendar()
		{
			var table = new DataTable();
			int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
			int weeks = GetWeekNumberOfMonth(DateTime.Now);

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
					if (day <= days)
						row[j] = day;
				}
				table.Rows.Add(row);
			}

			DataContext = table;
		}

		public int GetWeekNumberOfMonth(DateTime date)
		{
			date = date.Date;
			DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
			DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
			if (firstMonthMonday > date)
			{
				firstMonthDay = firstMonthDay.AddMonths(-1);
				firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
			}
			return (date - firstMonthMonday).Days / 7 + 1;
		}

		private void OnLogout(object sender, System.Windows.RoutedEventArgs e)
		{
			this.NavigationService.Navigate(new LoginPage());
		}
	}
}
