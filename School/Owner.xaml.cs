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
    /// Логика взаимодействия для Owner.xaml
    /// </summary>
    public partial class Owner : Window
    {
        private Авторизация no;
        public Owner(Авторизация no)
        {
            InitializeComponent();

            User.Content = no.Фио;
            Dolz.Content = no.Префикс;
            Frames.Content = new Privet();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frames.Content = new Nach();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frames.Content = new mid();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Frames.Content = new konec();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow nigger = new MainWindow();
            nigger.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Frames.Content = new Register();
        }
    }
}
