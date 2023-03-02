using System;
using System.Text.RegularExpressions;
namespace Numb3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Regex regexPunc = new Regex("[-)(,:]");
            Regex regexSent = new Regex(@"(\w+[-)(,:]?[\s.?!]?)+");
            MatchCollection matchs = regexSent.Matches(text);
            foreach (Match sent in matchs)
            {
                if (regexPunc.IsMatch(sent.Value))
                {
                    Console.WriteLine(sent.Value);
                }
            }
        }
    }
}
