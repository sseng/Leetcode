using System.Collections.Generic;

namespace LeetCode.Interval
{
    public class InsertInterval
    {
        // Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
        // Output: [[1,2],[3,10],[12,16]]
        public int[][] Insert(int[][] intervals, int[] newInterval) 
        {
            var result = new List<int[]>();

            for(int i = 0; i < intervals.Length; i++)
            {
                var start = intervals[i][0];
                var end = intervals[i][1];
                
                //before overlaps
                if (end < newInterval[0])
                {
                    result.Add(intervals[i]);
                }//after overlaps
                else if (start > newInterval[1])
                {
                    result.Add(newInterval);
                    newInterval = intervals[i];
                }//overlaps
                else
                {
                    newInterval[0] = start < newInterval[0] ? start : newInterval[0];
                    newInterval[1] = end > newInterval[1] ? end : newInterval[1];
                }
            }
            //after overlaps
            result.Add(newInterval);
            return result.ToArray();
        }
    }
}