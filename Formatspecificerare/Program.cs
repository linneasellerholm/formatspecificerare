using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatspecificerare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            DateTime dt = new DateTime(2016, 10, 7, 16, 14, 54, 50);
            Console.WriteLine(dt.ToString("d"));

            //Övning 2
            double number = 4*(Math.PI*Math.PI);
            Console.WriteLine(number.ToString("F4")+"cm2");

            //Övning 3

        }
    }
}
