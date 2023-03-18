using System;
using zad6;

namespace MyNamespace
{

    /// <summary>
    /// Created delegate EventHandler
    /// </summary>

    delegate void MyEventHandler();
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите имя");
            string enteredString = Console.ReadLine();

            MyInfo information = new MyInfo(enteredString);
            Listener listenerKolya = new Listener("Kolya");
            information.Action += Information_Action;
            information.Action += listenerKolya.Listen;
            while (true)
            {
                information.Name = enteredString;
                Console.WriteLine("Введите имя");
                enteredString = Console.ReadLine();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Methdo to get infotamion about basic action
        /// </summary>
        /// <param name="obj"></param>

        private static void Information_Action(string obj)
        {
            Console.WriteLine($"Basic action: {obj}");
        }
    }
}