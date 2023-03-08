using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication10
{
    class A
    {
        public int a;
        public int b;
        public A() { }
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
    class B : A
    {
        private int d;
        public int c2
        {
            get
            {
                switch (a)
                {
                    case 0:
                        return 0;
                        break;
                }
                switch (b)
                {
                    case 0:
                        return 0;
                        break;
                    default:
                        return a + b;
                        break;
                }
            }
        }
        public B() { }
        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A aa = new A(1, 2);

            B b = new B();
            B bb = new B(1, 2, 3);
            Console.WriteLine(bb.c2);
        }
    }
}
