using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Program
    {
        const int N = 7;
        static void Main(string[] args)
        {
            int n = 0;
            int[,] helix = new int[N, N];

            int x0 = 0;
            int xn = N - 1;
            int y0 = 0;
            int yn = N - 1;

            while (n < N * N)
            {
                for (int x = x0; x <= xn; x++)
                {
                    helix[y0, x] = ++n;
                }

                y0++;

                for (int y = y0; y <= yn; y++)
                {
                    helix[y, xn] = ++n;
                }

                xn--;

                for (int x = xn; x >= x0; x--)
                {
                    helix[yn, x] = ++n;
                }

                yn--;

                for (int y = yn; y >= y0; y--)
                {
                    helix[y, x0] = ++n;
                }

                x0++;
            }

            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    Console.Write("{0}\t", helix[y, x]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}