using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum =0;
            
            for (int i = 0; i < 1000; i++)
            {
                
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum); // write the result to the screen
            Console.ReadLine(); // to pause the application so you can see the output
        }
    }
}
