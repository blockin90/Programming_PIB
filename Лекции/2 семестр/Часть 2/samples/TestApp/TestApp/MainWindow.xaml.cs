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

namespace TestApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Меня нажали!");
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanelForm form = new StackPanelForm();
                form.ShowDialog();  
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            GridForm form   = new GridForm();
            form.ShowDialog();
        }

        private void UniformGrid_Click(object sender, RoutedEventArgs e)
        {
            UniformGridForm form= new UniformGridForm();
            form.ShowDialog();
        }

        private void DockPanel_Click(object sender, RoutedEventArgs e)
        {
            DockPanelForm form = new DockPanelForm();
                
            form.ShowDialog();
        }

        private void ListForms_Click(object sender, RoutedEventArgs e)
        {
            ListForm form = new ListForm();
            form.ShowDialog();
        }

        private void Binding_Click(object sender, RoutedEventArgs e)
        {
            BindingSample bindingSample = new BindingSample();
            bindingSample.ShowDialog();
        }
    }
}
