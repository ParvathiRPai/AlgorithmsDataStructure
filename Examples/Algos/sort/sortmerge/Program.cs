using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortmerge
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort ms = new MergeSort();
            ms.SortArray(0, ms.data.Length - 1);
            ms.Display();
            Console.Read();
        }
    }
}
