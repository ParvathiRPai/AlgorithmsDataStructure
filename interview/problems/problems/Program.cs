using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Node n = new Node(50);
            //n.left = new Node(30);
            //n.right = new Node(70);
            //n.left.left = new Node(20);
            //n.left.right = new Node(40);
            // n.right.left = new Node(60);
            //  n.right.right = new Node(80);
            //  Problem2 p = new Problem2();
            //  Sum s = new Sum();
            //  p.ModifyBST(n,s);
            //  p.Inorder(n);

            //DutchNationalFlagProblem d = new DutchNationalFlagProblem();
            //int[] arr = { 1, 0, 0, 1, 2, 1, 1, 2, 1 };
            // d.Sort(arr);
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.ReadKey();

            //int[] arr = { 1, 4, 45,
            //            6, 10, 8 };
            //Problem6 p = new Problem6();
            //p.GetPair(arr, 16);

            // int NA = -1;
            // int[] arr1 = { 1, 3, 4, 5,NA,
            //                NA, NA, NA };
            // int[] arr2 = { 2, 4, 6, 8 };
            // Problem8 p = new Problem8();
            //int[]arr= p.MergeSortedArrays(arr1, arr2);


            //Problem11 p1 = new Problem11();
            //int[] arr2 = { -2, -4, -6, -8 };
            //p1.LessThan(arr2, -5);
            //NodeLL n = new NodeLL(3);
            //n.next = new NodeLL(1);
            //n.next.next = new NodeLL(5);
            //n.next.next.next = new NodeLL(9);
            //n.next.next.next.next = new NodeLL(7);
            //n.next.next.next.next.next = new NodeLL(2);
            //n.next.next.next.next.next.next = new NodeLL(1);

            //NodeLL n1 = new NodeLL(4);
            //n1.next = new NodeLL(6);
            //n1.next.next = new NodeLL(7);
            //n1.next.next.next = new NodeLL(2);
            //n1.next.next.next.next = new NodeLL(1);

            //PointofIntersection p = new PointofIntersection();
            //p.GetDifferece(n, n1);

            //NodeLL n = new NodeLL(12);
            //n.next = new NodeLL(11);
            //n.next.next = new NodeLL(12);
            //n.next.next.next = new NodeLL(21);
            //n.next.next.next.next = new NodeLL(41);
            //n.next.next.next.next.next = new NodeLL(41);

            //RemoveDuplicates d = new RemoveDuplicates();
            //d.Remove(n);
            //DetectCycle d = new DetectCycle();
            //NodeLL n1 = d.GetMiddle(n);

            //QueueUsingStack q = new QueueUsingStack();
            //q.Queueusingstack(n);

            //FindMissingElements f = new FindMissingElements();
            //  int [] arr1 = { 1, 2, 3, 4, 5, 10 };
            //int[] arr2 = { 2, 3, 1, 0, 5 };
            //List<int> res=f.FindMissingElement(arr1, arr2);

            //string str1 = "babad";
            //LongestPalindromeSubstring p = new LongestPalindromeSubstring();
            //p.LongestPalindrome(str1);

            //string str = "paypalishiring";
            //printZig p = new printZig();
            //p.myAtoi("1234");

            //int[] arr = { 7, 3, 2, 4, 9, 12, 56 };
            //ChocolateDistributionProblem c = new ChocolateDistributionProblem();
            //int res=c.DistributionProblem(arr, 3);

            //int[] arr = { 1, 0, 2 };
            //Problem1 p = new Problem1();
            //int res=p.GetRatings(arr);

            //Problem5 p = new Problem5();
            //int []arr= { 100, 180, 260, 310, 40, 535, 695 };
            //p.stockBuySell(arr, arr.Length);

            //SumofPairs p = new SumofPairs();
            //int[] arr = {1, 4, 45,
            //            6, 10, 8};
            //p.Pairs(arr, 16);

            //Problem13 p = new Problem13();
            //string start = "TOON";
            //string target = "PLEA";
            //string[] dic = { "POON", "PLEE", "SAME", "POIE", "PLEA", "PLIE", "POIN" };
            //p.ShortesChain(start, target, dic);


            //Node n = new Node(1);
            //n.left = new Node(2);
            //n.right = new Node(3);
            //n.left.left = new Node(4);
            //n.left.right = new Node(5);
            //Problem17 p = new Problem17();
            //p.BFS(n);

            int[] arr = { 6,7,1,2,3,4,5};
            Problem20 p = new Problem20();
           int res= p.FindPivot(arr);
        }
    }
}
