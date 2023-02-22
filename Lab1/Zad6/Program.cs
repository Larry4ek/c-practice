using System;
namespace Zad6
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
            Console.Write("Введите двухзначное число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Произведение цифр: " + digitsMult(n));
            Console.ReadLine();

        }
    }
}