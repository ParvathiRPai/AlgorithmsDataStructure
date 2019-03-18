using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("length of array");
            int l = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for(int i=1;i<l;i++)
            {
                int value = arr[i];
                int hole = i;
                while(hole>0 &&arr[hole-1]>value)
                {
                    int temp = arr[hole];
                    arr[hole] = arr[hole - 1];
                    arr[hole - 1] = temp;
                    hole = hole - 1;
                    
                
                }
                arr[hole] = value;
            }
            for(int i=0;i<l;i++)
            {
                Console.WriteLine(arr[i]);
                
                   

            }
            Console.ReadKey();

        }
    }
}
