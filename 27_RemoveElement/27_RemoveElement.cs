// Source : https://leetcode.com/problems/remove-element/
// Author : Vitor França
// Date   : Feb 21, 2024

/********************************************************************************** 
* 
* Given an array and a value, remove all instances of that value in place and return the new length.
* 
* The order of elements can be changed. It doesn't matter what you leave beyond the new length. 
*               
**********************************************************************************/
public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        StringBuilder sb = new StringBuilder();
        int count = 0;

        foreach (int num in nums)
        {
            if (num != val)
            {
                sb.Append((char)num);
                count++;
            }
        }

        for (int i = 0; i < sb.Length; i++)
        {
            nums[i] = sb[i];
        }

        return count;
    }
}