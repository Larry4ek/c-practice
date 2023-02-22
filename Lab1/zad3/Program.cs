using static System.Console;
namespace zad3
{
    class Program
    {
        public static void Main()
        {
            int x = 5;
            double y = (Math.Pow(2.718, 2 * x) - Math.Pow(2.718, Math.Sqrt(Math.Abs(1 - x)))) + (2 * Math.Pow(Math.Sin(x), 2)) / (3.14 * x * x);
            Console.WriteLine(y);
        }
    }
}
