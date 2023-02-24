using Part3_Sample.Model;
using Part3_Sample.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Part3_Sample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GroupsClick(object sender, RoutedEventArgs e)
        {
            GroupsForm form = new GroupsForm();
            form.ShowDialog();
        }

        private void StudentsClick(object sender, RoutedEventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.ShowDialog();
        }
    }
}
