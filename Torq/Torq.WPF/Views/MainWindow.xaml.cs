﻿using System.Windows;

namespace Torq.WPF.Views
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			MainFrame.Content = new LoginPage();
		}
	}
}
