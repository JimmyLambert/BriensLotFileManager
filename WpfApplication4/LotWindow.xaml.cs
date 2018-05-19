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
using System.Windows.Shapes;

namespace WpfApplication4
{
	/// <summary>
	/// Interaction logic for LotWindow.xaml
	/// </summary>
	public partial class LotWindow : Window
	{
		List<LotButton> LotButtons = new List<LotButton>();
		public LotWindow()
		{
			InitializeComponent();
		}

		private void AddLotButton_Click(object sender, RoutedEventArgs e)
		{
			
		}

		//<Button Content="SampleButton"/>
		//<Button Content="SimpleButton;)" Click="Button_Click"/>

	}
}
