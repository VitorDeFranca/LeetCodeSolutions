// Source : https://leetcode.com/problems/two-sum/
// Author : Vitor França
// Date   : Dec 13, 2023

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

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int firstNum = 0;
        while (firstNum <= nums.Length - 1)
        {
            for (int i = firstNum + 1; i < nums.Length; i++)
            {
                if (nums[firstNum] + nums[i] == target){

                    return new int[2] {firstNum, i};
                }
            }
            firstNum++;
        }
        return new int[0];
    }
}