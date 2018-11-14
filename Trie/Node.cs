using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    public class Node<TValue>
    {
        public const int CharCount = 256;
        //used for all off-line algorithms - algorithms where the entire input is known from the start (IP addesses etc.)
        public char TrieData { get; set; }
        public TValue FinalValue { get; set; }
        public Node<TValue>[] Children = new Node<TValue>[CharCount];
        //only use for trie-based prediction algorithms
        internal int Frequency { get; set; }
        internal IDictionary<int, int> FrequencySentenceCountMap = new Dictionary<int, int>();
    }

    public interface ITrie<TValue>
    {
        //same as add - but this is not an IList
        //Updates the trie using the new sentence
        void Feed(string input, TValue value);
        //gets all sentences that match the input, or uses prediction, if available 
        TValue Get(string input);
        bool UsePrediction { get; }
    }

    public class Trie<TValue> : ITrie<TValue>
    {
        private Node<TValue> _root = null;

        public bool UsePrediction => false;
             
        private IList<char> GetCharArr(string input)
        {
            var charArr = new List<char>();
            charArr.AddRange(input);
            charArr.InsertRange(0, new List<char>
            {
                ' ',
            });
            return charArr;
        }

        public void Feed(string input, TValue value)
        {
            input = input.Trim();
            var charArr = GetCharArr(input);
            if(_root == null)
            {
                _root = new Node<TValue>();
            }

            FeedAt(_root, charArr, value);
        }

        private static void FeedAt(Node<TValue> location, IList<char> arr, TValue value)
        {
            //arr should not be null
            if(arr.Count == 0)
            {
                return;
            }

            //location should not be null
            if (location == null)
            {
                location = new Node<TValue>
                {
                    TrieData = arr[0]
                };
            }
            else
            {
                //redundant update because this might have been done earlier by another sentence
                location.TrieData = arr[0];
            }

            //remove added element
            arr.RemoveAt(0);
            
            //if no more, set final value
            if(arr.Count == 0)
            {
                location.FinalValue = value;
                return;
            }

            //recurse for other chars in input
            int charIndex = (int)arr[0];
            if(location.Children[charIndex] == null)
            {
                location.Children[charIndex] = new Node<TValue>();
            }

            FeedAt(location.Children[charIndex], arr, value);
        }

        public TValue Get(string input)
        {
            var charArr = GetCharArr(input);
            return GetAt(_root, charArr);
        }

        private static TValue GetAt(Node<TValue> location, IList<char> charArr)
        {
            if (location == null)
            {
                return default(TValue);
            }

            if (charArr == null || charArr.Count == 0)
            {
                return default(TValue);
            }

            if (location.TrieData != charArr[0])
            {
                return default(TValue);
            }

            charArr.RemoveAt(0);

            if(charArr.Count == 0)
            {
                return location.FinalValue;
            }

            return GetAt(location.Children[(int)charArr[0]], charArr);
        }
    }
}
