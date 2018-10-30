using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp1
{
  public class Grades
  {
    public String ID { get; set; }
    public String Assignment { get; set; }
    public String Grade { get; set; } //??

  }

  public static class GradesService
  {
    public static List<Grades> GradeFile(string fileLocation)
    {
      var lines = File.ReadAllLines(fileLocation);

      var data = from l in lines.Skip(1)
                 let split = l.Split(',')
                 select new Grades
                 {
                   ID = split[0],
                  Assignment = split[1],
                  Grade = split[2]
                 };

      return data.ToList();
    }
  }
}
