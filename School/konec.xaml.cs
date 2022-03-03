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
    /// Логика взаимодействия для konec.xaml
    /// </summary>
    public partial class konec : Page
    {
        public konec()
        {
            InitializeComponent();
            UpdateData1();
            UpdateData2();
            UpdateData3();
            UpdateData4();
            UpdateData5();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/konecRed.xaml", UriKind.Relative));
        }
        public void UpdateData1()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ПонедельникСТ in Class1.GetContext().ПонедельникСТ
                          select new
                          {
                              ID_ПонедельниикСТ = ПонедельникСТ.ID_ПонедельниикСТ,
                              Кабинет = ПонедельникСТ.Кабинет,
                              Предмет = ПонедельникСТ.Предмет,
                              Учитель = ПонедельникСТ.Учитель,
                          };
            Poned.ItemsSource = massive.ToList();
        }
        public void UpdateData2()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ВторникСТ in Class1.GetContext().ВторникСТ
                          select new
                          {
                              ID_ВторникСТ = ВторникСТ.ID_ВторникСТ,
                              Кабинет = ВторникСТ.Кабинет,
                              Предмет = ВторникСТ.Предмет,
                              Учитель = ВторникСТ.Учитель,
                          };
            VTOR.ItemsSource = massive.ToList();
        }
        public void UpdateData3()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from СредаСТ in Class1.GetContext().СредаСТ
                          select new
                          {
                              ID_СредаСТ = СредаСТ.ID_СредаСТ,
                              Кабинет = СредаСТ.Кабинет,
                              Предмет = СредаСТ.Предмет,
                              Учитель = СредаСТ.Учитель,
                          };
            Sred.ItemsSource = massive.ToList();
        }
        public void UpdateData4()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ЧетвергСТ in Class1.GetContext().ЧетвергСТ
                          select new
                          {
                              ID_Четверг = ЧетвергСТ.ID_Четверг,
                              Кабинет = ЧетвергСТ.Кабинет,
                              Предмет = ЧетвергСТ.Предмет,
                              Учитель = ЧетвергСТ.Учитель,
                          };
            Chet.ItemsSource = massive.ToList();
        }
        public void UpdateData5()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ПятницаСТ in Class1.GetContext().ПятницаСТ
                          select new
                          {
                              ID_ПятницаСТ = ПятницаСТ.ID_ПятницаСТ,
                              Кабинет = ПятницаСТ.Кабинет,
                              Предмет = ПятницаСТ.Предмет,
                              Учитель = ПятницаСТ.Учитель,
                          };
            pat.ItemsSource = massive.ToList();
        }
    }
}
