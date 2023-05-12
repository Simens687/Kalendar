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
    /// <summary>
    /// Логика взаимодействия для Month_Page.xaml
    /// </summary>
    public partial class Month_Page : Page
    {
        public Month_Page()
        {
            InitializeComponent();

            Uri relativePusto = new Uri("/img/Пусто.png", UriKind.Relative);

            UserDay one = new UserDay();
            one.Day_number.Text = "1";
            one.Photo.Source = new BitmapImage(relativePusto);

            griiid.Children.Add(one);
            Grid.SetRow(one, 1);
            Grid.SetColumn(one, 0);
        }
    }
}
