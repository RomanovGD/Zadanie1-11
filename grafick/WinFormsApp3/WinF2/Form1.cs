using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinF2
{
    public partial class Form1 : Form
    {
        public Label outDat;
        Task answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outDat = new Label();
            panel1.Controls.Add(outDat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double h = double.Parse(textBoxC.Text);

                answer = new Task(a, b, h,outDat);
                answer.Tasker();
                outDat.Height=panel1.Height;
            }
            catch
            {
                outDat.Text = "invavlid inpout";
            }
        }
        class Task
        {
            public double a;
            public double b;
            public double h;
            private double y;
            private object _obj;
            public Task(double x, double y, double n,object obj)
            {
                a = x; b = y; h = n;
                _obj = obj;
            }
            public void Tasker() //Функция метода
            {
                ((Label)_obj).Text = String.Empty;
                StringBuilder sb = new StringBuilder();

                for (double x = a; x <= b; x += h)
                {
                    if (x < 3)
                    {
                        sb.Append($"\n{x*x-0.3}");
                    }
                    else if (x <= 5)
                    {
                        sb.Append("\n0");
                    }
                    else
                    {
                        sb.Append($"\n{x*x + 1}");
                    }
                }
                ((Label)_obj).Text = sb.ToString();
            }
        }
    }
}
