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
    /// Логика взаимодействия для UserSel.xaml
    /// </summary>
    public partial class UserSel : UserControl
    {
        public UserSel()
        {
            InitializeComponent();
        }

        private void Cl(object sender, RoutedEventArgs e)
        {
            Other_class.kotik = Opis.Text;
            Other_class.kotiki.Add(Other_class.kotik);
        }
    }
}
