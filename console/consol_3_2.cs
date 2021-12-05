using System;

namespace pr3_2
{
    class Task
    {
        public double a;
        public double b;
        public double h;
        private double y;
        public Task(double x, double y, double n)
        {
            a = x; b = y; h = n;
        }
        public void Tasker() //Функция метода
        {
            for (double x = a; x <= b; x += h)
            {
                if (x < 3)
                {
                    Console.WriteLine($"{Math.Pow(x, 2) - 0.3}");
                }
                else if (x <= 5)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine($"{Math.Pow(x, 2) + 1}");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите [a,b] через Enter:");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите шаг h: ");
            double h = Convert.ToInt32(Console.ReadLine());
            Task answer = new Task(a, b, h);
            answer.Tasker();
            Console.ReadKey();
        }
    }
}