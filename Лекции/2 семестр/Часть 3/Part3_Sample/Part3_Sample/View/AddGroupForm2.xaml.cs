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
    /// Логика взаимодействия для AddGroupForm2.xaml
    /// </summary>
    public partial class AddGroupForm2 : Window
    {
        public Group Group { get; set; }

        public AddGroupForm2()
        {
            InitializeComponent();
            Group = new Group();
            cbFaculty.ItemsSource = UniversityModel.Instance.Faculties.ToArray();
            DataContext = Group;
        }

        /// <summary>
        /// Версия конструктора, используемая для редактирования групп
        /// </summary>
        /// <param name="group">Ссылка на редактируемую группу</param>
        public AddGroupForm2(Group group)
        {
            InitializeComponent();
            Group = group;
            cbFaculty.ItemsSource = UniversityModel.Instance.Faculties.ToArray();
            DataContext = Group;
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            //todo: добавить проверку корректности введенных данных
            this.DialogResult = true;
            Close();
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }
    }
}
