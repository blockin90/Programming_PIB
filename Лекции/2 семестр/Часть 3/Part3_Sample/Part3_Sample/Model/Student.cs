using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_Sample.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double AvgRate { get; set; }
        public string ImagePath { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public string FIO
        {
            get { return LastName + " " + FirstName; }
        }
    }
}
