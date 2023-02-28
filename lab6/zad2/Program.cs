using System;

namespace Numb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            Console.WriteLine("Введите диапазон для массива");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(a, b);
                Console.Write(array[i] + " ");
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] != array[array.Length - 1])
                {
                    sum++;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Кол-во чисел, отличных от последнего числа. = " + sum);
        }
    }
}
