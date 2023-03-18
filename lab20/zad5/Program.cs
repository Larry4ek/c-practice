using System.Runtime.CompilerServices;
using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Array first = new Array();
            first.Length = 10;
            int[,] First = new int[first.Length, first.Length];
            Console.WriteLine("Массив");
            first.fillArr(First, first.Length);
            Console.WriteLine("Остатки:");
            first.arrDiv(First, 2);
            Console.ReadLine();
        }


        /// <summary>
        /// created class Array
        /// </summary>
        class Array
        {
            public int Length;
            int[] Arr;

            /// <summary>
            /// Method to fill array with random numbers
            /// </summary>
            /// <param name="Arr"></param>
            /// <param name="Length"></param>
            public void fillArr(int[,] Arr, int Length)
            {
                Random r = new Random();

                for (int i = 0; i < Length; i++)
                {
                    for (int j = 0; j < Length; j++)
                    {

                        Arr[i, j] = r.Next(0, Length + 1);
                        Console.Write("{0}" + ", ", Arr[i, j]);
                    }
                }
                Console.ReadLine();
            }
            /// <summary>
            /// Method to calculate array diversion
            /// </summary>
            /// <param name="a"></param>
            /// <param name="temp"></param>
            public void arrDiv(int[,] a, int temp)
            {
                for (int i = 0; i < Length; i++)
                {
                    for (int j = 0; j < Length; j++)
                    {
                        a[i, j] %= temp;
                        Console.Write("{0}" + ", ", a[i, j]);
                    }
                }
            }

        }
    }

}