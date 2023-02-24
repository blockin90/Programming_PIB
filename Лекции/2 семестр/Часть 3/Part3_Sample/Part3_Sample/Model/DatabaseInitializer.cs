using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_Sample.Model
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<UniversityModel>
    {
        protected override void Seed(UniversityModel db)
        {
            var faculties = new Faculty[]
            {
                new Faculty(){ FacultyName = "Экономики и управления" },
                new Faculty(){ FacultyName = "Юридический" },
                new Faculty(){ FacultyName = "Торгово-технологический" },
            };
            var groups = new Group[]
            {
                new Group(){ Name = "Иб-51", Faculty = faculties[0], Year = 2020},
                new Group(){ Name = "Пиб-51", Faculty = faculties[0], Year = 2020},
                new Group(){ Name = "Иф-51", Faculty = faculties[0], Year = 2020}
            };
            var countries = new Country[]
            {
                new Country(){ Name = "Россий"},
                new Country(){ Name = "Казахстан"},
                new Country(){ Name = "Китай"},
                new Country(){ Name = "Мадагаскар"}
            };
            var students = new Student[]
            {
                new Student(){ FirstName = "Сидор", LastName = "Петров", Age = 20, AvgRate = 3.5, Group = groups[0], Country = countries[0]},
                new Student(){ FirstName = "Алексей", LastName = "Петриков", Age = 19, AvgRate = 3.25, Group = groups[0], Country = countries[0]},
                new Student(){ FirstName = "Петр", LastName = "Петрикян", Age = 21, AvgRate = 4.23, Group = groups[0], Country = countries[0]},
                new Student(){ FirstName = "Никитос", LastName = "Сережников", Age = 20, AvgRate = 3.5, Group = groups[1], Country = countries[1]},
                new Student(){ FirstName = "Жекос", LastName = "Иванов", Age = 21, AvgRate = 4.15, Group = groups[1], Country = countries[2]},
                new Student(){ FirstName = "Сергей", LastName = "Сергеев", Age = 22, AvgRate = 4.85, Group = groups[1], Country = countries[3]},
                new Student(){ FirstName = "Петр", LastName = "Сидоров", Age = 18, AvgRate = 3.0, Group = groups[1], Country = countries[2]},
                new Student(){ FirstName = "Кирилл", LastName = "Николаевич", Age = 18, AvgRate = 5.0, Group = groups[2], Country = countries[0]},
            };
            db.Faculties.AddRange(faculties);
            db.Countries.AddRange(countries);
            db.Groups.AddRange(groups);
            db.Students.AddRange(students);            

            db.SaveChanges();
        }
    }
}
