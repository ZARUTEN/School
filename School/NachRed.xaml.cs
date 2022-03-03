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
    /// Логика взаимодействия для NachRed.xaml
    /// </summary>
    public partial class NachRed : Page
    {
        public NachRed()
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
            var massive = from ПонедельникН in Class1.GetContext().ПонедельникН
                          select new
                          {
                              ID_Понедельниик = ПонедельникН.ID_Понедельниик,
                              Кабинет = ПонедельникН.Кабинет,
                              Предмет = ПонедельникН.Предмет,
                              Учитель = ПонедельникН.Учитель,
                          };
            Poned.ItemsSource = massive.ToList();
        }
        public void UpdateData2()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ВторникН in Class1.GetContext().ВторникН
                          select new
                          {
                              ID_Вторник = ВторникН.ID_Вторник,
                              Кабинет = ВторникН.Кабинет,
                              Предмет = ВторникН.Предмет,
                              Учитель = ВторникН.Учитель,
                          };
            VTOR.ItemsSource = massive.ToList();
        }
        public void UpdateData3()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from СредаН in Class1.GetContext().СредаН
                          select new
                          {
                              ID_Среда = СредаН.ID_Среда,
                              Кабинет = СредаН.Кабинет,
                              Предмет = СредаН.Предмет,
                              Учитель = СредаН.Учитель,
                          };
            Sred.ItemsSource = massive.ToList();
        }
        public void UpdateData4()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ЧетвергН in Class1.GetContext().ЧетвергН
                          select new
                          {
                              ID_ЧетвергН = ЧетвергН.ID_ЧетвергН,
                              Кабинет = ЧетвергН.Кабинет,
                              Предмет = ЧетвергН.Предмет,
                              Учитель = ЧетвергН.Учитель,
                          };
            Chet.ItemsSource = massive.ToList();
        }
        public void UpdateData5()
        {
            Class1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var massive = from ПятницаН in Class1.GetContext().ПятницаН
                          select new
                          {
                              ID_Пятница = ПятницаН.ID_Пятница,
                              Кабинет = ПятницаН.Кабинет,
                              Предмет = ПятницаН.Предмет,
                              Учитель = ПятницаН.Учитель,
                          };
            pat.ItemsSource = massive.ToList();
        }

        private void Button_PON1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(Poned.SelectedItem)[0].GetValue(Poned.SelectedItem));
                ПонедельникН poseh = Class1.GetContext().ПонедельникН.Where(p => p.ID_Понедельниик == id).First();
                Class1.GetContext().ПонедельникН.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData1();
            }
        }

        private void Button_PON2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new NachRedP(but.Tag);
        }

        private void Button_VTOR1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(VTOR.SelectedItem)[0].GetValue(VTOR.SelectedItem));
                ВторникН poseh = Class1.GetContext().ВторникН.Where(p => p.ID_Вторник == id).First();
                Class1.GetContext().ВторникН.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData2();
            }
        }

        private void Button_VTOR2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new NachRedV(but.Tag);
        }

        private void Button_SRED1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(Sred.SelectedItem)[0].GetValue(Sred.SelectedItem));
                СредаН poseh = Class1.GetContext().СредаН.Where(p => p.ID_Среда == id).First();
                Class1.GetContext().СредаН.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData3();
            }
        }

        private void Button_SRED2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new NachRedS(but.Tag);
        }

        private void Button_CHET1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(Chet.SelectedItem)[0].GetValue(Chet.SelectedItem));
                ЧетвергН poseh = Class1.GetContext().ЧетвергН.Where(p => p.ID_ЧетвергН == id).First();
                Class1.GetContext().ЧетвергН.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData4();
            }
        }

        private void Button_CHET2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new NachRedС(but.Tag);
        }

        private void Button_PYAT1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(pat.SelectedItem)[0].GetValue(pat.SelectedItem));
                ПятницаН poseh = Class1.GetContext().ПятницаН.Where(p => p.ID_Пятница == id).First();
                Class1.GetContext().ПятницаН.Remove(poseh);
                Class1.GetContext().SaveChanges();
                UpdateData5();
            }
        }

        private void Button_PYAT2(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            SredKlas.Content = new NachRedPyat(but.Tag);
        }

        private void Button_PON3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new NachRedPadd();
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
            SredKlas.Content = new NachRedVadd();
        }

        private void Button_CHET3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new NachRedCadd();
        }

        private void Button_PYAT3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new NachRedPyatAdd();
        }

        private void Button_SRED3(object sender, RoutedEventArgs e)
        {
            SredKlas.Content = new NachRedSadd();
        }
    }
}
