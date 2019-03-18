using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 0, 3, 12 };
            MoveZeroToEnd m = new MoveZeroToEnd();
            int []res=m.ZeroEnd(arr);
        }
    }
}
