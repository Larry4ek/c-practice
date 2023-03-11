using System;
using System.Threading;

namespace p3
{
    class Program
    {
        public class Example
        {
            public int a;
            public int n;
        }
        static void Metod1(Object ob)
        {
            Example ex = ob as Example;
            double sum = 0;
            for (int i = 0; i <= ex.n; i++)
            {
                sum += Math.Pow(ex.a, i);
            }
            Console.WriteLine(sum);
        }
        static void Metod2(Object ob)
        {
            Object obnew = new Object();
            Example ex = ob as Example;
            Console.WriteLine(Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            lock (obnew)
            {
                double mul = 1;
                for (int i = 0; i <= ex.n; i++)
                {
                    mul *= Math.Pow(ex.a, i);
                }
                Console.WriteLine(mul + " " + Thread.CurrentThread.Name);
            }
        }
        static void Main(string[] args)
        {
            Example ex = new Example();
            Console.Write("Введите значение А- ");
            ex.a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение N- ");
            ex.n = Convert.ToInt32(Console.ReadLine());
            Thread threadMet1 = new Thread(new ParameterizedThreadStart(Metod1));
            threadMet1.Name = "name1";
            threadMet1.IsBackground = true;
            Thread threadMet11 = new Thread(new ParameterizedThreadStart(Metod1));
            threadMet11.Name = "name11";
            threadMet11.IsBackground = true;
            Thread threadMet2 = new Thread(new ParameterizedThreadStart(Metod2));
            threadMet2.Name = "name2";
            threadMet2.IsBackground = true;
            Thread threadMet22 = new Thread(new ParameterizedThreadStart(Metod2));
            threadMet22.Name = "name22";
            threadMet22.IsBackground = true;
            threadMet1.Start(ex);
            threadMet11.Start(ex);
            threadMet2.Start(ex);
            threadMet22.Start(ex);
            Console.ReadLine();
        }
    }

}