using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution S = new Solution();
            //int[] num = { 100, 4, 200, 1, 3, 2 };
            //int count=S.LongestConsecutive(num);

            //int[] nums = { 2, 7, 11, 15 };
            //MSP2 m = new MSP2();
            //m.FindTarget(nums, 9);

            //int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //MP4 p = new MP4();
            //int max=p.GetMAxSum(arr);

            //int[] arr = { -1, 0, 1, 2, -1, -4 };
            //MS11 p = new MS11();
            //List<List<int>> res = p.ThreeSum(arr);

            //MS16 m = new MS16();
            //int[] arr = { 10, 9, 2, 5, 3, 7, 101, 18 };

            //int min = m.LengthofLongest(arr);

            //MS17 m = new MS17();
            //string s = "leetcode";

            //string[] dic = { "leet", "code" };
            //HashSet<string> set = new HashSet<string>(dic);
            //bool res=m.wordBreak(s, set);

            //ms18 m = new ms18();
            //int[] arr = { 1, 2, 3 };
            //int target = 4;
            //int k=m.Combinations(arr, target);

            //ms19 m = new ms19();
            //int[] arr = { 1, 2, 3, 1 };
            //int max=m.MaxMoney(arr);

            //ms19 m = new ms19();
            //string s = "12";
            //int c = m.NumDecodings(s);

            //MS20 m = new MS20();
            //int[] arr = { 2, 3, 1, 1, 4 };
            //bool res = m.Jump(arr);


            //MS23 m = new MS23();
            //string source = "ADOBECODEBANC";
            //string pattern = "ABC";
            //string res = m.MinWindow(source,pattern);

            //string[] s = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //MS25 m = new MS25();
            //List<List<string>> res = m.GroupAnagrams(s);

            //MS26 m = new MS26();
            //string i = "([)]";
            //bool res = m.Parenthesis(i);

            //MS27 m = new MS27();
            //string s = "A man, a plan, a canal: Panama";
            // bool res=m.IsPalindrome(s);

            //MS28 m = new MS28();
            //string s = "aaa";
            //int count = m.Palindrome(s);

            List<Interval> intervals = new List<Interval> { new Interval(1, 3), new Interval(2,6),new Interval(8,10), new Interval(15,18)};
            //Interval newInterval = new Interval(2, 5);
            MS30 m = new MS30();
            List<Interval>res=m.Merge(intervals);



        }
    }
}
