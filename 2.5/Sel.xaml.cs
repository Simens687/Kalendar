using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Sel.xaml
    /// </summary>
    public partial class Sel : Page
    {
        public Sel()
        {
            InitializeComponent();

            Daaay.Text = Other_class.date.ToString();
            Radio();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            var Dels = Application.Current.MainWindow.FindName("Dels") as Frame;
            var Dni = Application.Current.MainWindow.FindName("Dni") as Frame;

            Dni.Content = new Dnis();
            Dels.Content = null;
        }

        private void Radio()
        {
            Uri relativeVah = new Uri("/img/Вахуе котик.png", UriKind.Relative);

            UserSel Vah = new UserSel();
            Vah.Opis.Text = "Вахуе котик";
            Vah.Photo.Source = new BitmapImage(relativeVah);
            Vah.FontSize = 40;

            griiid.Children.Add(Vah);
            Grid.SetRow(Vah, 1);
            Grid.SetColumn(Vah, 1);
            Grid.SetColumnSpan(Vah, 5);

            Uri relativeGrust = new Uri("/img/Грустный котик.png", UriKind.Relative);

            UserSel Grust = new UserSel();
            Grust.Opis.Text = "Грустный котик";
            Grust.Photo.Source = new BitmapImage(relativeGrust);
            Grust.FontSize = 40;

            griiid.Children.Add(Grust);
            Grid.SetRow(Grust, 2);
            Grid.SetColumn(Grust, 1);
            Grid.SetColumnSpan(Grust, 5);

            Uri relativeAgree = new Uri("/img/Злой котик.png", UriKind.Relative);

            UserSel Agree = new UserSel();
            Agree.Opis.Text = "Злой котик";
            Agree.Photo.Source = new BitmapImage(relativeAgree);
            Agree.FontSize = 40;

            griiid.Children.Add(Agree);
            Grid.SetRow(Agree, 3);
            Grid.SetColumn(Agree, 1);
            Grid.SetColumnSpan(Agree, 5);
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Directory.CreateDirectory(desktop + "\\Дела");

            string json = JsonConvert.SerializeObject(Other_class.kotiki);
            File.WriteAllText(desktop + "\\Дела\\" + Daaay.Text + ".json", json);

            Other_class.kotiki = null;

            var Dels = Application.Current.MainWindow.FindName("Dels") as Frame;
            var Dni = Application.Current.MainWindow.FindName("Dni") as Frame;

            Dni.Content = new Dnis();
            Dels.Content = null;
        }
    }
}
