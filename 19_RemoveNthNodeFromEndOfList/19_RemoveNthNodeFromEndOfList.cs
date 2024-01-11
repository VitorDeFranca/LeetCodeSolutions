// Source : https://leetcode.com/problems/remove-nth-node-from-end-of-list/
// Author : Vitor França
// Date   : Jan 10, 2024

/********************************************************************************** 
* 
* Given a linked list, remove the nth node from the end of list and return its head.
* 
* For example,
* 
*    Given linked list: 1->2->3->4->5, and n = 2.
* 
*    After removing the second node from the end, the linked list becomes 1->2->3->5.
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
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