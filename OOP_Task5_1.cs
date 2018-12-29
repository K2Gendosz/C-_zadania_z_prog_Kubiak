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
            Console.WriteLine("Welcom in rectangle area calculator.");
            float sideA, sideB;
            while (true)
            {
                Console.Write("Enter the value of side A : ");
                if (float.TryParse(Console.ReadLine(),out sideA))
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
                Console.Write("Enter the value of side B : ");
                if (float.TryParse(Console.ReadLine(), out sideB))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong value .");
                }
            }

            Rectangle rectangle = new Rectangle();
            rectangle.readData(sideA, sideB);
            rectangle.calculateArea();
            rectangle.printResult();
        } 
    }

    class Rectangle
    {
       protected float sideA, sideB, area;

      public void readData(float sideA, float sideB)
       {
            this.sideA = sideA;
            this.sideB = sideB;
       }

        public void calculateArea()
        {
            area = (float)sideA * (float)sideB;
        }

        public void printResult()
        {
            Console.WriteLine($"Rectangle area with sides A = {sideA:#.##} and B = {sideB:#.##} is equal to {area:#.##}");
        }

    }
}