using System;
using System.Collections.Generic;

namespace PermutationofPalin
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "TACO CAT";

            

        }
        bool palindrome(string input)
        {
            int odd = 0;
            var map = new Dictionary<char, int>();
            foreach( char c in input)
            {
                if(map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map[c] = 1;
                }
            }
            foreach (var key in map)
            {
                if (map[key] % 2 == 0)
                {


                }
                else
                {
                    odd++;
                }
            }
            if(odd>2)
            { return false;
            }
            else
            {
                return true;
            }

            }

        }
    }

