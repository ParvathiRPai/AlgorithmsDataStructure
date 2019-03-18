using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 5;
            //WithoutConsecutiveOnes w = new WithoutConsecutiveOnes();
            //string outs = "";
            //w.CountStrings(n, outs, 0);

            //NonIncreasingOrder n = new NonIncreasingOrder();
            //int x = 3;
            //int[] arr = new int[x];
            //n.GetAllNumbers(x, arr, 0, 0);

            //IncreasingOrder i = new IncreasingOrder();
            //string outs = "";
            //i.Increasing(0, outs, 2);

            //SumofSubsets s = new SumofSubsets();
            //int[] set = { 2, 3 };
            //int sum = 0;
            //s.Sum(set, 0, set.Length-1, sum);

            //Solution s = new Solution();
            //ListNode n = new ListNode(-10);
            //n.next = new ListNode(-3);
            //n.next.next = new ListNode(0);
            //n.next.next.next = new ListNode(5);
            //n.next.next.next.next = new ListNode(9);
            //TreeNode nodes=s.SortedListtoBST(n);

            //MinCost m = new MinCost();
            //int [ ,] set = { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } };
            //int res=m.FindMinDistance(set, 2, 2);
            //Console.Write(res);

            int[] s = { 1, 3, 1 };
            Array.Sort(s);
            Subsets sub = new Subsets();
            List<int> set = new List<int>();
            sub.FindPowerSet(s, set, s.Length - 1);

        }
    }
}
