using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Problem11
    {
        public bool isBST(Node root)
        {
            if (root == null)
                return true;
            var val = root.data;
            if (root.left != null && val < root.left.data || root.right != null && val > root.right.data)
                return false;
            return isBST(root.left) && isBST(root.right);
        }
        public int count = 0;
        public int result = 0;
        public int KSmallest(Node root, int k)
        {
            count = k;
            Inorder(root);
            return result;

        }
        public void Inorder(Node root)
        {
            if (root == null)
                return;
            Inorder(root.left);
            count--;
            if(count==0)
            {
                result = root.data;
                return;
            }
            Inorder(root.right);
        }
        public void QuickSort(int []arr, int low, int high)
        {
            int pivot = Sort(arr, low, high);
            if(arr[low]<pivot)
            {
                QuickSort(arr, low, pivot);
            }
            else
            {
                QuickSort(arr, pivot, high);
            }
        }
        public int Sort(int []arr, int low, int high)
        {
            int mid = (low + high) / 2;
            while (low<high)
            {
                
                while (arr[low] < arr[mid]) low++;
                while (arr[high] > arr[mid]) high--;
                if(high<low)
                {
                    int temp = arr[low];
                    arr[low] = arr[high];
                    arr[high] = temp;
                    low++;
                    high--;
                }

            }
            return low;
        }
        public int MinCoins(int []coins, int total)
        {
            return CoinChange(0, coins, total);
        }
        public int CoinChange(int index, int []coins, int total)
        {
            if (total == 0)
                return 0;
            if(index < 0 && total >0)
            {
                int max = total / coins[index];
                int minCoins = int.MaxValue;
                for(int x=0;x<max;x++)
                {
                    if(total>x*coins[index])
                    {
                        int res = CoinChange(index + 1, coins, total - x);

                        minCoins = Math.Min(min, res);
                            }
                }
            }
        }
    }
}
