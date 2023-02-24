using System;
using static System.Console;

namespace zad2
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите число а: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            A num = new A(num1, num2);
            num.raznost();
            num.func();
            Console.ReadLine();
        }
    }
    class A
    {
        public int a;
        public int b;
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void raznost()
        {
            Console.WriteLine($"Разность чисел {a}-{b} равно {a - b}");
        }
        public void func()
        {
            Console.WriteLine($"Результат вычисления заданной функции равен {(a+b) / (a-b)}");
        }
    }
}   

