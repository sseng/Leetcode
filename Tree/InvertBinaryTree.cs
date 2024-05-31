using System;
using System.Collections.Generic;

namespace LeetCode.Tree
{
    //Given the root of a binary tree, invert the tree, and return its root.
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root) 
        {
            if (root != null)
            {
                var tmp = root.left;
                root.left = root.right;
                root.right = tmp;
                
                InvertTree(root.left);
                InvertTree(root.right);    
            }            
            return root;
        }

        public TreeNode Example1()
        {
            //Input: root = [4,2,7,1,3,6,9]
            //Output: [4,7,2,9,6,3,1]
            var node9 = new TreeNode(9);
            var node6 = new TreeNode(6);
            var node3 = new TreeNode(3);
            var node1 = new TreeNode(1);
            var node7 = new TreeNode(7, node6, node9);
            var node2 = new TreeNode(2, node1, node3);
            var node4 = new TreeNode(4, node2, node7);
            return node4;
        }

        public void RunProblem(){
            var example = Example1();
            InvertTree(example);
            
            var nodes = example.BreadthFirstSearchToList(example);
            Console.WriteLine();
        }
    }
}