using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    class Program
    {

        // basic operations on matrices

        static void Main(string[] args)
        {
            // matricesTask_1();
            // matricesTask_2();
            matricesTask_3();
        }

        //adding the matrices
         static void  matricesTask_1()
        {
            int[,] MatrixA = new int[10, 10];
            int[,] MatrixB = new int[10, 10];
            int[,] MatrixC = new int[10, 10];
            for (int i=0;i<10;i++)
            {
                for (int j = 0; j < 10; j++)
                { MatrixA[i, j] = 1;MatrixB[i, j] = 2; }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                { MatrixC[i, j] = MatrixA[i, j] + MatrixB[i, j]; }
            }
            for (int z = 0; z < 3; z++)
            {
                if (z == 0)
                { Console.WriteLine($"MatrixA : "); }
                else if (z == 1)
                { Console.WriteLine($"MatrixB : "); }

                else { Console.WriteLine($"MatrixC = MatrixA + MatrixB  "); }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (z==0)
                        { Console.Write($"{MatrixA[i,j]} "); }
                        else if (z == 1)
                        { Console.Write($"{MatrixB[i, j]} "); }

                        else  { Console.Write($"{MatrixC[i, j]} "); }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }

        //subtraction of the Matrices
        static void matricesTask_2()
        {
            int[,] MatrixA = new int[10, 10];
            int[,] MatrixB = new int[10, 10];
            int[,] MatrixC = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                { MatrixA[i, j] = 1; MatrixB[i, j] = 2; }       // adding values to Matrix
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                { MatrixC[i, j] = MatrixB[i, j] - MatrixA[i, j]; }    //subtraction
            } 
            for (int z = 0; z < 3; z++)
            {
                if (z == 0)
                { Console.WriteLine($"MatrixA : "); }
                else if (z == 1)
                { Console.WriteLine($"MatrixB : "); }

                else { Console.WriteLine($"MatrixC = MatrixB - MatrixA  "); }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (z == 0)
                        { Console.Write($"{MatrixA[i, j]} "); }
                        else if (z == 1)
                        { Console.Write($"{MatrixB[i, j]} "); }

                        else { Console.Write($"{MatrixC[i, j]} "); }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
        //multiplying
        static void matricesTask_3()
        {
            int[,] MatrixA = new int[10, 10];
            int[,] MatrixB = new int[10, 10];
            int[,] MatrixC = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                { MatrixA[i, j] = 1; MatrixB[i, j] = 2; }       // adding values to Matrix
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        MatrixC[i, j] += MatrixA[j, z] * MatrixB[z, j]; // multiplying 
                    }
                }       
            }
            for (int z = 0; z < 3; z++)                                 // printing matrices
            {
                if (z == 0)
                { Console.WriteLine($"MatrixA : "); }
                else if (z == 1)
                { Console.WriteLine($"MatrixB : "); }

                else { Console.WriteLine($"MatrixC = MatrixA * MatrixB  "); }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (z == 0)
                        { Console.Write($"{MatrixA[i, j]} "); }
                        else if (z == 1)
                        { Console.Write($"{MatrixB[i, j]} "); }

                        else { Console.Write($"{MatrixC[i, j]} "); }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

     }


}




