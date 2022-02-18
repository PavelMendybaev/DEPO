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
using WpfApp37.Pages;

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для Director.xaml
    /// </summary>
    public partial class Director : Window
    {
        public Director()
        {
            InitializeComponent();
        }

        private void btnrasxodaanddoxodi_Click(object sender, RoutedEventArgs e)
        {
            framepages.Navigate(new Expenses());
        }

        private void btnproducts_Click(object sender, RoutedEventArgs e)
        {
            framepages.Navigate(new Products());
        }

        private void btnzakazi_Click(object sender, RoutedEventArgs e)
        {
            framepages.Navigate(new Orders());
        }

        private void btnraspisanie_Click(object sender, RoutedEventArgs e)
        {
            framepages.Navigate(new TimeTable());
        }

        private void btnexitakk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnerrors_Click(object sender, RoutedEventArgs e)
        {
            framepages.Navigate(new Defect());
        }
    }
}
