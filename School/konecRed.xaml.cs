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
    /// Логика взаимодействия для konecRed.xaml
    /// </summary>
    public partial class konecRed : Page
    {
        public konecRed()
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

        private void Button_PON1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(Poned.SelectedItem)[0].GetValue(Poned.SelectedItem));
                ПонедельникСТ poseh = Class1.GetContext().ПонедельникСТ.Where(p => p.ID_ПонедельниикСТ == id).First();
                Class1.GetContext().ПонедельникСТ.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData1();
            }
        }

        private void Button_PON2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new konecRedP(but.Tag);
        }

        private void Button_VTOR1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(VTOR.SelectedItem)[0].GetValue(VTOR.SelectedItem));
                ВторникСТ poseh = Class1.GetContext().ВторникСТ.Where(p => p.ID_ВторникСТ == id).First();
                Class1.GetContext().ВторникСТ.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData2();
            }
        }

        private void Button_VTOR2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new konecRedV(but.Tag);
        }

        private void Button_SRED1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(Sred.SelectedItem)[0].GetValue(Sred.SelectedItem));
                СредаСТ poseh = Class1.GetContext().СредаСТ.Where(p => p.ID_СредаСТ == id).First();
                Class1.GetContext().СредаСТ.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData3();
            }
        }

        private void Button_SRED2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new konecRedS(but.Tag);
        }

        private void Button_CHET1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(Chet.SelectedItem)[0].GetValue(Chet.SelectedItem));
                ЧетвергСТ poseh = Class1.GetContext().ЧетвергСТ.Where(p => p.ID_Четверг == id).First();
                Class1.GetContext().ЧетвергСТ.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData4();
            }
        }

        private void Button_CHET2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new konecRedC(but.Tag);
        }

        private void Button_PYAT1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(pat.SelectedItem)[0].GetValue(pat.SelectedItem));
                ПятницаСТ poseh = Class1.GetContext().ПятницаСТ.Where(p => p.ID_ПятницаСТ == id).First();
                Class1.GetContext().ПятницаСТ.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData5();
            }
        }

        private void Button_PYAT2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new konecRedPyat(but.Tag);
        }

        private void Button_PON3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new konecRedPadd();
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
            SredKlas.Content = new konecRedVadd();
        }

        private void Button_CHET3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new konecRedCadd();
        }

        private void Button_PYAT3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new konecRedPyatAdd();
        }

        private void Button_SRED3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new konecRedSadd();
        }
    }
}

