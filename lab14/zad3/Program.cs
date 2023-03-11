using System;
using System.IO;

namespace zad3.MyInfo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            MyInfo myinfo = new MyInfo(name);
            myinfo.Act += Inf_Act;
            Console.WriteLine($"{myinfo.Name} будет изменено на: ");
            myinfo.Name = Console.ReadLine();
            string end = Console.ReadLine();
            while (end != "end")
            {
                myinfo.Name = name;
                Console.WriteLine("Введите имя");
                name = Console.ReadLine();
                string ends = Console.ReadLine();

            }

            Console.WriteLine();
        }

        private static void Inf_Act(string obj)
        {
            Console.WriteLine($"Basic action: {obj}");
        }
    }
}