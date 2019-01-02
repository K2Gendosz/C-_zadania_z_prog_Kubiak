using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumV2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();

        }
        //Maj inglisz is gud :D 
        static void ShowMenu()
        {
            int choice = 0;

            Console.WriteLine("*********KOLOKWIUM V2*********");
            Console.WriteLine("1. Adding numbers with using the array.");
            Console.WriteLine("2. Magic numbers.");
            Console.WriteLine("0. Exit.");
            Console.Write("Choose a task :  ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(),out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            { AddingNumbers(); }
                            break;
                        case 2:
                            { MagicNumbers(); }
                            break;
                        case 0:
                            break;
                        default:
                            Console.Write("Almost good. Try one mor time : ");
                            continue;
                    }
                    break;
                }
                else
                {
                    Console.Write("Almost good. Try one mor time : ");
                }
            }
        }

        static void AddingNumbers()
        {
            int sizeOfArray = 0,sum=0;
            int[] array;

            Console.Write("Enter the size of Array. Must be between 2 and 50 : ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(),out sizeOfArray)&&sizeOfArray>=2&&sizeOfArray<=50)
                {
                    array = new int[sizeOfArray];
                    break;
                }
                else
                {
                    Console.Write("Almost good. Try one mor time btw( number of numbers :D): ");
                }
            }

            for (int i = 1; i <= array.Length; i++)
            {
                Console.Write($"Enter the {i} number : ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out array[i-1]))
                    { break; }
                    else
	                 {
                        Console.Write($"Almost good. Try one mor time {i} number : ");
                    }
                }

                if (i%2==0)
                {
                    sum += array[i-1];
                }
            }

            for (int i = 1; i <= array.Length; i++)
            {
                if (i%2==0)
                {
                    Console.Write($" {array[i-1]}* ");
                }
                else
                {
                    Console.Write($" {array[i-1]} ");
                }

            }
            Console.WriteLine();
            Console.WriteLine($"sum = {sum}");

        }


        static void MagicNumbers()
        {
            int numberOfSteps = 0;
            double result=1.0,step;
            Console.Write("Enter the number of steps. Must be between 1-100 : ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(),out numberOfSteps))
                {
                    break;
                }
                else
                {
                    Console.Write("Almost good try one mor time . Must be between 1-100 : ");
                }
            }

            for (int i = 1; i <= numberOfSteps; i++)
            {

                Console.WriteLine($"result == {result}");


                while (true)
                {
                    Console.Write($"Step {i} = ");
                    if (double.TryParse(Console.ReadLine(), out step))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Almost good. Try one mor time : ");
                    }
                }

                if (i % 2 != 0)
                {
                    result *= step;
                }
                else
                {
                    result /= step;
                }
            }
            Console.WriteLine($"result == {result}");
        }
       
    }
}
