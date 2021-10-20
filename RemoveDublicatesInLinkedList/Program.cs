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
    
    public class Solution {
        public ListNode DeleteDuplicates(ListNode head)
        {

            var dummyNode = new ListNode(0) {next = head};

            var prev = dummyNode;

            while (head!=null)
            {
                head = head.next;
            }

            return dummyNode.next;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}