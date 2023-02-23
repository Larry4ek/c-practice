using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double rez = 0;
            for (int i = 1; i <= n; i++)
                rez += Math.Pow(-1, i + 1) * (1.0 + (double)i / 10);
            Console.WriteLine("Result=" + rez);
            Console.ReadKey();
        }
    }
}