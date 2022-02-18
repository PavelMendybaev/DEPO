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

namespace Admin_PV
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        DepoEntities BD = new DepoEntities();
        
        
        public Admin()
        {
            InitializeComponent();
            Mydatagrid.ItemsSource = BD.User.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            for (int i = 0, count = 0; i < BD.User.Count() + count; i++)
            {
                if (BD.User.Find(i) != null)
                {
                    if (TB.Text == BD.User.Find(i).Login)
                    {
                        LB.Content = "  В строчки " + BD.User.Find(i).idUser;
                    }
                    
                }
                else
                {
                    count++;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Add_User add_User = new Add_User();
            add_User.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var Dle = Mydatagrid.SelectedItem as User;
            BD.User.Remove(Dle);
            BD.SaveChanges();
            Mydatagrid.ItemsSource = BD.User.ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BD.SaveChanges();
            MessageBox.Show("Изминения сохранины");
        }
    }
}
