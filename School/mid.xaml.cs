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
    /// Логика взаимодействия для mid.xaml
    /// </summary>
    public partial class mid : Page
    {
        public mid()
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
            this.NavigationService.Navigate(new Uri("/midRed.xaml", UriKind.Relative));
        }
        public void UpdateData1()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ПонедельникС in Class1.GetContext().ПонедельникС
                          select new
                          {
                              ID_ПонедельниикС = ПонедельникС.ID_ПонедельниикС,
                              Кабинет = ПонедельникС.Кабинет,
                              Предмет = ПонедельникС.Предмет,
                              Учитель = ПонедельникС.Учитель,
                          };
            Poned.ItemsSource = massive.ToList();
        }
        public void UpdateData2()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ВторникС in Class1.GetContext().ВторникС
                          select new
                          {
                              ID_ВторникС = ВторникС.ID_ВторникС,
                              Кабинет = ВторникС.Кабинет,
                              Предмет = ВторникС.Предмет,
                              Учитель = ВторникС.Учитель,
                          };
            VTOR.ItemsSource = massive.ToList();
        }
        public void UpdateData3()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from СредаС in Class1.GetContext().СредаС
                          select new
                          {
                              ID_СредаС = СредаС.ID_СредаС,
                              Кабинет = СредаС.Кабинет,
                              Предмет = СредаС.Предмет,
                              Учитель = СредаС.Учитель,
                          };
            Sred.ItemsSource = massive.ToList();
        }
        public void UpdateData4()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ЧетвергС in Class1.GetContext().ЧетвергС
                          select new
                          {
                              ID_ЧетвергС = ЧетвергС.ID_ЧетвергС,
                              Кабинет = ЧетвергС.Кабинет,
                              Предмет = ЧетвергС.Предмет,
                              Учитель = ЧетвергС.Учитель,
                          };
            Chet.ItemsSource = massive.ToList();
        }
        public void UpdateData5()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ПятницаС in Class1.GetContext().ПятницаС
                          select new
                          {
                              ID_ПятницаС = ПятницаС.ID_ПятницаС,
                              Кабинет = ПятницаС.Кабинет,
                              Предмет = ПятницаС.Предмет,
                              Учитель = ПятницаС.Учитель,
                          };
            pat.ItemsSource = massive.ToList();
        }
    }
}
