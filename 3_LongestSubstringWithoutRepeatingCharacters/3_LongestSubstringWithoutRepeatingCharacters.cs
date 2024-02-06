// Source : https://leetcode.com/problems/longest-substring-without-repeating-characters/
// Author : Vitor França
// Date   : Feb 6, 2024

/********************************************************************************** 
* 
* Given a string, find the length of the longest substring without repeating characters. 
* For example, the longest substring without repeating letters for "abcabcbb" is "abc", 
* which the length is 3. For "bbbbb" the longest substring is "b", with the length of 1.
*               
**********************************************************************************/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int ponteiroComeco = 0;
        int ponteiroFim = 0;
        int max = 0;

        HashSet<char> hashSet = new HashSet<char>();

        while (ponteiroFim < s.Length)
        {
            if (!hashSet.Contains(s[ponteiroFim]))
            {
                hashSet.Add(s[ponteiroFim]);
                ponteiroFim++;
                if (hashSet.Count() > max) 
                    max = hashSet.Count();
            }
            else
            {
                hashSet.Remove(s[ponteiroComeco]);
                ponteiroComeco++;
            }
        }

        return max;
    }
}