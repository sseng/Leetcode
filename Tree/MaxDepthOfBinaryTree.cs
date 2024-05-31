using System;

namespace LeetCode.Tree
{

    public class MaxDepthOfBinaryTree
    {
        // 104. Maximum Depth of Binary Tree - easy
        public int MaxDepth(TreeNode root) 
        {
            if (root == null)
                return 0;
            
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            return Math.Max(left, right) + 1;
        }
    }
}