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

namespace WpfLecture2
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
        private void ComlexButtonForm_Click(object sender, RoutedEventArgs e)
        {
            ComplexButtonForm form = new ComplexButtonForm();
            form.ShowDialog();
        }

        private void TransformForm_Click(object sender, RoutedEventArgs e)
        {
            TransformForm form = new TransformForm();
            form.ShowDialog();
        }

        private void CustomForm_Click(object sender, RoutedEventArgs e)
        {
            CustomForm form= new CustomForm();
            form.Show();
        }
    }
}
