﻿using System;
using System.Collections.Generic;
using System.Text;

namespace March5
{
    class Problem2
    {
        public List<List<int>> ThreeSum(int []arr)
        {
            var result = new List<List<int>>();
            Array.Sort(arr);
            int n = arr.Length;
            for (int i = 0; i < n - 2; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1])
                    continue;
                int left = i + 1;
                int right = n - 1;
                while (left < right)
                {
                    int sum = arr[i] + arr[left] + arr[right];
                    if (sum < 0) left++;
                    if (sum > 0) right--;
                    else if (sum == 0)
                    {
                        result.Add(new List<int> { arr[i], arr[left], arr[right] });
                        while (left < right && arr[left] == arr[left + 1]) left++;
                        while (left < right && arr[right] == arr[right - 1]) right--;
                        left++;
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
