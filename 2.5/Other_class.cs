using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

    
namespace _2._5
{
    class Other_class
    {
        public static DateTime date_time = new DateTime();
        public static DateOnly date = new DateOnly();
        public static List<string> kotiki = new List<string>();
        public static string kotik;
        public static void Days(Grid griiid)
        {
            Uri relativePusto = new Uri("/img/Пусто.png", UriKind.Relative);

            int month = date_time.Month;
            int days;
            switch (month)
            {
                case 2:
                    days = 28;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                default:
                    days = 30;
                    break;
            }

            int i = 1, j = 0, q = 0;
            while (i <= days)
            {
                if (q == 7) { j++; q = 0; }
                UserDay day = new UserDay();
                day.Day_number.Text = i.ToString();
                day.Photo.Source = new BitmapImage(relativePusto);

                griiid.Children.Add(day);
                Grid.SetRow(day, j);
                Grid.SetColumn(day, q);

                q++;
                i++;
            }
        }
    }
}
