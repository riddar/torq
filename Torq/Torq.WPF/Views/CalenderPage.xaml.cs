using System.Windows.Controls;
using Torq.WPF.EmployeesService;

namespace Torq.WPF.Views
{
	public partial class CalenderPage : Page
	{
		Employee employee; 

		public CalenderPage()
		{
			InitializeComponent();
			employee = new Employee() { Id=1, UserName="donald", Password="duck", FirstName="donald", LastName="duck" };
			EmployeeLoggedIn.Content = employee.FirstName + " " + employee.LastName;
		}
	}
}
