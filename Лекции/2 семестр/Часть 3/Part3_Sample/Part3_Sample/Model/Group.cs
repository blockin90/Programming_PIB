using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_Sample.Model
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        /// <summary> Год набора </summary>
        public int Year { get; set; }
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
