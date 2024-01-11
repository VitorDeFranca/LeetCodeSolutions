// Source : https://leetcode.com/problems/string-to-integer-atoi/
// Author : Vitor França
// Date   : Dec 20, 2023

/********************************************************************************** 
* 
* Implement atoi to convert a string to an integer (similar to C/C++'s atoi function).
* 
* Requirements for atoi:
* 
* The function first discards as many whitespace characters as necessary until the first 
* non-whitespace character is found. Then, starting from this character, takes an optional 
* initial plus or minus sign followed by as many numerical digits as possible, and interprets 
* them as a numerical value.
* 
* The string can contain additional characters after those that form the integral number, 
* which are ignored and have no effect on the behavior of this function.
* 
* If the first sequence of non-whitespace characters in str is not a valid integral number, 
* or if no such sequence exists because either str is empty or it contains only whitespace 
* characters, no conversion is performed.
* 
* If no valid conversion could be performed, a zero value is returned. If the correct value 
* is out of the range of representable values, INT_MAX (2147483647) or INT_MIN (-2147483648) 
* is returned.
*               
**********************************************************************************/

public class Solution {
    public int MyAtoi(string s) {

        if (s.Length > 200 || String.IsNullOrEmpty(s)) return 0;
        int res;

        StringBuilder sb = new StringBuilder(s);

        while (sb[0] == ' ')
        {
            sb.Remove(0, 1);
            if (String.IsNullOrEmpty(sb.ToString())) return 0;
        }   

        if (!Char.IsDigit(sb[0]))
        {
            if (sb[0] != '-' && sb[0] != '+')
            {
                return 0;
            } 

            if (sb.Length < 2)
            {
                return 0;
            }

            if (!Char.IsDigit(sb[1]))
            {
                return 0;
            }

            if (sb[0] == '+')
            {
                sb.Remove(0, 1);

            }
        }

        for (int i = 1; i < sb.Length; i++)
        {
            if (!Char.IsDigit(sb[i]))
            {
                sb.Remove(i, (sb.Length - i));
                 
            }
        }

        try
        {
            res = Convert.ToInt32(sb.ToString());
        }
        catch
        {
            if (sb[0] == '-')
            {
                res = -2147483648;

            }
            else
            {
                res = 2147483647;
            }

        }

        return res;
    }
}