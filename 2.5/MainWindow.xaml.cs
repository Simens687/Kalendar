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

namespace _2._5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Other_class.date_time = DateTime.Now;

            Smena(0);

            Dni.Content = new Dnis();

            
            
        }

        private void Smena(int month)
        {
            Other_class.date_time = Other_class.date_time.AddMonths(month);
            Date_sel.SelectedDate = Other_class.date_time;
        }

        private void Зкщвр_ьщтер(object sender, RoutedEventArgs e)
        {
            Dni.Content = null;
            Dni.Content = new Dnis();
            Smena(-1);
        }

        private void Туче_ьщтер(object sender, RoutedEventArgs e)
        {
            Dni.Content = null;
            Dni.Content = new Dnis();
            Smena(+1);
        }

        private void Sel(object sender, SelectionChangedEventArgs e)
        {
            Dni.Content = null;
            Other_class.date_time = (DateTime)Date_sel.SelectedDate;
            Dni.Content = new Dnis();
        }

    }
}
