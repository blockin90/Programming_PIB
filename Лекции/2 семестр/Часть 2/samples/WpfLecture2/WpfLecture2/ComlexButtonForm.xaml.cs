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

namespace WpfLecture2
{
    /// <summary>
    /// Логика взаимодействия для ComlexButtonForm.xaml
    /// </summary>
    public partial class ComplexButtonForm : Window
    {
        public ComplexButtonForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Я кнопка!");
        }
    }
}
