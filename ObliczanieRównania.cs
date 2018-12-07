using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wyznaczanie x ze wzoru Ax+B=C");
            double a, b, c;
            while (true)
            {
                Console.Write("Podaj wartość wyrażenia a : ");
                a = wprowadzanie();
                if (a == 0) { Console.WriteLine("a nie może się równać 0"); }
                else { break; }
            }
            Console.Write("Podaj wartość wyrażenia b : ");
            b = wprowadzanie();
            Console.Write("Podaj wartość wyrażenia c : ");
            c = wprowadzanie();

            Console.WriteLine($"Wartość x = {obliczanie(a, b, c):##.##}");
        }
       static double wprowadzanie()
        {
            double x;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out x)) {return x;}
                else {
                    Console.WriteLine("Błędna wartość ");
                    Console.Write("Podaj poprawną wartość ");
                }
            }
            
        }

        static double obliczanie(double a,double b, double c)
        {
            return (c - b) / a;
            
        }

    }
}





