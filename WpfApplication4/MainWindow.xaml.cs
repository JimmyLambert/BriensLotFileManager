using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication4
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void AddLotMenuItem_Click(object sender, RoutedEventArgs e)
		{
			LotsGrid.ColumnDefinitions.Add(new ColumnDefinition());
		}

		private void LotMenuItem_Click(object sender, RoutedEventArgs e)
		{
			//LotsGrid.Children.Add();
			
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			LotWindow window = new LotWindow();
			window.ShowDialog();
			window.Activate();
		}

	}
}
