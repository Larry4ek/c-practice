using System;

namespace p1
{
    class Nedelya
    {
        public string f;
        public string den;
        public Nedelya(string f, string den)
        {
            this.f = f;
            this.den = den;
        }
        virtual public void PrintNedelya()
        {
            Console.WriteLine("В " + den + "  " + f);
        }
    }
}