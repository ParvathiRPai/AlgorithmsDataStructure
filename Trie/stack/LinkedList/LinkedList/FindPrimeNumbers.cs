using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class FindPrimeNumbers
    {
        public void GetPrimeNumbers(int N)
        {
            bool isPrime = true; 
            for (int i=2; i< N; i++)
            {
                for (int j=2; j < N; j++)
                {
                    if( i != j && i%j ==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
            
        }
    }
}
