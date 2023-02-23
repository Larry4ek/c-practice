using System;
using static System.Console;
namespace zad2
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) 
            Console.WriteLine("число чётное");
            else 
            Console.WriteLine("число нечётное");
        }
    }
}

