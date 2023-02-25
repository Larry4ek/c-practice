using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(CalculateX(x));
        }
        static double CalculateX(double x)
        {
            double y = 0;

            if (Math.Abs(x) < 3)
            {
                y = Math.Sin(x); 
            }
            else if (3 <= Math.Abs(x) && Math.Abs(x) < 9)
            {
                y = (Math.Sqrt(x*x + 1)) / (Math.Sqrt(x*x+5));
            }
            else if (Math.Abs(x) >= 9)
            {
                y = (Math.Sqrt(x*x+1)) - (Math.Sqrt(x*x+5));
            };

            return y;
        }
    }
}
