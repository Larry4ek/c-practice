using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Arr = new int[3, 5];
            Random random = new Random();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Arr[i, j] = random.Next(0, 10);
                }
            }
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write(Arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите номер строки");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число");
            int ch = int.Parse(Console.ReadLine());
            int n = Arr.GetLength(0);
            int m = Arr.GetLength(1);
            if (num < n)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += Arr[num, j];
                }
                if (sum > ch)
                {
                    Console.WriteLine("Сумма элементов строки массива с номером = {0} превышает заданное число ({1})", num, ch);
                }
                else
                {
                    Console.WriteLine("Сумма элементов строки массива с номером = {0} не превышает заданное число ({1})", num, ch);
                }
            }

        }
    }
}