// Source : https://leetcode.com/problems/sort-colors/
// Author : Vitor França
// Date   : May 24, 2024

/**********************************************************************************
*
* Given an array with n objects colored red, white or blue, sort them so that objects of
* the same color are adjacent, with the colors in the order red, white and blue.
*
* Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
*
**********************************************************************************/
public class Solution {
    public  void SortColors(int[] nums)
    {
        var numOf0s = 0;
        var numOf1s = 0;
        var numOf2s = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) numOf0s++;
            if (nums[i] == 1) numOf1s++;
            if (nums[i] == 2) numOf2s++;
        }

        var counter = 0;
        while (numOf0s > 0)
        {
            nums[counter] = 0;
            numOf0s--;
            counter++;
        }
        while (numOf1s > 0)
        {
            nums[counter] = 1;
            numOf1s--;
            counter++;
        }
        while (numOf2s > 0)
        {
            nums[counter] = 2;
            numOf2s--;
            counter++;
        }
    }
}