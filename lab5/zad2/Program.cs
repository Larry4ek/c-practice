namespace Numb2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число x: ");
                double x = Convert.ToInt32(Console.ReadLine());
                double f;
                if ((x < 1) && (x > -1))
                {
                    f = 1 / x;
                    Console.WriteLine("f(x) = " + f);
                }
                else if (x <= -1)
                    Console.WriteLine("f(x) = " + Math.Pow(x,2));
                else throw new Exception("Ошибка: выход из диапазона допустимых значений x");
            }
            catch (FormatException fx)
            {
                Console.WriteLine("Ошибка! " + fx.Message);
            }
            Console.ReadLine();
        }
    }
}

