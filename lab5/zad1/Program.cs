using System;
namespace Numb1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первый x");
                int x1 = Convert.ToInt32(Console.ReadLine());
                double y1 = (Math.Tan(x1 - 2)) / ((x1 + 12)) + Math.Pow((Math.Cos(x1 / 2)), 2);
                Console.WriteLine("Результат y1 : " + y1);

                Console.WriteLine("Введите второй x");
                int x2 = Convert.ToInt32(Console.ReadLine());
                double y2 = Math.Log10(x2) - (Math.Atan(Math.Pow(x2, 3))) / ((2 * x2 + 6));
                Console.WriteLine("Результат y2 : " + y2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Попытка деления на 0");
            }
            catch (FormatException)

            {
                Console.WriteLine("Не введено значение х");
            }
        }
    }
}
