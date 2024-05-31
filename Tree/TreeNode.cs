using System;
using System.Collections.Generic;

namespace LeetCode.Tree
{
    //102. Binary Tree Level Order Traversal - Medium
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public List<int> BreadthFirstSearchToList(TreeNode node)
        {
            var listNode = new List<int>();
            var q = new Queue<TreeNode>();
            q.Enqueue(node);

            while (q.Count > 0)
            {
                node = q.Dequeue();
                Console.Write(node.val + " ");
                listNode.Add(node.val);

                if (node.left != null)
                    q.Enqueue(node.left);

                if (node.right != null)
                    q.Enqueue(node.right);
            }
            return listNode;
        }
    }
}