// Source : https://leetcode.com/problems/roman-to-integer/
// Author : Vitor França
// Date   : Feb 9, 2024

/********************************************************************************** 
* Given a roman numeral, convert it to an integer.
* 
* Input is guaranteed to be within the range from 1 to 3999.              
**********************************************************************************/

public class Solution {
    public int RomanToInt(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        Dictionary<char, int> romanDict = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        var pointer = s.Length - 1;
        int romanInt = romanDict[s[pointer]];

        while (pointer > 0)
        {
            if (romanDict[s[pointer - 1]] < romanDict[s[pointer]])
            {
                romanInt = romanInt - romanDict[s[pointer - 1]];
            }
            else
            {
                romanInt = romanInt + romanDict[s[pointer - 1]];
            }

            pointer--;
        }

        return romanInt;
    }
}