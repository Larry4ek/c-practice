using static System.Console;
namespace zad3
{
    class Program
    {
        public static void Main()
        {
            double time = 0;
            int height = 0;

            Console.Write("Введите высоту в метрах, h= ");
            height = Convert.ToInt32(Console.ReadLine());
            time = Math.Sqrt(2 * height / 9.8);
            Write("Время падения камня - " + time + " секунд");

        }
    }
}