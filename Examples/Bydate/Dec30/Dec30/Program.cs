using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node n = new Node(8);
            //n.left = new Node(3);
            //n.right = new Node(10);
            //n.left.left = new Node(1);
            //n.left.right = new Node(6);
            //Problem1 p = new Problem1();
            //string res = p.TreeToArray(n);

            //int[] arr = { 3,4,-1,0,6,2,3};
            //problem3 p = new problem3();
            //int res=p.LongestIncresingSubsequence(arr);

            //MS1 m = new MS1();
            //int[] arr = { 2, 7, 11, 15 };
            //int target = 9;
            //int []res=m.GetTarget(arr, target);
            //NodeLL n = new NodeLL(2);
            //n.next = new NodeLL(4);
            //n.next.next = new NodeLL(3);

            //NodeLL m = new NodeLL(5);
            //m.next = new NodeLL(6);
            //m.next.next = new NodeLL(4);

            //MS2 p = new MS2();
            //NodeLL res = p.AddLL(n, m);

            int[] num1 = { 1, 2 };
            int[] num2 = { 3,4 };
            MS3 m = new MS3();
            float res=m.FindMedian(num1, num2);

        }
    }
}
