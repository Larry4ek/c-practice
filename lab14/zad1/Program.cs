using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadanie1
{
    class Program
    {
        public delegate double CalcFigure(double a);
        static double Perimeter(double a)
        {
            double p = 1;
            try
            {
                p = a * 3;
                Console.WriteLine("Периметр = {0}", p);
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine(err.Message);
            }
            return p;
        }
        static double Square(double a)
        {
            double s = 1;
            try
            {
                s = Math.Sqrt(3) / Math.Sqrt(4) * a;
                Console.WriteLine("Площадь = {0}", s);

            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine(err.Message);
            }
            return s;
        }
        static double Storona(double a)
        {
            try
            {
                Console.WriteLine("Сторона = {0}", a);
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine(err.Message);
            }
            return a;
        }
        public static void Zadan2(CalcFigure a)
        {
            try
            {
                Console.Write("Введите сторону: ");
                double rd = Convert.ToDouble(Console.ReadLine());
                a(rd);
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите сторону: ");
                double rad = Convert.ToDouble(Console.ReadLine());
                CalcFigure CF = new CalcFigure(Perimeter);
                CF += Square;
                CF += Storona;
                CF(rad);
                Zadan2(CF);
            }
            catch (FormatException err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}