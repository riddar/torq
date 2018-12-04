using System;
using System.Windows.Controls;
using Torq.WPF.SchedualsService;

namespace Torq.WPF.Views
{
	public partial class DayCalendarPage : Page
	{

		public DayCalendarPage(DateTime date)
		{
			InitializeComponent();
			using (ScheduleServiceClient scheduleService = new ScheduleServiceClient())
			{
				var schedules = scheduleService.GetSchedulesByDay(date);
				DayList.ItemsSource = schedules;
			}
		}
	}
}
