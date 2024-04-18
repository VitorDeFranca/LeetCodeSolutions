// Source : https://leetcode.com/problems/rotate-list/
// Author : Vitor França
// Date   : Apr 18, 2024

/********************************************************************************** 
* 
* Given a list, rotate the list to the right by k places, where k is non-negative.
* 
* For example:
* Given 1->2->3->4->5->NULL and k = 2,
* return 4->5->1->2->3->NULL.
*               
**********************************************************************************/
/**
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
    public ListNode RotateRight(ListNode head, int k) {

        if (head == null) return null;
        if (head.next == null || k == 0) return head;

        ListNode firstNode = head;
        ListNode previousNode = firstNode;
        ListNode node = previousNode.next;
        int numberOfNodes = 2;
        int numberOfSwaps;

        while (node.next != null)
        {
            numberOfNodes++;
            previousNode = node;
            node = node.next;
        }

        numberOfSwaps = k % numberOfNodes;

        if (numberOfSwaps == 0)
        {
            return head;
        }

        for (int i = 0; i < numberOfSwaps; i++)
        {
            while (node.next != null)
            {
                previousNode = node;
                node = node.next;
            }

            node.next = firstNode;
            previousNode.next = null;
            firstNode = node;

        }s
        return firstNode;
    }
}