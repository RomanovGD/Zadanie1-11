using System;
using System.IO;

namespace pr9_1
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				string a;
				int j = 0;
				Console.Write("Введите количество слов: ");
				int n = Int32.Parse(Console.ReadLine());
				FileStream f = new FileStream("Bin1.bin", FileMode.OpenOrCreate);
				BinaryWriter fOut = new BinaryWriter(f);

				for (int i = 0; i < n; i++)
				{
					Console.Write($"{i + 1} слово: ");
					a = Console.ReadLine();
					fOut.Write(a);

				}
				fOut.Close();
				f = new FileStream("Bin1.bin", FileMode.Open);
				BinaryReader fIn = new BinaryReader(f);
				Console.WriteLine("\nСлова начинающиеся и \nзаканчивающиесяна одну букву:");

				for (long i = 0; i < n; i++)
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
						Console.Write($"{a}\n");
					}
				}
				if (j == 0)
				{
					Console.WriteLine("Таких слов нет");
				}
				Console.WriteLine();
				fIn.Close();
				f.Close();
			}
			catch
            {
				Console.WriteLine("Произошла ошибка");
			}
		}
	}
}
