using System;
using System.Collections.Generic;

namespace LeetCode.Tree
{
    public class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q) 
        {
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (p.val == q.val)
            {              
                var left = IsSameTree(p.left, q.left);
                var right = IsSameTree(p.right, q.right);
                
                return left && right;
            }
            return false;
        }

        public List<TreeNode> example1()
        {    
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);

            var p = new TreeNode(1, node2, node3);
            var q = new TreeNode(1, node2, node3);
            return new List<TreeNode>(){ p, q };
        }

        public void RunProblem()
        {
            var example = example1();
            var result = IsSameTree(example[0], example[1]);
            Console.WriteLine(result.ToString());
        }
    }
}