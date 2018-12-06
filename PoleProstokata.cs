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
            double h, w;
            Console.WriteLine("Obliczanie pola prostokąta ");
            while (true)
            {
                Console.Write("Podaj wysokość : ");
                if (double.TryParse(Console.ReadLine(), out  h)) { break; }
                else { Console.WriteLine("ERROR "); }
            }
            
            while (true)
            {
                Console.Write("Podaj szerokość : ");
                if (double.TryParse(Console.ReadLine(), out  w)) { break; }
                else { Console.WriteLine("ERROR "); }
            }

            double pole = h * w;
            Console.WriteLine($"Pole prostokąta == {pole}");
        }

        
    }
}