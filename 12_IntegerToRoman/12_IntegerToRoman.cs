// Source : https://leetcode.com/problems/integer-to-roman/
// Author : Vitor França
// Date   : Feb 19, 2024

/********************************************************************************** 
* Given an integer, convert it to a roman numeral.
* 
* Input is guaranteed to be within the range from 1 to 3999.           
**********************************************************************************/

public class Solution {
    public int RomanToInt(string s)
    {
        if (num == 0) return "";

        Dictionary<string, int> romanDict = new Dictionary<string, int>()
        {
            {"I", 1},
            {"IV", 4},
            {"V", 5},
            {"IX", 9},
            {"X", 10},
            {"XL", 40},
            {"L", 50},
            {"XC", 90},
            {"C", 100},
            {"CD", 400},
            {"D", 500},
            {"CM", 900},
            {"M", 1000},
        };
        StringBuilder romanNum = new StringBuilder();

        for (int i = romanDict.Count - 1; i >= 0; i--)
        {
            if (num > 0)
            {
                while (num >= romanDict.ElementAt(i).Value)
                {
                    romanNum.Append(romanDict.ElementAt(i).Key);
                    num = num - romanDict.ElementAt(i).Value;
                }
            }
        }

        return romanNum.ToString(); 
    }
}