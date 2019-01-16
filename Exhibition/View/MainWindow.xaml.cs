//using Exhibition.ViewModel.ViewModels;
using Exhibition.ViewModel.VisitorData;
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

namespace Exhibition
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        VMDesctop h;

		public MainWindow()
		{
            h = new VMDesctop();
			InitializeComponent();
		}

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void VMDesctop_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(workgrid.ItemsSource).Refresh(); ;
        }
    }
}
