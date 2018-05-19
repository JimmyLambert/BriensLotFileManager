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

namespace WpfApplication4
{
	class LotButton : Button
	{
		string Path;
		string LabelName;

		public LotButton()
		{
			
		}

		private void LotButton_Click(WebBrowser wb)
		{
			wb.Source = new Uri(this.Path);
		}

		public partial class LotButtonDialog : Window
		{
			Label NameLabel;
			TextBox NameTextBox;
			Label FileLabel;
			Label DialogResultLabel;
			Button BrowseButton;
			Button CreateButton;
			Button CancelButton;
			Grid MainGrid;
			public LotButtonDialog()
			{
				this.AddChild(MainGrid);

				MainGrid.Margin = new Thickness(10);
				MainGrid.RowDefinitions.Add(new RowDefinition());
				MainGrid.RowDefinitions.Add(new RowDefinition());
				MainGrid.RowDefinitions.Add(new RowDefinition());
				MainGrid.ColumnDefinitions.Add(new ColumnDefinition());
				MainGrid.ColumnDefinitions.Add(new ColumnDefinition());
				MainGrid.ColumnDefinitions.Add(new ColumnDefinition());

				NameLabel = new Label();
				NameLabel.Content = "Enter Name: ";
				MainGrid.Children.Add(NameLabel);
				Grid.SetColumn(NameLabel, 1);
				Grid.SetRow(NameLabel, 0);

				NameTextBox = new TextBox();
				MainGrid.Children.Add(NameTextBox);
				Grid.SetColumnSpan(NameTextBox, 2);
				Grid.SetRow(NameLabel, 0);

				FileLabel = new Label();
				FileLabel.Content = "Path to File: ";
				MainGrid.Children.Add(FileLabel);
				Grid.SetColumn(FileLabel, 0);
				Grid.SetRow(FileLabel, 1);

				DialogResultLabel = new Label();
				MainGrid.Children.Add(DialogResultLabel);
				Grid.SetColumn(DialogResultLabel ,1);
				Grid.SetRow(DialogResultLabel, 1);

				BrowseButton = new Button();
				BrowseButton.Content = "Browse...";
				MainGrid.Children.Add(BrowseButton);
				Grid.SetColumn(BrowseButton, 1);
				Grid.SetRow(BrowseButton, 2);

				CreateButton = new Button();
				CreateButton.Content = "Create";
				MainGrid.Children.Add(CreateButton);
				Grid.SetColumn(CreateButton, 2);
				Grid.SetRow(CreateButton, 1);

				CancelButton = new Button();
				CancelButton.Content = "Cancel";
				MainGrid.Children.Add(CancelButton);
				Grid.SetColumn(CancelButton, 2);
				Grid.SetRow(CancelButton, 2);
			}
			private void CreateButton_Click(object sender, RoutedEventArgs e)
			{

			}
		}
		//bool validEntry = false;
		//	do
		//	{
		//		LotButton newLotButton = new LotButton();
		//		if(newLotButton.GetName().Equals(oldLotButton.GetName())))
		//		{
		//			MessageBox.Show("Error, Name Already Taken. Try Again.");
		//		}
		//		else
		//			validEntry=true;
		//	} while (validEntry == false);



		//	Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
		//	dlg.ShowDialog();
		//	try
		//	{
		//		LotButtons.Add(new LotButton(@"C:\Users\Developer\Desktop\This is a purchase order.pdf"));
		//		LotButtonStackPanel.Children.Add(LotButtons.Last());
		//	}
		//	catch(Exception ex)
		//	{
		//		MessageBox.Show(ex.Message);
		//	}
			
	}
}
