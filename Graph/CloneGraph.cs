using System.Collections.Generic;

namespace LeetCode.Graph
{
    public class CloneGraph133
    {
        Dictionary<int, Node> map = new Dictionary<int, Node>();
        public Node CloneGraph(Node node) 
        {
            if(node == null) 
                return null;
            //var map = new Dictionary<int, Node>();
            return CloneGraphs(node);
        }

        public Node CloneGraphs(Node node)
        {
            if(map.ContainsKey(node.val))
                return map[node.val];
            Node clone = new Node(node.val);
            map.Add(node.val, clone);

            foreach(var n in node.neighbors)
            {
                clone.neighbors.Add(CloneGraphs(n));
            }
            return clone;
        }
    }

    public class Node {
        public int val;
        public IList<Node> neighbors;

        public Node() {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val) {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors) {
            val = _val;
            neighbors = _neighbors;
        }
    }
}