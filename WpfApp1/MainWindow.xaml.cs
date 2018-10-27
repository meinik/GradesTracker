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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

    public MainWindow()
        {
            InitializeComponent();
    }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void NewStudent_Click(object sender, RoutedEventArgs e)
        {
        Window1 win1 = new Window1();
        this.Visibility = Visibility.Hidden; 
        win1.Show();
        this.Close();
      
      
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
        this.Close();
        }
    //var desiredText = File.ReadLines("C:\myfile.txt").ElementAt(1);  para leer la 2da linea
  }


}
