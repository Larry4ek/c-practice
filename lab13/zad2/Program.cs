class Program
{
    public delegate double Arif(double a, double b);
    static void Main(string[] args)
    {
        Arif Add = (x, y) =>
        {
            Console.WriteLine("Результат={0}", x + y);
            return x + y;
        };
        Arif Sub = (x, y) =>
        {
            Console.WriteLine("Результат={0}", x - y);
            return x - y;
        };
        Arif Mul = (x, y) =>
        {
            Console.WriteLine("Результат={0}", x * y);
            return x * y;
        };
        Arif Div = (x, y) =>
        {
            if (y == 0)
            {
                Console.WriteLine("Ошибка деление на 0!");
            }
            else
                Console.WriteLine("Результат={0}", x / y);
            return x / y;
        };
        Console.Write("Введите значение х- ");
        double X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение у- ");
        double Y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Выберите действие:\n1.Сложение \n2.Вычитание \n3.Умножение \n4.Деление");
        int i = Convert.ToInt32(Console.ReadLine());
        switch (i)
        {
            case 1: if (Add != null) Add(X, Y); break;
            case 2: if (Sub != null) Sub(X, Y); break;
            case 3: if (Mul != null) Mul(X, Y); break;
            case 4: if (Div != null) Div(X, Y); break;

            default: Console.WriteLine("Нет такого пункта!"); break;
        }
        Console.ReadLine();
    }
}