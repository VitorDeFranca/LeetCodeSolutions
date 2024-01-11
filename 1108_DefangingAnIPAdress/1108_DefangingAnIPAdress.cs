// Source : https://leetcode.com/problems/defanging-an-ip-address/
// Author : Vitor França
// Date   : Aug 9, 2023

/********************************************************************************** 
* 
* Given a valid (IPv4) IP address, return a defanged version of that IP address.
*
* A defanged IP address replaces every period "." with "[.]".
* 
*               
**********************************************************************************/
public class Solution 
{
    public string DefangIPaddr(string address)
    {
        return address.Replace(".", "[.]");
    }
}


