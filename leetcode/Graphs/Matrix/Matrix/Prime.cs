using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Prime
    {
        public bool IsPrime(int N)
        {
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void GenerateAllPrime(int N)
        {

            bool[] prime = new bool[N];
            for (int i = 0; i < N; i++)
            {
                prime[i] = true;
            }
            for (int i = 2; i < N; i++)
            {
                if(prime[i]==true)
                {
                    for(int m =i*i;m<N;m+=i)
                    {
                        prime[m] = false;
                    }
                }
            }


            for (int i = 0; i < N; i++)
            {
                if (prime[i] == true)
                {
                    Console.WriteLine(i);
                }
            }


        }

        public void Fib(int N)
        {
            int a = 0;
            int b = 1;
            
            for(int i=1;i<N;i++)
            {
                int c = a + b;
                Console.Write(c);
                a = b;
                b = c;
            }
        }
    }
}
