using num1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            Bird[] birds = new Bird[] {
                new Crow(15,"Ворона"),
                new Aist(10,"Аист")
            };

            foreach (Bird bird in birds)
            {
                bird.DisplayPrint();

            }


        }
    }
}