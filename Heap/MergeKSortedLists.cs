using LeetCode.Library;

namespace LeetCode.Heap
{
    //23. Merge k Sorted Lists
    public class MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            
            return null;
        }

        public void Merge(ListNode left, ListNode right){
            
        }

        public ListNode Example1(ListNode result){
            // var output = new int[] { 1, 1, 2, 3, 4, 4, 5, 6 };
            return new ListNode(1, new ListNode(
                                    1, new ListNode(
                                        2, new ListNode(
                                            3, new ListNode(
                                                4, new ListNode(
                                                    4, new ListNode(
                                                        5, new ListNode(
                                                            6)
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                    )
                                );
        }

        public ListNode[] Input1(){
            var list1 = new ListNode(1, new ListNode(4, new ListNode(5)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var list3 = new ListNode(2, new ListNode(6));
            return new ListNode[] {list1, list2, list3};
        }
    }
}