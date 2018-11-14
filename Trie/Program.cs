using System;
using System.Collections.Generic;
using System.Linq;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestTrie();
            //TestPlanks();
        }

        public static void TestPlanks()
        {
            var plankLengths = new int[]
            {
                10, 5
            };

            var numPlanks = 3;
            var allTotals = new HashSet<int>();
            var sth = new Something();
            sth.FindAdditiveResultsWithDecisionsAndChoices(numPlanks, plankLengths, 0, allTotals);
            Console.WriteLine(string.Join(",", allTotals.Select(x => x.ToString())));
            Console.ReadLine();
        }

        public static void TestTrie()
        {
            //arrange
            var inputs = new Dictionary<string, int>
            {
                { "cat", 1 },
                { "coo", 2 },
                { "bat", 3 },
                { "boo", 4 }
            };

            //act
            var trie = new Trie<int>();
            trie.Feed("cat", inputs["cat"]);
            trie.Feed("coo", inputs["coo"]);
            trie.Feed("bat", inputs["bat"]);
            trie.Feed("boo", inputs["boo"]);
            var value = trie.Get("bat");

            //assert
            if(value == 3)
            {
                Console.WriteLine("success");
            }
            else
            {
                Console.WriteLine("failure");
            }

            Console.ReadLine();
        }
    }
}
