// Source : https://leetcode.com/problems/valid-parentheses/
// Author : Vitor França
// Date   : Dec 21, 2023

/********************************************************************************** 
* 
* Given a string containing just the characters '(', ')', '{', '}', '[' and ']', 
* determine if the input string is valid.
* 
* The brackets must close in the correct order, "()" and "()[]{}" are all valid 
* but "(]" and "([)]" are not.
* 
*               
**********************************************************************************/

public class Solution {
    public bool IsValid(string s) {

        if (s.Length % 2 == 1) return false;

        char[] cs = s.Replace(" ", "").ToCharArray();
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < cs.Length; i++)
        {
            if ((int)cs[i] == 40 || (int)cs[i] == 91 || (int)cs[i] == 123)
            {
                stack.Push(cs[i]);
            }
            else
            {
                if (stack.Count == 0) return false;


                if ((int)stack.Peek() == 40)
                {
                    if ((int)cs[i] != ((int)stack.Peek() + 1)) return false;
                }
                if ((int)stack.Peek() == 91 || (int)stack.Peek() == 123)
                {
                    if ((int)cs[i] != ((int)stack.Peek() + 2)) return false;
                }
                stack.Pop(); 
            }
        }
        return stack.Count == 0;    
    }
}