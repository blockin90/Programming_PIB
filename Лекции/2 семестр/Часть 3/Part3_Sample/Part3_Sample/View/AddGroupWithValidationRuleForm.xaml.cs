using Part3_Sample.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
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

    class GroupNameValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = (string)value;
            if (string.IsNullOrWhiteSpace(str)) {
                return new ValidationResult(false, "Строка не может быть пустой!");
            } else if (Regex.IsMatch(str, @"^[А-ЯЁ][а-яё]{2}\-\d{2}$") == false) {
                return new ValidationResult(false, "Строка содержит недопустимые символы!");
            }
            return new ValidationResult(true, null);
        }
    }

    class YearValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string str = (string)value;
            int result = 0;
            if (string.IsNullOrWhiteSpace(str)) {
                return new ValidationResult(false, "Строка не может быть пустой!");
            } else if (int.TryParse(str, out result) == false) {
                return new ValidationResult(false, "Ошибка конвертации, возможно строка содержит недопустимые символы!");
            } else if (result < 0) {
                return new ValidationResult(false, "Год не может быть отрицательным!");
            }
            return new ValidationResult(true, null);
        }
    }

    public partial class AddGroupWithValidationRuleForm : Window
    {
        public Model.Group Group { get; set; }
        public AddGroupWithValidationRuleForm()
        {
            InitializeComponent();
            Group = new Model.Group();
            cbFaculty.ItemsSource = UniversityModel.Instance.Faculties.ToArray();
            DataContext = Group;
        }
        private void SaveClick(object sender, RoutedEventArgs e)
        {
            if (invalidList.Count != 0) {
                MessageBox.Show("Проверьте правильность заполнения полей перед сохранением!");
                return;
            }
            this.DialogResult = true;
            Close();
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }

        private Dictionary<object, ValidationError> invalidList = new Dictionary<object, ValidationError>();

        private void TextBoxValidation_Error(object sender, ValidationErrorEventArgs e)
        {
            if(e.Action == ValidationErrorEventAction.Added) {
                (e.Source as TextBox).ToolTip = e.Error.ErrorContent.ToString();
                invalidList[e.Source] = e.Error;
            } else if(!((BindingExpressionBase)e.Error.BindingInError).HasError) {
                (e.Source as TextBox).ToolTip = null;
                invalidList.Remove(e.Source);
            }
        }
    }
}
