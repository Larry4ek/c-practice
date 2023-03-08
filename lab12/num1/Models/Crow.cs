using System;

namespace num1.Models
{

    class Crow : Bird
    {
        public double R;

        public Crow(double R, string name) : base(name)
        {
            this.R = R;

        }
        public override void DisplayPrint()
        {
            Console.WriteLine($"Птица: { Name}, Размах крыльев: {R} Кол-во пищи {Food()}");
        }

        public virtual double Food()
        {
            return 0.8 * R;
        }

    }

}