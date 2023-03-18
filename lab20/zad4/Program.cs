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

        /// <summary>
        /// Method of calculatio  x nuber
        /// </summary>
        /// <param name="x"></param>
        /// <returns>
        /// y value
        /// </returns>
        static double CalculateX(double x)
        {
            double y = 0;

            if (x < 0)
            {
                y = 0.2 * (x * x) - x - 0.1;
            }
            else if (x > 0 && x != 0.1 && x != 1)
            {
                y = (x * x) / x - 0.1;
            }
            else if (x == 1)
            {
                y = 0;
            };

            return y;
        }
    }
}