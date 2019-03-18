using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a=new int[] { 1, 2, 3, 4, 1, 1, 1, 1 };
            int count = 0;
            int element = 0;
            for(int i=0;i<a.Length;i++)
            {
                int tempelement = a[i];
                int tempcount = 0;
                for (int p = 0; p < a.Length; p++)
                {
                    if (a[p] == tempelement)
                    {
                        tempcount++;
                    }
                    if (tempcount > count)
                    {
                        count = tempcount;
                        element = tempelement;
                    }
                }
                
            }
            Console.WriteLine("elem" +element);
            Console.WriteLine("count"+count);
            Console.ReadKey();
           
            

        }
    }
}
