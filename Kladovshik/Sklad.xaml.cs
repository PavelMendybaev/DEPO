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
    /// Логика взаимодействия для Sklad.xaml
    /// </summary>
    public partial class Sklad : Window
        
    {
        DepoEntities1 dp = new DepoEntities1();
        
        public Sklad()
        {

            InitializeComponent();
            MyGrid.ItemsSource = dp.Product.ToList();
        }
      

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainKlad home = new MainKlad();
            home.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        { 
                for (int id = 0 ; id < dp.Product.Count() + 1; id++)
                {
                    if (dp.Product.Find(id) == null)
                    {
                        dp.Product.Add(new Product
                        {
                            ProductsName = NameTovar.Text,
                            Quantity = Convert.ToInt32(NumTovar.Text),
                            DeliveryTime = DateTime.Now,
                            Cost = Convert.ToInt32(Cost.Text),
                            Info = Descrip.Text,
                            NumStorage = NameSklad.Text, 

                        });
                        
      
                        MessageBox.Show("товар добавлен");
                        break;
                    }

                    
                }
            dp.SaveChanges();
            MyGrid.ItemsSource = dp.Product.ToList();


        }

        

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var dle = MyGrid.SelectedItem as Product;
            dp.Product.Remove(dle);
            dp.SaveChanges();
            MyGrid.ItemsSource = dp.Product.ToList();
        }
    }
}
