using System.Windows;
using System.Windows.Controls;
using Torq.WPF.EmployeesService;

namespace Torq.WPF.Views
{
	public partial class LoginPage : Page
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private void OnLogin(object sender, RoutedEventArgs e)
		{
			using (var employeeService = new EmployeeServiceClient())
			{
				var employee = employeeService.GetEmployeeByUserName(UserName.Text);
				if(employee != null && employee.Password == Password.Text)
				{
					this.NavigationService.Navigate(new CalenderPage());
				}
			}
		}

		private void OnCancel(object sender, RoutedEventArgs e)
		{

		}
	}
}
