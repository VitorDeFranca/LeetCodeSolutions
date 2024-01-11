// Source : https://leetcode.com/problems/reverse-integer/
// Author : Vitor França
// Date   : Dec 19, 2023

/********************************************************************************** 
* 
* Reverse digits of an integer.
* 
* Example1: x =  123, return  321
* Example2: x = -123, return -321
* 
*               
**********************************************************************************/

public class Solution {
    public int Reverse(int x) {

        if (x == 0)
        {
            return 0;
        }

        StringBuilder intNormal = new StringBuilder(x.ToString());
        StringBuilder intReversed = new StringBuilder();
        char aux = intNormal[intNormal.Length - 1];



        if (intNormal[0] == '-')
        {
            intReversed = intReversed.Append('-');
            intNormal = intNormal.Remove(0, 1);
        }

        while (aux == '0')
        {
            intNormal = intNormal.Remove(intNormal.Length - 1, 1);
            aux = intNormal[intNormal.Length - 1];
        }

        while (intNormal.Length > 0)
        {
            intReversed.Append(aux);
            intNormal = intNormal.Remove(intNormal.Length - 1, 1);

            if (intNormal.Length != 0)
            {
                aux = intNormal[intNormal.Length - 1];
            }
        }

        long reversed = Convert.ToInt64(intReversed.ToString());

        if (reversed > 2147483647 || reversed < -2147483648 || reversed == 0)
        {
            return 0;
        }

        return Convert.ToInt32(intReversed.ToString());               
    }
}