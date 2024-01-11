// Source : https://leetcode.com/problems/palindrome-number/
// Author : Vitor França
// Date   : Dec 13, 2023

/********************************************************************************** 
* 
* Given an integer x, return true if x is a palindrome, and false otherwise.
*               
**********************************************************************************/

public class Solution {
    public bool IsPalindrome(int x) {
        string stringNum = x.ToString();
        StringBuilder stringNumReversed = new StringBuilder();
        int aux = stringNum.Length - 1;

        while (aux >= 0)
        {
            stringNumReversed.Append(stringNum[aux]);
            aux--;
        }

        return stringNum.Equals(stringNumReversed.ToString());
    }
}