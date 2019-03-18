using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "aple";
            SortLinkedList s = new SortLinkedList();
            int[] arr = { 1, 2, 3, 3, 2, 1, 5 };
            s.MostFrequent(arr);

        }
    }
}
