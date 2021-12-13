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
    public partial class Form2 : Form
    {
        public Form2()
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

                for (int i = 0; i < a.Length;)
                    if (char.IsPunctuation(a[i]))
                    {
                        a.Remove(i, 1);
                    }
                    else ++i;

                string str = a.ToString();
                string str2 = str.ToLower();
                string[] s = str2.Split(' ');

                var ordered = s.OrderBy(item => item);

                richTextBox2.Text = $"{string.Join("\n", ordered)}";

            }
            catch (Exception)
            {
                richTextBox2.Text = "";
                Console.WriteLine("\n\tЧто-то не так");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
