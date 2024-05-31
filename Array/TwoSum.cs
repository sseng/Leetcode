using System.Collections.Generic;

namespace LeetCode.Array
{
    public class TwoSum 
    {
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    // You can return the answer in any order.
        private int[] nums;
        private int target;
        
        public TwoSum(int[] numArray, int t)
        {
            nums = numArray;
            target = t;
        }

        public int[] BruteForce()
        {
            for (int i = 0; i < nums.Length; i++) 
            {
                for (int j = i + 1; j < nums.Length; j++) 
                {
                    if (nums[j] == target - nums[i]) 
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        public int[] TwoPassHashMap()
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                map.Add(nums[i], i);
            }
            for (int i = 0; i < nums.Length; i++) 
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && map[complement] != i) 
                {
                    return new int[] { i, map[complement] };
                }
            }
            return null;
        }

        public int[] OnePassHashMap()
        {
            Dictionary<int, int> map = new();
            for (int i = 0; i < nums.Length; i++) 
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement)) 
                {
                    return new int[] { map[complement], i };
                }
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }
            return null;
        }
    }
}