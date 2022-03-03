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
    /// Логика взаимодействия для midRed.xaml
    /// </summary>
    public partial class midRed : Page
    {
        public midRed()
        {
            InitializeComponent();
            UpdateData1();
            UpdateData2();
            UpdateData3();
            UpdateData4();
            UpdateData5();
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

        private void Button_PON1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(Poned.SelectedItem)[0].GetValue(Poned.SelectedItem));
                ПонедельникС poseh = Class1.GetContext().ПонедельникС.Where(p => p.ID_ПонедельниикС == id).First();
                Class1.GetContext().ПонедельникС.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData1();
            }
        }

        private void Button_PON2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new midRedP(but.Tag);
        }

        private void Button_VTOR1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(VTOR.SelectedItem)[0].GetValue(VTOR.SelectedItem));
                ВторникС poseh = Class1.GetContext().ВторникС.Where(p => p.ID_ВторникС == id).First();
                Class1.GetContext().ВторникС.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData2();
            }
        }

        private void Button_VTOR2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new midRedV(but.Tag);
        }

        private void Button_SRED1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(Sred.SelectedItem)[0].GetValue(Sred.SelectedItem));
                СредаС poseh = Class1.GetContext().СредаС.Where(p => p.ID_СредаС == id).First();
                Class1.GetContext().СредаС.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData3();
            }
        }

        private void Button_SRED2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new midRedS(but.Tag);
        }

        private void Button_CHET1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(Chet.SelectedItem)[0].GetValue(Chet.SelectedItem));
                ЧетвергС poseh = Class1.GetContext().ЧетвергС.Where(p => p.ID_ЧетвергС == id).First();
                Class1.GetContext().ЧетвергС.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData4();
            }
        }

        private void Button_CHET2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new midRedC(but.Tag);
        }

        private void Button_PYAT1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(pat.SelectedItem)[0].GetValue(pat.SelectedItem));
                ПятницаС poseh = Class1.GetContext().ПятницаС.Where(p => p.ID_ПятницаС == id).First();
                Class1.GetContext().ПятницаС.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData5();
            }
        }

        private void Button_PYAT2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new midRedPyat(but.Tag);
        }

        private void Button_PON3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new midRedPadd();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateData1();
            UpdateData2();
            UpdateData3();
            UpdateData4();
            UpdateData5();
        }

        private void Button_VTOR3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new midRedVadd();
        }

        private void Button_CHET3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new midRedCadd();
        }

        private void Button_PYAT3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new midRedPyatAdd();
        }

        private void Button_SRED3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new midRedSadd();
        }
    }
}
