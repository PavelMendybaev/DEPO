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
using Kladari.Kladovshik;

namespace Kladari.Kladovshik
{
    /// <summary>
    /// Логика взаимодействия для MainKlad.xaml
    /// </summary>
    public partial class MainKlad : Window
    {
        DepoEntities1 depo = new DepoEntities1();
        public MainKlad()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sklad window = new Sklad();
            window.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Dellit del = new Dellit();
            del.Show();
        }
    }
}
