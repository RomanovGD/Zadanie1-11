using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(textBox1x.Text), y1 = double.Parse(textBox1y.Text);
                double x2 = double.Parse(textBox2x.Text), y2 = double.Parse(textBox2y.Text);
                double x3 = double.Parse(textBox3x.Text), y3 = double.Parse(textBox3y.Text);
                
                double a = 0, b = 0, c = 0, minimal = 0;
                
                a = func(x1, y1, x2, y2);
                b = func(x2, y2, x3, y3);
                c = func(x1, y1, x3, y3);
                if (min(a, b) == a)
                    minimal = a;
                else
                    minimal = b;
                if (minimal > min(b, c))
                    minimal = c;
                if (minimal == a)
                    result.Text=("Минимальное расстояние между точками (x1,y1) и (x2,y2)");
                if (minimal == b)
                    result.Text = ("Минимальное расстояние между точками (x2,y2) и (x3,y3)");
                if (minimal == c)
                    result.Text = ("Минимальное расстояние между точками (x1,y1) и (x3,y3)");
            }
            catch
            {
                result.Text = "invalid input";
            }
        }
        static double func(double x1, double y1, double x2, double y2)
        {
            double answer = 0;
            answer = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            return answer;
        }
        static double min(double a, double b)
        {
            if (a <= b)
                return a;
            else
                return b;
        }
    }
}
