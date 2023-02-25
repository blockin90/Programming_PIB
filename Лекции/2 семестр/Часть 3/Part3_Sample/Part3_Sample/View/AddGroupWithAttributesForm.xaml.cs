using Part3_Sample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace Part3_Sample.View
{
    /// <summary>
    /// Логика взаимодействия для AddGroupWithAttributesForm.xaml
    /// </summary>
    public partial class AddGroupWithAttributesForm : Window
    {
        public Group Group { get; set; }

        public AddGroupWithAttributesForm()
        {
            InitializeComponent();
            Group = new Group();
            cbFaculty.ItemsSource = UniversityModel.Instance.Faculties.ToArray();
            DataContext = Group;
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            ValidationContext context = new ValidationContext(Group);
            
            var validationResults = new List<ValidationResult>();
            if (Validator.TryValidateObject(Group, context, validationResults,true)) {
                this.DialogResult = true;
                Close();
            } else {
                string error = string.Empty;
                foreach(var result in validationResults) {
                    error += result.ErrorMessage + "\r\n";
                }
                MessageBox.Show(error);
            }
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }
    }
}
