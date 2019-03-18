using System;

namespace FindMinelement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 1, 2, 3, 4 };
            Findminelesortedarr min = new Findminelesortedarr();
            int min1 = min.FindMin(arr,0,arr.Length-1);
            Console.WriteLine(min1);
            Console.ReadKey();
        }
    }
}
