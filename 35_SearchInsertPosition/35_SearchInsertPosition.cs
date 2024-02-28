// Source : https://leetcode.com/problems/search-insert-position/
// Author : Vitor França
// Date   : Feb 26, 2024

/********************************************************************************** 
* 
* Given a sorted array and a target value, return the index if the target is found. 
* If not, return the index where it would be if it were inserted in order.
* 
* You may assume no duplicates in the array.
* 
* Here are few examples.
* [1,3,5,6], 5 → 2
* [1,3,5,6], 2 → 1
* [1,3,5,6], 7 → 4
* [1,3,5,6], 0 → 0
*               
**********************************************************************************/
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int min = 0, max = nums.Length - 1;

        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] > target) max = mid - 1;
            else min = mid + 1;
        }

        return min;  
    }
}