using num2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во птиц");
            int l = int.Parse(Console.ReadLine());
            
            Bird[] birds = new Bird[l];
            

            for (int i = 0; i < birds.Length; i++)
            {
                Console.WriteLine("введ размах крыльев , вид птицы");
                birds[i] = new Cow(Convert.ToDouble(Console.ReadLine()), Console.ReadLine()); 
                birds[i] = new Aist(int.Parse(Console.ReadLine()), Console.ReadLine());
                
            }

            foreach (Bird bird in birds)
            {
                bird.DisplayPrint();
            }


            
           
        }
    }
}
