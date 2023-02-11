using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp1
{
    public class UniverDataModel : DbContext
    {
        public UniverDataModel()
            : base("name=UniverDataModel")
        {

        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public Group() { Students = new List<Student>(); }
    }


}