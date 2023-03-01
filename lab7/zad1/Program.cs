using System;
namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string offer = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < offer.Length; i++)
            {
                if (offer[i] == ' ')
                {
                    sum += 1;
                }
            }
            Console.WriteLine("кол-во пробелов = " + sum);
        }
    }
}
