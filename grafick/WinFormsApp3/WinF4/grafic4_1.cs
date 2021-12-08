using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_4__1____Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int Sum(int n, int a = 0)
        {
            if (n-- == 0) return a;
            return Sum(n, 1 + a + n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text_box1 = textBox1.Text;
            string text_box2 = textBox2.Text;
            try
            {
                int m = int.Parse(text_box1);
                int k = int.Parse(text_box2);

                if (m >= 0 && k >= 0)
                {
                    int result = Sum(m) + Sum(2 * k);

                    textBox3.Text = ("Значение выражения = " + result);
                }
                else
                    textBox3.Text = ("Ошибка! Введите положительное число для m и k.");
            }
            catch (Exception)
            {
                MessageBox.Show("Исключение! Введите натуральное число");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
