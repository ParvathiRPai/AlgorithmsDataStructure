using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem925 p = new Problem925();
            //string s1 = "alex";
            //string s2 = "aaeex";
            //bool res=p.IsMatch(s1, s2);
            //string s = "a-bc-def-ghij";
            //Problem917 p = new Problem917();
            //char [] c=p.Reverse(s);
            //string b = new string(c);
            //Console.WriteLine(b);

            //string[] inputA ={ "facebook", "google", "leetcode"};
            //string[] b = { "e", "o" };
            //Problem916 p = new Problem916();
            ////p.IsPresent(inputA, b);
            //string[] i = { "abcd", "cdab", "adcb", "cbad" };
            //Problem893 p = new Problem893();
            //int count =p.GetEquivalentStrings(i);

            //Problem890 p = new Problem890();
            //string[] s = { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
            //string pattern = "abb";
            //IList<string> l= p.FindAndReplacePattern(s, pattern);

            //Problem66 p = new Problem66();
            //int[] arr = { 9,9,9 };
            //int []arr1=p.AddPlusOne(arr);
            //Problem946 p = new Problem946();
            //int[] arr = { 3, 2, 1, 2, 1, 7 };
            //int res=p.Unique(arr);

            //pROBLEM926 p = new pROBLEM926();
            //string s = "00110";
            //List<string> expand=p.Expand(s);
            //List<string> xor = p.FindMinFlip(expand,s);
            //int min = p.GetMinOnes(xor);

            // RobDp r = new RobDp();
            // int[] arr = { 2, 7, 9, 3, 1 };
            //int res= r.Rob(arr);

            //stairsDp d = new stairsDp();
            //int n = 3;
            //int p=d.Stairs(n);

            //stock s = new stock();
            //int[] arr = { 7, 1, 5, 3, 6, 4 };
            //s.MaxProfit(arr);

            //int[] arr = { 1, 1, 2 };
            //BitwiseXor b = new BitwiseXor();
            //b.Xor(arr);

            //CatlanNumber c = new CatlanNumber();
            //int n=c.FindNumberofTrees(3);
            //CatlanExpansion c = new CatlanExpansion();
            //c.GenerateTrees(3);

            //List<List<int>> l = new List<List<int>> {
            //    new List<int>
            //    {
            //        2
            //    },
            //    new List<int>
            //    {
            //        3,4
            //    },
            //    new List<int>
            //    {
            //        6,5,7
            //    },
            //    new List<int>
            //    {
            //        4,1,8,3
            //    }
            //};
            //MinSum m = new MinSum();
            //int []res=m.FindMinSumOfTriangle(l);
            //int res1 = m.FindMinSum(res);

            //ProdSubArray p = new ProdSubArray();
            //int[] arr = { 2, 3, -1, 4 };
            //p.MaxProd(arr);

            //LongestFibanociiSequence l = new LongestFibanociiSequence();
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //l.LengthFib(arr);

            //DecodeString s = new DecodeString();
            //string s1 = "226";
            //char[] ch = s1.ToCharArray();
            //int n=s.Decode(s1);

            //Average a = new Average();
            //int[] arr = { 9, 1, 2, 3, 9 };
            //double a1 =a.largestSumOfAverages(arr, 3);

            //int[] arr1 = { 1, 2, 3, 2, 1 };
            //int[] arr2 = { 3, 2, 1, 4, 7 };
            //MaxLengthofSubArray m = new MaxLengthofSubArray();
            //int n=m.MaxLength(arr1, arr2);

            //int[] arr = { 1, 2, 3, 4 };
            //DifferentCombinations d = new DifferentCombinations();
            //d.PrintCombinations(arr, 2

            //BinaryRepresentaion b = new BinaryRepresentaion();
            //int[] arr = b.ReturnCollection(5);

            //NumberOfOperators n = new NumberOfOperators();
            //n.MakeTargetNumberDivisible(3, 19);


            //int[] arr1 = { 3, 4, 6, 5 };
            //int[] arr2 = { 9, 1, 2, 5, 8, 3 };
            //CreateMaximumNumber c = new CreateMaximumNumber();
            //int []res=c.CreateArray(arr1, arr2, 5);
            NodeLL n = new NodeLL(1);
            n.next = new NodeLL(2);
            n.next.next = new NodeLL(3);
            n.next.next.next = new NodeLL(4);
            SplitLinledListParts p = new SplitLinledListParts();
               int count = p.GetLength(n);
            List<List<NodeLL>> n1 = p.SplitLinkedList(n, count, 5);

        }
    }
}
