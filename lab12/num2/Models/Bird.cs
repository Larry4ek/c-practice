using System;

namespace num2.Models
{

    abstract class Bird
    {
        public string Name { get; }

        public virtual void DisplayPrint()
        {
            Console.WriteLine($"Птица:{Name} ");
        }
        public Bird(string name)
        {
            Name = name;
        }
        public abstract double Food();

       
    }

}
