
// Source : https://leetcode.com/problems/remove-duplicates-from-sorted-list/
// Author : Vitor França
// Date   : Mar 25, 2024

/********************************************************************************** 
* 
* Given a sorted linked list, delete all duplicates such that each element appear only once.
* 
* For example,
* Given 1->1->2, return 1->2.
* Given 1->1->2->3->3, return 1->2->3.
*                
**********************************************************************************/

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
        var pointer = head;

        while (!(pointer is null))
        {
            if (!(pointer.next is null))
            {
                var aux = pointer.next;
                while (aux != null && pointer.val == aux.val)
                {
                    aux = aux.next;
                    pointer.next = aux;
                }

            }
            pointer = pointer.next;
        }


        return head;

    }
}