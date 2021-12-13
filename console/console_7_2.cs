using System;

using System.Linq;

using System.Text;

namespace pr7_2

{

    class Program

    {

        static void Main(string[] args)

        {

            try

            {

                Console.Write("Ваша строка: ");

                StringBuilder a = new StringBuilder(Console.ReadLine());

                Console.WriteLine();

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

                Console.WriteLine(string.Join("\n", ordered));

            }

            catch (Exception)

            {

                Console.WriteLine("\n\tЧто-то не так");

            }

        }

    }

}