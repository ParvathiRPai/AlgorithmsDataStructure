using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class Problem916
    {
        //public List<string> IsPresent(string[] s, string[] b)
        //{
        //    int[] bmax = count("");
        //    foreach(string bs in b)
        //    {
        //        int[] bcout = count(bs);
        //        for(int i=0; i<26;i++)
        //        {
        //            bmax[i] = Math.Max(bmax[i], bcout[i]);
        //        }

        //    }
        //    List<string> ans = new List<string>();
        //   foreach(string ss in s)
        //    {
        //        int[] countS = count(ss);
        //        for(int i=0; i < 26;i++)
        //        {
        //            if(countS[i] <bmax[i])

        //                continue;

        //            ans.Add(ss);
        //        }

        //    }
        //    return ans;
        //}
        //public int[] count(string s)
        //{
        //    int[] ans = new int[26];
        //    foreach(char ch in s.ToCharArray())
        //    {
        //        ans[ch - 'a']++;
        //    }
        //    return ans;
        //}

        public List<string> IsPresent(string[] A, string[] B)
        {
            List<string> res = new List<string>();
            string b = string.Join("", B);
            char[] chB = b.ToCharArray();
            int count = 0;
            foreach (string s in A)
            {
                char[] ch = s.ToCharArray();
                for (int i = 0; i < chB.Length; i++)
                {
                    for (int j = 0; j < ch.Length; j++)
                    {
                        if (chB[i] == ch[j])
                        {
                            bool[] Present = new bool[27];

                            Present[ch[j] - 'a'] = true ;

                            if (Present[j]==true)
                            {
                                count++;
                            }
                        }


                    }
                }
                if (count == chB.Length - 1)
                {
                    res.Add(s);
                }

            }
            return res;
        }
        public bool IfPresent(char ch)
        {
            List<char> res = new List<char>();
            if (!res.Contains(ch))
            {
                res.Add(ch);
                return true;
            }
            return false;
        }
    }
}
