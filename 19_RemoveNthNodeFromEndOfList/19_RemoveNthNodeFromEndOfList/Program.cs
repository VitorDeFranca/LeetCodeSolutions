using System;
using System.Net.NetworkInformation;

namespace _19_RemoveNthNodeFromEndOfList
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            var list1 = head;
            list1.next = new ListNode(2);
            list1 = list1.next;
            list1.next = new ListNode(3);
            list1 = list1.next;
            list1.next = new ListNode(4);
            list1 = list1.next;
            list1.next = new ListNode(5);
            list1 = list1.next;


            var res = RemoveNthFromEnd(head, 2);

            Console.ReadKey();

        }

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

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null || head.next == null)
                return null;

            int lenList = 0, currNodeIndex = 0;

            ListNode dummyHead = head;
            var pointer = dummyHead;

            while(pointer != null)
            {
                lenList++;
                pointer = pointer.next;
            }

            int nodeToBeRemovIndex = lenList - n;

            pointer = dummyHead;

            while(currNodeIndex < nodeToBeRemovIndex - 1)
            {
                pointer = pointer.next;
                currNodeIndex++;
            }
            
            if (nodeToBeRemovIndex == 0)
            {
                dummyHead = dummyHead.next;
                return dummyHead;
            }
            
            var nodeToBeRemov = pointer.next;
            pointer.next = nodeToBeRemov.next;

            return dummyHead;
        }
    }
}
