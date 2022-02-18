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

namespace Kladari.Kladovshik
{
    /// <summary>
    /// Логика взаимодействия для Dellit.xaml
    /// </summary>
    public partial class Dellit : Window
    {
        DepoEntities1 dp = new DepoEntities1();
        public Dellit()
        {
            InitializeComponent();
            MyGrid.ItemsSource = dp.Product.ToList();
        }

        private void NameTovar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

           
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var dle = MyGrid.SelectedItem as Product;
            dp.Product.Remove(dle);
            dp.SaveChanges();
            MyGrid.ItemsSource = dp.Product.ToList();
            
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
