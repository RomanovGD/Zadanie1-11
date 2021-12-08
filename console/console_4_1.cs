using System;

namespace Zadanie_4_1_
{
    class Program
    {
        static int Rec(int n, int a = 0)
        {
            if (n-- == 0) return a;
            return Rec(n, 1 + a + n);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите m:");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите k:");
                int k = int.Parse(Console.ReadLine());

                if (m >= 0 && k >= 0)
                {
                    int result = Rec(m) + Rec(2 * k);

                    Console.WriteLine("Значение выражения = " + result);
                }
                else
                    Console.WriteLine("Ошибка! Введите положительное число для m и k.");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine("Исключение! Введите натуральное число");
            }
        }
    }
