using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0; //we increment this when we find a prime number
            int counter = 1; // we use this to go through the natural numbers
            int nth = 10001; //set this to the nth prime you want to find..e.g if you want the 2nd prime, set this to 2, if you want the 6th prime, set this to 6
            while(x < nth)
            {
                counter++;
                bool is_prime = IsPrime(counter);
                if( is_prime == true)
                {
                    x++;
                }
                
            }

            Console.WriteLine("The "+nth+"th prime is " + counter);// the output here might sound like wrong english, for values like 1st 2nd, 32nd and those numbers, but this was not the primary objective of the question
            Console.ReadLine();
        }


        //this method returns true if a number is a prime. Ref -> http://www.dotnetperls.com/prime
        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }



    }
}
