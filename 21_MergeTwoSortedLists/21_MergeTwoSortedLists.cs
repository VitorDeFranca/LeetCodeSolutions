// Source : https://leetcode.com/problems/merge-two-sorted-lists/
// Author : Vitor França
// Date   : Jan 4, 2024

/********************************************************************************** 
* 
* Merge two sorted linked lists and return it as a new list. The new list should be 
* made by splicing together the nodes of the first two lists.
*               
**********************************************************************************/
/*
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
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
}