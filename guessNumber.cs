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
            Console.WriteLine("Komputer wylosował liczbę z przedziału 1 - 9 ");
            Console.WriteLine("Spróbuj zgadnąć jaka to liczba ");
            int rand, input;
            input = wprowadzanie();
            rand = losowanie();
            while(!sprawdzanie(input,rand))
            {
                Console.Write("Niestety nie zgadłeś sprubój jeszcze raz  ");
                if (rand > input) { Console.Write("nieco wyżej :D "); }
                else { Console.Write("nieco niżej :D "); }
                input = wprowadzanie();
            }
            Console.WriteLine("Brawo zgadłeś :D");
        }


        static int wprowadzanie()
        {
            int x;
            while (true)
            {
                Console.Write("Wprowadź liczbę z przedziału 1 - 9 : ");
                if (int.TryParse(Console.ReadLine(), out x)&&x<=9&&x>=1) { return x; }
                else { Console.WriteLine("Błędna wartość"); }
            }
        }


        static int losowanie()
        {
            Random x = new Random();
            return x.Next(1,10);
        }

        static bool sprawdzanie(int input,int rand)
        {
            if (input == rand) { return true; }
            else { return false; }

        }


    }
}





