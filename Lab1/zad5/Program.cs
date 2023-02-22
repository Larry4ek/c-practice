using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            double VolumeCylindre, radius, Height;
            Write("Введите значение радиуса: ");
            radius = Convert.ToDouble(ReadLine());
            Write("Введите значение высоты: ");
            Height = Convert.ToDouble(ReadLine());
            VolumeCylindre = (Math.PI * radius * radius * Height) * 2;
            WriteLine("Объем цилиндра равен = " + VolumeCylindre);
            ReadLine();

        }
    }

}