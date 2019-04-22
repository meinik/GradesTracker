using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GradesTrackerApp;

namespace GradesTrackerApp
{

  public class Student
  {
    public String ID { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String Birthday { get; set; }
    public String Gender { get; set; }
    public String Special { get; set; }
  }
  public static class StudentService
  {
    public static List<Student> ReadFile(string filepath)
    {
      var lines = File.ReadAllLines(filepath);

      var data = from l in lines.Skip(1)
                 let split = l.Split(',')
                 select new Student
                 {
                   ID = split[0],
                   FirstName = split[1],
                   LastName = split[2],
                   Birthday = split[3],
                   Gender = split[4],
                   Special = split[5]
                 };

      return data.ToList();
    }
  }

}

