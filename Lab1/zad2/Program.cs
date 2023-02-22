using System;
namespace Zad2
{
    class Program
    {
        static int digitsMult(int n)

        {
            int mult = 1;
            while (n != 0)
            {
                mult *= n % 10;
                n /= 10;
            }
            return mult;
        }

        static void Main()

        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Произведение цифр: " + digitsMult(n));
            Console.ReadLine();

        }
    }
}