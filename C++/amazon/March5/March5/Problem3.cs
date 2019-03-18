using System;
using System.Collections.Generic;
using System.Text;

namespace March5
{
    class Problem3
    {
        public int Sum3Closest(int []arr, int target)
        {
            int sum = Int32.MaxValue;
            int n = arr.Length;
            int res = Int32.MaxValue;
            Array.Sort(arr);
            for(int i=0; i<n-2;i++)
            {
                if (i > 0 && arr[i] == arr[i - 1])
                    continue;
                int left = i + 1;
                int right = n - 1;
                while (left < right)
                {
                    int temp = arr[i] + arr[left] + arr[right];
                    res = target - temp;
                    if (sum > temp && res < temp )
                        sum = temp;
                    while (temp < target)
                    {
                        left++;
                    }

                    while (temp > target)
                    {
                        right--;
                    }
                    if (temp == target)
                        sum = temp;
                }
            }
                return sum;
        }
    }
}
