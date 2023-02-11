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
    /// Логика взаимодействия для BindingSample.xaml
    /// </summary>
    public partial class BindingSample : Window
    {
        public BindingSample()
        {
            InitializeComponent();
            var student = new Student2()
            {
                FirstName = "Вася",
                LastName = "Иванов",
                BirthDay = new DateTime(2010, 10, 10),
                Papers = new List<string>
                {
                    "Исследование влияния программирования на психику людей",
                    "Очен важное исследование",
                }

            };

            DataContext= student;
        }
    }
}
