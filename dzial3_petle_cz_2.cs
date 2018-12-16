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
            //zadanie3_16();
            zadanie3_19();
            //zadanie3_22();
            //-----------------------------
            // do{}while()
            //zadanie3_17();
            //-----------------------------
            //while(){}
            //zadanie3_18();
            //-----------------------------

        }

        static void zadanie3_16()
        {
            Console.Write("How many number i have to draw : ");

            double avg = 0;
            int num = 0, min, max;
            int[] tab;
            for (int i = 0; i != 2;)
            {
                if (int.TryParse(Console.ReadLine(), out num)) {  break; }
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
                if (tab[i] < min) { min = tab[i]; }
                else if (tab[i] > max) { max = tab[i]; }
            }
            avg /= tab.Length;
            Console.WriteLine($"The min value == {min}, the max value == {max}, the avrage is {avg} ");
        }

        //-----------------------------


        static void zadanie3_17()
        {
            Console.Write("How many number i have to draw : ");
            double avg = 0;
            int num, min, max, counter = 0;
            int[] tab;
            do
            {
                if (int.TryParse(Console.ReadLine(), out num)) { break; }
                else { Console.Write("Wrong operand.Please try one more time : "); }
            } while (true);
            tab = new int[num];
            Random rand = new Random();
            do
            {
                tab[counter] = rand.Next(1, 100);
                avg += tab[counter];
                counter++;
            } while (counter < tab.Length);
            counter = 0;
            min = tab[0];
            max = tab[0];
            do
            {
                if (tab[counter] < min) { min = tab[counter]; }
                else if (tab[counter] > max) { max = tab[counter]; }
                counter++;
            } while (counter < tab.Length);
            avg /= tab.Length;
            Console.WriteLine($"The min value == {min}, the max value == {max}, the avrage is {avg} ");

        }

        //--------------------------------------------

        static void zadanie3_18()
        {
            Console.Write("How many number i have to draw : ");
            double avg = 0;
            int num, min, max,counter=0;
            int[] tab;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out num)) { break; }
                else { Console.Write("Wrong operand.Please try one more time : "); }
            }
            tab = new int[num];
            Random rand = new Random();
            while (counter<tab.Length)
            {
                tab[counter] = rand.Next(1,100);
                avg += tab[counter];
                counter++;
            }
            counter = 0;
            min = tab[0];
            max = tab[0];
            while (counter < tab.Length)
            {
                if (tab[counter] < min) { min = tab[counter]; }
                else if (tab[counter] > max) { max = tab[counter]; }
                counter++;
            }
            avg /= tab.Length;
            /*
            foreach (var item in tab)
            {
                Console.Write($"{item} ");
            }
            */
            Console.WriteLine($"The min value == {min}, the max value == {max}, the avrage is {avg} ");

        }

        //-----------------------------
        static void zadanie3_19()
        {
            // do skończenia :)

        }

        //-----------------------------

        static void zadanie3_22()
        {
            char x;
            for (int i = 65; i <= 90; i++)
            {
                x = Convert.ToChar(i);
                Console.Write($"{x} ");
            }
            Console.WriteLine("");
            for (int i = 90; i >= 65; i--)
            {
                x = Convert.ToChar(i);
                Console.Write($"{x} ");
            }
            Console.WriteLine("");

        }
    }
}




