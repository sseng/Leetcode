using System;
using System.Collections.Generic;

namespace LeetCode.Tree
{
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root){
            
            var result = new List<IList<int>>();
            if (root == null) return result;
            
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                var list = new List<int>();

                for (int i = 0; i < size; i++)
                {
                    root = queue.Dequeue();
                    list.Add(root.val);
                    if (root.left != null)
                        queue.Enqueue(root.left);

                    if (root.right != null)
                        queue.Enqueue(root.right);

                }
                result.Add(list);
            }
            return result;
        }

        public TreeNode Example1(){
            var node20 = new TreeNode(20, new TreeNode(15), new TreeNode(7));
            var node3 = new TreeNode(3, new TreeNode(9), node20);
            return node3;
        }

        public void RunProblem(){
            var node = Example1();
            var result = LevelOrder(node);
            foreach(List<int> r in result)
            {
                Console.WriteLine(r.ToString());
                foreach(var n in r){
                    Console.WriteLine(n);
                }
            }
        }
    }
}