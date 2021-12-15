using System;
using System.IO;
using System.Windows.Forms;

namespace pr9WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
			try
			{
				richTextBox2.Text = "";
				string path = Environment.CurrentDirectory + @"\Text2WF.txt";
				string[] str = File.ReadAllLines(path);
				for (int i = 0; i < str.Length; i++)
				{
					if (str[i].Length % 2 == 0)
					{
						richTextBox2.Text += $"{i + 1}: {str[i]}\n";
					}
				}
			}
			catch
			{
				richTextBox2.Text = "";
				MessageBox.Show("Произошла ошибка");
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form1 form1 = new Form1();
			form1.Show();
		}
    }
}
