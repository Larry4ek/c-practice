using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер квадратной матрицы: ");
            byte N = Convert.ToByte(Console.ReadLine());
            int[,] Matrix = new int[N, N];
            Console.Write("Введите A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            int B = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Matrix[i, j] = random.Next(A, B);
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Write("Введите G: ");
            int G = int.Parse(Console.ReadLine());
            int GCount = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Matrix[i, j] > G)
                    {
                        GCount++;
                    }
                }
            }
            Console.WriteLine($"Количество элементов больше G: {GCount}");
            Console.Write("Введите строку: ");
            int k = int.Parse(Console.ReadLine());
            int odd = 0;
            for (int j = 0; j < N; j++)
            {
                if (Matrix[k, j] % 2 == 0)
                {
                    odd++;
                }
            }
            Console.WriteLine($"Количество четных элементов {k} строки: {odd}");
            Console.ReadLine();
        }
    }
}