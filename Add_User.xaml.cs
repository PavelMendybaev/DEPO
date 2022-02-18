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
    /// Логика взаимодействия для Add_User.xaml
    /// </summary>
    public partial class Add_User : Window
    {
        
        public Add_User()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DepoEntities BD = new DepoEntities ();

            bool tr = true;
            for (int id = 0 ,d = 0 ; id < BD.User.Count() + d; id++)
            {
                if (BD.User.Find(id) != null)
                {
                    if (BD.User.Find(id).Login == LogBox.Text)
                    {
                        MessageBox.Show("Пользователь существут");
                        tr = false;
                        break;
                    }
                    
                }
                else {
                    d++;
                }
            }


            if (tr) {
                for (int id = 0; id < BD.User.Count() + 1; id++)
                {


                    if (BD.User.Find(id) == null)
                    {
                        BD.User.Add(new User
                        {
                            idUser = id,
                            Workers = Combo_box.Text,
                            Login = LogBox.Text,
                            Password = PassBox.Text,
                            Agreement = "1"
                        });
                        MessageBox.Show("пользователь добвлен");
                        
                        break;
                    }
                }
            }


            
            
           

            BD.SaveChanges();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
