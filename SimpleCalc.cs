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
            double a,b;
            while(true)
            {
                Console.Write("Podaj  pierwszą liczbę : ");
                if (double.TryParse(Console.ReadLine(), out a))
                { break; }
                else { Console.WriteLine("Błędna wartoaść "); }
            }
            while (true)
            {
                Console.Write("Podaj  drugą liczbę : ");
                if (double.TryParse(Console.ReadLine(), out b))
                { break; }
                else { Console.WriteLine("Błędna wartoaść "); }
            }
            Console.WriteLine($"{a} + {b} = {dodawanie(a,b):##.##}");
            Console.WriteLine($"{a} - {b} = {odejmowanie(a, b):##.##}");
            Console.WriteLine($"{a} * {b} = {mnożenie(a, b):##.##}");
            Console.WriteLine($"{a} / {b} = {dzielenie(a, b):##.##}");



        }
        static double dodawanie(double a,double b) { return a + b; }
        static double odejmowanie(double a, double b) { return a - b; }
        static double mnożenie(double a, double b) { return a * b; }
        static double dzielenie(double a, double b) { return a / b; }


    }
}