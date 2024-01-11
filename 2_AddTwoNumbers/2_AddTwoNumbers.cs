// Source : https://leetcode.com/problems/add-two-numbers/
// Author : Vitor França
// Date   : Dec 18, 2023

/********************************************************************************** 
* 
* You are given two linked lists representing two non-negative numbers. 
* The digits are stored in reverse order and each of their nodes contain a single digit. 
* Add the two numbers and return it as a linked list.
* 
* Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
* Output: 7 -> 0 -> 8
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode startl3 = new ListNode(0);
        var pointer = startl3;
        int currentValue = 0;

        while (l1 != null || l2 != null)
        {
            currentValue = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + currentValue;
            pointer.next = new ListNode(currentValue % 10);
            pointer = pointer.next;
            currentValue = currentValue / 10;

            l1 = l1?.next;         
            l2 = l2?.next;         
        }

        if (currentValue != 0)
        {
            pointer.next = new ListNode(currentValue);
        }

        return startl3.next;
    }
}