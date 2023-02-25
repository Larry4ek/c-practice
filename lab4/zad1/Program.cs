using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static double min(double a, double b)
        {
            return (a < b) ? a : b;
        }
        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            Console.Write("z=");
            double z = double.Parse(Console.ReadLine());
            Console.Write("v=");
            double v = double.Parse(Console.ReadLine());
            Console.WriteLine(min(min(x, y), min(z, v)));
        }
    }
}
