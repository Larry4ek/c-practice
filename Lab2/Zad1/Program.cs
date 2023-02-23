using static System.Console;
namespace zad1
{
    class Program
    {
        public static void Main()
        {

            Console.Write("Введите значение x = ");
            double x = Convert.ToInt32(Console.ReadLine());
            double y;
            double e = 2.718;
            if (x >= 10)
            {
                y = 4 + Math.Pow(x, 2) - Math.Pow(e, Math.Sqrt(x));
                Console.WriteLine("Значение Y: "+ y);
            }
            else if (x < 10)
            {
                y = 3.4 - x + 0.1 * Math.Pow(x, 3);
                Console.WriteLine("Значение Y: "+ y);
            }
           
        
        }
    }
}
