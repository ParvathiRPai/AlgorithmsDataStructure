using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree1
{
    class PrintKDistance
    {
        public void PrintNodeKdistance(Node start, int k)
        {
            if(start==null)
            {
                return;
            }
            if(k==0)
            {
                Console.WriteLine(start.data);
            }
            else
            {
                PrintNodeKdistance(start.left, k - 1);
                PrintNodeKdistance(start.right, k - 1);
            }
        }
     
    }
}
