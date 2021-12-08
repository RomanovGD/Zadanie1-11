using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x)
        {
            try
            {
                //если х не попадает в область определения, то генерируется исключение
                if (x == -1) throw new Exception();
                else return Math.Sqrt(x * x + 1) - Math.Sqrt(x * x + 5);
            }
            catch
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text_box1 = textBox1.Text;
            string text_box2 = textBox2.Text;
            string text_box3 = textBox3.Text;


            try
            {
                double a = double.Parse(text_box1);
                double b = double.Parse(text_box2);
                double h = double.Parse(text_box3);

                for (double i = a; i <= b; i += h)
                    try
                    {
                        textBox4.Text += ($"y({i})={f(i)}").ToString() + "\r\n";
                    }
                    catch
                    {
                        textBox4.Text += ($"y({i})=error").ToString() + "\r\n";
                    }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат ввода данных");
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ScrollBars = ScrollBars.Vertical;
        }
    }

}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
