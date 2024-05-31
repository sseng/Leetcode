using System;
using System.Collections.Generic;

namespace LeetCode.Tree
{
    //102. Binary Tree Level Order Traversal - Medium
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            value = val;
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
                Console.Write(node.value + " ");
                listNode.Add(node.value);

                if (node.left != null)
                    q.Enqueue(node.left);

                if (node.right != null)
                    q.Enqueue(node.right);
            }
            return listNode;
        }
    
        public TreeNode Insert(TreeNode root, int v)
        {
            if (root == null)
            {
                root = new TreeNode(v);
            }
            else if (v < root.value)
            {
                root.left = Insert(root.left, v);
            }
            else
            {
                root.right = Insert(root.right, v);
            }

            return root;
        }

        public void Traverse(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Traverse(node.left);
            Traverse(node.right);
        }    
    }
}