using EF_Core_Lecture.Model;

namespace EF_Core_Lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDbContext context = new MyDbContext();

            context.Students.Add(new Student()  //добавление нового студента
            {
                FirstName = "Иван",
                LastName = "Иванов",
            });
            context.SaveChanges();

            var students = context.Students.ToArray();
            //вывод всех студентов на консоль:
            foreach (var s in students) {
                Console.WriteLine($"Имя: {s.FirstName}, фамилия: {s.LastName}");
            }


        }
    }
}
