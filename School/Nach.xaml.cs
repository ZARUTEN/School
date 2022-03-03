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
using Word = Microsoft.Office.Interop.Word;

namespace School
{
    /// <summary>
    /// Логика взаимодействия для Nach.xaml
    /// </summary>
    public partial class Nach : Page
    {
        public Nach()
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
            this.NavigationService.Navigate(new Uri("/NachRed.xaml", UriKind.Relative));
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/NachINFO.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Word documents (*.docx) |*.docx";
            if (saveFile.ShowDialog() == true)
            {
                object oMiss = System.Reflection.Missing.Value;
                Word.Application wordapp = new Word.Application();
                wordapp.Visible = true;
                Word.Document doc = wordapp.Documents.Add(ref oMiss, ref oMiss, ref oMiss, ref oMiss);
                Word.Paragraph pargar = doc.Content.Paragraphs.Add(ref oMiss);
                pargar.Range.Text = "Расписание начального класса";
                pargar.Range.Font.Color = Word.WdColor.wdColorBlack;
                pargar.Range.Font.Bold = 1;
                pargar.Range.Font.Size = 14f;
                pargar.Range.Font.Name = "Arial";
                pargar.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                pargar.Range.InsertParagraphAfter();
                Word.Paragraph table_par = doc.Content.Paragraphs.Add(ref oMiss);
                Word.Table table = doc.Content.Tables.Add(table_par.Range, Class1.GetContext().ПонедельникН.Count() + 1, 3, ref oMiss, ref oMiss);
                table.Range.Font.Size = 10f;
                table.Range.Font.Bold = 0;
                table.Rows[1].Range.Font.Bold = 1;
                table.Cell(1, 1).Range.Text = "Кабинет";
                table.Cell(1, 2).Range.Text = "Предмет";
                table.Cell(1, 3).Range.Text = "Учитель";
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                for (int i = 0; i < Class1.GetContext().ПонедельникН.Count(); i++)
                {
                    for (int j = 1; j <= table.Columns.Count; j++)
                    {
                        switch (j)
                        {
                            case 1:
                                table.Cell(i + 2, j).Range.Text = Class1.GetContext().ПонедельникН.ToList()[i].Кабинет.ToString();
                                break;
                            case 2:
                                table.Cell(i + 2, j).Range.Text = Class1.GetContext().ПонедельникН.ToList()[i].Предмет;
                                break;
                            case 3:
                                table.Cell(i + 2, j).Range.Text = Class1.GetContext().ПонедельникН.ToList()[i].Учитель;
                                break;
                        }
                    }

                }                      
                doc.SaveAs2(saveFile.FileName, ref oMiss, ref oMiss, ref oMiss, ref oMiss, ref oMiss,
                ref oMiss, ref oMiss, ref oMiss, ref oMiss, ref oMiss,
                ref oMiss, ref oMiss, ref oMiss, ref oMiss, ref oMiss);
            }                
        }
    }
}



