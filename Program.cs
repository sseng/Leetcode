using System;
using System.Collections.Generic;
using System.Diagnostics;
using LeetCode.Array;
using LeetCode.Binary;
using LeetCode.Graph;
using LeetCode.Interval;
using LeetCode.LinkedList;
using LeetCode.Matrix;
using LeetCode.Tree;

namespace projects
{
    class Program
    {
        static void Main(string[] args)
        {
            var abc = new Palindrome();
            abc.Test(11);
            
        }

        public static void RunTwoSums()
        {
            var nums = new int[]{ 2, 7, 11, 15 };            
            var target = 9;
            var twosum = new TwoSum(nums, target);

            Console.WriteLine($"Nums = [{String.Join(", ", nums)}]");
            Console.WriteLine($"Target = {target}");

            Stopwatch sw = new();

            sw.Start();
            var a = twosum.BruteForce();
            sw.Stop();
            Console.WriteLine($"BruteForce = [{a[0]}, {a[1]}] runtime = {sw.ElapsedMilliseconds}ms");

            sw.Start();
            var b = twosum.TwoPassHashMap();
            sw.Stop();
            Console.WriteLine($"TwoPassHashMap = [{b[0]}, {b[1]}] runtime = {sw.ElapsedMilliseconds}ms");

            sw.Start();
            var c = twosum.OnePassHashMap();
            sw.Stop();
            Console.WriteLine($"OnePassHashMap = [{c[0]}, {c[1]}] runtime = {sw.ElapsedMilliseconds}ms");
        }
        public static void RunSumOfTwoInt()
        {
            int a = 1;
            int b = 2;
            var sumOfTwo = new SumOfTwoIntegers(a, b);
        }
        public static void RunCloneGraph()
        {
            var nodes = new List<Node>()
            {
                new Node(1),
                new Node(2),
                new Node(3),
                new Node(4)
            };

            nodes[0].neighbors.Add(nodes[1]);
            nodes[0].neighbors.Add(nodes[3]);
            nodes[1].neighbors.Add(nodes[0]);
            nodes[1].neighbors.Add(nodes[2]);
            nodes[2].neighbors.Add(nodes[1]);
            nodes[2].neighbors.Add(nodes[3]);
            nodes[3].neighbors.Add(nodes[0]);
            nodes[3].neighbors.Add(nodes[2]);

            CloneGraph133 cg = new CloneGraph133();
            foreach(var node in nodes)
            {
                cg.CloneGraph(node);
                Console.WriteLine($"{node.val} [{node.neighbors[0].val}, {node.neighbors[1].val}]");
            }
        }
        public static void RunInsertIntervals()
        {
// You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi] represent the start and the end of the ith interval and intervals is sorted in ascending order by starti. You are also given an interval newInterval = [start, end] that represents the start and end of another interval.
// Insert newInterval into intervals such that intervals is still sorted in ascending order by starti and intervals still does not have any overlapping intervals (merge overlapping intervals if necessary).
// Return intervals after the insertion.
// Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
// Output: [[1,2],[3,10],[12,16]]
            var ii = new InsertInterval();
            var intervals = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 5 },
                new int[] { 6, 7 },
                new int[] { 8, 10 },
                new int[] { 12, 16 },
                new int[] { 18, 19}
            };
            

            var newInterval = new int[] { 4,8 };

            var result = ii.Insert(intervals, newInterval);
            foreach(var r in result)
            {
                Console.WriteLine($"{r[0]}, {r[1]}");
            }
        }
        public static void RunMatrixSetZeroes(){
            var problem = new MatrixSetZeroes();
            var ex = problem.example2();
            problem.SetZeroes(ex);
            string array = "";
            for (int i = 0; i < ex.Length; i++){
                array += string.Join(", ", ex[i]);
                array += System.Environment.NewLine;
            }
            Console.WriteLine(array);
        }

        public static void RunBinarySearch(int target){
            int[] numbers = {1, 2, 3, 4, 5, 6, 7 };
            int index = Array.BinarySearch(numbers, target);
            Console.WriteLine($"The number {target} is {index} ");
        }
    }
}
