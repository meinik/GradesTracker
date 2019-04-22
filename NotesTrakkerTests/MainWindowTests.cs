using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradesTrackerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesTrackerApp.Tests
{
  [TestClass()]
  public class MainWindowtest
    {
      [TestMethod()]
      public void MainWinTest()
      {
        MainWindow newWin = new MainWindow();
        Assert.IsNotNull(newWin);
      }

      [TestMethod()]
      public void MainWinListTest()
      {
        List<Student> st = StudentService.ReadFile(@"C:\Users\meinik\Documents\students.txt");

        Assert.IsNotNull(st);
      }
    }
  }



