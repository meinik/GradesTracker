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
  public class ShowGradesTests
  {
    [TestMethod()]
    public void ShowGradesTest()
    {
      ShowGrades grades = new ShowGrades();
      Assert.IsNotNull(grades);
     }
  }

}

