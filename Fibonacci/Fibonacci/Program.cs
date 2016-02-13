using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long first_term = 1;    // we know the first term
            long second_term = 2;    // we know the second term
            long limit = 4000000;       // we know the limit

            List<long> even_terms = new List<long>(); //list to store even terms

            even_terms.Add(2);         //add 2 to the list since we already know it.  

            for( long next_f_term =3; next_f_term <= limit; next_f_term = (first_term + second_term))
            {

                //check if term is even and add it to the list
                if ( next_f_term%2 == 0)
                {
                    even_terms.Add(next_f_term);
                }
                
                //change the values of the first term and second term to calculate the next term                
                first_term = second_term;
                second_term = next_f_term;

            }
            //covert the list of even terms to an array
            long[] even_term_array = even_terms.ToArray();

            //go through the array and sum the even terms...

            long sum_of_even_terms = 0;
            foreach (long even_term in even_term_array)
            {
                 sum_of_even_terms += even_term;
            }

            Console.WriteLine(sum_of_even_terms);
            Console.ReadLine();
        }

        //return the next term in the sequence
        public static long next_term(long term_1, long term_2)
        {
            long next = term_1 + term_2;
            return next;
        }
    }
}
