using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Anagrams
    {
        public void GetAnagrams(string []words)
        {
            List<string> word = new List<string>();
            List<string> result = new List<string>();
            foreach(string s in words)
            {
                word.Add(s);
            }
            for(int i=0; i <word.Count;i++)
            {
                for(int j=i+1;j<word.Count;j++)
                {
                    bool res = isAnagram(word[i], word[j]);
                    if (res = true)
                    {
                        Console.WriteLine(word[j]);
                    }

                }
            }
        }
        public bool isAnagram(string word1, string word2)
        {
            List<char> l = new List<char>();
            foreach(char c in word1)
            {
                l.Add(c);
            }
            foreach(char c in word2)
            {
                if(!l.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
