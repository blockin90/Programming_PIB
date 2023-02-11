using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniverDataModel model = new UniverDataModel();

            var students = model.Students.ToArray();
            foreach (var student in students) {
                Console.WriteLine($"Имя: {student.FirstName}, фамилия: {student.LastName} учится в {student.Group.Name}");
            }

            //model.Students.Add(new Student()
            //{
            //    FirstName = "Иван",
            //    LastName = "Иванов",
            //    BirthDate = new DateTime(2000, 10, 10)
            //});
            //model.SaveChanges();
            model.Dispose();
        }
    }
    
}
