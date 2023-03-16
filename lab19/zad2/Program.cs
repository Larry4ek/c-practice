using System;
using System.Collections.Generic;
using System.IO;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Console.WriteLine("Введите значение а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            FileStream file = new FileStream(@"f.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string s = reader.ReadToEnd();
            reader.Close();
            string[] sp = s.Split(' ');
            for (int i = 0; i < sp.Length; i++)
            {
                queue.Enqueue(Convert.ToInt32(sp[i]));
            }
            Console.WriteLine();
            Console.WriteLine("1) Элементы в диапазоне от a до b :");
            foreach (int n in queue)
            {
                if ((n > a) && (n < b)) Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("2) Элементы меньшие а :");
            foreach (int n in queue)
            {
                if (n < a) Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("3) Элементы большие b :");
            foreach (int n in queue)
            {
                if (n > b) Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}