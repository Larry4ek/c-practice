using System;
using System.Collections.Generic;
using System.Threading;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n = Int32.Parse(Console.ReadLine());
            Thread myThread1 = new Thread(new ParameterizedThreadStart(Run));
            Console.WriteLine("Поток 1");
            int[] array = RndArray(n);
            Console.WriteLine("Массив:");
            foreach (var item in array)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
            List<int> resList = EvenIndex(array);
            Console.WriteLine("Четные элементы массива:");
            foreach (var item in resList)
            {
                Console.Write(item + "  ");
            }
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Поток 2");
            myThread1.Start(resList);
            Thread.Sleep(100);
            Console.ReadLine();
        }
        static int[] GetArray(int n)
        {
            int[] array = new int[n];
            return array;
        }
        static int[] RndArray(int n)
        {
            int[] array = GetArray(n);
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(10);
            }
            return array;
        }
        static List<int> EvenIndex(int[] array)
        {
            List<int> ListEnev = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    ListEnev.Add(array[i]);
                }
            }
            return ListEnev;
        }
        static void Run(object o)
        {
            int summ = 0;
            List<int> sum = (List<int>)o;
            foreach (var item in sum)
            {
                summ += item;
            }
            Console.WriteLine("Сумма четных чисел массива:" + summ);
        }
    }

}