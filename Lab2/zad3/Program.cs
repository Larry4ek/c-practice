using System;
using static System.Console;
namespace secondPart_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            year %= 12; 
            year+=1;
            switch (year)
            {
                case 1: Console.WriteLine("Обезьяна"); break;
                case 2: Console.WriteLine("Петух"); break;
                case 3: Console.WriteLine("Собака"); break;
                case 4: Console.WriteLine("Кабан"); break;
                case 5: Console.WriteLine("Крыса"); break;
                case 6: Console.WriteLine("Бык"); break;
                case 7: Console.WriteLine("Тигр"); break;
                case 8: Console.WriteLine("Кролик"); break;
                case 9: Console.WriteLine("Дракон"); break;
                case 10: Console.WriteLine("Змея"); break;
                case 11: Console.WriteLine("Лошадь"); break;
                case 12: Console.WriteLine("Овца"); break;
                default: Console.WriteLine("ВЫ ОШИБЛИСЬ"); break;
            }

            Console.ReadKey();
        }
    }
}