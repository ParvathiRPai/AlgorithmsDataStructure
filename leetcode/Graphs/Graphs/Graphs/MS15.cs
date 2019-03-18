using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class MS15
    {
        public int CoinChange(int []coins, int amount)
        {
            return CoinChange(coins, amount, 0);
        }
        public int CoinChange(int []coins, int amount, int index)
        {
            if (amount == 0)
                return 0; 
            if(index< coins.Length && amount >0)
            {
                int max = amount / coins[index];
                int min = Int32.MaxValue;
                for(int i=0; i<max;i++)
                {
                    int res = CoinChange(coins, amount - i * coins[index], index + 1);
                    if(res!=-1)
                    {
                        min = Math.Min(min, res + i);
                    }
                }
                return (min == Int32.MaxValue) ? -1 : min;
            }
            return -1;
        }

    }
}
