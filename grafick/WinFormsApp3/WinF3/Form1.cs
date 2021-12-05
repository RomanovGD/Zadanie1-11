using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinF3
{
    public partial class Form1 : Form
    {
        public Label outDat;
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

                StringBuilder sb = new StringBuilder();

                for (double i = a; i <= b; i += h)
                { 
                    sb.Append($"\nf(0:f2)=1:f4, {i}, {f(i)}");
                }

                outDat.Text = sb.ToString();
                outDat.Height = panel1.Height;

            }
            catch
            {
                outDat.Text = "invavlid inpout";
            }
        }
        static double f(double x)
        {
            double y;
            if (x < 3) y = x * x - 0.3;
            else if (x <= 5) y = 0;
            else y = x * x + 1;
            return y;
        }
    }
}
