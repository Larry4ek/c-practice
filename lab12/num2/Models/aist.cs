using System;

namespace num2.Models
{

    class Aist : Bird
    {
        public int a;

        public override void DisplayPrint()
        {
            Console.WriteLine($"Аист: {Name}, размах крыльев: {a}, Кол-во пищи {Food()}");
        }

        public override double Food()
        {
            return a*1/2000;
        }
        public Aist(int a, string name) : base(name)
        {
            this.a = a;
        }
    }

}
