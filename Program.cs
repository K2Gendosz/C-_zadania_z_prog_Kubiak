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
                Console.Write("Podaj liczbę Ax : ");
                if (double.TryParse(Console.ReadLine(), out tab[0])) { break; }
                else { Console.WriteLine("Błędna wartość"); }
            }
            while (true)
            {
                Console.Write("Podaj liczbę Bx : ");
                if (double.TryParse(Console.ReadLine(), out tab[1])) { break; }
                else { Console.WriteLine("Błędna wartość"); }
            }
            while (true)
            {
                Console.Write("Podaj wyraz wolny C  : ");
                if (double.TryParse(Console.ReadLine(), out tab[2])) { break; }
                else { Console.WriteLine("Błędna wartość"); }
            }
            int liczbaPierwiastków;
            double delta = liczDelte(tab);
            if (delta > 0) { liczbaPierwiastków = 2; liczZerowe(delta, tab,liczbaPierwiastków); }
            else if (delta == 0) { liczbaPierwiastków = 1; liczZerowe(delta, tab,liczbaPierwiastków); }
            else { Console.WriteLine("Brak miejsc zerowych delta < 0"); }

        }

        static double liczDelte(double[] tab)
        {
            return (tab[1] * tab[1]) - (4 * tab[0] * tab[2]);
        }

        static void liczZerowe(double delta, double[] tab,int x)
        {
            switch (x)
            {
                case 1:
                    { Console.WriteLine($"Delta == 0 jet jedno miejsce zerowe == {(-tab[1] / (2 * tab[0])):#.##}"); } 
                    break;
                case 2:
                    {
                        double x1, x2;
                        x1 = (-tab[1] + Math.Sqrt(delta)) / (2 * tab[0]);
                        x2 = (-tab[1] - Math.Sqrt(delta)) / (2 * tab[0]);

                        Console.WriteLine($"Miejsca zerowe x1 == {x1:#.##}  i  x2 == {x2:#.##} delta == {delta:#.##}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}





