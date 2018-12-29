using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A program that calculates the value of an Ax^2+Bx+C=0 expression.");
            double Ax, Bx, C;
            while (true)
            {
                Console.Write("Enter the value of A : ");
                if (double.TryParse(Console.ReadLine(),out Ax))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong value .");
                }
            }

            while (true)
            {
                Console.Write("Enter the value of B : ");
                if (double.TryParse(Console.ReadLine(), out Bx))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong value .");
                }
            }
            while (true)
            {
                Console.Write("Enter the value of C : ");
                if (double.TryParse(Console.ReadLine(), out C))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong value .");
                }
            }

            ExpressionCalculator calculator = new ExpressionCalculator();

            calculator.readData(Ax,Bx,C);
            calculator.calculateTheElement();
            calculator.printResult();

            
        } 
    }

    class ExpressionCalculator
    {
        private double Ax, Bx, C, X1, X2, delta, elementsNumber;

        public void readData(double Ax, double Bx, double C)
        {
            this.Ax = Ax;
            this.Bx = Bx;
            this.C = C;
        }

        public void calculateTheElement()
        {
            
            delta = (Math.Pow(Bx, 2) - (4 * (Ax * C)));


            if (delta>0)
             { elementsNumber = 2; }
            else if (delta == 0)
             { elementsNumber = 1; }
            else
             { elementsNumber = 0; }

            switch (elementsNumber)
            {
                case 1:
                    X1 = -Bx / (2 * Ax);
                    break;
                case 2:
                    {
                        X1 = (-Bx - Math.Sqrt(delta)) / (2 * Ax);
                        X2 = (-Bx + Math.Sqrt(delta)) / (2 * Ax);
                    }
                    break;
                default:
                    break;
            }
        }

        public void printResult()
        {
            switch (elementsNumber)
            {
                case 1:
                    Console.WriteLine($"Delta equals to 0 there is only one root X = {X1:##.##}");
                    break;
                case 2:
                    Console.WriteLine($"There are two roots X1 = {X1:##.##} and X2 = {X2:##.##}");
                    break;
                default:
                    Console.WriteLine("There are no roots.The delta is smaller than 0. ");
                    break;
            }

        }

    }
    
}