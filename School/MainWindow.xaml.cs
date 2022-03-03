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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(Login.Text) || !String.IsNullOrEmpty(Pass.Password))
            {
                IQueryable<Авторизация> Авторизация_list = Class1.GetContext().Авторизация.Where(p => p.Логин == Login.Text && p.Пароль == Pass.Password);
                if (Авторизация_list.Count() == 1)
                {
                    MessageBox.Show("Добро пожаловать, " + Авторизация_list.First().Фио);
                    Owner cry = new Owner(Авторизация_list.First());                 
                    cry.Show();
                    this.Close();
                }
                else MessageBox.Show("Неверный логин или пароль!");
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
