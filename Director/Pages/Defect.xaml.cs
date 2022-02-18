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

namespace WpfApp37.Pages
{
    /// <summary>
    /// Логика взаимодействия для Defect.xaml
    /// </summary>
    public partial class Defect : Page
    {
        DepoEntities2 db = new DepoEntities2();
        public Defect()
        {
            InitializeComponent();
            dg1.ItemsSource = db.Defect.ToList();
        }
    }
}
