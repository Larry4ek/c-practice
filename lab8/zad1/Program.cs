using System;
using System.Text.RegularExpressions;
namespace Numb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();
            Regex data = new Regex(@"\d{2}.\d{2}.\d{4}");
            MatchCollection matches = data.Matches(s);
            string[] arrData;
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    arrData = match.Value.Split('.');
                    if ((Convert.ToInt32(arrData[0]) <= 31) && (Convert.ToInt32(arrData[1]) <= 12) && (Convert.ToInt32(arrData[2]) <= 2050))
                        Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}
