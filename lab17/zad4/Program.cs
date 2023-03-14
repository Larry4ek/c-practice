using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text;
            using (StreamReader sr = new StreamReader("D:\\!Практика c#\\lab17\\zad4\\f1.txt"))
            {
                text = sr.ReadToEnd().ToCharArray();
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '0')
                    text[i] = '1';
                else
                {
                    if (text[i] == '1')
                        text[i] = '0';
                }
            }
            using (StreamWriter sw = new StreamWriter("D:\\!Практика c#\\lab17\\zad4\\f2.txt"))
            {
                foreach (char c in text)
                    sw.Write(c);
            }
        }
    }
}
