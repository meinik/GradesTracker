using System;
using System.Collections.Generic;
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
using Microsoft.Win32;
using System.Data;

namespace GradesTrackerApp
{

    public partial class MainWindow : Window
    {
    String GradesFile { get; set; }
    

  
        public MainWindow()
        {
         InitializeComponent();

        List<Student>  st = StudentService.ReadFile(@"C:\Users\meinik\Documents\students.txt");
      
        DataContext = st;
        Dropdown.ItemsSource = st;
        Dropdown.DisplayMemberPath = "ID";
        Dropdown.SelectedValuePath = "ID";
                     
        }

    private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
        private void NewStudent_Click(object sender, RoutedEventArgs e)
        {
        Window1 win1 = new Window1();
        win1.Show();
        this.Close();      
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
        this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }


    private void Save_Click(object sender, RoutedEventArgs e)
    {
      using (StreamWriter writer = new StreamWriter(@"C:\Users\meinik\Documents\scores.txt", true))
      {
        writer.WriteLine(Dropdown.Text + "," + AssignmentTxtBx.Text + "," + ScoreTxtBx.Text );
        MessageBox.Show("Saved!");
      }
    }

    private void ViewGrades_Click(object sender, RoutedEventArgs e)
    {
      ShowGrades gradeWin = new ShowGrades();
      gradeWin.Show();
    }
  }


}
