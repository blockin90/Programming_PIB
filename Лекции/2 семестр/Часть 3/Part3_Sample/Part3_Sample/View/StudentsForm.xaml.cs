using Part3_Sample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Part3_Sample.View
{
    /// <summary>
    /// Логика взаимодействия для Students.xaml
    /// </summary>
    public partial class StudentsForm : Window
    {
        public StudentsForm()
        {
            InitializeComponent();
            var groups = UniversityModel.Instance.Groups.ToArray();
            cmbGroups.ItemsSource = groups;
            cmbGroups.SelectedIndex = 0;


        }
    }
}
