using Part3_Sample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public class GroupWithValidation : IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {                
                string error = string.Empty;
                switch (columnName) {
                    case "Name":
                        if (string.IsNullOrWhiteSpace(Name)) {
                            error = "Строка не может быть пустой!";
                        } else if (Regex.IsMatch(Name, @"^[А-ЯЁ][а-яё]{2}\-\d{2}$") == false) {
                            error = "Строка содержит недопустимые символы!";
                        }
                        break;
                    case "Year":
                        if (Year < 0) {
                            error = "Год не может быть отрицательным!";
                        }
                        break;
                }
                return error;
            }
        }

        public int GroupId { get; set; }
        public string Name { get; set; }
        /// <summary> Год набора </summary>
        public int Year { get; set; }
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public string Error => null;
    }

    public partial class AddGroupWithDataErrorInfoForm : Window
    {
        public GroupWithValidation Group { get; }
        public AddGroupWithDataErrorInfoForm()
        {
            InitializeComponent();
            Group = new GroupWithValidation();
            cbFaculty.ItemsSource = UniversityModel.Instance.Faculties.ToArray();
            DataContext = Group;
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBoxValidation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added) {
                (e.Source as TextBox).ToolTip = e.Error.ErrorContent.ToString();
            } else if (!((BindingExpressionBase)e.Error.BindingInError).HasError) {
                (e.Source as TextBox).ToolTip = null;
            }
        }
    }
}
