using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public partial class UserDay : UserControl
    {
        public UserDay()
        {
            InitializeComponent();
        }

        private void Open_sost(object sender, RoutedEventArgs e)
        {
            Other_class.date = new DateOnly(Other_class.date_time.Year, Other_class.date_time.Month, Convert.ToInt32(Day_number.Text));

            var Dels = Application.Current.MainWindow.FindName("Dels") as Frame;
            var Dni = Application.Current.MainWindow.FindName("Dni") as Frame;

            Dni.Content = null;
            Dels.Content = new Sel();
        }
    }
}
