using System;
using System.Text.RegularExpressions;

namespace bb
{
    class Program
    {
        public static void Main()
        {
            char[] arrLetters = {
                'а','б','в','г','д','е','ё','ж','з',
                'и','и','к','л','м','н','о','п',
                'р','с','т','у','ф','х','ц','ч',
                'ш','щ','ъ','ы','ь','э','ю','я'
            };

            int count = 0;
            string a;
            Console.WriteLine("Введите строку:");
            a = Console.ReadLine();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < arrLetters.Length; j++)
                {
                    count += arrLetters[j] + 1;
                };

            };
            int asasd = Foo(count);
            int asb = Foo(asasd);
            Console.WriteLine(asb);
        }
        static int Foo(int value)
        {
            int result = 0;
            while (value > 0)
            {
                result += value % 10;

                value /= 10;
            }
            return result;
        }
    }


}