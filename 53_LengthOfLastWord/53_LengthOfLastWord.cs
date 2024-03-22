// Source : https://leetcode.com/problems/length-of-last-word/
// Author : Vitor França
// Date   : Mar 22, 2024

/********************************************************************************** 
* 
* Given a string s consists of upper/lower-case alphabets and empty space characters ' ', 
* return the length of last word in the string.
* 
* If the last word does not exist, return 0.
* 
* Note: A word is defined as a character sequence consists of non-space characters only.
* 
* For example, 
* Given s = "Hello World",
* return 5.
*               
**********************************************************************************/
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int sizeOfLastWord = 0;
        var newS = s.TrimEnd();
        for (int i = newS.Length - 1; i >= 0; i--)
        {
            if (newS.Last() == ' ') return sizeOfLastWord;

            sizeOfLastWord++;
            newS = newS.Remove(newS.Length - 1, 1);
        }

        return sizeOfLastWord;
    }
}