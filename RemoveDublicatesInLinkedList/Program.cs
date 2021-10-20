using System;

namespace RemoveDublicatesInLinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            var dummyNode = new ListNode(0) {next = head};

            var prev = dummyNode;

            while (head != null)
            {
                if (head.next != null && head.val == head.next.val)
                {
                    while (head.next != null && head.val == head.next.val)
                    {
                        head = head.next;
                    }

                    prev.next = head.next;
                }
                else
                {
                    prev = prev.next;
                }

                head = head.next;
            }

            return dummyNode.next;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //[1,2,3,3,4,4,5]
            var head = new ListNode(1,
                new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5)))))));
            var res = Solution.DeleteDuplicates(head);
            var curr = res;
            while (curr != null)
            {
                Console.WriteLine(curr.val);
                curr = curr.next;
            }
        }
    }
}