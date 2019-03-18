using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Problem1
    {
        public int GetRatings(int []ratings)
        {
            int n = ratings.Length;
            int[] candies = new int[n];
            for(int i=0; i<ratings.Length;i++)
            {
                candies[i]=1;
            }
            for(int i=1; i<n;i++)
            {
                if(ratings[i]>ratings[i-1])
                {
                    candies[i] = candies[i-1] + 1;
                }
            }
            int sum = 0;
            for(int i=ratings.Length-2;i>=0;i--)
            {
                if(ratings[i] > ratings[i+1])
                {
                    candies[i] = candies[i + 1] + 1;
                }
                
            }
            for (int i = 0; i < candies.Length; i++)
            {
                sum = sum + candies[i];
            }
            return sum;
        }
    }
}
