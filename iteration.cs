using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    class Program
    {
        //00112233445566778899
        
        static void Main(string[] args)
        {
            int a = 0;
            for (int i = 1; i < 21; i++)
            {
                
                Console.Write(a);
                if (i%2==0)
                    {
                        a++;
                    }
            }
            Console.WriteLine();
        }
        
          
    }


}




