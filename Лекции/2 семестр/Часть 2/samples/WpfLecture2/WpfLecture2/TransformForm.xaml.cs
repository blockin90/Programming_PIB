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
    /// Логика взаимодействия для TransformForm.xaml
    /// </summary>
    public partial class TransformForm : Window
    {
        static Random random = new Random();
        public static double BlurEffectRadius 
        {
            get
            {
                return 2.0 +3.0* random.NextDouble();
            }
        }
        public static double ScaleValue 
        {
            get
            {
                return 0.5 + 1.5* random.NextDouble();
            }
        }
        public static double AngleValue 
        {
            get
            {
                return -20 + 65 * random.NextDouble();
            }
        }
        public static double TranslateValue
        {
            get
            {
                return 2.5 + 3 * random.NextDouble();
            }
        }

        public TransformForm()
        {
            InitializeComponent();
            symbols = Enumerable.Range(0,25).Select( num => (char)('A' + num) ).Concat(
                    Enumerable.Range(0, 25).Select(num => (char)('a' + num))).Concat(
                    Enumerable.Range(0, 9).Select(num => (char)('0' + num))
                )                
                .ToArray();
        }
        char [] symbols;
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            captcha.ItemsSource = Enumerable.Range(0, 6).Select( num => symbols[random.Next(symbols.Length)]);
        }
    }
}
