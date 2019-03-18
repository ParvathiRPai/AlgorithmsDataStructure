using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr3 = { 5, 3, 1, 7, 2, 9 };
            quicksort q = new quicksort();

            q.Quick(arr3,0,arr3.Length-1);
        //    int[] arr = { 1, 2, 3, 4, 5 };
        //    int[] arr1 = { 4, 6, 8, 9, 1, 5, 10, 11 };
        //    SplitArray s = new SplitArray();
        //    s.Split(arr1);
        //    GetOneCycle g = new GetOneCycle();
        //    int[] result = g.OneCycle(arr);
        //    for(int i=0;i<result.Length;i++)
        //    {
        //        Console.WriteLine(result[i]);
        //        Console.ReadKey();
        //    }
        //}
    }
}
