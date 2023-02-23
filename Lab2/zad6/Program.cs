using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            double A = (Math.Sqrt(2)) / (2);
            double B = 1;
            double H = (B - A) / M;
            double x = 0;
            x = x + H;
            for (int i = 1; i <= M; i++)
            {
                double y = 2 - Math.Sin(x);
                Console.WriteLine($"{i} - " + y);
                x = x + H;
            }
            Console.ReadLine();
        }
    }
}