using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradesTrakkerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesTrakkerApp.Tests
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

