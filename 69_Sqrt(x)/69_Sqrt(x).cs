// Source : https://leetcode.com/problems/sqrtx/
// Author : Vitor França
// Date   : Mar 25, 2024

/********************************************************************************** 
* 
* Implement int sqrt(int x).
* 
* Compute and return the square root of x.
*                
**********************************************************************************/
public class Solution {
    public int MySqrt(int x)
    {
        if (x == 0) return 0;

        uint num = (uint)x;
        uint midElem = num + 1 / 2;

        for (uint i = 1; i <= midElem; i++)
        {
            if (i * i == num)
            {
                return (int)i;
            }
            else if (i * i > num)
            {
                return (int)i - 1;
            }

        }

        return 1;
    }
}