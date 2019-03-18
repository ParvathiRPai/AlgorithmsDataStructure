using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikedLeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 2, 11, 15,7 };
            //int target = 9;
            //Problem1 p = new Problem1();
            //int [] r=p.EqualToTarget(arr, target);

            //string s = "abcabcbb";
            //LongestSubString longest = new LongestSubString();
            //int res=longest.Longest(s);
            //Console.WriteLine(res);

            //int[] arr1 = { 1, 2 };
            //int[] arr2 = { 3,4 };
            //FindMedian f = new FindMedian();
            //double result = f.GetMedian(arr1, arr2);
            //int[] result = f.Merge(arr1, arr2);
            //for (int i=0; i< result.Length;i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            //string s="pqbabad";
            //PalindromeSubstring p = new PalindromeSubstring();
            //string res=p.Palindromestring(s);
            //Console.WriteLine(res);

            //string s = "a**b***c";
            //WildCard w = new WildCard();
            //string result = w.ReplacePattern(s);

            //Tree t = new Tree();
            //Node node = new Node(-10);
            //node.left = new Node(9);
            //node.right = new Node(20);

            //node.right.left = new Node(15);
            //node.right.right = new Node(7);
            //int result=t.SumofPaths(node);

            //WordBreak w = new WordBreak();
            //string s = "leetcode";
            //HashSet<string> set = new HashSet<string>();
            //set.Add("leet");
            //set.Add("code");
            //bool res=w.IsWordBreak(s, set);

            //PalindromeSubstringCount p = new PalindromeSubstringCount();
            //string s="abc";
            //int res=p.GetPalindromeStringCount(s);

            PrintLengthOfUnSortedArray p = new PrintLengthOfUnSortedArray();
            int[] arr = { 10, 12, 20, 30, 25, 40, 32, 31, 35, 50, 60 };
            p.PrintUnsortedIndeces(arr);

        }

    }
}
