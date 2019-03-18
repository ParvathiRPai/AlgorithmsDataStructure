using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec31
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "babad";
            //MS1 m = new MS1();
            //string res = m.longestPalindrome(s);

            // string s = "-42";
            // MS2 m = new MS2();
            //long res= m.SToI(s);

            //string s = "VIII";
            // MS3 n = new MS3();
            //n.RomanToInt(s);

            //MS4 m = new MS4();
            //int[] arr = { -1, 0, 1, 2, -1, -4 };
            //List<List<int>> l=m.ThreeSum(arr);

            //SortColors s = new SortColors();
            //int[] arr = { 2, 0, 2, 1, 1, 0 };
            //int []arr1=s.Sort(arr);

            //validParenthesis v = new validParenthesis();
            //string s = "{ ]";
            //bool res=v.IsValid1(s);

            NodeLL n = new NodeLL(1);
            n.next = new NodeLL(2);
            n.next.next = new NodeLL(3);
            n.next.next.next = new NodeLL(4);
            n.next.next.next.next = new NodeLL(5);
            //NodeLL m = new NodeLL(1);
            //m.next = new NodeLL(3);
            //m.next.next = new NodeLL(4);

            //NodeLL[] l = { n, m };
            //MS6 p = new MS6();

            //MS7 m = new MS7();
            //NodeLL l=m.SwapPairs(n);

            //MS8 m = new MS8();
            //NodeLL res=m.ReverseKPairs(n, 2);

            //MS9 m1 = new MS9();
            //int[] arr = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //int l = m1.RemoveDuplicates(arr);

            //string hay = "hello";
            //string needle = "ll";
            //MS10 m = new MS10();
            //int res=m.StrStr(hay, needle);

            //MS11 m = new MS11();
            //int[] arr = { 4, 5, 1, 2, 3 };
            //int res=m.Search(arr, 3);


            //MS12 p = new MS12();
            //int[] arr = { 1, 1, 3 };
            //List<List<int>> p2=p.Permutation(arr);

            //MS13 m = new MS13();
            //string s = "my name is parvathi";
            //string res=m.Rotate(s);

            //Trie o = new Trie();
            //string s = "leet";
            //o.Insert(s);
            //bool res1 = o.Search(s);
            //bool res2 = o.StartsWith("lee");

            char[,] board = { { 'o', 'a', 'a', 'n' },{'e','t','a','e' },
  { 'i','h','k','r'},
  { 'i','f','l','v' }
    };
            string[] words = { "oath", "pea", "eat", "rain" };
            TrieWordSearch t = new TrieWordSearch();
            List<string> res=t.FindWords(board, words);

        }
    }
}
