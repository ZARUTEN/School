using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace School
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
            UpdateData1();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Tex1.Text != "")
            {
                if (Tex2.Text != "")
                {
                    if (Tex3.Text != "")
                    {
                        if(tex4.Text != "")
                        {
                            Class1.GetContext().Авторизация.Add(new Авторизация()
                            {
                                Фио = Tex1.Text,
                                Логин = Tex2.Text,
                                Пароль = Tex3.Text,
                                Префикс = tex4.Text,
                            });                      
                            Class1.GetContext().SaveChanges();
                            MessageBox.Show("Занесение прошло успешно!");
                            UpdateData1();

                        }   
                        else
                        {
                            MessageBox.Show("Пожалуйста, Введите Префикс!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, Введите Пароль!");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, Введите Логин!");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, Введите ФИО!");
            }
        }
        public void UpdateData1()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from Авторизация in Class1.GetContext().Авторизация
                          select new
                          {
                              ID_Пользователя = Авторизация.ID_Пользователя,
                              Фио = Авторизация.Фио,
                              Логин = Авторизация.Логин,
                              Пароль = Авторизация.Пароль,
                              Префикс = Авторизация.Префикс,
                          };
            if (!String.IsNullOrEmpty(Poisk1.Text))
            {
                massive = massive.Where(p => p.Фио.Contains(Poisk1.Text));
            }   
            auth.ItemsSource = massive.ToList();

          

        }

        private void Button_3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(auth.SelectedItem)[0].GetValue(auth.SelectedItem));
                Авторизация poseh = Class1.GetContext().Авторизация.Where(p => p.ID_Пользователя == id).First();
                Class1.GetContext().Авторизация.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData1();
            }
        }

        private void Lable_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/RegisterA.xaml", UriKind.Relative));
            
        }

        private void Button_4(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            RegisterADD window = new RegisterADD(but.Tag);       
            window.Show();
        }

        private void Poisk1_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData1();
        }
    }
}
