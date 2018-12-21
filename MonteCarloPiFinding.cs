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
            int r,points,inCircle=0;
            Console.Write("Please insert a 'r' value : ");

            Random rand = new Random();
            

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out r))
                { break; }
                else
                {
                    Console.Write("Wrong operand.Please try one more time : ");
                }
                
            }
            Console.Write("How many points you want :  ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out points))
                { break; }
                else
                {
                    Console.Write("Wrong operand.Please try one more time : ");
                }

            }
            for (int i = 0; i < points; i++)
            {
              int XValueOfRand = rand.Next(0,r+1);
              int YValueOfRand = rand.Next(0, r + 1);

              

                double lenght = (Math.Sqrt( ((XValueOfRand* XValueOfRand) + (YValueOfRand* YValueOfRand)) ) );
                if (lenght<=(double)r)
                {
                    inCircle++;
                }
               
            }

            double pi=4.0*((double)inCircle/(double)points);

            Console.WriteLine(inCircle);

            Console.WriteLine($"Pi = {pi}");

        }
        
          
    }


}




