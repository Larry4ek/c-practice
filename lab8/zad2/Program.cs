using System;
using System.Text.RegularExpressions;
namespace Numb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            string text = Console.ReadLine();
            Console.WriteLine(text);
            Regex task = new Regex(@"\b(\w+?)\s\1\b");
            bool hesDigits = task.IsMatch(text);
            string result = hesDigits ? "Есть повторяющиеся" : "Нет повторяющихся";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
