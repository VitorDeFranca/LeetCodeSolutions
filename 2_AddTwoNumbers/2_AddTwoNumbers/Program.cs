﻿public class ListNode
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
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