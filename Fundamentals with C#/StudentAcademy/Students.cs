using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcademy
{
    public class Students
    {
        public Students(string name)
        {
            Name = name;
            Grades = new List<double>();
        }

        public string Name { get; private set; }
        public List<double> Grades { get; private set; }

        public override string ToString()
        {
            double averageGrade = Grades.Count > 0 ? Grades.Average() : 0.0;
            return $"{Name} -> {averageGrade:f2}";
        }
    }
}
