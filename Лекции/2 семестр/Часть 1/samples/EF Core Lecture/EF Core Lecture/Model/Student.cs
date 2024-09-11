using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EF_Core_Lecture.Model
{
    public class Student
    {
        public int Id { get; set; }
        //другие поля
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
