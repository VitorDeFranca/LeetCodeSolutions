using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MergeTwoSortedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(0);
            var pointer1 = list1;
            pointer1.val = 1;
            pointer1.next = new ListNode(0);
            pointer1 = pointer1.next;
            pointer1.val = 2;
            pointer1.next = new ListNode(0);
            pointer1 = pointer1.next;
            pointer1.val = 4;
            
            
            ListNode list2 = new ListNode(0);
            var pointer2 = list2;
            pointer2.val = 1;
            pointer2.next = new ListNode(0);
            pointer2 = pointer2.next;
            pointer2.val = 3;
            pointer2.next = new ListNode(0);
            pointer2 = pointer2.next;
            pointer2.val = 4;

            int num1 = 1;
            int num2 = 2;
            int res = num1.CompareTo(num2);

            MergeTwoLists(list1, list2);

            Console.ReadKey();
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null) return null;
            
            ListNode headOfList3 = new ListNode();
            var pointer = headOfList3;

            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    pointer.val = list2.val;
                    list2 = list2.next;
                    if (list2 != null)
                    {
                        pointer.next = new ListNode();
                        pointer = pointer.next;
                    }
                }
                else if (list2 == null)
                {
                    pointer.val = list1.val;
                    list1 = list1.next;
                    if (list1 != null)
                    {
                        pointer.next = new ListNode();
                        pointer = pointer.next;
                    }
                }
                else
                {

                    if (list1.val.CompareTo(list2.val) == 1)
                    {
                        pointer.val = list2.val;
                        list2 = list2.next;
                        pointer.next = new ListNode();
                        pointer = pointer.next;
                    } 
                    else
                    {
                        pointer.val = list1.val;
                        list1 = list1.next;
                        pointer.next = new ListNode();
                        pointer = pointer.next;
                    }
                }
            }

            return headOfList3;
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
    }
}
