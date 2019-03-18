using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions.Hashtable
{
    //This means IHashTable (and implementations of it) accept a type of TValue that is used for values stored in the hashtable, and also there are 2 constraints on TValue, that is: TValue is a class, and TValue has a default constructor - so you can call new on it.
    public interface IHashTable<TValue> where TValue : class, new()
    {
        //you can ideally have a key of any type TKey key, but then to use that in a hastable, you will need to write a "int Transform(TKey key)" private method to transform that input to an int, so you can use it as an index of the array that is used inside the hashtable. In this case, instead of writing the transform, we are just going to assume a int.
        TValue Get(int key);
        //also need a way to set a key-value (KV) pair. A hastable is essentially a collection (mathematical set) of KV pairs with O(1) access (since we use an array internally, and accessing a specific index of an array is O(1))
        void Set(int key, TValue value);
    }

    //copy over constraints from interface
    public class HashTable<TValue> : IHashTable<TValue> where TValue : class, new()
    {
        //the hashfunction 1 that maps an int to an index looks like:
        //hash(k) = RandomNumberA (random number in range 0-2^word_size-1) * k (int key in range 0-2^word_size-1) % word_size (32 bits) >> word_size - m
        //lets say we left shifted a computed number instead
        //lets say a bad application only generates even number keys, that means, the last digit of any product will always be 0. So the odd indexes of the array will never have any key mapping there, so half the array is unused. So we dont take the last m digits, because they are susceptible to patterns in input. A good hashfunction works great even if the input follows anby pattern (such as all even). SO we take the first m digits, which means we need right shift word_size - m, so that m is left over
        private const int LENGTH_EXP = 4;
        //"(int) float/double" casts that float/double to an int by dropping the decimal. So (int)2.8 becomes 2, not 3. Round is different from cast. 
        private static readonly uint ArrLength = Convert.ToUInt32((int)(Math.Pow(2, LENGTH_EXP)));
        private static readonly uint RandomNumberA = GetRandomNumberA();
        
        private static uint GetRandomNumberA()
        {
            //create a random number generator
            var randGen = new Random();
            //pick a signed integer in the 32-bit signed range (we could picked one in the unsigned range, but the random number generator does ntot support that, so we will transform it next
            int num = randGen.Next(Int32.MinValue, Int32.MaxValue);
            //now we have an unsigned int
            uint unsignedNum = Convert.ToUInt32(num);
            //we need to make sure this is not even, else we dont have a good multiplier
            while(unsignedNum % 2 == 0)
            {
                num = randGen.Next(Int32.MinValue, Int32.MaxValue);
                //now we have an unsigned int
                unsignedNum = Convert.ToUInt32(num);
            }

            return unsignedNum;
        }

        //now you need to decide whether you want to use chaining (preferred) or the open addressing (which required 2 different random numbers RandomNumberA and RandomNumberB. This is the chained approach.

            //this is your hash table array
        private IList<HashTableEntry<TValue>>[] _table = new List<HashTableEntry<TValue>>[ArrLength];

        public TValue Get(int key)
        {
            uint uKey = Convert.ToUInt32(key);
            var arrIndex = HashFunction(uKey);
            var matchingElement = _table[arrIndex].Where(x => x.Key == key).FirstOrDefault();
            if(matchingElement == null)
            {
                return null;
            }
            else
            {
                return matchingElement.Value;
            }
        }

        public void Set(int key, TValue value)
        {
            uint uKey = Convert.ToUInt32(key);
            var arrIndex = HashFunction(uKey);
            if (_table[arrIndex] == null)
            {
                _table[arrIndex] = new List<HashTableEntry<TValue>>();
            }

            var matchingElement = _table[arrIndex].Where(x => x.Key == key).FirstOrDefault();
            if(matchingElement == null)
            {
                //there was no element, create a new KV pair and add it to list
                var entry = new HashTableEntry<TValue>
                {
                    Key = key,
                    Value = value,
                };

                _table[arrIndex].Add(entry);
            }
            else
            {
                //entry with that key already exists, update value
                matchingElement.Value = value;
            }
        }

        //the hasfunction takes an int key and returns the index in a ArrLength (2^LENGTH_EXP) array
        private uint HashFunction(uint key)
        {
            //note that this can cause an integer overflow, but C# automatically truncates the higher order 32 bits, other languages might throw
            uint product = RandomNumberA * key;
            //now right shift the product to keep the higher order LENGTH_EXP digits, which are most random (the lower order will not random e.g. keys are all even, even though RandomNumberA is odd)
            return product >> (32 - LENGTH_EXP);
        }
    }

    // C# IDictionary implementations are all hashtables, the only difference being, the [] operator has been overload to automatically call Get, so dict[key] internally calls dict.Get(key), which has been implemented already. Also dict[key] = value, automatically calls dict.Set(key, value)
    //HashSet is a collection of keys, a mathematical set. A hashmap can be internally represented by a HashTable where the value is same as key. Dictionaries Map. HashSet are just sets.
    //Java HashMap and C# Dictionaries are the same.
    public class HashTableEntry<TValue>
    {
        public int Key { get; set; }
        public TValue Value { get; set; }
    }
}
