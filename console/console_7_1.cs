using System;

using System.Text;

namespace pr7_1

{

    class Program

    {

        static void Main(string[] args)

        {

            try

            {

                Console.Write("Ваша строка: ");

                StringBuilder a = new StringBuilder(Console.ReadLine());

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

                Console.WriteLine("\nИзмененная строка: " + a);

            }

            catch (Exception)

            {

                Console.WriteLine("\n\tЧто-то не так");

            }

        }

    }

}