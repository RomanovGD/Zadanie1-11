using System;
using System.IO;

namespace pr9_2
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				string path = Environment.CurrentDirectory + @"\Text2.txt";
				Console.WriteLine("Файл Text2.txt\n");
				string[] str = File.ReadAllLines(path);
				for (int i = 0; i < str.Length; i++)
				{
					if (str[i].Length % 2 == 0)
					{
						Console.WriteLine($"{i + 1}: {str[i]}");
					}
				}
			}
			catch
            {
				Console.WriteLine("Произошла ошибка");
			}
		}
	}
}
