using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Логика взаимодействия для ListForm.xaml
    /// </summary>
    public partial class ListForm : Window
    {
        public ListForm()
        {
            InitializeComponent();
            var students = new List<Student>()
            {
                new Student()
                {
                    FirstName = "Test",
                    LastName= "Test",
                    Age = 20
                },
                new Student()
                {
                    FirstName = "Test 2",
                    LastName= "Test 2" ,
                    Age = 21
                },
                new Student()
                {
                    FirstName = "Test 3",
                    LastName= "Test 3",
                    Age = 20
                },
            };

            cbStudents.ItemsSource= students;
            lbStudents.ItemsSource = students;
            dgStudents.ItemsSource = students;
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public int Age { get; set; }
    }
}
