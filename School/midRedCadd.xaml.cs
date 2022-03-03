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
    /// Логика взаимодействия для midRedCadd.xaml
    /// </summary>
    public partial class midRedCadd : Page
    {
        public midRedCadd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tex1.Text != "")
            {
                if (tex2.Text != "")
                {
                    if (tex3.Text != "")
                    {
                        Class1.GetContext().ЧетвергС.Add(new ЧетвергС()
                        {
                            Кабинет = tex1.Text,
                            Предмет = tex2.Text,
                            Учитель = tex3.Text,
                        });
                        Class1.GetContext().SaveChanges();
                        MessageBox.Show("Занесение прошло успешно!");

                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, Введите Кабинет!");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, Введите Предмет!");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, Введите Учитель!");
            }
        }
    }
}
