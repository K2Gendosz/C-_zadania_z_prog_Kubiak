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
            double[] tab = new double[3];
            while (true)
            {
                Console.Write("Podaj pierwszą liczbę : ");
                if (double.TryParse(Console.ReadLine(), out tab[0])) { break; }
                else { Console.WriteLine("Błędna wartość"); }
            }
            while (true)
            {
                Console.Write("Podaj drugą liczbę : ");
                if (double.TryParse(Console.ReadLine(), out tab[1])) { break; }
                else { Console.WriteLine("Błędna wartość"); }
            }
            while (true)
            {
                Console.Write("Podaj trzecią liczbę : ");
                if (double.TryParse(Console.ReadLine(), out tab[2])) { break; }
                else { Console.WriteLine("Błędna wartość"); }
            }

           bool x = sprawdzanie(tab);
            switch (x)
            {
                case true:
                    {
                        Console.WriteLine("jest");
                        break;
                    }
                case false:
                    { Console.WriteLine("nie jest");
                        break;
                    }
                default:break;
            }

        }
        static bool sprawdzanie(double[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length; j++)
                {
                    double z;
                    if (tab[i] < tab[j]) { z = tab[i];tab[i] = tab[j];tab[j] = z; }
                }
            }

            if (Math.Pow(tab[0], 2) + Math.Pow(tab[1], 2) == Math.Pow(tab[2], 2)) { return true; }
            else { return false; }

            

        }

    }
}