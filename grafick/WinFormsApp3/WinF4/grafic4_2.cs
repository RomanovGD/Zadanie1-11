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

namespace Zadanie_4__2____Windows_Form
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            void metod(int n1)
            {
                if (n1 == 1) Console.WriteLine(n1);
                else
                {
                    Console.WriteLine(n1);
                    metod(--n1);
                }
            }

            void Main(string[] args)
            {

                int A;
                A = Convert.ToInt32(a.Text);
                if (A >= 1000)
                {
                    answer.Text = Convert.ToString("Рекурсивный метод");
                    metod(A);
                }
                else answer.Text = Convert.ToString("Число меньше 1000");
                Console.ReadKey();
            }
        }

    }
}
