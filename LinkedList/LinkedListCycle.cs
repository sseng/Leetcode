using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.LinkedList
{
    //141. Linked List Cycle - easy
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head) 
        {
            var walker = head;
            var runner = head;        

            while (runner != null && runner.Next != null)
            {
                walker = walker.Next;
                runner = runner.Next.Next;
                
                if (walker == runner){
                    return true;
                }
            }
            return false;
        }

        //Input: head = [3,2,0,-4], pos = 1
        //Output: true
        public ListNode Example1()
        {
            var node3 = new ListNode(-4, null);
            var node2 = new ListNode(0, node3);
            var node1 = new ListNode(2, node2);
            var node0 = new ListNode(3, node1);
            node3.Next = node1;
            return node0;
        }
    }
}