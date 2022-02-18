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

namespace buhgalterWin
{
    public partial class BuhgalterWindow : Window
    {
        int prodCount = 0;
        int salaryCount = 0;
        int pribyl = 0;

        // ЗДЕСЬ ДОЛЖЕН БЫТЬ ЭКЗЕМПЛЯР БД

        public BuhgalterWindow()
        {
            InitializeComponent();
            // (ДАТАГРИДЫ)
            //dgProdukt.ItemsSource = 
            //dgZp.ItemsSource = 
            //dgOrders.ItemsSource = 

            
        }

        private void BttnBack_Click(object sender, RoutedEventArgs e)
        {
            // ВЫХОД В МЕНЮ
            this.Close();
        }
    }
}
