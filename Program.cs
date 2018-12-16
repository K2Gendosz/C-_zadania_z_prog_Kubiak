using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // for (){}
            zadanie3_16();
            //zadanie3_22();
            //-----------------------------
            // do{}while()
            //-----------------------------
            //while(){}
            //-----------------------------

        }

        static void zadanie3_16()
        {
            Console.Write("How many number i have to draw : ");

            double avg=0;
            int num=0,min,max;
            int[] tab;
            for(int i=0;i!=2;)
            {
                if (int.TryParse(Console.ReadLine(), out int n)) { num = n; break;}
                else { Console.Write("Wrong operand.Please try one more time : "); }
            }
            tab = new int[num];
            Random rand = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(1, 100);
                avg += tab[i];
            }
            min = tab[0]; max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if(tab[i] < min) { min = tab[i]; }
                else if (tab[i] > max) { max = tab[i]; }
            }
            avg /= tab.Length;
            foreach (var item in tab)
            {
                Console.Write($"{item} ");
            }     
            Console.WriteLine($"The min value == {min}, the max value == {max}, the avrage is {avg} ");
        }




        static void zadanie3_22()
        {
            char x;
            for (int i = 65; i <= 90; i++)
            {
                x = Convert.ToChar(i);
                Console.Write($"{x} ");
            }
            Console.WriteLine("");
            for (int i = 90; i >=  65; i--)
            {
                x = Convert.ToChar(i);
                Console.Write($"{x} ");
            }
            Console.WriteLine("");

        }
    }
}
