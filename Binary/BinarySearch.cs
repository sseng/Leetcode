using System;
using LeetCode.Tree;

namespace LeetCode.Binary
{
    public class BinarySearch
    {
        public int BinarySearchArrayRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                return -1;
            }
            else
            {
                int mid = (min + max)/2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    return BinarySearchArrayRecursive(inputArray, key, min, mid - 1);
                }
                else 
                {
                    return BinarySearchArrayRecursive(inputArray, key, mid + 1, max);
                }
            }
        }

        public int BinarySearchArray(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while( min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
