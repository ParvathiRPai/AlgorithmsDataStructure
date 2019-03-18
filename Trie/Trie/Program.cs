using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 1,0 };
            ArrangeOnesandZeros a = new ArrangeOnesandZeros();
            a.Sort(arr);
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
                Console.ReadKey();
            }
        }
    }
}
