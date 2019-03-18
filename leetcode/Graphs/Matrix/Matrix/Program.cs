using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrix = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
            //MS1 m = new MS1();
            //int [,]res=m.MatrixZero(matrix);

            //int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //MS2 m = new MS2();
            //IList<int> res = m.SpiralOrder(matrix);

            //S1 s = new S1();
            //int[] arr = { 1, 0, 2 };
            //int count = s.Candies(arr);

            //Node n = new Node(50);
            //n.left = new Node(30);
            //n.left.left = new Node(20);
            //n.left.right = new Node(40);
            //n.right = new Node(70);
            //n.right.left = new Node(60);
            //n.right.right = new Node(80);
            //S2 s = new S2();
            //Node start=s.GreaterTree(n);


            //int[] arr = { 3, 3, 5, 0, 0, 3, 1, 4 };
            //S3 s = new S3();
            //int p = s.MaxProfit3(arr,2);

            //int[] arr = { 2, 3, 6, 7 };
            //int target = 7;
            //S4 s = new S4();
            //List<List<int>> l = s.TargetSum(arr, target);

            //int [] arr = { 10, 12, 13, 14, 18,0,0,0,0,0};
            //int[] arr1 = { 16, 17, 19, 20, 22 };
            //S5 s = new S5();
            //int[] arr2 = s.Merge(arr, arr1);
            //int []res=s.sortedMerge(arr, arr1, 5, 5);

            //int[] arr = { 5, 6, 1, 2, 3 };
            //QuickSortcs q = new QuickSortcs();
            //q.QuickSort(arr, 0, arr.Length-1);

            //HeapSort h = new HeapSort();
            //int[] arr = { 8, 3, 1, 7, 0, 10, 2 };
            //int[] arr2 = h.HeapSort1(arr, arr.Length);

            //char[,] board = { { 'E', 'E', 'E', 'E', 'E' }, { 'E', 'E', 'M', 'E', 'E' }, { 'E', 'E', 'E', 'E', 'E' }, { 'E', 'E', 'E', 'E', 'E' } };
            //int[] click = { 3, 0 };
            //Solution g = new Solution();
            //char[,] res = g.UpdateBoard(board, click);

            //Prime p = new Prime();
            //p.GenerateAllPrime(11);


            // NodeLL n = new NodeLL(1);
            // n.next = new NodeLL(2);
            // n.next.next = new NodeLL(3);
            // n.next.next.next = new NodeLL(3);
            // n.next .next.next.next = new NodeLL(4);
            // n.next.next.next.next.next = new NodeLL(4);

            // S6 s = new S6();
            //s.RemoveDuplicates(n);
            // while(n!=null)
            // {
            //     Console.WriteLine(n.data);
            //     n = n.next;
            // }
            //string b = "hit";
            //string e = "cog";
            //IList<string> s = new List<string>{ "hot", "dot", "dog", "lot", "log", "cog" };
            //S7 s1 = new S7();
            //IList<IList<string>> res=s1.FindLadders(b, e, s);

            //string s = "this apple is sweet";
            //string l = "this apple is sour";
            //s9 p = new s9();

            //string str=p.Reverse("apple");
            //List<string> res = p.UnCommon(s, l);

            //string[] words = { "APPLE", "PEACH", "PEAR" };
            //string[] sentences = { "I Like Apple", "Would love to have Peaches", "I long for Pear" };
            //p.Common1(words, sentences);


            int[] arr = { 10, 11, 12 };
            int[] index = { 1, 0, 2 };
            s9 s = new s9();
            s.Sort(arr, index);
            //s.Sort(arr,index);
            //Regex rx = new Regex("apple");

            //// Define a test string.        
            //string text = "I Like apple";

            //// Find matches.
            //MatchCollection matches = rx.Matches(text);

            //Console.WriteLine("{0} matches found in:\n   {1}",matches.Count, text);

            //// Report the number of matches found.
            //Console.WriteLine("{0} matches found in:\n   {1}",
            //                  matches.Count,
            //                  text);

            //// Report on each match.
            //foreach (Match match in matches)
            //{
            //    GroupCollection groups = match.Groups;
            //    Console.WriteLine("'{0}' repeated at positions {1} and {2}",
            //                      groups["word"].Value,
            //                      groups[0].Index,
            //                      groups[1].Index);
            //}

            //int[] arr = { 4, 5, 6, 7,8, 0, 1, 2 };
            //S12 s = new S12();
            //int res=s.Pivot(arr);

        }
    }
}
