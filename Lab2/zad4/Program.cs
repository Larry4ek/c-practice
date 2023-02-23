using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 80; i >= 10; i -= 2)
            {
                Console.WriteLine(i);
            }

            int k = 80;
            while (k >= 10)
            {
                Console.WriteLine(k);
                k -= 2;
            }

            int n = 80;
            do
            {
                Console.WriteLine(n);
                n -= 2;
            }
            while (n >= 10);
        }
    }
}

