using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            while(true)
            {
                Console.Write("Podaj promień kuli : ");
                if (double.TryParse(Console.ReadLine(), out r))
                { break; }
            }
           
            double V = (4.0 / 3.0) * Math.PI * r * r * r;

            Console.WriteLine("Obiętość kuli wynoci {0:#.##}",V);
        }

        
    }
}