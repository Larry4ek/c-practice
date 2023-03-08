using System;

namespace num1.Models
{

    class Aist : Bird
    {
        public int L;


        public override void DisplayPrint()
        {
            Console.WriteLine($"Аист: {Name}, размах крыльев: {L}, кол-во пищи {Food()}");
        }

        public virtual double Food()
        {
            return L * 1 / 2000;
        }
        public Aist(int L, string name) : base(name)
        {
            this.L = L;
        }
    }

}