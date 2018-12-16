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
            //zadanie3_19();
            //zadanie3_22();
            //zadanie3_25();
            zadanie3_28();
            //-----------------------------
            // do{}while()
            //zadanie3_17();
            //zadanie3_20();
            //zadanie3_23();
            //zadanie3_26();
            //-----------------------------
            //while(){}
            //zadanie3_18();
            //zadanie3_21();
            //zadanie3_24();
            //zadanie3_27();
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
                if (int.TryParse(Console.ReadLine(), out num)) { break; }
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
            int num, min, max, counter = 0;
            int[] tab;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out num)) { break; }
                else { Console.Write("Wrong operand.Please try one more time : "); }
            }
            tab = new int[num];
            Random rand = new Random();
            while (counter < tab.Length)
            {
                tab[counter] = rand.Next(1, 100);
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
            Console.WriteLine("multiplication table 1 - 10 ");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j} \t");
                }
                Console.WriteLine();
            }
        }

        //-----------------------------
        static void zadanie3_20()
        {
            Console.WriteLine("multiplication table 1 - 10 ");
            int a = 1, b = 1;
            do
            {
                b = 1;
                do
                {
                    Console.Write($"{a * b} \t");
                    b++;
                } while (b <= 10);
                Console.WriteLine();
                a++;
            } while (a <= 10);
        }

        //-----------------------------
        static void zadanie3_21()
        {
            Console.WriteLine("multiplication table 1 - 10 ");
            int a = 1, b = 1;
            while (a <= 10)
            {
                b = 1;
                while (b <= 10)
                {
                    Console.Write($"{a * b} \t");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
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

        static void zadanie3_23()
        {
            char i = 'A';
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i <='Z');
            Console.WriteLine();

            do
            {
                i--;
                Console.Write($"{i} ");
                
            } while (i>'A');

        }

        static void zadanie3_24()
        {
            char i = 'A';
            bool rev = false;
            while (true)
            {
                Console.Write($"{i} ");

                if (rev == false)
                { i++; }
                if (rev == true)
                { i--; }
                if (i > 'Z')
                { rev = true;i--; Console.WriteLine(); }
                else if (i < 'A'&&rev==true)
                { break; }
            }
            Console.WriteLine();
        }

        static void zadanie3_25()
        {
            Console.WriteLine("We known that 12^2+33^2=1233.");
            Console.WriteLine("How many similar numbers are in 1000-9999");
            int numbers = 0;
            for (int i = 1000; i < 10000; i++)
            {
                int a = i / 100;
                int b = i % 100;
                if ((a*a)+(b*b)==i)
                {
                    numbers++;
                    Console.WriteLine($"{a}^2 + {b}^2 = {i}");
                }
                

            }
            Console.WriteLine($"Found {numbers} numbers.");
        }
        
        static void zadanie3_26()
        {
            int numbs = 0;
            int number = 1000;
            Console.WriteLine("We known that 12^2+33^2=1233.");
            Console.WriteLine("How many similar numbers are in 1000-9999");
            do
            {
                double a = number / 100;
                double b = number % 100;
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == number)
                {
                    Console.WriteLine($"{a}^2+{b}^2=={number}");
                    numbs++;
                }

                    number++;
            } while (number < 10000);
            Console.WriteLine($"The program has found {numbs} numbers ");
        }

        static void zadanie3_27()
        {
            int numbs = 0;
            int number = 1000;
            Console.WriteLine("We known that 12^2+33^2=1233.");
            Console.WriteLine("How many similar numbers are in 1000-9999");
            while(number<10000)
            {
                double a = number / 100;
                double b = number % 100;
                if (Math.Pow(a,2)+Math.Pow(b,2)==number)
                {
                    Console.WriteLine($"{a}^2+{b}^2=={number}");
                    numbs++;
                }

                    number++;
            }
            Console.WriteLine($"The program has found {numbs} numbers ");
        }

        static void zadanie3_28()
        {
            Console.WriteLine("We known that 990^2+100^2=990100.");
            Console.WriteLine("How many similar numbers are in 100000-999999");
            int numbs = 0;
            for (int i = 100000 ; i < 999999; i++)
            {
                int a = i / 1000;
                int b = i % 1000;
                if ((a*a)+(b*b)==i)
                {
                    Console.WriteLine($"{a}^2+{b}^2=={i}");
                    numbs++;
                }
               
            }
            Console.WriteLine($"The program has found {numbs} numbers ");
        }
    }
}

