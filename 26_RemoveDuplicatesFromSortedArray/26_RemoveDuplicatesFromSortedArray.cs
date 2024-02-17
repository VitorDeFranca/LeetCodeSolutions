// Source : https://leetcode.com/problems/remove-duplicates-from-sorted-array/
// Author : Vitor França
// Date   : Feb 16, 2024

/********************************************************************************** 
* 
* Given a sorted array, remove the duplicates in place such that each element appear 
* only once and return the new length.
* 
* Do not allocate extra space for another array, you must do this in place with constant memory.
* 
* For example,
* Given input array A = [1,1,2],
* 
* Your function should return length = 2, and A is now [1,2].
* 
*               
**********************************************************************************/
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 1) return 1;
        
        int k = 1;
        var pointer1 = 0;
        var pointer2 = 1;

        if (nums.Length == 2 && nums[pointer1] != nums[pointer2]) return 2;

        while (pointer2 < nums.Length)
        {
            if (nums[pointer1] != nums[pointer2])
            {
                k++;
                pointer1++;
                pointer2++;
            }
            else
            {

                while (pointer2 < nums.Length && nums[pointer2] == nums[pointer1])
                {
                    pointer2++;
                }
                if (pointer2 < nums.Length)
                {
                    nums[pointer1 + 1] = nums[pointer2];
                    k++;
                    pointer1++;
                }
            }
        }
        return k;
    }
}