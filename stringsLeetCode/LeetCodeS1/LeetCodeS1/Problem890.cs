using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeS1
{
    class Problem890
    {
        //normally would declare these in function
        //scoped here to avoid dictionary memory allocation penalty
        private Dictionary<char, char> permutations = new Dictionary<char, char>();
        private Dictionary<char, char> permLookup = new Dictionary<char, char>();

        public bool Match(string word, string pattern)
        {
            permutations.Clear();
            permLookup.Clear();
            for (int i = 0; i < word.Length; i++)
            {
                if (permutations.ContainsKey(word[i]))
                {
                    if (pattern[i] != permutations[word[i]]) return false;
                }
                else
                {
                    if (permLookup.ContainsKey(pattern[i]))
                    {
                        if (word[i] != permLookup[pattern[i]]) return false;
                    }
                    permutations.Add(word[i], pattern[i]);
                    permLookup.Add(pattern[i], word[i]);
                }
            }
            return true;
        }

        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            return (from word in words where Match(word, pattern) select word).ToList();
        }
    }
}
