using System;

namespace LeetCode.Tree
{

    //124. Binary Tree Maximum Path Sum - Hard
    public class BinaryTreeMaxPathSum
    {
        int max = int.MinValue;
        public int MaxPathSum(TreeNode root){
            PathSum(root);
            return max;
        }

        public int PathSum(TreeNode root){
            if (root == null) return 0;

            int left = Math.Max(0, PathSum(root.left));
            int right = Math.Max(0, PathSum(root.right));
            max = Math.Max(max, left + right + root.val);
            return Math.Max(left, right) + root.val;
        }
    }
}