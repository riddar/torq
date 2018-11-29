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

			using (ScheduleServiceClient scheduleService = new ScheduleServiceClient())
			{
				Schedules_DataGrid.ItemsSource = scheduleService.GetSchedulesByEmployee(employee);
			}
		}

		private void OnLogout(object sender, System.Windows.RoutedEventArgs e)
		{
			this.NavigationService.Navigate(new LoginPage());
		}
	}
}
