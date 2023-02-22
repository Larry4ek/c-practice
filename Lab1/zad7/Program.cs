using static System.Console;
namespace zad3
{
    class Program
    {
        public static void Main()
        {
            double z1;
            double z2;
            double a;
            Console.Write("Введите значение a = ");
            a = Convert.ToInt32(Console.ReadLine());
            z1 = (1 - 2 * Math.Pow(Math.Sin(a), 2)) / (1 + Math.Pow(Math.Sin(a), 2));
            Console.WriteLine(z1);
            z2 = (1 - Math.Tan(a)) / (1 + Math.Tan(a));
            Console.WriteLine(z2);
        }
    }
}
