using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr7_1WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text = "";
                StringBuilder a = new StringBuilder();
                a.Append(richTextBox1.Text);
                int[] z = new int[2];
                for (int i = 0, j = 0; i < a.Length; i++)
                    if (a[i] == ',')
                    {
                        z[j] = i;
                        j++;
                    }
                int l = z[1] - z[0] - 1;
                for (int i = 0; i < a.Length; ++i)
                    if (i == z[0])
                    {
                        a.Remove(i + 1, l);
                    }
                richTextBox2.Text = $"{a}";
            }
            catch (Exception)
            {
                richTextBox2.Text = "";
                Console.WriteLine("\n\tЧто-то не так");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
