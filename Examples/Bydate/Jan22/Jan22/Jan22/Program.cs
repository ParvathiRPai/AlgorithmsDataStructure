using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack s = new Stack();
            //s.Push(1);
            //s.Push(2);
            //s.Push(3);
            //int data = s.Pop();

            //int[] arr = {1,2,3,1 };
            ////Problem1 p = new Problem1();
            ////int[] res=p.Sum(arr,9);

            //Problem4 p2 = new Problem4();
            //int res= p2.FindPeak(arr);

            NodeBB n = new NodeBB(7);
            n.left = new NodeBB(3);
            n.right = new NodeBB(15);
            n.right.left = new NodeBB(9);
            n.right.right = new NodeBB(20);

            Problem5 p = new Problem5();
            p.BSTIterator(n);
            bool res = p.Hasnext();
            if (res == true)
            {
                int res1 = p.Next();
                Console.WriteLine(res1);
            }
            else
            {
                Console.WriteLine("false");
            }
            
        }
    }
}
