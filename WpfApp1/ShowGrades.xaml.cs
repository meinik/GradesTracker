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

namespace GradesTrackerApp
{
  /// <summary>
  /// Interaction logic for ShowGrades.xaml
  /// </summary>
  public partial class ShowGrades : Window
  {
    public ShowGrades()
    {
      InitializeComponent();
      DataContext = GradesService.GradeFile(@"C:\Users\meinik\Documents\scores.txt");
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
