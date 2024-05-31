using System.Collections.Generic;
using LeetCode.Library;

namespace LeetCode.LinkedList
{

    //206. Reverse Linked List - Easy
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode newHead = null;
            while (head != null)
            {
                ListNode next = head.Next;
                head.Next = newHead;
                newHead = head;
                head = next;
            }
            return newHead;
        }

        public ListNode ReverseListRecursive(ListNode head){
            if (head == null)
                return null;
            ListNode newHead = head;
            if (head.Next != null)
            {
                newHead = ReverseListRecursive(head.Next);
                head.Next.Next = head;
            }
            head.Next = null;
            return newHead;
        }
    }
}