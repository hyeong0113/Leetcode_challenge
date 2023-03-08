public class Solution {
    /*
    * @title: Return a true for valid anagram or false for invalid anagram
    * @precondition: Two strings should be provided
    * @postcondition: Return a boolean value
    * @description:
    *             If length of s and t (two string inputs) are different, returh false.
    *             Create 26 length integer array to store an occurance of characters in s and t.
    *             During the first for loop, increase the occurance of characters in s.
    *             During the second for loop, decrease the occurance if a character in t exist in s.
    *               If not, increase the occurance.
    *             During the last for loop, add all values in integer array to result(integer variable).
    *             If the result is 0, return true.
    *             If not, return false.
    * @param:
    *         m: int
    *         n: int
    * @return:
    *         int
    * @time complexity:
    *         O(mn): since traversing all elements in the board.
    * @space complexity:
    *         O(mn): since creating the board with m and n.
    */   
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        int[] alphabets = new int[26];

        for(int i = 0; i < s.Length; i++)
        {
            alphabets[s[i]-'a']++;
        }
        for(int i = 0; i < t.Length; i++)
        {
            if(0 < alphabets[t[i]-'a'])
            {
                alphabets[t[i]-'a']--;
            }
            else
            {
                alphabets[t[i]-'a']++;
            }
        }

        int result = 0;
        for(int i = 0; i < alphabets.Length; i++)
        {
            result += alphabets[i];
        }

        if(result == 0)
        {
            return true;
        }

        return false;
    }
}