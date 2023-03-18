using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
    }
    class Discipline
    {
        public int DisciplineId { get; set; }
        public string DisciplineName { get; set; }
    }
    class Exam
    {
        public Student Student { get; set; }
        public Discipline Discipline { get; set; }
        public int Grade { get; set; }
    }

}
