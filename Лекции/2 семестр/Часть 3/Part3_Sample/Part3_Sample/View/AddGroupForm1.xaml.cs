using Part3_Sample.Model;
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

namespace Part3_Sample.View
{
    /// <summary>
    /// Логика взаимодействия для AddGroup1.xaml
    /// </summary>
    public partial class AddGroupForm1 : Window
    {
        public Group Group { get; set; }
        public AddGroupForm1()
        {
            InitializeComponent();
            Group= new Group();
            cbFaculty.ItemsSource = UniversityModel.Instance.Faculties.ToArray();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            //todo: добавить проверку корректности введенных данных
            Group.Name = tbGroupName.Text;
            Group.Year = Int32.Parse(tbYear.Text);
            Group.Faculty = cbFaculty.SelectedItem as Faculty;

            this.DialogResult = true;
            Close();
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult= false;
            Close();
        }
    }
}
