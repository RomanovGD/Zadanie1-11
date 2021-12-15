using System;
using System.IO;
using System.Windows.Forms;

namespace pr9WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                try
                {
					richTextBox2.Text = "";
					string a;
					int j = 0;

					FileStream f = new FileStream("Bin1WF.bin", FileMode.OpenOrCreate);
					BinaryWriter fOut = new BinaryWriter(f);

					a = richTextBox1.Text;
					string[] str = a.Split(' ');

					for (int i = 0; i < str.Length; i++)
					{
						fOut.Write(str[i]);

					}

					fOut.Close();
					f = new FileStream("Bin1WF.bin", FileMode.Open);
					BinaryReader fIn = new BinaryReader(f);

					for (long i = 0; i < str.Length; i++)
					{
						a = fIn.ReadString();
						a = a.ToString();
						char[] cha = a.ToCharArray();
						for (int k = 0; k < cha.Length; k++)
						{
							cha[k] = Char.ToLower(cha[k]);
						}
						if (cha[0] == cha[cha.Length - 1])
						{
							j++;
							richTextBox2.Text += $"{a}\n";
						}
					}
					if (j == 0)
					{
						richTextBox2.Text = "";
						MessageBox.Show("Таких слов нет");
					}
					Console.WriteLine();
					fIn.Close();
					f.Close();
				}
                catch
                {
					richTextBox2.Text = "";
                    MessageBox.Show("Произошла ошибка");
                }
            }
            else
            {
                MessageBox.Show("Слова не введены");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form2 form2 = new Form2();
			form2.Show();
        }
    }
}
