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
            // for (){}
            // zadanie3_1();
            //zadanie3_4();
            //zadanie3_7();
            //zadanie3_10();
            zadanie3_13();
            //-----------------------------
            // do{}while()
            // zadanie3_2();
            //zadanie3_5();
            //zadanie3_8();
            //zadanie3_11();
            zadanie3_14();
            //-----------------------------
            //while(){}
            //zadanie3_3();
            //zadanie3_6();
            //zadanie3_9();
            //zadanie3_12();
            zadanie3_15();
            //-----------------------------
        }



        static void zadanie3_1()
        {
            Console.WriteLine("oblaczanie wartości 2x^2-3 dla liczb od 0-10 ");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"2x^2-3 dla x == {i} = {(2 * (i * i)) - 3} ");
            }
        }

       static void zadanie3_2()
        {
            Console.WriteLine("oblaczanie wartości 2x^2-3 dla liczb od 0-10 ");
            int i = 0;
            do { Console.WriteLine($"2x^2-3 dla x == {i} = {(2 * (i * i)) - 3} "); i++; }
            while (i <= 10);
        }

        static void zadanie3_3()
        {
            Console.WriteLine("oblaczanie wartości 2x^2-3 dla liczb od 0-10 ");
            int i = 0;
            while (i <= 10)
            { Console.WriteLine($"2x^2-3 dla x == {i} = {(2 * (i * i)) - 3} "); i++; }
            
        }

        static void zadanie3_4()
        {
            Console.WriteLine("wypisywanie liczb z zakresu 1-20 ");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(" {0} ",i);
            }
        }

        static void zadanie3_5()
        {
            Console.WriteLine("wypisywanie liczb z zakresu 1-20 ");
            int i = 1;
            do { Console.Write(" {0} ",i);i++; } while (i<21);
        }

        static void zadanie3_6()
        {
            Console.WriteLine("wypisywanie liczb z zakresu 1-20 ");
            int i = 1;
             while (i < 21){ Console.Write(" {0} ", i); i++; } 
        }

        static void zadanie3_7()
        {
            Console.WriteLine("sumowanie liczb z zakresu 1-100");
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{suma}  {i}");
                suma += i;
                
            }
            Console.WriteLine($"suma liczb 1-100 = {suma}");
        }

        static void zadanie3_8()
        {
            int i = 1,suma=0;
            do
            {
                Console.WriteLine($"{suma}  {i}");
                suma += i;
                i++;
            }
            while (i<=100);
            Console.WriteLine($"suma liczb 1-100 = {suma}");
        }

        static void zadanie3_9()
        {
            double sumaCiagu = ((1.0 + 100.0) / 2) * 100;
            int i = 1, suma = 0;
            while (suma!=sumaCiagu)
            {
                Console.WriteLine($"{suma}  {i}");
                suma += i;
                i++;
            }
            
            Console.WriteLine($"suma liczb 1-100 = {suma}");
        }


        static void zadanie3_10()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{suma}  {i}");
                if (i%2==0) { suma += i; }
                

            }
            Console.WriteLine($"suma liczb parzystych 1-100 = {suma}");

        }

        static void zadanie3_11()
        {
            int suma = 0;
            int counter = 0;
            do
            { suma += counter;
                Console.WriteLine($"{suma}  {counter}");
                counter += 2;
            }
            while (counter<=100);
            Console.WriteLine($"suma liczb parzystych 1-100 = {suma}");
        }

        static void zadanie3_12()
        {
            int suma = 0, counter = 0;
            while (counter <= 100)
            {
                if (counter % 2 == 0)
                { suma += counter; }
                counter+=2;
            }
            Console.WriteLine($"suma liczb parzystych 1-100 = {suma}");
        }
        static void zadanie3_13()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{suma}  {i}");
                if (i % 2 != 0) { suma += i; }


            }
            Console.WriteLine($"suma liczb nie parzystych 1-100 = {suma}");

        }

        static void zadanie3_14()
        {
            int suma = 0;
            int counter = 1;
            do
            {
                suma += counter;
                Console.WriteLine($"{suma}  {counter}");
                counter += 2;
            }
            while (counter <= 100);
            Console.WriteLine($"suma liczb nie parzystych 1-100 = {suma}");
        }

        static void zadanie3_15()
        {
            int suma = 0, counter = 0;
            while (counter <= 100)
            {
                if (counter % 2 == 0)
                { suma += counter; }
                counter += 2;
            }
            Console.WriteLine($"suma liczb nie parzystych 1-100 = {suma}");
        }
    }

}


