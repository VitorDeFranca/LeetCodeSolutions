// Source : https://leetcode.com/problems/plus-one/
// Author : Vitor França
// Date   : Mar 22, 2024

/********************************************************************************** 
* 
* Given a non-negative number represented as an array of digits, plus one to the number.
* 
* The digits are stored such that the most significant digit is at the head of the list.
*                
**********************************************************************************/
public class Solution {
    public int[] PlusOne(int[] digits)
    {
        int lastIndex = digits.Length - 1;

        while (lastIndex > -1 && digits[lastIndex] + 1 > 9)
        {
            digits[lastIndex] = 0;
            lastIndex--;
        }

        if (lastIndex == -1)
        {
            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            for (int i = 1; i < digits.Length; i++)
            {
                newDigits[i] = digits[i];
            }
            digits = newDigits;

        }
        else
        {
            digits[lastIndex]++;
        }


        return digits;
    }
}