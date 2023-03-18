using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ContextCafe cafeContext = new ContextCafe();
            if (cafeContext.Cofes.Any() == false) {//бд пустая

                var milk = new Dobavki()
                {
                    DobavkiName = "молоко",
                    DobavkiPrice = 9
                };

                var shugar = new Dobavki()
                {
                    DobavkiName = "сахар",
                    DobavkiPrice = 2

                };
                Cofe cofe = new Cofe();
                cofe.CofeName = "Amerikano";
                cofe.Dobavkis.Add(milk);
                cofe.Dobavkis.Add(shugar);

                cafeContext.Cofes.Add(cofe);
                cafeContext.SaveChanges();

                Cofe cofe2 = new Cofe();

                cofe2.CofeName = "Latte";
                cofe2.Dobavkis.Add(milk);


                cafeContext.Cofes.Add(cofe2);
                cafeContext.SaveChanges();
            }

            var data = cafeContext.Cofes.ToArray();
            CofeDataGrid.ItemsSource = data;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void filterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ContextCafe cafeContext = new ContextCafe();

            var filterValue = filterTextBox.Text;
            if( String.IsNullOrWhiteSpace( filterValue)) {
                CofeDataGrid.ItemsSource = cafeContext.Cofes.ToArray();
            } else {
                CofeDataGrid.ItemsSource = cafeContext.Cofes
                    .Where(cofe => cofe.CofeName.Contains(filterValue))
                    .ToArray();
            }
        }
    }
}
