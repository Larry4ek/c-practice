using System;

namespace p1
{
    class Time : Nedelya
    {
        int tim;
        public Time(string f, string den, int tim) : base(f, den)
        {
            this.tim = tim;
        }
        public override void PrintNedelya()
        {
            Console.WriteLine("В " + f + " " + den + " время " + tim);
        }
    }
}

