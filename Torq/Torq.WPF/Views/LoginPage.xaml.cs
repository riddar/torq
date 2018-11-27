using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
					
				}
			}
		}

		private void OnCancel(object sender, RoutedEventArgs e)
		{

		}
	}
}
