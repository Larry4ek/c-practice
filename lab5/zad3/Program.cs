using System;
class Program
{
    static void Main()
    {
        try
        {
            double a = 3;
            double b, c, d;
            PowerA234(a, out b, out c, out d);
            Console.WriteLine("Квадрат числа {0} это {1}", a, b);
            Console.WriteLine("Куб числа {0} это {1}", a, c);
            Console.WriteLine("4-ая степень числа {0} это {1}", a, d);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void PowerA234(double a, out double b, out double c, out double d)
    {
        if (a == 0)
        {
            throw new ArgumentException("Argument A cannot be zero");
        }
        b = Math.Pow(a, 2);
        c = Math.Pow(a, 3);
        d = Math.Pow(a, 4);
    }
}