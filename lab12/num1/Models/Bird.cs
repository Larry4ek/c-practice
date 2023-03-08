using System;

namespace num1.Models
{

    class Bird
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

    }

}
