using System;
namespace MyNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            Console.WriteLine("Введите диапазон чисел для массива");
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
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("сумма элементов массива = " + sum);

        }
    }
}
