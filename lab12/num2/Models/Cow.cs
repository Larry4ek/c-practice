using System;

namespace num2.Models
{

    class Cow : Bird
    {
        public double l;

        public Cow(double l, string name) : base(name)
        {
            this.l = l;

        }
        public override void DisplayPrint()
        {
            Console.WriteLine($"Ворона: { Name}, размах крыльев: {l} , Кол-во пищи {Food()}");
        }

        public override double Food()
        {
            return 0.8 * l;
        }


    }

}
