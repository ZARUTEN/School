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

namespace School
{
    /// <summary>
    /// Логика взаимодействия для konecRedPyat.xaml
    /// </summary>
    public partial class konecRedPyat : Page
    {
        public konecRedPyat(object id)
        {
            InitializeComponent();
            DataContext = Class1.GetContext().ПятницаСТ.Where(p => p.ID_ПятницаСТ == (int)id).First();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1.GetContext().SaveChanges();
            MessageBox.Show("Успешно!");
        }
    }
}
