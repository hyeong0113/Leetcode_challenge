public class Solution {
    /*
    * @title: Reverse string
    * @precondition: Input must be character array
    * @postcondition: Order of character is reversed
    * @description:
    *             Run for-loop with half of length of s(character array)
    *             Switch two opposite characters using tuple inside the for loop
    * @param:
    *         s: Character array
    * @return:
    *         void
    * @time complexity:
    *         O(n): since O(n/2) and O(n) have the same growth rate
    * @space complexity:
    *         O(1): for using tuple
    */

    public void ReverseString(char[] s) {
        for(int i = 0; i < s.Length/2; i++)
        {
            // char temp = s[i];
            // s[i] = s[s.Length - i - 1];
            // s[s.Length - i - 1] = temp;
            (s[i], s[s.Length - i - 1]) = (s[s.Length - i - 1], s[i]);
        }
    }
}