using System;
namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string offer = Console.ReadLine();
            int sumc = 0;
            int sumn = 0;
            for (int i = 0; i < offer.Length; i++)
            {
                if (offer[i] >= '0' && offer[i] <= '9')
                {
                    sumc += 1;
                }
            }
            for (int i = 0; i < offer.Length; i++)
            {
                if (offer[i] >= '0' && offer[i] <= '9')
                {
                    sumn += 0;
                }
                else
                {
                    sumn += 1;
                }
            }
            Console.WriteLine("кол-во чисел = " + sumc);
            Console.WriteLine("кол-во букв = " + sumn);
        }
    }
}
