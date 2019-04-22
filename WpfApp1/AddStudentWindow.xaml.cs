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
using System.Windows.Shapes;
using System.IO;

namespace GradesTrackerApp
{
  /// <summary>
  /// Interaction logic for Window1.xaml
  /// </summary>
  public partial class Window1 : Window
  {
    List<Student> st;
     private string Path { set; get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    public Window1()
    {
      InitializeComponent();
      st = StudentService.ReadFile(@"C:\Users\meinik\Documents\students.txt");
    }
   

    private void AddButton_Click(object sender, RoutedEventArgs e) 
    { 
      using (StreamWriter writer = new StreamWriter(System.IO.Path.Combine(Path, "students.txt"), true))
      {
        writer.WriteLine(StudentIDTxtBx.Text 
          + "," + FirstNameTxtBx.Text 
          + "," + LastNameTxtBx.Text 
          + "," + Date + "," + Gender 
          + "," + SpecialAcc );

        //closes the window and re-opens the previous one
       

        writer.Close();
        MainWindow mainWin = new MainWindow();
        MessageBox.Show("Saved! Press \"Load\" to see changes");
      }
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
      MainWindow mainWin = new MainWindow();
      this.Close();
      mainWin.Show();
    }
    private void load_Click(object sender, RoutedEventArgs e)
    {

      st = StudentService.ReadFile(@"C:\Users\meinik\Documents\students.txt");
      DataGrid1.ItemsSource = st;
    }

    private void CheckBox_Checked(object sender, RoutedEventArgs e)
    {
    }

    string Date { set; get; }
    private void DatePicker_SelectedDateChanged(object sender,
       SelectionChangedEventArgs e)
    {
      // ... Get DatePicker reference.
      var picker = sender as DatePicker;

      // ... Get nullable DateTime from SelectedDate.
      DateTime? date = picker.SelectedDate;
      if (date == null)
      {
        // ... A null object.
        this.Date = "No date";
      }
      else
      {
        // ... No need to display the time.
        this.Date = date.Value.ToShortDateString();
      }

      Console.WriteLine(this.Date);
    }

    private void StudentIDTxtBx_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private string Gender { get; set; }
    private string SpecialAcc { get; set; }

    private void StackPanel_Checked(object sender, RoutedEventArgs e)
    {
      var activeRadio = e.OriginalSource as RadioButton;
      Gender = activeRadio.Content.ToString();

    }

    private void StackPanel_Unchecked(object sender, RoutedEventArgs e)
    {

    }

    private void SpecialAccomodations_Checked(object sender, RoutedEventArgs e)
    {
      SpecialAcc = "yes";
    }

    private void SpecialAccomodations_Unchecked(object sender, RoutedEventArgs e)
    {
      SpecialAcc = "no";
    }

  }
}

