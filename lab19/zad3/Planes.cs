using System;
using System.Collections.Generic;


namespace p1
{
    class Planes
    {
        static void Main(string[] args)
        {
            Time dem = new Time("(план)", "(день)", 24);
            InfoObj.Info<Time>(dem);
            Console.WriteLine();
            Fil List = new Fil();
            Dictionary<int, string> Fm = new Dictionary<int, string>(3);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите день ");
                string w = Console.ReadLine();
                Console.WriteLine("Введите план ");
                string g = Console.ReadLine();
                Console.WriteLine("Введите время ");
                int t = int.Parse(Console.ReadLine());
                List.Add(new Time(w, g, t));
                Fm[i + 1] = g;
            }
            Console.WriteLine();
            foreach (KeyValuePair<int, string> keyValue in Fm)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine();
            foreach (Time x in List) x.PrintNedelya();
            List.RemoveAt(1);
            Console.WriteLine();
            Fil cl = (Fil)List.Clone();
            foreach (Time x in cl) x.PrintNedelya();
            Console.ReadLine();
        }
    }
}
