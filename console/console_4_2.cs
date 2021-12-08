namespace hello
{
    class Program
    {
        static void metod(int n1)
        {
            if (n1 == 1) Console.WriteLine(n1);
            else
            {
                Console.WriteLine(n1);
                metod(--n1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число N (N >= 1000) ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 1000)
            {
                Console.WriteLine("Рекурсивный метод");
                metod(n);
            }
            else Console.WriteLine("Число меньше 1000");
            Console.ReadKey();
        }
    }
}
