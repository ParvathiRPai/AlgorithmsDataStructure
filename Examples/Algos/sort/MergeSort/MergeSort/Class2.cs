using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Class2
    {
        public static string PrintArray(int[] input)
        {
            string result = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result = result + input[i] + " ";
            }
            if (input.Length == 0)
            {
                result = "Array is empty.";
                return result;
            }
            else
            {
                return result;
            }
        }
    }
