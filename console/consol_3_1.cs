using System;

namespace pr3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 2.2, y1 = 3, x2 = 3.5, y2 = 1, x3 = 5, y3 = 10;
            double a = 0, b = 0, c = 0, minimal = 0;
            a = func(x1, y1, x2, y2);
            b = func(x2, y2, x3, y3);
            c = func(x1, y1, x3, y3);
            if (min(a, b) == a)
                minimal = a;
            else
                minimal = b;
            if (minimal > min(b, c))
                minimal = c;
            if (minimal == a)
                Console.WriteLine("Минимальное расстояние между точками (x1,y1) и (x2,y2)");
            if (minimal == b)
                Console.WriteLine("Минимальное расстояние между точками (x2,y2) и (x3,y3)");
            if (minimal == c)
                Console.WriteLine("Минимальное расстояние между точками (x1,y1) и (x3,y3)");
            Console.Read();
        }
        static double func(double x1, double y1, double x2, double y2)
        {
            double answer = 0;
            answer = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            return answer;
        }
        static double min(double a, double b)
        {
            if (a <= b)
                return a;
            else
                return b;
        }
    }
}