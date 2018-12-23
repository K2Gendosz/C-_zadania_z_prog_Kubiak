using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    class Program
    {
        //section 4 - tables
        
        static void Main(string[] args)
        {
            //task4_1();
            //task4_2();
            //task4_3();
            //task4_4();
            //task4_5();
            //task4_6();
            //task4_7();
            task4_8();
        }

        static void task4_1()
        {
            //print 10x10 table with 1 fom left to right dioagonal
            int[,] table = new int[10,10];
            int crossSum = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i==j)
                    {
                        table[i, j] = 1;
                        crossSum += table[i, j];
                    }
                    else
                    {
                        table[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   Console.Write($"{table[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum of the diagonal fields = {crossSum}");
        }

        static void task4_2()
        {
            //print 10x10 table with iteration on dioagonal
            int[,] table = new int[10, 10];
            int diagonalSum = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        table[i, j] = i;
                        diagonalSum += table[i, j];
                    }
                    else
                    {
                        table[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   Console.Write($"{table[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum of the diagonal fields = {diagonalSum}");
        }

        static void task4_3()
        {
            //print 10x10 table with 1 fom right to left dioagonal
            int[,] table = new int[10, 10];
            int diagonalSum = 0,k=9;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == k)
                    { table[i, j] = 1; diagonalSum += table[i, j]; }
                    else
                    { table[i, j] = 0; }
                }
                k--;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{table[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum of the diagonal fields = {diagonalSum}");
        }

        static void task4_4()
        {
            //print 10x10 table with 1 fom right to left dioagonal
            int[,] table = new int[10, 10];
            int diagonalSum = 0, k = 9;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == k)
                    { table[i, j] = i; diagonalSum += table[i, j]; }
                    else
                    { table[i, j] = 0; }
                }
                k--;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{table[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum of the diagonal fields = {diagonalSum}");
        }

        static void task4_5()
        {
            //print 10x10 table 
            //in first column is i value
            //in second column is square of i
            // and the sum of both columns
            int[,] table = new int[10, 10];
            int sumColumnOne = 0, sumColumnTwo = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j == 0)
                    { table[i, j] = i; sumColumnOne += table[i, j]; }
                    else if(j==1)
                    { table[i, j] = (i * i); sumColumnTwo += table[i, j]; }
                    else
                    { table[i, j] = 0; }
                }
            }   

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{table[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum of first column = {sumColumnOne}");
            Console.WriteLine($"Sum of second column = {sumColumnTwo}");

        }

        static void task4_6()
        {
            //swaping columns from tabel A with rows from table B
            int[,] tableA = new int[10, 10];
            int[,] tableB = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tableA[i, j] = j;
                }
            }
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tableB[i, j] = tableA[j, i];
                }
            }
            Console.WriteLine("Table A : \n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{tableA[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Table B : \n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{tableB[i, j]} ");
                }
                Console.WriteLine();
            }


        }

        static void task4_7()
        {
            //operations on lists
            //creating an list object
            List<int> s = new List<int>();
            //adding six elements
            s.Add(19);
            s.Add(124);
            s.Add(2);
            s.Add(34);
            s.Add(7);
            s.Add(53);
             Console.Write("Non sort list : ");
            for (int i = 0; i < s.Count; i++)
            {
                Console.Write($"{s[i]} ");
            }
            Console.WriteLine();
            s.Sort();
            Console.Write("Sorted list : ");
            for (int i = 0; i < s.Count; i++)
            {
                Console.Write($"{s[i]} ");
            }
            Console.WriteLine();
            //removing number from 2 position
            s.RemoveAt(1);
          
            Console.Write("List without second position : ");
            for (int i = 0; i < s.Count; i++)
            {
                Console.Write($"{s[i]} ");
            }
            Console.WriteLine();
            s.Add(123456);
            Console.Write("List with new value : ");
            for (int i = 0; i < s.Count; i++)
            {
                Console.Write($"{s[i]} ");
            }
            Console.WriteLine();
        }

        static void task4_8()
        {
            List<string> list = new List<string>();
            list.Add("Adam");
            list.Add("Tom");
            list.Add("John");
            list.Add("Inigo");
            list.Add("Eva");
            list.Add("Jack");

            Console.Write("Non sorted list : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
            list.Sort();
            Console.Write("Sorted list : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
        }

     }


}




